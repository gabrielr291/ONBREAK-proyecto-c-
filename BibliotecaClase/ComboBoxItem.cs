using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class ComboBoxItem
    {
        public int Value { get; set; }
        public String Texto { get; set; }

        public ComboBoxItem()
        {

        }
        public override string ToString()
        {
            return Texto;//se ve en el combo como texto
        }
    }
}