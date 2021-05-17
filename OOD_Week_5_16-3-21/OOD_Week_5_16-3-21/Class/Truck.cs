using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Week_5_16_3_21.Interfaces;

namespace OOD_Week_5_16_3_21.Class
{
    [Serializable]
    public class Truck : Vehicle, IFreight
    {
        private double maximumWeight;
        private double maximumVolume;
        public Truck(string licensePlate, double gasUsageLitresPerKm, double pricePerKm,
                   double totalKm, double maximumWeight, double maximumVolume, string makeAndModel) :
               base(licensePlate, gasUsageLitresPerKm, pricePerKm, totalKm, makeAndModel)
        {
            this.maximumVolume = maximumVolume;
            this.maximumWeight = maximumWeight;
        }
        public double MaximumWeight => maximumWeight;
        public double MaximumVolume => maximumVolume;
    }
}
