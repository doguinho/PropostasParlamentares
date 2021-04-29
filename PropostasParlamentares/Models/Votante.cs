using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropostasParlamentares.Models
{
    [Table("votante")]
    public class Votante
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        [Column("bc_address")]
        public String bc_address { get; set; }
    }
}
