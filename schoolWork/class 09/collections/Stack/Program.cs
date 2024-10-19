using Models;
namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<User> userStack = new Stack<User>();
            userStack.Push(new User("Bob", "Bobsky", 123, "example@mail"));
            userStack.Push(new User("David", "Davidsky", 231, "example2@mail"));
            while (true)
            {
                Console.WriteLine("Would you like to add a User to the stack? [ Y / N ]");
                var answer = Console.ReadLine().ToLower();
                switch(answer)
                {
                    case "y":
                        Console.WriteLine("Enter your full name seperated by an empty space");
                        var newUserName = Console.ReadLine();
                        if(!newUserName.Contains(' '))
                        {
                            Console.Clear();
                            Console.WriteLine("You didn't listen boy!");
                            continue;
                        }
                        var splitName = newUserName.Split(' ').ToList();
                        Console.WriteLine("Now enter your age\nAnd it better be a literal number!");
                        var number = Console.ReadLine();
                        if(!int.TryParse(number, out int parsedNumber))
                        {
                            Console.Clear();
                            Console.WriteLine("You didn't listen BOOOY!");
                            continue;
                        }
                        var newUserMail = $"{splitName.First()}@mail.com";
                        var newUser = new User(splitName.First(), splitName.Last(), parsedNumber, newUserMail);
                        userStack.Push(newUser);
                        Console.WriteLine("Would you like to try adding another User to the stack? [ Y / N ]");
                        var tryAgainMaybe = Console.ReadLine().ToLower() == "y";
                        if (tryAgainMaybe) continue;
                        break;

                    case "n":
                        Console.Clear();
                        Console.WriteLine("Youd don't like my stack anymore???\noKay I never liked you too anyway! ;[");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("You didn't answer good boooyy!");
                        continue;

                }
                break;
            }
            for(int i = 0; i <= userStack.Count; i++)
            {
                //userStack.TryPop(out var unstackedUser);
                var unstacked = userStack.Pop();
                Console.WriteLine($"Name: {unstacked.Fullname}\t{unstacked.Age}\t{unstacked.Email}");
            }
            //userStack.Pop();
            //bool success = userStack.TryPop(out User removedUser);
            //if(success) Console.WriteLine(removedUser.FirstName + " " + removedUser.LastName);
        }
    }
}
