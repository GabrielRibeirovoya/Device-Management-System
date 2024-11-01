using System.Management;

public class MemoryInfo
{
    public string MemoryType { get; set; }
    public long TotalMemoryGB { get; set; }
    public int SlotCount { get; set; }
    public int SpeedMHz { get; set; }

    public static MemoryInfo GetMemoryInfo()
    {
        MemoryInfo memoryInfo = new MemoryInfo();
        long totalMemoryBytes = 0;
        int slotCount = 0;

        using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory"))
        {
            foreach (ManagementObject obj in searcher.Get())
            {
                if (obj["Capacity"] != null)
                    totalMemoryBytes += Convert.ToInt64(obj["Capacity"]);

                int memoryTypeCode = obj["SMBIOSMemoryType"] != null 
                        ? Convert.ToInt32(obj["SMBIOSMemoryType"]) 
                        : obj["MemoryType"] != null 
                            ? Convert.ToInt32(obj["MemoryType"]) 
                            : 0;
                    memoryInfo.MemoryType = GetMemoryType(memoryTypeCode);

                if (obj["Speed"] != null)
                    memoryInfo.SpeedMHz = Convert.ToInt32(obj["Speed"]);

                slotCount++;
            }
        }

        memoryInfo.TotalMemoryGB = totalMemoryBytes / (1024 * 1024 * 1024);
        memoryInfo.SlotCount = slotCount;

        return memoryInfo;
    }

    private static string GetMemoryType(int code)
    {
        return code switch
        {
            20 => "DDR",
            21 => "DDR2",
            24 => "DDR3",
            26 => "DDR4",
            30 => "DDR5",
            _ => "Desconhecido"
        };
    }

}