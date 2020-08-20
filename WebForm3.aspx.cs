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

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string email = MyUser.email;
        int counter;
        string slot;
        static string t9, t10, t11, t12, t2, t3, t4, t5;
        static bool t91, t101, t111, t121, t21, t31, t41, t51 = false;

        private void hideButton()
        {
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
            Button7.Visible = false;
            Button8.Visible = false;
        }

        private void showButton()
        {
            Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            Button5.Visible = true;
            Button6.Visible = true;
            Button7.Visible = true;
            Button8.Visible = true;
        }

        private void resetButton()
        {
            t91 = false;
            t101 = false;
            t111 = false;
            t121 = false;
            t21 = false;
            t31 = false;
            t41 = false;
            t51 = false;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            refreshButton();
            t121 = true;
            Button4.BackColor = Color.Gray;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            refreshButton();
            t21 = true;
            Button5.BackColor = Color.Gray;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            refreshButton();
            t31 = true;
            Button6.BackColor = Color.Gray;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            refreshButton();
            t41 = true;
            Button7.BackColor = Color.Gray;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            refreshButton();
            t51 = true;
            Button8.BackColor = Color.Gray;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            refreshButton();
            t111 = true;
            Button3.BackColor = Color.Gray;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            refreshButton();
            t101 = true;
            Button2.BackColor = Color.Gray;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            refreshButton();
            t91 = true;
            Button1.BackColor = Color.Gray;
        }

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
            provider = new FirebaseAuthProvider(con);
            txtusername.Text = MyUser.email;
            try
            {
                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {
                    //Response.Write("<script>alert('Connection is established')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            
            if (MyUser.email == null)
            {
                Response.Redirect("WebForm1.aspx");
            }

            if (!IsPostBack)
            {
                var res1 = client.Get(@"Doctors/");
                MyAppointment ResAppointment = res1.ResultAs<MyAppointment>();
                if (ResAppointment != null)
                {
                    counter = ResAppointment.counter;
                }
                for (int ii = 1; counter >= ii; ii++)
                {
                    var res = client.Get(@"Doctors/" + ii);
                    MyAppointment ResAppointment1 = res.ResultAs<MyAppointment>();
                    DropDownList1.Items.Add(new ListItem(ResAppointment1.Fullname));
                }
            }

        }
        private void book()
        {

            if (email == null)//Prevent unlogged booking
            {
                Response.Write("<script>alert('Invalid Booking!')</script>");
            }
            else
            {
                timestatus();
                if (t91 || t101 || t111 || t121 || t21 || t31 || t41 || t51 == true)
                {
                    MyAppointment appointment = new MyAppointment()
                    {
                        Doctor = DropDownList1.Text,
                        Date = txtShow.Text,
                        t9 = t9,
                        t10 = t10,
                        t11 = t11,
                        t12 = t12,
                        t2 = t2,
                        t3 = t3,
                        t4 = t4,
                        t5 = t5,
                    };
                    if (t91 == true)
                    {
                        appointment.t9 = email;
                        slot = "9am";
                    }
                    else if (t101 == true)
                    {
                        appointment.t10 = email;
                        slot = "10am";
                    }
                    else if (t111 == true)
                    {
                        appointment.t11 = email;
                        slot = "11am";
                    }
                    else if (t121 == true)
                    {
                        appointment.t12 = email;
                        slot = "12pm";
                    }
                    else if (t21 == true)
                    {
                        appointment.t2 = email;
                        slot = "2pm";
                    }
                    else if (t31 == true)
                    {
                        appointment.t3 = email;
                        slot = "3pm";
                    }
                    else if (t41 == true)
                    {
                        appointment.t4 = email;
                        slot = "4pm";
                    }
                    else if (t51 == true)
                    {
                        appointment.t5 = email;
                        slot = "5pm";
                    }
                    //get counter
                    string cleanEmail = email.Replace(".", string.Empty);

                    var res = client.Get(@"Records/" + cleanEmail);
                    MyRecord ResRecord = res.ResultAs<MyRecord>();
                    if (ResRecord != null)
                    {
                        counter = ResRecord.counter;
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    
                    //record for user
                    string date = DateTime.Now.ToString("dddd, dd MMM yyy HH:mm:ss");
                    MyRecord record = new MyRecord()
                    {
                        doctor = DropDownList1.Text,
                        date = date,
                        time = slot,
                        email = email,
                        counter = counter,
                        appointment = txtShow.Text
                    };
                    client.Set(@"Records/" + cleanEmail + "/" + counter, record);
                    client.Set(@"Records/" + cleanEmail + "/" + "counter", counter);
                    Response.Write("<script>alert('Debug save record for user!')</script>");
                    
                    var set = client.Update(@"Appointments/" + DropDownList1.Text + "/" + txtShow.Text, appointment);
                    Response.Write("<script>alert('Booking Successfully!')</script>");
                    timestatus();
                }
                else
                {
                    Response.Write("<script>alert('Pick a timeslot!')</script>");
                }
            }
        }

        public bool information()
        {
            DateTime timeSelect = Calendar1.SelectedDate;
            string astimeSelect = timeSelect.ToString("dd MMMM yyyy");
            txtShow2.Text = astimeSelect;

            var res = client.Get(@"Appointments/" + DropDownList1.Text + "/" + astimeSelect);
            MyAppointment ResAppointment = res.ResultAs<MyAppointment>();

            if (ResAppointment != null)
            {
                t9 = ResAppointment.t9;
                t10 = ResAppointment.t10;
                t11 = ResAppointment.t11;
                t12 = ResAppointment.t12;
                t2 = ResAppointment.t2;
                t3 = ResAppointment.t3;
                t4 = ResAppointment.t4;
                t5 = ResAppointment.t5;

                txtShow.Text = ResAppointment.Date;
                return true;
            }
            else
            {
                Response.Write("<script>alert('No Data!')</script>");
                return false;
            }
        }
        
        private void timestatus()
        {
            DateTime timeSelect = Calendar1.SelectedDate;
            string astimeSelect = timeSelect.ToString("dd MMMM yyyy");
            txtShow2.Text = astimeSelect;

            if (information() == true)
            {
                showButton();
                if (txtShow2.Text == astimeSelect)
                {
                    if (t9 == "Available")
                    {
                        Button1.Enabled = true;
                        Button1.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Button1.Enabled = false;
                        Button1.BackColor = System.Drawing.Color.Red;
                    }
                    if (t10 == "Available")
                    {
                        Button2.Enabled = true;
                        Button2.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Button2.Enabled = false;
                        Button2.BackColor = System.Drawing.Color.Red;
                    }
                    if (t11 == "Available")
                    {
                        Button3.Enabled = true;
                        Button3.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Button3.Enabled = false;
                        Button3.BackColor = System.Drawing.Color.Red;
                    }
                    if (t12 == "Available")
                    {
                        Button4.Enabled = true;
                        Button4.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Button4.Enabled = false;
                        Button4.BackColor = System.Drawing.Color.Red;
                    }
                    if (t2 == "Available")
                    {
                        Button5.Enabled = true;
                        Button5.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Button5.Enabled = false;
                        Button5.BackColor = System.Drawing.Color.Red;
                    }
                    if (t3 == "Available")
                    {
                        Button6.Enabled = true;
                        Button6.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Button6.Enabled = false;
                        Button6.BackColor = System.Drawing.Color.Red;
                    }
                    if (t4 == "Available")
                    {
                        Button7.Enabled = true;
                        Button7.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Button7.Enabled = false;
                        Button7.BackColor = System.Drawing.Color.Red;
                    }
                    if (t5 == "Available")
                    {
                        Button8.Enabled = true;
                        Button8.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Button8.Enabled = false;
                        Button8.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
            else
            {
                hideButton();
            }
        }
        private void refreshButton()
        {
            resetButton();

            if (t9 == "Available")
            {
                Button1.Enabled = true;
                Button1.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button1.Enabled = false;
                Button1.BackColor = System.Drawing.Color.Red;
            }
            if (t10 == "Available")
            {
                Button2.Enabled = true;
                Button2.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button2.Enabled = false;
                Button2.BackColor = System.Drawing.Color.Red;
            }
            if (t11 == "Available")
            {
                Button3.Enabled = true;
                Button3.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button3.Enabled = false;
                Button3.BackColor = System.Drawing.Color.Red;
            }
            if (t12 == "Available")
            {
                Button4.Enabled = true;
                Button4.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button4.Enabled = false;
                Button4.BackColor = System.Drawing.Color.Red;
            }
            if (t2 == "Available")
            {
                Button5.Enabled = true;
                Button5.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button5.Enabled = false;
                Button5.BackColor = System.Drawing.Color.Red;
            }
            if (t3 == "Available")
            {
                Button6.Enabled = true;
                Button6.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button6.Enabled = false;
                Button6.BackColor = System.Drawing.Color.Red;
            }
            if (t4 == "Available")
            {
                Button7.Enabled = true;
                Button7.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button7.Enabled = false;
                Button7.BackColor = System.Drawing.Color.Red;
            }
            if (t5 == "Available")
            {
                Button8.Enabled = true;
                Button8.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button8.Enabled = false;
                Button8.BackColor = System.Drawing.Color.Red;
            }
        }

        protected void btncheck_Click(object sender, EventArgs e)
        {
            timestatus();
        }

        protected void btnbook_Click(object sender, EventArgs e)
        {
            book();
            resetButton();
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            MyUser.email = null;
            //Response.Write("<script>alert('Logout Successfully!')</script>");
            Response.Redirect("WebForm1.aspx");
        }
    }
}