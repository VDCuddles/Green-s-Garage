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
	public partial class VehicleForm : Form
	{
		public void getOwnerName()
		{
			int aOwnerID = Convert.ToInt32(txtOwnerID.Text);
			cmOwner.Position = DM.ownerView.Find(aOwnerID);
			DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

			txtOwnerName.Text = drOwner["FirstName"].ToString();
			txtOwnerName.AppendText(" ");
			txtOwnerName.AppendText(drOwner["LastName"].ToString());
		}

		public void BindControls()
		{
			lblVehicleID.DataBindings.Add("Text", DM.dsGreen, "Vehicle.VehicleID");
			txtPlateNumber.DataBindings.Add("Text", DM.dsGreen, "Vehicle.PlateNumber");
			txtMake.DataBindings.Add("Text", DM.dsGreen, "Vehicle.Make");
			txtModel.DataBindings.Add("Text", DM.dsGreen, "Vehicle.Model");
			txtOwnerID.DataBindings.Add("Text", DM.dsGreen, "Vehicle.OwnerID");

			txtPlateNumber.Enabled = false;
			txtMake.Enabled = false;
			txtModel.Enabled = false;
			txtOwnerID.Enabled = false;
			txtOwnerName.Enabled = false;

			txtAddPlateNumber.Enabled = false;
			txtAddMake.Enabled = false;
			txtAddModel.Enabled = false;
			cmbAddOwnerID.Enabled = false;
			cmbAddOwnerName.Enabled = false;
			cmbAddOwnerID.DataSource = DM.dsGreen;
			cmbAddOwnerID.DisplayMember = "Owner.OwnerID";
			cmbAddOwnerID.ValueMember = "Owner.OwnerID";
			cmbAddOwnerName.DataSource = DM.dsGreen;
			cmbAddOwnerName.DisplayMember = "Owner.LastName";
			cmbAddOwnerName.ValueMember = "Owner.LastName";


			lblUpdateVehicleID.DataBindings.Add("Text", DM.dsGreen, "Vehicle.VehicleID");
			txtUpdatePlateNumber.DataBindings.Add("Text", DM.dsGreen, "Vehicle.PlateNumber");
			txtUpdateMake.DataBindings.Add("Text", DM.dsGreen, "Vehicle.Make");
			txtUpdateModel.DataBindings.Add("Text", DM.dsGreen, "Vehicle.Model");
			txtUpdateOwnerName.DataBindings.Add("Text", DM.dsGreen, "Owner.LastName");
			txtUpdatePlateNumber.Enabled = false;
			txtUpdateMake.Enabled = false;
			txtUpdateModel.Enabled = false;
			txtUpdateOwnerName.Enabled = false;

			lstVehicle.DataSource = DM.dsGreen;
			lstVehicle.DisplayMember = "Vehicle.PlateNumber";
			lstVehicle.ValueMember = "Vehicle.PlateNumber";
			currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreen, "VEHICLE"];
			cmOwner = (CurrencyManager)this.BindingContext[DM.dsGreen, "OWNER"];

		}
		private DataModule DM;
		private MainForm frmMenu;
		private CurrencyManager currencyManager;
		private CurrencyManager cmOwner;
		public VehicleForm(DataModule dm, MainForm mnu)
		{
			InitializeComponent();
			DM = dm;
			frmMenu = mnu;
			BindControls();

			//initialising owner name

			cmOwner.Position = (0);
			DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
			txtOwnerName.Text = drOwner["FirstName"].ToString();
			txtOwnerName.AppendText(" ");
			txtOwnerName.AppendText(drOwner["LastName"].ToString());

			pnlAddVehicle.Left = 369;
			pnlAddVehicle.Top = 43;

			pnlUpdateVehicle.Left = 369;
			pnlUpdateVehicle.Top = 43;

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
			getOwnerName();

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (currencyManager.Position < currencyManager.Count - 1)
			{
				++currencyManager.Position;
			}
			getOwnerName();

		}

		private void btnDeleteVehicle_Click(object sender, EventArgs e)
		{
			DataRow deleteVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];
			DataRow[] ServiceRow = DM.dtService.Select("VehicleID = " + lblVehicleID.Text);
			if (ServiceRow.Length != 0)
			{
				MessageBox.Show("You may only delete Vehicles that are not allocated to a Service", "Error");
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
				MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					deleteVehicleRow.Delete();
					DM.UpdateVehicle();
				}
			}
		}

		private void btnAddVehicle_Click(object sender, EventArgs e)
		{
			lstVehicle.Visible = false;
			btnDeleteVehicle.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnUpdateVehicle.Enabled = false;
			btnAddVehicle.Enabled = true;
			txtAddPlateNumber.Enabled = true;
			txtAddMake.Enabled = true;
			txtAddModel.Enabled = true;
			cmbAddOwnerID.Enabled = true;
			cmbAddOwnerName.Enabled = true;
			pnlAddVehicle.Show();
		}

		private void btnAddCancel_Click(object sender, EventArgs e)
		{
			pnlAddVehicle.Hide();
			lstVehicle.Enabled = true;
			lstVehicle.Visible = true;
			btnDeleteVehicle.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateVehicle.Enabled = true;
			btnAddVehicle.Enabled = true;
			txtAddPlateNumber.Enabled = false;
			txtAddMake.Enabled = false;
			txtAddModel.Enabled = false;
			cmbAddOwnerID.Enabled = false;
			cmbAddOwnerName.Enabled = false;
		}

		private void btnSaveVehicle_Click(object sender, EventArgs e)
		{
			lblVehicleID.Text = null;
			DataRow newVehicleRow = DM.dtVehicle.NewRow();
			if ((txtAddPlateNumber.Text == "") || (txtAddMake.Text == "") ||
				(txtAddModel.Text == ""))

			{
				MessageBox.Show("Values must be entered for all fields.", "Error");
			}
			else
			{
				try
				{
					newVehicleRow["PlateNumber"] = txtAddPlateNumber.Text;
					newVehicleRow["Make"] = txtAddMake.Text;
					newVehicleRow["Model"] = txtAddModel.Text;
					newVehicleRow["OwnerID"] = cmbAddOwnerID.Text;
					DM.dtVehicle.Rows.Add(newVehicleRow);
					MessageBox.Show("Vehicle added successfully", "Success");
					DM.UpdateVehicle();
				}
				catch (FormatException ex)
				{
					MessageBox.Show("Please enter a number for cost", "Error");
				}
			}
		}

		private void btnUpdateVehicle_Click(object sender, EventArgs e)
		{
			DataRow updateVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];

			lstVehicle.Visible = false;
			btnDeleteVehicle.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnAddVehicle.Enabled = false;
			txtUpdatePlateNumber.Enabled = true;
			txtUpdateMake.Enabled = true;
			txtUpdateModel.Enabled = true;
			pnlUpdateVehicle.Visible = true;
			pnlUpdateVehicle.Show();
		}

		private void btnUpdateCancel_Click(object sender, EventArgs e)
		{
			pnlUpdateVehicle.Hide();
			lstVehicle.Enabled = true;
			lstVehicle.Visible = true;
			btnDeleteVehicle.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateVehicle.Enabled = true;
			btnAddVehicle.Enabled = true;
			txtUpdatePlateNumber.Enabled = false;
			txtUpdateMake.Enabled = false;
			txtUpdateModel.Enabled = false;
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			DataRow updateVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];

			if ((txtUpdatePlateNumber.Text == "") || (txtUpdateMake.Text == "") ||
				(txtUpdateModel.Text == ""))
			{
				MessageBox.Show("Values must be entered for all fields.", "Error");
			}
			else
			{
				updateVehicleRow["PlateNumber"] = (txtUpdatePlateNumber.Text);
				updateVehicleRow["Make"] = txtUpdateMake.Text;
				updateVehicleRow["Model"] = txtUpdateModel.Text;
				currencyManager.EndCurrentEdit();
				DM.UpdateVehicle();
				MessageBox.Show("Vehicle updated successfully", "Success");
			}
		}

		private void lstVehicle_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lstVehicle_Click(object sender, EventArgs e)
		{
			getOwnerName();
		}
	}
}
