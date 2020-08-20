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

using FireSharp;
using Firebase.Auth;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        IFirebaseConfig config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "60nOjiGqrPUtG6rSRGfRTprsSkCbGLk4lVXo0iOe",
            BasePath = "https://clinic-appointment-syste-2fbc1.firebaseio.com"
        };
        
        IFirebaseClient client;
        IFirebaseAuthProvider client1;

        Firebase.Auth.FirebaseConfig con = new Firebase.Auth.FirebaseConfig("AIzaSyBy3eaNORAjiFGRrs80Gy8pEIoCa4Rwjjk");
        protected void Page_Load(object sender, EventArgs e)
        {
            client1 = new FirebaseAuthProvider(con);
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
            if (MyUser.username != null)
            {
                Response.Redirect("WebForm3.aspx");
            }
        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            string cleanEmail = txtemail.Text.Replace(".", string.Empty);
            /*
            FirebaseResponse res = client.Get(@"Users/" + txtusername.Text);
            MyUser ResUser = res.ResultAs<MyUser>();//Database result

            MyUser CurUser = new MyUser() //User given info
            {
                Username = txtusername.Text,
            };

            if (MyUser.IsExist(ResUser, CurUser))
            {
                MyUser.ShowError();
                Response.Write("<script>alert('Username already exist!')</script>");
            }
            else
            {
                MyUser user = new MyUser() //user given info
                {
                    Username = txtusername.Text,
                    Password = txtpassword.Text,
                    Gender = gender,
                    Fullname = txtfullname.Text,
                    Ic = txtic.Text,
                    Address = txtaddress.Text
                };

                SetResponse set = client.Set(@"Users/" + txtusername.Text, user);
                Response.Write("<script>alert('Successfully Register!')</script>");
            }*/
            try
            {
                FirebaseResponse res = client.Get(@"Users/" + txtemail.Text);//check username is it already exist
                MyUser ResUser = res.ResultAs<MyUser>();//Database result

                MyUser CurUser = new MyUser() //User given info
                {
                    Username = txtemail.Text,
                };

                if (MyUser.IsExist(ResUser, CurUser))
                {/*
                    MyUser user = new MyUser() //user given info
                    {
                        Username = txtusername.Text,
                        Password = txtpassword.Text,
                        Gender = gender,
                        Fullname = txtfullname.Text,
                        Ic = txtic.Text,
                        Address = txtaddress.Text
                    };

                    SetResponse set = client.Set(@"Users/" + txtusername.Text, user);*/
                    Response.Write("<script>alert('Successfully Register!')</script>");
                }

                else
                
                {
                    //MyUser.ShowError();
                    Response.Write("<script>alert('Username already exist!')</script>");
                }
            }
            catch
            {
                MyUser user = new MyUser() //user given info
                {
                    Email = txtemail.Text,
                    Password = txtpassword.Text,
                    Gender = dropdownlistgender.Text,
                    Fullname = txtfullname.Text,
                    Ic = txtic.Text,
                    Address = txtaddress.Text
                };

                SetResponse set = client.Set(@"Users/" + cleanEmail, user);
                Response.Write("<script>alert('Successfully Register!')</script>");
            }
            client1.CreateUserWithEmailAndPasswordAsync(txtemail.Text,txtpassword.Text);
        }

    }
}