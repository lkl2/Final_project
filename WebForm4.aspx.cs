using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "60nOjiGqrPUtG6rSRGfRTprsSkCbGLk4lVXo0iOe",
            BasePath = "https://clinic-appointment-syste-2fbc1.firebaseio.com"
        };

        IFirebaseClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                Response.Write("<script>alert('No Internet or Connection Problem')</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                Response.Write("<script>alert('Please Fill All The Field')</script>");
                return;
            }
            #endregion
            try
            {
                FirebaseResponse res = client.Get(@"Admin/" + txtusername.Text);
                MyAppointment ResAdmin = res.ResultAs<MyAppointment>();//database result

                MyAppointment CurAdmin = new MyAppointment() //USER GIVEN INFO
                {
                    Username = txtusername.Text,
                    Password = txtpassword.Text
                };

                if (MyAppointment.IsEqual(ResAdmin, CurAdmin))
                {
                    Response.Write("<script>alert('Successfully login!')</script>");
                    Response.Redirect("WebForm5.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Username and password does not match!')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('User does not exist!')</script>");
            }
        }
    }
}