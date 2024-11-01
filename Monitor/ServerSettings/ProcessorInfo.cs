using System;
using System.Management;

namespace DeviceManagementSystem
{
    public class ProcessorInfo
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string SocketDesignation { get; private set; }
        public int MaxClockSpeed { get; private set; } 

        public ProcessorInfo()
        {
            CollectProcessorInfo();
        }

        private void CollectProcessorInfo()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["Name"] != null)
                        Name = obj["Name"].ToString();

                    if (obj["Description"] != null)
                        Description = obj["Description"].ToString();

                    if (obj["SocketDesignation"] != null)
                        SocketDesignation = obj["SocketDesignation"].ToString();

                    if (obj["MaxClockSpeed"] != null)
                        MaxClockSpeed = Convert.ToInt32(obj["MaxClockSpeed"]);

                }
            }
        }

        public override string ToString()
        {
            return $"Nome: {Name}\n" +
                   $"Especificação: {Description}\n" +
                   $"Pacote: {SocketDesignation}\n" +
                   $"Max TDP: {MaxClockSpeed} W";
        }
    }
}
