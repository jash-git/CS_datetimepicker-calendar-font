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

            //ApplicationConfiguration.Initialize();//net6.0原生-影響dateTimePicker1.CalendarFont屬性
            
            //net6.0之前ApplicationConfiguration.Initialize()的程式碼為以下三行
            //Application.EnableVisualStyles();//net6.0之前-影響dateTimePicker1.CalendarFont屬性
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.Run(new Form1());
        }
    }
}