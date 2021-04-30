using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropostasParlamentares.Models
{
    [Table("VOTO")]
    public class Voto
    {
        [Key]
        [Column("ID")]
        public int id { get; set; }
        [Column("ID_VOTACAO")]
        public int id_votacao { get; set; }
        [Column("ID_VOTANTE")]
        public int id_votante { get; set; }
        [Column("BC_TRANSACAO")]
        public int bc_transacao { get; set; }
        [Column("DT_CRIACAO")]
        public DateTime dt_criacao { get; set; }

    }
}
