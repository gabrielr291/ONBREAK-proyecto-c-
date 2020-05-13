﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BibliotecaClase;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using BibliotecaDALC;
using System.Windows.Threading;
using System.Runtime.Caching;
using System.IO;
namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para AgregarContrato.xaml
    /// </summary>
    public partial class AgregarContrato : MetroWindow
    {
        DispatcherTimer deptime = new DispatcherTimer();
        String rutaPathEx;
        private OnBreakEntities bdd = new OnBreakEntities();
        BibliotecaClase.Cliente supremo = new BibliotecaClase.Cliente();
        //crear objeto de tipo cache
        private ObjectCache cache = MemoryCache.Default;
        public AgregarContrato()
        {
            InitializeComponent();
            // esto esta oculto por que se activa con el check del local a convernir
            txtMontoLoCliente.Visibility = Visibility.Hidden;
            rutaPathEx = Directory.GetCurrentDirectory();
            rutaPathEx = rutaPathEx.Substring(0, rutaPathEx.Length - 9);
            BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
            txtContrato.Text = con.numero();
            txtFeIni.Text = con.Inicio();
            txtFeTer.Text = ""+con.Termino();
            txtCreacion.Text = "" + DateTime.Today.ToString("dd/MM/yyyy");
            DateTime ter = DateTime.Now;
            //inicializamos valores en ceromilcerocientoscero
            txtAsistentes.Text = "0";
            txtPerBase.Text = "0";
            txtMonto.Text = "0";
            txtPreBase.Text = "0";
            //termianmos de inicalizar
            ter = ter.AddDays(2);
            txtTermino.Text = "" + ter;
            llenarCbox();
            //deptime.Tick += new EventHandler();
            //agrega el uf al programa
            try
            {
                string UF = new datosUF().entregarUF(DateTime.Now.ToString("dd-MM-yyyy"));
                txtUF.Text = UF;
            }
            catch (Exception)
            {
                txtUF.Text = "24000";
            }
            //fin agregar uf
            chbAmbientacion.Visibility = Visibility.Hidden;
            chbAmbPers.Visibility = Visibility.Hidden;
            chbLoAConvenir.Visibility = Visibility.Hidden;
            chbLocalCliente.Visibility = Visibility.Hidden;
            chbLocalOnBreak.Visibility = Visibility.Hidden;
            chbMusica.Visibility = Visibility.Hidden;
            chbVegetariano.Visibility = Visibility.Hidden;
            txtMontoLoCliente.Visibility = Visibility.Hidden;
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }
        private void Volver(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String cont = "";
                if (txtContrato.Text != null)
                {
                    cont = txtContrato.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese el numero de contrato");
                }

                String crea = "";
                if (txtCreacion.Text!=null)
                {
                    crea = txtCreacion.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese la fecha de creacion del contrato");
                }

                String ter = "";
                if (txtTermino.Text!=null)
                {
                    ter = txtTermino.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese la fecha de termino del contrato");
                }

                String fein = "";
                if (txtFeIni.Text !=null)
                {
                    fein = txtFeIni.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese la fecha de inicio del evento");
                }

                String fete = "";
                if (txtFeTer.Text !=null)
                {
                    fete = txtFeTer.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese la fecha de termino del evento");
                }

               

                String total = "";
                if (txtMonto != null)
                {
                    total = txtMonto.Text;
                }

                String obs = "";
                if (txtObs !=null)
                {
                    obs = txtObs.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese una observacion");
                }

                String nom = "";
                if (txtNombre != null)
                {
                    nom = txtNombre.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese un nombre");
                }

                Valorizador valor = new Valorizador();
                double valorBass = ((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).ValorBase; //variable para valorizar
                string numero = txtContrato.Text; 
                DateTime _creacion = Convert.ToDateTime(txtCreacion.Text);
                DateTime _termino = Convert.ToDateTime(txtTermino.Text);

                string rutcli= cboRutAso.Text;
                var moda = (BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem;
                string idModalidad =moda.IdModalidad;
                var tipo = (BibliotecaClase.TipoEvento)cboxTipo.SelectedItem;
                int idTipoEvento = tipo.IdTipoEvento;
                DateTime _fechahorainicio = Convert.ToDateTime(txtFeIni.Text);
                DateTime _fechahoratermino = Convert.ToDateTime(txtFeTer.Text);
                int Asistentes = Convert.ToInt32(txtAsistentes.Text);
                int PerAdicional = Convert.ToInt32(txtPersonalAdic.Text);
                bool _vigente = false;
                float monto = float.Parse(txtMonto.Text);
                string _observaciones = txtObs.Text;
                
                

                if ((string.IsNullOrEmpty(txtContrato.Text)!=true && string.IsNullOrEmpty(txtPersonalAdic.Text) != true && 
                    string.IsNullOrEmpty(txtMonto.Text) != true && string.IsNullOrEmpty(txtObs.Text) != true && 
                    string.IsNullOrEmpty(txtFeIni.Text) != true && string.IsNullOrEmpty(txtFeTer.Text) != true && 
                    string.IsNullOrEmpty(txtTermino.Text ) != true) && string.IsNullOrEmpty(txtNombre.Text) != true && 
                     string.IsNullOrEmpty(txtCreacion.Text) != true &&
                    string.IsNullOrEmpty(txtTermino.Text) != true)

                {
                    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato()
                    {
                        _numero = numero,
                        _creacion = _creacion,
                        _termino = _termino,
                        RutCliente= rutcli,
                        idModalidad = idModalidad,
                        idTipoEvento = idTipoEvento,
                        _fechahorainicio = _fechahorainicio,
                        _fechahoratermino = _fechahoratermino,
                        asistentes = Asistentes,
                        personalAdicional = PerAdicional,
                        Realizado = _vigente,
                        ValorTotalContrato =monto,
                        Observaciones = _observaciones,
                      

                    };
                    BibliotecaClase.Contrato noesdao = new BibliotecaClase.Contrato();
                    bool resp = noesdao.AgregarContrato(con);
                    await this.ShowMessageAsync(null, resp ? "Añadido" : "No Ha sido Añadio");
                }

                }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception x)
            {
                Logger.Mensaje(x.Message);
                await this.ShowMessageAsync(null, "Error de ingreso de datos");
                MessageBox.Show(x.Message);

            }
        }


        public void llenarCbox()
        {
            var x = bdd.TipoEvento.ToList();
            foreach (var item in x)
            {
                BibliotecaClase.TipoEvento moda = new BibliotecaClase.TipoEvento();

                moda.IdTipoEvento = item.IdTipoEvento;
                moda.Descripcion = item.Descripcion;
                cboxTipo.Items.Add(moda);
            }
            var x1= bdd.Cliente.ToList();
            foreach (BibliotecaDALC.Cliente item in x1)
            {
                BibliotecaClase.Cliente cl = new BibliotecaClase.Cliente();
                cl.Rut = item.RutCliente;
                cl.Correo = item.MailContacto;
                cl.Direccion = item.Direccion;
                cl.Telefono = item.Telefono;
                cl.Razon_social = item.RazonSocial;
                cl.Nom_contacto = item.NombreContacto;
                cl.IdTipoEmpresa = item.IdTipoEmpresa;
                cl.idActividadEmpresa = item.IdActividadEmpresa;
                cboRutAso.Items.Add(cl);
            }
        }

        private void cboRutAso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnTraspaso_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtCreacion_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtFTe_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void btnRut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string rut = cboRutAso.SelectedValue.ToString();
                BibliotecaClase.Cliente cla = new BibliotecaClase.Cliente();
                
                BibliotecaClase.Cliente cl = cla.Buscar(rut);
                if (cl !=null)
                {
                    txtNombre.Text = cl.Razon_social;
                    
                }
            }
            catch (Exception x)
            {
                Logger.Mensaje(x.Message);
                await this.ShowMessageAsync(null, "Error al buscar los datos");
            }
        }

        private void cboxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtPreBase.Text = "" + (((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).ValorBase * Convert.ToDouble(txtUF.Text));
            txtPerBase.Text = "" + ((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).PersonalBase;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LIstarContrato lco = new LIstarContrato();
            lco.Show();
        }

        private void cboxTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {

                //BibliotecaClase.TipoEvento moda = (BibliotecaClase.TipoEvento)cboxTipo.SelectedItem;
                //cboxModalidades.Items.Clear();
                //cboxModalidades.SelectedIndex = 0;
                //var x = bdd.ModalidadServicio.ToList();
                //x = x.Where(y => y.IdTipoEvento == moda.IdTipoEvento).ToList();

                //foreach (var item in x)
                //{
                //    BibliotecaClase.ModalidadServicio ms = new BibliotecaClase.ModalidadServicio();
                //    ms.IdModalidad = item.IdModalidad;
                //    ms.IdTipoEvento = item.IdTipoEvento;
                //    ms.Nombre = item.Nombre;
                //    ms.PersonalBase = item.PersonalBase;
                //    ms.ValorBase = item.ValorBase;
                //    cboxModalidades.Items.Add(ms);
                //}


                BibliotecaClase.TipoEvento te = (BibliotecaClase.TipoEvento)cboxTipo.SelectedItem;
                try
                {
                    cboxModalidades.Items.Clear();

                }
                catch (Exception)
                {

                    cboxModalidades.ItemsSource = null;
                }
                var list = bdd.ModalidadServicio.ToList().Where(x=>x.IdTipoEvento==te.IdTipoEvento).ToList();

                foreach (var item in list)
                {
                    BibliotecaClase.ModalidadServicio ms = new BibliotecaClase.ModalidadServicio();
                    ms.IdModalidad = item.IdModalidad;
                    ms.IdTipoEvento = item.IdTipoEvento;
                    ms.Nombre = item.Nombre.Trim();
                    ms.PersonalBase = item.PersonalBase;
                    ms.ValorBase = item.ValorBase;
                    cboxModalidades.Items.Add(ms);
                }
                cboxModalidades.SelectedIndex = 0;
            
                switch ( ((BibliotecaClase.TipoEvento)cboxTipo.SelectedItem).Descripcion )
                {
                    case "Coffee Break":
                        chbAmbientacion.Visibility = Visibility.Hidden;
                        chbAmbPers.Visibility = Visibility.Hidden;
                        chbLoAConvenir.Visibility = Visibility.Hidden;
                        chbLocalCliente.Visibility = Visibility.Hidden;
                        chbLocalOnBreak.Visibility = Visibility.Hidden;
                        chbMusica.Visibility = Visibility.Hidden;
                        chbVegetariano.Visibility = Visibility.Visible;
                        txtMontoLoCliente.Visibility = Visibility.Hidden;
                        lblAConve.Visibility = Visibility.Hidden;
                        break;
                    case "Cocktail":
                        chbAmbientacion.Visibility = Visibility.Visible;
                        chbAmbPers.Visibility = Visibility.Visible;
                        chbLoAConvenir.Visibility = Visibility.Hidden;
                        chbLocalCliente.Visibility = Visibility.Hidden;
                        chbLocalOnBreak.Visibility = Visibility.Hidden;
                        chbMusica.Visibility = Visibility.Visible;
                        chbVegetariano.Visibility = Visibility.Hidden;
                        txtMontoLoCliente.Visibility = Visibility.Hidden;
                        lblAConve.Visibility = Visibility.Hidden;
                        break;

                    case "Cenas":
                        chbAmbientacion.Visibility = Visibility.Visible;
                        chbAmbPers.Visibility = Visibility.Visible;
                        chbLoAConvenir.Visibility = Visibility.Visible;
                        chbLocalCliente.Visibility = Visibility.Visible;
                        chbLocalOnBreak.Visibility = Visibility.Visible;
                        chbMusica.Visibility = Visibility.Visible;
                        chbVegetariano.Visibility = Visibility.Hidden;
                        txtMontoLoCliente.Visibility = Visibility.Hidden;
                        lblAConve.Visibility = Visibility.Hidden;
                        break;
                }







            }
            catch (Exception ex)
            {

            }
        }

        private void chbAmbPers_Checked(object sender, RoutedEventArgs e)
        {
            if (chbAmbientacion.IsChecked==true)
            {
                chbAmbientacion.IsChecked = false;
            }
            
            
        }

        private void chbAmbientacion_Checked(object sender, RoutedEventArgs e)
        {
            if (chbAmbPers.IsChecked == true)
            {
                chbAmbPers.IsChecked = false;
            }
            

        }

        private void chbVegetariano_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void chbLocalOnBreak_Checked(object sender, RoutedEventArgs e)
        {
            if (chbLoAConvenir.IsChecked==true)
            {
                chbLoAConvenir.IsChecked = false;
            }
            txtMontoLoCliente.Text = ""+0;
            txtMontoLoCliente.Visibility = Visibility.Hidden;
            lblAConve.Visibility = Visibility.Visible;
        }
        // this
        private void chbLoAConvenir_Checked(object sender, RoutedEventArgs e)
        {
            if (chbLocalOnBreak.IsChecked == true)
            {
                chbLocalOnBreak.IsChecked = false;
            }
            
            txtMontoLoCliente.Visibility = Visibility.Visible;

        }

        private void txtMontoLoCliente_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnGrCache_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //almacena en cache los valores
                BibliotecaClase.Contrato con = new BibliotecaClase.Contrato()
                {
                    _numero = txtContrato.Text,
                    _creacion = Convert.ToDateTime(txtCreacion.Text),
                    _termino = Convert.ToDateTime(txtTermino.Text),
                    RutCliente = ((BibliotecaClase.Cliente)cboRutAso.SelectedItem).Rut.ToString(),
                    idModalidad = ((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).IdModalidad.ToString(),
                    idTipoEvento = Convert.ToUInt16(((BibliotecaClase.TipoEvento)cboxTipo.SelectedItem).IdTipoEvento.ToString()),
                    _fechahorainicio = Convert.ToDateTime(txtFeIni.Text),
                    _fechahoratermino = Convert.ToDateTime(txtFeTer.Text),
                    asistentes = int.Parse(txtAsistentes.Text),
                    personalAdicional = int.Parse(txtPersonalAdic.Text),
                    Realizado = false,
                    ValorTotalContrato = float.Parse(txtMonto.Text),
                    Observaciones = txtObs.Text
                };
                //creacion de politica
                CacheItemPolicy politica = new CacheItemPolicy();
                politica.Priority = CacheItemPriority.Default;
                politica.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(5);
                //almacenar en el cache
                cache.Set("contrato", con, politica);
                MessageBox.Show("Almacenando");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDevCache_Click(object sender, RoutedEventArgs e)
        {
            BibliotecaClase.Contrato con = cache["contrato"] as BibliotecaClase.Contrato;
            if (con == null)
            {
                MessageBox.Show("Sin Datos");
            }
            else
            {
                txtContrato.Text = con._numero;
                txtCreacion.Text = "" + con._creacion;
                txtTermino.Text = con._numero;
                foreach (BibliotecaClase.Cliente item in cboRutAso.Items)
                {
                    if (item.Rut.ToString() == con.RutCliente)
                    {
                        cboRutAso.SelectedItem = item;
                    }
                }

                foreach (BibliotecaClase.TipoEvento item in cboxTipo.Items)
                {
                    if (item.IdTipoEvento.ToString() == "" + con.idTipoEvento)
                    {
                        cboxTipo.SelectedItem = item;
                    }
                }
                llenameModa(((BibliotecaClase.TipoEvento)cboxTipo.SelectedItem).IdTipoEvento);
                foreach (BibliotecaClase.ModalidadServicio item in cboxModalidades.Items)
                {
                    if (item.IdModalidad.ToString() == con.idModalidad)
                    {
                        cboxModalidades.SelectedItem = item;
                    }

                    txtFeIni.Text = "" + con._fechahorainicio;
                    txtFeTer.Text = "" + con._fechahoratermino;
                    txtAsistentes.Text = "" + con.asistentes;
                    txtPersonalAdic.Text = "" + con.personalAdicional;
                    txtMonto.Text = "" + con.ValorTotalContrato;
                    txtObs.Text = con.Observaciones;
                }
            }
        }

        private void btnLimCache_Click(object sender, RoutedEventArgs e)
        {
            cache.Remove("Contrato");
            MessageBox.Show("Cache removido");
        }



        private void llenameModa(int miId)
        {
            try
            {
                var x = bdd.ModalidadServicio.ToList();
                x = x.Where(y => y.IdTipoEvento == miId).ToList();
                cboxModalidades.Items.Clear();
                cboxModalidades.ItemsSource = null;
                foreach (var item in x)
                {
                    BibliotecaClase.ModalidadServicio ms = new BibliotecaClase.ModalidadServicio();
                    ms.IdModalidad = item.IdModalidad;
                    ms.IdTipoEvento = item.IdTipoEvento;
                    ms.Nombre = item.Nombre.Trim();
                    ms.PersonalBase = item.PersonalBase;
                    ms.ValorBase = item.ValorBase;
                    cboxModalidades.Items.Add(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtPersonalAdic_LostFocus(object sender, RoutedEventArgs e)
        {


            
        }


        private async void Calculador() {
            try
            {
                Valorizador valo = new Valorizador();
                string Evento = ((BibliotecaClase.TipoEvento)cboxTipo.SelectedItem).Descripcion;
                int ValBase = Convert.ToInt32(((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).ValorBase);
                int PerAdic = Convert.ToInt32(txtPersonalAdic.Text);
                int Asis = Convert.ToInt32(txtAsistentes.Text);
                bool MusAm = chbMusica.IsChecked.Value ;
                bool ambitacion = chbAmbientacion.IsChecked.Value;
                bool amPerso = chbAmbPers.IsChecked.Value; ;
                bool local = chbLocalOnBreak.IsChecked.Value;
                int convenido = Convert.ToInt32(txtMontoLoCliente.Text);
                bool AlimVeg = chbVegetariano.IsChecked.Value;
                int total= (int)valo.ValorContrato(Evento,ValBase,PerAdic,Asis,MusAm,ambitacion,amPerso,local,convenido,AlimVeg);
                txtMonto.Text = ""+total* float.Parse(txtUF.Text);
            }
            catch (Exception)
            {


                await this.ShowMessageAsync(null, "no pueden haber campos vacios");
            }



        }

        private void btnOPTATIVO_Click(object sender, RoutedEventArgs e)
        {
            Calculador();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            UpdContracto cd = new UpdContracto();
            cd.Show();
            this.Close();
        }

        private async void txtFeTer_LostFocus(object sender, RoutedEventArgs e)
        {
            var fechafin = txtFeTer.Text;
            DateTime dtFIN = DateTime.Now;
            DateTime dt24 = DateTime.Now.AddHours(24);


            bool fechaValida = DateTime.TryParse(fechafin, out dtFIN);

            if (dtFIN > dt24)
            {
                await this.ShowMessageAsync(null, "la fecha no puede superar las 24 horas");
                txtFeTer.Clear();
            }
        }

        private async void txtFeIni_LostFocus(object sender, RoutedEventArgs e)
        {
            var fechacrea = txtCreacion.Text;
            var fechaini = txtFeIni.Text;
            DateTime dtc = DateTime.Now;
            DateTime dtf = dtc;
            DateTime dt10 = DateTime.Now.AddMonths(10);

            bool fechaValida = DateTime.TryParse(fechacrea, out dtc)
                           && DateTime.TryParse(fechaini, out dtf);
            if (dtf <= dtc)
            {
                await this.ShowMessageAsync(null, "La fecha ingresada no puede ser anterior a la fecha de creacion del contrato");
                txtFeIni.Clear();
            }
            if (dtf >= dt10)
            {
                await this.ShowMessageAsync(null, "La fecha ingresada no puede ser superior a 10 meses del evento");
                txtFeIni.Clear();
            }

        }

        private void txtPerBase_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ListarCliente lc = new ListarCliente(this);
                lc.Show();
            }
            catch (Exception)
            {

            }
        }
    }
}
