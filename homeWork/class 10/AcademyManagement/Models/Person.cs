namespace Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string Username { get; set; }
        protected string Password { get; set; }
        public Person(string firstName, string username, string password) 
        {
            FirstName = firstName;
            Username = username;
            Password = password;
        }
        public bool CheckPassword(string password)
        {
            return Password.Equals(password);
        }

    }
}
