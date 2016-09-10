using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greens_Garage
{



	public partial class OwnerForm : Form
	{
		public void BindControls()
		{
			lblOwnerID.DataBindings.Add("Text", DM.dsGreen, "Owner.OwnerID");
			txtLastName.DataBindings.Add("Text", DM.dsGreen, "Owner.LastName");
			txtFirstName.DataBindings.Add("Text", DM.dsGreen, "Owner.FirstName");
			txtStreetAddress.DataBindings.Add("Text", DM.dsGreen, "Owner.StreetAddress");
			txtSuburb.DataBindings.Add("Text", DM.dsGreen, "Owner.Suburb");
			txtPhoneNumber.DataBindings.Add("Text", DM.dsGreen, "Owner.PhoneNumber");

			txtLastName.Enabled = false;
			txtFirstName.Enabled = false;
			txtStreetAddress.Enabled = false;
			txtSuburb.Enabled = false;
			txtPhoneNumber.Enabled = false;

			txtAddLastName.Enabled = false;
			txtAddFirstName.Enabled = false;
			txtAddStreetAddress.Enabled = false;
			txtAddSuburb.Enabled = false;
			txtAddPhoneNumber.Enabled = false;

			lblUpdateOwnerID.DataBindings.Add("Text", DM.dsGreen, "Owner.OwnerID");
			txtUpdateLastName.DataBindings.Add("Text", DM.dsGreen, "Owner.LastName");
			txtUpdateFirstName.DataBindings.Add("Text", DM.dsGreen, "Owner.FirstName");
			txtUpdateStreetAddress.DataBindings.Add("Text", DM.dsGreen, "Owner.StreetAddress");
			txtUpdateSuburb.DataBindings.Add("Text", DM.dsGreen, "Owner.Suburb");
			txtUpdatePhoneNumber.DataBindings.Add("Text", DM.dsGreen, "Owner.PhoneNumber");
			txtUpdateLastName.Enabled = false;
			txtUpdateFirstName.Enabled = false;
			txtUpdateStreetAddress.Enabled = false;
			txtUpdateSuburb.Enabled = false;
			txtUpdatePhoneNumber.Enabled = false;

			lstOwner.DataSource = DM.dsGreen;
			lstOwner.DisplayMember = "Owner.LastName";
			lstOwner.ValueMember = "Owner.LastName";
			currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreen, "OWNER"];
		}
		private DataModule DM;
		private MainForm frmMenu;
		private CurrencyManager currencyManager;
		public OwnerForm(DataModule dm, MainForm mnu)
		{
			InitializeComponent();
			DM = dm;
			frmMenu = mnu;
			BindControls();
			pnlAddOwner.Left = 369;
			pnlAddOwner.Top = 43;
			pnlUpdateOwner.Left = 369;
			pnlUpdateOwner.Top = 43;

		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (currencyManager.Position > 0)
			{
				--currencyManager.Position;
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (currencyManager.Position < currencyManager.Count - 1)
			{
				++currencyManager.Position;
			}
		}

		private void btnAddOwner_Click(object sender, EventArgs e)
		{
			lstOwner.Visible = false;
			btnDeleteOwner.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnUpdateOwner.Enabled = false;
			btnAddOwner.Enabled = true;
			txtAddLastName.Enabled = true;
			txtAddFirstName.Enabled = true;
			txtAddStreetAddress.Enabled = true;
			txtAddSuburb.Enabled = true;
			txtAddPhoneNumber.Enabled = true;
			pnlAddOwner.Show();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			pnlAddOwner.Hide();
			lstOwner.Enabled = true;
			lstOwner.Visible = true;
			btnDeleteOwner.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateOwner.Enabled = true;
			btnAddOwner.Enabled = true;
			txtAddLastName.Enabled = false;
			txtAddFirstName.Enabled = false;
			txtAddStreetAddress.Enabled = false;
			txtAddSuburb.Enabled = false;
			txtAddPhoneNumber.Enabled = false;
		}

		private void btnSaveOwner_Click(object sender, EventArgs e)
		{
			lblOwnerID.Text = null;
			DataRow newOwnerRow = DM.dtOwner.NewRow();
			if ((txtAddLastName.Text == "") || (txtAddFirstName.Text == "") ||
				(txtAddSuburb.Text == "") || (txtAddStreetAddress.Text == ""))
			{
				MessageBox.Show("Values must be entered for First and Last name, as well as Street Address/Suburb.", "Error");
			}
			else
			{
				try
				{
					newOwnerRow["LastName"] = txtAddLastName.Text;
					newOwnerRow["FirstName"] = txtAddFirstName.Text;
					newOwnerRow["StreetAddress"] = txtAddStreetAddress.Text;
					newOwnerRow["Suburb"] = txtAddSuburb.Text;
					newOwnerRow["PhoneNumber"] = txtAddPhoneNumber.Text;
					DM.dtOwner.Rows.Add(newOwnerRow);
					MessageBox.Show("Owner added successfully", "Success");
					DM.UpdateOwner();
				}
				catch (FormatException ex)
				{
					MessageBox.Show("Please enter a number for cost", "Error");
				}
			}
		}

		private void btnDeleteOwner_Click(object sender, EventArgs e)
		{
			DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
			DataRow[] VehicleRow = DM.dtVehicle.Select("OwnerID = " + lblOwnerID.Text);
			if (VehicleRow.Length != 0)
			{
				MessageBox.Show("You may only delete owners that are not allocated to vehicles", "Error");
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
				MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					deleteOwnerRow.Delete();
					DM.UpdateOwner();
				}
			}
		}

		private void btnUpdateOwner_Click(object sender, EventArgs e)
		{
			DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];

			lstOwner.Visible = false;
			btnDeleteOwner.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnAddOwner.Enabled = false;
			txtUpdateLastName.Enabled = true;
			txtUpdateFirstName.Enabled = true;
			txtUpdateStreetAddress.Enabled = true;
			txtUpdateSuburb.Enabled = true;
			txtUpdatePhoneNumber.Enabled = true;
			pnlUpdateOwner.Visible = true;
			pnlUpdateOwner.Show();
		}

		private void btnUpdateCancel_Click(object sender, EventArgs e)
		{
			pnlUpdateOwner.Hide();
			lstOwner.Enabled = true;
			lstOwner.Visible = true;
			btnDeleteOwner.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateOwner.Enabled = true;
			btnAddOwner.Enabled = true;
			txtUpdateLastName.Enabled = false;
			txtUpdateFirstName.Enabled = false;
			txtUpdateStreetAddress.Enabled = false;
			txtUpdateSuburb.Enabled = false;
			txtUpdatePhoneNumber.Enabled = false;
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];

			if ((txtUpdateLastName.Text == "") || (txtUpdateFirstName.Text == "") ||
				(txtUpdateSuburb.Text == "") || (txtUpdateStreetAddress.Text == ""))
			{
				MessageBox.Show("Values must be entered for First and Last name, as well as Street Address/Suburb.", "Error");
			}
			else
			{
				updateOwnerRow["LastName"] = txtUpdateLastName.Text;
				updateOwnerRow["FirstName"] = txtUpdateFirstName.Text;
				updateOwnerRow["StreetAddress"] = txtUpdateStreetAddress.Text;
				updateOwnerRow["Suburb"] = txtUpdateSuburb.Text;
				updateOwnerRow["PhoneNumber"] = txtUpdatePhoneNumber.Text;
				currencyManager.EndCurrentEdit();
				DM.UpdateOwner();
				MessageBox.Show("Owner updated successfully", "Success");
			}
		}

	}
}
