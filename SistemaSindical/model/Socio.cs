using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSindical.model
{
    public class Socio
    {
        public Int64 id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public DateTime dataNascimento { get; set; }
        public char sexo { get; set; }
        public string idSindicato { get; set; }
    }
}
