using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBank
{
    public class Bank
    {


        public string Name { get; set; }
        public string State { get; set; }
        public Coin CoinType { get; set; }
        public double Capital { get; set; }

        public List<Account> accounts = new List<Account>();
        public List<CurrentCount> counts = new List<CurrentCount>();

        public Bank(string name, string state, Coin coin, double capital)
        {
            Name = name;
            State = state;
            CoinType = coin;
            Capital = capital;
        }

        //public List<Account> CaricaAccount()
        //{
        //    accounts.Add(new Account("Fedecasse", "Fede152004", 0001, new(2004, 10, 15)));
        //    return accounts;
        //}

        //public List<CurrentCount> CaricaConti()
        //{
        //    //CurrentCount count = null;
        //    counts.Add(new CurrentCount(1000, "IT000045987496D877"));
        //    return counts;
        //}
        //public void ViewCounts()
        //{
        //    DateTime Now = DateTime.Now;
        //    foreach (var c in counts)
        //    {
        //        Console.WriteLine($"Conto di: {c.Username}; codice conto: {c.Id} e iban: {c.Iban}; " +
        //            $"saldo disponibile: {c.Money} {Coin.EURO}");
        //        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
        //        Console.WriteLine($"data: {Now}");
        //        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
        //    }
        //}

        
    }  
}
