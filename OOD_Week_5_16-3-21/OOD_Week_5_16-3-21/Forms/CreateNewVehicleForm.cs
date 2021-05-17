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
using OOD_Week_5_16_3_21;

namespace OOD_Week_5_16_3_21.Forms
{
    public partial class CreateNewVehicleForm : Form
    {
        private VehicleManager vehicleManager;
        private ValidationInput validationInput;
        public CreateNewVehicleForm()
        {
            vehicleManager = new VehicleManager();
            validationInput = new ValidationInput();

            InitializeComponent();

            foreach(var item in Enum.GetValues(typeof(VehicleType)))
            {
                cbxType.Items.Add(item);
            }
            cbxType.SelectedIndex = 0;
        }

        private void btnCreateNewButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle newVehicle = null;

                VehicleType type = (VehicleType)cbxType.SelectedIndex;
                string plate = tbxLicensePlate.Text;
                validationInput.ValidateLicensePlate(plate);
                string model = tbxModel.Text;
                double gasUsage = validationInput.ValidateReal(tbxGasUsage.Text);
                double price = validationInput.ValidateReal(tbxPricePerKm.Text);

                switch (type)
                {
                    case VehicleType.CAR:
                        {
                            int maxPeople = validationInput.ValidateInt(tbxMaximumPeople.Text);
                            newVehicle = new Car(plate, gasUsage, price, 0, maxPeople, model);
                            break;
                        }
                    case VehicleType.VAN:
                        {
                            int maxPeople = validationInput.ValidateInt(tbxMaximumPeople.Text);
                            double maxVolume = validationInput.ValidateReal(tbxMaximumVolume.Text);
                            double maxWeight = validationInput.ValidateReal(tbxMaximumWeight.Text);
                            newVehicle = new Van(plate, gasUsage, price, 0, maxPeople, maxWeight, maxVolume, model);
                            break;
                        }
                    case VehicleType.TRUCK:
                        {
                            double maxVolume = validationInput.ValidateReal(tbxMaximumVolume.Text);
                            double maxWeight = validationInput.ValidateReal(tbxMaximumWeight.Text);
                            newVehicle = new Truck(plate, gasUsage, price, 0, maxWeight, maxVolume, model);
                            break;
                        }
                }
                vehicleManager.AddVehicle(newVehicle);
                MessageBox.Show("Successful adding new vehicle");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleType type = (VehicleType)cbxType.SelectedIndex;

            if (type == VehicleType.CAR)
            {
                tbxMaximumPeople.Enabled = true;
                tbxMaximumVolume.Enabled = false;
                tbxMaximumWeight.Enabled = false;
            }
            else if (type == VehicleType.VAN)
            {
                tbxMaximumPeople.Enabled = true;
                tbxMaximumVolume.Enabled = true;
                tbxMaximumWeight.Enabled = true;
            }
            else if (type == VehicleType.TRUCK)
            {
                tbxMaximumPeople.Enabled = false;
                tbxMaximumVolume.Enabled = true;
                tbxMaximumWeight.Enabled = true;
            }
        }
    }
}
