using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUser_Contact_Management_System
{
    class MyGroup
    {
        private string _userid;
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

        private string grpName;
        public string GrpName
        {
            get { return grpName; }
            set { grpName = value; }
        }

    }
}
