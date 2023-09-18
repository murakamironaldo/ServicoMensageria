using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Configuracoes")]
    public  class Configuracao
    {
        [Key]
        public string Variavel { get; set; }
        public string Valor { get; set; }
        public int FlgStatus { get; set; }
    }
}
