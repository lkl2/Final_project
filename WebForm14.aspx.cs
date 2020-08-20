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
    public partial class WebForm14 : System.Web.UI.Page
    {
        public int counter;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "60nOjiGqrPUtG6rSRGfRTprsSkCbGLk4lVXo0iOe",
            BasePath = "https://clinic-appointment-syste-2fbc1.firebaseio.com"
        };

        IFirebaseClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox4.Text = MyAppointment.username;
            client = new FireSharp.FirebaseClient(config);
            if (!IsPostBack){
                getDropDownList();
            }
        }

        public void getDropDownList()
        {
            //DropDownList1.Items.Clear();
            var res = client.Get(@"Doctors/");
            MyAppointment ResAppointment = res.ResultAs<MyAppointment>();
            if (ResAppointment != null)
            {
                var i = Convert.ToInt32(ResAppointment.counter.ToString());
                for (int a = 1; i >= a; a++)
                {
                    DropDownList1.Items.Add(new ListItem(a.ToString()));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            view();
        }

        public void view()
        {
            var res = client.Get(@"Doctors/" + DropDownList1.SelectedValue);
            MyAppointment ResAppointment = res.ResultAs<MyAppointment>();
            if (ResAppointment != null)
            {
                TextBox1.Text = ResAppointment.Username;
                TextBox2.Text = ResAppointment.Password;
                TextBox3.Text = ResAppointment.Fullname;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "" && TextBox2.Text != ""){
                add();
                DropDownList1.Items.Clear();
                getDropDownList();
                //Response.Redirect("WebForm14.aspx");
            }
            else
            {
                Response.Write("<script>alert('Username and Password cannot be empty')</script>");
            }
        }

        public void add()
        {
            var res = client.Get(@"Doctors/");
            MyAppointment ResAppointment = res.ResultAs<MyAppointment>();
            if (ResAppointment != null)
            {
                counter = ResAppointment.counter;
                counter++;
            }
            else
            {
                counter = 1;
            }

            MyAppointment doctor = new MyAppointment()
            {
                Username = TextBox1.Text,
                Password = TextBox2.Text,
                Fullname = TextBox3.Text,
                counter = counter
            };

            SetResponse set = client.Set(@"Doctors/" + counter, doctor);
            client.Set(@"Doctors/" + "/" + "counter", counter);
            Response.Write("<script>alert('Successfully Added!')</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            delete();
            DropDownList1.Items.Clear();
            getDropDownList();
            //Response.Redirect("WebForm14.aspx");
        }

        public void delete()
        {
            var i = 0;// i == dropdownlist1 selected value int form
            var p = 0;// total counter
            var res = client.Get(@"Doctors/");
            MyAppointment ResAppointment = res.ResultAs<MyAppointment>();
            if (ResAppointment != null)
            {
                counter = ResAppointment.counter;
                p = ResAppointment.counter;
                i = Convert.ToInt32(DropDownList1.SelectedValue);
                counter--;
            }
            else
            {
                counter = 0;
            }
            if (p > i)
            {
                for (int b = i; p > b; b++)//b replace i for loop
                {
                    int n = b + 1;//counter++ 
                    var res1 = client.Get(@"Doctors/" + n);
                    MyAppointment ResAppointment1 = res1.ResultAs<MyAppointment>();
                    if (ResAppointment1 != null)
                    {
                        MyAppointment doctor = new MyAppointment()
                        {
                            Username = ResAppointment1.Username,
                            Password = ResAppointment1.Password,
                            Fullname = ResAppointment1.Fullname,
                            counter = i
                        };
                        FirebaseResponse set1 = client.Update(@"Doctors/" + i, doctor);
                    }
                    i++;
                }
            }
            FirebaseResponse set = client.Delete(@"Doctors/" + p);
            client.Set(@"Doctors/" + "/" + "counter", counter);
            Response.Write("<script>alert('Successfully Deleted!')</script>");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            update();
            clear();
        }
        
        public void update()
        {
            var res = client.Get(@"Doctors/" + DropDownList1.SelectedValue);
            MyAppointment ResAppointment = res.ResultAs<MyAppointment>();
            if (ResAppointment != null)
            {
                counter = ResAppointment.counter;
            }

            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                MyAppointment doctor = new MyAppointment()
                {
                    Username = TextBox1.Text,
                    Password = TextBox2.Text,
                    Fullname = TextBox3.Text,
                    counter = counter
                };

                FirebaseResponse set = client.Update(@"Doctors/" + counter, doctor);
                Response.Write("<script>alert('Successfully Updated!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Username and Password cannot be empty!')</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MyAppointment.username = null;
            Response.Redirect("WebForm4.aspx");
        }
    }
}