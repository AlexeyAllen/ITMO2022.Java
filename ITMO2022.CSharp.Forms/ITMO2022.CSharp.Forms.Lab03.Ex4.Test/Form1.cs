using System.Runtime.CompilerServices;
using System.Text;

namespace ITMO2022.CSharp.Forms.Lab03.Ex4.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = userControlValidateForm1.TextBox1 + " " + userControlValidateForm1.TextBox2;
        }
    }
}