namespace Queue_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> userQueue = new Queue<string>();
            userQueue.Enqueue("user1");
            userQueue.Enqueue("user2");
            userQueue.Enqueue("user3");
            userQueue.Enqueue("user4");

            string name = userQueue.Dequeue();

            bool success = userQueue.TryDequeue(out string user2);
            if (success) Console.WriteLine($"The second removed user: {user2}");

            string namePeek = userQueue.Peek();
            Console.WriteLine($"The next user in the queue: {namePeek}");
            userQueue.Dequeue();
            bool namePeek1 = userQueue.TryPeek(out string user3);
            if (namePeek1) Console.WriteLine($"Attempted to peek the next user and it's a success: {user3}");

            foreach(string user in userQueue)
            {
                Console.WriteLine(user);
            }

        }
    }
}
