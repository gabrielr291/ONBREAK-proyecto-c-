using BibliotecaDALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class TipoEmpresa
    {
        public int IdTipoEmpresa { get; set; }
        public string Descripcion { get; set; }
        public TipoEmpresa()
        {
            if (TipoEventos==null)
            {
                TipoEventos = new List<TipoEmpresa>();

            }
        }
        public override string ToString()
        {
            return this.Descripcion;
        }

        public static List<BibliotecaClase.TipoEmpresa> TipoEventos;
        private OnBreakEntities bdd = new OnBreakEntities();
        public List<BibliotecaClase.TipoEmpresa> ReadAll()
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
