using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBank
{
    public class UserInterface
    {
        //public UserInterface(string name, string state, Coin coin, double capital) : base(name, state, coin, capital)
        //{
        //}

        //public List<Account> accounts;
        //public List<CurrentCount> counts;

        public void Accesso(List<CurrentCount> counts, List<Account> accounts)
        {
            Console.WriteLine("inserisci 1 per accedere, 2 per uscire");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Accedi(counts, accounts);
                    break;
                case 2:
                    return;
                default:
                    Console.WriteLine("numero sbagliato");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                    return;
            }
        }

        public void Menu(List<CurrentCount> counts, string username)
        {
            CurrentCount contoSelezionato = (
                from c in counts
                where c.Account.Username == username
                select c).FirstOrDefault();
            Console.WriteLine("Scegli 1 per prelevare, 2 per depositare, 3 per visualizzare il saldo, 4 esci");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    contoSelezionato.Prelievo(contoSelezionato);
                    Menu(counts, username);
                    break;
                case 2:
                    contoSelezionato.Deposito(contoSelezionato);
                    Menu(counts, username);
                    break;
                case 3:
                    contoSelezionato.Saldo(contoSelezionato);
                    Menu(counts, username);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("scelta non valida");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                    return;
            }
        }

        public void Accedi(List<CurrentCount> counts, List<Account> accounts)
        {
            Console.WriteLine("inserisci username: ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            string username = Console.ReadLine();
            Console.WriteLine("inserisci password: ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
            string password = Console.ReadLine();
            
            Account account = ControlAccount(username, password, accounts);
            if (account != null)
            { 
               Menu(counts, username);
            }
            else
            {
                Console.WriteLine("utente non trovato o password sbagliata");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                Accesso(counts, accounts);
            }
        }

        public Account ControlAccount(string username, string password, List<Account> accounts)
        {
            Account account =
                    (from c in accounts
                     where c.Username == username && c.Password == password
                     select c).FirstOrDefault();
            return account;
        }
    }
}
