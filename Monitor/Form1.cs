using System;

namespace Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hostname.Text = Environment.MachineName + " |";
            hostname.ForeColor = Color.Gray;
            Operating_system.Text = Environment.OSVersion.ToString() + " |";
            Operating_system.ForeColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
