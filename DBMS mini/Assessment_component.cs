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
    public partial class Assessment_component : Form
    {
        public static Assessment_portal frm1 = new Assessment_portal();
        private int combo_val;
        Dictionary<string, int> strings = new Dictionary<string, int>();
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        private string combo_key;
        private int combo1_val;
        private string combo1_key;
        private bool comboBox1_click;
        private bool comboBox2_click;
        private int Rubric_id;
        private int clo_id;
        private int r_id;
        private string detail;
        private int clo_id1;
        private string clo_name;

        public Assessment_component(Assessment_portal form)
        {
            InitializeComponent();
            frm1 = form;
        }

        

        private void Form7_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'projectBDataSet4.AssessmentComponent' table. You can move, or remove it, as needed.
            //this.assessmentComponentTableAdapter.Fill(this.projectBDataSet4.AssessmentComponent);
            comboBox1.SelectedItem = null;
            comboBox1.Text = "--select--";
            
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Clo";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["Name"]);

                        }
                        

                    }

                }


            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
        

            comboBox2.SelectedItem = null;
            comboBox2.Text = "--select--";

        comboBox2.Click += new System.EventHandler(comboBox2_clicked);
  
            disp_data();
        }

        private void comboBox2_clicked(object sender, EventArgs e)
        {
            
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Clo where Name = '" + comboBox1.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clo_id = Convert.ToInt32(reader["Id"]);
                            break;
                        }
                    }


                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }

            comboBox2.Items.Clear();
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Rubric where CloId='" + clo_id + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["Details"]);
                      
                        }
                       
                    }

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
            var id_v = frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from AssessmentComponent where AssessmentId='"+id_v+"'", con);
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
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                r_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Rubric where Id='" + r_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                detail = reader["Details"].ToString();

                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
                dataGridView1.Rows[i].Cells[3].Value = detail;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                r_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Rubric where Id='" + r_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clo_id1 =Convert.ToInt32( reader["CloId"]);

                            }
                        }
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
                        string query1 = "Select * from Clo where Id='" + clo_id1 + "'";
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
                dataGridView1.Rows[i].Cells[2].Value = clo_name;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var id_v = frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Rubric where Details = '" + comboBox2.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rubric_id = Convert.ToInt32(reader["Id"]);
                            break;
                        }
                    }


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
                    string query = "INSERT INTO AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) VALUES (@n,@r,@m,@c,@u,@i)";


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@r", Rubric_id);
                    cmd.Parameters.AddWithValue("@m", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@c", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@u",dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@i", Convert.ToInt32(id_v));
                    

                    cmd.ExecuteNonQuery();
                    con.Close();
                    // MessageBox.Show("ADDED");
                    
                    textBox1.Text = "";
                    textBox2.Text = "";
                    disp_data();
                }
            }

            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox1.Text = "--select--";
            comboBox2.Text = "--select--";
            Rubric_id = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                    var id_v = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                 try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from StudentResult where AssessmentComponentId='" + id_v + "'";

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
                            cmd.CommandText = "delete from AssessmentComponent where Id='" + id_v + "'";

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
            if (e.ColumnIndex == 10)
            {
                Component_update form = new Component_update(this);
                form.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assessment_portal form = new Assessment_portal();
            form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Course_learning_outcome_Portal form = new Course_learning_outcome_Portal();
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Evaluation_portal form = new Evaluation_portal();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Assessment_portal form = new Assessment_portal();
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
            frm1.Show();
            this.Hide();
        }
    }
    

}
