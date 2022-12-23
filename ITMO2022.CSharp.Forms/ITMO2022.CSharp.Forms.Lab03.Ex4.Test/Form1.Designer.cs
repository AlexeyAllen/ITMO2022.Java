namespace ITMO2022.CSharp.Forms.Lab03.Ex4.Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.userControlValidateForm1 = new ITMO2022.CSharp.Forms.Lab03.Ex4.Test.UserControlValidateForm();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = " Вывести e-mail и имя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 275);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 120);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // userControlValidateForm1
            // 
            this.userControlValidateForm1.Location = new System.Drawing.Point(12, 12);
            this.userControlValidateForm1.Name = "userControlValidateForm1";
            this.userControlValidateForm1.Size = new System.Drawing.Size(352, 173);
            this.userControlValidateForm1.TabIndex = 5;
            this.userControlValidateForm1.TextBox1 = "";
            this.userControlValidateForm1.TextBox2 = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 413);
            this.Controls.Add(this.userControlValidateForm1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Validate Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private UserControlValidateForm userControlValidateForm1;
    }
}