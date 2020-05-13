using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClase;
using BibliotecaDALC;
namespace BibliotecaControlador
{
    public class DaoTEmpresa
    {
        public static List<BibliotecaClase.TipoEmpresa> TipoEventos;
        private OnBreakEntities bdd = new OnBreakEntities();
        public DaoTEmpresa()
        {

        }
        public List<BibliotecaClase.TipoEmpresa> listarTiposEventos()
        {
            var listabdd = bdd.TipoEmpresa.ToList();
            foreach (BibliotecaDALC.TipoEmpresa item in listabdd)
            {
                BibliotecaClase.TipoEmpresa evento = new BibliotecaClase.TipoEmpresa();
                evento.IdTipoEmpresa = item.IdTipoEmpresa;
                evento.Descripcion = item.Descripcion;
                TipoEventos.Add(evento);

            }
            return TipoEventos;
        }



    }
}
