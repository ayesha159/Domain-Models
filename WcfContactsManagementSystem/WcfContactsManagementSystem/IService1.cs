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

        bool AddGroup(string GrpName , ref string userId);
        [OperationContract]
        bool AddContact(string userId, string grpId, string name, string DOB, string moblieNo, string email, string address);
        [OperationContract]

        bool DeleteContact(string idcon);
        [OperationContract]
        bool UpdateContacts(string conid, string name, string DOB, string moblieNo, string email, string address);
      


        //[OperationContract]
        //bool AddGroup(string userId, string GrpName);


        [OperationContract]
        bool DeleteGroup(string delGrp);

        [OperationContract]
        bool UpdateGroup(string grpid, string grpname);

        [OperationContract]
        List<myGroup> GetData();

        [OperationContract]
        List<myContacts> GetCon();
        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        //// TODO: Add your service operations here
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
