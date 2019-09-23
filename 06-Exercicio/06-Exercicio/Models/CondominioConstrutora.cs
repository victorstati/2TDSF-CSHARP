using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Exercicio.Models
{
    public class CondominioConstrutora
    {
        public Construtora Construtora { get; set; }
        public int ConstrutoraId { get; set; }
        public Condominio Condominio { get; set; }
        public int CondominioId { get; set; }
    }
}
