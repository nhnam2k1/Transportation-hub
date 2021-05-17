
namespace OOD_Week_5_16_3_21.Forms
{
    partial class CreateNewRideForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.cbxRideType = new System.Windows.Forms.ComboBox();
            this.tbxNrPeople = new System.Windows.Forms.TextBox();
            this.tbxCargoVolume = new System.Windows.Forms.TextBox();
            this.tbxCargoWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxStartingPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(107, 47);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(100, 20);
            this.tbxDistance.TabIndex = 1;
            // 
            // cbxRideType
            // 
            this.cbxRideType.FormattingEnabled = true;
            this.cbxRideType.Location = new System.Drawing.Point(107, 20);
            this.cbxRideType.Name = "cbxRideType";
            this.cbxRideType.Size = new System.Drawing.Size(100, 21);
            this.cbxRideType.TabIndex = 2;
            this.cbxRideType.SelectedIndexChanged += new System.EventHandler(this.cbxRideType_SelectedIndexChanged);
            // 
            // tbxNrPeople
            // 
            this.tbxNrPeople.Location = new System.Drawing.Point(107, 73);
            this.tbxNrPeople.Name = "tbxNrPeople";
            this.tbxNrPeople.Size = new System.Drawing.Size(100, 20);
            this.tbxNrPeople.TabIndex = 3;
            // 
            // tbxCargoVolume
            // 
            this.tbxCargoVolume.Location = new System.Drawing.Point(107, 99);
            this.tbxCargoVolume.Name = "tbxCargoVolume";
            this.tbxCargoVolume.Size = new System.Drawing.Size(100, 20);
            this.tbxCargoVolume.TabIndex = 4;
            // 
            // tbxCargoWeight
            // 
            this.tbxCargoWeight.Location = new System.Drawing.Point(107, 125);
            this.tbxCargoWeight.Name = "tbxCargoWeight";
            this.tbxCargoWeight.Size = new System.Drawing.Size(100, 20);
            this.tbxCargoWeight.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of People";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cargo Volume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cargo Weight";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(61, 229);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create New Ride";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(47, 177);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(160, 20);
            this.dtpStart.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(47, 203);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(160, 20);
            this.dtpEnd.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "End";
            // 
            // tbxStartingPrice
            // 
            this.tbxStartingPrice.Location = new System.Drawing.Point(107, 151);
            this.tbxStartingPrice.Name = "tbxStartingPrice";
            this.tbxStartingPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxStartingPrice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Starting Price";
            // 
            // CreateNewRideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 255);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxStartingPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCargoWeight);
            this.Controls.Add(this.tbxCargoVolume);
            this.Controls.Add(this.tbxNrPeople);
            this.Controls.Add(this.cbxRideType);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewRideForm";
            this.Text = "Create New Ride";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.ComboBox cbxRideType;
        private System.Windows.Forms.TextBox tbxNrPeople;
        private System.Windows.Forms.TextBox tbxCargoVolume;
        private System.Windows.Forms.TextBox tbxCargoWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxStartingPrice;
        private System.Windows.Forms.Label label8;
    }
}