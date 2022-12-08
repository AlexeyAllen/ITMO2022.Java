using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO2022.CSharp.Forms.Lab01.Exercise05.Test.GreenPeace
{
    public partial class Form2_ParentForm : Form
    {
        public Form2_ParentForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            Form1_ChildForm newChild = new Form1_ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
        }
    }
}
