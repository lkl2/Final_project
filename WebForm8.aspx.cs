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
using System.IO;

namespace WebApplication2
{
    public partial class WebForm8 : System.Web.UI.Page
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "60nOjiGqrPUtG6rSRGfRTprsSkCbGLk4lVXo0iOe",
            BasePath = "https://clinic-appointment-syste-2fbc1.firebaseio.com"
        };

        IFirebaseClient client;

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox38.Text = MyAppointment.username;
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
            if (!IsPostBack)
            {
                var res = client.Get(@"Diagnose/");
                MyDiagnosis ResDiagnosis = res.ResultAs<MyDiagnosis>();
                if (ResDiagnosis != null)
                {
                    var i = Convert.ToInt32(ResDiagnosis.Counter.ToString());
                    for (int a = 1; i >= a; a++)
                    {
                        DropDownList1.Items.Add(new ListItem(a.ToString()));
                    }
                    TextBox37.Text = ResDiagnosis.Counter.ToString();
                }
            }
        }
        public void Export()
        {
            string FromDate = TextBox33.Text + " " + DropDownList2.SelectedValue + " " + TextBox34.Text;
            string ToDate = TextBox35.Text + " " + DropDownList3.SelectedValue + " " + TextBox36.Text;
            string printDate = "%Date " + FromDate + " to " + ToDate;

            StringWriter sw = new StringWriter();
            try
            {
                DateTime Date1 = Convert.ToDateTime(FromDate);
            }
            catch
            {
                FromDate = null;
                ToDate = null;
                printDate = "%All Data";
            }
            
            sw.WriteLine(printDate+"\n@relation Diagnosis\n@attribute 'Angina' real\n@attribute 'Bruise' real\n@attribute 'Coughing up blood' real\n@attribute 'Coughing' real" +
                "\n@attribute 'Coma' real\n@attribute 'Dizzy' real\n@attribute 'Diarrhea' real\n@attribute 'Difficulty breathing' real\n@attribute 'Flu' real" +
                "\n@attribute 'Foot pain' real\n@attribute 'Genital pain' real\n@attribute 'Hand pain' real\n@attribute 'Headache' real\n@attribute 'Itch' real" +
                "\n@attribute 'Incontinence' real\n@attribute 'Irregular heart rate' real\n@attribute 'Muscle pain' real\n@attribute 'Mouth pain' real\n@attribute 'Rash' real" +
                "\n@attribute 'Rigid muscle' real\n@attribute 'Runny nose' real\n@attribute 'Shoulder pain' real\n@attribute 'Stomachache' real\n@attribute 'Sore throat' real" +
                "\n@attribute 'Sputum' real\n@attribute 'Sneezing' real\n@attribute 'Toothache' real\n@attribute 'Tinnitus' real\n@attribute 'Urethral pain' real" +
                "\n@attribute 'Vomiting blood' real\n@attribute 'Class' real\n@attribute 'Reasonings' {'Diabetes','Fever','Covid-19','HighBloodPressure','Sensitive'," +
                "'PeriodontalDisease','Cancer','HeartDisease','Others','Healthy'}\n@data");

            Response.ClearContent();
            //Response.AddHeader("content-disposition", "attachment;filename=ExportClientList.csv");
            Response.AddHeader("content-disposition", "attachment;filename=ExportDiagnoseList.arff");
            Response.ContentType = "text/arff";

            var clients = MyDiagnosis.GenerateDiagnoseList(FromDate,ToDate);

            for (int i = 0; i < clients.Count; i++)
            {
                MyDiagnosis dia2 = clients[i];
                sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}," +
                    "{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31}",

                    dia2.Angina,
                    dia2.Bruise,
                    dia2.CoughingUpBlood,
                    dia2.Coughing,
                    dia2.Coma,
                    dia2.Dizzy,
                    dia2.Diarrhea,
                    dia2.DifficultyBreathing,
                    dia2.Flu,
                    dia2.FootPain,
                    dia2.GenitalPain,
                    dia2.HandPain,
                    dia2.Headache,
                    dia2.Itch,
                    dia2.Incontinence,
                    dia2.IrregularHeartRate,
                    dia2.MusclePain,
                    dia2.MouthUlcer,
                    dia2.Rash,
                    dia2.RigidMuscles,
                    dia2.RunnyNose,
                    dia2.ShoulderPain,
                    dia2.Stomachache,
                    dia2.SoreThroat,
                    dia2.Sputum,
                    dia2.Sneezing,
                    dia2.Toothache,
                    dia2.Tinnitus,
                    dia2.UrethralPain,
                    dia2.VomitingBlood,
                    dia2.Class,
                    dia2.Reasonings));
            }
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var res = client.Get(@"Diagnose/" + DropDownList1.SelectedValue );
            MyDiagnosis ResDiagnosis = res.ResultAs<MyDiagnosis>();
            TextBox1.Text = ResDiagnosis.Angina.ToString();
            TextBox2.Text = ResDiagnosis.Bruise.ToString();
            TextBox3.Text = ResDiagnosis.CoughingUpBlood.ToString();
            TextBox4.Text = ResDiagnosis.Coughing.ToString();
            TextBox5.Text = ResDiagnosis.Coma.ToString();
            TextBox6.Text = ResDiagnosis.Dizzy.ToString();
            TextBox7.Text = ResDiagnosis.Diarrhea.ToString();
            TextBox8.Text = ResDiagnosis.DifficultyBreathing.ToString();
            TextBox9.Text = ResDiagnosis.Flu.ToString();
            TextBox10.Text = ResDiagnosis.FootPain.ToString();
            TextBox11.Text = ResDiagnosis.GenitalPain.ToString();
            TextBox12.Text = ResDiagnosis.HandPain.ToString();
            TextBox13.Text = ResDiagnosis.Headache.ToString();
            TextBox14.Text = ResDiagnosis.Itch.ToString();
            TextBox15.Text = ResDiagnosis.Incontinence.ToString();
            TextBox16.Text = ResDiagnosis.IrregularHeartRate.ToString();
            TextBox17.Text = ResDiagnosis.MusclePain.ToString();
            TextBox18.Text = ResDiagnosis.MouthUlcer.ToString();
            TextBox19.Text = ResDiagnosis.Rash.ToString();
            TextBox20.Text = ResDiagnosis.RigidMuscles.ToString();
            TextBox21.Text = ResDiagnosis.RunnyNose.ToString();
            TextBox22.Text = ResDiagnosis.ShoulderPain.ToString();
            TextBox23.Text = ResDiagnosis.Stomachache.ToString();
            TextBox24.Text = ResDiagnosis.SoreThroat.ToString();
            TextBox25.Text = ResDiagnosis.Sputum.ToString();
            TextBox26.Text = ResDiagnosis.Sneezing.ToString();
            TextBox27.Text = ResDiagnosis.Toothache.ToString();
            TextBox28.Text = ResDiagnosis.Tinnitus.ToString();
            TextBox29.Text = ResDiagnosis.UrethralPain.ToString();
            TextBox30.Text = ResDiagnosis.VomitingBlood.ToString();
            TextBox31.Text = ResDiagnosis.Class.ToString();
            TextBox32.Text = ResDiagnosis.Reasonings;
            DateTime Date = Convert.ToDateTime(ResDiagnosis.Date);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Export();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string path = @"C:\Users\kinli\Downloads";
                string file = FileUpload1.FileName;
                path += file;
                //FileUpload1.SaveAs(@"C:\Users\kinli\Downloads" + FileUpload1.FileName);
                FileUpload1.SaveAs(path);
                Label2.Text = "File : " + FileUpload1.FileName;
                Label1.Text = Main.classifyTest("C:\\Users\\kinli\\Downloads" + FileUpload1.FileName,DropDownList4.Text);
            }
            else
            {
                Label2.Text = "No File";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MyAppointment.username = null;
            Response.Redirect("WebForm4.aspx");
        }
    }
}