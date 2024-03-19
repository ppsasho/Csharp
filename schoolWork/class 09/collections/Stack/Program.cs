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
            userStack.Pop();
            bool success = userStack.TryPop(out User removedUser);
            if(success) Console.WriteLine(removedUser.FirstName + " " + removedUser.LastName);
        }
    }
}
