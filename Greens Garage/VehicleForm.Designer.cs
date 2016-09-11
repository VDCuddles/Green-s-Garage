namespace Greens_Garage
{
	partial class VehicleForm
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
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnAddVehicle = new System.Windows.Forms.Button();
			this.btnUpdateVehicle = new System.Windows.Forms.Button();
			this.btnDeleteVehicle = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.lstVehicle = new System.Windows.Forms.ListBox();
			this.lblVehicleNo = new System.Windows.Forms.Label();
			this.lblPlateNumber = new System.Windows.Forms.Label();
			this.lblMake = new System.Windows.Forms.Label();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblOwnerNo = new System.Windows.Forms.Label();
			this.lblOwnerName = new System.Windows.Forms.Label();
			this.lblVehicleID = new System.Windows.Forms.Label();
			this.txtPlateNumber = new System.Windows.Forms.TextBox();
			this.txtMake = new System.Windows.Forms.TextBox();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.txtOwnerID = new System.Windows.Forms.TextBox();
			this.txtOwnerName = new System.Windows.Forms.TextBox();
			this.pnlAddVehicle = new System.Windows.Forms.Panel();
			this.cboAddOwnerName = new System.Windows.Forms.ComboBox();
			this.cboAddOwnerID = new System.Windows.Forms.ComboBox();
			this.txtAddModel = new System.Windows.Forms.TextBox();
			this.txtAddMake = new System.Windows.Forms.TextBox();
			this.txtAddPlateNumber = new System.Windows.Forms.TextBox();
			this.lblAddVehicleID = new System.Windows.Forms.Label();
			this.lblAddOwner = new System.Windows.Forms.Label();
			this.lblAddModel = new System.Windows.Forms.Label();
			this.lblAddMake = new System.Windows.Forms.Label();
			this.lblAddPlateNumber = new System.Windows.Forms.Label();
			this.lblAddVehicleNo = new System.Windows.Forms.Label();
			this.btnAddCancel = new System.Windows.Forms.Button();
			this.btnSaveVehicle = new System.Windows.Forms.Button();
			this.pnlUpdateVehicle = new System.Windows.Forms.Panel();
			this.txtUpdatePlateNumber = new System.Windows.Forms.TextBox();
			this.txtUpdateMake = new System.Windows.Forms.TextBox();
			this.txtUpdateModel = new System.Windows.Forms.TextBox();
			this.txtUpdateOwnerName = new System.Windows.Forms.TextBox();
			this.btnUpdateCancel = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.lblUpdateOwnerName = new System.Windows.Forms.Label();
			this.lblUpdateModel = new System.Windows.Forms.Label();
			this.lblUpdateMake = new System.Windows.Forms.Label();
			this.lblUpdatePlateNumber = new System.Windows.Forms.Label();
			this.lblUpdateVehicleID = new System.Windows.Forms.Label();
			this.lblUpdateVehicleNo = new System.Windows.Forms.Label();
			this.pnlAddVehicle.SuspendLayout();
			this.pnlUpdateVehicle.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(45, 355);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(120, 40);
			this.btnPrevious.TabIndex = 0;
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(203, 355);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(120, 40);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnAddVehicle
			// 
			this.btnAddVehicle.Location = new System.Drawing.Point(362, 355);
			this.btnAddVehicle.Name = "btnAddVehicle";
			this.btnAddVehicle.Size = new System.Drawing.Size(120, 40);
			this.btnAddVehicle.TabIndex = 2;
			this.btnAddVehicle.Text = "Add Vehicle";
			this.btnAddVehicle.UseVisualStyleBackColor = true;
			this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
			// 
			// btnUpdateVehicle
			// 
			this.btnUpdateVehicle.Location = new System.Drawing.Point(523, 355);
			this.btnUpdateVehicle.Name = "btnUpdateVehicle";
			this.btnUpdateVehicle.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateVehicle.TabIndex = 3;
			this.btnUpdateVehicle.Text = "Update Vehicle";
			this.btnUpdateVehicle.UseVisualStyleBackColor = true;
			this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
			// 
			// btnDeleteVehicle
			// 
			this.btnDeleteVehicle.Location = new System.Drawing.Point(680, 355);
			this.btnDeleteVehicle.Name = "btnDeleteVehicle";
			this.btnDeleteVehicle.Size = new System.Drawing.Size(120, 40);
			this.btnDeleteVehicle.TabIndex = 4;
			this.btnDeleteVehicle.Text = "Delete Vehicle";
			this.btnDeleteVehicle.UseVisualStyleBackColor = true;
			this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(680, 419);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(120, 40);
			this.btnReturn.TabIndex = 5;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// lstVehicle
			// 
			this.lstVehicle.FormattingEnabled = true;
			this.lstVehicle.Location = new System.Drawing.Point(45, 43);
			this.lstVehicle.Name = "lstVehicle";
			this.lstVehicle.Size = new System.Drawing.Size(275, 277);
			this.lstVehicle.TabIndex = 6;
			this.lstVehicle.Click += new System.EventHandler(this.lstVehicle_Click);
			this.lstVehicle.SelectedIndexChanged += new System.EventHandler(this.lstVehicle_SelectedIndexChanged);
			// 
			// lblVehicleNo
			// 
			this.lblVehicleNo.AutoSize = true;
			this.lblVehicleNo.Location = new System.Drawing.Point(389, 78);
			this.lblVehicleNo.Name = "lblVehicleNo";
			this.lblVehicleNo.Size = new System.Drawing.Size(59, 13);
			this.lblVehicleNo.TabIndex = 7;
			this.lblVehicleNo.Text = "Vehicle ID:";
			// 
			// lblPlateNumber
			// 
			this.lblPlateNumber.AutoSize = true;
			this.lblPlateNumber.Location = new System.Drawing.Point(375, 116);
			this.lblPlateNumber.Name = "lblPlateNumber";
			this.lblPlateNumber.Size = new System.Drawing.Size(74, 13);
			this.lblPlateNumber.TabIndex = 8;
			this.lblPlateNumber.Text = "Plate Number:";
			// 
			// lblMake
			// 
			this.lblMake.AutoSize = true;
			this.lblMake.Location = new System.Drawing.Point(410, 156);
			this.lblMake.Name = "lblMake";
			this.lblMake.Size = new System.Drawing.Size(37, 13);
			this.lblMake.TabIndex = 9;
			this.lblMake.Text = "Make:";
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Location = new System.Drawing.Point(409, 197);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(39, 13);
			this.lblModel.TabIndex = 10;
			this.lblModel.Text = "Model:";
			// 
			// lblOwnerNo
			// 
			this.lblOwnerNo.AutoSize = true;
			this.lblOwnerNo.Location = new System.Drawing.Point(393, 237);
			this.lblOwnerNo.Name = "lblOwnerNo";
			this.lblOwnerNo.Size = new System.Drawing.Size(55, 13);
			this.lblOwnerNo.TabIndex = 11;
			this.lblOwnerNo.Text = "Owner ID:";
			// 
			// lblOwnerName
			// 
			this.lblOwnerName.AutoSize = true;
			this.lblOwnerName.Location = new System.Drawing.Point(376, 276);
			this.lblOwnerName.Name = "lblOwnerName";
			this.lblOwnerName.Size = new System.Drawing.Size(72, 13);
			this.lblOwnerName.TabIndex = 12;
			this.lblOwnerName.Text = "Owner Name:";
			// 
			// lblVehicleID
			// 
			this.lblVehicleID.AutoSize = true;
			this.lblVehicleID.Location = new System.Drawing.Point(470, 78);
			this.lblVehicleID.Name = "lblVehicleID";
			this.lblVehicleID.Size = new System.Drawing.Size(23, 13);
			this.lblVehicleID.TabIndex = 13;
			this.lblVehicleID.Text = "null";
			// 
			// txtPlateNumber
			// 
			this.txtPlateNumber.Location = new System.Drawing.Point(473, 113);
			this.txtPlateNumber.Name = "txtPlateNumber";
			this.txtPlateNumber.Size = new System.Drawing.Size(129, 20);
			this.txtPlateNumber.TabIndex = 14;
			// 
			// txtMake
			// 
			this.txtMake.Location = new System.Drawing.Point(473, 153);
			this.txtMake.Name = "txtMake";
			this.txtMake.Size = new System.Drawing.Size(327, 20);
			this.txtMake.TabIndex = 15;
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(473, 194);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(327, 20);
			this.txtModel.TabIndex = 16;
			// 
			// txtOwnerID
			// 
			this.txtOwnerID.Location = new System.Drawing.Point(473, 234);
			this.txtOwnerID.Name = "txtOwnerID";
			this.txtOwnerID.Size = new System.Drawing.Size(63, 20);
			this.txtOwnerID.TabIndex = 17;
			// 
			// txtOwnerName
			// 
			this.txtOwnerName.Location = new System.Drawing.Point(473, 273);
			this.txtOwnerName.Name = "txtOwnerName";
			this.txtOwnerName.Size = new System.Drawing.Size(327, 20);
			this.txtOwnerName.TabIndex = 18;
			// 
			// pnlAddVehicle
			// 
			this.pnlAddVehicle.Controls.Add(this.cboAddOwnerName);
			this.pnlAddVehicle.Controls.Add(this.cboAddOwnerID);
			this.pnlAddVehicle.Controls.Add(this.txtAddModel);
			this.pnlAddVehicle.Controls.Add(this.txtAddMake);
			this.pnlAddVehicle.Controls.Add(this.txtAddPlateNumber);
			this.pnlAddVehicle.Controls.Add(this.lblAddVehicleID);
			this.pnlAddVehicle.Controls.Add(this.lblAddOwner);
			this.pnlAddVehicle.Controls.Add(this.lblAddModel);
			this.pnlAddVehicle.Controls.Add(this.lblAddMake);
			this.pnlAddVehicle.Controls.Add(this.lblAddPlateNumber);
			this.pnlAddVehicle.Controls.Add(this.lblAddVehicleNo);
			this.pnlAddVehicle.Controls.Add(this.btnAddCancel);
			this.pnlAddVehicle.Controls.Add(this.btnSaveVehicle);
			this.pnlAddVehicle.Location = new System.Drawing.Point(29, 197);
			this.pnlAddVehicle.Name = "pnlAddVehicle";
			this.pnlAddVehicle.Size = new System.Drawing.Size(438, 277);
			this.pnlAddVehicle.TabIndex = 19;
			this.pnlAddVehicle.Visible = false;
			// 
			// cboAddOwnerName
			// 
			this.cboAddOwnerName.FormattingEnabled = true;
			this.cboAddOwnerName.Location = new System.Drawing.Point(223, 175);
			this.cboAddOwnerName.Name = "cboAddOwnerName";
			this.cboAddOwnerName.Size = new System.Drawing.Size(162, 21);
			this.cboAddOwnerName.TabIndex = 13;
			// 
			// cboAddOwnerID
			// 
			this.cboAddOwnerID.FormattingEnabled = true;
			this.cboAddOwnerID.Location = new System.Drawing.Point(120, 175);
			this.cboAddOwnerID.Name = "cboAddOwnerID";
			this.cboAddOwnerID.Size = new System.Drawing.Size(85, 21);
			this.cboAddOwnerID.TabIndex = 12;
			// 
			// txtAddModel
			// 
			this.txtAddModel.Location = new System.Drawing.Point(120, 140);
			this.txtAddModel.Name = "txtAddModel";
			this.txtAddModel.Size = new System.Drawing.Size(265, 20);
			this.txtAddModel.TabIndex = 11;
			// 
			// txtAddMake
			// 
			this.txtAddMake.Location = new System.Drawing.Point(120, 103);
			this.txtAddMake.Name = "txtAddMake";
			this.txtAddMake.Size = new System.Drawing.Size(265, 20);
			this.txtAddMake.TabIndex = 10;
			// 
			// txtAddPlateNumber
			// 
			this.txtAddPlateNumber.Location = new System.Drawing.Point(120, 65);
			this.txtAddPlateNumber.Name = "txtAddPlateNumber";
			this.txtAddPlateNumber.Size = new System.Drawing.Size(120, 20);
			this.txtAddPlateNumber.TabIndex = 8;
			// 
			// lblAddVehicleID
			// 
			this.lblAddVehicleID.AutoSize = true;
			this.lblAddVehicleID.Location = new System.Drawing.Point(119, 33);
			this.lblAddVehicleID.Name = "lblAddVehicleID";
			this.lblAddVehicleID.Size = new System.Drawing.Size(23, 13);
			this.lblAddVehicleID.TabIndex = 7;
			this.lblAddVehicleID.Text = "null";
			// 
			// lblAddOwner
			// 
			this.lblAddOwner.AutoSize = true;
			this.lblAddOwner.Location = new System.Drawing.Point(43, 181);
			this.lblAddOwner.Name = "lblAddOwner";
			this.lblAddOwner.Size = new System.Drawing.Size(41, 13);
			this.lblAddOwner.TabIndex = 6;
			this.lblAddOwner.Text = "Owner:";
			// 
			// lblAddModel
			// 
			this.lblAddModel.AutoSize = true;
			this.lblAddModel.Location = new System.Drawing.Point(42, 143);
			this.lblAddModel.Name = "lblAddModel";
			this.lblAddModel.Size = new System.Drawing.Size(39, 13);
			this.lblAddModel.TabIndex = 5;
			this.lblAddModel.Text = "Model:";
			// 
			// lblAddMake
			// 
			this.lblAddMake.AutoSize = true;
			this.lblAddMake.Location = new System.Drawing.Point(43, 106);
			this.lblAddMake.Name = "lblAddMake";
			this.lblAddMake.Size = new System.Drawing.Size(37, 13);
			this.lblAddMake.TabIndex = 4;
			this.lblAddMake.Text = "Make:";
			// 
			// lblAddPlateNumber
			// 
			this.lblAddPlateNumber.AutoSize = true;
			this.lblAddPlateNumber.Location = new System.Drawing.Point(43, 68);
			this.lblAddPlateNumber.Name = "lblAddPlateNumber";
			this.lblAddPlateNumber.Size = new System.Drawing.Size(74, 13);
			this.lblAddPlateNumber.TabIndex = 3;
			this.lblAddPlateNumber.Text = "Plate Number:";
			// 
			// lblAddVehicleNo
			// 
			this.lblAddVehicleNo.AutoSize = true;
			this.lblAddVehicleNo.Location = new System.Drawing.Point(43, 33);
			this.lblAddVehicleNo.Name = "lblAddVehicleNo";
			this.lblAddVehicleNo.Size = new System.Drawing.Size(59, 13);
			this.lblAddVehicleNo.TabIndex = 2;
			this.lblAddVehicleNo.Text = "Vehicle ID:";
			// 
			// btnAddCancel
			// 
			this.btnAddCancel.Location = new System.Drawing.Point(283, 219);
			this.btnAddCancel.Name = "btnAddCancel";
			this.btnAddCancel.Size = new System.Drawing.Size(120, 40);
			this.btnAddCancel.TabIndex = 1;
			this.btnAddCancel.Text = "Cancel";
			this.btnAddCancel.UseVisualStyleBackColor = true;
			this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
			// 
			// btnSaveVehicle
			// 
			this.btnSaveVehicle.Location = new System.Drawing.Point(34, 219);
			this.btnSaveVehicle.Name = "btnSaveVehicle";
			this.btnSaveVehicle.Size = new System.Drawing.Size(120, 40);
			this.btnSaveVehicle.TabIndex = 0;
			this.btnSaveVehicle.Text = "Save Vehicle";
			this.btnSaveVehicle.UseVisualStyleBackColor = true;
			this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
			// 
			// pnlUpdateVehicle
			// 
			this.pnlUpdateVehicle.Controls.Add(this.txtUpdatePlateNumber);
			this.pnlUpdateVehicle.Controls.Add(this.txtUpdateMake);
			this.pnlUpdateVehicle.Controls.Add(this.txtUpdateModel);
			this.pnlUpdateVehicle.Controls.Add(this.txtUpdateOwnerName);
			this.pnlUpdateVehicle.Controls.Add(this.btnUpdateCancel);
			this.pnlUpdateVehicle.Controls.Add(this.btnSaveChanges);
			this.pnlUpdateVehicle.Controls.Add(this.lblUpdateOwnerName);
			this.pnlUpdateVehicle.Controls.Add(this.lblUpdateModel);
			this.pnlUpdateVehicle.Controls.Add(this.lblUpdateMake);
			this.pnlUpdateVehicle.Controls.Add(this.lblUpdatePlateNumber);
			this.pnlUpdateVehicle.Controls.Add(this.lblUpdateVehicleID);
			this.pnlUpdateVehicle.Controls.Add(this.lblUpdateVehicleNo);
			this.pnlUpdateVehicle.Location = new System.Drawing.Point(362, 43);
			this.pnlUpdateVehicle.Name = "pnlUpdateVehicle";
			this.pnlUpdateVehicle.Size = new System.Drawing.Size(438, 294);
			this.pnlUpdateVehicle.TabIndex = 20;
			this.pnlUpdateVehicle.Visible = false;
			// 
			// txtUpdatePlateNumber
			// 
			this.txtUpdatePlateNumber.Location = new System.Drawing.Point(140, 67);
			this.txtUpdatePlateNumber.Name = "txtUpdatePlateNumber";
			this.txtUpdatePlateNumber.Size = new System.Drawing.Size(125, 20);
			this.txtUpdatePlateNumber.TabIndex = 11;
			// 
			// txtUpdateMake
			// 
			this.txtUpdateMake.Location = new System.Drawing.Point(140, 105);
			this.txtUpdateMake.Name = "txtUpdateMake";
			this.txtUpdateMake.Size = new System.Drawing.Size(222, 20);
			this.txtUpdateMake.TabIndex = 10;
			// 
			// txtUpdateModel
			// 
			this.txtUpdateModel.Location = new System.Drawing.Point(140, 142);
			this.txtUpdateModel.Name = "txtUpdateModel";
			this.txtUpdateModel.Size = new System.Drawing.Size(222, 20);
			this.txtUpdateModel.TabIndex = 9;
			// 
			// txtUpdateOwnerName
			// 
			this.txtUpdateOwnerName.Location = new System.Drawing.Point(140, 182);
			this.txtUpdateOwnerName.Name = "txtUpdateOwnerName";
			this.txtUpdateOwnerName.Size = new System.Drawing.Size(264, 20);
			this.txtUpdateOwnerName.TabIndex = 8;
			// 
			// btnUpdateCancel
			// 
			this.btnUpdateCancel.Location = new System.Drawing.Point(284, 230);
			this.btnUpdateCancel.Name = "btnUpdateCancel";
			this.btnUpdateCancel.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateCancel.TabIndex = 7;
			this.btnUpdateCancel.Text = "Cancel";
			this.btnUpdateCancel.UseVisualStyleBackColor = true;
			this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(34, 230);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(120, 40);
			this.btnSaveChanges.TabIndex = 6;
			this.btnSaveChanges.Text = "Save Changes";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// lblUpdateOwnerName
			// 
			this.lblUpdateOwnerName.AutoSize = true;
			this.lblUpdateOwnerName.Location = new System.Drawing.Point(34, 185);
			this.lblUpdateOwnerName.Name = "lblUpdateOwnerName";
			this.lblUpdateOwnerName.Size = new System.Drawing.Size(72, 13);
			this.lblUpdateOwnerName.TabIndex = 5;
			this.lblUpdateOwnerName.Text = "Owner Name:";
			// 
			// lblUpdateModel
			// 
			this.lblUpdateModel.AutoSize = true;
			this.lblUpdateModel.Location = new System.Drawing.Point(34, 145);
			this.lblUpdateModel.Name = "lblUpdateModel";
			this.lblUpdateModel.Size = new System.Drawing.Size(39, 13);
			this.lblUpdateModel.TabIndex = 4;
			this.lblUpdateModel.Text = "Model:";
			// 
			// lblUpdateMake
			// 
			this.lblUpdateMake.AutoSize = true;
			this.lblUpdateMake.Location = new System.Drawing.Point(34, 108);
			this.lblUpdateMake.Name = "lblUpdateMake";
			this.lblUpdateMake.Size = new System.Drawing.Size(37, 13);
			this.lblUpdateMake.TabIndex = 3;
			this.lblUpdateMake.Text = "Make:";
			// 
			// lblUpdatePlateNumber
			// 
			this.lblUpdatePlateNumber.AutoSize = true;
			this.lblUpdatePlateNumber.Location = new System.Drawing.Point(34, 73);
			this.lblUpdatePlateNumber.Name = "lblUpdatePlateNumber";
			this.lblUpdatePlateNumber.Size = new System.Drawing.Size(74, 13);
			this.lblUpdatePlateNumber.TabIndex = 2;
			this.lblUpdatePlateNumber.Text = "Plate Number:";
			// 
			// lblUpdateVehicleID
			// 
			this.lblUpdateVehicleID.AutoSize = true;
			this.lblUpdateVehicleID.Location = new System.Drawing.Point(137, 38);
			this.lblUpdateVehicleID.Name = "lblUpdateVehicleID";
			this.lblUpdateVehicleID.Size = new System.Drawing.Size(23, 13);
			this.lblUpdateVehicleID.TabIndex = 1;
			this.lblUpdateVehicleID.Text = "null";
			// 
			// lblUpdateVehicleNo
			// 
			this.lblUpdateVehicleNo.AutoSize = true;
			this.lblUpdateVehicleNo.Location = new System.Drawing.Point(34, 38);
			this.lblUpdateVehicleNo.Name = "lblUpdateVehicleNo";
			this.lblUpdateVehicleNo.Size = new System.Drawing.Size(59, 13);
			this.lblUpdateVehicleNo.TabIndex = 0;
			this.lblUpdateVehicleNo.Text = "Vehicle ID:";
			// 
			// VehicleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 493);
			this.Controls.Add(this.pnlUpdateVehicle);
			this.Controls.Add(this.pnlAddVehicle);
			this.Controls.Add(this.txtOwnerName);
			this.Controls.Add(this.txtOwnerID);
			this.Controls.Add(this.txtModel);
			this.Controls.Add(this.txtMake);
			this.Controls.Add(this.txtPlateNumber);
			this.Controls.Add(this.lblVehicleID);
			this.Controls.Add(this.lblOwnerName);
			this.Controls.Add(this.lblOwnerNo);
			this.Controls.Add(this.lblModel);
			this.Controls.Add(this.lblMake);
			this.Controls.Add(this.lblPlateNumber);
			this.Controls.Add(this.lblVehicleNo);
			this.Controls.Add(this.lstVehicle);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnDeleteVehicle);
			this.Controls.Add(this.btnUpdateVehicle);
			this.Controls.Add(this.btnAddVehicle);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Name = "VehicleForm";
			this.Text = "Vehicle Form";
			this.pnlAddVehicle.ResumeLayout(false);
			this.pnlAddVehicle.PerformLayout();
			this.pnlUpdateVehicle.ResumeLayout(false);
			this.pnlUpdateVehicle.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnAddVehicle;
		private System.Windows.Forms.Button btnUpdateVehicle;
		private System.Windows.Forms.Button btnDeleteVehicle;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.ListBox lstVehicle;
		private System.Windows.Forms.Label lblVehicleNo;
		private System.Windows.Forms.Label lblPlateNumber;
		private System.Windows.Forms.Label lblMake;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.Label lblOwnerNo;
		private System.Windows.Forms.Label lblOwnerName;
		private System.Windows.Forms.Label lblVehicleID;
		private System.Windows.Forms.TextBox txtPlateNumber;
		private System.Windows.Forms.TextBox txtMake;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtOwnerID;
		private System.Windows.Forms.TextBox txtOwnerName;
		private System.Windows.Forms.Panel pnlAddVehicle;
		private System.Windows.Forms.Label lblAddOwner;
		private System.Windows.Forms.Label lblAddModel;
		private System.Windows.Forms.Label lblAddMake;
		private System.Windows.Forms.Label lblAddPlateNumber;
		private System.Windows.Forms.Label lblAddVehicleNo;
		private System.Windows.Forms.Button btnAddCancel;
		private System.Windows.Forms.Button btnSaveVehicle;
		private System.Windows.Forms.ComboBox cboAddOwnerName;
		private System.Windows.Forms.ComboBox cboAddOwnerID;
		private System.Windows.Forms.TextBox txtAddModel;
		private System.Windows.Forms.TextBox txtAddMake;
		private System.Windows.Forms.TextBox txtAddPlateNumber;
		private System.Windows.Forms.Label lblAddVehicleID;
		private System.Windows.Forms.Panel pnlUpdateVehicle;
		private System.Windows.Forms.TextBox txtUpdatePlateNumber;
		private System.Windows.Forms.TextBox txtUpdateMake;
		private System.Windows.Forms.TextBox txtUpdateModel;
		private System.Windows.Forms.TextBox txtUpdateOwnerName;
		private System.Windows.Forms.Button btnUpdateCancel;
		private System.Windows.Forms.Button btnSaveChanges;
		private System.Windows.Forms.Label lblUpdateOwnerName;
		private System.Windows.Forms.Label lblUpdateModel;
		private System.Windows.Forms.Label lblUpdateMake;
		private System.Windows.Forms.Label lblUpdatePlateNumber;
		private System.Windows.Forms.Label lblUpdateVehicleID;
		private System.Windows.Forms.Label lblUpdateVehicleNo;
	}
}