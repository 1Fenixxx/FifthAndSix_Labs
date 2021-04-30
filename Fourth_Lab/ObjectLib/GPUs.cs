
namespace ObjectLib
{
    public interface IGPU
    {
        double Price { get; }
        string Manufacturer { get; }
        int TechProcess_nm { get; }
        double CountOfTransistors_mln { get; }
        int ShaderBlocksCount { get; }
        int MemorySize { get; }
        double Power { get; }
    }

    public class GTX1050 : IGPU
    {
        public double Price { get; private set; }
        public string Manufacturer { get; private set; }
        public int TechProcess_nm { get; private set; }
        public double CountOfTransistors_mln { get; private set; }
        public int ShaderBlocksCount { get; private set; }
        public int MemorySize { get; private set; }
        public double Power { get; private set; }

        public GTX1050()
        {
            this.Price = 100;
            this.Manufacturer = "NVIDIA";
            this.TechProcess_nm = 14;
            this.CountOfTransistors_mln = 3300;
            this.ShaderBlocksCount = 640;
            this.MemorySize = 2048;
            this.Power = 75;
        }
        public override string ToString()
        {
            return "NVIDIA GeForce GTX 1050";
        }
    }
    public class GTX1660 : IGPU
    {
        public double Price { get; private set; }
        public string Manufacturer { get; private set; }
        public int TechProcess_nm { get; private set; }
        public double CountOfTransistors_mln { get; private set; }
        public int ShaderBlocksCount { get; private set; }
        public int MemorySize { get; private set; }
        public double Power { get; private set; }

        public GTX1660()
        {
            this.Price = 670;
            this.Manufacturer = "NVIDIA";
            this.TechProcess_nm = 12;
            this.CountOfTransistors_mln = 6600;
            this.ShaderBlocksCount = 1408;
            this.MemorySize = 6144;
            this.Power = 120;
        }
        public override string ToString()
        {
            return "NVIDIA GeForce GTX 1660";
        }
    }
}
