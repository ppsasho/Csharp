namespace ATM.Classes
{
    public class Customer
    {
        #region properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] CardNumber { get; set; }
        protected int Pin { get; set; }
        protected int Balance { get; set; }
        #endregion
        public Customer() { }
        public Customer(string firstName, string lastName, int[] cardNumber, int pin, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }
        #region methods
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool ComparePin(int pin)
        {
            if (Pin == pin) return true;
            return false;
        }
        public string CheckBalance()
        {
            return $"Your current balance is {Balance}$.";
        }
        public string Withdrawal(int amount)
        {
            if (amount > Balance)
            {
                return "You don't have enough balance!";
            }
            else
            {
                Balance -= amount;
                return $"You withdrew {amount}$. You have {Balance}$ left on your account.";
            }
        }
        public string Deposit(int amount)
        {
            Balance += amount;
            return $"You deposited {amount}$. Your updated balance is {Balance}$.";
        }
        #endregion
    }
}
