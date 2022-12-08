using System.Drawing.Drawing2D;

namespace ITMO2022.CSharp.Forms.Lab01.Exercise05.Test.GreenPeace
{
    public partial class Form1_ChildForm : Form
    {
        public Form1_ChildForm()
        {
            InitializeComponent();
        }

        private void Form1_ChildForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddPolygon(new Point[] 
            {
                new Point(this.Width/2, 0),
                new Point(0, this.Height/2),
                new Point(this.Width/2, this.Height),
                new Point(this.Width, this.Height/2)
            });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}