namespace inheritance.Models
{
    public class Student : Person
    {
        public string Group { get; set; }

        public Student(string group, string firstName, string lastName, string email, string phoneNumber) 
            : base(firstName,lastName,email,phoneNumber)
        {
            Group = group;
        }

        //  If there is an empty constructor in the base class
/*        public Student(string group, string firstName, string lastName, string email, string phoneNumber)
        {
            Group = group;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            PhoneNumber = phoneNumber;
        }*/
    }
}
