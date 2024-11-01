using System;
using System.Management;

namespace DeviceManagementSystem
{
    public class GraphicsCardInfo
    {
        public string Name { get; private set; } = "Informação não disponível";
        public long MemorySizeInGB { get; private set; } = -1;
        public string VideoProcessor { get; private set; } = "Informação não disponível";
        public string Manufacturer { get; private set; } = "Informação não disponível";
        public int BusWidth { get; private set; } = -1;
        public string MemoryType { get; private set; } = "Informação não disponível";

        public GraphicsCardInfo()
        {
            CollectGraphicsCardInfo();
        }

        private void CollectGraphicsCardInfo()
        {
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        if (obj["Name"] != null)
                            Name = obj["Name"].ToString();

                        if (obj["AdapterRAM"] != null)
                            MemorySizeInGB = Convert.ToInt64(obj["AdapterRAM"]) / (1024 * 1024 * 1024);

                        if (obj["VideoProcessor"] != null)
                            VideoProcessor = obj["VideoProcessor"].ToString();

                        if (obj["AdapterCompatibility"] != null)
                            Manufacturer = obj["AdapterCompatibility"].ToString();

                        if (obj["CurrentBitsPerPixel"] != null)
                            BusWidth = Convert.ToInt32(obj["CurrentBitsPerPixel"]);

                        if (obj["VideoMemoryType"] != null)
                        {
                            int memoryTypeCode = Convert.ToInt32(obj["VideoMemoryType"]);
                            MemoryType = GetMemoryTypeDescription(memoryTypeCode);
                        }
                    }
                }
            }
            catch (ManagementException ex)
            {
                Console.WriteLine($"Erro ao coletar informações da GPU: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        private string GetMemoryTypeDescription(int code)
        {
            return code switch
            {
                2 => "VRAM",
                3 => "DRAM",
                4 => "SRAM",
                5 => "WRAM",
                6 => "EDO RAM",
                7 => "Burst Synchronous DRAM",
                8 => "Pipelined Burst SRAM",
                9 => "CDRAM",
                10 => "3DRAM",
                11 => "SDRAM",
                12 => "SGRAM",
                _ => "Desconhecido"
            };
        }

        public override string ToString()
        {
            return $"Nome: {Name}\n" +
                   $"Memória da GPU: {(MemorySizeInGB >= 0 ? MemorySizeInGB.ToString() + " GB" : "Informação não disponível")}\n" +
                   $"Processador de Vídeo: {VideoProcessor}\n" +
                   $"Fabricante: {Manufacturer}\n" +
                   $"Bus Width: {(BusWidth >= 0 ? BusWidth.ToString() + " bits" : "Informação não disponível")}\n" +
                   $"Tipo de Memória: {MemoryType}";
        }
    }
}
