using System.Collections.Generic;

namespace User_Administration__For_Press_RFID_.Classes
{
    public class UserInformations
    {
        public UserNameAndID NameAndID { get; private set; }
        public string RFIDID { get; private set; }
        public string PermissionGroup { get; private set; }

        public UserInformations(UserNameAndID UserNameAndID, string UserRFIDID, string UserPermissionGroup)
        {
            NameAndID = UserNameAndID;
            RFIDID = UserRFIDID;
            PermissionGroup = UserPermissionGroup;
        }
    }
}
