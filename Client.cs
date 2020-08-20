using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Client
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public static List<Client> GenarateDummyClientList()
        {
            List<Client> clients = new List<Client>
            {
                new Client{Firstname="NG", Lastname="CC", DOB=DateTime.Parse("25/07/1997"), Email="cc@cc.com"},
                new Client{Firstname="TANG", Lastname="VIIKS", DOB=DateTime.Parse("18/03/1997"), Email="tang@tang.com"},
                new Client{Firstname="CHENG", Lastname="LALA", DOB=DateTime.Parse("16/05/1997"), Email="evelyn@lala.com"}
            };
            return clients;
        }
    }
}