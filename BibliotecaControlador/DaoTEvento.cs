using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClase;
using BibliotecaDALC;
namespace BibliotecaControlador
{
    public class DaoTEvento
    {
        public List<BibliotecaClase.TipoEvento> TipoEventos = new List<BibliotecaClase.TipoEvento>();
        private OnBreakEntities bdd = new OnBreakEntities();
        public DaoTEvento()
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



    }
}
