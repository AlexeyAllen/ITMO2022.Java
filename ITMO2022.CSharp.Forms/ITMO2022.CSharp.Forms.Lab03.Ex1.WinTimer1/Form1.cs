namespace ITMO2022.CSharp.Forms.Lab03.Ex1.WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                userControlTimer1.TimeEnabled = true;
            }
            else
            {
                userControlTimer1.TimeEnabled = false;
            }
        }
    }
}