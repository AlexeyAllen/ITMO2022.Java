using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2022.CSharp.Forms.Lab04.Ex5.Function
{
    public partial class Form2 : Form

    {
        public static double a, b;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);

                double step = 0.1;
                StringBuilder sb = new StringBuilder();
                Form1 frm1 = this.Owner as Form1;

                for (double x = a; x < b; x += step)
                {
                    string str = x.ToString("0.0") + " : " + Math.Sin(x).ToString("0.00") + Environment.NewLine;
                    sb.Append(str);
                }

                frm1.RichTextBox1Data = sb.ToString();

            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + er.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
