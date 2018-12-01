using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadam.course.capstone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            // the following code 
            string cont = Welcome.getsName();
            Name1.Text = cont;

            int crsno = Welcome.getnocours();
            Number1.Text = Convert.ToString(crsno);

            DateTime dttime = Welcome.getdate();
            Date.Text = Convert.ToString(dttime);

            string type6 = Welcome.gettype();
            Type.Text = type6;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                // Storeing the values to variables

                DateTime dt = Convert.ToDateTime(dateTimePicker1.Text);
                Hello.setstartdate(dt);// passing the value of datetime variable to another variable dtTime of the setdate method in class1.
                string course = Number.Text;
                // the following code tests the first textbox No. of Course Taken
                // it checks if the value entered is integer if not it shows an error.
                try
                {
                    int Nocourse = int.Parse(Number.Text, System.Globalization.NumberStyles.None); // parses the string in CrsTaken text box.
                    Hello.setcourseno(Nocourse); // passing the value of NoOfCourse variable to another variable course of the setsnocours method in class1.
                }

                catch (Exception)
                {
                    MessageBox.Show("Enter the Number of Courses Taken. Enter the values in form of Numbers only.");
                    Number.Clear();// Clears the TextBox CrsTaken

                }

                // the following code tests the Second textbox Student Name
                // it checks if the value entered ends with or starts with a space if it does it shows an error.
                string StdName = Name.Text; // storeing of value to variable
                if (StdName.EndsWith(" ") || StdName.StartsWith(" ")) // the code checks if the string starts with or ends with a Blank
                {
                    MessageBox.Show("Student Name Cannot Start or End with a Space");
                    Name.Clear();

                }
                else
                { }
                //the following code tests the Second textbox Student Name
                // it checks if the value entered consist of a space if it doesn't it shows an error.
                if (StdName.Contains(" ")) // the code that checks if there is space between first name and last name.
                {
                    Hello.setsn(StdName); // passing the value of StudentName variable to another variable sname of the sets1 method in class1.
                }
                else
                {
                    MessageBox.Show("There should be a space between First name and Last name");
                    Name.Clear();
                }

                if (online.Checked == true)
                {
                    string type = "Online";
                    Hello.setclasstype(type);

                }

                else
                {
                    Hybrid.Checked = true;
                    string t = "Hybrid";
                    Hello.setclasstype(t);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

