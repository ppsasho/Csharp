namespace exercise_3.Classes
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User() { }
        public User(int iD, string userName, string password, string[] messages)
        {
            ID = iD;
            UserName = userName;
            Password = password;
            Messages = messages;
        }
    }
}
