using System;
using System.Collections.Generic;

namespace ProjectBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("BCC", "Italia", Coin.EURO, 1000000);
            UserInterface ui = new UserInterface();

            List<CurrentCount> cc = new List<CurrentCount>();
            List<Account> accounts = new List<Account>();

            Account account1 = new Account("Fedecasse", "Fede152004", 0001, new(2004, 10, 15));
            CurrentCount c1 = new CurrentCount(account1, 1000, "IT000045987496D877");

            Account account2 = new Account("pippo", "pippo1", 0002, new(2001, 2, 4));
            CurrentCount c2 = new CurrentCount(account2, 1000, "IT0000457867496D877");

            Account account3 = new Account("pluto", "pluto1", 0003, new(1998, 7, 24));
            CurrentCount c3 = new CurrentCount(account3, 1000, "IT0005745987496D877");

            cc.Add(c1);
            cc.Add(c2);
            cc.Add(c3);

            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);

            //accounts = ui.CaricaAccount();
            //cc = ui.CaricaConti();
            //ui.ViewCounts();            
            ui.Accesso(cc, accounts);

        }
    }
}
