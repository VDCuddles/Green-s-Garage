namespace Greens_Garage
{
	partial class ServiceForm
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
			this.dgvService = new System.Windows.Forms.DataGridView();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnAddService = new System.Windows.Forms.Button();
			this.btnUpdateService = new System.Windows.Forms.Button();
			this.btnDeleteService = new System.Windows.Forms.Button();
			this.btnMarkServiceAsPaid = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.txtHourlyRate = new System.Windows.Forms.TextBox();
			this.txtServiceType = new System.Windows.Forms.TextBox();
			this.txtOwnerName = new System.Windows.Forms.TextBox();
			this.txtPlateNumber = new System.Windows.Forms.TextBox();
			this.lblHourlyRate = new System.Windows.Forms.Label();
			this.lblServiceType = new System.Windows.Forms.Label();
			this.lblOwnerName = new System.Windows.Forms.Label();
			this.lblPlateNumber = new System.Windows.Forms.Label();
			this.pnlGetData = new System.Windows.Forms.Panel();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.txtServiceDate = new System.Windows.Forms.TextBox();
			this.txtHours = new System.Windows.Forms.TextBox();
			this.txtServiceTypeID = new System.Windows.Forms.TextBox();
			this.txtVehicleID = new System.Windows.Forms.TextBox();
			this.pnlAddService = new System.Windows.Forms.Panel();
			this.btnAddCancel = new System.Windows.Forms.Button();
			this.btnSaveService = new System.Windows.Forms.Button();
			this.lblAddServiceDate = new System.Windows.Forms.Label();
			this.lblAddHours = new System.Windows.Forms.Label();
			this.lblAddServiceType = new System.Windows.Forms.Label();
			this.lblAddVehicle = new System.Windows.Forms.Label();
			this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
			this.cboAddServiceTypeID = new System.Windows.Forms.ComboBox();
			this.cboAddVehicleID = new System.Windows.Forms.ComboBox();
			this.txtAddHours = new System.Windows.Forms.TextBox();
			this.cboAddServiceTypeDescription = new System.Windows.Forms.ComboBox();
			this.cboAddVehiclePlateNumber = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
			this.pnlGetData.SuspendLayout();
			this.pnlAddService.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvService
			// 
			this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvService.Location = new System.Drawing.Point(45, 43);
			this.dgvService.Name = "dgvService";
			this.dgvService.Size = new System.Drawing.Size(418, 277);
			this.dgvService.TabIndex = 0;
			this.dgvService.Click += new System.EventHandler(this.dgvService_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(45, 355);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(120, 40);
			this.btnPrevious.TabIndex = 1;
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(203, 355);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(120, 40);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnAddService
			// 
			this.btnAddService.Location = new System.Drawing.Point(362, 355);
			this.btnAddService.Name = "btnAddService";
			this.btnAddService.Size = new System.Drawing.Size(120, 40);
			this.btnAddService.TabIndex = 3;
			this.btnAddService.Text = "Add Service";
			this.btnAddService.UseVisualStyleBackColor = true;
			this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
			// 
			// btnUpdateService
			// 
			this.btnUpdateService.Location = new System.Drawing.Point(523, 355);
			this.btnUpdateService.Name = "btnUpdateService";
			this.btnUpdateService.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateService.TabIndex = 4;
			this.btnUpdateService.Text = "Update Service";
			this.btnUpdateService.UseVisualStyleBackColor = true;
			// 
			// btnDeleteService
			// 
			this.btnDeleteService.Location = new System.Drawing.Point(680, 355);
			this.btnDeleteService.Name = "btnDeleteService";
			this.btnDeleteService.Size = new System.Drawing.Size(120, 40);
			this.btnDeleteService.TabIndex = 5;
			this.btnDeleteService.Text = "Delete Service";
			this.btnDeleteService.UseVisualStyleBackColor = true;
			this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
			// 
			// btnMarkServiceAsPaid
			// 
			this.btnMarkServiceAsPaid.Location = new System.Drawing.Point(362, 419);
			this.btnMarkServiceAsPaid.Name = "btnMarkServiceAsPaid";
			this.btnMarkServiceAsPaid.Size = new System.Drawing.Size(281, 40);
			this.btnMarkServiceAsPaid.TabIndex = 6;
			this.btnMarkServiceAsPaid.Text = "Mark Service as Paid";
			this.btnMarkServiceAsPaid.UseVisualStyleBackColor = true;
			this.btnMarkServiceAsPaid.Click += new System.EventHandler(this.btnMarkServiceAsPaid_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(680, 419);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(120, 40);
			this.btnReturn.TabIndex = 7;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// txtHourlyRate
			// 
			this.txtHourlyRate.Location = new System.Drawing.Point(571, 227);
			this.txtHourlyRate.Name = "txtHourlyRate";
			this.txtHourlyRate.Size = new System.Drawing.Size(69, 20);
			this.txtHourlyRate.TabIndex = 8;
			// 
			// txtServiceType
			// 
			this.txtServiceType.Location = new System.Drawing.Point(571, 181);
			this.txtServiceType.Name = "txtServiceType";
			this.txtServiceType.Size = new System.Drawing.Size(187, 20);
			this.txtServiceType.TabIndex = 9;
			// 
			// txtOwnerName
			// 
			this.txtOwnerName.Location = new System.Drawing.Point(571, 135);
			this.txtOwnerName.Name = "txtOwnerName";
			this.txtOwnerName.Size = new System.Drawing.Size(226, 20);
			this.txtOwnerName.TabIndex = 10;
			// 
			// txtPlateNumber
			// 
			this.txtPlateNumber.Location = new System.Drawing.Point(571, 89);
			this.txtPlateNumber.Name = "txtPlateNumber";
			this.txtPlateNumber.Size = new System.Drawing.Size(114, 20);
			this.txtPlateNumber.TabIndex = 11;
			// 
			// lblHourlyRate
			// 
			this.lblHourlyRate.AutoSize = true;
			this.lblHourlyRate.Location = new System.Drawing.Point(490, 230);
			this.lblHourlyRate.Name = "lblHourlyRate";
			this.lblHourlyRate.Size = new System.Drawing.Size(66, 13);
			this.lblHourlyRate.TabIndex = 12;
			this.lblHourlyRate.Text = "Hourly Rate:";
			// 
			// lblServiceType
			// 
			this.lblServiceType.AutoSize = true;
			this.lblServiceType.Location = new System.Drawing.Point(489, 184);
			this.lblServiceType.Name = "lblServiceType";
			this.lblServiceType.Size = new System.Drawing.Size(73, 13);
			this.lblServiceType.TabIndex = 13;
			this.lblServiceType.Text = "Service Type:";
			// 
			// lblOwnerName
			// 
			this.lblOwnerName.AutoSize = true;
			this.lblOwnerName.Location = new System.Drawing.Point(489, 138);
			this.lblOwnerName.Name = "lblOwnerName";
			this.lblOwnerName.Size = new System.Drawing.Size(72, 13);
			this.lblOwnerName.TabIndex = 14;
			this.lblOwnerName.Text = "Owner Name:";
			// 
			// lblPlateNumber
			// 
			this.lblPlateNumber.AutoSize = true;
			this.lblPlateNumber.Location = new System.Drawing.Point(488, 92);
			this.lblPlateNumber.Name = "lblPlateNumber";
			this.lblPlateNumber.Size = new System.Drawing.Size(74, 13);
			this.lblPlateNumber.TabIndex = 15;
			this.lblPlateNumber.Text = "Plate Number:";
			// 
			// pnlGetData
			// 
			this.pnlGetData.Controls.Add(this.txtStatus);
			this.pnlGetData.Controls.Add(this.txtServiceDate);
			this.pnlGetData.Controls.Add(this.txtHours);
			this.pnlGetData.Controls.Add(this.txtServiceTypeID);
			this.pnlGetData.Controls.Add(this.txtVehicleID);
			this.pnlGetData.Location = new System.Drawing.Point(30, 32);
			this.pnlGetData.Name = "pnlGetData";
			this.pnlGetData.Size = new System.Drawing.Size(311, 185);
			this.pnlGetData.TabIndex = 16;
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(164, 23);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(100, 20);
			this.txtStatus.TabIndex = 4;
			// 
			// txtServiceDate
			// 
			this.txtServiceDate.Location = new System.Drawing.Point(33, 150);
			this.txtServiceDate.Name = "txtServiceDate";
			this.txtServiceDate.Size = new System.Drawing.Size(100, 20);
			this.txtServiceDate.TabIndex = 3;
			// 
			// txtHours
			// 
			this.txtHours.Location = new System.Drawing.Point(33, 112);
			this.txtHours.Name = "txtHours";
			this.txtHours.Size = new System.Drawing.Size(100, 20);
			this.txtHours.TabIndex = 2;
			// 
			// txtServiceTypeID
			// 
			this.txtServiceTypeID.Location = new System.Drawing.Point(33, 66);
			this.txtServiceTypeID.Name = "txtServiceTypeID";
			this.txtServiceTypeID.Size = new System.Drawing.Size(100, 20);
			this.txtServiceTypeID.TabIndex = 1;
			// 
			// txtVehicleID
			// 
			this.txtVehicleID.Location = new System.Drawing.Point(33, 24);
			this.txtVehicleID.Name = "txtVehicleID";
			this.txtVehicleID.Size = new System.Drawing.Size(100, 20);
			this.txtVehicleID.TabIndex = 0;
			// 
			// pnlAddService
			// 
			this.pnlAddService.Controls.Add(this.btnAddCancel);
			this.pnlAddService.Controls.Add(this.btnSaveService);
			this.pnlAddService.Controls.Add(this.lblAddServiceDate);
			this.pnlAddService.Controls.Add(this.lblAddHours);
			this.pnlAddService.Controls.Add(this.lblAddServiceType);
			this.pnlAddService.Controls.Add(this.lblAddVehicle);
			this.pnlAddService.Controls.Add(this.dtpServiceDate);
			this.pnlAddService.Controls.Add(this.cboAddServiceTypeID);
			this.pnlAddService.Controls.Add(this.cboAddVehicleID);
			this.pnlAddService.Controls.Add(this.txtAddHours);
			this.pnlAddService.Controls.Add(this.cboAddServiceTypeDescription);
			this.pnlAddService.Controls.Add(this.cboAddVehiclePlateNumber);
			this.pnlAddService.Location = new System.Drawing.Point(428, 32);
			this.pnlAddService.Name = "pnlAddService";
			this.pnlAddService.Size = new System.Drawing.Size(405, 288);
			this.pnlAddService.TabIndex = 17;
			this.pnlAddService.Visible = false;
			// 
			// btnAddCancel
			// 
			this.btnAddCancel.Location = new System.Drawing.Point(262, 235);
			this.btnAddCancel.Name = "btnAddCancel";
			this.btnAddCancel.Size = new System.Drawing.Size(120, 40);
			this.btnAddCancel.TabIndex = 12;
			this.btnAddCancel.Text = "Cancel";
			this.btnAddCancel.UseVisualStyleBackColor = true;
			this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
			// 
			// btnSaveService
			// 
			this.btnSaveService.Location = new System.Drawing.Point(23, 235);
			this.btnSaveService.Name = "btnSaveService";
			this.btnSaveService.Size = new System.Drawing.Size(120, 40);
			this.btnSaveService.TabIndex = 11;
			this.btnSaveService.Text = "Save Service";
			this.btnSaveService.UseVisualStyleBackColor = true;
			this.btnSaveService.Click += new System.EventHandler(this.btnSaveService_Click);
			// 
			// lblAddServiceDate
			// 
			this.lblAddServiceDate.AutoSize = true;
			this.lblAddServiceDate.Location = new System.Drawing.Point(42, 184);
			this.lblAddServiceDate.Name = "lblAddServiceDate";
			this.lblAddServiceDate.Size = new System.Drawing.Size(72, 13);
			this.lblAddServiceDate.TabIndex = 10;
			this.lblAddServiceDate.Text = "Service Date:";
			// 
			// lblAddHours
			// 
			this.lblAddHours.AutoSize = true;
			this.lblAddHours.Location = new System.Drawing.Point(42, 138);
			this.lblAddHours.Name = "lblAddHours";
			this.lblAddHours.Size = new System.Drawing.Size(38, 13);
			this.lblAddHours.TabIndex = 9;
			this.lblAddHours.Text = "Hours:";
			// 
			// lblAddServiceType
			// 
			this.lblAddServiceType.AutoSize = true;
			this.lblAddServiceType.Location = new System.Drawing.Point(42, 92);
			this.lblAddServiceType.Name = "lblAddServiceType";
			this.lblAddServiceType.Size = new System.Drawing.Size(73, 13);
			this.lblAddServiceType.TabIndex = 8;
			this.lblAddServiceType.Text = "Service Type:";
			// 
			// lblAddVehicle
			// 
			this.lblAddVehicle.AutoSize = true;
			this.lblAddVehicle.Location = new System.Drawing.Point(42, 46);
			this.lblAddVehicle.Name = "lblAddVehicle";
			this.lblAddVehicle.Size = new System.Drawing.Size(45, 13);
			this.lblAddVehicle.TabIndex = 7;
			this.lblAddVehicle.Text = "Vehicle:";
			// 
			// dtpServiceDate
			// 
			this.dtpServiceDate.Location = new System.Drawing.Point(164, 179);
			this.dtpServiceDate.Name = "dtpServiceDate";
			this.dtpServiceDate.Size = new System.Drawing.Size(200, 20);
			this.dtpServiceDate.TabIndex = 6;
			// 
			// cboAddServiceTypeID
			// 
			this.cboAddServiceTypeID.FormattingEnabled = true;
			this.cboAddServiceTypeID.Location = new System.Drawing.Point(164, 90);
			this.cboAddServiceTypeID.Name = "cboAddServiceTypeID";
			this.cboAddServiceTypeID.Size = new System.Drawing.Size(65, 21);
			this.cboAddServiceTypeID.TabIndex = 5;
			this.cboAddServiceTypeID.SelectedIndexChanged += new System.EventHandler(this.cboAddServiceTypeID_SelectedIndexChanged);
			// 
			// cboAddVehicleID
			// 
			this.cboAddVehicleID.FormattingEnabled = true;
			this.cboAddVehicleID.Location = new System.Drawing.Point(164, 43);
			this.cboAddVehicleID.Name = "cboAddVehicleID";
			this.cboAddVehicleID.Size = new System.Drawing.Size(65, 21);
			this.cboAddVehicleID.TabIndex = 4;
			this.cboAddVehicleID.SelectedIndexChanged += new System.EventHandler(this.cboAddVehicleID_SelectedIndexChanged);
			// 
			// txtAddHours
			// 
			this.txtAddHours.Location = new System.Drawing.Point(164, 136);
			this.txtAddHours.Name = "txtAddHours";
			this.txtAddHours.Size = new System.Drawing.Size(100, 20);
			this.txtAddHours.TabIndex = 3;
			// 
			// cboAddServiceTypeDescription
			// 
			this.cboAddServiceTypeDescription.FormattingEnabled = true;
			this.cboAddServiceTypeDescription.Location = new System.Drawing.Point(250, 90);
			this.cboAddServiceTypeDescription.Name = "cboAddServiceTypeDescription";
			this.cboAddServiceTypeDescription.Size = new System.Drawing.Size(121, 21);
			this.cboAddServiceTypeDescription.TabIndex = 1;
			this.cboAddServiceTypeDescription.SelectedIndexChanged += new System.EventHandler(this.cboAddServiceTypeDescription_SelectedIndexChanged);
			this.cboAddServiceTypeDescription.TextChanged += new System.EventHandler(this.cboAddServiceTypeDescription_TextChanged);
			this.cboAddServiceTypeDescription.Click += new System.EventHandler(this.cboAddServiceTypeDescription_Click);
			// 
			// cboAddVehiclePlateNumber
			// 
			this.cboAddVehiclePlateNumber.FormattingEnabled = true;
			this.cboAddVehiclePlateNumber.Location = new System.Drawing.Point(250, 43);
			this.cboAddVehiclePlateNumber.Name = "cboAddVehiclePlateNumber";
			this.cboAddVehiclePlateNumber.Size = new System.Drawing.Size(121, 21);
			this.cboAddVehiclePlateNumber.TabIndex = 0;
			this.cboAddVehiclePlateNumber.SelectedIndexChanged += new System.EventHandler(this.cboAddVehiclePlateNumber_SelectedIndexChanged);
			// 
			// ServiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 493);
			this.Controls.Add(this.pnlAddService);
			this.Controls.Add(this.lblPlateNumber);
			this.Controls.Add(this.lblOwnerName);
			this.Controls.Add(this.lblServiceType);
			this.Controls.Add(this.lblHourlyRate);
			this.Controls.Add(this.txtPlateNumber);
			this.Controls.Add(this.txtOwnerName);
			this.Controls.Add(this.txtServiceType);
			this.Controls.Add(this.txtHourlyRate);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnMarkServiceAsPaid);
			this.Controls.Add(this.btnDeleteService);
			this.Controls.Add(this.btnUpdateService);
			this.Controls.Add(this.btnAddService);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.dgvService);
			this.Controls.Add(this.pnlGetData);
			this.Name = "ServiceForm";
			this.Text = "Service Form";
			this.TextChanged += new System.EventHandler(this.ServiceForm_TextChanged);
			((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
			this.pnlGetData.ResumeLayout(false);
			this.pnlGetData.PerformLayout();
			this.pnlAddService.ResumeLayout(false);
			this.pnlAddService.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvService;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnAddService;
		private System.Windows.Forms.Button btnUpdateService;
		private System.Windows.Forms.Button btnDeleteService;
		private System.Windows.Forms.Button btnMarkServiceAsPaid;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.TextBox txtHourlyRate;
		private System.Windows.Forms.TextBox txtServiceType;
		private System.Windows.Forms.TextBox txtOwnerName;
		private System.Windows.Forms.TextBox txtPlateNumber;
		private System.Windows.Forms.Label lblHourlyRate;
		private System.Windows.Forms.Label lblServiceType;
		private System.Windows.Forms.Label lblOwnerName;
		private System.Windows.Forms.Label lblPlateNumber;
		private System.Windows.Forms.Panel pnlGetData;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.TextBox txtServiceDate;
		private System.Windows.Forms.TextBox txtHours;
		private System.Windows.Forms.TextBox txtServiceTypeID;
		private System.Windows.Forms.TextBox txtVehicleID;
		private System.Windows.Forms.Panel pnlAddService;
		private System.Windows.Forms.TextBox txtAddHours;
		private System.Windows.Forms.ComboBox cboAddServiceTypeDescription;
		private System.Windows.Forms.ComboBox cboAddVehiclePlateNumber;
		private System.Windows.Forms.ComboBox cboAddServiceTypeID;
		private System.Windows.Forms.ComboBox cboAddVehicleID;
		private System.Windows.Forms.Button btnAddCancel;
		private System.Windows.Forms.Button btnSaveService;
		private System.Windows.Forms.Label lblAddServiceDate;
		private System.Windows.Forms.Label lblAddHours;
		private System.Windows.Forms.Label lblAddServiceType;
		private System.Windows.Forms.Label lblAddVehicle;
		private System.Windows.Forms.DateTimePicker dtpServiceDate;
	}
}