namespace GroupProject_106
{
    internal static class Program
    {
        public static double F(double x)
        {
            return x * x;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Producer p1 = new Producer(0, 1, 0.001);
            Consumer c = new Consumer();
            c.Start(0.001);
            p1.Start();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}