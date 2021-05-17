using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week_5_16_3_21.Class
{
    [Serializable]
    public class FreightRide : Ride
    {
        private double cargoWeight;
        private double cargoVolume;
        public FreightRide(int id, Vehicle vehicle,
                           DateTime startingTime, DateTime endingTime,
                           double cargoWeight, double cargoVolume,
                           double kilometers, double startingPrice) : 
            base(id, vehicle, startingTime, endingTime, kilometers, startingPrice)
        {
            this.cargoWeight = cargoWeight;
            this.cargoVolume = cargoVolume;
        }
        public double CargoWeight { get { return cargoWeight; } }
        public double CargoVolume { get { return cargoVolume; } }
    }
}
