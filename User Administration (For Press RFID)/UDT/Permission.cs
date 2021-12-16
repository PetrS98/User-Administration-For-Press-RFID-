namespace User_Administration__For_Press_RFID_.Classes
{
    public class Permission
    {
        public string Name { get; private set; }
        public byte BitPosition { get; private set; }

        public Permission(string name, byte bitPosition)
        {
            Name = name;
            BitPosition = bitPosition;
        }
    }
}
