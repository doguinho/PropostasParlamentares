using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropostasParlamentares.Models
{
    public class Votacao
    {
        public int id { get; set; }
        public int id_propositura { get; set; }
        public int id_tipo_votacao { get; set; }
        public DateTime dt_inicio { get; set; }
        public DateTime dt_fim { get; set; }
        public DateTime dt_criacao { get; set; }
        public DateTime dt_alteracao { get; set; }
        public DateTime dt_exclusao { get; set; }

    }
}
