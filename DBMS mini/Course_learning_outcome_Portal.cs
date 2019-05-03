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
    public partial class Course_learning_outcome_Portal : Form

    {
       
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public Course_learning_outcome_Portal()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query = "INSERT INTO Clo(Name,DateCreated,DateUpdated) VALUES (@n,@dc,@ud)";


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@dc", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@ud", dateTimePicker2.Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("ADDED");
                    disp_data();
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
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Clo", con);
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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Course_learning_outcome_Portal_Load(object sender, EventArgs e)
        {
            try
            {
                
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Clo", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    dataGridView1.DataSource = tbl;

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);

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
                        string query1 = "Select * from Rubric where CloId = '" + id_v + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                var rubric_id = Convert.ToInt32(reader["Id"]);

                                try
                                {
                                    using (SqlConnection conn = new SqlConnection(str))
                                    {


                                        conn.Open();
                                        SqlCommand cmd = conn.CreateCommand();
                                        cmd.CommandType = CommandType.Text;

                                        cmd.CommandText = "delete from AssessmentComponent where RubricId = '" + rubric_id + "'";
                                        cmd.ExecuteNonQuery();
                                        conn.Close();


                                    }
                                }
                                catch (System.Data.SqlClient.SqlException sqlException)
                                {
                                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                                    MessageBox.Show("Error occurred");
                                }

                            } } } }
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
                        string query1 = "Select * from Rubric where CloId = '" + id_v + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                var rubric_id = Convert.ToInt32(reader["Id"]);

                                try
                                {
                                    using (SqlConnection conn = new SqlConnection(str))
                                    {

                                        conn.Open();
                                        SqlCommand cmd = conn.CreateCommand();
                                        cmd.CommandType = CommandType.Text;

                                        cmd.CommandText = "delete from RubricLevel where RubricId = '" + rubric_id + "'";
                                        cmd.ExecuteNonQuery();
                                        conn.Close();


                                    }
                                }
                                catch (System.Data.SqlClient.SqlException sqlException)
                                {
                                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                                    MessageBox.Show("Error occurred");
                                }
                            }
                        }
                    } }
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
                       
                        cmd.CommandText = "delete from Rubric where CloId='" + id_v + "'";
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
                        cmd.CommandText = "delete from Clo where Id='" + id_v + "' ";
                        
                        cmd.ExecuteNonQuery();
                        con.Close();
                        SqlDataAdapter da = new SqlDataAdapter("select * from Clo", con);
                        DataTable tbl = new DataTable();
                        da.Fill(tbl);
                        dataGridView1.DataSource = tbl;

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

                Clo_update form2 = new Clo_update(this);
                form2.Show();
                this.Hide();


            }
            if (e.ColumnIndex == 4)
            {
                var id_v = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                Rubrics_portal form3 = new Rubrics_portal(this);
                form3.Show();
                this.Hide();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StudentPortal form = new StudentPortal();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Assessment_portal form = new Assessment_portal();
            form.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
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
    

