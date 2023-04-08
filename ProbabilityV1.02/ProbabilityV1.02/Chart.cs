using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace ProbabilityV1._02
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
       
        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            HttpWebRequest request = WebRequest.Create("https://flightaware.com/live/") as HttpWebRequest;
            
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string data = reader.ReadToEnd();
            reader.Close();
            int firstStringPosition = data.IndexOf("uçuşu olan");
            int secondStringPosition = data.IndexOf("uçak takip");
            string stringBetweenTwoStrings = data.Substring(firstStringPosition+10,
    secondStringPosition - firstStringPosition-10 );

            richTextBox1.Text = stringBetweenTwoStrings;





        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = WebRequest.Create("https://www.flightera.net/en/airline/Pegasus") as HttpWebRequest;
            request.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            request.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string data = reader.ReadToEnd();
            reader.Close();
            
            int firstStringPosition = data.IndexOf("PLANE INFORMATION");
            int secondStringPosition = data.IndexOf("currently flying");
            //string stringBetweenTwoStrings = data.Substring(firstStringPosition,
            //secondStringPosition);
            string stringBetweenTwoStrings = data.Substring(secondStringPosition - 100,
    secondStringPosition - firstStringPosition - 10);

            richTextBox2.Text = stringBetweenTwoStrings;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
