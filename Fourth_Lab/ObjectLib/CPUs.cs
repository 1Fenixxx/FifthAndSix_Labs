
namespace ObjectLib
{
    public enum Sockets
    {
        LGA771, LGA775, LGA1567, LGA1366, 
        LGA1156, LGA1155, LGA2011, LGA1356, 
        LGA1150, LGA2011_3, LGA1151, LGA2066, 
        LGA1200, LGA1700,

        AM2, AM2p, AM3, AM3p, FM1, FM2, FM2p, AM1, AM4, TR4, TRX4
    }
    public interface ICPU
    {
        string Manufacturer { get; }
        int Cores { get; }
        int Threads { get; }
        int TechProcess_nm { get; }
        Sockets Socket { get; }
        string Name { get; }
        double Price { get; }
    }

    public class IntelCore_I3_6100 : ICPU
    {
        public string Manufacturer { get; private set; }
        public int Cores { get; private set; }
        public int Threads { get; private set; }
        public int TechProcess_nm { get; private set; }
        public Sockets Socket { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public IntelCore_I3_6100()
        {
            this.Manufacturer = "Intel";
            this.Cores = 2;
            this.Threads = 4;
            this.TechProcess_nm = 14;
            this.Socket = Sockets.LGA1151;
            this.Name = "Intel Core I3 6100";
            this.Price = 84.99;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
    public class IntelCore_I5_9300H : ICPU
    {
        public string Manufacturer { get; private set; }
        public int Cores { get; private set; }
        public int Threads { get; private set; }
        public int TechProcess_nm { get; private set; }
        public Sockets Socket { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public IntelCore_I5_9300H()
        {
            this.Manufacturer = "Intel";
            this.Cores = 4;
            this.Threads = 8;
            this.TechProcess_nm = 14;
            this.Socket = Sockets.LGA1151;
            this.Name = "Intel Core I5 9300H";
            this.Price = 249.99;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
    public class Ryzen5_5600X : ICPU
    {
        public string Manufacturer { get; private set; }
        public int Cores { get; private set; }
        public int Threads { get; private set; }
        public int TechProcess_nm { get; private set; }
        public Sockets Socket { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public Ryzen5_5600X()
        {
            this.Manufacturer = "AMD";
            this.Cores = 6;
            this.Threads = 12;
            this.TechProcess_nm = 7;
            this.Socket = Sockets.AM4;
            this.Name = "AMD Ryzen 5 5600X";
            this.Price = 344.95;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
