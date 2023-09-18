using BLL;

namespace EnviarEmailMensageria
{
    public class Processamento
    {

        public static void Processar()
        {
            Console.Clear();
            Console.WriteLine("Data / Hora inicio processamento: " + DateTime.Now);
            var bll = new MensageriaBll();
            var lista = bll.Listar();

            var bllemail = new EmailBll();

            foreach (var obj in lista)
            {

                var retorno = bllemail.Enviar(obj.Destino, obj.Destino, obj.Titulo, obj.Mensagem);
                if (retorno)
                {
                    obj.Flg = 1;
                    bll.Alterar(obj);
                }

            }
            Console.WriteLine("Data / Hora fim processamento: " + DateTime.Now);

        }
    }
}
