namespace WinForms_DateTimePicker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();//net6.0���-�v�TdateTimePicker1.CalendarFont�ݩ�
            
            //net6.0���eApplicationConfiguration.Initialize()���{���X���H�U�T��
            //Application.EnableVisualStyles();//net6.0���e-�v�TdateTimePicker1.CalendarFont�ݩ�
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.Run(new Form1());
        }
    }
}