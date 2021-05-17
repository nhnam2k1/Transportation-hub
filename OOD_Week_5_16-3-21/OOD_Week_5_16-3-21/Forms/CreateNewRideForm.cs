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

namespace OOD_Week_5_16_3_21.Forms
{
    public partial class CreateNewRideForm : Form
    {
        private RideManager rideManager;
        private VehicleManager vehicleManager;
        private ValidationInput validationInput;
        public CreateNewRideForm()
        {
            rideManager = new RideManager();
            validationInput = new ValidationInput();
            vehicleManager = new VehicleManager();

            InitializeComponent();

            foreach(var type in Enum.GetValues(typeof(RideType)))
            {
                cbxRideType.Items.Add(type);
            }
            cbxRideType.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                RideType type = (RideType)cbxRideType.SelectedIndex;
                double distance = validationInput.ValidateReal(tbxDistance.Text);
                double startingPrice = validationInput.ValidateReal(tbxStartingPrice.Text);
                DateTime start = dtpStart.Value;
                DateTime end = dtpEnd.Value;
                Vehicle vehicle = null;

                if (start.CompareTo(DateTime.Now) == -1)
                {
                    throw new Exception("The starting date should not in the past");
                }

                if (end.CompareTo(start) == -1)
                {
                    throw new Exception("The ending date should be after the starting date");
                }

                Ride newRide = null;
                switch (type)
                {
                    case RideType.PASSENGERS:
                        {
                            int amountPeople = validationInput.ValidateInt(tbxNrPeople.Text);
                            vehicle = vehicleManager.FindPassengerTransportation(amountPeople);
                            newRide = new PassengersRide(0, vehicle, start, end, amountPeople, distance, startingPrice);
                            break;
                        }
                    case RideType.FREIGHT:
                        {
                            double cargoWeight = validationInput.ValidateReal(tbxCargoWeight.Text);
                            double cargoVolume = validationInput.ValidateReal(tbxCargoVolume.Text);
                            vehicle = vehicleManager.FindFreighter(cargoVolume, cargoWeight);
                            newRide = new FreightRide(0, vehicle, start, end, cargoWeight, cargoVolume, distance, startingPrice);
                            break;
                        }
                }
                rideManager.AddRide(newRide);
                MessageBox.Show("Successful creating new ride");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxRideType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RideType type = (RideType)cbxRideType.SelectedIndex;

            if (type == RideType.PASSENGERS)
            {
                tbxCargoVolume.Enabled = false;
                tbxCargoWeight.Enabled = false;
                tbxNrPeople.Enabled = true;
            }
            else if (type == RideType.FREIGHT)
            {
                tbxCargoVolume.Enabled = true;
                tbxCargoWeight.Enabled = true;
                tbxNrPeople.Enabled = false;
            }
        }
    }
}
