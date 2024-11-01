using DeviceManagementSystem;
using System;
using System.Data.Common;
using System.IO.Packaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Monitor
{
    public partial class Form1 : Form
    {
        DiskInfo diskInfo;
        MemoryInfo memoryInfo;
        ProcessorInfo processorInfo = new ProcessorInfo();
        GraphicsCardInfo gpuInfo = new GraphicsCardInfo();

        public Form1()
        {
            InitializeComponent();
            hostname.Text = Environment.MachineName + " |";
            hostname.ForeColor = Color.Gray;
            Operating_system.Text = Environment.OSVersion.ToString() + " |";
            Operating_system.ForeColor = Color.Gray;
            MemoryInfo memoryInfo = MemoryInfo.GetMemoryInfo();
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Exemplo: Definindo a cor de fundo da terceira linha para azul claro
            dataGridView1.DefaultCellStyle.ForeColor = Color.MediumSlateBlue; // Cor do texto


            // Atribui os valores aos TextBox
            type.Text = memoryInfo.MemoryType ?? "Indisponível";
            syze.Text = memoryInfo.TotalMemoryGB > 0 ? $"{memoryInfo.TotalMemoryGB} GB" : "Indisponível";
            channel.Text = memoryInfo.SlotCount > 0 ? memoryInfo.SlotCount.ToString() : "Indisponível";
            Uncore.Text = memoryInfo.SpeedMHz > 0 ? $"{memoryInfo.SpeedMHz} MHz" : "Indisponível";

            textBox4.Text = processorInfo.Name;
            textBox1.Text = processorInfo.Description;
            textBox2.Text = processorInfo.SocketDesignation;
            textBox3.Text = (processorInfo.MaxClockSpeed).ToString();

            textBox8.Text = gpuInfo.Name;
            textBox5.Text = (gpuInfo.MemorySizeInGB + " GBytes").ToString();
            textBox6.Text = gpuInfo.MemoryType;
            textBox7.Text = (gpuInfo.Manufacturer).ToString();
            textBox9.Text = (gpuInfo.BusWidth + " Bytes").ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<DiskInfo> disks = GetDiskInfo();
            foreach (DiskInfo disk in disks)
            {
                dataGridView1.Rows.Add(disk.Name, disk.TotalSizeGB, disk.AvailableFreeSpaceGB);
            }
        }

        private List<DiskInfo> GetDiskInfo()
        {
            List<DiskInfo> diskInfos = new List<DiskInfo>();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    long totalSizeGB = drive.TotalSize / (1024 * 1024 * 1024);
                    long availableFreeSpaceGB = drive.AvailableFreeSpace / (1024 * 1024 * 1024);

                    DiskInfo diskInfo = new DiskInfo(
                        drive.Name,
                        drive.DriveType.ToString(),
                        drive.DriveFormat,
                        totalSizeGB,
                        availableFreeSpaceGB
                    );

                    diskInfos.Add(diskInfo);
                }
            }

            return diskInfos;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}


