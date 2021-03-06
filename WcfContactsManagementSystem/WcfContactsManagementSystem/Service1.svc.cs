﻿using System;
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
                    curUsr = u.Userid;
                }
            }
            return isFound;
        }
        public void IsUserRegister(string userName, string password, string Email, string MobileNo)
        {
            myUser u = new myUser();

            int _lastUserid = 0;
            foreach (myUser usr in dataClass.usersList)
            {
                _lastUserid = Convert.ToInt16(usr.Userid);

            }
            _lastUserid++;

            bool _tf = false;
            if (_lastUserid == 1) _tf = true;
            else _tf = false;

            u.Userid = _lastUserid.ToString();
            u.Username = userName;
            u.Userpwd = password;
            u.email = Email;
            u.mobileno = MobileNo;
            u.UserIsAdmin = _tf;

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

        public bool AddGroup(string GrpName, ref string userId, string userName)
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
            g.Username = userName;
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
        public bool UpdateGroup(string grpid, string grpname, string username)
        {
           ;
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
                myGrp1.Username = username;
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

        public List<myGroup> GetData(string _id)
        {
            dataClass.usersGroupsArrayListtmp.Clear();
            if (_id == "1")
            {
                foreach (myGroup g in dataClass.usersGroupsArrayList)
                {
                        myGroup grp = new myGroup();
                        grp.GrpId = g.GrpId;
                        grp.GrpName = g.GrpName;
                        grp.Userid = g.Userid;
                    grp.Username = grpCreator(_id);
                        dataClass.usersGroupsArrayListtmp.Add(grp);
                }
                return dataClass.usersGroupsArrayListtmp;
            }
            else
            {
                foreach(myGroup g in dataClass.usersGroupsArrayList)
                {
                    if (g.Userid == _id)
                    {
                        myGroup grp = new myGroup();
                        grp.GrpId = g.GrpId;
                        grp.GrpName = g.GrpName;
                        grp.Userid = g.Userid;
                        //grp.Username = grpCreator(_id);
                        dataClass.usersGroupsArrayListtmp.Add(grp);
                    }
                }
                return dataClass.usersGroupsArrayListtmp;
            }

            return null;
        }
        
        public List<myContacts> GetCon()
        {
            return dataClass.usersContactsArrayList;

        }

        public List<myUser> GetUser()
        {
            return dataClass.usersList;

        }
        public bool AddContact(string userId, string grpId, string name, string DOB, string moblieNo, string email, string address)
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

            myContacts con = new myContacts();
            con.Userid = userId;
            con.GrpId = grpId;
            con.conId = _id.ToString();
            con.ConName = name;
            con.ConDob = DOB;
            con.ConMob = moblieNo;
            con.ConEmail = email;
            con.ConAddr = address;
            dataClass.usersContactsArrayList.Add(con);

            return true;
        }
        public bool DeleteContact(string idcon)
        {

            int b = 0;
            foreach (myContacts c in dataClass.usersContactsArrayList)
            {
                if (c.conId == idcon)
                {
                    break;
                }
                b++;
            }
            dataClass.usersGroupsArrayList.RemoveAt(Convert.ToInt16(b));

            return true;

        }
        public bool UpdateContacts(string conid, string name, string DOB, string moblieNo, string email, string address)
        {
                       // algo1
            foreach (myContacts con in dataClass.usersContactsArrayList)
            {

                myContacts myCon1 = new myContacts();
                myCon1.conId = con.conId;

                if (conid != con.conId)
                {
                    myCon1.ConName = con.ConName;
                    myCon1.ConDob = con.ConDob;
                    myCon1.ConMob = con.ConMob;
                    myCon1.ConAddr = con.ConAddr;
                    myCon1.ConEmail = con.ConEmail;

                }
                else
                {
                    myCon1.ConName = name;
                    myCon1.ConDob = DOB;
                    myCon1.ConMob = moblieNo;
                    myCon1.ConAddr = address;
                    myCon1.ConEmail = email;
                }
                dataClass.usersContactsArrayListtmp.Add(myCon1);
            }

            dataClass.usersContactsArrayList.Clear();
            foreach(myContacts c in dataClass.usersContactsArrayListtmp)
            {
                myContacts co = new myContacts();
                co.conId = c.conId;
                co.ConName = c.ConName;
                co.ConDob = c.ConDob;
                co.ConMob = c.ConMob;
                co.ConAddr = c.ConAddr;
                co.ConEmail = c.ConEmail;
                dataClass.usersContactsArrayList.Add(co);
            }
            dataClass.usersContactsArrayListtmp.Clear();
            //dataClass.usersGroupsArrayList.RemoveRange(0, tc);
            return true;
        }
        public string ImportContacts(string name, string DOB, string moblieNo, string email, string address, string userId, string grpId)
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

            myContacts con = new myContacts();
            con.Userid = userId;
            con.GrpId = grpId;
            con.conId = _id.ToString();
            con.ConName = name;
            con.ConDob = DOB;
            con.ConMob = moblieNo;
            con.ConEmail = email;
            con.ConAddr = address;
            dataClass.usersContactsArrayList.Add(con);
            return "";

        }


        public List<myContacts> SearchCbyName(string userId, string grpId, string name)
        {
            dataClass.SearchList.Clear();
            foreach (myContacts mc in dataClass.usersContactsArrayList)
            {
                string usid = mc.Userid.ToString();
                string gpid = mc.GrpId.ToString().Trim();
                if (userId == usid)
                {
                    if (grpId == gpid)
                    {
                        if (mc.ConName.Trim().ToLower() == name.Trim())
                        {
                            string[] row0 = { mc.Userid, mc.GrpId, mc.conId, mc.ConName, mc.ConMob, mc.ConEmail, mc.ConDob, mc.ConAddr };
                            dataClass.SearchList.Add(mc);
                           
                        }
                    }
                }

            }
            return dataClass.SearchList;
        }
      
        public  List<myContacts> SSTG(string userid,string grpid)
        {
                foreach (myContacts c in dataClass.usersContactsArrayList)
                {
                   if (userid==c.Userid & grpid == c.GrpId)
                   {
                    myContacts con = new myContacts();
                    con.Userid = c.Userid;
                    con.GrpId = c.GrpId;
                    con.conId = c.conId;
                    con.ConName = c.ConName;
                    con.ConDob = c.ConDob;
                    con.ConMob = c.ConMob;
                    con.ConEmail = c.ConEmail;
                    con.ConAddr = c.ConAddr;
                    dataClass.usersContactsArrayListtmp.Add(con);
                }
                }
            
            return dataClass.usersContactsArrayListtmp;
        }

        public List<myContacts> SSTC( string userid, string grpid)
        {
            foreach (myContacts c in dataClass.usersContactsArrayList)
            {
                if (userid == c.Userid)
                {
                    myContacts con = new myContacts();
                    con.Userid = c.Userid;
                    con.GrpId = c.GrpId;
                    con.conId = c.conId;
                    con.ConName = c.ConName;
                    con.ConDob = c.ConDob;
                    con.ConMob = c.ConMob;
                    con.ConEmail = c.ConEmail;
                    con.ConAddr = c.ConAddr;
                    dataClass.usersContactsArrayListtmp.Add(con);
                }
            }

            return dataClass.usersContactsArrayListtmp;
        }

        public List<myContacts> SearchCbyDob(string userId, string grpId, string dob)
        {
            dataClass.SearchList.Clear();
            foreach (myContacts mc in dataClass.usersContactsArrayList)
            {
                string usid = mc.Userid.ToString();
                string gpid = mc.GrpId.ToString().Trim();
                if (userId == usid)
                {
                    if (grpId == gpid)
                    {
                        if (mc.ConDob.Trim().ToLower() == dob.Trim())
                        {
                            string[] row0 = { mc.Userid, mc.GrpId, mc.conId, mc.ConName, mc.ConMob, mc.ConEmail, mc.ConDob, mc.ConAddr };
                            dataClass.SearchList.Add(mc);

                        }
                    }
                }

            }
            return dataClass.SearchList;
        }

        public List<myContacts> SearchCbyEmail(string userId, string grpId, string email)
        {
            dataClass.SearchList.Clear();
            foreach (myContacts mc in dataClass.usersContactsArrayList)
            {
                string usid = mc.Userid.ToString();
                string gpid = mc.GrpId.ToString().Trim();
                if (userId == usid)
                {
                    if (grpId == gpid)
                    {
                        if (mc.ConEmail.Trim().ToLower() == email.Trim())
                        {
                            string[] row0 = { mc.Userid, mc.GrpId, mc.conId, mc.ConName, mc.ConMob, mc.ConEmail, mc.ConDob, mc.ConAddr };
                            dataClass.SearchList.Add(mc);

                        }
                    }
                }

            }
            return dataClass.SearchList;
        }
        public List<myContacts> SearchCbyMob(string userId, string grpId, string mob)
        {
            dataClass.SearchList.Clear();
            foreach (myContacts mc in dataClass.usersContactsArrayList)
            {
                string usid = mc.Userid.ToString();
                string gpid = mc.GrpId.ToString().Trim();
                if (userId == usid)
                {
                    if (grpId == gpid)
                    {
                        if (mc.ConMob.Trim().ToLower() == mob.Trim())
                        {
                            string[] row0 = { mc.Userid, mc.GrpId, mc.conId, mc.ConName, mc.ConMob, mc.ConEmail, mc.ConDob, mc.ConAddr };
                            dataClass.SearchList.Add(mc);

                        }
                    }
                }

            }
            return dataClass.SearchList;
        }
        public List<myContacts> ShowAllContacts(string userId, string grpId)
        {
            dataClass.SearchList.Clear();
            foreach (myContacts mc in dataClass.usersContactsArrayList)
            {
                string usid = mc.Userid.ToString();
                string gpid = mc.GrpId.ToString().Trim();
                if (userId == usid)
                {
                    
                        string[] row0 = { mc.Userid, mc.GrpId, mc.conId, mc.ConName, mc.ConMob, mc.ConEmail, mc.ConDob, mc.ConAddr };
                        dataClass.SearchList.Add(mc);
                }

            }
            return dataClass.SearchList;
        }

        public List<myContacts> ShowContactsSMS(string userId, string grpId)
        {
            dataClass.SearchList.Clear();
            foreach (myContacts mc in dataClass.usersContactsArrayList)
            {
                string usid = mc.Userid.ToString();
                string gpid = mc.GrpId.ToString().Trim();
                if (userId == usid)
                {
                    if (grpId == gpid)
                    {
                        string[] row0 = { mc.Userid, mc.GrpId, mc.conId, mc.ConName, mc.ConMob, mc.ConEmail, mc.ConDob, mc.ConAddr };
                        dataClass.SearchList.Add(mc);
                    }
                }

            }
            return dataClass.SearchList;
        }
public string grpCreator(string userId)
        {
            foreach(myUser u in dataClass.usersList)
            {
                if (userId == u.Userid)
                {
                 return u.Username;
                }
                          
            }
            return "";
        }






    }
}