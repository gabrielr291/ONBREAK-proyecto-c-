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
    /// Lógica de interacción para LIstarContrato.xaml
    /// </summary>
    public partial class LIstarContrato : MetroWindow
    {
        BibliotecaClase.Contrato supremo = new BibliotecaClase.Contrato();
        OnBreakEntities bdd = new OnBreakEntities();
        public LIstarContrato()
        {
            InitializeComponent();
            llenarCbox();

            dtgContratos.ItemsSource = supremo.readAll();
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
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

      
        public void llenarCbox()
        {
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
                cboxRut.Items.Add(cl);
            }

            //LLENAR TIPO DE EVENTO
            var x = bdd.TipoEvento.ToList();
            foreach (var item in x)
            {
                BibliotecaClase.TipoEvento moda = new BibliotecaClase.TipoEvento();

                moda.IdTipoEvento = item.IdTipoEvento;
                moda.Descripcion = item.Descripcion.Trim();
                cboxTipo.Items.Add(moda);
            }



            ///LLENAR COMBO DE MODALIDAD

            var x2 = bdd.ModalidadServicio.ToList();
            foreach (var item in x2)
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

      
        private async void btnBaja_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BibliotecaClase.Contrato E = (BibliotecaClase.Contrato)dtgContratos.SelectedItem;
                
                supremo.DarDeBaja(E);
                if (E != null)
                {
                    MessageBoxResult resp = MessageBox.Show("Desea dar de baja?", "Dar de baja",
                                            MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (resp == MessageBoxResult.Yes)
                    {
                        bool resp2 = supremo.DarDeBaja(E);
                        await this.ShowMessageAsync(null, "Vigencia cambiada");
                        dtgContratos.ItemsSource = supremo.readAll();
                    }
                    else
                    {
                        await this.ShowMessageAsync(null, "Error al cambiar vigencia");
                        dtgContratos.ItemsSource = supremo.readAll();
                    }
                }
                dtgContratos.ItemsSource = supremo.readAll();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BibliotecaClase.Contrato c = (BibliotecaClase.Contrato)dtgContratos.SelectedItem;
                UpdContracto ac = new UpdContracto();
                ac.txtContrato.Text = c._numero;
                ac.txtCreacion.Text = ""+c._creacion;
                ac.txtAsistentes.Text = "" + c.asistentes;
                ac.txtTermino.Text = ""+c._termino;
                ac.txtFeIni.Text = ""+c._fechahoratermino;
                ac.txtMonto.Text = ""+c.ValorTotalContrato;
                //ac.cboxModalidades = c.idModalidad;
                ac.txtObs.Text = c.Observaciones;
                ac.txtPersonalAdic.Text = ""+c.personalAdicional;
                ac.txtFeTer.Text = ""+c._fechahoratermino;
               // ac.cboxModalidades.SelectedValue = c.idModalidad;
                ac.cboRutAso.SelectedValue= c.RutCliente;
                ac.llenarCbox();
                ac.Show();
                this.Close();
            }
            catch (Exception ex)
            {

                await this.ShowMessageAsync(null, "seleccione un capo de la lista");
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BibliotecaClase.Contrato cont = new BibliotecaClase.Contrato();
                string textoRut =( (BibliotecaClase.Cliente)cboxRut.SelectedItem).Rut;
                var c = cont.cliConContrato(textoRut);
                dtgContratos.ItemsSource = c;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: "+ex.Message);
            }
        }

        


        private void cboxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnBuscarModalidad.Visibility = Visibility.Visible;
            btnBuscarTipo.Visibility = Visibility.Hidden;
            btnBuscarRut.Visibility = Visibility.Hidden;
        }

        private void cboxTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnBuscarModalidad.Visibility = Visibility.Hidden;
            btnBuscarTipo.Visibility = Visibility.Visible;
            btnBuscarRut.Visibility = Visibility.Hidden;
        }


        private void cboxRut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnBuscarModalidad.Visibility = Visibility.Hidden;
            btnBuscarTipo.Visibility = Visibility.Hidden;
            btnBuscarRut.Visibility = Visibility.Visible;
        }

        private void btnBuscarRut_Click(object sender, RoutedEventArgs e)
        {
            BibliotecaClase.Contrato conti = new BibliotecaClase.Contrato();
            string id = ((BibliotecaClase.Cliente)cboxRut.SelectedItem).Rut;
            var x = conti.cliConContrato(id);
            dtgContratos.ItemsSource = x;
        }

        private void btnBuscarModalidad_Click(object sender, RoutedEventArgs e)
        {
            BibliotecaClase.Contrato conti = new BibliotecaClase.Contrato();
            string id = ((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).IdModalidad;
            var x = conti.ContratoPorModalidad(id);
            dtgContratos.ItemsSource = x;
        }
    

        private async void btnBuscarTipo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BibliotecaClase.Contrato conti = new BibliotecaClase.Contrato();
                int id = ((BibliotecaClase.TipoEvento)cboxTipo.SelectedItem).IdTipoEvento;
                var x = conti.ContratoporTipoEve(id);
                dtgContratos.ItemsSource = x;
            }
            catch (Exception)
            {

                await this.ShowMessageAsync(null, "seleccione un campo de la lista");
            }

        }
}
    
}