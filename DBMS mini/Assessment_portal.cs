using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_mini
{

    public partial class Assessment_portal : Form
    {
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public Assessment_portal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {

                    con.Open();
                    string query = "INSERT INTO Assessment(Title,DateCreated,TotalMarks,TotalWeightage) VALUES (@t,@c,@m,@w)";
                    
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@t", textBox1.Text.ToString());
                    
                    cmd.Parameters.AddWithValue("@m", textBox4.Text.ToString());
                    cmd.Parameters.AddWithValue("@c", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@w", textBox3.Text.ToString());


                    cmd.ExecuteNonQuery();
                    con.Close();
                    // MessageBox.Show("ADDED");

                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    
                    
                }
            }

            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
            
           
            disp_data();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet5.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet5.Assessment);
        
        }
        public void disp_data()
        {
            
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Assessment", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    //dataGridView1.DataSource = tbl;
                    dataGridView1.DataSource = tbl;
                    con.Close();

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Assessment_component form = new Assessment_component(this);
                form.Show();
                this.Hide();
            }

            if (e.ColumnIndex == 6)
            {
                var id_v = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete  from AssessmentComponent where AssessmentId='" + id_v + "'";

                        cmd.ExecuteNonQuery();
                        con.Close();
                        
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Assessment where Id='" + id_v + "'";

                        cmd.ExecuteNonQuery();
                        con.Close();
                        disp_data();

                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
            }
            if (e.ColumnIndex == 7)
            {
                Assessment_update form = new Assessment_update(this);
                form.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main form = new Main();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Main form = new Main();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            StudentPortal form = new StudentPortal();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Course_learning_outcome_Portal form = new Course_learning_outcome_Portal();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Evaluation_portal form = new Evaluation_portal();
            form.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Class_attendance form = new Class_attendance();
            form.Show();
            this.Hide();
        }
    }
}
