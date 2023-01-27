namespace ITMO2022.ADO.Net.ControlTask
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьСоединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьСоединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table1DataGridView = new System.Windows.Forms.DataGridView();
            this.table2DataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.presentTable1Button = new System.Windows.Forms.Button();
            this.presentTable2Button = new System.Windows.Forms.Button();
            this.updateButton1 = new System.Windows.Forms.Button();
            this.updateButton2 = new System.Windows.Forms.Button();
            this.addRowInTable1Button = new System.Windows.Forms.Button();
            this.deleteRowInTable1Button = new System.Windows.Forms.Button();
            this.addRowInTable2Button = new System.Windows.Forms.Button();
            this.deleteRowInTable2Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // подключениеКБДToolStripMenuItem
            // 
            this.подключениеКБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьСоединениеToolStripMenuItem,
            this.отключитьСоединениеToolStripMenuItem});
            this.подключениеКБДToolStripMenuItem.Name = "подключениеКБДToolStripMenuItem";
            this.подключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.подключениеКБДToolStripMenuItem.Text = "1 Подключение к БД";
            // 
            // создатьСоединениеToolStripMenuItem
            // 
            this.создатьСоединениеToolStripMenuItem.Name = "создатьСоединениеToolStripMenuItem";
            this.создатьСоединениеToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.создатьСоединениеToolStripMenuItem.Text = "Создать соединение";
            this.создатьСоединениеToolStripMenuItem.Click += new System.EventHandler(this.создатьСоединениеToolStripMenuItem_Click);
            // 
            // отключитьСоединениеToolStripMenuItem
            // 
            this.отключитьСоединениеToolStripMenuItem.Name = "отключитьСоединениеToolStripMenuItem";
            this.отключитьСоединениеToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.отключитьСоединениеToolStripMenuItem.Text = "Отключить соединение";
            this.отключитьСоединениеToolStripMenuItem.Click += new System.EventHandler(this.отключитьСоединениеToolStripMenuItem_Click);
            // 
            // table1DataGridView
            // 
            this.table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1DataGridView.Location = new System.Drawing.Point(12, 31);
            this.table1DataGridView.Name = "table1DataGridView";
            this.table1DataGridView.RowHeadersWidth = 51;
            this.table1DataGridView.RowTemplate.Height = 24;
            this.table1DataGridView.Size = new System.Drawing.Size(606, 378);
            this.table1DataGridView.TabIndex = 1;
            // 
            // table2DataGridView
            // 
            this.table2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2DataGridView.Location = new System.Drawing.Point(625, 32);
            this.table2DataGridView.Name = "table2DataGridView";
            this.table2DataGridView.RowHeadersWidth = 51;
            this.table2DataGridView.RowTemplate.Height = 24;
            this.table2DataGridView.Size = new System.Drawing.Size(609, 378);
            this.table2DataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "3 Изменение данных в таблицах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "4 Добавление новых и/или удаление данных в таблицы БД";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "2 Вывод на экран содержимого одной или нескольких таблиц БД:";
            // 
            // presentTable1Button
            // 
            this.presentTable1Button.Location = new System.Drawing.Point(12, 477);
            this.presentTable1Button.Name = "presentTable1Button";
            this.presentTable1Button.Size = new System.Drawing.Size(311, 23);
            this.presentTable1Button.TabIndex = 11;
            this.presentTable1Button.Text = "Вывод на экран таблицы 1";
            this.presentTable1Button.UseVisualStyleBackColor = true;
            this.presentTable1Button.Click += new System.EventHandler(this.presentTable1Button_Click);
            // 
            // presentTable2Button
            // 
            this.presentTable2Button.Location = new System.Drawing.Point(625, 477);
            this.presentTable2Button.Name = "presentTable2Button";
            this.presentTable2Button.Size = new System.Drawing.Size(311, 23);
            this.presentTable2Button.TabIndex = 13;
            this.presentTable2Button.Text = "Вывод на экран таблицы 2";
            this.presentTable2Button.UseVisualStyleBackColor = true;
            this.presentTable2Button.Click += new System.EventHandler(this.presentTable2Button_Click);
            // 
            // updateButton1
            // 
            this.updateButton1.Location = new System.Drawing.Point(12, 556);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(311, 23);
            this.updateButton1.TabIndex = 14;
            this.updateButton1.Text = "Сохранить изменения данных в таблице 1";
            this.updateButton1.UseVisualStyleBackColor = true;
            this.updateButton1.Click += new System.EventHandler(this.updateButton1_Click);
            // 
            // updateButton2
            // 
            this.updateButton2.Location = new System.Drawing.Point(625, 556);
            this.updateButton2.Name = "updateButton2";
            this.updateButton2.Size = new System.Drawing.Size(311, 23);
            this.updateButton2.TabIndex = 15;
            this.updateButton2.Text = "Сохранить изменения данных в таблице 2";
            this.updateButton2.UseVisualStyleBackColor = true;
            this.updateButton2.Click += new System.EventHandler(this.updateButton2_Click);
            // 
            // addRowInTable1Button
            // 
            this.addRowInTable1Button.Location = new System.Drawing.Point(15, 654);
            this.addRowInTable1Button.Name = "addRowInTable1Button";
            this.addRowInTable1Button.Size = new System.Drawing.Size(311, 23);
            this.addRowInTable1Button.TabIndex = 16;
            this.addRowInTable1Button.Text = "Добавить ряд в таблицу 1";
            this.addRowInTable1Button.UseVisualStyleBackColor = true;
            this.addRowInTable1Button.Click += new System.EventHandler(this.addRowInTable1Button_Click);
            // 
            // deleteRowInTable1Button
            // 
            this.deleteRowInTable1Button.Location = new System.Drawing.Point(15, 697);
            this.deleteRowInTable1Button.Name = "deleteRowInTable1Button";
            this.deleteRowInTable1Button.Size = new System.Drawing.Size(311, 23);
            this.deleteRowInTable1Button.TabIndex = 17;
            this.deleteRowInTable1Button.Text = "Удалить ряд в таблице 1";
            this.deleteRowInTable1Button.UseVisualStyleBackColor = true;
            this.deleteRowInTable1Button.Click += new System.EventHandler(this.deleteRowInTable1Button_Click);
            // 
            // addRowInTable2Button
            // 
            this.addRowInTable2Button.Location = new System.Drawing.Point(625, 654);
            this.addRowInTable2Button.Name = "addRowInTable2Button";
            this.addRowInTable2Button.Size = new System.Drawing.Size(311, 23);
            this.addRowInTable2Button.TabIndex = 18;
            this.addRowInTable2Button.Text = "Добавить ряд в таблицу 2";
            this.addRowInTable2Button.UseVisualStyleBackColor = true;
            this.addRowInTable2Button.Click += new System.EventHandler(this.addRowInTable2Button_Click);
            // 
            // deleteRowInTable2Button
            // 
            this.deleteRowInTable2Button.Location = new System.Drawing.Point(625, 697);
            this.deleteRowInTable2Button.Name = "deleteRowInTable2Button";
            this.deleteRowInTable2Button.Size = new System.Drawing.Size(311, 23);
            this.deleteRowInTable2Button.TabIndex = 19;
            this.deleteRowInTable2Button.Text = "Удалить ряд в таблице 2";
            this.deleteRowInTable2Button.UseVisualStyleBackColor = true;
            this.deleteRowInTable2Button.Click += new System.EventHandler(this.deleteRowInTable2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 772);
            this.Controls.Add(this.deleteRowInTable2Button);
            this.Controls.Add(this.addRowInTable2Button);
            this.Controls.Add(this.deleteRowInTable1Button);
            this.Controls.Add(this.addRowInTable1Button);
            this.Controls.Add(this.updateButton2);
            this.Controls.Add(this.updateButton1);
            this.Controls.Add(this.presentTable2Button);
            this.Controls.Add(this.presentTable1Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table2DataGridView);
            this.Controls.Add(this.table1DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьСоединениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитьСоединениеToolStripMenuItem;
        private System.Windows.Forms.DataGridView table1DataGridView;
        private System.Windows.Forms.DataGridView table2DataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button presentTable1Button;
        private System.Windows.Forms.Button presentTable2Button;
        private System.Windows.Forms.Button updateButton1;
        private System.Windows.Forms.Button updateButton2;
        private System.Windows.Forms.Button addRowInTable1Button;
        private System.Windows.Forms.Button deleteRowInTable1Button;
        private System.Windows.Forms.Button addRowInTable2Button;
        private System.Windows.Forms.Button deleteRowInTable2Button;
    }
}

