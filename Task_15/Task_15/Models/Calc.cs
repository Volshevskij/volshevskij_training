using System;

namespace Calculator.Models
{
    public class Calc
    {
        public double Argument1 { get; set; }
        public double Argument2 { get; set; }
        public string Operator { get; set; }
        public double Result { get; set; }
        public double Answer { get; set; }
        public string Ret { get; set; }
        public Calc()
        {
            Ret = " ";
        }
        public void RandCalc()
        {
            Random r = new Random();
            Argument1 = r.Next(1, 10);
            Argument2 = r.Next(1, 10);
            double tmp = r.Next(0, 3);
            if (tmp == 0)
            {
                Operator = "+";
            }

            if (tmp == 1)
            {
                Operator = "-";
            }

            if (tmp == 2)
            {
                Operator = "*";
            }
            GetResult();
        }
        public void GetResult()
        {
            if (Operator == "+")
            {
                Result = Argument1 + Argument2;
            }
            if (Operator == "-")
            {
                Result = Argument1 - Argument2;
            }
            if (Operator == "*")
            {
                Result = Argument1 * Argument2;
            }
        }
    }
}