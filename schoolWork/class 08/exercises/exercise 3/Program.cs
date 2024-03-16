using exercise_3.Classes;
namespace exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User() {ID = 1, UserName = "Sasho", Password = "1234", Messages = new string[] {"Hello", "How are you", "Bye"}},
                new User() {ID = 2, UserName = "Nikola", Password = "2356", Messages = new string[] {"How are you", "sdfsdfsdf"}},
                new User() {ID = 3, UserName = "Kristijan", Password = "6456", Messages = new string[] {"bob234", "adfasasf"}}
            };
            while (!UserInterface(users)) ;
        }
        static User FindUser(User[] users, string username, string password)
        {
            foreach (User user in users)
            {
                if (user.UserName.ToLower() == username.ToLower() && user.Password == password) return user;
            }
            return null;
        }
        static void Register(User[] users, string username, string password, int id)
        {
            User user = FindUser(users, username, password);
            if (user != null)
            {
                Console.WriteLine("User already exists!");
            }
            else
            {
                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = new User(id, username, password, new string[] { "Welcome message" });
                Console.WriteLine("User successfully registered");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Users registered so far:");
                foreach (User u in users) Console.WriteLine(u.UserName);
                Console.WriteLine("----------------------------");
            }
        }
        static void Login(User[] users, string username, string password)
        {
            User user = FindUser(users, username, password);
            if (user != null)
            {
                Console.WriteLine($"Welcome {user.UserName}, here are your messages:");
                foreach (string msg in user.Messages) Console.WriteLine(msg);
            }
            else
            {
                Console.WriteLine("User not found!");
            }
        }
        static bool UserInterface(User[] users)
        {
            Console.WriteLine("Choose: \n1) Login\n2) Register");
            char choice;
            if (!char.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter only 1 number");
                return false;
            }
            else
            {
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Enter your username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        string password = Console.ReadLine();
                        Login(users, username, password);
                        return true;
                    case '2':
                        Console.WriteLine("Enter your username:");
                        string newUserName = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        string newUserPassword = Console.ReadLine();
                        Register(users, newUserName, newUserPassword, users.Length + 1);
                        return true;
                    default:
                        Console.WriteLine("Please make sure you entered 1 or 2");
                        return false;
                }
            }


        }
    }
}
