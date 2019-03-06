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
}


// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
    public class IdeaPOCO
    {

        int _nameId;
        [DataMember]
        public int NameId
        {
            get { return _nameId; }
            set { _nameId = value; }
        }

        string _name;
        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        string _ideaText;
        [DataMember]
        public string IdeaText
        {
            get { return _ideaText; }
            set { _ideaText = value; }
        }
    }

