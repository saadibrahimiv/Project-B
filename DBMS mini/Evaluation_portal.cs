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
    public partial class Evaluation_portal : Form
    {
       
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        private int Assessment_id;
        private int Assessment_comp_id;
        private int Student_id;
        private int level_value;
        private int Measurement_id;
        private int Assessment_component_id;
        private bool index_changed3;
        private bool index_changed2;
        private bool index_changed1;
        private bool index_changed4;
        private int Assessment_id1;
        private int std_id;
        private string std_fname;
        private int comp_id;
        private string comp_name;
        private int m_id;
        private string l_name;
        private string std_lname;
        private int level_value1;
        private string std_reg;
        private float measure_level;
        private int rubric_id;
        private float max_level;
        private float total_marks;
        private float result;

        public Evaluation_portal()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet6.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet6.StudentResult);
            comboBox1.Text = "--select--";
            comboBox2.Text = "--select--";
            comboBox3.Text = "--select--";
            comboBox4.Text = "--select--";
           
            Assessment_component_id = 0;
            Measurement_id = 0;
            Student_id = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Student";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["RegistrationNumber"]);

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
                    string query1 = "Select * from Assessment";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["Title"]);

                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }

            comboBox3.Click += new System.EventHandler(comboBox3_clicked);
            comboBox4.Click += new System.EventHandler(comboBox4_clicked);
           
            comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_changed);
            comboBox2.SelectedIndexChanged += new System.EventHandler(comboBox2_changed);
            comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_changed);
            comboBox4.SelectedIndexChanged += new System.EventHandler(comboBox4_changed);
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
           
            Student_id = 0;
            Assessment_component_id = 0;
            Measurement_id = 0;
            disp_data();
        }

        private void comboBox4_changed(object sender, EventArgs e)
        {
            index_changed4 = true;
        }

        private void comboBox1_changed(object sender, EventArgs e)
        {
            index_changed1 = true;

        }

        private void comboBox2_changed(object sender, EventArgs e)
        {
            index_changed2 = true;
        }

        private void comboBox3_changed(object sender, EventArgs e)
        {
            index_changed3 = true;
        }

        

        

        private void comboBox3_clicked(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Assessment where Title = '" + comboBox2.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Assessment_id = Convert.ToInt32(reader["Id"]);
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
            comboBox3.Items.Clear();
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from AssessmentComponent where AssessmentId='" + Assessment_id + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox3.Items.Add(reader["Name"]);

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
        private void comboBox4_clicked(object sender, EventArgs e)
        {
            Assessment_comp_id = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from AssessmentComponent where Name = '" + comboBox3.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Assessment_comp_id = Convert.ToInt32(reader["RubricId"]);
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
            if (index_changed3 != true)
            {
                Assessment_comp_id = 0;
            }
            comboBox4.Items.Clear();
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from RubricLevel where RubricId='" + Assessment_comp_id + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int level = Convert.ToInt32(reader["MeasurementLevel"]);
                            if (level == 1)
                            {
                                comboBox4.Items.Add("Unsatisfactory");
                                level_value = 1;
                            }
                            else if (level == 2)
                            {
                                comboBox4.Items.Add("Fair");
                                level_value = 2;
                            }
                            else if (level == 3)
                            {
                                comboBox4.Items.Add("Good");
                                level_value = 3;
                            }
                            else
                            {
                                comboBox4.Items.Add("Excellent");
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

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Assessment_component_id = 0;
            
            comboBox3.Items.Clear();
            if (index_changed2 == true)
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Assessment where Title = '" + comboBox2.SelectedItem + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Assessment_id1 = Convert.ToInt32(reader["Id"]);
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
                if (index_changed3 == true)
                {
                    try
                    {

                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from AssessmentComponent where Name = '" + comboBox3.Text + "'";
                            SqlCommand command = new SqlCommand(query1, con);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Assessment_component_id = Convert.ToInt32(reader["Id"]);
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
               

                Measurement_id = 0;
                if (index_changed4 == true)
                {
                    try
                    {

                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from RubricLevel where MeasurementLevel = '" + level_value + "'";
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
               
                Student_id = 0;
                if (index_changed1 == true)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from Student where RegistrationNumber = '" + comboBox1.SelectedItem + "'";
                            SqlCommand command = new SqlCommand(query1, con);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Student_id = Convert.ToInt32(reader["Id"]);
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
                        string query = "INSERT INTO StudentResult(StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) VALUES (@s,@a,@r,@d)";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@s", Student_id);
                        cmd.Parameters.AddWithValue("@a", Assessment_component_id);
                        cmd.Parameters.AddWithValue("@r", Measurement_id);
                        cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value);

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


                
                comboBox3.SelectedItem = null;
                level_value = 0;
                comboBox2.SelectedItem = null;
                comboBox1.SelectedItem = null;

                comboBox1.Text = "--select--";
                comboBox2.Text = "--select--";
                comboBox3.Text = "--select--";
                comboBox4.Text = "--select--";

                Assessment_component_id = 0;
                Measurement_id = 0;
                Student_id = 0;
                Assessment_comp_id = 0;
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
                std_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
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
                dataGridView1.Rows[i].Cells[0].Value = std_fname +" "+  std_lname +" \\ "+ std_reg ;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comp_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
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
                dataGridView1.Rows[i].Cells[2].Value = comp_name;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                m_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
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
                                level_value1 =Convert.ToInt32 (reader["MeasurementLevel"]);

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
                dataGridView1.Rows[i].Cells[4].Value = l_name;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var measure_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
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
                var assess_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
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
               
                dataGridView1.Rows[i].Cells[7].Value = result;
                dataGridView1.Rows[i].Cells[8].Value = total_marks;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id_v = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var id_aa = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (e.ColumnIndex == 9)
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from StudentResult where StudentId='" + id_v + "' and AssessmentComponentId='"+id_aa+"' ";

                        cmd.ExecuteNonQuery();
                        con.Close();
                        SqlDataAdapter da = new SqlDataAdapter("select * from StudentResult", con);
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
            if (e.ColumnIndex == 10)
            {
                Result_update form = new Result_update(this);
                form.Show();
                this.Hide();
            }
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
            Assessment_portal form = new Assessment_portal();
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Class_attendance form = new Class_attendance();
            form.Show();
            this.Hide();
        }
    }
}
