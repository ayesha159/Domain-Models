using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace WcfContactsManagementSystem
{
     [DataContract]
  public  class myContacts
    { private string _userid;
           [DataMember]
        public string Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

       
        private string grpId;
           [DataMember]
        public string GrpId
        {
            get { return grpId; }
            set { grpId = value; }
        }

        private string ConId;
           [DataMember]
        public string conId
        {
            get { return ConId; }
            set { ConId = value; }
        }

        private string conName;
           [DataMember]
        public string ConName
        {
            get { return conName; }
            set { conName = value; }
        }

        private string conMob;
           [DataMember]
        public string ConMob
        {
            get { return conMob; }
            set { conMob = value; }
        }

        private string conEmail;
           [DataMember]
        public string ConEmail
        {
            get { return conEmail; }
            set { conEmail = value; }
        }

        private string conDOB;
           [DataMember]
        public string ConDob
        {
            get { return conDOB; }
            set { conDOB = value; }
        }
        private string conAddr;
           [DataMember]
        public string ConAddr
        {
            get { return conAddr; }
            set { conAddr = value; }
        }
        //bool AddContact();
        //bool UpdateContact();
        //bool DeleteContact();
        //bool ImportContact();
        //bool SearchContact();
        
    }
}
