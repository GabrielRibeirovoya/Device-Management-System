using System;

namespace DeviceManagementSystem
{
    public class DiskInfo
    {
        public string Name { get; set; }
        public string DriveType { get; set; }
        public string DriveFormat { get; set; }
        public long TotalSizeGB { get; set; }
        public long AvailableFreeSpaceGB { get; set; }

        public DiskInfo(string name, string driveType, string driveFormat, long totalSizeGB, long availableFreeSpaceGB)
        {
            Name = name;
            DriveType = driveType;
            DriveFormat = driveFormat;
            TotalSizeGB = totalSizeGB;
            AvailableFreeSpaceGB = availableFreeSpaceGB;
        }

        public override string ToString()
        {
            return $"Disco: {Name} | Armazenamento total: {TotalSizeGB} GB | Armazenamento disponível: {AvailableFreeSpaceGB} GB";
        }
    }
}
