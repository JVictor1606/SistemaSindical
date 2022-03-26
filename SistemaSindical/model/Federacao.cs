using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSindical.model
{
    public class Federacao
    {
        public Int64 id   { get; set; }
        public string nome { get; set; }  
        public string estado { get; set; } 
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
    }
}
