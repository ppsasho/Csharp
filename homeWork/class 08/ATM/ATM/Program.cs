using ATM.Classes;
namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
            #region data
        {
            List<Customer> customers = new ();
            Customer firtstCustomer = new("Sasho", "Popovski", new int[]{1244, 1234, 5123, 1234}, 6345, 1000);
            customers.Add(firtstCustomer);
            #endregion
            while (!CustomerUI(customers));
        }
        #region methods
        static string GetInput(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
        static int[] FormatCardInput(string input)
        {
            string[] cardNumParts = input.Split("-");
            if (cardNumParts.Length > 4 || cardNumParts.Length < 4) 
            {
                Console.WriteLine("Please make sure your card number consists of 4 sections divided by a dash(-)");
                return Array.Empty<int>();
            }

            int[] cardNumber = Array.Empty<int>();

            foreach (string part in cardNumParts)
            {
                if(part.Length > 4)
                {
                    Console.WriteLine("Please make sure each section only contains 4 digits!");
                    return Array.Empty<int>();
                }
                if (!int.TryParse(part, out int cardPart)) 
                {
                    Console.WriteLine("Make sure there's only digits inbetween the dashes!");
                    return Array.Empty<int>();
                }
                Array.Resize(ref cardNumber, cardNumber.Length + 1);
                cardNumber[cardNumber.Length - 1] = cardPart;
            }
            return cardNumber;
        }
        static int GetNumber(string msg) 
        {
            while (true)
            {
                if (!int.TryParse(GetInput(msg), out int number))
                {
                    Console.WriteLine("Please make sure you only enter numbers!");
                    continue;
                }
                return number;
            }
        }

        static bool Login(Customer customer) 
        {
            Console.WriteLine($"Welcome {customer.GetFullName()}!");
            while (true)
            {
                string choice = GetInput("What would you like to do:\n*\ta) Check Balance\n*\tb) Cash Withdrawal\n*\tc) Cash Deposit").ToUpper();
                bool isBalance = choice == "A";
                bool isWithdraw = choice == "B";
                bool isDeposit = choice == "C";

                if(isBalance) Console.WriteLine(customer.CheckBalance());
                if(isWithdraw) Console.WriteLine(customer.Withdrawal(GetNumber("Enter the amount you would like to withdraw:")));
                if(isDeposit) Console.WriteLine(customer.Deposit(GetNumber("Enter the amount you would like to deposit:")));

                if (isBalance || isWithdraw || isDeposit) {
                    string tryAgain = GetInput("Would you like to do another action? (Y N)").ToUpper();
                    switch (tryAgain)
                    {
                        case "Y":
                            Console.Clear();
                            continue;
                        case "N":
                        default:
                            Console.Clear();
                            Console.WriteLine("Thanks for using ATM app [:");
                            return false;

                    }
                }
                Console.Clear();
                Console.WriteLine("Please make sure to enter one of the options:\n\ta\n\tb\n\tc");
            }

        }
        static bool Register(int[] cardNumber, List<Customer> customers)
        {
            Customer customer;
            while(true)
            {
                string firstName = GetInput("Enter your name:");
                string lastName = GetInput("Enter your last name");
                if(firstName.Length < 2 || lastName.Length < 2) {
                    Console.WriteLine("Please make sure to not leave any field empty or enter names shorter than 2 characters.");
                    continue;
                }
                int pin = GetNumber("Enter your new pin:");
                int balance = GetNumber("Enter the amount you would like to deposit into your new account (min = 200)");
                if(balance < 200){
                    Console.WriteLine("The entered amount was lower than the minimal requirement!");
                    continue;
                }
                customer = new(firstName, lastName, cardNumber, pin, balance);
                customers.Add(customer);
                break;
            }
            switch (GetInput("Your new account was successfully registered, would you like to login? (Y N)").ToUpper())
                {
                    case "Y":
                        return Login(customer);
                    case "N":
                    default:
                    Console.Clear();
                    return false;
                }
        }
        #endregion

        #region UI
        static bool CustomerUI(List<Customer> customers)
        {
            Console.WriteLine("Welcome to the ATM app!");
            while (true)
            {
            int[] cardNumber = FormatCardInput(GetInput("Please enter your card number: Ex: 5123-1234-1231-1234"));
            if(cardNumber.Length < 4) return false;

            while (true)
            {
                int pin = GetNumber("Enter Pin:");

                foreach(Customer customer in customers)
                {
                    int matchingParts = 0;
                    for(int i = 0; i < cardNumber.Length; i++)
                    {
                        if (customer.CardNumber[i] == cardNumber[i]) matchingParts++;
                    }
                    bool matchingCardNum = matchingParts == 4; 
                    if(matchingCardNum) 
                        {
                            if (customer.ComparePin(pin)) return Login(customer);
                            else Console.WriteLine("The pin you entered was incorrect!");
                            return false;
                        } 
                }

                    switch (GetInput("There was no user matching that card number, would you like to register a new account using that card number? (Y N)").ToUpper())
                    {
                        case "Y":
                            return Register(cardNumber, customers);
                        case "N":
                        default:
                            return false;
                    }
            }
            }
        }
        #endregion
    }
}
