namespace Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            hostname = new ToolStripStatusLabel();
            Operating_system = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            label14 = new Label();
            textBox9 = new TextBox();
            label12 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox8 = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            Uncore = new TextBox();
            label5 = new Label();
            channel = new TextBox();
            label3 = new Label();
            syze = new TextBox();
            label2 = new Label();
            type = new TextBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            Disc = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Available = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabPage1 = new TabPage();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { hostname, Operating_system });
            statusStrip1.Location = new Point(0, 387);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // hostname
            // 
            hostname.Name = "hostname";
            hostname.Size = new Size(0, 17);
            // 
            // Operating_system
            // 
            Operating_system.Name = "Operating_system";
            Operating_system.Size = new Size(0, 17);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 436);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 408);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CPU";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Location = new Point(8, 169);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(503, 88);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Processor";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(365, 54);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 17;
            label14.Text = "BusWidth";
            // 
            // textBox9
            // 
            textBox9.ForeColor = Color.MediumSlateBlue;
            textBox9.Location = new Point(426, 51);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(61, 23);
            textBox9.TabIndex = 16;
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(229, 54);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 15;
            label12.Text = "Vendor";
            // 
            // textBox7
            // 
            textBox7.ForeColor = Color.MediumSlateBlue;
            textBox7.Location = new Point(279, 51);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(80, 23);
            textBox7.TabIndex = 14;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(125, 54);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 13;
            label11.Text = "Type";
            // 
            // textBox6
            // 
            textBox6.ForeColor = Color.MediumSlateBlue;
            textBox6.Location = new Point(162, 51);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(61, 23);
            textBox6.TabIndex = 12;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 55);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 11;
            label10.Text = "Memory";
            // 
            // textBox5
            // 
            textBox5.ForeColor = Color.MediumSlateBlue;
            textBox5.Location = new Point(58, 51);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(61, 23);
            textBox5.TabIndex = 10;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 25);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 9;
            label13.Text = "Name";
            // 
            // textBox8
            // 
            textBox8.ForeColor = Color.MediumSlateBlue;
            textBox8.Location = new Point(58, 22);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(429, 23);
            textBox8.TabIndex = 8;
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Uncore);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(channel);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(syze);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(type);
            groupBox2.Location = new Point(8, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 86);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Memory";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 54);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "Uncore Frequency";
            // 
            // Uncore
            // 
            Uncore.ForeColor = Color.MediumSlateBlue;
            Uncore.Location = new Point(334, 49);
            Uncore.Name = "Uncore";
            Uncore.Size = new Size(153, 23);
            Uncore.TabIndex = 6;
            Uncore.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 25);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 5;
            label5.Text = "Channel";
            // 
            // channel
            // 
            channel.ForeColor = Color.MediumSlateBlue;
            channel.Location = new Point(334, 20);
            channel.Name = "channel";
            channel.Size = new Size(153, 23);
            channel.TabIndex = 4;
            channel.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 54);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Syze";
            // 
            // syze
            // 
            syze.ForeColor = Color.MediumSlateBlue;
            syze.Location = new Point(43, 51);
            syze.Name = "syze";
            syze.Size = new Size(176, 23);
            syze.TabIndex = 2;
            syze.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // type
            // 
            type.ForeColor = Color.MediumSlateBlue;
            type.Location = new Point(43, 22);
            type.Name = "type";
            type.Size = new Size(176, 23);
            type.TabIndex = 0;
            type.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(8, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 145);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Processor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 54);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 15;
            label8.Text = "Specification";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.MediumSlateBlue;
            textBox3.Location = new Point(94, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(393, 23);
            textBox3.TabIndex = 14;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 83);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "Packege";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.MediumSlateBlue;
            textBox2.Location = new Point(94, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(393, 23);
            textBox2.TabIndex = 12;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 112);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 11;
            label6.Text = "Max TDP";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.MediumSlateBlue;
            textBox1.Location = new Point(94, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 23);
            textBox1.TabIndex = 10;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 25);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 9;
            label9.Text = "Name";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.MediumSlateBlue;
            textBox4.Location = new Point(94, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(393, 23);
            textBox4.TabIndex = 8;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Disc, Total, Available });
            dataGridView1.GridColor = SystemColors.ScrollBar;
            dataGridView1.Location = new Point(517, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(267, 324);
            dataGridView1.TabIndex = 2;
            // 
            // Disc
            // 
            Disc.HeaderText = "Disk";
            Disc.Name = "Disc";
            Disc.Width = 88;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 88;
            // 
            // Available
            // 
            Available.HeaderText = "Available";
            Available.Name = "Available";
            Available.Width = 88;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(517, 7);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Storage";
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Device Management System";
            Load += Form1_Load_1;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel hostname;
        private ToolStripStatusLabel Operating_system;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox syze;
        private Label label2;
        private TextBox type;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox Uncore;
        private Label label5;
        private TextBox channel;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private Label label13;
        private TextBox textBox8;
        private DataGridViewTextBoxColumn Disc;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Available;
        private Label label10;
        private TextBox textBox5;
        private Label label14;
        private TextBox textBox9;
        private Label label12;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox6;
    }
}
