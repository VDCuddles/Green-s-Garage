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
	public partial class EquipmentForm : Form
	{
		public void BindControls()
		{
			lblEquipmentID.DataBindings.Add("Text", DM.dsGreen, "Equipment.EquipmentID");
			txtDescription.DataBindings.Add("Text", DM.dsGreen, "Equipment.Description");

			txtDescription.Enabled = false;

			txtAddDescription.Enabled = false;

			lblUpdateEquipmentID.DataBindings.Add("Text", DM.dsGreen, "Equipment.EquipmentID");
			txtUpdateDescription.DataBindings.Add("Text", DM.dsGreen, "Equipment.Description");
			txtUpdateDescription.Enabled = false;

			lstEquipment.DataSource = DM.dsGreen;
			lstEquipment.DisplayMember = "Equipment.Description";
			lstEquipment.ValueMember = "Equipment.Description";
			currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreen, "EQUIPMENT"];
		}

		private DataModule DM;
		private MainForm frmMenu;
		private CurrencyManager currencyManager;
		public EquipmentForm(DataModule dm, MainForm mnu)
		{
			InitializeComponent();
			DM = dm;
			frmMenu = mnu;
			BindControls();

			pnlAddEquipment.Left = 359;
			pnlAddEquipment.Top = 83;

			pnlUpdateEquipment.Left = 359;
			pnlUpdateEquipment.Top = 83;
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

		private void btnReturn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAddEquipment_Click(object sender, EventArgs e)
		{
			lstEquipment.Visible = false;
			btnDeleteEquipment.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnUpdateEquipment.Enabled = false;
			btnAddEquipment.Enabled = true;
			txtAddDescription.Enabled = true;
			pnlAddEquipment.Show();
		}

		private void btnAddCancel_Click(object sender, EventArgs e)
		{
			pnlAddEquipment.Hide();
			lstEquipment.Enabled = true;
			lstEquipment.Visible = true;
			btnDeleteEquipment.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateEquipment.Enabled = true;
			btnAddEquipment.Enabled = true;
			txtAddDescription.Enabled = false;
		}

		private void btnSaveEquipment_Click(object sender, EventArgs e)
		{
			lblEquipmentID.Text = null;
			DataRow newEquipmentRow = DM.dtEquipment.NewRow();
			if (txtAddDescription.Text == "")

			{
				MessageBox.Show("Value must be entered for description.", "Error");
			}
			else
			{
				try
				{
					newEquipmentRow["Description"] = txtAddDescription.Text;
					DM.dtEquipment.Rows.Add(newEquipmentRow);
					MessageBox.Show("Equipment added successfully", "Success");
					DM.UpdateEquipment();
				}
				catch (FormatException ex)
				{
					MessageBox.Show("Please enter a number for cost", "Error");
				}
			}
		}

		private void btnDeleteEquipment_Click(object sender, EventArgs e)
		{
			DataRow deleteEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
			DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("EquipmentID = " + lblEquipmentID.Text);
			if (ServiceTypeEquipmentRow.Length != 0)
			{
				MessageBox.Show("You may only delete Equipment that are not allocated to a Service Type", "Error");
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
				MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					deleteEquipmentRow.Delete();
					DM.UpdateEquipment();
				}
			}
		}

		private void btnUpdateEquipment_Click(object sender, EventArgs e)
		{
			DataRow updateEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];

			lstEquipment.Visible = false;
			btnDeleteEquipment.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnAddEquipment.Enabled = false;
			txtUpdateDescription.Enabled = true;
			pnlUpdateEquipment.Visible = true;
			pnlUpdateEquipment.Show();
		}

		private void btnUpdateCancel_Click(object sender, EventArgs e)
		{
			pnlUpdateEquipment.Hide();
			lstEquipment.Enabled = true;
			lstEquipment.Visible = true;
			btnDeleteEquipment.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnUpdateEquipment.Enabled = true;
			btnAddEquipment.Enabled = true;
			txtUpdateDescription.Enabled = false;
		}

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			DataRow updateEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];

			if (txtUpdateDescription.Text == "")
			{
				MessageBox.Show("Value must be entered for description.", "Error");
			}
			else
			{
				updateEquipmentRow["Description"] = txtUpdateDescription.Text;
				currencyManager.EndCurrentEdit();
				DM.UpdateEquipment();
				MessageBox.Show("Equipment updated successfully", "Success");
			}
		}
	}


}
