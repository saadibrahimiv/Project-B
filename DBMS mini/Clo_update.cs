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
    public partial class Clo_update : Form
    {
        private bool date_changed1 = false;
        private bool date_changed2 = false;
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static Course_learning_outcome_Portal Frm1 = new Course_learning_outcome_Portal();
        public Clo_update(Course_learning_outcome_Portal form)
        {
            InitializeComponent();
            Frm1 = form;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    var id_v = Frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "update Clo set Name = @n,DateCreated=@dc, DateUpdated=@du  where Id=@id";

                    //VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    if (textBox1.Text != "")
                    { cmd.Parameters.AddWithValue("@n", textBox1.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@n", Frm1.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    }



                    if (date_changed1==true)
                    { cmd.Parameters.AddWithValue("@dc", dateTimePicker1.Value); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@dc", Frm1.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    }
                    if (date_changed2==true)
                    { cmd.Parameters.AddWithValue("@du", dateTimePicker2.Value); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@du", Frm1.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    }



                    cmd.Parameters.AddWithValue("@id", id_v);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("updated");
                    disp_data();
                    this.Hide();
                    Frm1.Show();
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
                    //dataGridView1.DataSource = tbl;
                    Frm1.dataGridView1.DataSource = tbl;
                    con.Close();

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
            dateTimePicker2.ValueChanged += new System.EventHandler(dateTimePicker2_ValueChanged);


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
            
            Frm1.Show();
            this.Hide();

        }
    }
}
        
