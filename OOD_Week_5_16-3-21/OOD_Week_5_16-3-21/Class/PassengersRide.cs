using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week_5_16_3_21.Class
{
    [Serializable]
    public class PassengersRide : Ride
    {
        private int amountPeople;
        public PassengersRide(int id, Vehicle vehicle,
                              DateTime startingTime, DateTime endingTime,
                              int amountPeople,  double kilometers, double startingPrice) :
            base(id, vehicle, startingTime, endingTime, kilometers, startingPrice)
        {
            this.amountPeople = amountPeople;
        }
        public int AmountPeople { get { return amountPeople; } }
    }
}
