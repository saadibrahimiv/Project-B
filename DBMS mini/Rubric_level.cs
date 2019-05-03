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
    public partial class Rubric_level : Form
    {
        
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static Rubrics_portal frm1 = new Rubrics_portal();
        public Rubric_level(Rubrics_portal form)
        {
            InitializeComponent();
            frm1 = form;
        }


        Dictionary<string, int> integers = new Dictionary<string, int>();
        private int clo_id;
        private int combo_val;
        private string detail;
        private int m_id;
        private string l_name;

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet3.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet3.RubricLevel);

            integers.Add("Unsatisfactory", 1);
            integers.Add("Fair", 2);
            integers.Add("Good", 3);
            integers.Add("Excellent", 4);
            comboBox1.DataSource = new BindingSource(integers, null);
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";
            comboBox1.SelectedItem = null;
            comboBox1.Text = "--select--";

            disp_data();
        }

            public void disp_data()
        {
            var id_v = frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            clo_id = Convert.ToInt32(id_v);
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("select * from RubricLevel where RubricId='" + Convert.ToInt32(id_v) + "'", con);
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
                m_id =Convert.ToInt32( dataGridView1.Rows[i].Cells[4].Value);
                

                    if (m_id == 1)
                {
                    l_name="Unsatisfactory";
                  
                }
                else if (m_id == 2)
                {
                   l_name="Fair";
                   
                }
                else if (m_id == 3)
                {
                    l_name = "Good";
                }
                else
                {
                    l_name = "Excellent";
                }
                dataGridView1.Rows[i].Cells[3].Value = l_name;

            }
            
            
                
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            combo_val = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Value;
            var id_v = frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {


                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query = "INSERT INTO RubricLevel(RubricId,Details,MeasurementLevel) VALUES (@id,@d,@l)";


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id_v));
                    cmd.Parameters.AddWithValue("@l", combo_val);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    // MessageBox.Show("ADDED");
                    disp_data();
                    textBox2.Text = "";
                    comboBox1.Text = "--select--";

                }
            }

            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
            comboBox1.SelectedItem = null;
            comboBox1.Text = "--select--";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frm1.Show();
            this.Hide();
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
                        cmd.CommandText = "delete from RubricLevel where Id='" + id_v + "'";

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
                Level_update form = new Level_update(this);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }
    }
}
