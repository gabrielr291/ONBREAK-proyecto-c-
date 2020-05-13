using BibliotecaDALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{
    public class Cliente
    {
        private string rut;
        private string razon_social;
        private string nom_contacto;
        private string correo;
        private string direccion;
        private string telefono;
        public int idActividadEmpresa { get; set; }
        public int IdTipoEmpresa { get; set; }


        public override string ToString()
        {
            return this.rut;
        }
        ///y aqui tenemos 
        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Telefono no puede estar en blanco");
                }
                else
                {

                    telefono = value;
                }
            }
        }
        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Direccion no puede estar en blanco");
                }
                else
                {

                    direccion = value;
                }
            }
        }
        public string Correo
        {
            get { return correo; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Correo no puede estar en blanco");
                }
                else
                {

                    correo = value;
                }
            }
        }
        public string Nom_contacto
        {
            get { return nom_contacto; }
            set
            {
                if (value == null)
                {

                    throw new ArgumentException("El nombre no puede estar en blanco");
                }
                else
                {

                    nom_contacto = value;
                }

            }
        }
        public string Razon_social
        {
            get { return razon_social; }
            set
            {
                if (value == null)
                {

                    throw new ArgumentException("Razon Social no puede estar en blanco");
                }
                else
                {
                    razon_social = value;
                }
            }
        }
        public string Rut
        {
            get { return rut; }
            set
            {
                if (value == null)
                {

                    throw new ArgumentException("El rut no puede estar en blanco");
                }
                else //estas reglas de negocio la vamos a poner en la vista  if txt
                {
                    rut = value;

                }
            }
        }
        public static List<BibliotecaClase.Cliente> clientes;
        //Declaramos y construimos
        private OnBreakEntities bdd = new OnBreakEntities();
        public Cliente()
        {
            if (clientes == null)
            {
                clientes = new List<BibliotecaClase.Cliente>();
            }
        }
        // Metodos muy metodicos
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
            catch (Exception ex)
            {
                Console.WriteLine("Error al magregar: "+ex.Message);
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
                bdd.SaveChanges();
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
               
                var x = bdd.Cliente.ToList().First(e =>e.RutCliente.Equals(client.rut));
                x.MailContacto = client.Correo;
                x.RazonSocial = client.Razon_social;
                x.NombreContacto = client.Nom_contacto;
                x.Telefono = client.Telefono;
                x.Direccion = client.Direccion;
                x.IdActividadEmpresa = client.idActividadEmpresa;
                x.IdTipoEmpresa = client.IdTipoEmpresa;

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

                BibliotecaDALC.Cliente cli = 
                    bdd.Cliente.First(e=>e.RutCliente.Equals(rutCliente));

                Cliente c = new Cliente();
                

                      var x = new Cliente
                        {
                            Rut = cli.RutCliente,
                            Correo = cli.MailContacto,
                            Razon_social = cli.RazonSocial,
                            Nom_contacto = cli.NombreContacto,
                            Telefono = cli.Telefono,
                            Direccion = cli.Direccion,
                            idActividadEmpresa = cli.IdActividadEmpresa,
                            IdTipoEmpresa = cli.IdTipoEmpresa
                        };

                return x;
            }
            catch (Exception)
            {

                throw;
            }
        }//revisar
        public List<Cliente> BuscarListado(string rutCliente)
        {
            try
            {
                BibliotecaClase.Cliente cli = new BibliotecaClase.Cliente();
                BibliotecaDALC.Cliente clio = bdd.Cliente.Find(rutCliente);
                List<Cliente> misclientes = new List<Cliente>();
                cli.Rut = clio.RutCliente;
                cli.Correo = clio.MailContacto;
                cli.Razon_social = clio.RazonSocial;
                cli.Nom_contacto = clio.NombreContacto;
                cli.Telefono = clio.Telefono;
                cli.Direccion = clio.Direccion;
                cli.idActividadEmpresa = clio.IdActividadEmpresa;
                cli.IdTipoEmpresa = clio.IdTipoEmpresa;
                misclientes.Add(cli);
                return misclientes;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<ListaCompleta> ReadAll()
        {

            var listarTodo = from cli in bdd.Cliente
                             join ti in bdd.ActividadEmpresa
                             on cli.IdActividadEmpresa equals ti.IdActividadEmpresa
                             join Tipa in bdd.TipoEmpresa
                             on cli.IdTipoEmpresa equals Tipa.IdTipoEmpresa
                             select new ListaCompleta
                             {
                                 rut = cli.RutCliente,
                                 razon_social = cli.RazonSocial,
                                 nom_contacto = cli.NombreContacto,
                                 correo = cli.MailContacto,
                                 direccion = cli.Direccion,
                                 telefono = cli.Telefono,
                                 desActEMP = ti.Descripcion,
                                 descTEMP = Tipa.Descripcion
                             };
            return listarTodo.ToList();
        }

        public List<ListaCompleta> ReadAllxEmpre(int idtipo)
        {
            var listaXtipoEmpresa = from cli in bdd.Cliente
                                join ti in bdd.ActividadEmpresa
                                on cli.IdActividadEmpresa equals ti.IdActividadEmpresa
                                join Tipa in bdd.TipoEmpresa
                                on cli.IdTipoEmpresa equals Tipa.IdTipoEmpresa
                                where cli.IdActividadEmpresa.Equals(idtipo)
                                select new ListaCompleta
                                {
                                    rut = cli.RutCliente,
                                    razon_social = cli.RazonSocial,
                                    nom_contacto = cli.NombreContacto,
                                    correo=cli.MailContacto,
                                    direccion = cli.Direccion,
                                    telefono = Telefono,
                                    desActEMP = ti.Descripcion,
                                    descTEMP = Tipa.Descripcion
                                };
                                return listaXtipoEmpresa.ToList();
                                } 
        public List<ListaCompleta> ReadAllxAct(int idAct)
        {
            var listaXtipoEmpresa = from cli in bdd.Cliente
                                    join ti in bdd.ActividadEmpresa
                                    on cli.IdActividadEmpresa equals ti.IdActividadEmpresa
                                    join Tipa in bdd.TipoEmpresa
                                    on cli.IdTipoEmpresa equals Tipa.IdTipoEmpresa
                                    where cli.IdActividadEmpresa.Equals(idAct)
                                    select new ListaCompleta
                                    {
                                        rut = cli.RutCliente,
                                        razon_social = cli.RazonSocial,
                                        nom_contacto = cli.NombreContacto,
                                        correo = cli.MailContacto,
                                        direccion = cli.Direccion,
                                        telefono = Telefono,
                                        desActEMP = ti.Descripcion,
                                        descTEMP = Tipa.Descripcion
                                    };
            return listaXtipoEmpresa.ToList();
        }// Revisar 
        public List<ListaCompleta> ReadAllxRut(String rut)
        {
            var listaXtipoEmpresa = from cli in bdd.Cliente
                                    join ti in bdd.ActividadEmpresa
                                    on cli.IdActividadEmpresa equals ti.IdActividadEmpresa
                                    join Tipa in bdd.TipoEmpresa
                                    on cli.IdTipoEmpresa equals Tipa.IdTipoEmpresa
                                    where cli.RutCliente.Equals(rut)
                                    select new ListaCompleta
                                    {
                                        rut = cli.RutCliente,
                                        razon_social = cli.RazonSocial,
                                        nom_contacto = cli.NombreContacto,
                                        correo = cli.MailContacto,
                                        direccion = cli.Direccion,
                                        telefono = Telefono,
                                        desActEMP = ti.Descripcion,
                                        descTEMP = Tipa.Descripcion
                                    };
            return listaXtipoEmpresa.ToList();
        }// Revisar 
        public BibliotecaClase.Cliente Buscar1(string rutCliente)
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

                return null;
            }
        }

    }

}
