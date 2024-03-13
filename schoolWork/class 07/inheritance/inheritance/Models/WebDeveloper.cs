using System.Text.RegularExpressions;

namespace inheritance.Models
{
    public class WebDeveloper : Student
    {
        public string FavouriteLanguage {  get; set; }

        public WebDeveloper(string group, string firstName, string lastName, string email, string phoneNumber, string favouriteLanguage)
            : base(firstName, lastName, email, group, phoneNumber)
        {
            FavouriteLanguage = favouriteLanguage;
        }
    }
}
