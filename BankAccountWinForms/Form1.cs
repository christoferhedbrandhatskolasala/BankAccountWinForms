namespace BankAccountWinForms
{
    public partial class Form1 : Form
    {
        BankAccount bankAccount = new BankAccount();

        public Form1()
        {
            InitializeComponent();
            label1.Text = bankAccount.GetBalance().ToString();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textBox1.Text);
            bankAccount.Deposit(amount);
            label1.Text = bankAccount.GetBalance().ToString();
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textBox1.Text);
            bankAccount.Withdraw(amount);
            label1.Text = bankAccount.GetBalance().ToString();
        }
    }
}