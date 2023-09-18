using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("tbMensageria")]
    public class Mensageria
    {
        [Column("codMensageria"), Key]
        public int CodMensageria{get;set;}
        [Column("destino")]
        public string Destino { get; set; }
        [Column("titulo")]
        public string Titulo { get; set; }
        [Column("msg")]
        public string Mensagem { get; set; }
        [Column("flg")]
        public int Flg { get; set; }
    }
}
