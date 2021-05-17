using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Week_5_16_3_21.Interfaces;

namespace OOD_Week_5_16_3_21.Class
{
    [Serializable]
    public class Van : Vehicle, IPassengerTransport, IFreight
    {
        private int maximumPassengers;
        private double maximumWeight;
        private double maximumVolume;
        public Van(string licensePlate, double gasUsageLitresPerKm, double pricePerKm,
                   double totalKm, int maximumPassengers, double maximumWeight,
                   double maximumVolume, string makeAndModel) :
               base(licensePlate, gasUsageLitresPerKm, pricePerKm, totalKm, makeAndModel)
        {
            this.maximumPassengers = maximumPassengers;
            this.maximumVolume = maximumVolume;
            this.maximumWeight = maximumWeight;
        }
        public int MaximumPassengers => maximumPassengers;
        public double MaximumWeight => maximumWeight;
        public double MaximumVolume => maximumVolume;
    }
}
