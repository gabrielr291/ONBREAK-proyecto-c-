using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class ListadoDeContratos
    {
        public string numContra { get; set; }
        public string creacion { get; set; }
        public string fechaInicio { get; set; }
        public string fechatermino { get; set; }
        public int asistente { get; set; }
        public string rutClien { get; set; }
        public int perAdicional { get; set; }
        public int total { get; set; }
        public string observa { get; set; }
        public ListadoDeContratos()
        {
        }
        public override string ToString()
        {
            return this.numContra;
        }
    }
}
