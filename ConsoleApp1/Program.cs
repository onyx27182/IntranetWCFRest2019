using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ServiceReference1;
using ConsoleApp1.ServiceReference2;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          //  ServiceReference2.SytechClient client = new ServiceReference2.SytechClient();


            ServiceReference2.SytechClient client = new ServiceReference2.SytechClient();


            /// var peeps = client.GetPeople();
            /// 
            //   SytechClient client = new SytechClient(@"http://localhost:4007");
            //  var p = client.GetPeople();
            //   var s = client.GetIdeas();
            var t = 9;
            /*
            var r = HttpWebRequest.Create(@"http://localhost:4007/SytechService/GetIdeas");
            r.ContentType = @"application/json; charset=utf-8";
            r.Method = "GET";
            HttpWebResponse webresponse = null;

            try
            {
                webresponse = r.GetResponse() as HttpWebResponse;
            }
            catch( Exception e)
            {

            }

            r.ContentType = @"application/xml";
            r.Method = "GET";
            HttpWebResponse webresponse2 = null;

            try
            {
                webresponse2 = r.GetResponse() as HttpWebResponse;
            }
            catch (Exception e)
            {

            }

            */
            /*
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var url = "@http://localhost:4007/SytechService./GetIdeas";
         
               
                byte[] result = client.UploadData(url, null);
                var x = Encoding.UTF8.GetString(result);
            }

            */



            /*
                        string responseText = null;
                        var encoding = ASCIIEncoding.ASCII;
                        using (var reader = new System.IO.StreamReader(webresponse.GetResponseStream(), encoding))
                        {
                            responseText = reader.ReadToEnd();
                        }
                        */

            /*
            using (WebResponse response = r.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    
                }
            }*/
            // Now do whatever you want with doc here




        }
    }
}
