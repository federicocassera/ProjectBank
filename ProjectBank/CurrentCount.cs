using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBank
{
    public class CurrentCount 
    {
        public double Money { get; set; }
        public string Iban { get; set; }
        public Account Account { get; set; }
        
        

        public CurrentCount(Account account,double money, string iban)
        {
            Account = account;
            Money = money;
            Iban = iban;            
        }

        public void Prelievo(CurrentCount count)
        {
            DateTime Now = DateTime.Now;
            Console.WriteLine("inserire saldo da prelevare");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            if (saldo < count.Money)
            {
                count.Money -= saldo;                
            }
            else
            {
                Console.WriteLine("importo da prelevare maggiore del saldo");
            }
            Console.WriteLine($"saldo attuale: {count.Money}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            Console.WriteLine($"data: {Now}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
        }

        public void Deposito(CurrentCount count)
        {
            DateTime Now = DateTime.Now;
            Console.WriteLine("inserire saldo da versare");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            count.Money += saldo;
            Console.WriteLine($"saldo attuale: {count.Money}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            Console.WriteLine($"data: {Now}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
        }

        /*public string ViewMyCount(Account account)
        {
            DateTime Now = DateTime.Now;
            //Console.WriteLine("inserire username");
            //Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            //string username = Console.ReadLine();
            //Console.WriteLine("inserire password");
            //Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            //string password = Console.ReadLine();
            CurrentCount count = (
                from c in counts
                where c.Username == username && c.Password == password
                select c).FirstOrDefault();
            try
            {
                Console.WriteLine($"Conto di: {count.Username}; codice conto: {count.Id} e iban: {count.Iban}; " +
                    $"saldo disponibile: {count.Money} {Coin.EURO}");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                Console.WriteLine($"data: {Now}");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            }
            catch
            {
                Console.WriteLine("l'utente inserito non possiede un account nella nostra banca");
            }
            return count.Iban;
        } */
        
        public void Saldo(CurrentCount count)
        {
            DateTime Now = DateTime.Now;
            Console.WriteLine($"saldo disponibile: {count.Money} {Coin.EURO}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            Console.WriteLine($"data: {Now}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
        }

    }
}
