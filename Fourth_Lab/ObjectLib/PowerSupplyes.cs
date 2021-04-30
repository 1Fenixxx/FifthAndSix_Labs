
namespace ObjectLib
{
    public interface IPowerSupply
    {
        int Power { get; }
        string Manufacturer { get; }
        string EfficientStandard { get; }
        double Price { get; }
        double DollarPerWatt();
    }

    public class PowerSupply_Germany550 : IPowerSupply
    {
        public int Power { get; private set; }
        public string Manufacturer { get; private set; }
        public string EfficientStandard { get; private set; }
        public double Price { get; private set; }
        public PowerSupply_Germany550()
        {
            this.Power = 550;
            this.Manufacturer = "Germany";
            this.EfficientStandard = "80+ Bronze";
            this.Price = 80;
        }
        public double DollarPerWatt()
        {
            return Price / Power;
        }
        public override string ToString()
        {
            return "550W Germany PowerSupply";
        }
    }
    public class PowerSupply_Polish950 : IPowerSupply
    {
        public int Power { get; private set; }
        public string Manufacturer { get; private set; }
        public string EfficientStandard { get; private set; }
        public double Price { get; private set; }
        public PowerSupply_Polish950()
        {
            this.Power = 950;
            this.Manufacturer = "Poland";
            this.EfficientStandard = "80+ Platinum";
            this.Price = 180;
        }
        public double DollarPerWatt()
        {
            return Price / Power;
        }
        public override string ToString()
        {
            return "950W Polish PowerSupply";
        }
    }
}
