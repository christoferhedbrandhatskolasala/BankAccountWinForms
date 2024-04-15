namespace BankAccountWinForms
{
    internal class BankAccount
    {
        int balance = 0;

        public void Deposit(int amount)
        {
            balance += amount;
        }
        
        public void Withdraw(int amount)
        {
            // Ta ut pengar, men bara om det finns tillräckligt
            if (amount <= balance)
            {
                balance -= amount;
            }
        }
        
        public int GetBalance()
        {
            return balance;
        }
    }
}
