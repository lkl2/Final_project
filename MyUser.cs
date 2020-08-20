using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Firebase.Auth;
using System.Web;


namespace WebApplication2
{
    public class MyUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Ic { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public static string username;

        public static string email;
        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null)
            {
                return false;
            }
            if (user1.Username != user2.Username)
            {
                return false;
            }
            else if (user1.Password != user2.Password)
            {
                return false;
            }
            MyUser.username = user1.Username;
            return true;
        }

        public static bool IsExist(MyUser user1, MyUser user2)//database username and user given username
        {
            if (user1 == null && user2 != null)
            {
                return true;
            }

            else if (user1.Username == user2.Username)
            {
                return false;
            }
            return true;
        }

        public static void getEmail(MyUser user1)
        {
            MyUser.email = user1.Email;
        }
    }
}