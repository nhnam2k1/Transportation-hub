using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using OOD_Week_5_16_3_21.Interfaces;
using OOD_Week_5_16_3_21.Class;

namespace OOD_Week_5_16_3_21
{
    class RideManager : IPersistentStorage
    {
        private static List<Ride> rides;
        private static int rideID;
        public RideManager()
        {
            if (rides == null)
            {
                rides = new List<Ride>();
                rideID = 0;
            }
        }
        public void AddRide(Ride ride)
        {
            double distance = ride.Kilometers;
            DateTime start = ride.StartingTime;
            DateTime end = ride.EndingTime;
            double startingPrice = ride.StartingPrice;
            Vehicle vehicle = ride.Vehicle;

            if (ride is PassengersRide)
            {
                int amountPeople = ((PassengersRide)ride).AmountPeople;
                ride = new PassengersRide(rideID, vehicle, start, end, amountPeople, distance, startingPrice);
            }
            else if (ride is FreightRide)
            {
                double cargoWeight = ((FreightRide)ride).CargoWeight;
                double cargoVolume = ((FreightRide)ride).CargoVolume;
                ride = new FreightRide(rideID, vehicle, start, end,cargoWeight, cargoVolume, distance, startingPrice);
            }
            rides.Add(ride);
            rides.Sort();
            rideID++;
        }
        public Ride[] GetRides()
        {
            rides.Sort();
            return rides.ToArray();
        }
        public void MarkRideComplete(int id)
        {
            foreach(Ride ride in rides)
            {
                if (ride.ID == id)
                {
                    ride.MarkCompleted();
                    return;
                }
            }
            throw new Exception("Cannot find the id of this ride");
        }
        public void LoadData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            string filepath = "rides.bin";

            try
            {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);

                rides = (List<Ride>)bf.Deserialize(fs);
                rideID = rides.Count();
            }
            catch(Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        public void SaveData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            string filepath = "rides.bin";

            try
            {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                bf.Serialize(fs, rides);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
