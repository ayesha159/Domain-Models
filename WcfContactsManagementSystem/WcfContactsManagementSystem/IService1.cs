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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool IsValidUser(string userName, string password,ref string curUsr);
        [OperationContract]
        void  IsUserRegister (string userName, string password ,string Email, string MobileNo);

        [OperationContract]
        string RecoverPwdE(string email);

        [OperationContract]
        string RecoverPwdS(string MobNo);

        [OperationContract]
        bool ChangePwd(string Id, string txtOld, string txtNew, string txtNewRe);

        [OperationContract]

        bool AddGroup(string GrpName , ref string userId ,string userName);
        [OperationContract]
        bool AddContact(string userId, string grpId, string name,string DOB,string moblieNo, string email,string address);
        [OperationContract]

        bool DeleteContact(string idcon);
        [OperationContract]
        bool UpdateContacts(string conid, string name, string DOB, string moblieNo, string email, string address);
           [OperationContract]
        bool DeleteGroup(string delGrp);

        [OperationContract]
        bool UpdateGroup(string grpid, string grpname, string username);

        [OperationContract]
        List<myGroup> GetData(string _uid);

        [OperationContract]
        List<myUser> GetUser();


        [OperationContract]
        List<myContacts> GetCon();

        [OperationContract]
        string ImportContacts(string name, string DOB, string moblieNo, string email, string address, string userId, string grpId);
        [OperationContract]
        string grpCreator(string userId);
        [OperationContract]
        List<myContacts> SSTG(string userid, string grpid);

        [OperationContract]
        List<myContacts> SearchCbyName(string userId, string grpId, string name);


        [OperationContract]
        List<myContacts> SearchCbyDob(string userId, string grpId, string dob);


        [OperationContract]
        List<myContacts> SearchCbyEmail(string userId, string grpId, string email);
        [OperationContract]
        List<myContacts> ShowContactsSMS(string userId, string grpId);
        [OperationContract]
        List<myContacts> SearchCbyMob(string userId, string grpId, string mob);

        [OperationContract]
        List<myContacts> SSTC(string userid, string grpid);
        [OperationContract]
        List<myContacts> ShowAllContacts(string userId, string grpId);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
