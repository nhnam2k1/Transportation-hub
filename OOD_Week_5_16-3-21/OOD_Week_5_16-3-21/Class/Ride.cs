using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Week_5_16_3_21.Class
{
    [Serializable]
    public class Ride : IComparable<Ride>
    {
        protected int id;
        protected Vehicle vehicle;
        protected DateTime startingTime;
        protected DateTime endingTime;
        protected double kilometers;
        protected double startingPrice;
        public Ride(int id, Vehicle vehicle,
                    DateTime startingTime, DateTime endingTime,
                    double kilometers, double startingPrice)
        {
            this.id = id;
            this.vehicle = vehicle;
            this.startingTime = startingTime;
            this.endingTime = endingTime;
            this.kilometers = kilometers;
            this.startingPrice = startingPrice;
            IsCompleted = false;
        }
        public int ID { get { return id; } }
        public Vehicle Vehicle { get { return vehicle; } }
        public DateTime StartingTime { get { return startingTime; } }
        public DateTime EndingTime { get { return endingTime; } }
        public double Kilometers { get { return kilometers; } }
        public double Price { get { return vehicle.PricePerKm * kilometers + StartingPrice; } }
        public double StartingPrice { get { return startingPrice; } }
        public bool IsCompleted { get; protected set; }
        public void MarkCompleted()
        {
            IsCompleted = true;
        }
        public int CompareTo(Ride other)
        {
            int checkDate = startingTime.CompareTo(other.startingTime);
            int checkKm = kilometers.CompareTo(other.kilometers);

            if (checkDate != 0)
            {
                return checkDate;
            }
            return checkKm;
        }
    }
}
