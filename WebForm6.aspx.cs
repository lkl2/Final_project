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
    public partial class WebForm6 : System.Web.UI.Page
    {
        string email = MyUser.email;
        //string cleanEmail = email.Replace(".", string.Empty);

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "60nOjiGqrPUtG6rSRGfRTprsSkCbGLk4lVXo0iOe",
            BasePath = "https://clinic-appointment-syste-2fbc1.firebaseio.com"
        };

        IFirebaseClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtusername.Text = MyUser.email;
            client = new FireSharp.FirebaseClient(config);

            if (txtusername.Text == "")
            {
                Response.Redirect("WebForm1.aspx");
            }
          
            if (! IsPostBack)
            {
                string cleanEmail = email.Replace(".", string.Empty);
                var res = client.Get(@"Records/" + cleanEmail);
                MyRecord ResRecord = res.ResultAs<MyRecord>();
                if (ResRecord != null)
                {
                    var i = Convert.ToInt32(ResRecord.counter.ToString());
                    for (int a = 1; i >= a; a++)
                    {
                        DropDownList1.Items.Add(new ListItem(a.ToString()));
                    }
                }
            }
            view();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            view();
        }

        public void view()
        {
            string cleanEmail = email.Replace(".", string.Empty);
            var res = client.Get(@"Records/" + cleanEmail + "/" + DropDownList1.SelectedValue);
            MyRecord ResRecord = res.ResultAs<MyRecord>();
            if (ResRecord != null)
            {
                Label1.Text = ResRecord.date;
                Label2.Text = ResRecord.doctor;
                Label3.Text = ResRecord.time;
                Label4.Text = ResRecord.appointment;
            }
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            txtusername = null;
            Response.Redirect("WebForm1.aspx");
        }
    }
}