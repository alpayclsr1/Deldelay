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
    public partial class main : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpay\Documents\airports.accdb");
        public main()
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            dataviewer();
            label1.Visible = false;
            label2.Visible = false; 
            label3.Visible = false; 
            from2.Visible = false;
            to2.Visible = false;
            to3.Visible = false;
            from3.Visible = false;
            swap2.Visible = false;
            swap3.Visible = false;
            time2.Visible = false;
            time3.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = true;
            groupBox3.Visible = false;


           
            
        }
        public System.Windows.Forms.TextBox textbox2;
        public static string fromm1 = "";
        public static string fromm2 = "";
        public static string fromm3 = "";
        public static string too1 = "";
        public static string too2 = "";
        public static string too3 = "";
        public static double fl1=0 ;
        public static double fl2=0 ;
        public static double fl3=0 ;
        public static string fll1="0" ;
        public static string fll2="0" ;
        public static string fll3="0" ;
        public static double ffl1 = 0;
        public static double ffl2 = 0;
        public static double ffl3 = 0;
        public static string rain1="" ;
        public static string rain2="" ;
        public static string rain3="" ;
        public static string pegasus1="" ;
        public static string pegasus2="" ;
        public static string pegasus3="" ;
        public static string thy1="" ;
        public static string thy2="" ;
        public static string thy3="" ;



        void dataviewer()
        {
            try
            {


                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from airport";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                DataTable dt5 = new DataTable();
                DataTable dt6 = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dp.Fill(dt2);
                dp.Fill(dt3);
                dp.Fill(dt4);
                dp.Fill(dt5);
                dp.Fill(dt6);
                from1.DataSource = dt4;
                from1.DisplayMember = "Airport_list";
                from1.ValueMember = "ID";
                from2.DataSource = dt5;
                from2.DisplayMember = "Airport_list";
                from2.ValueMember = "ID";
                from3.DataSource = dt6;
                from3.DisplayMember = "Airport_list";
                from3.ValueMember = "ID";
                to1.DataSource = dt2;
                to1.DisplayMember = "Airport_list";
                to1.ValueMember = "ID";
                to2.DataSource = dt3;
                to2.DisplayMember = "Airport_list";
                to2.ValueMember = "ID";
                to3.DataSource = dt;
                to3.DisplayMember = "Airport_list";
                to3.ValueMember = "ID";
                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }
      

            private void button1_Click(object sender, EventArgs e)
        {
            if (ra1.Checked == true)
            {
                rain1 = "rain1";
            } 
            if(ra2.Checked == true)
            {
                rain2 = "rain2";
            }
            if(ra3.Checked == true)
            {
                rain3 = "rain3";
            }
            if(pg1.Checked == true)
            {
                
            }
            
            
            if (singleflight.Checked == true)
            {

                try
                {


                    conn.Open();
                    OleDbCommand cmdd = new OleDbCommand();
                    cmdd.Connection = conn;
                    string query = "SELECT * FROM airport WHERE Airport_list ='" + from1.Text + "'";
                    cmdd.CommandText = query;
                    OleDbDataReader reader = cmdd.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        
                        fll1 = reader["Delay_probability"].ToString();

                        
                       
                        
                        
                    }
                    //cmd.CommandType = CommandType.Text;



                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                
                

                fromm1 = from1.Text;
                fromm2 = "bos";
                fromm3 = "bos";
                too1 = to1.Text;
                too2 = "bos";
                too3 = "bos";
            }

            else if(twoflight.Checked == true)
            {
                fromm1 = from1.Text;
                fromm2 = from2.Text;
                fromm3 = "bos";
                too1 = to1.Text;
                too2 = to2.Text;
                too3 = "bos";
                try
                {


                    conn.Open();
                    OleDbCommand cmdd = new OleDbCommand();
                    cmdd.Connection = conn;
                    string query = "SELECT * FROM airport WHERE Airport_list ='" + from1.Text + "'";
                    cmdd.CommandText = query;
                    OleDbDataReader reader = cmdd.ExecuteReader();
                    while (reader.Read())
                    {

                        
                        fll1 = reader["Delay_probability"].ToString();
                        // BURASI
                        ffl1 = Convert.ToDouble(fll1);
                       

                    }
                    //cmd.CommandType = CommandType.Text;



                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                try
                {


                    conn.Open();
                    OleDbCommand cmdd = new OleDbCommand();
                    cmdd.Connection = conn;
                    string query = "SELECT * FROM airport WHERE Airport_list ='" + from2.Text + "'";
                    cmdd.CommandText = query;
                    OleDbDataReader reader = cmdd.ExecuteReader();
                    while (reader.Read())
                    {

                        
                        fll2 = reader["Delay_probability"].ToString();

                        ffl2= Convert.ToDouble(fll2);
                        

                    }
                    //cmd.CommandType = CommandType.Text;



                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            else if(threeflight.Checked == true)
            {
                fromm1 = from1.Text;
                fromm2 = from2.Text;
                fromm3 = from3.Text;
                too1 = to1.Text;
                too2 = to2.Text;
                too3 = to3.Text;
                try
                {


                    conn.Open();
                    OleDbCommand cmdd = new OleDbCommand();
                    cmdd.Connection = conn;
                    string query = "SELECT * FROM airport WHERE Airport_list ='" + from1.Text + "'";
                    cmdd.CommandText = query;
                    OleDbDataReader reader = cmdd.ExecuteReader();
                    while (reader.Read())
                    {

                        
                        fll1 = reader["Delay_probability"].ToString();
                        ffl1 = Convert.ToDouble(fll1);



                    }
                    //cmd.CommandType = CommandType.Text;



                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                try
                {


                    conn.Open();
                    OleDbCommand cmdd = new OleDbCommand();
                    cmdd.Connection = conn;
                    string query = "SELECT * FROM airport WHERE Airport_list ='" + from2.Text + "'";
                    cmdd.CommandText = query;
                    OleDbDataReader reader = cmdd.ExecuteReader();
                    while (reader.Read())
                    {


                        fll2 = reader["Delay_probability"].ToString();

                        ffl2=Convert.ToDouble(fll2);

                      


                    }
                    //cmd.CommandType = CommandType.Text;



                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                try
                {


                    conn.Open();
                    OleDbCommand cmdd = new OleDbCommand();
                    cmdd.Connection = conn;
                    string query = "SELECT * FROM airport WHERE Airport_list ='" + from3.Text + "'";
                    cmdd.CommandText = query;
                    OleDbDataReader reader = cmdd.ExecuteReader();
                    while (reader.Read())
                    {


                        fll3 = reader["Delay_probability"].ToString();
                        ffl3= Convert.ToDouble(fll3);
                       


                    }
                    //cmd.CommandType = CommandType.Text;



                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }

            }
            
           




            result rslt =new result();
            rslt.Show();
            this.Close();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (singleflight.Checked == true)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                from2.Visible = false;
                to2.Visible = false;
                to3.Visible = false;
                from3.Visible = false;
                swap3.Visible=false;
                swap2.Visible=false;
                time2.Visible=false;
                time3.Visible=false;
                groupBox7.Visible = false;
                groupBox3.Visible = false;
                groupBox8.Visible = true;

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (twoflight.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                from2.Visible = true;
                to2.Visible = true;
                to3.Visible = false;
                from3.Visible = false;
                swap2.Visible = true;
                swap3.Visible = false;
                time2.Visible=true;
                time3.Visible = false;
                groupBox7.Visible=false;
                groupBox3.Visible=true;
                groupBox8.Visible=true;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void main_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (threeflight.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                from2.Visible = true;
                to2.Visible = true;
                to3.Visible = true;
                from3.Visible = true;
                swap2.Visible=true;
                swap3.Visible = true;
                time2.Visible =true;
                time3.Visible=true; 
                groupBox3.Visible=true;
                groupBox8.Visible=true;
                groupBox7.Visible=true;
                    

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            from2.SelectedItem = to1.SelectedItem;
            if (to1.SelectedIndex==from1.SelectedIndex)
            {
                
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            from3.SelectedItem = to2.SelectedItem;
        }

        private void swap1_Click(object sender, EventArgs e)
        {
            //int gecici = 0;
            //int gecici2=0;

            //gecici=from1.SelectedIndex ;
            //gecici2 = to1.SelectedIndex ;
            //from1.SelectedIndex=gecici2 ;
           // to1.SelectedIndex = gecici;


            


        }

        private void swap2_Click(object sender, EventArgs e)
        {
            int gecici3= 0;
            int gecici4= 0;

            gecici3= from2.SelectedIndex;
            gecici4= to2.SelectedIndex;
            from2.SelectedIndex = gecici4;
            to2.SelectedIndex = gecici3;
        }

        private void swap3_Click(object sender, EventArgs e)
        {
            int gecici5 = 0;
            int gecici6 = 0;

            gecici5 = from3.SelectedIndex;
            gecici6 = to3.SelectedIndex;
            from3.SelectedIndex = gecici6;
            to3.SelectedIndex = gecici5;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to go back to main menu? (your choices will disappear) ",
                      "Main Menu", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    menu menu = new menu();
                    menu.Show();
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
