using Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order()
            {
                Street = "st_235425235",  
                PhoneNum = "087135135",
                Status = StatusEnum.Ordered
            };

            if(o1.Status < StatusEnum.Delivered ) 
            {
                Console.WriteLine("Order is still in progress");
            }
        }
    }
}
