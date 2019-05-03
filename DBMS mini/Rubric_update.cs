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
    public partial class Rubric_update : Form
    {
        int clo_ID1;
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static Rubrics_portal Frm1 = new Rubrics_portal();
        private string clo_name;

        public Rubric_update(Rubrics_portal form)
        {
            InitializeComponent();
            Frm1 = form;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clo_id = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Clo where Name = '"+comboBox1.SelectedItem+"'";
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

            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    var id_v = Frm1.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "update Rubric set Details = @d, CloId=@c where Id=@id";



                    SqlCommand cmd = new SqlCommand(query, con);
                    if (textBox1.Text != "")
                    { cmd.Parameters.AddWithValue("@d", textBox1.Text.ToString()); }
                    else
                    {
                        cmd.Parameters.AddWithValue("@d", Frm1.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    }
                    if (comboBox1.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@c", clo_id);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@c", Frm1.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    }





                    cmd.Parameters.AddWithValue("@id", id_v);
                    cmd.ExecuteNonQuery();
                    con.Close();
                   // MessageBox.Show("updated");
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
            var clo_ID = Frm1.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            clo_ID1 = Convert.ToInt32(clo_ID);
            try
            {

                using (SqlConnection con = new SqlConnection(str))  
                {

                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("select * from Rubric where CloId='" + clo_ID1 + "'", con);
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
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Clo where Id='" + clo_ID1 + "'";
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
            for (int i = 0; i < Frm1.dataGridView1.Rows.Count; i++)
            {
                Frm1.dataGridView1.Rows[i].Cells[3].Value = clo_name;

            }


        }
        private void Form4_Load(object sender, EventArgs e)
        {
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
            comboBox1.Text = "--select--";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
       
    

