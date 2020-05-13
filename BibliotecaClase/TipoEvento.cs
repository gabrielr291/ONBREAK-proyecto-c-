using BibliotecaDALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class TipoEvento
    {
        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }
        
        public List<BibliotecaClase.TipoEvento> TipoEventos = new List<BibliotecaClase.TipoEvento>();
        private OnBreakEntities bdd = new OnBreakEntities();
        public TipoEvento()
        {

        }
        public List<BibliotecaClase.TipoEvento> listarTiposEventos()
        {
            var listabdd = bdd.TipoEvento.ToList();
            foreach (BibliotecaDALC.TipoEvento item in listabdd)
            {
                BibliotecaClase.TipoEvento evento = new BibliotecaClase.TipoEvento();
                evento.IdTipoEvento = item.IdTipoEvento;
                evento.Descripcion = item.Descripcion;
                TipoEventos.Add(evento);

            }
            return TipoEventos;
        }

        public override string ToString()
        {
            return this.Descripcion;
        }






    }
}
