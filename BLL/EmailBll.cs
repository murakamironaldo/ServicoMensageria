using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using CrossCutting;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace BLL
{
    public class EmailBll
    {
        public bool Enviar(string paraEmail, string paraNome, string assunto, string mensagem)
        {

            var configBll = new ConfiguracaoBll();
            var variaveis = configBll.Carregar("smtp");
            var remetenteNome = variaveis.FirstOrDefault(m => m.Variavel == "smtp.remetente.nome")?.Valor;
            var remetenteEmail = variaveis.FirstOrDefault(m => m.Variavel == "smtp.remetente.email")?.Valor;
            var host =  variaveis.FirstOrDefault(m => m.Variavel == "smtp.host")?.Valor;
            var senha = variaveis.FirstOrDefault(m => m.Variavel == "smtp.senha")?.Valor;
            var porta = variaveis.FirstOrDefault(m => m.Variavel == "smtp.porta")?.Valor;
            var ssl = variaveis.FirstOrDefault(m => m.Variavel == "smtp.ssl")?.Valor;
            ServicePointManager
                    .ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
            


            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(remetenteNome, remetenteEmail));
            email.To.Add(new MailboxAddress(paraNome, paraEmail));
            email.Subject = assunto;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = mensagem
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect(host, int.Parse(porta), ssl=="true");
                // Note: only needed if the SMTP server requires authenticatio;
                smtp.Authenticate(remetenteEmail, senha);
                smtp.Send(email);
                smtp.Disconnect(true);
                

            }
           
            return true;
        }



        private static bool ValidateCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // Implement your custom certificate validation logic here
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                // Certificate is valid
                return true;
            }
            else
            {
                // Certificate validation failed, handle the error or log it
                Console.WriteLine($"Certificate error: {sslPolicyErrors}");
                return false;
            }
        }
    }
}
