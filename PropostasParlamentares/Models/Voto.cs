using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropostasParlamentares.Models
{
    public class Voto
    {
        public int id { get; set; }
        public int id_votacao { get; set; }
        
        public int id_votante { get; set; }

        public int bc_transacao { get; set; }

        public DateTime dt_criacao { get; set; }


    }
}
