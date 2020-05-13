
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class ClValorUF
    {
        public static double uf;

        public ClValorUF()
        {

            Contrato con = new Contrato();
            uf = con.vauf();
        }

        public double obtener()
        {
            return uf;
        }
    }
}
