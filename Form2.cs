using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Student.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"{txtname.Text};{txtlast.Text};{txtfather.Text};{txtdate.Text};{txtjoin.Text};{txtnationality.Text}");

            txtname.Clear();
            txtlast.Clear();
            txtfather.Clear();
            txtdate.Clear();
            txtjoin.Clear();
            txtnationality.Clear();

            sw.Close();
            fs.Close();
        }
    }
}
