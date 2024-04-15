namespace BankAccountWinForms
{
    public partial class Form1 : Form
    {
        BankAccount bankAccount = new BankAccount();

        public Form1()
        {
            InitializeComponent();
            updateBalanceLabel();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            int amount = parseAmount();
            bankAccount.Deposit(amount);
            updateBalanceLabel();
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            int amount = parseAmount();
            bankAccount.Withdraw(amount);
            updateBalanceLabel();
        }

        private int parseAmount()
        {
            return int.Parse(textBox1.Text);
        }

        private void updateBalanceLabel()
        {
            label1.Text = bankAccount.GetBalance().ToString();
        }
    }
}