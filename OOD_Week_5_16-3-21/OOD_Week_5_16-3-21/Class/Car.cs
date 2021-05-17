using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Week_5_16_3_21.Interfaces;

namespace OOD_Week_5_16_3_21.Class
{
    [Serializable]
    public class Car : Vehicle, IPassengerTransport
    {
        private int maximumPassengers;
        public Car(string licensePlate, double gasUsageLitresPerKm, double pricePerKm,
                   double totalKm, int maximumPassengers, string makeAndModel) :  
               base(licensePlate, gasUsageLitresPerKm, pricePerKm, totalKm, makeAndModel)
        {
            this.maximumPassengers = maximumPassengers;
        }

        public int MaximumPassengers => maximumPassengers;
    }
}
