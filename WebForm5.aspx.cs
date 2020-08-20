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

namespace WebApplication2
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public int counter;
        public string calendar;
        public static string morning = "Occupied";
        public static string evening = "Occupied";
        public static string afternoon = "Occupied";
        public static string t9 = "Occupied";
        public static string t10 = "Occupied";
        public static string t11 = "Occupied";
        public static string t12 = "Occupied";
        public static string t2 = "Occupied";
        public static string t3 = "Occupied";
        public static string t4 = "Occupied";
        public static string t5 = "Occupied";

        public static bool t91, t101, t111, t121, t21, t31, t41, t51 = false;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "60nOjiGqrPUtG6rSRGfRTprsSkCbGLk4lVXo0iOe",
            BasePath = "https://clinic-appointment-syste-2fbc1.firebaseio.com"
        };

        IFirebaseClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtadminname.Text = MyAppointment.username;
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
            if (MyAppointment.username == null)
            {
                Response.Redirect("WebForm4.aspx");
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

        private void resetAll()
        {
            t91 = false; t101 = false; t111 = false; t121 = false; t21 = false; t31 = false; t41 = false; t51 = false;

            Button4.BackColor = System.Drawing.Color.Red;
            Button5.BackColor = System.Drawing.Color.Red;
            Button6.BackColor = System.Drawing.Color.Red;
            Button7.BackColor = System.Drawing.Color.Red;
            Button8.BackColor = System.Drawing.Color.Red;
            Button9.BackColor = System.Drawing.Color.Red;
            Button10.BackColor = System.Drawing.Color.Red;
            Button11.BackColor = System.Drawing.Color.Red;
        }
        private bool information()//get information from database
        {
            DateTime timeSelect = Calendar1.SelectedDate;
            string astimeSelect = timeSelect.ToString("dd MMMM yyyy");

            var res = client.Get(@"Appointments/" + DropDownList1.SelectedValue + "/" + astimeSelect);
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
                return true;
            }
            //Response.Write("<script>alert('No Record!')</script>");
            return false;
        }

        private void refreshButton()
        {
            resetAll();

            if (t9 == "Available")
            {
                Button4.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button4.BackColor = System.Drawing.Color.Red;
            }

            if (t10 == "Available")
            {
                Button5.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button5.BackColor = System.Drawing.Color.Red;
            }

            if (t11 == "Available")
            {
                Button6.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button6.BackColor = System.Drawing.Color.Red;
            }

            if (t12 == "Available")
            {
                Button7.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button7.BackColor = System.Drawing.Color.Red;
            }

            if (t2 == "Available")
            {
                Button8.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button8.BackColor = System.Drawing.Color.Red;
            }

            if (t3 == "Available")
            {
                Button9.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button9.BackColor = System.Drawing.Color.Red;
            }

            if (t4 == "Available")
            {
                Button10.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button10.BackColor = System.Drawing.Color.Red;
            }

            if (t5 == "Available")
            {
                Button11.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                Button11.BackColor = System.Drawing.Color.Red;
            }

            Button4.Visible = true;
            Button5.Visible = true;
            Button6.Visible = true;
            Button7.Visible = true;
            Button8.Visible = true;
            Button9.Visible = true;
            Button10.Visible = true;
            Button11.Visible = true;

            checkboxmorning.Visible = false;
            checkboxafternoon.Visible = false;
            TextBox1.Text = DropDownList1.SelectedValue;

        }
        private void retrieveData()
        {
            resetAll();
            if (information() == true)
            {
                if (t9 == "Available")
                {
                    Button4.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Button4.BackColor = System.Drawing.Color.Red;
                }

                if (t10 == "Available")
                {
                    Button5.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Button5.BackColor = System.Drawing.Color.Red;
                }

                if (t11 == "Available")
                {
                    Button6.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Button6.BackColor = System.Drawing.Color.Red;
                }

                if (t12 == "Available")
                {
                    Button7.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Button7.BackColor = System.Drawing.Color.Red;
                }

                if (t2 == "Available")
                {
                    Button8.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Button8.BackColor = System.Drawing.Color.Red;
                }

                if (t3 == "Available")
                {
                    Button9.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Button9.BackColor = System.Drawing.Color.Red;
                }

                if (t4 == "Available")
                {
                    Button10.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Button10.BackColor = System.Drawing.Color.Red;
                }

                if (t5 == "Available")
                {
                    Button11.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Button11.BackColor = System.Drawing.Color.Red;
                }

                Button4.Visible = true;
                Button5.Visible = true;
                Button6.Visible = true;
                Button7.Visible = true;
                Button8.Visible = true;
                Button9.Visible = true;
                Button10.Visible = true;
                Button11.Visible = true;

                checkboxmorning.Visible = false;
                checkboxafternoon.Visible = false;
                TextBox1.Text = DropDownList1.SelectedValue;
            }
            else
            {
                resetAll();
                hideButton();
                Response.Write("<script>alert('No Record!')</script>");
            }
        }

        private void hideButton()
        {
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
            Button7.Visible = false;
            Button8.Visible = false;
            Button9.Visible = false;
            Button10.Visible = false;
            Button11.Visible = false;
        }
        private bool CheckExist()
        {
            DateTime timeSelect = Calendar1.SelectedDate;
            string astimeSelect = timeSelect.ToString("dd MMMM yyyy");

            var res = client.Get(@"Appointments/" + DropDownList1.Text + "/" + astimeSelect);
            MyAppointment ResAppointment = res.ResultAs<MyAppointment>();

            if (ResAppointment != null)
            {
                return true;
            }
            return false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckExist() == false)
            {
                DateTime dateSelect = Calendar1.SelectedDate;
                string asdateSelect = dateSelect.ToString("dd MMMM yyyy");

                MyAppointment appointment = new MyAppointment()
                {
                    Doctor = DropDownList1.Text,
                    Date = asdateSelect,
                    t9 = t9,
                    t10 = t10,
                    t11 = t11,
                    t12 = t12,
                    t2 = t2,
                    t3 = t3,
                    t4 = t4,
                    t5 = t5
                };
                FirebaseResponse set = client.Set(@"Appointments/" + DropDownList1.Text + "/" + asdateSelect, appointment);
                Response.Write("<script>alert('Successfully create!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Data already exist!')</script>");
            }
        }

        protected void checkboxmorning_CheckedChanged(object sender, EventArgs e)
        {
            morning = "Available";

            t9 = "Available";
            t10 = "Available";
            t11 = "Available";
            t12 = "Available";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            refreshButton();
            t111 = true;
            Button6.BackColor = System.Drawing.Color.Gray;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            refreshButton();
            t121 = true;
            Button7.BackColor = System.Drawing.Color.Gray;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            refreshButton();
            t21 = true;
            Button8.BackColor = System.Drawing.Color.Gray;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            refreshButton();
            t31 = true;
            Button9.BackColor = System.Drawing.Color.Gray;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            refreshButton();
            t41 = true;
            Button10.BackColor = System.Drawing.Color.Gray;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            refreshButton();
            t51 = true;
            Button11.BackColor = System.Drawing.Color.Gray;
        }

        protected void checkboxevening_CheckedChanged(object sender, EventArgs e)
        {
            evening = "Available";
        }

        protected void checkboxafternoon_CheckedChanged(object sender, EventArgs e)
        {
            afternoon = "Available";

            t2 = "Available";
            t3 = "Available";
            t4 = "Available";
            t5 = "Available";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MyAppointment.username = null;
            Response.Redirect("WebForm4.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            retrieveData();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            refreshButton();
            t101 = true;
            Button5.BackColor = System.Drawing.Color.Gray;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            refreshButton();
            t91 = true;
            Button4.BackColor = System.Drawing.Color.Gray;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DateTime timeSelect = Calendar1.SelectedDate;
            string astimeSelect = timeSelect.ToString("dd MMMM yyyy");
            information();

            if (t91 || t101 || t111 || t121 || t21 || t31 || t41 || t51 == true)
            {
                MyAppointment appointment = new MyAppointment()
                {
                    Doctor = DropDownList1.Text,
                    Date = astimeSelect,
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
                    if (t9 == "Available")
                    {
                        appointment.t9 = TextBox2.Text;
                    }
                    else
                    {
                        appointment.t9 = "Available";
                    }
                }
                else if (t101 == true)
                {
                    if (t10 == "Available")
                    {
                        appointment.t10 = TextBox2.Text;
                    }
                    else
                    {
                        appointment.t10 = "Available";
                    }
                }
                else if (t111 == true)
                {
                    if (t11 == "Available")
                    {
                        appointment.t11 = TextBox2.Text;
                    }
                    else
                    {
                        appointment.t11 = "Available";
                    }
                }
                else if (t121 == true)
                {
                    if (t12 == "Available")
                    {
                        appointment.t12 = TextBox2.Text;
                    }
                    else
                    {
                        appointment.t12 = "Available";
                    }
                }
                else if (t21 == true)
                {
                    if (t2 == "Available")
                    {
                        appointment.t2 = TextBox2.Text;
                    }
                    else
                    {
                        appointment.t2 = "Available";
                    }
                }
                else if (t31 == true)
                {
                    if (t3 == "Available")
                    {
                        appointment.t3 = TextBox2.Text;
                    }
                    else
                    {
                        appointment.t3 = "Available";
                    }
                }
                else if (t41 == true)
                {
                    if (t4 == "Available")
                    {
                        appointment.t4 = TextBox2.Text;
                    }
                    else
                    {
                        appointment.t4 = "Available";
                    }
                }
                else if (t51 == true)
                {
                    if (t5 == "Available")
                    {
                        appointment.t5 = TextBox2.Text;
                    }
                    else
                    {
                        appointment.t5 = "Available";
                    }
                }
                var set = client.Update(@"Appointments/" + DropDownList1.Text + "/" + astimeSelect, appointment);
                Response.Write("<script>alert('Successfully update!')</script>");
                retrieveData();

                TextBox2.Text = null;
            }
            else
            {
                Response.Write("<script>alert('Please select one timeslot!')</script>");
            }
        }
    }
}