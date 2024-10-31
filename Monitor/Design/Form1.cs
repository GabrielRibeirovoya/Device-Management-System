using DeviceManagementSystem;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Monitor
{
    public partial class Form1 : Form
    {
        DiskInfo diskInfo;
        MemoryInfo memoryInfo;
        public Form1()
        {
            InitializeComponent();
            hostname.Text = Environment.MachineName + " |";
            hostname.ForeColor = Color.Gray;
            Operating_system.Text = Environment.OSVersion.ToString() + " |";
            Operating_system.ForeColor = Color.Gray;
            MemoryInfo memoryInfo = MemoryInfo.GetMemoryInfo();

            // Atribui os valores aos TextBox
            type.Text = memoryInfo.MemoryType ?? "Indispon�vel";
            syze.Text = memoryInfo.TotalMemoryGB > 0 ? $"{memoryInfo.TotalMemoryGB} GB" : "Indispon�vel";
            channel.Text = memoryInfo.SlotCount > 0 ? memoryInfo.SlotCount.ToString() : "Indispon�vel";
            Uncore.Text = memoryInfo.SpeedMHz > 0 ? $"{memoryInfo.SpeedMHz} MHz" : "Indispon�vel";

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


