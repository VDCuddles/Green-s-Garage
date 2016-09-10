namespace Greens_Garage
{
	partial class ServiceTypeForm
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
			this.lstServiceType = new System.Windows.Forms.ListBox();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnAddServiceType = new System.Windows.Forms.Button();
			this.btnUpdateServiceType = new System.Windows.Forms.Button();
			this.btnDeleteServiceType = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.lblServiceTypeNo = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblHourlyRate = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtHourlyRate = new System.Windows.Forms.TextBox();
			this.lblServiceTypeID = new System.Windows.Forms.Label();
			this.pnlAddServiceType = new System.Windows.Forms.Panel();
			this.btnAddCancel = new System.Windows.Forms.Button();
			this.btnSaveServiceType = new System.Windows.Forms.Button();
			this.txtAddHourlyRate = new System.Windows.Forms.TextBox();
			this.txtAddDescription = new System.Windows.Forms.TextBox();
			this.lblAddHourlyRate = new System.Windows.Forms.Label();
			this.lblAddDescription = new System.Windows.Forms.Label();
			this.pnlUpdateServiceType = new System.Windows.Forms.Panel();
			this.txtUpdateHourlyRate = new System.Windows.Forms.TextBox();
			this.txtUpdateDescription = new System.Windows.Forms.TextBox();
			this.lblUpdateServiceTypeID = new System.Windows.Forms.Label();
			this.lblUpdateServiceTypeNo = new System.Windows.Forms.Label();
			this.lblUpdateDescription = new System.Windows.Forms.Label();
			this.lblUpdateHourlyRate = new System.Windows.Forms.Label();
			this.btnUpdateCancel = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.pnlAddServiceType.SuspendLayout();
			this.pnlUpdateServiceType.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstServiceType
			// 
			this.lstServiceType.FormattingEnabled = true;
			this.lstServiceType.Location = new System.Drawing.Point(45, 43);
			this.lstServiceType.Name = "lstServiceType";
			this.lstServiceType.Size = new System.Drawing.Size(275, 277);
			this.lstServiceType.TabIndex = 0;
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
			// btnAddServiceType
			// 
			this.btnAddServiceType.Location = new System.Drawing.Point(362, 355);
			this.btnAddServiceType.Name = "btnAddServiceType";
			this.btnAddServiceType.Size = new System.Drawing.Size(120, 40);
			this.btnAddServiceType.TabIndex = 3;
			this.btnAddServiceType.Text = "Add Service Type";
			this.btnAddServiceType.UseVisualStyleBackColor = true;
			this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
			// 
			// btnUpdateServiceType
			// 
			this.btnUpdateServiceType.Location = new System.Drawing.Point(523, 355);
			this.btnUpdateServiceType.Name = "btnUpdateServiceType";
			this.btnUpdateServiceType.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateServiceType.TabIndex = 4;
			this.btnUpdateServiceType.Text = "Update Service Type";
			this.btnUpdateServiceType.UseVisualStyleBackColor = true;
			this.btnUpdateServiceType.Click += new System.EventHandler(this.btnUpdateServiceType_Click);
			// 
			// btnDeleteServiceType
			// 
			this.btnDeleteServiceType.Location = new System.Drawing.Point(680, 355);
			this.btnDeleteServiceType.Name = "btnDeleteServiceType";
			this.btnDeleteServiceType.Size = new System.Drawing.Size(120, 40);
			this.btnDeleteServiceType.TabIndex = 5;
			this.btnDeleteServiceType.Text = "Delete Service Type";
			this.btnDeleteServiceType.UseVisualStyleBackColor = true;
			this.btnDeleteServiceType.Click += new System.EventHandler(this.btnDeleteServiceType_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(680, 419);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(120, 40);
			this.btnReturn.TabIndex = 6;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// lblServiceTypeNo
			// 
			this.lblServiceTypeNo.AutoSize = true;
			this.lblServiceTypeNo.Location = new System.Drawing.Point(396, 126);
			this.lblServiceTypeNo.Name = "lblServiceTypeNo";
			this.lblServiceTypeNo.Size = new System.Drawing.Size(87, 13);
			this.lblServiceTypeNo.TabIndex = 7;
			this.lblServiceTypeNo.Text = "Service Type ID:";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(396, 166);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 8;
			this.lblDescription.Text = "Description:";
			// 
			// lblHourlyRate
			// 
			this.lblHourlyRate.AutoSize = true;
			this.lblHourlyRate.Location = new System.Drawing.Point(396, 206);
			this.lblHourlyRate.Name = "lblHourlyRate";
			this.lblHourlyRate.Size = new System.Drawing.Size(66, 13);
			this.lblHourlyRate.TabIndex = 9;
			this.lblHourlyRate.Text = "Hourly Rate:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(523, 163);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(277, 20);
			this.txtDescription.TabIndex = 11;
			// 
			// txtHourlyRate
			// 
			this.txtHourlyRate.Location = new System.Drawing.Point(523, 203);
			this.txtHourlyRate.Name = "txtHourlyRate";
			this.txtHourlyRate.Size = new System.Drawing.Size(100, 20);
			this.txtHourlyRate.TabIndex = 12;
			// 
			// lblServiceTypeID
			// 
			this.lblServiceTypeID.AutoSize = true;
			this.lblServiceTypeID.Location = new System.Drawing.Point(520, 126);
			this.lblServiceTypeID.Name = "lblServiceTypeID";
			this.lblServiceTypeID.Size = new System.Drawing.Size(23, 13);
			this.lblServiceTypeID.TabIndex = 13;
			this.lblServiceTypeID.Text = "null";
			// 
			// pnlAddServiceType
			// 
			this.pnlAddServiceType.Controls.Add(this.btnAddCancel);
			this.pnlAddServiceType.Controls.Add(this.btnSaveServiceType);
			this.pnlAddServiceType.Controls.Add(this.txtAddHourlyRate);
			this.pnlAddServiceType.Controls.Add(this.txtAddDescription);
			this.pnlAddServiceType.Controls.Add(this.lblAddHourlyRate);
			this.pnlAddServiceType.Controls.Add(this.lblAddDescription);
			this.pnlAddServiceType.Location = new System.Drawing.Point(369, 96);
			this.pnlAddServiceType.Name = "pnlAddServiceType";
			this.pnlAddServiceType.Size = new System.Drawing.Size(431, 160);
			this.pnlAddServiceType.TabIndex = 14;
			this.pnlAddServiceType.Visible = false;
			// 
			// btnAddCancel
			// 
			this.btnAddCancel.Location = new System.Drawing.Point(283, 107);
			this.btnAddCancel.Name = "btnAddCancel";
			this.btnAddCancel.Size = new System.Drawing.Size(120, 40);
			this.btnAddCancel.TabIndex = 5;
			this.btnAddCancel.Text = "Cancel";
			this.btnAddCancel.UseVisualStyleBackColor = true;
			this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
			// 
			// btnSaveServiceType
			// 
			this.btnSaveServiceType.Location = new System.Drawing.Point(30, 107);
			this.btnSaveServiceType.Name = "btnSaveServiceType";
			this.btnSaveServiceType.Size = new System.Drawing.Size(120, 40);
			this.btnSaveServiceType.TabIndex = 4;
			this.btnSaveServiceType.Text = "Save Service Type";
			this.btnSaveServiceType.UseVisualStyleBackColor = true;
			this.btnSaveServiceType.Click += new System.EventHandler(this.btnSaveServiceType_Click);
			// 
			// txtAddHourlyRate
			// 
			this.txtAddHourlyRate.Location = new System.Drawing.Point(120, 59);
			this.txtAddHourlyRate.Name = "txtAddHourlyRate";
			this.txtAddHourlyRate.Size = new System.Drawing.Size(111, 20);
			this.txtAddHourlyRate.TabIndex = 3;
			// 
			// txtAddDescription
			// 
			this.txtAddDescription.Location = new System.Drawing.Point(120, 27);
			this.txtAddDescription.Name = "txtAddDescription";
			this.txtAddDescription.Size = new System.Drawing.Size(283, 20);
			this.txtAddDescription.TabIndex = 2;
			// 
			// lblAddHourlyRate
			// 
			this.lblAddHourlyRate.AutoSize = true;
			this.lblAddHourlyRate.Location = new System.Drawing.Point(36, 62);
			this.lblAddHourlyRate.Name = "lblAddHourlyRate";
			this.lblAddHourlyRate.Size = new System.Drawing.Size(66, 13);
			this.lblAddHourlyRate.TabIndex = 1;
			this.lblAddHourlyRate.Text = "Hourly Rate:";
			// 
			// lblAddDescription
			// 
			this.lblAddDescription.AutoSize = true;
			this.lblAddDescription.Location = new System.Drawing.Point(39, 30);
			this.lblAddDescription.Name = "lblAddDescription";
			this.lblAddDescription.Size = new System.Drawing.Size(63, 13);
			this.lblAddDescription.TabIndex = 0;
			this.lblAddDescription.Text = "Description:";
			// 
			// pnlUpdateServiceType
			// 
			this.pnlUpdateServiceType.Controls.Add(this.txtUpdateHourlyRate);
			this.pnlUpdateServiceType.Controls.Add(this.txtUpdateDescription);
			this.pnlUpdateServiceType.Controls.Add(this.lblUpdateServiceTypeID);
			this.pnlUpdateServiceType.Controls.Add(this.lblUpdateServiceTypeNo);
			this.pnlUpdateServiceType.Controls.Add(this.lblUpdateDescription);
			this.pnlUpdateServiceType.Controls.Add(this.lblUpdateHourlyRate);
			this.pnlUpdateServiceType.Controls.Add(this.btnUpdateCancel);
			this.pnlUpdateServiceType.Controls.Add(this.btnSaveChanges);
			this.pnlUpdateServiceType.Location = new System.Drawing.Point(12, 174);
			this.pnlUpdateServiceType.Name = "pnlUpdateServiceType";
			this.pnlUpdateServiceType.Size = new System.Drawing.Size(431, 159);
			this.pnlUpdateServiceType.TabIndex = 15;
			this.pnlUpdateServiceType.Visible = false;
			// 
			// txtUpdateHourlyRate
			// 
			this.txtUpdateHourlyRate.Location = new System.Drawing.Point(120, 78);
			this.txtUpdateHourlyRate.Name = "txtUpdateHourlyRate";
			this.txtUpdateHourlyRate.Size = new System.Drawing.Size(100, 20);
			this.txtUpdateHourlyRate.TabIndex = 7;
			// 
			// txtUpdateDescription
			// 
			this.txtUpdateDescription.Location = new System.Drawing.Point(120, 45);
			this.txtUpdateDescription.Name = "txtUpdateDescription";
			this.txtUpdateDescription.Size = new System.Drawing.Size(100, 20);
			this.txtUpdateDescription.TabIndex = 6;
			// 
			// lblUpdateServiceTypeID
			// 
			this.lblUpdateServiceTypeID.AutoSize = true;
			this.lblUpdateServiceTypeID.Location = new System.Drawing.Point(117, 16);
			this.lblUpdateServiceTypeID.Name = "lblUpdateServiceTypeID";
			this.lblUpdateServiceTypeID.Size = new System.Drawing.Size(23, 13);
			this.lblUpdateServiceTypeID.TabIndex = 5;
			this.lblUpdateServiceTypeID.Text = "null";
			// 
			// lblUpdateServiceTypeNo
			// 
			this.lblUpdateServiceTypeNo.AutoSize = true;
			this.lblUpdateServiceTypeNo.Location = new System.Drawing.Point(27, 16);
			this.lblUpdateServiceTypeNo.Name = "lblUpdateServiceTypeNo";
			this.lblUpdateServiceTypeNo.Size = new System.Drawing.Size(87, 13);
			this.lblUpdateServiceTypeNo.TabIndex = 4;
			this.lblUpdateServiceTypeNo.Text = "Service Type ID:";
			// 
			// lblUpdateDescription
			// 
			this.lblUpdateDescription.AutoSize = true;
			this.lblUpdateDescription.Location = new System.Drawing.Point(51, 48);
			this.lblUpdateDescription.Name = "lblUpdateDescription";
			this.lblUpdateDescription.Size = new System.Drawing.Size(63, 13);
			this.lblUpdateDescription.TabIndex = 3;
			this.lblUpdateDescription.Text = "Description:";
			// 
			// lblUpdateHourlyRate
			// 
			this.lblUpdateHourlyRate.AutoSize = true;
			this.lblUpdateHourlyRate.Location = new System.Drawing.Point(48, 81);
			this.lblUpdateHourlyRate.Name = "lblUpdateHourlyRate";
			this.lblUpdateHourlyRate.Size = new System.Drawing.Size(66, 13);
			this.lblUpdateHourlyRate.TabIndex = 2;
			this.lblUpdateHourlyRate.Text = "Hourly Rate:";
			// 
			// btnUpdateCancel
			// 
			this.btnUpdateCancel.Location = new System.Drawing.Point(283, 106);
			this.btnUpdateCancel.Name = "btnUpdateCancel";
			this.btnUpdateCancel.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateCancel.TabIndex = 1;
			this.btnUpdateCancel.Text = "Cancel";
			this.btnUpdateCancel.UseVisualStyleBackColor = true;
			this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(28, 106);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(120, 40);
			this.btnSaveChanges.TabIndex = 0;
			this.btnSaveChanges.Text = "Save Changes";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// ServiceTypeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 493);
			this.Controls.Add(this.pnlUpdateServiceType);
			this.Controls.Add(this.pnlAddServiceType);
			this.Controls.Add(this.lblServiceTypeID);
			this.Controls.Add(this.txtHourlyRate);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblHourlyRate);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblServiceTypeNo);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnDeleteServiceType);
			this.Controls.Add(this.btnUpdateServiceType);
			this.Controls.Add(this.btnAddServiceType);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.lstServiceType);
			this.Name = "ServiceTypeForm";
			this.Text = "Service Type Form";
			this.pnlAddServiceType.ResumeLayout(false);
			this.pnlAddServiceType.PerformLayout();
			this.pnlUpdateServiceType.ResumeLayout(false);
			this.pnlUpdateServiceType.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstServiceType;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnAddServiceType;
		private System.Windows.Forms.Button btnUpdateServiceType;
		private System.Windows.Forms.Button btnDeleteServiceType;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label lblServiceTypeNo;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblHourlyRate;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtHourlyRate;
		private System.Windows.Forms.Label lblServiceTypeID;
		private System.Windows.Forms.Panel pnlAddServiceType;
		private System.Windows.Forms.Button btnAddCancel;
		private System.Windows.Forms.Button btnSaveServiceType;
		private System.Windows.Forms.TextBox txtAddHourlyRate;
		private System.Windows.Forms.TextBox txtAddDescription;
		private System.Windows.Forms.Label lblAddHourlyRate;
		private System.Windows.Forms.Label lblAddDescription;
		private System.Windows.Forms.Panel pnlUpdateServiceType;
		private System.Windows.Forms.TextBox txtUpdateHourlyRate;
		private System.Windows.Forms.TextBox txtUpdateDescription;
		private System.Windows.Forms.Label lblUpdateServiceTypeID;
		private System.Windows.Forms.Label lblUpdateServiceTypeNo;
		private System.Windows.Forms.Label lblUpdateDescription;
		private System.Windows.Forms.Label lblUpdateHourlyRate;
		private System.Windows.Forms.Button btnUpdateCancel;
		private System.Windows.Forms.Button btnSaveChanges;
	}
}