using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSindical.model
{
    public class Sindicato
    {
        public Int64 id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string municipio { get; set; }  
        public string email { get; set; }
        public string telefone { get; set; }
        public string idFederacao { get; set; }
        public Regionais regi { get; set; }
    }
}
