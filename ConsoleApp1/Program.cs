using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ConsoleApp1.ServiceReference1;
using System.Runtime.Serialization.Json;
using System.IO;
using RestSharp;
using WCFREST;

namespace ConsoleApp1
{

    public class PeoplePOCO
    {

        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
    }
    public class input
    {
        public string idea { get; set; }
    }

    class Program
    {

        private static async Task PutDataAsync()
        {


            String decoded = null;
            RestSharp.RestResponse p = default(RestSharp.RestResponse);
            byte[] b = new byte[0];

            var client = new RestClient("http://localhost/WCFREST/SytechService.svc/SaveIdea");
            RestRequest request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Accept", "application/json");


            IdeaText idea = new IdeaText { Idea = "What a great one!" };

            /*
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer serializerToUpload = new DataContractJsonSerializer(typeof(Idea));
            serializerToUpload.WriteObject(ms, idea);
            */

            request.AddJsonBody(idea);

            var obj = await client.ExecuteTaskAsync(request);
            try
            {

                b = obj.RawBytes;
                decoded = Encoding.UTF8.GetString(b);

            }
            catch (Exception ex)
            {

            }
        }



        private static async Task<string> GetDataAsync(string url)
        {
          
 
            String decoded = null;
            RestSharp.RestResponse p = default(RestSharp.RestResponse);
            byte[] b = new byte[0];
            var client = new RestClient("http://localhost/WCFREST/SytechService.svc");
            var request = new RestRequest("/GetPeople", Method.GET);
            var restClient = new RestClient(url);
            var obj = await client.ExecuteTaskAsync(request);
            try
            {

                b = obj.RawBytes;
                decoded = Encoding.UTF8.GetString(b);

            }
            catch (Exception ex)
            {
               
            }
            return decoded;
        }

        static void Main(string[] args)
        {

            try
            {
                Console.ReadLine();
                Thread.Sleep(5);
                Task<string> p = Program.GetDataAsync("http://localhost/WCFREST/SytechService.svc");
                Task tt =  Program.PutDataAsync();
                Console.WriteLine("p");
                Console.ReadLine();
                
            }
            catch
            {
                // never gets called
            }





            //  ServiceReference2.SytechClient client = new ServiceReference2.SytechClient();


            // ServiceReference1.SytechServiceClient client = new ServiceReference1.SytechServiceClient();

            //var p = client.GetIdeas();
            /// var peeps = client.GetPeople();
            /// 
            //   SytechClient client = new SytechClient(@"http://localhost:4007");
            //  var p = client.GetPeople();
            //   var s = client.GetIdeas();
            var t = 9;

            /*
            
            var r = HttpWebRequest.Create(@"http://localhost/WCFREST/SytechService.svc");
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

            try
            {
                HttpWebRequest http = (HttpWebRequest)WebRequest.Create("http://empoweredai.com/SytechService.svc/GetPeople");
                WebResponse response = http.GetResponse();
                Console.ReadLine();
                int y = 9;
            }
            catch(Exception ex)
            {

            }

            /*
            try
            {
                var client = new RestClient(@"http://empoweredai.com/SytechService.svc/");
                var request = new RestRequest("GetPeople/", Method.GET);
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string
            }
            catch (Exception ex)
            {

            }
            */

            /*
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                //var url = @"http://localhost/WCFREST/SytechService.svc/GetIdeas";
                var url = @" http://empoweredai.com/SytechService.svc/GetPeople";
                try
                {
                   var t0  = client.DownloadData(url);
                   int y   = 0;
                }
                catch(Exception ex)
                {

                }
               // Stream stream = new MemoryStream(data);
               // DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(EmployeeDataContract));
               // EmployeeDataContract employee = obj.ReadObject(stream) as EmployeeDataContract;

                //byte[] result = client.UploadData(url, null);
                //var x = Encoding.UTF8.GetString(result);
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
