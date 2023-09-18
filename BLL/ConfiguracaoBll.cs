using DAL;
using Models;

namespace BLL
{
    public class ConfiguracaoBll
    {
        public List<Configuracao> Carregar(string variavel)
        {
            var contexto = new Contexto();
            var lista = contexto.Confirguracoes.Where(m => m.FlgStatus==1 && m.Variavel.Contains(variavel)).Take(20);
            return lista.ToList();
        }
    }
}
