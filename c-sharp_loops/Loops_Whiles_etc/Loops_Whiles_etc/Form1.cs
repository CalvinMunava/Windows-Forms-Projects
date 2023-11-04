using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops_Whiles_etc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Human {
            public string Name { get; set; }

            public string sleep()
            {
                return Name + " is sleeping";
            }

        }

        public class Student
        {
            public string StudentNumber { get; set; }
            public string RegistrationDate { get; set; }
            public string RegistrationExpiary { get; set; }
        }
        public void NukeRussia()
        {
            var Step1 = "Get the Nukes";
            var Step2 = "Load them into missile champer";
            var Step3 = "Do the pre flight check";
            var Step4 = "Nuke Russia";
            //do
            //    Step1
            //        do 
            //            Step2

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //--------------------------------------whiles -----------------------------------\\
            //  > < = == ! != true false !true == > "false"  !false ==> "true";
            Human newHuman = new Human();
            newHuman.Name = "Zinhle";

            string Name = "";

            int i = 0;
            while ( i < 24)
            {
                NukeRussia();
                i++;
            }


            Student student = new Student();
            student.StudentNumber = "19051883";
            student.RegistrationDate = "17/01/2022";
            student.RegistrationExpiary = "17/12/2022";

            DateTime today = new DateTime();
            while (today.ToString() != student.RegistrationExpiary)
            {
                //Allow student to enter hatfield campus

                //wait 24 hours before doing this 
                today.AddDays(1);
            }


            //--------------------------------------FOR-----------------------------------\\
            
            // i j k l -- x z                         //0         //1   //2    //3             //4
            string[] EnemiesofRussia = new string[] { "Ukraine", "USA", "UK", "SOUTH AFRICA", "AUSTRALIA" }; // 5 -- ? 


                   //start         //condition   //updating sequence 
            for( int zinhle = 0;    zinhle < 24;     zinhle++ )
            {
                NukeRussia();
            }

            for( int zinhle = 24; zinhle >= 0; zinhle--)
            {
                NukeRussia();
            }

            for (int zinhle = 0; zinhle < EnemiesofRussia.Length ; zinhle++)
            {
                MessageBox.Show(EnemiesofRussia[zinhle] + " Nuked Russia");
                NukeRussia();
            }

        }
    }
}
