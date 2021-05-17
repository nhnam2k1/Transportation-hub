using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week_5_16_3_21
{
    class ValidationInput
    {
        public ValidationInput()
        {

        }
        public int ValidateInt(string text)
        {
            int number = int.Parse(text);
            if (number < 0)
            {
                throw new Exception("The number should not be negative");
            }
            return number;
        }
        public double ValidateReal(string text)
        {
            double val = double.Parse(text);
            if (val < 0)
            {
                throw new Exception("The real should not be negative");
            }
            return val;
        }
        public void ValidateLicensePlate(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new Exception("The license plate should not empty");
            }
        }
    }
}
