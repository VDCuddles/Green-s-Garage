using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Greens_Garage
{
	public partial class DataModule : Form
	{
		public DataTable dtEquipment;
		public DataTable dtOwner;
		public DataTable dtService;
		public DataTable dtServiceType;
		public DataTable dtServiceTypeEquipment;
		public DataTable dtVehicle;
		public DataView equipmentView;
		public DataView serviceTypeView;
		public DataView ownerView;
		public DataView vehicleView;

		public DataModule()
		{
			InitializeComponent();
			dsGreen.EnforceConstraints = false;
			daEquipment.Fill(dsGreen);
			daOwner.Fill(dsGreen);
			daService.Fill(dsGreen);
			daServiceType.Fill(dsGreen);
			daServiceTypeEquipment.Fill(dsGreen);
			daVehicle.Fill(dsGreen);
			dtEquipment = dsGreen.Tables["Equipment"];
			dtOwner = dsGreen.Tables["Owner"];
			dtService = dsGreen.Tables["Service"];
			dtServiceType = dsGreen.Tables["ServiceType"];
			dtServiceTypeEquipment = dsGreen.Tables["ServiceTypeEquipment"];
			dtVehicle = dsGreen.Tables["Vehicle"];
			vehicleView = new DataView(dtVehicle);
			vehicleView.Sort = "vehicleID";
			ownerView = new DataView(dtOwner);
			ownerView.Sort = "OwnerID";
			serviceTypeView = new DataView(dtServiceType);
			serviceTypeView.Sort = "ServiceTypeID";
			equipmentView = new DataView(dtEquipment);
			equipmentView.Sort = "EquipmentID";	


			dsGreen.EnforceConstraints = true;
		}

		public void UpdateOwner()
		{
			daOwner.Update(dtOwner);
		}

		public void UpdateServiceType()
		{
			daServiceType.Update(dtServiceType);
		}

		public void UpdateEquipment()
		{
			daEquipment.Update(dtEquipment);
		}

		public void UpdateVehicle()
		{
			daVehicle.Update(dtVehicle);
		}

		public void UpdateService()
		{
			daService.Update(dtService);
		}

		public void UpdateServiceTypeEquipment()
		{
			daServiceTypeEquipment.Update(dtServiceTypeEquipment);
		}

		private void daOwner_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
		{
			int newID = 0;
			OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreen);
			if (e.StatementType == StatementType.Insert)
			{
				newID = (int)idCMD.ExecuteScalar();
				e.Row["OwnerID"] = newID;
			}
		}

		private void daServiceType_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
		{
			int newID = 0;
			OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreen);
			if (e.StatementType == StatementType.Insert)
			{
				newID = (int)idCMD.ExecuteScalar();
				e.Row["ServiceTypeID"] = newID;
			}
		}

		private void daEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
		{
			int newID = 0;
			OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreen);
			if (e.StatementType == StatementType.Insert)
			{
				newID = (int)idCMD.ExecuteScalar();
				e.Row["EquipmentID"] = newID;
			}
		}

		private void daVehicle_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
		{
			int newID = 0;
			OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreen);
			if (e.StatementType == StatementType.Insert)
			{
				newID = (int)idCMD.ExecuteScalar();
				e.Row["VehicleID"] = newID;
			}
		}

		private void daService_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
		{
			int newID = 0;
			OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreen);
			if (e.StatementType == StatementType.Insert)
			{
				newID = (int)idCMD.ExecuteScalar();
				e.Row["ServiceID"] = newID;
			}
		}

		private void daServiceTypeEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
		{
			int newID = 0;
			OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreen);
			if (e.StatementType == StatementType.Insert)
			{
				newID = (int)idCMD.ExecuteScalar();
				e.Row["ServiceTypeID"] = newID;
			}
		}
	}
}
