using BibliotecaClase;
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

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para ActualizarCliente.xaml
    /// </summary>
    public partial class ActualizarCliente : MetroWindow
    {
        public ActualizarCliente()
        {
            InitializeComponent();
            llenarCbox();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarCliente ac = new AgregarCliente();
            ac.Show();
            Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            ListarCliente ec = new ListarCliente();
            ec.Show();
            Close();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }
        public void llenarCbox()
        {
            cmbActividad.Items.Clear();
            cmbTipo.Items.Clear();
            foreach (ActividadEmpresa item in new ActividadEmpresa().ReadAll())
            {
                BibliotecaClase.ComboBoxItem cbi = new BibliotecaClase.ComboBoxItem();
                cbi.Value = item.IdActividadEmpresa;
                cbi.Texto = item.Descripcion;
                cmbActividad.Items.Add(cbi);
            }// funciona
            foreach (TipoEmpresa item in new TipoEmpresa().ReadAll())
            {
                BibliotecaClase.ComboBoxItem cbi = new BibliotecaClase.ComboBoxItem();
                cbi.Value = item.IdTipoEmpresa;
                cbi.Texto = item.Descripcion;
                cmbTipo.Items.Add(cbi);
            }//funciona



        }
        private void Volver(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }


        private async void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string rut = txtRut.Text;
                string razon_social = txtRazon.Text;
                string nom_contacto = txtNombre.Text;
                string correo = txtCorreo.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                int idActividadEmpresa = ((BibliotecaClase.ComboBoxItem)cmbActividad.SelectedItem).Value;
                int IdTipoEmpresa = ((BibliotecaClase.ComboBoxItem)cmbTipo.SelectedItem).Value;
                Cliente nc = new Cliente()
                {
                    Rut = rut,
                    Nom_contacto = nom_contacto,
                    Direccion = direccion,
                    Telefono = telefono,
                    Correo = correo,
                    Razon_social = razon_social,
                    idActividadEmpresa = idActividadEmpresa,
                    IdTipoEmpresa = IdTipoEmpresa
                };
                Cliente cli = new Cliente();
                bool respo = cli.ActualizarCliente(nc);
                if (respo)
                {
                    await this.ShowMessageAsync(null, "Se ha modificado correctamente");
                }
                else
                {
                    await this.ShowMessageAsync(null, "Error al modificar Cliente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }         
    } // No deberia tener problemas

      
        private string formatoRut(string rut)
        {
            try
            {

                int cont = 0;
                string format;
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;

            }
            catch (Exception x)
            {

                return null;
            }

        }
        //deberia estar bien
        private bool validarRut(string rut)
        {
            try
            {
                bool validacion = false;
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
                return validacion;


            }
            catch (Exception x)
            {

                return false;
            }


        }

        private void txtRut_LostFocus(object sender, RoutedEventArgs e)
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
                    int miid = (cl.IdTipoEmpresa) / 10;
                    txtRut.Text = cl.Rut;
                    txtRazon.Text = cl.Razon_social;
                    txtNombre.Text = cl.Nom_contacto;
                    txtCorreo.Text = cl.Correo;
                    txtDireccion.Text = cl.Direccion;
                    txtTelefono.Text = cl.Telefono;
                    cmbActividad.SelectedIndex = cl.idActividadEmpresa;
                    cmbTipo.SelectedIndex = miid;
                    txtRut.IsEnabled = false;
                }
                txtRazon.IsEnabled = true;
                txtNombre.IsEnabled = true;
                txtDireccion.IsEnabled = true;
                txtCorreo.IsEnabled = true;
                txtTelefono.IsEnabled = true;
                cmbActividad.IsEnabled = true;
                cmbTipo.IsEnabled = true;

            }
            catch (Exception)
            {
                txtRut.Text = "";
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

    }
}

