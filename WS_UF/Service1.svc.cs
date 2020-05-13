using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;


namespace WS_UF
{
    public class Service1 : IService1
    {
        public double Uf()
        {
            ClUF datos;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://mindicador.cl/api/uf");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader stream_reader = new StreamReader(stream);
            var json = stream_reader.ReadToEnd();
            datos = JsonConvert.DeserializeObject<ClUF>(json);
            string uf = " ";
            foreach (Serie item in datos.serie)
            {
                uf = item.valor;
            }
            uf = uf.Replace('.', ',');
            return double.Parse(uf);

        }
    }   
}
