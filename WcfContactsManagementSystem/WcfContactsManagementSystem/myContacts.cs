using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfContactsManagementSystem
{ 
    class myContacts
    { private string _userid;
        public string Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

       
        private string grpId;
        public string GrpId
        {
            get { return grpId; }
            set { grpId = value; }
        }

        private string ConId;
        public string conId
        {
            get { return ConId; }
            set { ConId = value; }
        }

        private string conName;
        public string ConName
        {
            get { return conName; }
            set { conName = value; }
        }

        private string conMob;
        public string ConMob
        {
            get { return conMob; }
            set { conMob = value; }
        }

        private string conEmail;
        public string ConEmail
        {
            get { return conEmail; }
            set { conEmail = value; }
        }

        private string conDOB;
        public string ConDob
        {
            get { return conDOB; }
            set { conDOB = value; }
        }
        private string conAddr;
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
