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
    public partial class Level_update : Form
    {
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static Rubric_level frm1 = new Rubric_level();
        public Level_update(Rubric_level form)
        {
            InitializeComponent();
            frm1 = form;
        }

        Dictionary<string, int> integers = new Dictionary<string, int>();
        private int combo_val;
        private int m_id;
        private string l_name;

        private void Form5_Load(object sender, EventArgs e)
        {
            integers.Add("Unsatisfactory", 1);
            integers.Add("Fair", 2);
            integers.Add("Good", 3);
            integers.Add("Excellent", 4);
            comboBox1.DataSource = new BindingSource(integers, null);
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";
            comboBox1.SelectedItem = null;
            comboBox1.Text = "--select--";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                   
                    con.Open();
                    var id_v = frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "update RubricLevel set Details = @d, MeasurementLevel=@l where Id=@id";



                    SqlCommand cmd = new SqlCommand(query, con);
                    if (textBox1.Text != "")
                    { cmd.Parameters.AddWithValue("@d", textBox1.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@d", frm1.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    }
                    if (comboBox1.SelectedItem != null)
                    {
                        combo_val = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Value;
                        cmd.Parameters.AddWithValue("@l", combo_val);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@l", frm1.dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    }





                    cmd.Parameters.AddWithValue("@id", id_v);
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
            var clo_ID = frm1.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            var clo_ID1 = Convert.ToInt32(clo_ID);
           
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {

                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("select * from RubricLevel where RubricId='" + clo_ID1 + "'", con);
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
                m_id = Convert.ToInt32(frm1.dataGridView1.Rows[i].Cells[4].Value);


                if (m_id == 1)
                {
                    l_name = "Unsatisfactory";

                }
                else if (m_id == 2)
                {
                    l_name = "Fair";

                }
                else if (m_id == 3)
                {
                    l_name = "Good";
                }
                else
                {
                    l_name = "Excellent";
                }


            }
            for (int i = 0; i < frm1.dataGridView1.Rows.Count; i++)
            {
                frm1.dataGridView1.Rows[i].Cells[3].Value = l_name;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            frm1.Show();
            this.Hide();
        }
    }
    }

