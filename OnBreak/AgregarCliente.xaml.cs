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

namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para AgregarCliente.xaml
    /// </summary>
    public partial class AgregarCliente : MetroWindow

    {
        public AgregarCliente()
        {
            InitializeComponent();
            llenarCbox();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            ActualizarCliente actc = new ActualizarCliente();
            actc.Show();
            Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            ListarCliente ec = new ListarCliente();
            ec.Show();
            Close();
        }

        private void Volver(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }
        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                String rut = "";
                if (txtRut.Text!=null && txtRut.Text.Length==12)
                {
                    rut = txtRut.Text;   
                }

                else
                {
                    await this.ShowMessageAsync(null, "Ingrese un Rut valido");
                    txtRut.Clear();
                    txtRut.Focus();
                }

                String razon_social = "";
                if (txtRazon.Text != null)
                {
                    razon_social = txtRazon.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese una Razon Social");
                    txtRazon.Clear();
                    txtRazon.Focus();
                }

                String nom_contacto = "";
                if (txtNombre.Text != null)
                {
                    nom_contacto = txtNombre.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese un Nombre");
                    txtNombre.Clear();
                    txtNombre.Focus();
                }



                String correo = "";
                if (txtCorreo.Text != null)
                {
                    correo = txtCorreo.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese un Correo valido");
                    txtCorreo.Clear();
                    txtCorreo.Focus();
                }

                String direccion = "";
                if (txtDireccion.Text != null)
                {
                    direccion = txtDireccion.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese una Direccion");
                    txtDireccion.Clear();
                    txtDireccion.Focus();
                }

                String telefono = "";
                if (txtTelefono.Text != null && txtTelefono.Text.Length == 11)
                {
                    telefono = txtTelefono.Text;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese un Telefono valido");
                    txtTelefono.Clear();
                    txtTelefono.Focus();
                }

                String act_empresa = "";
                if (cmbActividad.SelectedValue != null)
                {
                    act_empresa = "" + cmbActividad.SelectedValue;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Ingrese una Actividad");
                    cmbActividad.SelectedValue = 0;
                    cmbActividad.Focus();
                }

                String tipo = "";
                if (cmbTipo.SelectedValue != null)
                {
                    tipo = "" + cmbTipo.SelectedValue;
                }
                else
                {
                    await this.ShowMessageAsync(null, "Seleccione un Tipo de Empresa");
                    cmbTipo.SelectedValue = 0;
                    cmbTipo.Focus();
                }
                var ActividadEmpresa = (BibliotecaClase.ComboBoxItem)cmbActividad.SelectedItem;
                int idActividadEmpresa = ActividadEmpresa.Value;
                var TipoEmpresa = (BibliotecaClase.ComboBoxItem)cmbTipo.SelectedItem;
                int IdTipoEmpresa = TipoEmpresa.Value;
                if (string.IsNullOrEmpty(txtNombre.Text) != true && string.IsNullOrEmpty(txtCorreo.Text) != true && string.IsNullOrEmpty(txtDireccion.Text) != true && string.IsNullOrEmpty(txtRazon.Text) != true && string.IsNullOrEmpty(txtRut.Text) != true && string.IsNullOrEmpty(txtTelefono.Text) != true && cmbActividad.SelectedIndex > 0 && cmbTipo.SelectedIndex > 0)
                {
                    Cliente cli = new Cliente()
                    {

                        Rut = rut,
                        Razon_social = razon_social,
                        Nom_contacto = nom_contacto,
                        Correo = correo,
                        Direccion = direccion,
                        Telefono = telefono,   
                        idActividadEmpresa = idActividadEmpresa,
                        IdTipoEmpresa= IdTipoEmpresa
                    };
                    Cliente nodao = new Cliente();
                    bool resp = nodao.AgregarCliente(cli);
                    await this.ShowMessageAsync(null, resp ? "Correctamente Añadido" : "No se pudo añadir");
                    if (resp == true)
                    {
                        txtRut.Clear();
                        txtRazon.Clear();
                        txtNombre.Clear();

                        txtCorreo.Clear();
                        txtDireccion.Clear();
                        txtTelefono.Clear();
                        cmbActividad.SelectedValue = 0;
                        cmbTipo.SelectedValue = 0;
                        txtRut.Focus();
                    }
                    
                }
                else
                {
                    await this.ShowMessageAsync(null, "Todos los campos son obligatorios");
                }


            }
            catch (Exception exa)
            {
                await this.ShowMessageAsync(null, "Error de ingreso de datos");
            }
        }
        //segun yo tiene todo para poder funcionar
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



        } //Funciona
        //Deberia estar bien
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
        //deberia estar bien
        private void txtNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            if (ascci >= 65 && ascci <= 90 || ascci >= 97 && ascci <= 122)

                e.Handled = false;
            
            else e.Handled = true;
        }
        //deberia estar bien
        private void txtApellido_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            if (ascci >= 65 && ascci <= 90 || ascci >= 97 && ascci <= 122)

                e.Handled = false;

            else e.Handled = true;
        }
        //deberia estar bien
        private void txtTelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            if (ascci >= 48 && ascci <= 57) e.Handled = false;

            else e.Handled = true;
        }
        //deberia estar bien
        private void txtRut_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            //if (ascci >= 48 && ascci <= 57) e.Handled = false;

            //else e.Handled = true;
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ListarCliente lc = new ListarCliente();
            lc.Show();
        }

        private void cmbActividad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, TextChangedEventArgs e)
        {

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
        //deberia estar bien
    }
}


