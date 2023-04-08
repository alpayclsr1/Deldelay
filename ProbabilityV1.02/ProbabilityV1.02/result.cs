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
using System.Diagnostics;

namespace ProbabilityV1._02
{
    public partial class result : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpay\Documents\airports.accdb");
        public static double delay1 = 0;
        public static double delay2 = 0;
        public static double delay3 = 0;
        public static double avg1 = 0;
        public static double avg2 = 0;
        public static double avg3 = 0;
        public static double rain = 0.18;
        public static double rain1 = 1;
        public static double rain2 = 1;
        public static double rain3 = 1;
        public static string flii1 = "";
        public result()
        {
            InitializeComponent();
            //this.TopMost = true;
           this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            label5.Text = main.fromm1;
            label10.Text = main.too1;
            label28.Text = main.fromm2;
            label43.Text = main.fromm3;
            label25.Text = main.too2;
            label40.Text = main.too3;
            
            //fli1=Convert.ToDouble(label47.Text)*0.20;
            //flii1 = Convert.ToString(fli1);
            //MessageBox.Show(flii1);
            delay1=Convert.ToDouble(main.fll1)*100;
            delay2=Convert.ToDouble(main.fll2)*100;
            delay3=Convert.ToDouble(main.fll3)*100;
            
            if (main.fromm2 == "bos")
            {
                panel2.Visible = false;
                panel3.Visible = false;
            }
            else if (main.fromm3 == "bos")
            {
                panel3.Visible=false;
            }

            //    Rain Situation

            if (main.rain1=="rain1")
            {
                rain1 = 0.18;
                delay1 = delay1 + delay1 * rain1;
            }
            if (main.rain2 == "rain2")
            {
                rain2 = 0.18;
                delay2 = delay2 + delay2 * rain2;
            }
            if(main.rain3 == "rain3")
            {
                rain3 = 0.18;
                delay3 = delay3 + delay3 * rain3;
            }

            //    Rain Situation

            label47.Text = Convert.ToString(delay1);
            label48.Text = Convert.ToString(delay2);
            label50.Text = Convert.ToString(delay3);


            try
            {


                conn.Open();
                OleDbCommand cmdd = new OleDbCommand();
                cmdd.Connection = conn;
                string query = "SELECT * FROM airport WHERE Airport_list ='" + main.fromm1 + "'";
                cmdd.CommandText = query;
                OleDbDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    label8.Text = reader["Average_delay"].ToString();
                    avg1=Convert.ToDouble(label8.Text);
                    
                    label9.Text = reader["Perday"].ToString();
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
                string query = "SELECT * FROM airport WHERE Airport_list ='" + main.fromm2 + "'";
                cmdd.CommandText = query;
                OleDbDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    label21.Text = reader["Average_delay"].ToString();
                    avg2 = Convert.ToDouble(label21.Text);
                    label20.Text = reader["Perday"].ToString();
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
                string query = "SELECT * FROM airport WHERE Airport_list ='" + main.fromm3 + "'";
                cmdd.CommandText = query;
                OleDbDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    label36.Text = reader["Average_delay"].ToString();
                    avg3 = Convert.ToDouble(label36.Text);
                    label35.Text = reader["Perday"].ToString();
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
                string query = "SELECT * FROM airport WHERE Airport_list ='" + main.too1 + "'";
                cmdd.CommandText = query;
                OleDbDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    label11.Text = reader["Average_delay"].ToString();
                    label12.Text = reader["Perday"].ToString();
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
                string query = "SELECT * FROM airport WHERE Airport_list ='" + main.too2 + "'";
                cmdd.CommandText = query;
                OleDbDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    label19.Text = reader["Average_delay"].ToString();
                    label18.Text = reader["Perday"].ToString();
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
                string query = "SELECT * FROM airport WHERE Airport_list ='" + main.too3 + "'";
                cmdd.CommandText = query;
                OleDbDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    label34.Text = reader["Average_delay"].ToString();
                    label33.Text = reader["Perday"].ToString();
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
        public static int fr1 = 0;
        public static int fr2 = 0;
        public static int fr3 = 0;
        public static int prob = fr1+fr2+fr3;

        private void button1_Click(object sender, EventArgs e)
        {




            if (main.fromm2 == "bos")
            {
                fr2 = 0;
                fr3 = 0;

            }
            
        }

        private void result_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void label47_Click(object sender, EventArgs e)
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            //Process process = new Process();
            // Configure the process using the StartInfo properties.
            //process.StartInfo.FileName = "matlab.exe";
            //process.StartInfo.Arguments = "-n";
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            //process.Start();
            //process.WaitForExit();// Waits here for the process to exit.;

            graph graph = new graph();
            graph.Show();
            this.Close();

        }
    }
}
