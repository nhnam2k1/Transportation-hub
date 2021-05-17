using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD_Week_5_16_3_21.Class;
using OOD_Week_5_16_3_21.Forms;

namespace OOD_Week_5_16_3_21
{
    public partial class TransportationHub : Form
    {
        CreateNewRideForm createNewRideForm;
        CreateNewVehicleForm createNewVehicleForm;
        UpdateVehicleForm updateVehicleForm;

        private Vehicle[] vehicles;
        private Ride[] rides;

        private RideManager rideManager;
        private VehicleManager vehicleManager;
        public TransportationHub()
        {
            rideManager = new RideManager();
            vehicleManager = new VehicleManager();

            InitializeComponent();

            rideManager.LoadData();
            vehicleManager.LoadData();

            UpdateVehiclesListView();
            UpdateRidesListView();
        }
        private void btnCreateNewRide_Click(object sender, EventArgs e)
        {
            try
            {
                createNewRideForm = new CreateNewRideForm();
                createNewRideForm.ShowDialog();
                UpdateRidesListView();
                UpdateVehiclesListView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCompleteRide_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lvRide.SelectedItems[0].SubItems[1].Text);
                string licensePlate = lvRide.SelectedItems[0].SubItems[0].Text;
                double kilometers = Convert.ToDouble(lvRide.SelectedItems[0].SubItems[7].Text);

                vehicleManager.MarkVehicleAvailalbe(licensePlate, kilometers);
                rideManager.MarkRideComplete(id);

                UpdateVehiclesListView();
                UpdateRidesListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle vehicle = vehicleManager.GetVehicle(lvVehicle.SelectedItems[0].Name);
                updateVehicleForm = new UpdateVehicleForm(vehicle);
                updateVehicleForm.ShowDialog();
                UpdateVehiclesListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCreateNewVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                createNewVehicleForm = new CreateNewVehicleForm();
                createNewVehicleForm.ShowDialog();
                UpdateVehiclesListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateRidesListView()
        {
            rides = rideManager.GetRides();
            lvRide.Items.Clear();

            foreach(Ride ride in rides)
            {
                ListViewItem lvi = new ListViewItem(ride.Vehicle.LicensePlate);
                lvi.SubItems.Add(ride.ID.ToString());
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");

                if (ride is PassengersRide)
                {
                    lvi.SubItems[2].Text = ((PassengersRide)ride).AmountPeople.ToString();
                }
                else if (ride is FreightRide)
                {
                    lvi.SubItems[3].Text = ((FreightRide)ride).CargoWeight.ToString();
                    lvi.SubItems[4].Text = ((FreightRide)ride).CargoVolume.ToString();
                }
                lvi.SubItems.Add(ride.Price.ToString());
                lvi.SubItems.Add(ride.StartingPrice.ToString());
                lvi.SubItems.Add(ride.Kilometers.ToString());
                lvi.SubItems.Add(ride.StartingTime.ToString());
                lvi.SubItems.Add(ride.EndingTime.ToString());
                lvi.SubItems.Add(ride.IsCompleted ? "V" : " ");
                lvi.Name = ride.ID.ToString();
                lvRide.Items.Add(lvi);
            }
        }
        private void UpdateVehiclesListView()
        {
            vehicles = vehicleManager.GetVehicles();
            lvVehicle.Items.Clear();

            foreach(Vehicle vehicle in vehicles)
            {
                ListViewItem lvi = new ListViewItem(vehicle.LicensePlate);
                lvi.SubItems.Add(vehicle.MakeAndModel);
                lvi.SubItems.Add(vehicle.GasUsageLitresPerKm.ToString());
                lvi.SubItems.Add(vehicle.PricePerKm.ToString());
                lvi.SubItems.Add(vehicle.ConsumedFuel.ToString());
                lvi.SubItems.Add(vehicle.TotalKm.ToString());
                lvi.SubItems.Add(vehicle.IsAvailable ? "V" : " ");
                lvi.SubItems.Add(vehicle.GetType().Name);
                lvi.Name = vehicle.LicensePlate;
                lvVehicle.Items.Add(lvi);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            vehicleManager.SaveData();
            rideManager.SaveData();
        }
    }
}
