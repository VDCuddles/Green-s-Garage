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
	public partial class ServiceForm : Form
	{

		public void getPlateNumber()
		{
			int aVehicleID = Convert.ToInt32(txtVehicleID.Text);
			cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
			DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

			txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
		}

		public void getOwnerName()
		{
			int aVehicleID = Convert.ToInt32(txtVehicleID.Text);
			cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
			DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

			int aOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
			cmOwner.Position = DM.ownerView.Find(aOwnerID);
			DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

			txtOwnerName.Text = drOwner["FirstName"].ToString();
			txtOwnerName.AppendText(" ");
			txtOwnerName.AppendText(drOwner["LastName"].ToString());
		}

		public void getServiceType()
		{
			int aServiceTypeID = Convert.ToInt32(txtServiceTypeID.Text);
			cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
			DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];

			txtServiceType.Text = drServiceType["Description"].ToString();
		}

		public void getHourlyRate()
		{
			int aServiceTypeID = Convert.ToInt32(txtServiceTypeID.Text);
			cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
			DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];

			txtHourlyRate.Text = drServiceType["HourlyRate"].ToString();
		}

		public void BindControls()
		{
			txtVehicleID.DataBindings.Add("Text", DM.dsGreen, "Service.VehicleID");
			txtServiceTypeID.DataBindings.Add("Text", DM.dsGreen, "Service.ServiceTypeID");
			txtHours.DataBindings.Add("Text", DM.dsGreen, "Service.Hours");
			txtServiceDate.DataBindings.Add("Text", DM.dsGreen, "Service.ServiceDate");
			txtStatus.DataBindings.Add("Text", DM.dsGreen, "Service.Status");

			txtPlateNumber.Enabled = false;
			txtOwnerName.Enabled = false;
			txtServiceType.Enabled = false;
			txtHourlyRate.Enabled = false;

			txtVehicleID.Enabled = false;
			txtServiceTypeID.Enabled = false;
			txtHours.Enabled = false;
			txtServiceDate.Enabled = false;
			txtStatus.Enabled = false;

			cboAddVehicleID.Enabled = false;
			cboAddVehiclePlateNumber.Enabled = false;
			cboAddServiceTypeID.Enabled = false;
			cboAddServiceTypeDescription.Enabled = false;
			txtAddHours.Enabled = false;
			dtpServiceDate.Enabled = false;
			cboAddVehicleID.DataSource = DM.dsGreen;
			cboAddVehicleID.DisplayMember = "Vehicle.VehicleID";
			cboAddVehicleID.ValueMember = "Vehicle.VehicleID";
			cboAddServiceTypeID.DataSource = DM.dsGreen;
			cboAddServiceTypeID.DisplayMember = "ServiceType.ServiceTypeID";
			cboAddServiceTypeID.ValueMember = "ServiceType.ServiceTypeID";
			cboAddVehiclePlateNumber.DataSource = DM.dsGreen;
			cboAddVehiclePlateNumber.DisplayMember = "Vehicle.PlateNumber";
			cboAddVehiclePlateNumber.ValueMember = "Vehicle.PlateNumber";
			cboAddServiceTypeDescription.DataSource = DM.dsGreen;
			cboAddServiceTypeDescription.DisplayMember = "ServiceType.Description";
			cboAddServiceTypeDescription.ValueMember = "ServiceType.Description";


			cboUpdateVehicleID.DataSource = DM.dsGreen;
			cboUpdateVehicleID.DisplayMember = "Vehicle.VehicleID";
			cboUpdateVehicleID.ValueMember = "Vehicle.VehicleID";
			cboUpdateServiceTypeID.DataSource = DM.dsGreen;
			cboUpdateServiceTypeID.DisplayMember = "ServiceType.ServiceTypeID";
			cboUpdateServiceTypeID.ValueMember = "ServiceType.ServiceTypeID";
			cboUpdateVehiclePlateNumber.DataSource = DM.dsGreen;
			cboUpdateVehiclePlateNumber.DisplayMember = "Vehicle.PlateNumber";
			cboUpdateVehiclePlateNumber.ValueMember = "Vehicle.PlateNumber";
			cboUpdateServiceTypeDescription.DataSource = DM.dsGreen;
			cboUpdateServiceTypeDescription.DisplayMember = "ServiceType.Description";
			cboUpdateServiceTypeDescription.ValueMember = "ServiceType.Description";
			txtUpdateHours.DataBindings.Add("Text", DM.dsGreen, "Service.Hours");

			dgvService.DataSource = DM.dsGreen;
			dgvService.DataMember = "Service";
			dgvService.ReadOnly = true;
			currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreen, "SERVICE"];
			cmVehicle = (CurrencyManager)this.BindingContext[DM.dsGreen, "VEHICLE"];
			cmOwner = (CurrencyManager)this.BindingContext[DM.dsGreen, "OWNER"];
			cmServiceType = (CurrencyManager)this.BindingContext[DM.dsGreen, "SERVICETYPE"];
		}
		private DataModule DM;
		private MainForm frmMenu;
		private CurrencyManager currencyManager;
		private CurrencyManager cmOwner;
		private CurrencyManager cmVehicle;
		private CurrencyManager cmServiceType;

		public ServiceForm(DataModule dm, MainForm mnu)
		{
			InitializeComponent();
			DM = dm;
			frmMenu = mnu;
			BindControls();

			pnlAddService.Left = 428;
			pnlAddService.Top = 32;

			pnlUpdateService.Left = 428;
			pnlUpdateService.Top = 32;

			//initialise plate number

			cmVehicle.Position = (0);
			DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

			txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();

			//initialise owner

			cmVehicle.Position = (0);
			DataRow drVehicle2 = DM.dtVehicle.Rows[cmVehicle.Position];

			cmOwner.Position = (0);
			DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

			txtOwnerName.Text = drOwner["FirstName"].ToString();
			txtOwnerName.AppendText(" ");
			txtOwnerName.AppendText(drOwner["LastName"].ToString());

			//initialise service type

			cmServiceType.Position = (0);
			DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];

			txtServiceType.Text = drServiceType["Description"].ToString();

			//initialise hourly rate

			cmServiceType.Position = (0);
			DataRow drServiceType2 = DM.dtServiceType.Rows[cmServiceType.Position];

			txtHourlyRate.Text = drServiceType["HourlyRate"].ToString();

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
			getPlateNumber();
			getOwnerName();
			getServiceType();
			getHourlyRate();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (currencyManager.Position < currencyManager.Count - 1)
			{
				++currencyManager.Position;
			}
			getPlateNumber();
			getOwnerName();
			getServiceType();
			getHourlyRate();
		}

		private void dgvService_Click(object sender, EventArgs e)
		{
			getPlateNumber();
			getOwnerName();
			getServiceType();
			getHourlyRate();
		}

		private void btnAddService_Click(object sender, EventArgs e)
		{
			dgvService.Visible = false;
			btnDeleteService.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnUpdateService.Enabled = false;
			btnAddService.Enabled = true;
			cboAddVehicleID.Enabled = true;
			cboAddVehiclePlateNumber.Enabled = true;
			cboAddServiceTypeID.Enabled = true;
			cboAddServiceTypeDescription.Enabled = true;
			txtAddHours.Enabled = true;
			dtpServiceDate.Enabled = true;
			pnlAddService.Show();
			pnlGetData.Visible = false;
		}

		private void btnAddCancel_Click(object sender, EventArgs e)
		{
			pnlAddService.Hide();
			dgvService.Enabled = true;
			dgvService.Visible = true;
			btnDeleteService.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateService.Enabled = true;
			btnAddService.Enabled = true;
			cboAddVehicleID.Enabled = false;
			cboAddVehiclePlateNumber.Enabled = false;
			cboAddServiceTypeID.Enabled = false;
			cboAddServiceTypeDescription.Enabled = false;
			txtAddHours.Enabled = false;
			dtpServiceDate.Enabled = false;
			pnlGetData.Visible = true;
		}

		private void cboAddServiceTypeDescription_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cboAddServiceTypeID_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cboAddVehiclePlateNumber_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cboAddVehicleID_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cboAddServiceTypeDescription_Click(object sender, EventArgs e)
		{

		}

		private void ServiceForm_TextChanged(object sender, EventArgs e)
		{

		}

		private void cboAddServiceTypeDescription_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSaveService_Click(object sender, EventArgs e)
		{
			DataRow newServiceRow = DM.dtService.NewRow();
			if (txtAddHours.Text == "")

			{
				MessageBox.Show("Please specify hours spent.", "Error");
			}
			else
			{
				try
				{
					newServiceRow["VehicleID"] = cboAddVehicleID.Text;
					newServiceRow["ServiceTypeID"] = cboAddServiceTypeID.Text;
					newServiceRow["Hours"] = txtAddHours.Text;
					newServiceRow["ServiceDate"] = dtpServiceDate.Text;
					newServiceRow["Status"] = "Pending";
					DM.dtService.Rows.Add(newServiceRow);
					MessageBox.Show("Service added successfully", "Success");
					DM.UpdateService();
				}
				catch (FormatException ex)
				{
					MessageBox.Show("Please enter a number for hours", "Error");
				}
			}
		}

		private void btnDeleteService_Click(object sender, EventArgs e)
		{
			DataRow deleteServiceRow = DM.dtService.Rows[currencyManager.Position];

			if (deleteServiceRow["Status"].ToString() != "Paid")
			{
				MessageBox.Show("You may only delete paid services.", "Error");
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
				MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					deleteServiceRow.Delete();
					DM.UpdateVehicle();
				}
			}
		}

		private void btnMarkServiceAsPaid_Click(object sender, EventArgs e)
		{
			DataRow markPaidRow = DM.dtService.Rows[currencyManager.Position];

			if (markPaidRow["Status"].ToString() != "Pending")
			{
				MessageBox.Show("You may only mark pending services as paid.", "Error");
			}
			else
			{
				markPaidRow["Status"] = "Paid";
				MessageBox.Show("Service marked as Paid.");
			}
		}

		private void btnUpdateService_Click(object sender, EventArgs e)
		{
			DataRow updateVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];

			dgvService.Visible = false;
			btnDeleteService.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnAddService.Enabled = false;
			btnMarkServiceAsPaid.Enabled = false;
			cboUpdateVehicleID.Enabled = true;
			cboUpdateVehiclePlateNumber.Enabled = true;
			cboUpdateServiceTypeID.Enabled = true;
			cboUpdateServiceTypeDescription.Enabled = true;
			txtUpdateHours.Enabled = true;
			dtpUpdateServiceDate.Enabled = true;
			pnlUpdateService.Visible = true;
			pnlUpdateService.Show();
		}

		private void btnUpdateCancel_Click(object sender, EventArgs e)
		{
			pnlUpdateService.Hide();
			dgvService.Enabled = true;
			dgvService.Visible = true;
			btnDeleteService.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateService.Enabled = true;
			btnMarkServiceAsPaid.Enabled = true;
			btnAddService.Enabled = true;
			cboUpdateVehicleID.Enabled = false;
			cboUpdateVehiclePlateNumber.Enabled = false;
			cboUpdateServiceTypeID.Enabled = false;
			cboUpdateServiceTypeDescription.Enabled = false;
			txtUpdateHours.Enabled = false;
			dtpUpdateServiceDate.Enabled = false;
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			DataRow updateServiceRow = DM.dtService.Rows[currencyManager.Position];

			if (txtUpdateHours.Text == "")

			{
				MessageBox.Show("Please specify hours spent.", "Error");
			}
			else
			{
				updateServiceRow["VehicleID"] = cboUpdateVehicleID.Text;
				updateServiceRow["ServiceTypeID"] = cboUpdateServiceTypeID.Text;
				updateServiceRow["Hours"] = txtUpdateHours.Text;
				updateServiceRow["ServiceDate"] = dtpUpdateServiceDate.Text;
				currencyManager.EndCurrentEdit();
				DM.UpdateService();
				MessageBox.Show("Service updated successfully", "Success");
			}
		}
	}
}
