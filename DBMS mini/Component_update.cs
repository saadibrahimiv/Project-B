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
    public partial class Component_update : Form
    {
        int Rubric_id;
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static Assessment_component frm1 = new Assessment_component();
        private int clo_id;
        private bool date_changed1;
        private bool date_changed2;
        private int r_id;
        private string detail;
        private int clo_id1;
        private string clo_name;

        public Component_update(Assessment_component form)
        {
            InitializeComponent();
            frm1 = form;
        }
        public void disp_data()
        {
            var id_v = frm1.dataGridView1.CurrentRow.Cells[8].Value.ToString();

            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from AssessmentComponent where AssessmentId='" + id_v + "'", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);

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
                r_id = Convert.ToInt32(frm1.dataGridView1.Rows[i].Cells[4].Value);
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
                frm1.dataGridView1.Rows[i].Cells[3].Value = detail;
            }

            for (int i = 0; i < frm1.dataGridView1.Rows.Count; i++)
            {
                r_id = Convert.ToInt32(frm1.dataGridView1.Rows[i].Cells[4].Value);
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
                                clo_id1 = Convert.ToInt32(reader["CloId"]);

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
                frm1.dataGridView1.Rows[i].Cells[2].Value = clo_name;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                    var id_v = frm1.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    var id = frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "update AssessmentComponent set Name=@n,RubricId=@r,TotalMarks=@m,DateCreated=@c,DateUpdated=@u,AssessmentId=@i  where Id=@id";



                    SqlCommand cmd = new SqlCommand(query, con);
                    if (textBox2.Text != "")
                    { cmd.Parameters.AddWithValue("@n", textBox2.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@n", frm1.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    }
                    if (comboBox2.SelectedItem != null)
                    {

                        cmd.Parameters.AddWithValue("@r",Rubric_id );
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@r", frm1.dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    }
                    if (textBox1.Text != "")
                    { cmd.Parameters.AddWithValue("@m", textBox1.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@m", frm1.dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    }
                    if (date_changed1 == true)
                    { cmd.Parameters.AddWithValue("@c", dateTimePicker1.Value); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@c", frm1.dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    }
                    if (date_changed2 == true)
                    { cmd.Parameters.AddWithValue("@u", dateTimePicker2.Value); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@u", frm1.dataGridView1.CurrentRow.Cells[7].Value.ToString());
                    }



                    cmd.Parameters.AddWithValue("@i", id_v);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    // MessageBox.Show("updated");
                   
                    this.Hide();
                    frm1.Show();
                    disp_data();
                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
            
        }

        private void Component_update_Load(object sender, EventArgs e)
        {
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
            comboBox1.SelectedItem = null;


            comboBox2.SelectedItem = null;
            comboBox2.Text = "--select--";

            comboBox2.Click += new System.EventHandler(comboBox2_clicked);
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
            dateTimePicker2.ValueChanged += new System.EventHandler(dateTimePicker2_ValueChanged);

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
            comboBox2.SelectedItem = null;
           
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_changed1 = true;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date_changed2 = true;

        }


       

        private void button2_Click(object sender, EventArgs e)
        {
            
            frm1.Show();
            this.Hide();
        }
    }
}
