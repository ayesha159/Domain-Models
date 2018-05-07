using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;


namespace WcfContactsManagementSystem
{

    public class Service1 : IService1
    {
        public bool IsValidUser(string userName, string password, ref string curUsr)
        {
            Boolean isFound = false;
            foreach (myUser u in dataClass.usersList)
            {
                if (u.Username == userName && u.Userpwd == password)
                {
                    isFound = true;
                    myUtill.loginUser = u;

                }
            }
            return isFound;
        }
        public void IsUserRegister(string userName, string password, string Email, string MobileNo)
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



        public bool ChangePwd(string Id, string txtOld, string txtNew, string txtNewRe)
        {
            if (txtOld.Trim().Length == 0)
            { return false; }
            if (txtNew.Trim() != txtNewRe.Trim())
            {
                return false;
            }
            string _thisid = "";

            foreach (myUser u in dataClass.usersList)
            {

                _thisid = u.Userid.ToString().Trim();
                if (_thisid != Id)
                {
                    myUser ust = new myUser();

                    ust.Userid = u.Userid;
                    ust.Username = u.Username; // error fixed
                    ust.email = u.email;
                    ust.mobileno = u.mobileno;
                    ust.Userpwd = u.Userpwd;
                    dataClass.usersListTemp.Add(ust);
                }
                else
                {
                    myUser ust = new myUser();
                    ust.Userid = u.Userid;
                    ust.Username = u.Username;// error fixed
                    ust.email = u.email;
                    ust.mobileno = u.mobileno;
                    ust.Userpwd = txtNew.Trim();
                    dataClass.usersListTemp.Add(ust);
                }
            }
            int tc = 0;
            foreach (myUser us in dataClass.usersList)
            {
                tc++;
            }
            dataClass.usersList.RemoveRange(0, tc);

            foreach (myUser uout in dataClass.usersListTemp)
            {
                myUser us = new myUser();
                us.Userid = uout.Userid;
                us.Username = uout.Username;// error fixed
                us.email = uout.email;
                us.mobileno = uout.mobileno;
                us.Userpwd = uout.Userpwd;
                // dataClass.usersListTemp.Add(us); // error fixed 
                dataClass.usersList.Add(us);

            }

            // _name = myGrp.GrpName.ToString();

            return true;

        }

        public bool AddGroup(string GrpName, ref string userId)
        {
            int _id = 0;
            string _name = "";

            foreach (myGroup myG in dataClass.usersGroupsArrayList)
            {
                _id = Convert.ToInt16(myG.GrpId.ToString());
                _name = myG.GrpName.ToString();
            }
            if (_id == 0) _id = 1;
            else _id++;

            myGroup g = new myGroup();

            g.GrpName = GrpName;
            g.GrpId = _id.ToString();

            g.Userid = myUtill.loginUser.Userid;

            dataClass.usersGroupsArrayList.Add(g);
            return true;


        }

        public bool DeleteGroup(string idgrp)
        {
            int c = 0;
            foreach (myGroup grp in dataClass.usersGroupsArrayList)
            {
                if (grp.GrpId == idgrp)
                {
                    break;
                }
                c++;
            }
            dataClass.usersGroupsArrayList.RemoveAt(Convert.ToInt16(c));
            return true;
        }
        public bool UpdateGroup(string grpid, string grpname)
        {
            int tc = 0;
            // algo1
            foreach (myGroup myGrp in dataClass.usersGroupsArrayList)
            {

                myGroup myGrp1 = new myGroup();
                myGrp1.GrpId = myGrp.GrpId;

                if (grpid != myGrp.GrpId)
                {
                    myGrp1.GrpName = myGrp.GrpName;
                }
                else
                    myGrp1.GrpName = grpname;
                dataClass.usersGroupsArrayListtmp.Add(myGrp1);

            }

            dataClass.usersGroupsArrayList.Clear();

            foreach (myGroup g in dataClass.usersGroupsArrayListtmp)
            {
                myGroup myGrp1 = new myGroup();
                myGrp1.GrpId = g.GrpId;
                myGrp1.GrpName = g.GrpName;
                dataClass.usersGroupsArrayList.Add(myGrp1);
            }
            dataClass.usersGroupsArrayListtmp.Clear();
            //dataClass.usersGroupsArrayList.RemoveRange(0, tc);
            return true;
        }

        public List<myGroup> GetData()
        {
            return dataClass.usersGroupsArrayList;

        }




        public bool AddContact()
        {
            int _id = 0;
            string _name = "";

            foreach (myContacts myCon in dataClass.usersContactsArrayList)
            {
                _id = Convert.ToInt16(myCon.conId.ToString());
                _name = myCon.ConName.ToString();
            }
            if (_id == 0) _id = 1;
            else _id++;

            return true;
        }
        public bool DeleteContact(string delgrp)
        {

            dataClass.usersContactsArrayList.RemoveAt(Convert.ToInt16(delgrp));
            return true;


        }
        public bool UpdateContacts()
        {

            int tc = 0;
            foreach (myContacts mc in dataClass.usersContactsArrayList)
            {
                tc++;

            }

            dataClass.usersContactsArrayList.RemoveRange(0, tc);

            return true;
        }

    }



}