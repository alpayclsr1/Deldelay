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
    public partial class graph : Form
    {

        public static double delayy1 = 1;
        public static double ddelayy1 = 1;
        public static double delayy2 = 1;
        public static double ddelayy2 = 1;
        public static double delayy3 = 1;
        public static double ddelayy3 = 1;
        public static double delayy4 = 1;
        public static double ddelayy4 = 1;
        public static double delayy5 = 1;
        public static double avgg1 = 1;
        public static double avgg2 = 1;
        public static double avgg3 = 1;
        public graph()
        {
            InitializeComponent();

            delayy1 = 1-Convert.ToDouble(result.delay1)/100 ;
            ddelayy1 = 1-Convert.ToDouble(result.delay1)/100 ;

            delayy2 = 1-Convert.ToDouble(result.delay2)/100 ;
            ddelayy2 = 1-Convert.ToDouble(result.delay2)/100 ;
            delayy3 = 1-Convert.ToDouble(result.delay3)/100 ;
            ddelayy3 = 1-Convert.ToDouble(result.delay3)/100 ;
            delayy4 = 1-(delayy1*delayy2*delayy3) ;
            delayy5 = 1-delayy4;


            label4.Text = delayy1.
                ToString();

            label7.Text=delayy2.ToString();
            label8.Text=delayy3.ToString(); 
            label16.Text=delayy4.ToString(); 
            
            label21.Text=delayy5.ToString();
            label29.Text=delayy4.ToString();    

            label60.Text = Convert.ToString(result.avg1);
            label57.Text = Convert.ToString(result.avg2);
            label56.Text = Convert.ToString(result.avg3);
            label48.Text = Convert.ToString((result.avg1) + (result.avg2) + (result.avg3));
            

            if (result.avg1 < 40)
            {
                ddelayy1 = 1;
                
            }
            if (result.avg2 < 40)
            {
                ddelayy2=1;
            }
            if (result.avg3 < 40)
            {
                ddelayy3 = 1;
            }

            ddelayy4 = ddelayy1 * ddelayy2 * ddelayy3 * ddelayy4;

            label42.Text = ddelayy1.ToString();
            label39.Text = ddelayy2.ToString();
            label38.Text = ddelayy3.ToString();

            label26.Text = ddelayy4.ToString();




        }

        private void graph_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }
    }
}
