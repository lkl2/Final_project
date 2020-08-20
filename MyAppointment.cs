using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class MyAppointment
    {
        public int counter { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Doctor { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
        public string Morning { get; set; }
        public string Evening { get; set; }
        public string Afternoon { get; set; }
        public string t9 { get; set; }
        public string t10 { get; set; }
        public string t11 { get; set; }
        public string t12 { get; set; }
        public string t2 { get; set; }
        public string t3 { get; set; }
        public string t4 { get; set; }
        public string t5 { get; set; }
        public string ID { get; set; }

        public static string username;
        public static bool IsEqual(MyAppointment admin1, MyAppointment admin2)
        {
            if (admin1 == null || admin2 == null)
            {
                return false;
            }
            if (admin1.Username != admin2.Username)
            {
                return false;
            }
            else if (admin1.Password != admin2.Password)
            {
                return false;
            }
            username = admin1.Username;
            return true;
        }
    }
}