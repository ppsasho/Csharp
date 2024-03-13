namespace inheritance.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress {  get; set; }
        public string PhoneNumber { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            PhoneNumber = phoneNumber;
        }
        //  virtual allows the child classes to have a method with the same name but with another code implementation
        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName} - {EmailAddress} ({PhoneNumber})";
        }
    }
}
