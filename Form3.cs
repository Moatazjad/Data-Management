using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try2
{
    public partial class Form3 : Form
    {
        List<Student> mystudents = new List<Student>();
        int IndexToShow = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void ShowStudent() 
        {
            lblcount.Text = $"{IndexToShow+ 1}/{mystudents.Count}";
            lblname.Text = mystudents[IndexToShow].Name;
            lbllast.Text = mystudents[IndexToShow].LastName;
            lblfather.Text = mystudents[IndexToShow].FatherName;
            lbldate.Text = mystudents[IndexToShow].DateOfBirth.ToString();
            lbljoin.Text = mystudents[IndexToShow].JoinDate.ToString();
            lblnationality.Text = mystudents[IndexToShow].Nationality;

            if (IndexToShow >= mystudents.Count-1) 
            {
                Navright.Enabled = false;
            }
            if (IndexToShow == 0) 
            {
                Navleft.Enabled = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream) 
            {
                string line = sr.ReadLine();
                string[] splittedline = line.Split(';');

                Student s = new Student(splittedline[0],
                    splittedline[1],
                    splittedline[2], 
                    splittedline[3],
                    splittedline[4], 
                    splittedline[5]
                    );
                mystudents.Add(s);
            }

            sr.Close();
            fs.Close();
            ShowStudent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (IndexToShow >= 0 && IndexToShow < mystudents.Count) 
            {
                mystudents.RemoveAt(IndexToShow);
                FileStream fs = new FileStream("Student.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                
                    
                                  
                    
            }

        }

        private void Navright_Click(object sender, EventArgs e)
        {
            IndexToShow++;
            ShowStudent();
            Navleft.Enabled = true;
        }

        private void Navleft_Click(object sender, EventArgs e)
        {
            IndexToShow--;
            ShowStudent();
            Navright.Enabled = true;
        }
    }
}
