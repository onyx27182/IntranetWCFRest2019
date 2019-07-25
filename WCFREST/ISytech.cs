using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFREST
{

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class PeoplePOCO
    {

        int _id;
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _firstName;
        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
    }

    [DataContract]
    public class IdeaPOCO
    {

        int _id;
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _name;
        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        string _text;
        [DataMember]
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

    }
}



