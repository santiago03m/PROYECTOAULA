using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using CONECTOR;
using Newtonsoft.Json;
using RestSharp;
namespace GUIClientes
{
    internal class DBapi
    {
        public static dynamic Get(string urlApi)

            {
                HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
                objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
                objPedido.Credentials = CredentialCache.DefaultCredentials;
                objPedido.Proxy = null;
                HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
                Stream objFlujo = objRespuesta.GetResponseStream();
                StreamReader objFlujoLectura = new StreamReader(objFlujo);
                string datosJson = HttpUtility.HtmlDecode(objFlujoLectura.ReadToEnd());
                dynamic datos = JsonConvert.DeserializeObject(datosJson);
                return datos;
        }

        public static bool CreateCredito(string urlApi, Credito credito)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
            objPedido.Method = "POST";
            objPedido.ContentType = "application/json";
            objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101  Firefox/23.0";
            objPedido.Proxy = null;

            string jsonData = JsonConvert.SerializeObject(credito);
            byte[] byteArray = Encoding.UTF8.GetBytes(jsonData);

            using (Stream dataStream = objPedido.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            try
            {
                HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
                return objRespuesta.StatusCode == HttpStatusCode.Created;
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)ex.Response)
                    {
                        if (errorResponse.StatusCode == HttpStatusCode.BadRequest)
                        {
                            return false;
                        }
                    }
                }
                throw;
            }
        }

        public static dynamic Post(string urlApi, string json, string autorizacion = null)

            {

                Method op = Method.Post;

            return operaciones(urlApi, json, autorizacion, op);

        }

        public static bool UpdateCredito(string urlApi, int id, Credito credito)
        {
            string fullUrl = urlApi + "/actualizar/" + id;
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(fullUrl);
            objPedido.Method = "PUT";
            objPedido.ContentType = "application/json";
            objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101  Firefox/23.0";
            objPedido.Proxy = null;

            string jsonData = JsonConvert.SerializeObject(credito);
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

        public static bool DeleteCredito(string urlApi, int id)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create($"{urlApi}/eliminar/{id}");
            objPedido.Method = "DELETE";
            objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101  Firefox/23.0";
            objPedido.Proxy = null;

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

        private static dynamic operaciones(string urlApi, string json, string autorizacion, Method op)

            {

                try

                {

                    var objCliente = new RestClient(urlApi);

                    var objPedido = new RestRequest();

                    objPedido.Method = op;

                    objPedido.AddHeader("content-type", "application/json");

                    objPedido.AddParameter("application/json", json, ParameterType.RequestBody);

                    if (autorizacion != null)

                    {

                        objPedido.AddHeader("Authorization", autorizacion);

                    }

                    RestResponse objRespuesta = objCliente.Execute(objPedido);

                    dynamic datos = JsonConvert.DeserializeObject(objRespuesta.Content);

                    return datos;

                }

                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);

                    return null;

                }

            }

        }
    }

