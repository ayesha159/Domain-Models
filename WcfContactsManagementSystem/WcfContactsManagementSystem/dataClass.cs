using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace WcfContactsManagementSystem
{
    public class dataClass
    {
        public static List<myUser> usersList = new List<myUser>();
        public static List<myGroup> usersGroupsArrayList = new List<myGroup>();
        public static List<myGroup> usersGroupsArrayListtmp = new List<myGroup>();
        public static List<myContacts> usersContactsArrayList = new List<myContacts>();
        public static List<myContacts> usersContactsArrayListtmp = new List<myContacts>();
        public static ArrayList smsArrayList = new ArrayList();
        public static ArrayList usersListTemp = new ArrayList();
        public static List<myContacts> SearchList = new List<myContacts>();
    }
}