using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDALC;
namespace BibliotecaClase
{


    public class ContratoTraducido
    {

        public string _numero { get; set; }
        public DateTime _creacion { get; set; }
        public DateTime _termino { get; set; }
        public string RutCliente { get; set; }
        public string idModalidadTradu { get; set; }
        public string idTipoEventoTradu { get; set; }
        public DateTime _fechahorainicio { get; set; }
        public DateTime _fechahoratermino { get; set; }
        public int asistentes { get; set; }
        public int personalAdicional { get; set; }
        public bool Realizado { get; set; }

        public float ValorTotalContrato { get; set; }
        public string Observaciones { get; set; }
        public ContratoTraducido()
        {

        }

    }
}

