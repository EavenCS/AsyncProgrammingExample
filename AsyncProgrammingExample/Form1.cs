using System.Diagnostics;
using System.Net;
using System.Text;

namespace AsyncProgrammingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// synchron benchmark method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void synchron_Bt_Click(object sender, EventArgs e)
        {
            Logger_Rtb.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int repeat = int.Parse(Repeat_Tb.Text);
            for (int i = 0; i < repeat; i++)
            {
                Download();
            }
            Done(sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Logger_Rtb_TextChanged method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logger_Rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Done(long time)
        {
            Logger_Rtb.Text += "Download complete. Entire time " + time + "ms";
        }

        /// <summary>
        /// Download a Image
        /// </summary>
        private void Download()
        {
            string img = "https://cdn.pixabay.com/photo/2021/04/23/19/57/yorkshire-terrier-6202621_960_720.jpg";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(img);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            response.Close();
            readStream.Close();
        }

        /// <summary>
        /// Async method benchmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Async_Bt_Click(object sender, EventArgs e)
        {
            Logger_Rtb.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int repeat = int.Parse(Repeat_Tb.Text);
            for (int i = 0; i < repeat; i++)
            {
               await Task.Run(() =>Download());
            }
            Done(sw.ElapsedMilliseconds);
        }
    }
}