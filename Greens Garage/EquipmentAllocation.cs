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
	public partial class EquipmentAllocationForm : Form
	{
		private DataModule DM;
		private MainForm frmMenu;
		private CurrencyManager cmEquipment;
		private CurrencyManager cmServiceType;
		private CurrencyManager cmServiceTypeEquipment;
		private DataTable dt = new DataTable();
		private CurrencyManager cmDt;


		public void BindControls()
		{
			dgvEquipment.DataSource = DM.dsGreen;
			dgvEquipment.DataMember = "Equipment";

			dgvServiceType.DataSource = DM.dsGreen;
			dgvServiceType.DataMember = "ServiceType";

			dgvServiceTypeEquipment.DataSource = DM.dsGreen;
			dgvServiceTypeEquipment.DataMember = "ServiceTypeEquipment";
		}
		public EquipmentAllocationForm(DataModule dm, MainForm mnu)
		{
			InitializeComponent();
			DM = dm;
			frmMenu = mnu;
			cmEquipment = (CurrencyManager)this.BindingContext[DM.dsGreen, "Equipment"];
			cmServiceType = (CurrencyManager)this.BindingContext[DM.dsGreen, "ServiceType"];
			cmServiceTypeEquipment = (CurrencyManager)this.BindingContext[DM.dsGreen, "ServiceTypeEquipment"];
			cmDt = (CurrencyManager)this.BindingContext[dt];
			BindControls();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAllocateEquipment_Click(object sender, EventArgs e)
		{
			try
			{
				if (DM.dtServiceTypeEquipment.Rows[cmServiceTypeEquipment.Position]["EquipmentID"].ToString() != 
					DM.dtEquipment.Rows[cmEquipment.Position]["EquipmentID"].ToString())
				{
					MessageBox.Show("Item of equipment allocated successfully", "Error");
					DataRow newServiceTypeEquipment = DM.dtServiceTypeEquipment.NewRow();
					newServiceTypeEquipment["ServiceTypeID"] = dgvServiceType["ServiceTypeID", cmServiceType.Position].Value;
					newServiceTypeEquipment["EquipmentID"] = dgvEquipment["EquipmentID", cmEquipment.Position].Value;
					DM.dsGreen.Tables["ServiceTypeEquipment"].Rows.Add(newServiceTypeEquipment); //add a new row to dataset
					DM.UpdateServiceTypeEquipment(); //update database
				}
				else
				{
					MessageBox.Show("This item of equipment has already been allocated to this service type", "Error");
				}
			}
			catch (ConstraintException)
			{
				MessageBox.Show("This item of equipment has already been allocated to this service type.", "Error");
			}

		}

		private void btnRemoveEquipment_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
			MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				string ServiceTypeID = DM.dtServiceTypeEquipment.Rows[cmServiceTypeEquipment.Position]["ServiceTypeID"].ToString();
				string EquipmentID = dgvServiceTypeEquipment.Rows[cmServiceTypeEquipment.Position].Cells[1].Value.ToString();
				int row = 0;
				for (int i = 0; i < DM.dtServiceTypeEquipment.Rows.Count; i++)
				{
					string sID = DM.dtServiceTypeEquipment.Rows[i]["ServiceTypeID"].ToString();
					string eID = DM.dtServiceTypeEquipment.Rows[i]["EquipmentID"].ToString();
					if (ServiceTypeID == sID && EquipmentID == eID)
					{
						row = i;
					}
				}
				DataRow dr = DM.dsGreen.Tables["ServiceTypeEquipment"].Rows[row];
				dr.Delete();
				DM.UpdateServiceTypeEquipment(); //update database
			}


		}
	}


}

//private void btnDeleteOwner_Click(object sender, EventArgs e)
//{
//	DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
//	DataRow[] VehicleRow = DM.dtVehicle.Select("OwnerID = " + lblOwnerID.Text);
//	if (VehicleRow.Length != 0)
//	{
//		MessageBox.Show("You may only delete owners that are not allocated to vehicles", "Error");
//	}
//	else
//	{
//		if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
//		MessageBoxButtons.OKCancel) == DialogResult.OK)
//		{
//			deleteOwnerRow.Delete();
//			DM.UpdateOwner();
//		}
//	}
//}