namespace Greens_Garage
{
	partial class EquipmentForm
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
			this.btnAddEquipment = new System.Windows.Forms.Button();
			this.btnUpdateEquipment = new System.Windows.Forms.Button();
			this.btnDeleteEquipment = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnEquipmentNo = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblEquipmentID = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lstEquipment = new System.Windows.Forms.ListBox();
			this.pnlAddEquipment = new System.Windows.Forms.Panel();
			this.btnAddCancel = new System.Windows.Forms.Button();
			this.btnSaveEquipment = new System.Windows.Forms.Button();
			this.lblAddDescription = new System.Windows.Forms.Label();
			this.txtAddDescription = new System.Windows.Forms.TextBox();
			this.pnlUpdateEquipment = new System.Windows.Forms.Panel();
			this.lblUpdateEquipmentID = new System.Windows.Forms.Label();
			this.txtUpdateDescription = new System.Windows.Forms.TextBox();
			this.lblEquipmentNo = new System.Windows.Forms.Label();
			this.lblUpdateDescription = new System.Windows.Forms.Label();
			this.btnUpdateCancel = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.pnlAddEquipment.SuspendLayout();
			this.pnlUpdateEquipment.SuspendLayout();
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
			// btnAddEquipment
			// 
			this.btnAddEquipment.Location = new System.Drawing.Point(362, 355);
			this.btnAddEquipment.Name = "btnAddEquipment";
			this.btnAddEquipment.Size = new System.Drawing.Size(120, 40);
			this.btnAddEquipment.TabIndex = 2;
			this.btnAddEquipment.Text = "Add Equipment";
			this.btnAddEquipment.UseVisualStyleBackColor = true;
			this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
			// 
			// btnUpdateEquipment
			// 
			this.btnUpdateEquipment.Location = new System.Drawing.Point(523, 355);
			this.btnUpdateEquipment.Name = "btnUpdateEquipment";
			this.btnUpdateEquipment.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateEquipment.TabIndex = 3;
			this.btnUpdateEquipment.Text = "Update Equipment";
			this.btnUpdateEquipment.UseVisualStyleBackColor = true;
			this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
			// 
			// btnDeleteEquipment
			// 
			this.btnDeleteEquipment.Location = new System.Drawing.Point(680, 355);
			this.btnDeleteEquipment.Name = "btnDeleteEquipment";
			this.btnDeleteEquipment.Size = new System.Drawing.Size(120, 40);
			this.btnDeleteEquipment.TabIndex = 4;
			this.btnDeleteEquipment.Text = "Delete Equipment";
			this.btnDeleteEquipment.UseVisualStyleBackColor = true;
			this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
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
			// btnEquipmentNo
			// 
			this.btnEquipmentNo.AutoSize = true;
			this.btnEquipmentNo.Location = new System.Drawing.Point(363, 126);
			this.btnEquipmentNo.Name = "btnEquipmentNo";
			this.btnEquipmentNo.Size = new System.Drawing.Size(74, 13);
			this.btnEquipmentNo.TabIndex = 6;
			this.btnEquipmentNo.Text = "Equipment ID:";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(373, 158);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 7;
			this.lblDescription.Text = "Description:";
			// 
			// lblEquipmentID
			// 
			this.lblEquipmentID.AutoSize = true;
			this.lblEquipmentID.Location = new System.Drawing.Point(453, 126);
			this.lblEquipmentID.Name = "lblEquipmentID";
			this.lblEquipmentID.Size = new System.Drawing.Size(23, 13);
			this.lblEquipmentID.TabIndex = 8;
			this.lblEquipmentID.Text = "null";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(456, 155);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(344, 20);
			this.txtDescription.TabIndex = 9;
			// 
			// lstEquipment
			// 
			this.lstEquipment.FormattingEnabled = true;
			this.lstEquipment.Location = new System.Drawing.Point(45, 43);
			this.lstEquipment.Name = "lstEquipment";
			this.lstEquipment.Size = new System.Drawing.Size(275, 277);
			this.lstEquipment.TabIndex = 10;
			// 
			// pnlAddEquipment
			// 
			this.pnlAddEquipment.Controls.Add(this.btnAddCancel);
			this.pnlAddEquipment.Controls.Add(this.btnSaveEquipment);
			this.pnlAddEquipment.Controls.Add(this.lblAddDescription);
			this.pnlAddEquipment.Controls.Add(this.txtAddDescription);
			this.pnlAddEquipment.Location = new System.Drawing.Point(362, 103);
			this.pnlAddEquipment.Name = "pnlAddEquipment";
			this.pnlAddEquipment.Size = new System.Drawing.Size(458, 120);
			this.pnlAddEquipment.TabIndex = 11;
			this.pnlAddEquipment.Visible = false;
			// 
			// btnAddCancel
			// 
			this.btnAddCancel.Location = new System.Drawing.Point(290, 71);
			this.btnAddCancel.Name = "btnAddCancel";
			this.btnAddCancel.Size = new System.Drawing.Size(120, 40);
			this.btnAddCancel.TabIndex = 3;
			this.btnAddCancel.Text = "Cancel";
			this.btnAddCancel.UseVisualStyleBackColor = true;
			this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
			// 
			// btnSaveEquipment
			// 
			this.btnSaveEquipment.Location = new System.Drawing.Point(31, 71);
			this.btnSaveEquipment.Name = "btnSaveEquipment";
			this.btnSaveEquipment.Size = new System.Drawing.Size(120, 40);
			this.btnSaveEquipment.TabIndex = 2;
			this.btnSaveEquipment.Text = "Save Equipment";
			this.btnSaveEquipment.UseVisualStyleBackColor = true;
			this.btnSaveEquipment.Click += new System.EventHandler(this.btnSaveEquipment_Click);
			// 
			// lblAddDescription
			// 
			this.lblAddDescription.AutoSize = true;
			this.lblAddDescription.Location = new System.Drawing.Point(28, 38);
			this.lblAddDescription.Name = "lblAddDescription";
			this.lblAddDescription.Size = new System.Drawing.Size(63, 13);
			this.lblAddDescription.TabIndex = 1;
			this.lblAddDescription.Text = "Description:";
			// 
			// txtAddDescription
			// 
			this.txtAddDescription.Location = new System.Drawing.Point(97, 35);
			this.txtAddDescription.Name = "txtAddDescription";
			this.txtAddDescription.Size = new System.Drawing.Size(313, 20);
			this.txtAddDescription.TabIndex = 0;
			// 
			// pnlUpdateEquipment
			// 
			this.pnlUpdateEquipment.Controls.Add(this.lblUpdateEquipmentID);
			this.pnlUpdateEquipment.Controls.Add(this.txtUpdateDescription);
			this.pnlUpdateEquipment.Controls.Add(this.lblEquipmentNo);
			this.pnlUpdateEquipment.Controls.Add(this.lblUpdateDescription);
			this.pnlUpdateEquipment.Controls.Add(this.btnUpdateCancel);
			this.pnlUpdateEquipment.Controls.Add(this.btnSaveChanges);
			this.pnlUpdateEquipment.Location = new System.Drawing.Point(36, 274);
			this.pnlUpdateEquipment.Name = "pnlUpdateEquipment";
			this.pnlUpdateEquipment.Size = new System.Drawing.Size(458, 162);
			this.pnlUpdateEquipment.TabIndex = 12;
			this.pnlUpdateEquipment.Visible = false;
			// 
			// lblUpdateEquipmentID
			// 
			this.lblUpdateEquipmentID.AutoSize = true;
			this.lblUpdateEquipmentID.Location = new System.Drawing.Point(122, 42);
			this.lblUpdateEquipmentID.Name = "lblUpdateEquipmentID";
			this.lblUpdateEquipmentID.Size = new System.Drawing.Size(23, 13);
			this.lblUpdateEquipmentID.TabIndex = 5;
			this.lblUpdateEquipmentID.Text = "null";
			// 
			// txtUpdateDescription
			// 
			this.txtUpdateDescription.Location = new System.Drawing.Point(124, 69);
			this.txtUpdateDescription.Name = "txtUpdateDescription";
			this.txtUpdateDescription.Size = new System.Drawing.Size(302, 20);
			this.txtUpdateDescription.TabIndex = 4;
			// 
			// lblEquipmentNo
			// 
			this.lblEquipmentNo.AutoSize = true;
			this.lblEquipmentNo.Location = new System.Drawing.Point(39, 40);
			this.lblEquipmentNo.Name = "lblEquipmentNo";
			this.lblEquipmentNo.Size = new System.Drawing.Size(74, 13);
			this.lblEquipmentNo.TabIndex = 3;
			this.lblEquipmentNo.Text = "Equipment ID:";
			// 
			// lblUpdateDescription
			// 
			this.lblUpdateDescription.AutoSize = true;
			this.lblUpdateDescription.Location = new System.Drawing.Point(49, 72);
			this.lblUpdateDescription.Name = "lblUpdateDescription";
			this.lblUpdateDescription.Size = new System.Drawing.Size(63, 13);
			this.lblUpdateDescription.TabIndex = 2;
			this.lblUpdateDescription.Text = "Description:";
			// 
			// btnUpdateCancel
			// 
			this.btnUpdateCancel.Location = new System.Drawing.Point(306, 110);
			this.btnUpdateCancel.Name = "btnUpdateCancel";
			this.btnUpdateCancel.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateCancel.TabIndex = 1;
			this.btnUpdateCancel.Text = "Cancel";
			this.btnUpdateCancel.UseVisualStyleBackColor = true;
			this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(37, 110);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(120, 40);
			this.btnSaveChanges.TabIndex = 0;
			this.btnSaveChanges.Text = "Save Changes";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// EquipmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 493);
			this.Controls.Add(this.pnlUpdateEquipment);
			this.Controls.Add(this.pnlAddEquipment);
			this.Controls.Add(this.lstEquipment);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblEquipmentID);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.btnEquipmentNo);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnDeleteEquipment);
			this.Controls.Add(this.btnUpdateEquipment);
			this.Controls.Add(this.btnAddEquipment);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Name = "EquipmentForm";
			this.Text = "Equipment Form";
			this.pnlAddEquipment.ResumeLayout(false);
			this.pnlAddEquipment.PerformLayout();
			this.pnlUpdateEquipment.ResumeLayout(false);
			this.pnlUpdateEquipment.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnAddEquipment;
		private System.Windows.Forms.Button btnUpdateEquipment;
		private System.Windows.Forms.Button btnDeleteEquipment;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label btnEquipmentNo;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblEquipmentID;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.ListBox lstEquipment;
		private System.Windows.Forms.Panel pnlAddEquipment;
		private System.Windows.Forms.Button btnAddCancel;
		private System.Windows.Forms.Button btnSaveEquipment;
		private System.Windows.Forms.Label lblAddDescription;
		private System.Windows.Forms.TextBox txtAddDescription;
		private System.Windows.Forms.Panel pnlUpdateEquipment;
		private System.Windows.Forms.Label lblUpdateEquipmentID;
		private System.Windows.Forms.TextBox txtUpdateDescription;
		private System.Windows.Forms.Label lblEquipmentNo;
		private System.Windows.Forms.Label lblUpdateDescription;
		private System.Windows.Forms.Button btnUpdateCancel;
		private System.Windows.Forms.Button btnSaveChanges;
	}
}