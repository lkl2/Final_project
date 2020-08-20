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
    public partial class WebForm7 : System.Web.UI.Page
    {
        string time = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, aa, bb, cc, dd, ee, ff;
        int counter;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "60nOjiGqrPUtG6rSRGfRTprsSkCbGLk4lVXo0iOe",
            BasePath = "https://clinic-appointment-syste-2fbc1.firebaseio.com"
        };

        IFirebaseClient client;

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Text = MyAppointment.username;

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
        }

        protected void RadioButton30_CheckedChanged(object sender, EventArgs e)
        {
            o = 0;
        }

        protected void RadioButton31_CheckedChanged(object sender, EventArgs e)
        {
            p = 1;
        }

        protected void RadioButton32_CheckedChanged(object sender, EventArgs e)
        {
            p = 0;
        }

        protected void RadioButton33_CheckedChanged(object sender, EventArgs e)
        {
            q = 1;
        }

        protected void RadioButton34_CheckedChanged(object sender, EventArgs e)
        {
            q = 0;
        }

        protected void RadioButton35_CheckedChanged(object sender, EventArgs e)
        {
            r = 1;
        }

        protected void RadioButton36_CheckedChanged(object sender, EventArgs e)
        {
            r = 0;
        }

        protected void RadioButton37_CheckedChanged(object sender, EventArgs e)
        {
            s = 1;
        }

        protected void RadioButton38_CheckedChanged(object sender, EventArgs e)
        {
            s = 0;
        }

        protected void RadioButton39_CheckedChanged(object sender, EventArgs e)
        {
            t = 1;
        }

        protected void RadioButton40_CheckedChanged(object sender, EventArgs e)
        {
            t = 0;
        }

        protected void RadioButton41_CheckedChanged(object sender, EventArgs e)
        {
            u = 1;
        }

        protected void RadioButton42_CheckedChanged(object sender, EventArgs e)
        {
            u = 0;
        }

        protected void RadioButton43_CheckedChanged(object sender, EventArgs e)
        {
            v = 1;
        }

        protected void RadioButton44_CheckedChanged(object sender, EventArgs e)
        {
            v = 0;
        }

        protected void RadioButton45_CheckedChanged(object sender, EventArgs e)
        {
            w = 1;
        }

        protected void RadioButton46_CheckedChanged(object sender, EventArgs e)
        {
            w = 0;
        }

        protected void RadioButton47_CheckedChanged(object sender, EventArgs e)
        {
            x = 1;
        }

        protected void RadioButton48_CheckedChanged(object sender, EventArgs e)
        {
            x = 0;
        }

        protected void RadioButton49_CheckedChanged(object sender, EventArgs e)
        {
            y = 1;
        }

        protected void RadioButton50_CheckedChanged(object sender, EventArgs e)
        {
            y = 0;
        }

        protected void RadioButton51_CheckedChanged(object sender, EventArgs e)
        {
            z = 1;
        }

        protected void RadioButton52_CheckedChanged(object sender, EventArgs e)
        {
            z = 0;
        }

        protected void RadioButton53_CheckedChanged(object sender, EventArgs e)
        {
            aa = 1;
        }

        protected void RadioButton54_CheckedChanged(object sender, EventArgs e)
        {
            aa = 0;
        }

        protected void RadioButton55_CheckedChanged(object sender, EventArgs e)
        {
            bb = 1;
        }

        protected void RadioButton56_CheckedChanged(object sender, EventArgs e)
        {
            bb = 0;
        }

        protected void RadioButton57_CheckedChanged(object sender, EventArgs e)
        {
            cc = 1;
        }

        protected void RadioButton58_CheckedChanged(object sender, EventArgs e)
        {
            cc = 0;
        }

        protected void RadioButton59_CheckedChanged(object sender, EventArgs e)
        {
            dd = 1;
        }

        protected void RadioButton60_CheckedChanged(object sender, EventArgs e)
        {
            dd = 0;
        }

        protected void RadioButton61_CheckedChanged(object sender, EventArgs e)
        {
            ee = 1;
        }

        protected void RadioButton62_CheckedChanged(object sender, EventArgs e)
        {
            ee = 0;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm7.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MyAppointment.username = null;
            Response.Redirect("WebForm13.aspx");
        }

        protected void RadioButton29_CheckedChanged(object sender, EventArgs e)
        {
            o = 1;
        }

        protected void RadioButton28_CheckedChanged(object sender, EventArgs e)
        {
            n = 0;
        }

        protected void RadioButton27_CheckedChanged(object sender, EventArgs e)
        {
            n = 1;
        }

        protected void RadioButton26_CheckedChanged(object sender, EventArgs e)
        {
            m = 0;
        }

        protected void RadioButton25_CheckedChanged(object sender, EventArgs e)
        {
            m = 1;
        }

        protected void RadioButton24_CheckedChanged(object sender, EventArgs e)
        {
            l = 0;
        }

        protected void RadioButton23_CheckedChanged(object sender, EventArgs e)
        {
            l = 1;
        }

        protected void RadioButton22_CheckedChanged(object sender, EventArgs e)
        {
            k = 0;
        }

        protected void RadioButton21_CheckedChanged(object sender, EventArgs e)
        {
            k = 1;
        }

        protected void RadioButton20_CheckedChanged(object sender, EventArgs e)
        {
            j = 0;
        }

        protected void RadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            j = 1;
        }

        protected void RadioButton18_CheckedChanged(object sender, EventArgs e)
        {
            i = 0;
        }

        protected void RadioButton17_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        protected void RadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            h = 0;
        }

        protected void RadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            h = 1;
        }

        protected void RadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            g = 0;
        }

        protected void RadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            g = 1;
        }

        protected void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            f = 0;
        }

        protected void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            f = 1;
        }

        protected void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ff = 0;
        }

        protected void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ff = 1;
        }

        protected void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            d = 0;
        }

        protected void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            d = 1;
        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            c = 0;
        }

        protected void RadioButton5_CheckedChanged1(object sender, EventArgs e)
        {
            c = 1;
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            b = 0;
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            b = 1;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.Text == "")
            {
                Response.Write("<script>alert('Reasonings cannot be empty!')</script>");
            }
            else
            {
                var res = client.Get(@"Diagnose");
                MyDiagnosis ResDiagnosis = res.ResultAs<MyDiagnosis>();
                if (ResDiagnosis != null)
                {
                    counter = ResDiagnosis.Counter;
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                

                MyDiagnosis diagnose = new MyDiagnosis() //User given info
                {
                    Counter = counter,
                    Date = time,
                    Angina = a,
                    Bruise = b,
                    CoughingUpBlood = c,
                    Coughing = d,
                    Coma = ff,
                    Dizzy = f,
                    Diarrhea = g,
                    DifficultyBreathing = h,
                    Flu = i,
                    FootPain = j,
                    GenitalPain = k,
                    HandPain = l,
                    Headache = m,
                    Itch = n,
                    Incontinence = o,
                    IrregularHeartRate = p,
                    MusclePain = q,
                    MouthUlcer = r,
                    Rash = s,
                    RigidMuscles = t,
                    RunnyNose = u,
                    ShoulderPain = v,
                    Stomachache = w,
                    SoreThroat = x,
                    Sputum = y,
                    Sneezing = z,
                    Toothache = aa,
                    Tinnitus = bb,
                    UrethralPain = cc,
                    VomitingBlood = dd,
                    Class = ee,
                    Reasonings = RadioButtonList1.Text,
                };
                try
                {
                    SetResponse set = client.Set(@"Diagnose/" + counter, diagnose);
                    SetResponse set1 = client.Set(@"Diagnose/" + "Counter", counter);//outer
                    Response.Write("<script>alert('Successfully Save!')</script>");
                }
                catch
                {
                    Response.Write("<script>alert('Error!')</script>");
                }
            }
        }
    }
}