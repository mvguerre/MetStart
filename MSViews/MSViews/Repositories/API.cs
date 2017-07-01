using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MSViews.Repositories
{
    public class API
    {
        private static string baseIP = "localhost:54586";

        private static string baseUrl = "http://"+baseIP+"/"; 
        //private static string RRHHBaseUrl = baseUrl + "rrhh-ph/";

        public static string BaseUrl { get { return baseIP; } }
        internal static string GetBaseUrl()
        {
            return baseUrl;
        }

        // Returns JSON string
        public static string PerformGETRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }
        // POST a JSON string
        public static Tuple<HttpStatusCode, string> PerformPostRequest(string url, string jsonContent)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(jsonContent);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            long length = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    length = response.ContentLength;

                    string responseString;
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                        responseString = reader.ReadToEnd();
                    }
                    Tuple<HttpStatusCode, string> res = new Tuple<HttpStatusCode, string>(response.StatusCode, responseString);
                    return res;
                }
            }
            catch (WebException)
            {
                // Log exception and throw as for GET example above
                //MessageBox.Show("Error de conexión, comuniquese con el proveedor de Internet");
                return null;
            }
        }
    }
}
