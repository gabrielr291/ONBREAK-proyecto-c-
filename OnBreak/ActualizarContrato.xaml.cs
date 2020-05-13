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
    /// Lógica de interacción para ActualizarContrato.xaml
    /// </summary>
    public partial class ActualizarContrato : MetroWindow
    {
        BibliotecaClase.Cliente supremo = new BibliotecaClase.Cliente();
        private OnBreakEntities bdd = new OnBreakEntities();
        public ActualizarContrato(BibliotecaClase.Contrato c)
        {
            InitializeComponent();
            llenarCbox();
            txtContrato.IsEnabled = false;
            txtCreacion.IsEnabled = false;    
        } // ARREGLAR ACA

        public void llenarCbox()
        {
            foreach (ClientesParacBox item in new ClientesParacBox().ReadAll())
            {
                ClientesParacBox cpbox = new ClientesParacBox();
                cpbox.rutDeMiCli = item.rutDeMiCli;
                cboRutAso.Items.Add(cpbox);
            }

            var x = bdd.ModalidadServicio.ToList();
            foreach (BibliotecaDALC.ModalidadServicio item in x)
            {
                BibliotecaClase.ModalidadServicio moda = new BibliotecaClase.ModalidadServicio();
                moda.IdModalidad = item.IdModalidad;
                moda.IdTipoEvento = item.IdTipoEvento;
                moda.Nombre = item.Nombre;
                moda.ValorBase = item.ValorBase;
                moda.PersonalBase = item.PersonalBase;
                cboxModalidades.Items.Add(moda);
            }// funciona

        }// Revisar si podemos usar un select simple

    
    

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            AgregarContrato ac = new AgregarContrato();
            ac.Show();
            Close();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            Close();
        }

        private async void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {    //FCA 
                Valorizador valor = new Valorizador();
                double valorBass = ((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).ValorBase; //variable para valorizar
                string numero = txtContrato.Text;
                DateTime _creacion = Convert.ToDateTime(txtCreacion.Text);
                DateTime _termino = Convert.ToDateTime(txtTermino.Text);

                string rutcli = ((BibliotecaClase.ClientesParacBox)cboRutAso.SelectedItem).rutDeMiCli;
                string idModalidad = ((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).IdModalidad;
                int idTipoEvento = ((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).IdTipoEvento;
                DateTime _fechahorainicio = Convert.ToDateTime(txtFIn.Text);
                DateTime _fechahoratermino = Convert.ToDateTime(txtTerEven.Text);
                int Asistentes = Convert.ToInt32(txtAsistentes.Text);
                int PerAdicional = Convert.ToInt32(txtPersonalAdic.Text);
                bool _vigente = false;
                float monto = valor.ValorContrato(valorBass, PerAdicional, Asistentes);
                string _observaciones = txtObs.Text;


                if ((string.IsNullOrEmpty(txtContrato.Text) != true && string.IsNullOrEmpty(txtPersonalAdic.Text) != true &&
                    string.IsNullOrEmpty(txtMonto.Text) != true && string.IsNullOrEmpty(txtObs.Text) != true &&
                    string.IsNullOrEmpty(txtFIn.Text) != true && string.IsNullOrEmpty(txtTerEven.Text) != true &&
                    string.IsNullOrEmpty(txtTermino.Text) != true) &&
                     string.IsNullOrEmpty(txtCreacion.Text) != true &&
                    string.IsNullOrEmpty(txtTermino.Text) != true)

                {
                    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato()
                    {
                        _numero = numero,
                        _creacion = _creacion,
                        _termino = _termino,
                        RutCliente = rutcli,
                        idModalidad = idModalidad,
                        idTipoEvento = idTipoEvento,
                        _fechahorainicio = _fechahorainicio,
                        _fechahoratermino = _fechahoratermino,
                        asistentes = Asistentes,
                        personalAdicional = PerAdicional,
                        Realizado = _vigente,
                        ValorTotalContrato = monto,
                        Observaciones = _observaciones,


                    };
                    BibliotecaClase.Contrato noesdao = new BibliotecaClase.Contrato();
                    bool resp = noesdao.ActualizarContrato(con);
                    await this.ShowMessageAsync(null, resp ? "Modificado" : "No se ha podido Modificar");
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

        private void chboxVigente_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        

        private void btnTraspaso_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cboRutAso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //BibliotecaClase.Contrato contra = new BibliotecaClase.Contrato();
            //string mirut = ((ClientesParacBox)cboRutAso.SelectedItem).rutDeMiCli;
            //var x = from contrac in bdd.Contrato
            //        join cli in bdd.Cliente
            //        on contrac.RutCliente equals cli.RutCliente
            //        join moda in bdd.ModalidadServicio
            //        on contrac.IdModalidad equals moda.IdModalidad
            //        where cli.RutCliente.Equals(mirut)
            //        select new ListadoDeContratos
            //        {
            //            numContra = contrac.Numero,
            //            creacion = "" + contrac.Creacion,
            //            fechaInicio = "" + contrac.FechaHoraInicio,
            //            fechatermino = "" + contrac.FechaHoraTermino,
            //            asistente = contrac.Asistentes,
            //            perAdicional = contrac.PersonalAdicional,
            //            total = Convert.ToInt32(contrac.ValorTotalContrato)
            //        };
            //foreach (ListadoDeContratos item in x)
            //{
            //    txtContrato.Text = item.numContra;
            //    txtCreacion.Text = item.creacion;
            //    txtTermino.Text = item.fechatermino;
            //    txtAsistentes.Text = ""+item.asistente;
            //    txtPersonalAdic.Text = "" + item.perAdicional;
            //    txtObs.Text = item.observa;
            //}


        }

        private void cboxModalidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Valorizador valor = new Valorizador();
            double valorBase = ((BibliotecaClase.ModalidadServicio)cboxModalidades.SelectedItem).ValorBase;
            int Asis = Convert.ToInt32(txtAsistentes.Text);
            int PerAd = Convert.ToInt32(txtPersonalAdic.Text);

            txtMonto.Text = "" + valor.ValorContrato(valorBase, PerAd, Asis);
        }
        //este metodo hace que cuando se sleccione un rut desde aca se pongan los datos automaticamente en los txtBox
    }
}
