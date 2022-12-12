using System.Text;

namespace ITMO2022.CSharp.Forms.Lab04.Ex5.Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string RichTextBox1Data 
        {
            get
            { return richTextBox1.Text; }
            set
            { richTextBox1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(this);
        }
    }
}