using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilityV1._02
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            information inf = new information();
            inf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            References reff= new References();
            reff.Show();
            this.Hide();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
            this.Hide();

        }
    }
}
