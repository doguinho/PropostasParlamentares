using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropostasParlamentares.Models
{
    [Table("VOTACAO")]
    public class Votacao
    {
        [Key]
        [Column("ID")]
        public int id { get; set; }
        [Column("ID_PROPOSITURA")]
        public int id_propositura { get; set; }
        [Column("ID_TIPO_VOTACAO")]
        public int id_tipo_votacao { get; set; }
        [Column("DT_INICIO")]
        public DateTime dt_inicio { get; set; }
        [Column("DT_FIM")]
        public DateTime dt_fim { get; set; }
        [Column("DT_CRIACAO")]
        public DateTime dt_criacao { get; set; }
        [Column("DT_ALTERACAO")]
        public DateTime dt_alteracao { get; set; }
        [Column("DT_EXCLUSAO")]
        public DateTime dt_exclusao { get; set; }

    }
}
