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
    public partial class Student_update : Form

    {
        public static Rubrics_portal frm2 = new Rubrics_portal();
        Dictionary<string, int> integers = new Dictionary<string, int>();
        int combo_val;
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static StudentPortal Frm1 = new StudentPortal();
        private int s_id;
        private string s_name;

        public Student_update(StudentPortal form)
        {
            InitializeComponent();
            Frm1 = form;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    var id_v = Frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "update Student set FirstName = @fn, LastName = @ln, Contact = @c, Email = @e, RegistrationNumber = @r, Status = @s where Id=@id" ;
                         
                        //VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "')";
                    
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (textBox1.Text != "")
                    { cmd.Parameters.AddWithValue("@fn", textBox1.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@fn", Frm1.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    }

                    if (textBox2.Text != "")
                    { cmd.Parameters.AddWithValue("@ln", textBox2.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ln", Frm1.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    }
                    if (textBox3.Text != "")
                    { cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@c", Frm1.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    }
                    if (textBox4.Text != "")
                    { cmd.Parameters.AddWithValue("@e", textBox4.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@e", Frm1.dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    }
                    if (textBox5.Text != "")
                    { cmd.Parameters.AddWithValue("@r", textBox5.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@r", Frm1.dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    }
                    if (comboBox1.SelectedItem != null)
                    {
                        combo_val = ((KeyValuePair<string, int>)comboBox1.SelectedItem).Value;

                        cmd.Parameters.AddWithValue("@s", combo_val);
                    }
                     
                    else
                    {
                        cmd.Parameters.AddWithValue("@s", Frm1.dataGridView1.CurrentRow.Cells[7].Value);
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
                    SqlDataAdapter da = new SqlDataAdapter("select * from Student", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    Frm1.dataGridView1.DataSource = tbl;
                    con.Close();

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }

            for (int i = 0; i < Frm1.dataGridView1.Rows.Count; i++)
            {
                s_id = Convert.ToInt32(Frm1.dataGridView1.Rows[i].Cells[7].Value);


                if (s_id == 5)
                {
                    s_name = "Active";

                }
                else if (s_id == 6)
                {
                    s_name = "Inactive";

                }

                Frm1.dataGridView1.Rows[i].Cells[6].Value = s_name;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            integers.Add("active", 5);
            integers.Add("inactive", 6);
            comboBox1.DataSource = new BindingSource(integers, null);
            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";
            comboBox1.SelectedItem = null;
            comboBox1.Text = "--select--";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPortal form = new StudentPortal();
            form.Show();
            this.Hide();
        }
    }
}
