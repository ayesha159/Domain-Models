using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfContactsManagementSystem
{
    
    public class Service1 : IService1
    {
      public   bool IsValidUser(string userName, string password)
        {
            Boolean isFound = false;
            foreach (myUser u in dataClass.usersList)
            {
                if (u.Username == userName  && u.Userpwd ==password)
                {
                    isFound = true;
                    myUtill.loginUser = u;

                }
            }
            return isFound;
        }
    public  void IsUserRegister(string userName, string password, string Email,string MobileNo)
        {
            myUser u = new myUser();
            
            int _lastUserid = 1;
            foreach (myUser usr in dataClass.usersList)
            {
                _lastUserid = Convert.ToInt16(usr.Userid);
               
            }
            _lastUserid++;

            u.Userid = _lastUserid.ToString();
            u.Username = userName;
            u.Userpwd = password;
            u.email = Email;
            u.mobileno = MobileNo;
           dataClass.usersList.Add(u);
        }

        public string RecoverPwdE(string email)
        {
            string zzz = "";

            foreach (myUser u in dataClass.usersList)
            {
                if (email == u.email)
                {
                    return u.Userpwd;
                }
            }

            return "invalid user or User no Registered with this email";
        }

        public string RecoverPwdS(string MobNo)
        {
            foreach (myUser u in dataClass.usersList)
            {
                if (MobNo == u.mobileno)
                {
                    return u.Userpwd;

                }
            }

            return "invalid user or User no Registered with this Mobile No.";
        }
        //public bool AddGroup(string userId, string GrpName)
        //{

        //}
    }
}
