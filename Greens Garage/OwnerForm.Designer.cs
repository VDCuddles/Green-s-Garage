namespace Greens_Garage
{
	partial class OwnerForm
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
			this.lstOwner = new System.Windows.Forms.ListBox();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnAddOwner = new System.Windows.Forms.Button();
			this.btnUpdateOwner = new System.Windows.Forms.Button();
			this.btnDeleteOwner = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.lblOwnerNo = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblStreetAddress = new System.Windows.Forms.Label();
			this.lblSuburb = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtStreetAddress = new System.Windows.Forms.TextBox();
			this.txtSuburb = new System.Windows.Forms.TextBox();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.lblOwnerID = new System.Windows.Forms.Label();
			this.pnlAddOwner = new System.Windows.Forms.Panel();
			this.txtAddPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtAddSuburb = new System.Windows.Forms.TextBox();
			this.txtAddStreetAddress = new System.Windows.Forms.TextBox();
			this.txtAddFirstName = new System.Windows.Forms.TextBox();
			this.txtAddLastName = new System.Windows.Forms.TextBox();
			this.lblAddPhoneNumber = new System.Windows.Forms.Label();
			this.lblAddSuburb = new System.Windows.Forms.Label();
			this.lblAddStreetAddress = new System.Windows.Forms.Label();
			this.lblAddFirstName = new System.Windows.Forms.Label();
			this.lblAddLastName = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSaveOwner = new System.Windows.Forms.Button();
			this.pnlUpdateOwner = new System.Windows.Forms.Panel();
			this.txtUpdatePhoneNumber = new System.Windows.Forms.TextBox();
			this.txtUpdateSuburb = new System.Windows.Forms.TextBox();
			this.txtUpdateStreetAddress = new System.Windows.Forms.TextBox();
			this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
			this.txtUpdateLastName = new System.Windows.Forms.TextBox();
			this.lblUpdateOwnerID = new System.Windows.Forms.Label();
			this.lblUpdatePhoneNumber = new System.Windows.Forms.Label();
			this.lblUpdateSuburb = new System.Windows.Forms.Label();
			this.lblUpdateStreetAddress = new System.Windows.Forms.Label();
			this.lblUpdateFirstName = new System.Windows.Forms.Label();
			this.lblUpdateLastName = new System.Windows.Forms.Label();
			this.lblUpdateOwnerNo = new System.Windows.Forms.Label();
			this.btnUpdateCancel = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.pnlAddOwner.SuspendLayout();
			this.pnlUpdateOwner.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstOwner
			// 
			this.lstOwner.FormattingEnabled = true;
			this.lstOwner.Location = new System.Drawing.Point(45, 43);
			this.lstOwner.Name = "lstOwner";
			this.lstOwner.Size = new System.Drawing.Size(275, 277);
			this.lstOwner.TabIndex = 0;
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
			this.btnNext.Location = new System.Drawing.Point(200, 355);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(120, 40);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnAddOwner
			// 
			this.btnAddOwner.Location = new System.Drawing.Point(369, 355);
			this.btnAddOwner.Name = "btnAddOwner";
			this.btnAddOwner.Size = new System.Drawing.Size(120, 40);
			this.btnAddOwner.TabIndex = 3;
			this.btnAddOwner.Text = "Add Owner";
			this.btnAddOwner.UseVisualStyleBackColor = true;
			this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
			// 
			// btnUpdateOwner
			// 
			this.btnUpdateOwner.Location = new System.Drawing.Point(530, 355);
			this.btnUpdateOwner.Name = "btnUpdateOwner";
			this.btnUpdateOwner.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateOwner.TabIndex = 4;
			this.btnUpdateOwner.Text = "Update Owner";
			this.btnUpdateOwner.UseVisualStyleBackColor = true;
			this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
			// 
			// btnDeleteOwner
			// 
			this.btnDeleteOwner.Location = new System.Drawing.Point(680, 355);
			this.btnDeleteOwner.Name = "btnDeleteOwner";
			this.btnDeleteOwner.Size = new System.Drawing.Size(120, 40);
			this.btnDeleteOwner.TabIndex = 5;
			this.btnDeleteOwner.Text = "Delete Owner";
			this.btnDeleteOwner.UseVisualStyleBackColor = true;
			this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
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
			// lblOwnerNo
			// 
			this.lblOwnerNo.AutoSize = true;
			this.lblOwnerNo.Location = new System.Drawing.Point(396, 70);
			this.lblOwnerNo.Name = "lblOwnerNo";
			this.lblOwnerNo.Size = new System.Drawing.Size(55, 13);
			this.lblOwnerNo.TabIndex = 7;
			this.lblOwnerNo.Text = "Owner ID:";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(396, 110);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(61, 13);
			this.lblLastName.TabIndex = 8;
			this.lblLastName.Text = "Last Name:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(396, 150);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(60, 13);
			this.lblFirstName.TabIndex = 9;
			this.lblFirstName.Text = "First Name:";
			// 
			// lblStreetAddress
			// 
			this.lblStreetAddress.AutoSize = true;
			this.lblStreetAddress.Location = new System.Drawing.Point(396, 190);
			this.lblStreetAddress.Name = "lblStreetAddress";
			this.lblStreetAddress.Size = new System.Drawing.Size(79, 13);
			this.lblStreetAddress.TabIndex = 10;
			this.lblStreetAddress.Text = "Street Address:";
			// 
			// lblSuburb
			// 
			this.lblSuburb.AutoSize = true;
			this.lblSuburb.Location = new System.Drawing.Point(396, 230);
			this.lblSuburb.Name = "lblSuburb";
			this.lblSuburb.Size = new System.Drawing.Size(44, 13);
			this.lblSuburb.TabIndex = 11;
			this.lblSuburb.Text = "Suburb:";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Location = new System.Drawing.Point(396, 270);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
			this.lblPhoneNumber.TabIndex = 12;
			this.lblPhoneNumber.Text = "Phone Number:";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(487, 107);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(163, 20);
			this.txtLastName.TabIndex = 14;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(487, 147);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(163, 20);
			this.txtFirstName.TabIndex = 15;
			// 
			// txtStreetAddress
			// 
			this.txtStreetAddress.Location = new System.Drawing.Point(487, 187);
			this.txtStreetAddress.Name = "txtStreetAddress";
			this.txtStreetAddress.Size = new System.Drawing.Size(313, 20);
			this.txtStreetAddress.TabIndex = 16;
			// 
			// txtSuburb
			// 
			this.txtSuburb.Location = new System.Drawing.Point(487, 227);
			this.txtSuburb.Name = "txtSuburb";
			this.txtSuburb.Size = new System.Drawing.Size(163, 20);
			this.txtSuburb.TabIndex = 17;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(487, 267);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
			this.txtPhoneNumber.TabIndex = 18;
			// 
			// lblOwnerID
			// 
			this.lblOwnerID.AutoSize = true;
			this.lblOwnerID.Location = new System.Drawing.Point(484, 70);
			this.lblOwnerID.Name = "lblOwnerID";
			this.lblOwnerID.Size = new System.Drawing.Size(23, 13);
			this.lblOwnerID.TabIndex = 19;
			this.lblOwnerID.Text = "null";
			// 
			// pnlAddOwner
			// 
			this.pnlAddOwner.Controls.Add(this.txtAddPhoneNumber);
			this.pnlAddOwner.Controls.Add(this.txtAddSuburb);
			this.pnlAddOwner.Controls.Add(this.txtAddStreetAddress);
			this.pnlAddOwner.Controls.Add(this.txtAddFirstName);
			this.pnlAddOwner.Controls.Add(this.txtAddLastName);
			this.pnlAddOwner.Controls.Add(this.lblAddPhoneNumber);
			this.pnlAddOwner.Controls.Add(this.lblAddSuburb);
			this.pnlAddOwner.Controls.Add(this.lblAddStreetAddress);
			this.pnlAddOwner.Controls.Add(this.lblAddFirstName);
			this.pnlAddOwner.Controls.Add(this.lblAddLastName);
			this.pnlAddOwner.Controls.Add(this.btnCancel);
			this.pnlAddOwner.Controls.Add(this.btnSaveOwner);
			this.pnlAddOwner.Location = new System.Drawing.Point(369, 43);
			this.pnlAddOwner.Name = "pnlAddOwner";
			this.pnlAddOwner.Size = new System.Drawing.Size(431, 277);
			this.pnlAddOwner.TabIndex = 20;
			this.pnlAddOwner.Visible = false;
			// 
			// txtAddPhoneNumber
			// 
			this.txtAddPhoneNumber.Location = new System.Drawing.Point(118, 171);
			this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
			this.txtAddPhoneNumber.Size = new System.Drawing.Size(100, 20);
			this.txtAddPhoneNumber.TabIndex = 11;
			// 
			// txtAddSuburb
			// 
			this.txtAddSuburb.Location = new System.Drawing.Point(118, 137);
			this.txtAddSuburb.Name = "txtAddSuburb";
			this.txtAddSuburb.Size = new System.Drawing.Size(100, 20);
			this.txtAddSuburb.TabIndex = 10;
			// 
			// txtAddStreetAddress
			// 
			this.txtAddStreetAddress.Location = new System.Drawing.Point(118, 100);
			this.txtAddStreetAddress.Name = "txtAddStreetAddress";
			this.txtAddStreetAddress.Size = new System.Drawing.Size(286, 20);
			this.txtAddStreetAddress.TabIndex = 9;
			// 
			// txtAddFirstName
			// 
			this.txtAddFirstName.Location = new System.Drawing.Point(118, 64);
			this.txtAddFirstName.Name = "txtAddFirstName";
			this.txtAddFirstName.Size = new System.Drawing.Size(210, 20);
			this.txtAddFirstName.TabIndex = 8;
			// 
			// txtAddLastName
			// 
			this.txtAddLastName.Location = new System.Drawing.Point(118, 27);
			this.txtAddLastName.Name = "txtAddLastName";
			this.txtAddLastName.Size = new System.Drawing.Size(210, 20);
			this.txtAddLastName.TabIndex = 7;
			// 
			// lblAddPhoneNumber
			// 
			this.lblAddPhoneNumber.AutoSize = true;
			this.lblAddPhoneNumber.Location = new System.Drawing.Point(27, 174);
			this.lblAddPhoneNumber.Name = "lblAddPhoneNumber";
			this.lblAddPhoneNumber.Size = new System.Drawing.Size(81, 13);
			this.lblAddPhoneNumber.TabIndex = 6;
			this.lblAddPhoneNumber.Text = "Phone Number:";
			// 
			// lblAddSuburb
			// 
			this.lblAddSuburb.AutoSize = true;
			this.lblAddSuburb.Location = new System.Drawing.Point(64, 140);
			this.lblAddSuburb.Name = "lblAddSuburb";
			this.lblAddSuburb.Size = new System.Drawing.Size(44, 13);
			this.lblAddSuburb.TabIndex = 5;
			this.lblAddSuburb.Text = "Suburb:";
			// 
			// lblAddStreetAddress
			// 
			this.lblAddStreetAddress.AutoSize = true;
			this.lblAddStreetAddress.Location = new System.Drawing.Point(29, 104);
			this.lblAddStreetAddress.Name = "lblAddStreetAddress";
			this.lblAddStreetAddress.Size = new System.Drawing.Size(79, 13);
			this.lblAddStreetAddress.TabIndex = 4;
			this.lblAddStreetAddress.Text = "Street Address:";
			// 
			// lblAddFirstName
			// 
			this.lblAddFirstName.AutoSize = true;
			this.lblAddFirstName.Location = new System.Drawing.Point(48, 67);
			this.lblAddFirstName.Name = "lblAddFirstName";
			this.lblAddFirstName.Size = new System.Drawing.Size(60, 13);
			this.lblAddFirstName.TabIndex = 3;
			this.lblAddFirstName.Text = "First Name:";
			// 
			// lblAddLastName
			// 
			this.lblAddLastName.AutoSize = true;
			this.lblAddLastName.Location = new System.Drawing.Point(47, 30);
			this.lblAddLastName.Name = "lblAddLastName";
			this.lblAddLastName.Size = new System.Drawing.Size(61, 13);
			this.lblAddLastName.TabIndex = 2;
			this.lblAddLastName.Text = "Last Name:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(284, 213);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 40);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSaveOwner
			// 
			this.btnSaveOwner.Location = new System.Drawing.Point(45, 213);
			this.btnSaveOwner.Name = "btnSaveOwner";
			this.btnSaveOwner.Size = new System.Drawing.Size(120, 40);
			this.btnSaveOwner.TabIndex = 0;
			this.btnSaveOwner.Text = "Save Owner";
			this.btnSaveOwner.UseVisualStyleBackColor = true;
			this.btnSaveOwner.Click += new System.EventHandler(this.btnSaveOwner_Click);
			// 
			// pnlUpdateOwner
			// 
			this.pnlUpdateOwner.Controls.Add(this.txtUpdatePhoneNumber);
			this.pnlUpdateOwner.Controls.Add(this.txtUpdateSuburb);
			this.pnlUpdateOwner.Controls.Add(this.txtUpdateStreetAddress);
			this.pnlUpdateOwner.Controls.Add(this.txtUpdateFirstName);
			this.pnlUpdateOwner.Controls.Add(this.txtUpdateLastName);
			this.pnlUpdateOwner.Controls.Add(this.lblUpdateOwnerID);
			this.pnlUpdateOwner.Controls.Add(this.lblUpdatePhoneNumber);
			this.pnlUpdateOwner.Controls.Add(this.lblUpdateSuburb);
			this.pnlUpdateOwner.Controls.Add(this.lblUpdateStreetAddress);
			this.pnlUpdateOwner.Controls.Add(this.lblUpdateFirstName);
			this.pnlUpdateOwner.Controls.Add(this.lblUpdateLastName);
			this.pnlUpdateOwner.Controls.Add(this.lblUpdateOwnerNo);
			this.pnlUpdateOwner.Controls.Add(this.btnUpdateCancel);
			this.pnlUpdateOwner.Controls.Add(this.btnSaveChanges);
			this.pnlUpdateOwner.Location = new System.Drawing.Point(76, 183);
			this.pnlUpdateOwner.Name = "pnlUpdateOwner";
			this.pnlUpdateOwner.Size = new System.Drawing.Size(431, 277);
			this.pnlUpdateOwner.TabIndex = 12;
			this.pnlUpdateOwner.Visible = false;
			// 
			// txtUpdatePhoneNumber
			// 
			this.txtUpdatePhoneNumber.Location = new System.Drawing.Point(118, 189);
			this.txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
			this.txtUpdatePhoneNumber.Size = new System.Drawing.Size(135, 20);
			this.txtUpdatePhoneNumber.TabIndex = 13;
			// 
			// txtUpdateSuburb
			// 
			this.txtUpdateSuburb.Location = new System.Drawing.Point(118, 154);
			this.txtUpdateSuburb.Name = "txtUpdateSuburb";
			this.txtUpdateSuburb.Size = new System.Drawing.Size(100, 20);
			this.txtUpdateSuburb.TabIndex = 12;
			// 
			// txtUpdateStreetAddress
			// 
			this.txtUpdateStreetAddress.Location = new System.Drawing.Point(118, 117);
			this.txtUpdateStreetAddress.Name = "txtUpdateStreetAddress";
			this.txtUpdateStreetAddress.Size = new System.Drawing.Size(283, 20);
			this.txtUpdateStreetAddress.TabIndex = 11;
			// 
			// txtUpdateFirstName
			// 
			this.txtUpdateFirstName.Location = new System.Drawing.Point(118, 81);
			this.txtUpdateFirstName.Name = "txtUpdateFirstName";
			this.txtUpdateFirstName.Size = new System.Drawing.Size(190, 20);
			this.txtUpdateFirstName.TabIndex = 10;
			// 
			// txtUpdateLastName
			// 
			this.txtUpdateLastName.Location = new System.Drawing.Point(118, 44);
			this.txtUpdateLastName.Name = "txtUpdateLastName";
			this.txtUpdateLastName.Size = new System.Drawing.Size(190, 20);
			this.txtUpdateLastName.TabIndex = 9;
			// 
			// lblUpdateOwnerID
			// 
			this.lblUpdateOwnerID.AutoSize = true;
			this.lblUpdateOwnerID.Location = new System.Drawing.Point(115, 14);
			this.lblUpdateOwnerID.Name = "lblUpdateOwnerID";
			this.lblUpdateOwnerID.Size = new System.Drawing.Size(23, 13);
			this.lblUpdateOwnerID.TabIndex = 8;
			this.lblUpdateOwnerID.Text = "null";
			// 
			// lblUpdatePhoneNumber
			// 
			this.lblUpdatePhoneNumber.AutoSize = true;
			this.lblUpdatePhoneNumber.Location = new System.Drawing.Point(28, 192);
			this.lblUpdatePhoneNumber.Name = "lblUpdatePhoneNumber";
			this.lblUpdatePhoneNumber.Size = new System.Drawing.Size(81, 13);
			this.lblUpdatePhoneNumber.TabIndex = 7;
			this.lblUpdatePhoneNumber.Text = "Phone Number:";
			// 
			// lblUpdateSuburb
			// 
			this.lblUpdateSuburb.AutoSize = true;
			this.lblUpdateSuburb.Location = new System.Drawing.Point(65, 157);
			this.lblUpdateSuburb.Name = "lblUpdateSuburb";
			this.lblUpdateSuburb.Size = new System.Drawing.Size(44, 13);
			this.lblUpdateSuburb.TabIndex = 6;
			this.lblUpdateSuburb.Text = "Suburb:";
			// 
			// lblUpdateStreetAddress
			// 
			this.lblUpdateStreetAddress.AutoSize = true;
			this.lblUpdateStreetAddress.Location = new System.Drawing.Point(30, 120);
			this.lblUpdateStreetAddress.Name = "lblUpdateStreetAddress";
			this.lblUpdateStreetAddress.Size = new System.Drawing.Size(79, 13);
			this.lblUpdateStreetAddress.TabIndex = 5;
			this.lblUpdateStreetAddress.Text = "Street Address:";
			// 
			// lblUpdateFirstName
			// 
			this.lblUpdateFirstName.AutoSize = true;
			this.lblUpdateFirstName.Location = new System.Drawing.Point(49, 84);
			this.lblUpdateFirstName.Name = "lblUpdateFirstName";
			this.lblUpdateFirstName.Size = new System.Drawing.Size(60, 13);
			this.lblUpdateFirstName.TabIndex = 4;
			this.lblUpdateFirstName.Text = "First Name:";
			// 
			// lblUpdateLastName
			// 
			this.lblUpdateLastName.AutoSize = true;
			this.lblUpdateLastName.Location = new System.Drawing.Point(48, 47);
			this.lblUpdateLastName.Name = "lblUpdateLastName";
			this.lblUpdateLastName.Size = new System.Drawing.Size(61, 13);
			this.lblUpdateLastName.TabIndex = 3;
			this.lblUpdateLastName.Text = "Last Name:";
			// 
			// lblUpdateOwnerNo
			// 
			this.lblUpdateOwnerNo.AutoSize = true;
			this.lblUpdateOwnerNo.Location = new System.Drawing.Point(54, 14);
			this.lblUpdateOwnerNo.Name = "lblUpdateOwnerNo";
			this.lblUpdateOwnerNo.Size = new System.Drawing.Size(55, 13);
			this.lblUpdateOwnerNo.TabIndex = 2;
			this.lblUpdateOwnerNo.Text = "Owner ID:";
			// 
			// btnUpdateCancel
			// 
			this.btnUpdateCancel.Location = new System.Drawing.Point(291, 223);
			this.btnUpdateCancel.Name = "btnUpdateCancel";
			this.btnUpdateCancel.Size = new System.Drawing.Size(120, 40);
			this.btnUpdateCancel.TabIndex = 1;
			this.btnUpdateCancel.Text = "Cancel";
			this.btnUpdateCancel.UseVisualStyleBackColor = true;
			this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(18, 223);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(120, 40);
			this.btnSaveChanges.TabIndex = 0;
			this.btnSaveChanges.Text = "Save Changes";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// OwnerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 493);
			this.Controls.Add(this.pnlUpdateOwner);
			this.Controls.Add(this.pnlAddOwner);
			this.Controls.Add(this.lblOwnerID);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtSuburb);
			this.Controls.Add(this.txtStreetAddress);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.lblSuburb);
			this.Controls.Add(this.lblStreetAddress);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblOwnerNo);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnDeleteOwner);
			this.Controls.Add(this.btnUpdateOwner);
			this.Controls.Add(this.btnAddOwner);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.lstOwner);
			this.Name = "OwnerForm";
			this.Text = "Owner Form";
			this.pnlAddOwner.ResumeLayout(false);
			this.pnlAddOwner.PerformLayout();
			this.pnlUpdateOwner.ResumeLayout(false);
			this.pnlUpdateOwner.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstOwner;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnAddOwner;
		private System.Windows.Forms.Button btnUpdateOwner;
		private System.Windows.Forms.Button btnDeleteOwner;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label lblOwnerNo;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblStreetAddress;
		private System.Windows.Forms.Label lblSuburb;
		private System.Windows.Forms.Label lblPhoneNumber;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtStreetAddress;
		private System.Windows.Forms.TextBox txtSuburb;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label lblOwnerID;
		private System.Windows.Forms.Panel pnlAddOwner;
		private System.Windows.Forms.TextBox txtAddPhoneNumber;
		private System.Windows.Forms.TextBox txtAddSuburb;
		private System.Windows.Forms.TextBox txtAddStreetAddress;
		private System.Windows.Forms.TextBox txtAddFirstName;
		private System.Windows.Forms.TextBox txtAddLastName;
		private System.Windows.Forms.Label lblAddPhoneNumber;
		private System.Windows.Forms.Label lblAddSuburb;
		private System.Windows.Forms.Label lblAddStreetAddress;
		private System.Windows.Forms.Label lblAddFirstName;
		private System.Windows.Forms.Label lblAddLastName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSaveOwner;
		private System.Windows.Forms.Panel pnlUpdateOwner;
		private System.Windows.Forms.TextBox txtUpdatePhoneNumber;
		private System.Windows.Forms.TextBox txtUpdateSuburb;
		private System.Windows.Forms.TextBox txtUpdateStreetAddress;
		private System.Windows.Forms.TextBox txtUpdateFirstName;
		private System.Windows.Forms.TextBox txtUpdateLastName;
		private System.Windows.Forms.Label lblUpdateOwnerID;
		private System.Windows.Forms.Label lblUpdatePhoneNumber;
		private System.Windows.Forms.Label lblUpdateSuburb;
		private System.Windows.Forms.Label lblUpdateStreetAddress;
		private System.Windows.Forms.Label lblUpdateFirstName;
		private System.Windows.Forms.Label lblUpdateLastName;
		private System.Windows.Forms.Label lblUpdateOwnerNo;
		private System.Windows.Forms.Button btnUpdateCancel;
		private System.Windows.Forms.Button btnSaveChanges;
	}
}