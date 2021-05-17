using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week_5_16_3_21.Class
{
    [Serializable]
    public class Vehicle : IComparable<Vehicle>
    {
        protected string licensePlate;
        protected double gasUsageLitresPerKm;
        protected double pricePerKm;
        protected double totalKm;
        protected string makeAndModel;
        public bool IsAvailable;
        public Vehicle(string licensePlate, 
                       double gasUsageLitresPerKm, double pricePerKm, 
                       double totalKm, string makeAndModel)
        {
            this.licensePlate = licensePlate;
            this.gasUsageLitresPerKm = gasUsageLitresPerKm;
            this.pricePerKm = pricePerKm;
            this.totalKm = totalKm;
            this.makeAndModel = makeAndModel;
            IsAvailable = true;
        }
        public void AddDistance(double kilometers)
        {
            totalKm += kilometers;
        }
        public string LicensePlate { get { return licensePlate; } }
        public double GasUsageLitresPerKm { get { return gasUsageLitresPerKm; } }
        public double PricePerKm { get { return pricePerKm; } }
        public double TotalKm { get { return totalKm; } }
        public string MakeAndModel { get { return makeAndModel; } }
        public double ConsumedFuel { get { return totalKm * gasUsageLitresPerKm; } }
        public int CompareTo(Vehicle other)
        {
            return licensePlate.CompareTo(other.licensePlate);
        }
    }
}
