using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_mini
{

    public partial class StudentPortal : Form

    {
        
        bool valueChanged;

        public StudentPortal()
        {
            
            InitializeComponent();
            
            
        }

       
        Dictionary<string, int> integers = new Dictionary<string, int>();
        int combo_val;

        private void StudentPortal_Load(object sender, EventArgs e)
        {

            integers.Add("Active", 5);
            integers.Add("Inactive", 6);
            comboBox1.DataSource = new BindingSource(integers, null);
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";
            comboBox1.SelectedItem = null;
            comboBox1.Text = "--select--";
            disp_data();
        }
        private void comboBox1_valueChanged(object sender, EventArgs e)
        {
            valueChanged = true;
            
            
        }

        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        private int s_id;
        private string s_name;
        private string s_val;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                var id_v = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Student_update form1 = new Student_update(this);
                form1.Show();
                this.Hide();
                
                    
                    
            }



            if (e.ColumnIndex == 8 )

            {
                var id_v = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from StudentAttendance where StudentId='" + id_v + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        

                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }


                 id_v = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from StudentResult where StudentId='" + id_v + "'";
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
                        cmd.CommandText = "delete from Student where Id='" + id_v + "'";
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(valueChanged.ToString());
            //if (valueChanged == true)
            //{
           
            //}

            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("All fields required");
                }

                else
                {

                    combo_val = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Value;
                    string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();

                        string query = "INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES (@fn,@ln,@c,@e,@r,@s)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@fn", textBox1.Text.ToString());
                        cmd.Parameters.AddWithValue("@ln", textBox2.Text.ToString());
                        cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString());
                        cmd.Parameters.AddWithValue("@e", textBox4.Text.ToString());
                        cmd.Parameters.AddWithValue("@r", textBox5.Text.ToString());
                        cmd.Parameters.AddWithValue("@s", combo_val);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        //MessageBox.Show("ADDED");
                        disp_data();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        comboBox1.Text = "--select--";


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
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Student", con);
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
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                s_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
                

                if (s_id == 5)
                {
                    s_name = "Active";

                }
                else if (s_id == 6)
                {
                    s_name = "Inactive";

                }

                dataGridView1.Rows[i].Cells[6].Value = s_name;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main form = new Main();
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
