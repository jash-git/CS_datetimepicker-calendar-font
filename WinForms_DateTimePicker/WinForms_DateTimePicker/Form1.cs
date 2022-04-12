namespace WinForms_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Font = new Font("Courier New", 18.0F, FontStyle.Italic, GraphicsUnit.Point, ((Byte)(0)));
            dateTimePicker1.CalendarFont = new Font("Courier New", 36F, FontStyle.Italic, GraphicsUnit.Point, ((Byte)(0)));
        }
    }
}