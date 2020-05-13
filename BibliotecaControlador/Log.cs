using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaControlador
{
    public class Logger
    {
        public static void Mensaje(string msg)
        {
            msg = DateTime.Now + " | " + msg + Environment.NewLine;
            File.AppendAllText(@"d:\log.txt", msg);
        }
    }
}
