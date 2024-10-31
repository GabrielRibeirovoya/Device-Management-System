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
            dataGridView1 = new DataGridView();
            Disco = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Disponivel = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabPage1 = new TabPage();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox2.Location = new Point(8, 190);
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
            Uncore.Location = new Point(334, 49);
            Uncore.Name = "Uncore";
            Uncore.Size = new Size(153, 23);
            Uncore.TabIndex = 6;
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
            channel.Location = new Point(334, 20);
            channel.Name = "channel";
            channel.Size = new Size(153, 23);
            channel.TabIndex = 4;
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
            syze.Location = new Point(43, 51);
            syze.Name = "syze";
            syze.Size = new Size(176, 23);
            syze.TabIndex = 2;
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
            type.Location = new Point(43, 22);
            type.Name = "type";
            type.Size = new Size(176, 23);
            type.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(8, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 159);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Processor";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Disco, Total, Disponivel });
            dataGridView1.GridColor = SystemColors.ScrollBar;
            dataGridView1.Location = new Point(517, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(267, 324);
            dataGridView1.TabIndex = 2;
            // 
            // Disco
            // 
            Disco.HeaderText = "Disco";
            Disco.Name = "Disco";
            Disco.Width = 88;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 88;
            // 
            // Disponivel
            // 
            Disponivel.HeaderText = "Disponivel";
            Disponivel.Name = "Disponivel";
            Disponivel.Width = 88;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(517, 7);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Armazenamento";
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private DataGridViewTextBoxColumn Disco;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Disponivel;
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
    }
}
