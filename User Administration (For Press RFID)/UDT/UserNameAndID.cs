﻿namespace User_Administration__For_Press_RFID_.Classes
{
    public class UserNameAndID
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public UserNameAndID(int UserID, string UserFirstName, string UserLastName)
        {
            ID = UserID;
            FirstName = UserFirstName;
            LastName = UserLastName;
        }
    }
}
