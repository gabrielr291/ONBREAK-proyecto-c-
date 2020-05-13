using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace BibliotecaClase
{
    public class datosUF
    {
        public string entregarUF(string fechaHoy)
        {
            //web service externo
            clsDatosUF datos;
            HttpWebRequest reques = (HttpWebRequest)WebRequest.Create(@"https://mindicador.cl/api/uf/" + fechaHoy);
            HttpWebResponse response = (HttpWebResponse)reques.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader stream_reader = new StreamReader(stream);
            var json = stream_reader.ReadToEnd();
            datos = JsonConvert.DeserializeObject<clsDatosUF>(json);

            //Cargar el Valor UF
            string uf = "";
            foreach (Serie item in datos.serie)
            {
                uf = item.valor;
            }
            uf = uf.Replace('.', ',');

            return uf;
        }
    }
}
