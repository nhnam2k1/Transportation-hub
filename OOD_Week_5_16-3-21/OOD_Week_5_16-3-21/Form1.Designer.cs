
namespace OOD_Week_5_16_3_21
{
    partial class TransportationHub
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCompleteRide = new System.Windows.Forms.Button();
            this.btnCreateNewRide = new System.Windows.Forms.Button();
            this.lvRide = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnCreateNewVehicle = new System.Windows.Forms.Button();
            this.lvVehicle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(12, 12);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(798, 426);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCompleteRide);
            this.tabPage1.Controls.Add(this.btnCreateNewRide);
            this.tabPage1.Controls.Add(this.lvRide);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rides Hub";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCompleteRide
            // 
            this.btnCompleteRide.Location = new System.Drawing.Point(276, 374);
            this.btnCompleteRide.Name = "btnCompleteRide";
            this.btnCompleteRide.Size = new System.Drawing.Size(131, 23);
            this.btnCompleteRide.TabIndex = 2;
            this.btnCompleteRide.Text = "Mark Complete";
            this.btnCompleteRide.UseVisualStyleBackColor = true;
            this.btnCompleteRide.Click += new System.EventHandler(this.btnCompleteRide_Click);
            // 
            // btnCreateNewRide
            // 
            this.btnCreateNewRide.Location = new System.Drawing.Point(413, 374);
            this.btnCreateNewRide.Name = "btnCreateNewRide";
            this.btnCreateNewRide.Size = new System.Drawing.Size(148, 23);
            this.btnCreateNewRide.TabIndex = 1;
            this.btnCreateNewRide.Text = "Create New Ride";
            this.btnCreateNewRide.UseVisualStyleBackColor = true;
            this.btnCreateNewRide.Click += new System.EventHandler(this.btnCreateNewRide_Click);
            // 
            // lvRide
            // 
            this.lvRide.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvRide.HideSelection = false;
            this.lvRide.Location = new System.Drawing.Point(6, 6);
            this.lvRide.Name = "lvRide";
            this.lvRide.Size = new System.Drawing.Size(778, 362);
            this.lvRide.TabIndex = 0;
            this.lvRide.UseCompatibleStateImageBehavior = false;
            this.lvRide.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "License Plate";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 45;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Amount People";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 84;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Cargo Weight";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 77;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Cargo Volume";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 79;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Price";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Starting Price";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader14.Width = 76;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Kilometers";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Starting";
            this.columnHeader16.Width = 75;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ending";
            this.columnHeader17.Width = 75;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Complete";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateVehicle);
            this.tabPage2.Controls.Add(this.btnCreateNewVehicle);
            this.tabPage2.Controls.Add(this.lvVehicle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehicles Hub";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(674, 322);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateVehicle.TabIndex = 2;
            this.btnUpdateVehicle.Text = "Update Vehicle Info";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnCreateNewVehicle
            // 
            this.btnCreateNewVehicle.Location = new System.Drawing.Point(674, 360);
            this.btnCreateNewVehicle.Name = "btnCreateNewVehicle";
            this.btnCreateNewVehicle.Size = new System.Drawing.Size(110, 23);
            this.btnCreateNewVehicle.TabIndex = 1;
            this.btnCreateNewVehicle.Text = "Create New Vehicle";
            this.btnCreateNewVehicle.UseVisualStyleBackColor = true;
            this.btnCreateNewVehicle.Click += new System.EventHandler(this.btnCreateNewVehicle_Click);
            // 
            // lvVehicle
            // 
            this.lvVehicle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader19});
            this.lvVehicle.HideSelection = false;
            this.lvVehicle.Location = new System.Drawing.Point(7, 7);
            this.lvVehicle.Name = "lvVehicle";
            this.lvVehicle.Size = new System.Drawing.Size(661, 387);
            this.lvVehicle.TabIndex = 0;
            this.lvVehicle.UseCompatibleStateImageBehavior = false;
            this.lvVehicle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "License Plate";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gas Usage Litres Per Km";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price Per Km";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Comsumed Fuel";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Km";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Is Available";
            this.columnHeader7.Width = 68;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Type";
            // 
            // TransportationHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.tab1);
            this.Name = "TransportationHub";
            this.Text = "Transportation Hub";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnCreateNewVehicle;
        private System.Windows.Forms.ListView lvVehicle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnCompleteRide;
        private System.Windows.Forms.Button btnCreateNewRide;
        private System.Windows.Forms.ListView lvRide;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}

