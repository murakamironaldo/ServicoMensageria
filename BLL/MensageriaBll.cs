using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class MensageriaBll
    {
        public List<Mensageria> Listar()
        {

            var configBll = new ConfiguracaoBll();
            var variaveis = configBll.Carregar("smtp");
            _ = int.TryParse(variaveis.FirstOrDefault(m => m.Variavel == "smtp.quantidadeemails")?.Valor, out int quantidadeEmails);
            var contexto = new Contexto();
            var lista = contexto.Mensagerias.Where(m => m.Flg == 0).Take(quantidadeEmails);
            return lista.ToList();
        }


        public void Alterar(Mensageria obj)
        {
            var contexto = new Contexto();
            contexto.Update(obj);
            contexto.SaveChanges();
        }
    }
}
