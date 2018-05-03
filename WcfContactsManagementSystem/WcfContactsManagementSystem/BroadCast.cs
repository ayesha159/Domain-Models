using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfContactsManagementSystem
{
    class BroadCast
    {
               
        private string userID;
        public string UserID
        {
             get { return userID; }
            set { userID = value; }
        }
       

        private string MobileNo;
        public string MobileNo1
        {   
            get { return MobileNo; }
            set { MobileNo = value; }
        }
      
        private bool SentSMS;
        public bool SentSMS1
        {
            get { return  SentSMS; }
            set {  SentSMS = value; }
        }
        
        private DateTime SentMsg;
        public DateTime SentMsg1
        {
            get { return SentMsg; }
            set { SentMsg = value; }
        }
        //bool AddBroadcast();     
    }
}
