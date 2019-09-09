using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Condominio
    {
        public int CondominioId { get; set; }
        public string Nome { get; set; }
        public int Blocos{ get; set; }
        public bool Ativo { get; set; }
        public Tipo Tipo { get; set; }
    }
}
