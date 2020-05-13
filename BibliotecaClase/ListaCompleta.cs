using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class ListaCompleta
    {
        public string rut { get; set; }
        public string razon_social { get; set; }
        public string nom_contacto { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string desActEMP { get; set; }
        public string descTEMP { get; set; }


        public ListaCompleta()
        {

        }
        public override string ToString()
        {
            return rut;
        }

     
       
    }
}

