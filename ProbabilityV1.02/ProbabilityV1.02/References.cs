using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;



namespace ProbabilityV1._02
{
    public partial class References : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpay\Documents\Trial.accdb");

        public References()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }


        void dataviewer()
        {
            try
            {


                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Trial";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                    
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

           
        }
        //  OleDbConnection baglanti=new OleDbConnection();

        private void References_Load(object sender, EventArgs e)
        {
            dataviewer();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Trial(Reference_ID,Reference)values('" + textBox1.Text + "','" + textBox2.Text + "' )";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reference is added", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            
               
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to delete selected reference?",
                      "Delete reference", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete * from Trial where  Reference_ID='" + textBox1.Text + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Reference deleted", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        dataviewer();
                        break;
                    case DialogResult.No:
                        break;
                }

                


                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

            

            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text =String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            

        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Trial where Reference_ID = '" + search.Text + "' or Reference = '" + search.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Trial set Reference_ID='" + textBox1.Text + "'where Reference='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reference list updated", "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                dataviewer();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            dataviewer();
        }
    }
}
