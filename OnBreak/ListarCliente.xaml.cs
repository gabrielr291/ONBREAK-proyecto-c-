using System;
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
namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para ListarCliente.xaml
    /// </summary>
    public partial class ListarCliente : MetroWindow
    {
        BibliotecaClase.Cliente supremo = new BibliotecaClase.Cliente();
        public object BuscarPorRut { get; private set; }
        OnBreakEntities bdd = new OnBreakEntities();
        AgregarContrato a = null;
        public ListarCliente()
        {
            InitializeComponent();
            dgrListarCli.ItemsSource = supremo.ReadAll();
            llenarCbox();
            button.Visibility = Visibility.Hidden;

        }
        public ListarCliente(AgregarContrato ac)
        {
            InitializeComponent();
            dgrListarCli.ItemsSource = supremo.ReadAll();
            llenarCbox();
            a = ac;
            button.Visibility = Visibility.Visible;


        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }
        
        public void llenarCbox()
        {
            foreach (BibliotecaClase.ActividadEmpresa item in new BibliotecaClase.ActividadEmpresa().ReadAll())
            {
                BibliotecaClase.ComboBoxItem cbi = new BibliotecaClase.ComboBoxItem();
                cbi.Value = item.IdActividadEmpresa;
                cbi.Texto = item.Descripcion;
                cmbActividad.Items.Add(cbi);
            }// funciona
            foreach (BibliotecaClase.TipoEmpresa item in new BibliotecaClase.TipoEmpresa().ReadAll())
            {
                BibliotecaClase.ComboBoxItem cbi = new BibliotecaClase.ComboBoxItem();
                cbi.Value = item.IdTipoEmpresa;
                cbi.Texto = item.Descripcion;
                cmbTipo.Items.Add(cbi);
            }//funciona


            //lo vamos a cambiar por un text 

            var x1 = bdd.Cliente.ToList();
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
            }
        }


        private void cboxRut_GotFocus(object sender, RoutedEventArgs e)
        {
            btnBusTipo.Visibility = Visibility.Hidden;
            btnBusRut.Visibility = Visibility.Visible;
            btnBusActi.Visibility = Visibility.Hidden;
            
            
        }

        private void cboxTipo_GotFocus(object sender, RoutedEventArgs e)
        {
            

            btnBusTipo.Visibility = Visibility.Visible;
            btnBusRut.Visibility = Visibility.Hidden;
            btnBusActi.Visibility = Visibility.Hidden;

            dgrListarCli.ItemsSource = supremo.ReadAll();
        }

        private void cboxActividad_GotFocus(object sender, RoutedEventArgs e)
        {
            btnBusTipo.Visibility = Visibility.Hidden;
            btnBusRut.Visibility = Visibility.Hidden;
            btnBusActi.Visibility = Visibility.Visible;

            dgrListarCli.ItemsSource = supremo.ReadAll();

        }

        private void btnBusRut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BibliotecaClase.Cliente cli = new BibliotecaClase.Cliente();
                string mirutcli = txtRut.Text;
               var x= cli.ReadAllxRut(mirutcli);
                dgrListarCli.ItemsSource = x;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por rut: "+ex.Message);
            }
           
        }
        //revisar
        private void btnBusActi_Click(object sender, RoutedEventArgs e)
        {
            var listado = supremo.ReadAll();

            string def = ((BibliotecaClase.ComboBoxItem)cmbActividad.SelectedItem).Texto;
            var filtracion = listado.Where(p => p.desActEMP.Contains(def));

            dgrListarCli.ItemsSource = filtracion;
        }
        //revisar

        private void btnBusTipo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var listado = supremo.ReadAll();
                string tipo = ((BibliotecaClase.ComboBoxItem)cmbTipo.SelectedItem).Texto;
                var filtracion = listado.Where(p => p.descTEMP.Contains(tipo));
                dgrListarCli.ItemsSource = filtracion;
            }
            catch (Exception)
            {

                
            }
        }
        //revisar




        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ActualizarCliente ag = new ActualizarCliente();
                BibliotecaClase.ListaCompleta cl = (BibliotecaClase.ListaCompleta)dgrListarCli.SelectedItem;
                ag.txtRut.IsEnabled = false;
                ag.txtCorreo.Text = cl.correo;
                ag.txtDireccion.Text = cl.direccion;
                ag.txtNombre.Text = cl.nom_contacto;
                ag.txtRazon.Text = cl.razon_social;
                ag.txtTelefono.Text = cl.telefono;
                ag.txtRut.Text = cl.rut;
                foreach (BibliotecaClase.ComboBoxItem item in ag.cmbActividad.Items)
                {
                    if (item.Texto.ToString() == cl.desActEMP)
                    {
                        ag.cmbActividad.SelectedItem = item;
                    }
                }

                foreach (BibliotecaClase.ComboBoxItem item in ag.cmbTipo.Items)
                {
                    if (item.Texto.ToString() == cl.descTEMP)
                    {
                        ag.cmbTipo.SelectedItem = item;
                    }
                }

                ag.Show();

                this.Close();

            }
            catch (Exception)
            {

            
            }

        }

        private void dgrListarCli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListaCompleta ls = (ListaCompleta)(dgrListarCli.SelectedItem);

                BibliotecaClase.Cliente p = new BibliotecaClase.Cliente();
                p.Rut = ls.rut; // ahhh Malditas manos, esta linea esta mal>
                p.Razon_social = ls.razon_social;
                p.Nom_contacto = ls.nom_contacto;
                p.Direccion = ls.direccion;
                p.Correo = ls.correo;
                p.Telefono = ls.telefono;
                var x = bdd.ActividadEmpresa.ToList();
                x = x.Where(y => y.Descripcion == ls.desActEMP).ToList();
                foreach (var item in x)
                {
                    p.idActividadEmpresa = item.IdActividadEmpresa;
                }
                var x1 = bdd.TipoEmpresa.ToList();
                x1 = x1.Where(y1 => y1.Descripcion == ls.descTEMP).ToList();
                foreach (var item in x1)
                {
                    p.IdTipoEmpresa = item.IdTipoEmpresa;
                }
                BibliotecaClase.Contrato conto = new BibliotecaClase.Contrato();

                if (p != null )
                {
                    //if (conto.ExisteClienteConContrato(p.Rut) == false)
                    //{
                        MessageBoxResult resp = MessageBox.Show("Desea Eliminar?", "Eliminar",
                                           MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        if (resp == MessageBoxResult.Yes)
                        {
                            bool resp2 = p.EliminarCliente(p.Rut);
                            await this.ShowMessageAsync(null, "Elimino");
                        }
                        else
                        {
                            await this.ShowMessageAsync(null, "No elimino");
                        }
                    //}
                   
                }
                else
                {
                    await this.ShowMessageAsync(null, "Cliente tiene contratos asociados: Imposible Eliminar");
                }
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync(null,"No se puede eliminar cliente si tiene contratos asociados");
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbActividad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Volver(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }

        private async void txtRut_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {

                if (txtRut.Text != "")
                {
                    string verifica = new VerificarRut().ValidarRut(txtRut.Text);
                    string rut = txtRut.Text;
                    /*Quitar los . las , y -*/
                    rut = rut.Replace(",", "");
                    rut = rut.Replace(".", "");
                    rut = rut.Replace("-", "");
                    /*ajustar el largo del rut a validar*/
                    if (rut.Length == 8)
                    {
                        rut = "0" + rut;
                    }
                }

                string ruti = txtRut.Text;
                rutificador(ruti);
                BibliotecaClase.Cliente cl = new BibliotecaClase.Cliente().Buscar1(txtRut.Text);
                if (cl != null)
                {
                    txtRut.Text = cl.Rut;
                }
            }
            catch (Exception)
            {
                await this.ShowMessageAsync(null, "erorcito");
            }
        }
        public void rutificador(string ruti)
        {
            try
            {
                string rutSinFormato = ruti;

                //si el rut ingresado tiene "." o "," o "-" son ratirados para realizar la formula 
                rutSinFormato = rutSinFormato.Replace(",", "");
                rutSinFormato = rutSinFormato.Replace(".", "");
                rutSinFormato = rutSinFormato.Replace("-", "");
                string rutFormateado = String.Empty;

                //obtengo la parte numerica del RUT
                string rutTemporal = rutSinFormato.Substring(0, rutSinFormato.Length - 1);

                //obtengo el Digito Verificador del RUT
                string dv = rutSinFormato.Substring(rutSinFormato.Length - 1, 1);

                Int64 rut;

                //aqui convierto a un numero el RUT si ocurre un error lo deja en CERO
                if (!Int64.TryParse(rutTemporal, out rut))
                {
                    rut = 0;
                }

                //este comando es el que formatea con los separadores de miles
                rutFormateado = rut.ToString("N0");

                if (rutFormateado.Equals("0"))
                {
                    rutFormateado = string.Empty;
                }
                else
                {
                    //si no hubo problemas con el formateo agrego el DV a la salida
                    rutFormateado += "-" + dv;

                    //y hago este replace por si el servidor tuviese configuracion anglosajona y reemplazo las comas por puntos
                    rutFormateado = rutFormateado.Replace(",", ".");
                }

                //se pasa a mayuscula si tiene letra k
                rutFormateado = rutFormateado.ToUpper();

                //la salida esperada para el ejemplo es 99.999.999-K
                txtRut.Text = rutFormateado.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtRut_GotFocus(object sender, RoutedEventArgs e)
        {
            btnBusTipo.Visibility = Visibility.Hidden;
            btnBusRut.Visibility = Visibility.Visible;
            btnBusActi.Visibility = Visibility.Hidden;
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var d = (BibliotecaClase.ListaCompleta)dgrListarCli.SelectedItem;
                a.txtNombre.Text =d.razon_social;
                a.cboRutAso.Text = d.rut;
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                await this.ShowMessageAsync("Error","Por favor seleccione un cliente");
                
            }
        }
    }
}
