using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDALC;

namespace BibliotecaClase
{
    public class ClientesParacBox
    {
        public string rutDeMiCli { get; set; }
        public ClientesParacBox()
        {

        }

        public override string ToString()
        {
            return this.rutDeMiCli;
        }
        private OnBreakEntities bdd = new OnBreakEntities();
        public List<ClientesParacBox> ReadAll()
        {

            var listaRuts = from cli in bdd.Cliente
                                    select new ClientesParacBox
                                    {
                                       rutDeMiCli = cli.RutCliente, 
                                    };
            return listaRuts.ToList();

        } 
    }

}
