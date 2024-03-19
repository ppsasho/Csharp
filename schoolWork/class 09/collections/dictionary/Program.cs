using Models;
namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, User> users = new Dictionary<int, User>();
            bool successs = users.TryAdd(1, new User("Sasho", "Popovski", 19, "example@mail"));
            users.Add(2, new User("David", "Davidsky", 20, "example2@mail"));
            users.Add(3, new User("Bob", "Bobsky", 30, "example3@mail"));
            Console.WriteLine($"{users[2].FirstName}  {users[2].LastName}");

            foreach(KeyValuePair<int, User> user in users) {
            Console.WriteLine($"{user.Key} {user.Value.FirstName}");
            }
        }
    }
}
