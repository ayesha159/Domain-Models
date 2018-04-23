using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUser_Contact_Management_System
{
    class BroadCast
    {
               
        private string userID;
        public string UserID
        {
            get => userID;
            set => userID = value;
        }
       

        private string MobileNo;
        public string MobileNo1
        {   get => MobileNo;
            set => MobileNo = value;
        }
      
        private bool SentSMS;
        public bool SentSMS1
        {
            get => SentSMS;
            set => SentSMS = value;
        }
        
        private DateTime SentMsg;
        public DateTime SentMsg1
        {
            get => SentMsg;
            set => SentMsg = value;
        }
        //bool AddBroadcast();     
    }
}
