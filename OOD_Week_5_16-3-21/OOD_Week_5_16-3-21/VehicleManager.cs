using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using OOD_Week_5_16_3_21.Class;
using OOD_Week_5_16_3_21.Interfaces;

namespace OOD_Week_5_16_3_21
{
    class VehicleManager  : IPersistentStorage
    {
        private static List<Vehicle> vehicles;
        public VehicleManager()
        {
            if (vehicles == null)
            {
                vehicles = new List<Vehicle>();
            }
        }
        public Vehicle GetVehicle(string licensePlate)
        {
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle.LicensePlate == licensePlate)
                {
                    return vehicle;
                }
            }
            throw new Exception("Cannot find this vehicle");
        }
        public Vehicle FindPassengerTransportation(int amountPeople)
        {
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle is IPassengerTransport && vehicle.IsAvailable)
                {
                    int maxPeople = ((IPassengerTransport)vehicle).MaximumPassengers;
                    if (amountPeople <= maxPeople)
                    {
                        vehicle.IsAvailable = false;
                        return vehicle;
                    }
                }
            }
            throw new Exception("Cannot find suitable passenger transportation in this moment");
        }
        public Vehicle FindFreighter(double cargoVolume, double cargoWeight)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is IFreight && vehicle.IsAvailable)
                {
                    double maxVol = ((IFreight)vehicle).MaximumVolume;
                    double maxWeight = ((IFreight)vehicle).MaximumWeight;

                    if (cargoVolume <= maxVol && cargoWeight <= maxWeight)
                    {
                        vehicle.IsAvailable = false;
                        return vehicle;
                    }
                }
            }
            throw new Exception("Cannot find suitable freighter in this moment");
        }
        public Vehicle[] GetVehicles()
        {
            vehicles.Sort();
            return vehicles.ToArray();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            foreach(Vehicle veh in vehicles)
            {
                if (veh.LicensePlate == vehicle.LicensePlate)
                {
                    throw new Exception("This licensePlate has already in system");
                }
            }
            vehicles.Add(vehicle);
            vehicles.Sort();
        }
        public void UpdateVehicle(Vehicle oldVehicle, Vehicle newVehicle)
        {
            int length = vehicles.Count;
            for(int i = 0; i < length; i++)
            {
                if (vehicles[i].LicensePlate == oldVehicle.LicensePlate)
                {
                    vehicles[i] = newVehicle;
                    return;
                }
            }
            throw new Exception("Cannot find the info of vehicle");
        }
        public void MarkVehicleAvailalbe(string licensePlate, double rideDistance)
        {
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle.LicensePlate == licensePlate)
                {
                    vehicle.AddDistance(rideDistance);
                    vehicle.IsAvailable = true;
                    return;
                }
            }
            throw new Exception("Cannot find the license plate for this vehicle");
        }
        public void LoadData()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            string filepath = "vehicles.bin";

            try
            {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read);
                vehicles = (List<Vehicle>)bf.Deserialize(fs);
            }
            catch (Exception ex)
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
            string filepath = "vehicles.bin";

            try
            {
                bf = new BinaryFormatter();
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                bf.Serialize(fs, vehicles);
            }
            catch (Exception ex)
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
