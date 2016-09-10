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
	public partial class ServiceTypeForm : Form
	{
		public void BindControls()
		{
			lblServiceTypeID.DataBindings.Add("Text", DM.dsGreen, "ServiceType.ServiceTypeID");
			txtDescription.DataBindings.Add("Text", DM.dsGreen, "ServiceType.Description");
			txtHourlyRate.DataBindings.Add("Text", DM.dsGreen, "ServiceType.HourlyRate");

			txtDescription.Enabled = false;
			txtHourlyRate.Enabled = false;

			txtAddDescription.Enabled = false;
			txtAddHourlyRate.Enabled = false;



			lblUpdateServiceTypeID.DataBindings.Add("Text", DM.dsGreen, "ServiceType.ServiceTypeID");
			txtUpdateDescription.DataBindings.Add("Text", DM.dsGreen, "ServiceType.Description");
			txtUpdateHourlyRate.DataBindings.Add("Text", DM.dsGreen, "ServiceType.HourlyRate");
			txtUpdateDescription.Enabled = false;
			txtUpdateHourlyRate.Enabled = false;

			lstServiceType.DataSource = DM.dsGreen;
			lstServiceType.DisplayMember = "ServiceType.Description";
			lstServiceType.ValueMember = "ServiceType.Description";
			currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreen, "SERVICETYPE"];
		}
		private DataModule DM;
		private MainForm frmMenu;
		private CurrencyManager currencyManager;
		public ServiceTypeForm(DataModule dm, MainForm mnu)
		{
			InitializeComponent();
			DM = dm;
			frmMenu = mnu;
			BindControls();

			pnlAddServiceType.Left = 369;
			pnlAddServiceType.Top = 83;

			pnlUpdateServiceType.Left = 369;
			pnlUpdateServiceType.Top = 83;

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

		private void btnDeleteServiceType_Click(object sender, EventArgs e)
		{
				DataRow deleteServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
				DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("ServiceTypeID = " + lblServiceTypeID.Text);
				if (ServiceTypeEquipmentRow.Length != 0)
				{
					MessageBox.Show("You may only delete Service Types that are not allocated to Equipment", "Error");
				}
				else
				{
					if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
					MessageBoxButtons.OKCancel) == DialogResult.OK)
					{
					deleteServiceTypeRow.Delete();
						DM.UpdateServiceType();
					}
				}
		}

		private void btnAddServiceType_Click(object sender, EventArgs e)
		{
			lstServiceType.Visible = false;
			btnDeleteServiceType.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnUpdateServiceType.Enabled = false;
			btnAddServiceType.Enabled = true;
			txtAddDescription.Enabled = true;
			txtAddHourlyRate.Enabled = true;
			pnlAddServiceType.Show();
		}

		private void btnAddCancel_Click(object sender, EventArgs e)
		{
			pnlAddServiceType.Hide();
			lstServiceType.Enabled = true;
			lstServiceType.Visible = true;
			btnDeleteServiceType.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateServiceType.Enabled = true;
			btnAddServiceType.Enabled = true;
			txtAddDescription.Enabled = false;
			txtAddHourlyRate.Enabled = false;
		}

		private void btnSaveServiceType_Click(object sender, EventArgs e)
		{
			lblServiceTypeID.Text = null;
			DataRow newServiceTypeRow = DM.dtServiceType.NewRow();
			if ((txtAddDescription.Text == "") || (txtAddHourlyRate.Text == ""))

			{
				MessageBox.Show("Values must be entered for description as well as hourly rate.", "Error");
			}
			else
			{
				try
				{
					newServiceTypeRow["Description"] = txtAddDescription.Text;
					newServiceTypeRow["HourlyRate"] = txtAddHourlyRate.Text;
					DM.dtServiceType.Rows.Add(newServiceTypeRow);
					MessageBox.Show("Service Type added successfully", "Success");
					DM.UpdateServiceType();
				}
				catch (FormatException ex)
				{
					MessageBox.Show("Please enter a number for cost", "Error");
				}
			}
		}

		private void btnUpdateServiceType_Click(object sender, EventArgs e)
		{
			DataRow updateServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];

			lstServiceType.Visible = false;
			btnDeleteServiceType.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnAddServiceType.Enabled = false;
			txtUpdateDescription.Enabled = true;
			txtUpdateHourlyRate.Enabled = true;
			pnlUpdateServiceType.Visible = true;
			pnlUpdateServiceType.Show();
		}

		private void btnUpdateCancel_Click(object sender, EventArgs e)
		{
			pnlUpdateServiceType.Hide();
			lstServiceType.Enabled = true;
			lstServiceType.Visible = true;
			btnDeleteServiceType.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateServiceType.Enabled = true;
			btnAddServiceType.Enabled = true;
			txtUpdateDescription.Enabled = false;
			txtUpdateHourlyRate.Enabled = false;
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			DataRow updateServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];

			if ((txtUpdateDescription.Text == "") || (txtUpdateHourlyRate.Text == ""))
			{
				MessageBox.Show("Values must be entered for description as well as hourly rate.", "Error");
			}
			else
			{
				updateServiceTypeRow["Description"] = txtUpdateDescription.Text;
				updateServiceTypeRow["HourlyRate"] = txtUpdateHourlyRate.Text;
				currencyManager.EndCurrentEdit();
				DM.UpdateServiceType();
				MessageBox.Show("Service Type updated successfully", "Success");
			}
		}
	}
}
