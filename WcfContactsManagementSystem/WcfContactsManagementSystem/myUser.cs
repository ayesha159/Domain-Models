using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfContacts
{
    public class myUser
    {
        private string _userid;
        public string Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }


        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        private string _password;
        public string Userpwd
        {
            get { return _password; }
            set { _password = value; }
        }


        private bool _userIsAdmin;

        public bool UserIsAdmin
        {
            get { return _userIsAdmin; }
            set { _userIsAdmin = value; }
        }

        //void RegisterUser(string UserName, string password);
        //bool isValidUser(string UserName, string password);

    }
}
