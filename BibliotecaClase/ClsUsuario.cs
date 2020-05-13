using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDALC;
namespace BibliotecaClase
{
    public class clsUsuario
    {
        public static List<clsUsuario> usuarios;
        public string user { get; set; }
        public string pass { get; set; }

        public  clsUsuario()
        {
            if (usuarios == null)
            {
                usuarios = new List<clsUsuario>();
                clsUsuario usuario = new clsUsuario();
                usuario.user = "admin";
                usuario.pass = "1234";
                usuarios.Add(usuario);
            }
        }

        public bool login()
        {
            try
            {
                foreach (var item in usuarios)
                {
                    if (item.user.Equals(this.user) && item.pass.Equals(this.pass))
                    {
                        return true;
                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Al iniciar: " + ex.Message);
                return false;
            }
        }
    }
}
