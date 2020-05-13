using System;
using System.Windows;
using BibliotecaClase;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using System.Windows.Input;

namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsername.Text;
            string pass = txtPass.Password;

            clsUsuario usu = new clsUsuario();

            usu.user = usuario;
            usu.pass = pass;
            if (usu.login() == true)
            {
                Inicio main = new Inicio();
                await this.ShowMessageAsync("Confirmacion", "Bienvenido");
                main.Show();
                this.Close();
            }
            else
            {
                await this.ShowMessageAsync("Error", "Datos Ingresados Incorrectos");
            }
        }

       

        private void txtUsername_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private async void txtPass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string usuario = txtUsername.Text;
                string pass = txtPass.Password;

                clsUsuario usu = new clsUsuario();

                usu.user = usuario;
                usu.pass = pass;
                if (usu.login() == true)
                {
                    Inicio main = new Inicio();
                    await this.ShowMessageAsync("Confirmacion", "Bienvenido");
                    main.Show();
                    this.Close();



                }
                else
                {
                    await this.ShowMessageAsync("Error", "Datos Ingresados Incorrectos");
                }
            }
        }
    }
}
