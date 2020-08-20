using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WebApplication2
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        int counter;
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
            if (string.IsNullOrWhiteSpace(TextBox1.Text) ||
                string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                Response.Write("<script>alert('Please Fill All The Field')</script>");
                return;
            }
            #endregion
            try
            {
                var res1 = client.Get(@"Doctors/");
                MyAppointment ResAppointment = res1.ResultAs<MyAppointment>();
                if (ResAppointment != null)
                {
                    counter = ResAppointment.counter;
                }
                for (int i = 1; counter > i; i++)
                {
                    FirebaseResponse res = client.Get(@"Doctors/" + i);
                    MyAppointment ResUser = res.ResultAs<MyAppointment>();//database result
                    MyAppointment CurUser = new MyAppointment() //USER GIVEN INFO
                    {
                        Username = TextBox1.Text,
                        Password = TextBox2.Text
                    };

                    if (MyAppointment.IsEqual(ResUser, CurUser))
                    {
                        Response.Write("<script>alert('Successfully login!')</script>");
                        Response.Redirect("WebForm7.aspx");
                    }

                }
                Response.Write("<script>alert('Username and Password does not match!')</script>");
            }
            catch
            {
                Response.Write("<script>alert('User does not exist!')</script>");
            }
        }
    }
}