using BibliotecaDALC;
using BibliotecaClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase
{

    public class Contrato
    {

        //Campos

        public string _numero { get; set; }
        public DateTime _creacion { get; set; }
        public DateTime _termino { get; set; }
        public string RutCliente { get; set; }
        public string idModalidad { get; set; }
        public int idTipoEvento { get; set; }
        public DateTime _fechahorainicio { get; set; }
        public DateTime _fechahoratermino { get; set; }
        public int asistentes { get; set; }
        public int personalAdicional { get; set; }
        public bool Realizado { get; set; }

        public float ValorTotalContrato { get; set; }
        public string Observaciones { get; set; }

        //Ahora empieza las cosas buenas
        public static List<BibliotecaClase.Contrato> contratos;
        private OnBreakEntities bdd = new OnBreakEntities();
        public double vauf()
        {
            try
            {
                ServiceReference1.Service1Client WS = new ServiceReference1.Service1Client();
                double uf = WS.Uf();
                bool vuf = Convert.ToBoolean(uf);
                return uf;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public Contrato()
        {
            if (contratos == null)
            {
                contratos = new List<BibliotecaClase.Contrato>();
            }
        }
        // Metodos para AUTORELLENADO
        public String numero()
        {
            String ncontrato = DateTime.Now.ToString("yyyyddMMHHmm");
            return ncontrato;
        }
        public String Inicio()
        {
            String ini = DateTime.Now.ToString("dd-MM-yyyy");
            return ini;
        }
        public String Termino()
        {
            DateTime ter = DateTime.Now;
            ter = ter.AddDays(1);
            string feter = ter.ToString("dd-MM-yyyy");
            return feter;
        }
        //metodos CRUD
        public List<Contrato> cliConContrato(String rut)
        {

            try
            {
                BibliotecaDALC.Cliente daocli = new BibliotecaDALC.Cliente();
                var x = from clio in bdd.Cliente
                        join co in bdd.Contrato
                        on clio.RutCliente equals co.RutCliente
                        where clio.RutCliente.Equals(rut)
                        select new Contrato()
                        {
                            _numero = co.Numero,
                            _creacion =co.Creacion,
                            _termino = co.Termino,
                            RutCliente= clio.RutCliente,
                            idModalidad = co.IdModalidad,
                            idTipoEvento = co.IdTipoEvento,
                            _fechahorainicio= co.FechaHoraInicio,
                            _fechahoratermino=co.FechaHoraTermino,
                            asistentes = co.Asistentes,
                            personalAdicional= co.PersonalAdicional,
                            Realizado = co.Realizado,
                            ValorTotalContrato = (float)co.ValorTotalContrato,
                            Observaciones= co.Observaciones

                                                 };
                return x.ToList();
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception x)
            {
                throw new ArgumentException(x.Message);
            }
        } //LISTO
        public bool AgregarContrato(BibliotecaClase.Contrato cont)
        {
            try
            {
                BibliotecaDALC.Contrato contra = new BibliotecaDALC.Contrato();
                contra.Numero = cont._numero;
                contra.Creacion = Convert.ToDateTime(cont._creacion); //estara bueno?
                contra.Termino = Convert.ToDateTime(cont._termino);
                contra.RutCliente = cont.RutCliente;
                contra.IdModalidad = cont.idModalidad;
                contra.IdTipoEvento = cont.idTipoEvento;
                contra.FechaHoraInicio = Convert.ToDateTime(cont._fechahorainicio);
                contra.FechaHoraTermino = Convert.ToDateTime(cont._fechahoratermino);
                contra.Asistentes = cont.asistentes;
                contra.PersonalAdicional = cont.personalAdicional;
                contra.Realizado = cont.Realizado;
                contra.ValorTotalContrato = cont.ValorTotalContrato;
                contra.Observaciones = cont.Observaciones;
                //contra.ModalidadServicio;
                bdd.Contrato.Add(contra);
                bdd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar contrato :" +ex.Message);
                throw;
            }
        } //No deberia tener problemas, puede que por los date time, pero no estoy seguro
        public bool DarDeBaja(BibliotecaClase.Contrato cont)
        {
            try
            {

                BibliotecaDALC.Contrato contra = bdd.Contrato.Find(cont._numero);
                bdd.Contrato.Remove(contra);
                bdd.SaveChanges();
                BibliotecaDALC.Contrato cli = new BibliotecaDALC.Contrato();
                contra.Numero = cont._numero;
                contra.Creacion = Convert.ToDateTime(cont._creacion); //estara bueno?
                contra.Termino = Convert.ToDateTime(cont._termino);
                contra.RutCliente = "" + cont.RutCliente;
                contra.IdModalidad = "" + cont.idModalidad;
                contra.IdTipoEvento = cont.idTipoEvento;
                contra.FechaHoraInicio = Convert.ToDateTime(cont._fechahorainicio);
                contra.FechaHoraTermino = Convert.ToDateTime(cont._fechahoratermino);
                contra.Asistentes = cont.asistentes;
                contra.PersonalAdicional = cont.personalAdicional;
                contra.Realizado = cont.Realizado == false ? true : false;
                contra.ValorTotalContrato = cont.ValorTotalContrato;
                contra.Observaciones = cont.Observaciones;
                bdd.Contrato.Add(contra);
                bdd.SaveChanges();

                return true;
            }
            catch (Exception)
            {


                throw;
            }
        }//dAR DE BAJA O UNA COSA SCOMO eLIMINAR, no se pu8ede eliminar un CONTRATO
        public bool ActualizarContrato(BibliotecaClase.Contrato cont)
        {

            try
            {

                BibliotecaDALC.Contrato contra = bdd.Contrato.Find(cont._numero);
                bdd.Contrato.Remove(contra);
                bdd.SaveChanges();
                BibliotecaDALC.Contrato cli = new BibliotecaDALC.Contrato();
                contra.Numero = cont._numero;
                contra.Creacion = Convert.ToDateTime(cont._creacion); //estara bueno?
                contra.Termino = Convert.ToDateTime(cont._termino);
                contra.RutCliente = "" + cont.RutCliente;
                contra.IdModalidad = "" + cont.idModalidad;
                contra.IdTipoEvento = cont.idTipoEvento;
                contra.FechaHoraInicio = Convert.ToDateTime(cont._fechahorainicio);
                contra.FechaHoraTermino = Convert.ToDateTime(cont._fechahoratermino);
                contra.Asistentes = cont.asistentes;
                contra.PersonalAdicional = cont.personalAdicional;
                contra.Realizado = cont.Realizado ;
                contra.ValorTotalContrato = cont.ValorTotalContrato;
                contra.Observaciones = cont.Observaciones;
                bdd.Contrato.Add(contra);
                bdd.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar contrato :" + ex.Message);
                throw;
            }

        } //esto en realidad no se usa, solo es para modificar peques datos
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
        public List<BibliotecaClase.Contrato> readAll()
        {

            var lista = bdd.Contrato.ToList();
            try
            {
                BibliotecaDALC.Contrato daocli = new BibliotecaDALC.Contrato();
                var x = bdd.Contrato.ToList();
                List<BibliotecaClase.Contrato> listaEntera = new List<BibliotecaClase.Contrato>();
                foreach (BibliotecaDALC.Contrato item in x)
                {
                    BibliotecaClase.Contrato contra = new BibliotecaClase.Contrato();
                    contra._numero = item.Numero;
                    contra._creacion = Convert.ToDateTime(item.Creacion); //estara bueno?
                    contra._termino = Convert.ToDateTime(item.Termino);
                    contra.RutCliente = item.RutCliente;
                    contra.idModalidad = item.IdModalidad;
                    contra.idTipoEvento = item.IdTipoEvento;
                    contra._fechahorainicio = Convert.ToDateTime(item.FechaHoraInicio);
                    contra._fechahoratermino = Convert.ToDateTime(item.FechaHoraTermino);
                    contra.asistentes = item.Asistentes;
                    contra.personalAdicional = item.PersonalAdicional;
                    contra.Realizado = item.Realizado;
                    contra.Observaciones = item.Observaciones;
                    contra.ValorTotalContrato = Convert.ToInt32(item.ValorTotalContrato) ;
                    listaEntera.Add(contra);
                }


                return listaEntera;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception x)
            {
                throw new ArgumentException(x.Message);
            }

        } //revisar
        public List<Contrato> ContratoByNumer(String numero)
        {

            try
            {
                var x = from clio in bdd.Cliente
                        join co in bdd.Contrato
                        on clio.RutCliente equals co.RutCliente
                        where co.Numero.Equals(numero)
                        select new Contrato()
                        {
                            _numero = co.Numero,
                            _creacion = co.Creacion,
                            _termino = co.Termino,
                            RutCliente = clio.RutCliente,
                            idModalidad = co.IdModalidad,
                            idTipoEvento = co.IdTipoEvento,
                            _fechahorainicio = co.FechaHoraInicio,
                            _fechahoratermino = co.FechaHoraTermino,
                            asistentes = co.Asistentes,
                            personalAdicional = co.PersonalAdicional,
                            Realizado = co.Realizado,
                            ValorTotalContrato = (float)co.ValorTotalContrato,
                            Observaciones = co.Observaciones

                        };
                return x.ToList();
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception x)
            {
                throw new ArgumentException(x.Message);
            }
        } //LISTO
        public List<Contrato> ContratoporTipoEve(int id) {
            try
            {

                var x = from clio in bdd.Cliente
                        join co in bdd.Contrato
                        on clio.RutCliente equals co.RutCliente
                        where co.IdTipoEvento==id
                        select new Contrato()
                        {
                            _numero = co.Numero,
                            _creacion = co.Creacion,
                            _termino = co.Termino,
                            RutCliente = clio.RutCliente,
                            idModalidad = co.IdModalidad,
                            idTipoEvento = co.IdTipoEvento,
                            _fechahorainicio = co.FechaHoraInicio,
                            _fechahoratermino = co.FechaHoraTermino,
                            asistentes = co.Asistentes,
                            personalAdicional = co.PersonalAdicional,
                            Realizado = co.Realizado,
                            ValorTotalContrato = (float)co.ValorTotalContrato,
                            Observaciones = co.Observaciones

                        };
                return x.ToList();
            }
            catch (Exception)
            {

                throw;
            }




        }
        public List<Contrato> ContratoPorModalidad(string id) {
            try
            {

                var x = from clio in bdd.Cliente
                        join co in bdd.Contrato
                        on clio.RutCliente equals co.RutCliente
                        where co.IdModalidad == id
                        select new Contrato()
                        {
                            _numero = co.Numero,
                            _creacion = co.Creacion,
                            _termino = co.Termino,
                            RutCliente = clio.RutCliente,
                            idModalidad = co.IdModalidad,
                            idTipoEvento = co.IdTipoEvento,
                            _fechahorainicio = co.FechaHoraInicio,
                            _fechahoratermino = co.FechaHoraTermino,
                            asistentes = co.Asistentes,
                            personalAdicional = co.PersonalAdicional,
                            Realizado = co.Realizado,
                            ValorTotalContrato = (float)co.ValorTotalContrato,
                            Observaciones = co.Observaciones

                        };
                return x.ToList();
            }
            catch (Exception)
            {

                throw;
            }






        }
        public override string ToString()
        {
            return this._numero;
        }
        public bool ExisteClienteConContrato(string rutito)
        {
            try
            {
                BibliotecaClase.Contrato conti = new Contrato();
                var x = bdd.Contrato.ToList();
                x = x.Where(y => y.RutCliente == rutito).ToList();
                //another choice 
                //var xx =  from bd in bdd.Contrato
                foreach (var item in x)
                {
                    conti.RutCliente = item.RutCliente;
                    conti._numero = item.Numero;
                    conti._creacion = item.Creacion;
                    conti._termino = item.Termino;
                    conti.idModalidad = item.IdModalidad;
                    conti.idTipoEvento = item.IdTipoEvento;
                    conti._fechahorainicio = item.FechaHoraInicio;
                    conti._fechahoratermino = item.FechaHoraTermino;
                    conti.asistentes = item.Asistentes;
                    conti.personalAdicional = item.PersonalAdicional;
                    conti.Realizado = item.Realizado;
                    conti.ValorTotalContrato = (float)item.ValorTotalContrato;
                    conti.Observaciones = item.Observaciones;


                }
                if (conti != null)
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
        }// hay que revisar por que no encuentra a nada, siendo que si existe algo >:C me enojo

    }
       
} 





