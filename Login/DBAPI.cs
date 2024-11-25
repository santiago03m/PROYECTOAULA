using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Login
{
    internal class DBAPI
    {
        public static List<Usuario> Get(string urlApi)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
            objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101  Firefox/23.0";
            //objPedido.Credentials = CredentialCache.DefaultCredentials;
            objPedido.Proxy = null;

            HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
            Stream objFlujo = objRespuesta.GetResponseStream();
            StreamReader objFlujoLectura = new StreamReader(objFlujo);

            string datosJson = HttpUtility.HtmlDecode(objFlujoLectura.ReadToEnd());
            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(datosJson);
            return usuarios;

        }

        public static bool Update(string urlApi, Usuario usuario)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
            objPedido.Method = "PUT";
            objPedido.ContentType = "application/json";
            objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101  Firefox/23.0";
            objPedido.Proxy = null;

            string jsonData = JsonConvert.SerializeObject(usuario);
            byte[] byteArray = Encoding.UTF8.GetBytes(jsonData);

            using (Stream dataStream = objPedido.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            try
            {
                HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
                return objRespuesta.StatusCode == HttpStatusCode.OK;
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)ex.Response)
                    {
                        if (errorResponse.StatusCode == HttpStatusCode.NotFound)
                        {
                            return false;
                        }
                    }
                }
                throw;
            }
        }

    }
}
