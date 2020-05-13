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
    /// Lógica de interacción para EliminarCliente.xaml
    /// </summary>
    public partial class EliminarCliente : MetroWindow
    {
        public EliminarCliente()
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

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            ActualizarCliente acac = new ActualizarCliente();
            acac.Show();
            Close();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }

        private async void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente micli = new Cliente();
                Cliente cli = micli.Buscar(txtRut.Text);
                txtNombre.Text = cli.Nom_contacto;
                txtDireccion.Text = cli.Direccion;
                txtRazon.Text = cli.Razon_social;
                txtTelefono.Text = cli.Telefono;
                txtCorreo.Text = cli.Correo;
                txtRut.Text = cli.Rut;

            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync(null, "No existe Rut para buscar");
            }

        } // No deberia presentar problema

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente micli = new Cliente();
                Cliente cli = micli.Buscar(txtRut.Text);
                if (cli != null)
                {
                    MessageBoxResult resp = MessageBox.Show("Desea Eliminar?", "Eliminar",
                                            MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (resp == MessageBoxResult.Yes)
                    {
                        bool resp2 = micli.EliminarCliente(txtRut.Text);
                        await this.ShowMessageAsync(null, "Elimino");
                    }
                    else
                    {
                        await this.ShowMessageAsync(null, "No elimino");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //Deberia funcionar, no testeado de momento
        public void llenarCbox()
        {
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



        }// no deberia presentar errores, por que? Por que lo hice yo -Chernobyl baby
    }
    }
