using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ITMO2022.CSharp.Forms.Lab01.Exercise01.RectangularShape
{
    public partial class nForm : Form
    {
        private bool nclose = false;

        public new void Close() 
        {
            nclose = true; 
            base.Close(); 
        }

        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose) return;
            e.Cancel = true;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
