using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBank
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public DateTime BornDate { get; set; }

        
        public Account(string username, string password, int id, DateTime bornDate)
        {
            Username = username;    
            Password = password;
            Id = id;
            BornDate = bornDate;                     
        }

        public void caricaAccount()
        {

        }
    }
}
