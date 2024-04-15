using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BankAccountWinForms
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestMain();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static void TestMain()
        {

            // redirect console output to parent process;
            // must be before any calls to Console.WriteLine()
            AttachConsole(ATTACH_PARENT_PROCESS);

            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();
            bankAccount1.Deposit(100);
            bankAccount2.Deposit(50);
            Debug.WriteLine("Account1: " + bankAccount1.GetBalance());
            Debug.WriteLine("Account2: " + bankAccount2.GetBalance());
            bankAccount1.Withdraw(20);
            bankAccount2.Deposit(70);
            Debug.WriteLine("Account1: " + bankAccount1.GetBalance());
            Debug.WriteLine("Account2: " + bankAccount2.GetBalance());
            bankAccount1.Withdraw(9999);
            Debug.WriteLine("Account1: " + bankAccount1.GetBalance());


        }
    }
}