using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class QuadEqForm : Form
    {
        double disc, deno, x1, x2;

        public double RootX1 => x1;
        public double RootX2 => x2;

        public QuadEqForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(textBox1, "Must be digit");
                e.Handled = true;
                MessageBox.Show(this, "Must be digit");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                errorProvider2.SetError(textBox1, "Must be digit");
                e.Handled = true;
                MessageBox.Show(this, "Must be digit");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                errorProvider3.SetError(textBox1, "Must be digit");
                e.Handled = true;
                MessageBox.Show(this, "Must be digit");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                if (a == 0 && b != 0 && c != 0)
                {
                    x1 = -c / b;
                    x2 = 0;
                }
                else if (a != 0 && b == 0 && c != 0)
                {
                    x1 = -c / a;
                    x2 = 0;
                }

                else if ((a == 0 && b == 0 && c != 0) || (a == 0 && b == 0 && c == 0))
                {
                    MessageBox.Show(this, "Error, no roots");
                }
                else
                {
                    disc = (b * b) - (4 * a * c);
                    deno = 2 * a;
                    if (disc > 0)
                    {
                        x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                        x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    }
                    else if (disc == 0)
                    {
                        x1 = -b / deno;
                    }
                    else
                    {
                        x1 = -b / deno;
                        x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please enter all coefficients");
            }

            Close();
        }
       
    }
}
