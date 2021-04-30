namespace ObjectLib
{
    public class Computer
    {
        public struct DeviceDesc
        {
            public IPowerSupply PS;  //PowerSupply
            public I_SSD_HDD[] Drives; //Physical drives in computer
            public IMotherboard Motherboard; //Motherboard with current CPU & GPU
            public double TotalPrice;
        }
        private DeviceDesc Description;
        public Computer()
        {
            this.Description = new DeviceDesc()
            {
                PS = new PowerSupply_Germany550(),
                Drives = new I_SSD_HDD[] { new WD_Blue() },
                Motherboard = new Lenovo_Unknown(null, null),
            };
            this.Description.TotalPrice = totalPrice();
        }
        public Computer(DeviceDesc Desc)
        {
            this.Description = Desc;
            this.Description.TotalPrice = totalPrice();
        }
        public override string ToString()
        {
            string output = string.Empty;

            output += GetTotalPriceString();
            output += GetMotherboardTypeString();
            output += GetCPUTypeString();
            output += GetGPUTypeString();
            output += GetDrivesTypeString();
            output += GetPowerSupplyTypeString();

            return output;
        }
        public string[] GetDataForDataGridView()
        {
            string[] output = new string[6];

            output[0] = GetTotalPriceString();
            output[1] = GetMotherboardTypeString();
            output[2] = GetCPUTypeString();
            output[3] = GetGPUTypeString();
            output[4] = GetDrivesTypeString();
            output[5] = GetPowerSupplyTypeString();

            return output;
        }
        public DeviceDesc GetDesc()
        { return this.Description;}
        public string GetTotalPriceString()
        { return "Price: " + this.Description.TotalPrice + "\r\n";}
        public string GetMotherboardTypeString() 
        { return "MotherBoard: " + this.Description.Motherboard.GetType().Name + "\r\n";}
        public string GetCPUTypeString()
        { return "CPU: " + this.Description.Motherboard.CPU.GetType().Name + "\r\n";}
        public string GetGPUTypeString()
        { return "GPU: " + this.Description.Motherboard.GPU.GetType().Name + "\r\n"; }
        public string GetPowerSupplyTypeString() 
        { return "Power Supply: " + this.Description.PS.GetType().Name + "\r\n"; }
        public string GetDrivesTypeString()
        {
            string buffer_1 = "\r\n\tCount: " + this.Description.Drives.Length + "\r\n";
            foreach (I_SSD_HDD drive in this.Description.Drives)
            {
                buffer_1 += "\t" + drive.GetType().Name + "\r\n";
            }
            return "Drives: " + buffer_1;
        }
        public double totalPrice()
        {
            double DrivesPrice = 0;
            foreach (I_SSD_HDD drive in Description.Drives)
            {
                DrivesPrice += drive.Price;
            }
            return (Description.PS.Price
                    + Description.Motherboard.Price
                    + Description.Motherboard.CPU.Price
                    + Description.Motherboard.GPU.Price
                    + DrivesPrice);
        }

    }
}
