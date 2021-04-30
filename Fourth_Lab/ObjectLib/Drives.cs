
namespace ObjectLib
{
    public enum ConnectionInterface
    {
        Sata_1, Sata_2, Sata_3, M2, NVME, PCIe_2, PCIe_3
    }
    public interface I_SSD_HDD
    {
        double GBSize { get; }
        string Manufacturer { get; }
        ConnectionInterface Interface { get; }
        double Price { get; }
    }
    public class WD_Blue : I_SSD_HDD
    {
        public double GBSize { get; private set; }
        public string Manufacturer { get; private set; }
        public ConnectionInterface Interface { get; private set; }
        public double Price { get; private set; }

        public WD_Blue()
        {
            this.GBSize = 1024;
            this.Manufacturer = "Western Digital";
            this.Interface = ConnectionInterface.Sata_3;
        }
        public override string ToString()
        {
            return "WD_Blue";
        }
    }
    public class Samsung_EVO970 : I_SSD_HDD
    {
        public double GBSize { get; private set; }
        public string Manufacturer { get; private set; }
        public ConnectionInterface Interface { get; private set; }
        public double Price { get; private set; }

        public Samsung_EVO970()
        {
            this.GBSize = 512;
            this.Manufacturer = "Samsung";
            this.Interface = ConnectionInterface.PCIe_3;
        }
        public override string ToString()
        {
            return "Samsung EVO970";
        }
    }
}
