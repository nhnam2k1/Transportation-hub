
namespace OOD_Week_5_16_3_21.Forms
{
    partial class CreateNewVehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateNewButton = new System.Windows.Forms.Button();
            this.tbxLicensePlate = new System.Windows.Forms.TextBox();
            this.tbxGasUsage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPricePerKm = new System.Windows.Forms.TextBox();
            this.tbxMaximumVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMaximumWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMaximumPeople = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateNewButton
            // 
            this.btnCreateNewButton.Location = new System.Drawing.Point(61, 238);
            this.btnCreateNewButton.Name = "btnCreateNewButton";
            this.btnCreateNewButton.Size = new System.Drawing.Size(122, 23);
            this.btnCreateNewButton.TabIndex = 0;
            this.btnCreateNewButton.Text = "Create New Vehicle";
            this.btnCreateNewButton.UseVisualStyleBackColor = true;
            this.btnCreateNewButton.Click += new System.EventHandler(this.btnCreateNewButton_Click);
            // 
            // tbxLicensePlate
            // 
            this.tbxLicensePlate.Location = new System.Drawing.Point(128, 19);
            this.tbxLicensePlate.Name = "tbxLicensePlate";
            this.tbxLicensePlate.Size = new System.Drawing.Size(100, 20);
            this.tbxLicensePlate.TabIndex = 1;
            // 
            // tbxGasUsage
            // 
            this.tbxGasUsage.Location = new System.Drawing.Point(141, 71);
            this.tbxGasUsage.Name = "tbxGasUsage";
            this.tbxGasUsage.Size = new System.Drawing.Size(87, 20);
            this.tbxGasUsage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "License Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gas Usage Litres per km";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(128, 123);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(100, 21);
            this.cbxType.TabIndex = 5;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price per Km";
            // 
            // tbxPricePerKm
            // 
            this.tbxPricePerKm.Location = new System.Drawing.Point(128, 97);
            this.tbxPricePerKm.Name = "tbxPricePerKm";
            this.tbxPricePerKm.Size = new System.Drawing.Size(100, 20);
            this.tbxPricePerKm.TabIndex = 9;
            // 
            // tbxMaximumVolume
            // 
            this.tbxMaximumVolume.Location = new System.Drawing.Point(128, 176);
            this.tbxMaximumVolume.Name = "tbxMaximumVolume";
            this.tbxMaximumVolume.Size = new System.Drawing.Size(100, 20);
            this.tbxMaximumVolume.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Maximum Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maximum Volume";
            // 
            // tbxMaximumWeight
            // 
            this.tbxMaximumWeight.Location = new System.Drawing.Point(128, 150);
            this.tbxMaximumWeight.Name = "tbxMaximumWeight";
            this.tbxMaximumWeight.Size = new System.Drawing.Size(100, 20);
            this.tbxMaximumWeight.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type";
            // 
            // tbxMaximumPeople
            // 
            this.tbxMaximumPeople.Location = new System.Drawing.Point(128, 202);
            this.tbxMaximumPeople.Name = "tbxMaximumPeople";
            this.tbxMaximumPeople.Size = new System.Drawing.Size(100, 20);
            this.tbxMaximumPeople.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Maximum People";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(128, 45);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 20);
            this.tbxModel.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Model";
            // 
            // CreateNewVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 273);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxMaximumPeople);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMaximumWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxMaximumVolume);
            this.Controls.Add(this.tbxPricePerKm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxGasUsage);
            this.Controls.Add(this.tbxLicensePlate);
            this.Controls.Add(this.btnCreateNewButton);
            this.Name = "CreateNewVehicleForm";
            this.Text = "Create New Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewButton;
        private System.Windows.Forms.TextBox tbxLicensePlate;
        private System.Windows.Forms.TextBox tbxGasUsage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPricePerKm;
        private System.Windows.Forms.TextBox tbxMaximumVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxMaximumWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMaximumPeople;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label label8;
    }
}