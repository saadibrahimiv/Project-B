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
    public partial class Rubrics_portal : Form
    {
        int clo_id;
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static Course_learning_outcome_Portal Frm1 = new Course_learning_outcome_Portal();
        private object r_id;
        private string r_detail;
        private string clo_name;

        public Rubrics_portal(Course_learning_outcome_Portal form)
        {
            InitializeComponent();
            Frm1 = form;

        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet2.Rubric' table. You can move, or remove it, as needed.
            //this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);
            disp_data();
            //display();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var id_v = Frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {

                
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query = "INSERT INTO Rubric(Details,CloId) VALUES (@d,@id)";


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@id",Convert.ToInt32(id_v));
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    // MessageBox.Show("ADDED");
                    disp_data();
                    //display();
                    textBox1.Text = "";

                }
            }

            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
        }
        public void disp_data()
        {
            var id_v = Frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            clo_id = Convert.ToInt32(id_v);
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                   
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("select * from Rubric where CloId='" + Convert.ToInt32(id_v) + "'", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    dataGridView1.DataSource = tbl;
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
                    string query1 = "Select * from Clo where Id='" + Convert.ToInt32(id_v) + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clo_name = reader["Name"].ToString();
                           
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = clo_name;

            }


        }
       
            

        
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)

            {

                var id_v = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from RubricLevel where RubricId='" + id_v + "'";

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
                        cmd.CommandText = "delete from AssessmentComponent where RubricId='" + id_v + "'";

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
                        cmd.CommandText = "delete from Rubric where Id='" + id_v + "'";
                        
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

            if (e.ColumnIndex == 6)
            {
                var id_v = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Rubric_update form4 = new Rubric_update(this);
                form4.Show();
                this.Hide();
                
            }

            if (e.ColumnIndex == 4)
            {
                Rubric_level form3 = new Rubric_level(this);
                form3.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button3_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            Course_learning_outcome_Portal form = new Course_learning_outcome_Portal();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Assessment_portal form = new Assessment_portal();
            form.Show();
            this.Hide();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Course_learning_outcome_Portal form = new Course_learning_outcome_Portal();
            form.Show();
            this.Hide();
        }
    }
}
