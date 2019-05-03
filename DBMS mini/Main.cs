using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_mini
{
    public partial class Main : Form
    {
        public static Rubrics_portal frm2 = new Rubrics_portal();
        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPortal form1 = new StudentPortal();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course_learning_outcome_Portal form2 = new Course_learning_outcome_Portal();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class_attendance form = new Class_attendance();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Evaluation_portal form = new Evaluation_portal();
            form.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Assessment_portal form = new Assessment_portal();
            form.Show();
            this.Hide();
        }
    }
}
