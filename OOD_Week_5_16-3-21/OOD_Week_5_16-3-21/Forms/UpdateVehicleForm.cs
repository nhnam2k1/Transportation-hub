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
    public partial class UpdateVehicleForm : Form
    {
        private Vehicle currentVehicle;
        private VehicleManager vehicleManager;
        private ValidationInput validationInput;
        public UpdateVehicleForm(Vehicle vehicle)
        {
            currentVehicle = vehicle;
            InitializeComponent();

            vehicleManager = new VehicleManager();
            validationInput = new ValidationInput();

            tbxMaximumPeople.Enabled = false;
            tbxMaximumVolume.Enabled = false;
            tbxMaximumWeight.Enabled = false;
            tbxLicensePlate.Enabled = false;
            cbxType.Enabled = false;

            foreach(var item in Enum.GetValues(typeof(VehicleType)))
            {
                cbxType.Items.Add(item);
            }

            if (vehicle is Car)
            {
                tbxMaximumPeople.Enabled = true;
                cbxType.SelectedIndex = 0;
                tbxMaximumPeople.Text = ((Car)vehicle).MaximumPassengers.ToString();
            }
            else if (vehicle is Van)
            {
                tbxMaximumPeople.Enabled = true;
                tbxMaximumVolume.Enabled = true;
                tbxMaximumWeight.Enabled = true;
                cbxType.SelectedIndex = 1;
                tbxMaximumPeople.Text = ((Van)vehicle).MaximumPassengers.ToString();
                tbxMaximumVolume.Text = ((Van)vehicle).MaximumVolume.ToString();
                tbxMaximumWeight.Text = ((Van)vehicle).MaximumWeight.ToString();
            }
            else if (vehicle is Truck)
            {
                tbxMaximumVolume.Enabled = true;
                tbxMaximumWeight.Enabled = true;
                cbxType.SelectedIndex = 2;
                tbxMaximumVolume.Text = ((Truck)vehicle).MaximumVolume.ToString();
                tbxMaximumWeight.Text = ((Truck)vehicle).MaximumWeight.ToString();
            }

            tbxLicensePlate.Text = vehicle.LicensePlate;
            tbxModel.Text = vehicle.MakeAndModel;
            tbxGasUsage.Text = vehicle.GasUsageLitresPerKm.ToString();
            tbxPricePerKm.Text = vehicle.PricePerKm.ToString();
        } 

        private void btnUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle updatedVehicle = currentVehicle;
                string license = tbxLicensePlate.Text;
                validationInput.ValidateLicensePlate(license);
                string model = tbxModel.Text;
                double gasUsage = validationInput.ValidateReal(tbxGasUsage.Text);
                double price = validationInput.ValidateReal(tbxPricePerKm.Text);
                double totalKm = currentVehicle.TotalKm;

                if (currentVehicle is Car)
                {
                    int maxPeople = validationInput.ValidateInt(tbxMaximumPeople.Text);
                    updatedVehicle = new Car(license, gasUsage, price, totalKm, maxPeople, model);
                }
                else if (currentVehicle is Van)
                {
                    int maxPeople = validationInput.ValidateInt(tbxMaximumPeople.Text);
                    double maxWeight = validationInput.ValidateReal(tbxMaximumWeight.Text);
                    double maxVolume = validationInput.ValidateReal(tbxMaximumVolume.Text);
                    updatedVehicle = new Van(license, gasUsage, price, totalKm, maxPeople, maxWeight, maxVolume, model);
                }
                else if (currentVehicle is Truck)
                {
                    double maxWeight = validationInput.ValidateReal(tbxMaximumWeight.Text);
                    double maxVolume = validationInput.ValidateReal(tbxMaximumVolume.Text);
                    updatedVehicle = new Truck(license, gasUsage, price, totalKm, maxWeight, maxVolume, model);
                }

                vehicleManager.UpdateVehicle(currentVehicle, updatedVehicle);
                MessageBox.Show("Successful update the vehicle");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
