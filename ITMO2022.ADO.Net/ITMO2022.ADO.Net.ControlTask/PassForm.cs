using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITMO2022.ADO.Net.ControlTask
{
    public partial class PassForm : Form
    {
        public PassForm()
        {
            InitializeComponent();
        }

        public string Login
        {
            get { return loginTextBox.Text; }
            set { loginTextBox.Text = value; }
        }

        public string Password
        {
            get { return passTextBox.Text; }
            set { passTextBox.Text = value; }
        }
    }
}
