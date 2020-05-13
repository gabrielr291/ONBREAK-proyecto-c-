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
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : MetroWindow
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void btnAgregarCl_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync(null, "Bienvenido al modulo de Administrar Cliente");
            AgregarCliente AC = new AgregarCliente();
            AC.Show();
            Close();
        }

        private async void btnAgregarCon_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync(null, "Bienvenido al modulo de Administrar Contrato");
            AgregarContrato acon = new AgregarContrato();
            acon.Show();
            Close();
        }

        private void Volver(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resp = MessageBox.Show("Desea salir del Sistema?", "Hasta luego!",
                                            MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resp == MessageBoxResult.Yes)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Cancelo");
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resp = MessageBox.Show("Desea salir del Sistema?", "Hasta luego!",
                                            MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resp == MessageBoxResult.Yes)
            {
                Close();
            }else
            {
                MessageBox.Show("Cancelo");
            }
        }

        private async void btnListarCl_Click(object sender, RoutedEventArgs e)
        {
            ListarCliente lc = new ListarCliente();
            await this.ShowMessageAsync(null, "Bienvenido al modulo de Listar Cliente");
            lc.Show();
            Close();
        }

        private async void btnListarCon_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync(null, "Bienvenido al modulo de Listar Contrato");
            LIstarContrato lcon = new LIstarContrato();
            lcon.Show();
            Close();
        }
    }
}
