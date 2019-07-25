using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using WCFREST.Data;
using WCFREST.SignalR;

namespace WCFREST
{


    [DataContract]
    public class IdeaText
    {
        [DataMember]
        public string Idea { get; set; }


    }


    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SytechService 
    {

        static IDisposable _signalr;

        public SytechService()
        {
        }

        static SytechService()
        {
            try
            {
                _signalr = WebApp.Start<SignalrStartup>("http://*:8080/");
            }
            catch (Exception ex)
            {

            }
        }


        [OperationContract]
        [WebGet(
         UriTemplate = "/GetPeople",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare
         )
       ]
        public List<PeoplePOCO> GetPeople()
        {
            return DbManager.GetPeople();
        }

        [OperationContract]
        [WebGet(
         UriTemplate = "/GetIdeas",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare
        )
        ]
        public List<IdeaPOCO> GetIdeas()
        {
          return DbManager.GetIdeas();

        }

        public class Result
        {
            public string Status { get; set; }
            public bool IsOkay { get; set; } = true;

            public string Stack { get; set; }
        }


        /*
        [OperationContract]
        [WebInvoke(Method = "OPTION",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "/SaveIdea"
            )]
        public Result SaveIdea()
        {
            return new Result { IsOkay = true, Status = "" };
        }
        */



        [OperationContract]
        [WebInvoke(Method = "*",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "/SaveIdea"
            )]
        public Result SaveIdea(IdeaText idea)
        {
            string status = "preflight request";
            bool bOkay = true;

            if (idea != null)
            {
                string errMsg = null;
                if (string.IsNullOrEmpty(idea.Idea))
                {
                    errMsg = "empty idea text entered";
                    bOkay = false;
                }

                if (bOkay)
                {
                    errMsg = DbManager.SaveIdea(idea.Idea);

                    if (!string.IsNullOrEmpty(errMsg))
                    {
                        bOkay = false;
                        status = errMsg;
                    }
                }

                /*
                catch(Exception ex)
                {
                    bOkay = false;
                    errMsg = $"Exception occurred in SaveIdea();{ ex.Message}\r\n{ex.StackTrace}";

                    throw new WebFaultException<Result>(
                        new Result { IsOkay = false, Status = ex.Message, Stack = ex.StackTrace },
                        HttpStatusCode.InternalServerError);
                }
                */
            }
            return new Result { IsOkay = bOkay, Status = status };
        }

        public List<PeoplePOCO> GetPeople(string id)
        {
            return DbManager.GetPeople();
        }

    
        
        /*
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        */

    }
}
