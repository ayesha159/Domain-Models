using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfContacts;

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
    public  void IsUserRegister(string userName, string password)
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

           dataClass.usersList.Add(u);
        }

        //public bool AddGroup(string userId, string GrpName)
        //{

        //}
    }
}
