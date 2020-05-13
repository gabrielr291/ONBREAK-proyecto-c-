using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClase;
using BibliotecaDALC;
namespace BibliotecaControlador
{
    public class DaoCliente
    {
        public static List<BibliotecaClase.Cliente> clientes;
        private OnBreakEntities bdd = new OnBreakEntities();
        public DaoCliente()
        {
            if (clientes == null)
            {
                clientes = new List<BibliotecaClase.Cliente>();
            }
        }

        public bool AgregarCliente(BibliotecaClase.Cliente clio)
        {
            try
            {
                BibliotecaDALC.Cliente cli = new BibliotecaDALC.Cliente();
                cli.RutCliente = clio.Rut;
                cli.MailContacto = clio.Correo;
                cli.RazonSocial = clio.Razon_social;
                cli.NombreContacto = clio.Nom_contacto;
                cli.Telefono = clio.Telefono;
                cli.Direccion = clio.Direccion;
                cli.IdActividadEmpresa = clio.idActividadEmpresa;
                cli.IdTipoEmpresa = clio.IdTipoEmpresa;
                bdd.Cliente.Add(cli);
                bdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        } //revisar

        private bool ExisteRut(string rut)
        {
            try
            {
                BibliotecaDALC.Cliente moda = bdd.Cliente.Find(rut);
                if (moda != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {


                throw;
            }
        }  //revisar

        public bool EliminarCliente(string rutCliente)
        {

            try
            {
                BibliotecaDALC.Cliente client = bdd.Cliente.Find(rutCliente);
                bdd.Cliente.Remove(client);

                return true;
            }
            catch (Exception)
            {


                throw;
            }
        } //revisar

        public bool ActualizarCliente(BibliotecaClase.Cliente client)
        {

            try
            {
                BibliotecaDALC.Cliente clie = bdd.Cliente.Find(client.Rut);
                bdd.Cliente.Remove(clie);
                BibliotecaDALC.Cliente cli = new BibliotecaDALC.Cliente();
                cli.RutCliente = client.Rut;
                cli.MailContacto = client.Correo;
                cli.RazonSocial = client.Razon_social;
                cli.NombreContacto = client.Nom_contacto;
                cli.Telefono = client.Telefono;
                cli.Direccion = client.Direccion;
                cli.IdActividadEmpresa = client.idActividadEmpresa;
                cli.IdTipoEmpresa = client.IdTipoEmpresa;
                bdd.Cliente.Add(cli);
                bdd.SaveChanges();

                return true;
            }
            catch (Exception)
            {


                throw;
            }

        } //revisar

        public BibliotecaClase.Cliente Buscar(string rutCliente)
        {
            try
            {
                BibliotecaClase.Cliente cli = new BibliotecaClase.Cliente();
                BibliotecaDALC.Cliente clio = bdd.Cliente.Find(rutCliente);

                cli.Rut = clio.RutCliente;
                cli.Correo = clio.MailContacto;
                cli.Razon_social = clio.RazonSocial;
                cli.Nom_contacto = clio.NombreContacto;
                cli.Telefono = clio.Telefono;
                cli.Direccion = clio.Direccion;
                cli.idActividadEmpresa = clio.IdActividadEmpresa;
                cli.IdTipoEmpresa = clio.IdTipoEmpresa;
                return cli;
            }
            catch (Exception)
            {

                throw;
            }
        }//revisar

        public List<BibliotecaClase.Cliente> listar()
        {

            var lista = bdd.Cliente.ToList();
            foreach (BibliotecaDALC.Cliente clio in lista)
            {
                BibliotecaClase.Cliente cli = new BibliotecaClase.Cliente();
                cli.Rut = clio.RutCliente;
                cli.Correo = clio.MailContacto;
                cli.Razon_social = clio.RazonSocial;
                cli.Nom_contacto = clio.NombreContacto;
                cli.Telefono = clio.Telefono;
                cli.Direccion = clio.Direccion;
                cli.idActividadEmpresa = clio.IdActividadEmpresa;
                cli.IdTipoEmpresa = clio.IdTipoEmpresa;
                clientes.Add(cli);

            }
            return clientes;

        } //revisar

        public List<BibliotecaClase.Cliente> BuscarPorTipo(String tipo)
        {

            var lista = bdd.Cliente.ToList();
            foreach (BibliotecaDALC.Cliente clio in lista)
            {
                BibliotecaClase.Cliente cli = new BibliotecaClase.Cliente();
                cli.Rut = clio.RutCliente;
                cli.Correo = clio.MailContacto;
                cli.Razon_social = clio.RazonSocial;
                cli.Nom_contacto = clio.NombreContacto;
                cli.Telefono = clio.Telefono;
                cli.Direccion = clio.Direccion;
                cli.idActividadEmpresa = clio.IdActividadEmpresa;
                cli.IdTipoEmpresa = clio.IdTipoEmpresa;
                clientes.Add(cli);

            }
            return clientes;
        } // Revisar si podemos usar un select simple

        public List<BibliotecaClase.Cliente> BuscarPorActiv(String act)
        {
            var lista = bdd.Cliente.ToList();
            foreach (BibliotecaDALC.Cliente clio in lista)
            {
                BibliotecaClase.Cliente cli = new BibliotecaClase.Cliente();
                cli.Rut = clio.RutCliente;
                cli.Correo = clio.MailContacto;
                cli.Razon_social = clio.RazonSocial;
                cli.Nom_contacto = clio.NombreContacto;
                cli.Telefono = clio.Telefono;
                cli.Direccion = clio.Direccion;
                cli.idActividadEmpresa = clio.IdActividadEmpresa;
                cli.IdTipoEmpresa = clio.IdTipoEmpresa;
                clientes.Add(cli);

            }
            return clientes;
        }// Revisar si podemos usar un select simple

        public List<BibliotecaClase.Cliente> BuscarPorRut(String rut)
        {
            var lista = bdd.Cliente.ToList();
            foreach (BibliotecaDALC.Cliente clio in lista)
            {
                BibliotecaClase.Cliente cli = new BibliotecaClase.Cliente();
                cli.Rut = clio.RutCliente;
                cli.Correo = clio.MailContacto;
                cli.Razon_social = clio.RazonSocial;
                cli.Nom_contacto = clio.NombreContacto;
                cli.Telefono = clio.Telefono;
                cli.Direccion = clio.Direccion;
                cli.idActividadEmpresa = clio.IdActividadEmpresa;
                cli.IdTipoEmpresa = clio.IdTipoEmpresa;
                clientes.Add(cli);

            }
            return clientes;
        }// Revisar si podemos usar un select simple




    }
}
