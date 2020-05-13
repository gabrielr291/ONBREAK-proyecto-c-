using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClase;
using BibliotecaDALC;
namespace BibliotecaControlador
{
    public class DaoModalidad
    {
        public static List<BibliotecaClase.ModalidadServicio> eventos;
        private OnBreakEntities bdd = new OnBreakEntities();
        public DaoModalidad()
        {
            {
                if (eventos == null)
                {
                    eventos = new List<BibliotecaClase.ModalidadServicio>();
                }
            }
        }
        public List<BibliotecaClase.ModalidadServicio> listarEve()
        {

            var listabdd = bdd.ModalidadServicio.ToList();
            foreach (BibliotecaDALC.ModalidadServicio item in listabdd)
            {
                BibliotecaClase.ModalidadServicio modalidad = new BibliotecaClase.ModalidadServicio();
                modalidad.IdModalidad = item.IdModalidad;
                modalidad.IdTipoEvento = item.IdTipoEvento;
                modalidad.Nombre = item.Nombre;
                modalidad.ValorBase = item.ValorBase;
                modalidad.PersonalBase = item.PersonalBase;
                eventos.Add(modalidad);
            }
            return eventos;

        }

        public bool AgregarModalidad(BibliotecaClase.ModalidadServicio itemo)
        {
            try
            {
                BibliotecaDALC.ModalidadServicio eve = new BibliotecaDALC.ModalidadServicio();
                eve.IdModalidad = itemo.IdModalidad;
                eve.IdTipoEvento = itemo.IdTipoEvento;
                eve.Nombre = itemo.Nombre;
                eve.ValorBase = itemo.ValorBase;
                eve.PersonalBase = itemo.PersonalBase;
                bdd.ModalidadServicio.Add(eve);
                bdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public bool Eliminar(string id)
        {

            try
            {
                BibliotecaDALC.ModalidadServicio moda = bdd.ModalidadServicio.Find(id);
                bdd.ModalidadServicio.Remove(moda);

                return true;
            }
            catch (Exception)
            {


                throw;
            }
        }

        public bool Actualizar(BibliotecaClase.ModalidadServicio moda)
        {

            try
            {
                BibliotecaDALC.ModalidadServicio mod = bdd.ModalidadServicio.Find(moda.IdModalidad);
                mod.IdModalidad = moda.IdModalidad;
                mod.IdTipoEvento = moda.IdTipoEvento;
                mod.Nombre = moda.Nombre;
                mod.ValorBase = moda.ValorBase;
                mod.PersonalBase = moda.PersonalBase;
                bdd.ModalidadServicio.Remove(mod);
                bdd.ModalidadServicio.Add(mod);

                return true;
            }
            catch (Exception)
            {


                throw;
            }

        }

        public BibliotecaClase.ModalidadServicio Buscar(string IdModalidad)
        {
            try
            {
                BibliotecaClase.ModalidadServicio eve = new BibliotecaClase.ModalidadServicio();
                BibliotecaDALC.ModalidadServicio itemo = bdd.ModalidadServicio.Find(IdModalidad);
                eve.IdModalidad = itemo.IdModalidad;
                eve.IdTipoEvento = itemo.IdTipoEvento;
                eve.Nombre = itemo.Nombre;
                eve.ValorBase = itemo.ValorBase;
                eve.PersonalBase = itemo.PersonalBase;

                return eve;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}