using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropostasParlamentares.Models
{
    [Table("VOTANTE")]
    public class Votante
    {
        [Key]
        [Column("ID")]
        public int id { get; set; }
        [Column("BC_ADDRESS")]
        public String bc_address { get; set; }
    }
}
