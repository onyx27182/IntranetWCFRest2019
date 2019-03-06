using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using WCFREST.Data;

namespace WCFREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SytechService 
    {
        public SytechService()
        {
        }

        [OperationContract]
        [WebGet(
         UriTemplate = "/GetPeople",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Wrapped
         )
       ]
        public List<PeoplePOCO> GetPeople()
        {
           return DbManager.GetPeople();
        }

        /*
        public List<IdeaPOCO> GetIdeas()
        {
          //  return DbManager.GetIdeas();

        }
        */
        /*
        [OperationContract]
        [WebInvoke(Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "Idea/{personId}"
            )]
        public List<IdeaPOCO> GetIdeas(string Ide)
        {
            return DbManager.GetIdeas();
        }

        public List<PeoplePOCO> GetPeople(string id)
        {
            return DbManager.GetPeople();
        }

        public void SaveIdea(string ideaText, string personId)
        {
            throw new NotImplementedException();
        }

        */
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
