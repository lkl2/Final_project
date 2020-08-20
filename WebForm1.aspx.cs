using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Threading;
using System.ComponentModel;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Auth;
using FireSharp.Exceptions;


namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        IFirebaseConfig config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "60nOjiGqrPUtG6rSRGfRTprsSkCbGLk4lVXo0iOe",
            BasePath = "https://clinic-appointment-syste-2fbc1.firebaseio.com"
        };

        IFirebaseClient client;
        IFirebaseAuthProvider provider;

        Firebase.Auth.FirebaseConfig con = new Firebase.Auth.FirebaseConfig("AIzaSyBy3eaNORAjiFGRrs80Gy8pEIoCa4Rwjjk"); 

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            provider = new FirebaseAuthProvider(con);

            MyUser user = new MyUser
            {
                Email = null
            };
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyUser CurUser = new MyUser() //User given info
            {
                Email = textbox1.Text,
            };
            MyUser.getEmail(CurUser);
            try
            {
                _ = provider.SignInWithEmailAndPasswordAsync(textbox1.Text, textbox2.Text).Result;
                Response.Redirect("WebForm6.aspx");
            }
            catch
            {
                Response.Write("<script>alert('The email and password you entered did not match our records!')</script>");
            }

        }
    }
}