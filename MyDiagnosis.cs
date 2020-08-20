using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Web;

namespace WebApplication2
{
    public class MyDiagnosis
    {
        public int Counter { get; set; }
        public string Date { get; set; }
        public int Angina { get; set; }
        public int Bruise { get; set; }
        public int CoughingUpBlood { get; set; }
        public int Coughing { get; set; }
        public int Coma { get; set; }
        public int Dizzy { get; set; }
        public int Diarrhea { get; set; }
        public int DifficultyBreathing { get; set; }
        public int Flu { get; set; }
        public int FootPain { get; set; }
        public int GenitalPain { get; set; }
        public int HandPain { get; set; }
        public int Headache { get; set; }
        public int Itch { get; set; }
        public int Incontinence { get; set; }
        public int IrregularHeartRate { get; set; }
        public int MusclePain { get; set; }
        public int MouthUlcer { get; set; }
        public int Rash { get; set; }
        public int RigidMuscles { get; set; }
        public int RunnyNose { get; set; }
        public int ShoulderPain { get; set; }
        public int Stomachache { get; set; }
        public int SoreThroat { get; set; }
        public int Sputum { get; set; }
        public int Sneezing { get; set; }
        public int Toothache { get; set; }
        public int Tinnitus { get; set; }
        public int UrethralPain { get; set; }
        public int VomitingBlood { get; set; }
        public int Class { get; set; }
        public string Reasonings { get; set; }

        public static List<MyDiagnosis> GenerateDiagnoseList(string FromDate, string ToDate)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "C8u58eR9CaCRk8zC0a11EYHCC94eI0DkVQbPmbdb",
                BasePath = "https://theusers-b5706.firebaseio.com/"
            };

            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);

            var res1 = client.Get(@"Diagnose/");
            MyDiagnosis ResDiagnosis1 = res1.ResultAs<MyDiagnosis>();
            var i = ResDiagnosis1.Counter.ToString();
            int c = Convert.ToInt32(i);

            List<MyDiagnosis> dia2 = new List<MyDiagnosis>();
            //for (int a = 0; a < b; b--) //keep looping until condition is false
            for (int d = 1; d <= c; d++)
            {
                //var res = client.Get(@"Diagnose/" + b);
                var res = client.Get(@"Diagnose/" + d);
                MyDiagnosis ResDiagnosis = res.ResultAs<MyDiagnosis>();

                DateTime Date = Convert.ToDateTime(ResDiagnosis.Date); //database daytime
                DateTime Date1 = Convert.ToDateTime(FromDate); //user given date
                DateTime Date2 = Convert.ToDateTime(ToDate); //user give date

                if (FromDate == null && ToDate == null)
                {
                    dia2.Add(new MyDiagnosis
                    {
                        Angina = ResDiagnosis.Angina,
                        Bruise = ResDiagnosis.Bruise,
                        CoughingUpBlood = ResDiagnosis.CoughingUpBlood,
                        Coughing = ResDiagnosis.Coughing,
                        Coma = ResDiagnosis.Coma,
                        Dizzy = ResDiagnosis.Dizzy,
                        Diarrhea = ResDiagnosis.Diarrhea,
                        DifficultyBreathing = ResDiagnosis.DifficultyBreathing,
                        Flu = ResDiagnosis.Flu,
                        FootPain = ResDiagnosis.FootPain,
                        GenitalPain = ResDiagnosis.GenitalPain,
                        HandPain = ResDiagnosis.HandPain,
                        Headache = ResDiagnosis.Headache,
                        Itch = ResDiagnosis.Itch,
                        Incontinence = ResDiagnosis.Incontinence,
                        IrregularHeartRate = ResDiagnosis.IrregularHeartRate,
                        MusclePain = ResDiagnosis.MusclePain,
                        MouthUlcer = ResDiagnosis.MouthUlcer,
                        Rash = ResDiagnosis.Rash,
                        RigidMuscles = ResDiagnosis.RigidMuscles,
                        RunnyNose = ResDiagnosis.RunnyNose,
                        ShoulderPain = ResDiagnosis.ShoulderPain,
                        Stomachache = ResDiagnosis.Stomachache,
                        SoreThroat = ResDiagnosis.SoreThroat,
                        Sputum = ResDiagnosis.Sputum,
                        Sneezing = ResDiagnosis.Sneezing,
                        Toothache = ResDiagnosis.Toothache,
                        Tinnitus = ResDiagnosis.Tinnitus,
                        UrethralPain = ResDiagnosis.UrethralPain,
                        VomitingBlood = ResDiagnosis.VomitingBlood,
                        Class = ResDiagnosis.Class,
                        Reasonings = ResDiagnosis.Reasonings
                    });
                }
                else if (Date1.Year <= Date.Year && Date.Year <= Date2.Year && Date1.Month <= Date.Month && Date.Month <= Date2.Month && Date1.Day <= Date.Day && Date.Day <= Date2.Day)
                {
                    dia2.Add(new MyDiagnosis
                    {
                        Angina = ResDiagnosis.Angina,
                        Bruise = ResDiagnosis.Bruise,
                        CoughingUpBlood = ResDiagnosis.CoughingUpBlood,
                        Coughing = ResDiagnosis.Coughing,
                        Coma = ResDiagnosis.Coma,
                        Dizzy = ResDiagnosis.Dizzy,
                        Diarrhea = ResDiagnosis.Diarrhea,
                        DifficultyBreathing = ResDiagnosis.DifficultyBreathing,
                        Flu = ResDiagnosis.Flu,
                        FootPain = ResDiagnosis.FootPain,
                        GenitalPain = ResDiagnosis.GenitalPain,
                        HandPain = ResDiagnosis.HandPain,
                        Headache = ResDiagnosis.Headache,
                        Itch = ResDiagnosis.Itch,
                        Incontinence = ResDiagnosis.Incontinence,
                        IrregularHeartRate = ResDiagnosis.IrregularHeartRate,
                        MusclePain = ResDiagnosis.MusclePain,
                        MouthUlcer = ResDiagnosis.MouthUlcer,
                        Rash = ResDiagnosis.Rash,
                        RigidMuscles = ResDiagnosis.RigidMuscles,
                        RunnyNose = ResDiagnosis.RunnyNose,
                        ShoulderPain = ResDiagnosis.ShoulderPain,
                        Stomachache = ResDiagnosis.Stomachache,
                        SoreThroat = ResDiagnosis.SoreThroat,
                        Sputum = ResDiagnosis.Sputum,
                        Sneezing = ResDiagnosis.Sneezing,
                        Toothache = ResDiagnosis.Toothache,
                        Tinnitus = ResDiagnosis.Tinnitus,
                        UrethralPain = ResDiagnosis.UrethralPain,
                        VomitingBlood = ResDiagnosis.VomitingBlood,
                        Class = ResDiagnosis.Class,
                        Reasonings = ResDiagnosis.Reasonings
                    });
                }
            }
            return dia2;
        }

    }
}