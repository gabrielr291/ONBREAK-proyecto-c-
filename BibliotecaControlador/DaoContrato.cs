using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClase;
using BibliotecaDALC;
namespace BibliotecaControlador
{
    public class DaoContrato
    { // REVISAR ENTERO
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

        public DaoContrato()
        {   
            if(contratos == null)
            {
                contratos = new List<BibliotecaClase.Contrato>();
            }
        }
        public List<ListaCompleta> cliConContrato(String rut)
        {

            try
            {
                BibliotecaDALC.Cliente daocli = new BibliotecaDALC.Cliente();
                DaoCliente dacli = new DaoCliente();
                var x = from cl in bdd.Cliente
                        join co in bdd.Contrato
                        on cl.RutCliente equals co.RutCliente
                        select new ListaCompleta()
                        {
                            rut = cl.RutCliente,
                            razon_social = cl.RazonSocial,
                            nom_contacto = cl.NombreContacto,
                            correo = cl.MailContacto,
                            direccion = cl.Direccion,
                            telefono = cl.Telefono
                        };
                return x.ToList();
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }catch(Exception x)
            {
                throw new ArgumentException(x.Message);
            }
        } //Deberia funcionar

        public bool AgregarContrato(BibliotecaClase.Contrato cont)
        {
            try
            {
                BibliotecaDALC.Contrato contra = new BibliotecaDALC.Contrato();
                contra.Numero = cont._numero;
                contra.Creacion = Convert.ToDateTime(cont._creacion); //estara bueno?
                contra.Termino = Convert.ToDateTime(cont._termino);
                contra.RutCliente = ""+cont.RutCliente;
                contra.IdModalidad = ""+cont.idModalidad;
                contra.IdTipoEvento = cont.idTipoEvento;
                contra.FechaHoraInicio = Convert.ToDateTime(cont._fechahorainicio);
                contra.FechaHoraTermino = Convert.ToDateTime(cont._fechahoratermino);
                contra.Asistentes = cont.asistentes;
                contra.PersonalAdicional = cont.personalAdicional;
                contra.Realizado = cont.Realizado;
                contra.ValorTotalContrato = ValorContrato(cont);
                bdd.Contrato.Add(contra);
                bdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        } //No deberia tener problemas, puede que por los date time, pero no estoy seguro



        public bool DarDeBaja(BibliotecaClase.Contrato cont)
        {


            try
            {

                BibliotecaDALC.Contrato contra = bdd.Contrato.Find(cont._numero);
                bdd.Contrato.Remove(contra);
                //BibliotecaDALC.Contrato cli = new BibliotecaDALC.Contrato();
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
                contra.Realizado = cont.Realizado == true ? false : true || cont.Realizado == false ? true : false;

                bdd.Contrato.Add(contra);
                bdd.SaveChanges();

                return true;
            }
            catch (Exception)
            {


                throw;
            }
        }//revisar

        public bool ActualizarContrato(BibliotecaClase.Contrato cont)
        {

            try
            {   

                BibliotecaDALC.Contrato contra = bdd.Contrato.Find(cont._numero);
                bdd.Contrato.Remove(contra);
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
                contra.Realizado = cont.Realizado;
                bdd.Contrato.Add(contra);
                bdd.SaveChanges();

                return true;
            }
            catch (Exception)
            {


                throw;
            }

        } //revisar aplicar ciertas reglas nene

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
        }//revisar y no creo que vaya

        public List<BibliotecaClase.Contrato> listar()
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
                    contra._creacion =""+item.Creacion; //estara bueno?
                    contra._termino = ""+item.Termino;
                    contra.RutCliente = Convert.ToInt16(item.RutCliente);
                    contra.idModalidad = Convert.ToInt16(item.IdModalidad);
                    contra.idTipoEvento = item.IdTipoEvento;
                    contra._fechahorainicio = ""+item.FechaHoraInicio;
                    contra._fechahoratermino = ""+item.FechaHoraTermino;
                    contra.asistentes = item.Asistentes;
                    contra.personalAdicional = item.PersonalAdicional;
                    contra.Realizado = item.Realizado;

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

      

    public int ValorContrato(BibliotecaClase.Contrato con)
        {
            int i = 0;
            int valor_evento = 0;
             double v_Nper = 0;//per uf cobradas
            double  v_perAdic = 0; //personal adic
            BibliotecaClase.ModalidadServicio ev = new BibliotecaClase.ModalidadServicio();
            var x = from c in bdd.Contrato 
                            join m in bdd.ModalidadServicio
                             on c.IdModalidad equals m.IdModalidad
                    select new ListMyC() {
                    valorBase = Convert.ToInt32(m.ValorBase)
                    }
                    ;
            int evolu = Convert.ToInt32(x.ToString());
            
            //TRYCATCH
            if (Convert.ToInt32(con.asistentes) >= 20)
            {
                v_Nper = 3;
            }
            if (Convert.ToInt32(con.asistentes) >= 21 && Convert.ToInt32(con.asistentes) < 50)
            {
                v_Nper = 5;
            }
            if (Convert.ToInt32(con.asistentes) > 50)
            {
                v_Nper = 5;
                for (i = 0; i < ((Convert.ToInt32(con.asistentes) - 50)/20); i++)
                {
                    v_Nper = v_Nper + 2 * i;
                }

            }

            switch ((int)v_perAdic)
            {
                case 2:
                    v_perAdic = 2;
                    break;

                case 3:
                    v_perAdic = 3;
                    break;
                case 4:
                    v_perAdic = 3.5;
                    break;
                default:
                    break;
            }
            if (v_perAdic > 4)
            {
                v_perAdic = 3.5 + (0.5 * (v_perAdic - 4));
            }


            valor_evento =Convert.ToInt32(ev.ValorBase)+ (int)((v_perAdic + v_Nper) * ClValorUF.uf);

            return valor_evento;
        } //esto posiblemente funcione
    }

    }


