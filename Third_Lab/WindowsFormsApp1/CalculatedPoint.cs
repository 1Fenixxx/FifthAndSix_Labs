using System;

namespace WindowsFormsApp1
{
    public class CalculatedPoint
    {
        public double Y;
        public double X1;
        public double X2;

        public CalculatedPoint(double X1, double X2)
        {
            calculate_Y(X1, X2, ref Y);
            this.X1 = X1;
            this.X2 = X2;
        }
        public static double calculate_Y(double X1, double X2, ref double res_Y)
        {
            double Y = 0;
            double TopPart = 0;
            double BotPart = 1;

            TopPart = (Math.Pow(X1, 3) + Math.Pow(X2, 5));
            TopPart = (Math.Pow(TopPart, 0.5));

            BotPart = (X1 + Math.Pow(X2, 5));
            BotPart = (Math.Pow(BotPart, 0.5) * 1000);

            Y = (TopPart / BotPart);
            Y += 65;

            res_Y = Y;
            return Y;
        }
        public override string ToString()
        {
            string output = string.Empty;

            output  += "| Y: " + Y.ToString("0.00000000") 
                    + " |\t| " + "X1: " + X1.ToString("0.000")
                    + " |\t| " + "X2: " + X2.ToString("0.000") 
                    + " |\n";

            return output;
        }

        //0 - X1 | 1 - X2 | 2 - Y
        public string[] GetStringForDataGridView()
        {
            string[] output = new string[3];

            output[0] = this.Y.ToString ("0.0000");
            output[1] = this.X1.ToString("0.0000");
            output[2] = this.X2.ToString("0.0000");

            return output;
        }
    }
}
