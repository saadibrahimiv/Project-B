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
    public partial class Assessment_update : Form
    {
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static Assessment_portal frm1 = new Assessment_portal();
        private bool date_changed1;

        public Assessment_update(Assessment_portal form)
        {
            InitializeComponent();
            frm1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    var id_v = frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "update Assessment set Title = @t,DateCreated=@c,TotalMarks=@m,TotalWeightage=@w  where Id=@id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    if (textBox1.Text != "")
                    { cmd.Parameters.AddWithValue("@t", textBox1.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@t", frm1.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    }



                    if (date_changed1 == true)
                    { cmd.Parameters.AddWithValue("@c", dateTimePicker1.Value); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@c", frm1.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    }
                    if (textBox4.Text != "")
                    { cmd.Parameters.AddWithValue("@m", textBox4.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@m", frm1.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    }
                    if (textBox3.Text != "")
                    { cmd.Parameters.AddWithValue("@w", textBox3.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@w", frm1.dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    }



                    cmd.Parameters.AddWithValue("@id", id_v);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("updated");
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

        private void Assessment_update_Load(object sender, EventArgs e)
        {
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_changed1 = true;
        }

        public void disp_data()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Assessment", con);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assessment_portal form = new Assessment_portal();
            form.Show();
            this.Hide();
        }
    }

}
