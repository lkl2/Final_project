using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Firebase.Auth;

namespace WebApplication2
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        IFirebaseAuthProvider auth;
        Firebase.Auth.FirebaseConfig con = new Firebase.Auth.FirebaseConfig("AIzaSyBy3eaNORAjiFGRrs80Gy8pEIoCa4Rwjjk");
        protected void Page_Load(object sender, EventArgs e)
        {
            auth = new FirebaseAuthProvider(con);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                auth.SendPasswordResetEmailAsync(TextBox1.Text);
                Response.Write("<script>alert('Succeed')</script>");
                Label1.Visible = true;
            }
            else
            {
                Response.Write("<script>alert('Enter your email')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}