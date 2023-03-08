using System.Diagnostics;

namespace GroupProject_106
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        public static double F(double x)
        {
            return x * x;
        }

        private void ShowResult()
        {
            if (InvokeRequired)
                Invoke(ShowResult);
            else
            {
                stopwatch.Stop();
                label1.Visible = true;
                label1.Text = "Integral: " + Consumer.Integral.ToString();
                label2.Visible = true;
                label2.Text = "Time: " + stopwatch.ElapsedMilliseconds.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producer p1 = new Producer(0, 300000, 0.001);
            Consumer c = new Consumer();
            p1.Finish += ShowResult;
            stopwatch.Reset();
            stopwatch.Start();
            c.Start(0.001);
            p1.Start();
        }
    }
}