using System.Runtime.CompilerServices;
using System.Xml.Linq;

internal class Program
{
   public interface IAccount
    {
         void PrintDetails();
    }
    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Current Account");
        }
    }
    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Saving Account");

        }
    }
    class Account
    {
        private IAccount account;
        public Account(IAccount account) // Parameterized Contructor
        {
            this.account = account;
        }
        public void PrintAccount()
        {
            account.PrintDetails();
        }
    }
    private static void Main(string[] args)
    {
        IAccount ca=new CurrentAccount();   
        Account account = new Account(ca);
        account.PrintAccount();


        IAccount sa = new SavingAccount();
        Account account2 = new Account(sa);
        account2.PrintAccount();












    }
}