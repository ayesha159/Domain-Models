using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfContactsManagementSystem
{

    [DataContract]
    public class myGroup
    {

        private string _userid;
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

        private string grpName;
        [DataMember]
        public string GrpName
        {
            get { return grpName; }
            set { grpName = value; }
        }
        //bool AddGroup();
        //bool GroupCreater();
        //bool UpdateGroup();
        //bool DeleteGroup();
   
    }
}