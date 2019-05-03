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
    public partial class Result_update : Form
    {
        public static Evaluation_portal frm1= new Evaluation_portal();
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        private int Assessment_id;
        private int level_value;
        private int Assessment_comp_id;
        private int Student_id;
        private int Measurement_id;
        private int Assessment_component_id;
        private bool date_changed1;
        private string reg_num;
        private string a_component;
        private string level_key;
        private int rubric_id;
        private int std_id;
        private string std_fname;
        private string std_lname;
        private int comp_id;
        private string comp_name;
        private int m_id;
        private string l_name;
        private int level_value1;
        private string std_reg;
        private float measure_level;
        private float max_level;
        private float total_marks;
        private float result;
        private object dataGridView1;

        public Result_update(Evaluation_portal form)
        {
            InitializeComponent();
            frm1 = form;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evaluation_portal form = new Evaluation_portal();
            form.Show();
            this.Hide();
        }

        private void Result_update_Load(object sender, EventArgs e)
        {
            
            var id_a = frm1.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from AssessmentComponent where Id='" + id_a+ "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rubric_id =Convert.ToInt32( reader["RubricId"]);

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
                    string query1 = "Select * from RubricLevel where RubricId='" + rubric_id + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int level = Convert.ToInt32(reader["MeasurementLevel"]);
                            if (level == 1)
                            {
                                
                                level_key = "Unsatisfactory";
                                comboBox4.Items.Add(level_key);
                                level_value = 1;
                            }
                            else if (level == 2)
                            {
                                
                                level_key = "Fair";
                                comboBox4.Items.Add(level_key);
                                level_value = 2;

                            }
                            else if (level == 3)
                            {
                               
                                level_key = "Good";
                                comboBox4.Items.Add(level_key);
                                level_value = 3;

                            }
                            else
                            {

                                level_key = "Excellent";
                                comboBox4.Items.Add(level_key);
                                level_value = 4;
                                
                            }
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }

            comboBox4.SelectedItem = null;
            comboBox4.Text = "--select--";
            
                      
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);


           

            
            
           


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_changed1 = true;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem.ToString() == "Unsatisfactory")
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from RubricLevel where MeasurementLevel = '"+1+"' and RubricId= '"+rubric_id+"'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Measurement_id = Convert.ToInt32(reader["Id"]);
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

            }
            if (comboBox4.SelectedItem.ToString() == "Fair")
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from RubricLevel where MeasurementLevel = '" + 2 + "' and RubricId= '" + rubric_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Measurement_id = Convert.ToInt32(reader["Id"]);
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

            }
            if (comboBox4.SelectedItem.ToString() == "Good")
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from RubricLevel where MeasurementLevel = '" + 3 + "' and RubricId= '" + rubric_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Measurement_id = Convert.ToInt32(reader["Id"]);
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

            }
            if (comboBox4.SelectedItem.ToString() == "Excellent")
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from RubricLevel where MeasurementLevel = '" + 4 + "' and RubricId= '" + rubric_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Measurement_id = Convert.ToInt32(reader["Id"]);
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

            }
           
            
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();

                    var id_ss = frm1.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    var id_aa = frm1.dataGridView1.CurrentRow.Cells[3].Value.ToString();

                    string query = "update StudentResult set RubricMeasurementId=@m,EvaluationDate=@d  where StudentId=@id and AssessmentComponentId=@a";



                    SqlCommand cmd = new SqlCommand(query, con);
                   
                        
                   
                       
                    
                   
                    if (comboBox4.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@m", Measurement_id);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@m", frm1.dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    }
                    if (date_changed1 == true)
                    { cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@d", frm1.dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    }


                    cmd.Parameters.AddWithValue("@id",Convert.ToInt32 (id_ss));
                    cmd.Parameters.AddWithValue("@a", Convert.ToInt32(id_aa));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    // MessageBox.Show("updated");
                    disp_data();
                    this.Hide();
                    frm1.Show();
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
                    SqlDataAdapter da = new SqlDataAdapter("select * from StudentResult", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    //dataGridView1.DataSource = tbl;
                    frm1.dataGridView1.DataSource = tbl;
                    con.Close();

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }

            for (int i = 0; i < frm1.dataGridView1.Rows.Count; i++)
            {
                std_id = Convert.ToInt32(frm1.dataGridView1.Rows[i].Cells[1].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Student where Id='" + std_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                std_fname = reader["FirstName"].ToString();
                                std_lname = reader["LastName"].ToString();
                                std_reg = reader["RegistrationNumber"].ToString();

                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
                frm1.dataGridView1.Rows[i].Cells[0].Value = std_fname + " " + std_lname +" \\ "+ std_reg;
            }
            for (int i = 0; i < frm1.dataGridView1.Rows.Count; i++)
            {
                comp_id = Convert.ToInt32(frm1.dataGridView1.Rows[i].Cells[3].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from AssessmentComponent where Id='" + comp_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comp_name = reader["Name"].ToString();

                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
                frm1.dataGridView1.Rows[i].Cells[2].Value = comp_name;
            }
            for (int i = 0; i < frm1.dataGridView1.Rows.Count; i++)
            {
                m_id = Convert.ToInt32(frm1.dataGridView1.Rows[i].Cells[5].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from RubricLevel where Id='" + m_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                level_value1 = Convert.ToInt32(reader["MeasurementLevel"]);

                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }

                if (level_value1 == 1)
                {
                    l_name = "Unsatisfactory";

                }
                else if (level_value1 == 2)
                {
                    l_name = "Fair";

                }
                else if (level_value1 == 3)
                {
                    l_name = "Good";
                }
                else if (level_value1 == 4)
                {
                    l_name = "Excellent";
                }
                frm1.dataGridView1.Rows[i].Cells[4].Value = l_name;
            }

            for (int i = 0; i < frm1.dataGridView1.Rows.Count; i++)
            {
                var measure_id = Convert.ToInt32(frm1.dataGridView1.Rows[i].Cells[5].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from RubricLevel where Id = '" + measure_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                measure_level = Convert.ToInt32(reader["MeasurementLevel"]);
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
                        string query1 = "Select * from RubricLevel where Id = '" + measure_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rubric_id = Convert.ToInt32(reader["RubricId"]);
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
                        string query1 = "Select * from RubricLevel where RubricId = '" + rubric_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    using (SqlConnection conn = new SqlConnection(str))
                                    {
                                        conn.Open();
                                        string query2 = "Select max(MeasurementLevel) from RubricLevel where RubricId = '" + rubric_id + "'";
                                        SqlCommand command1 = new SqlCommand(query2, conn);
                                        max_level = (int)command1.ExecuteScalar();
                                    }
                                }
                                catch (System.Data.SqlClient.SqlException sqlException)
                                {
                                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                                    MessageBox.Show("Error occurred");
                                }
                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
                var assess_id = Convert.ToInt32(frm1.dataGridView1.Rows[i].Cells[3].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from AssessmentComponent where Id = '" + assess_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                total_marks = Convert.ToInt32(reader["TotalMarks"]);
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

               
                result = (measure_level / max_level) * total_marks;

                frm1.dataGridView1.Rows[i].Cells[7].Value = result;
                frm1.dataGridView1.Rows[i].Cells[8].Value = total_marks;
            }
        }

    }
    }
    

