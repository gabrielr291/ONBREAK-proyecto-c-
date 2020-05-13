using BibliotecaDALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class ActividadEmpresa
    {
        public int IdActividadEmpresa { get; set; }
        public string Descripcion { get; set; }
       

        public List<BibliotecaClase.ActividadEmpresa> actEmpre = new List<BibliotecaClase.ActividadEmpresa>();
        private OnBreakEntities bdd = new OnBreakEntities();
        public ActividadEmpresa()
        {

        }
        public List<BibliotecaClase.ActividadEmpresa> ReadAll()
        {
            try
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
            catch (Exception)
            {
                return null;
               
            }
        }

    }
}
