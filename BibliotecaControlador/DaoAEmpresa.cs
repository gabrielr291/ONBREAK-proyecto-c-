using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClase;
using BibliotecaDALC;
namespace BibliotecaControlador
{
    public class DaoAEmpresa
    {
        public List<BibliotecaClase.ActividadEmpresa> actEmpre = new List<BibliotecaClase.ActividadEmpresa>();
        private OnBreakEntities bdd = new OnBreakEntities();
        public DaoAEmpresa()
        {

        }
        public List<BibliotecaClase.ActividadEmpresa> listarTiposEventos()
        {
            var listabdd = bdd.ActividadEmpresa.ToList();
            foreach (BibliotecaDALC.ActividadEmpresa item in listabdd)
            {
                BibliotecaClase.ActividadEmpresa evento = new BibliotecaClase.ActividadEmpresa();
                evento.IdActividadEmpresa = item.IdActividadEmpresa;
                evento.Descripcion = item.Descripcion;
                actEmpre.Add(evento);

            }
            return actEmpre;
        }



    }
}
