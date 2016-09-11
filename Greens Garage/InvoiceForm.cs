using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this code with reference to Wallace Events solution - concertreportform.cs
//and also StageForm.cs/lblStageID_TextChanged()

namespace Greens_Garage
{
	public partial class InvoiceForm : Form
	{
		
		private DataModule DM;
		private MainForm frmMenu;
		CurrencyManager cmServiceType;
		CurrencyManager cmOwner;
		CurrencyManager cmVehicle;
		CurrencyManager cmServiceTypeEquipment;
		CurrencyManager cmEquipment;
		private int amountOfInvoicesPrinted, pagesAmountExpected;
		private DataRow[] invoicesForPrint;
		public DataRow drInvoices;

		public InvoiceForm(DataModule dm, MainForm mnu)
		{
			InitializeComponent();
			DM = dm;
			frmMenu = mnu;
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnPrintInvoices_Click(object sender, EventArgs e)
		{
			amountOfInvoicesPrinted = 0;
			string strFilter = "Status = 'Pending'";
			string strSort = "VehicleID";

			invoicesForPrint = DM.dsGreen.Tables["SERVICE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
			pagesAmountExpected = invoicesForPrint.Length;
			prvInvoices.Show();
		}

		private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			Font textFont = new Font("Arial", 10, FontStyle.Regular);
			Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
			Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
			Font headingFont = new Font("Arial", 10, FontStyle.Bold);

			DataRow drInvoices = invoicesForPrint[amountOfInvoicesPrinted];


			cmServiceType= (CurrencyManager)this.BindingContext[DM.dsGreen, "SERVICE"];
			cmOwner = (CurrencyManager)this.BindingContext[DM.dsGreen, "OWNER"];
			cmVehicle = (CurrencyManager)this.BindingContext[DM.dsGreen, "VEHICLE"];
			cmServiceTypeEquipment = (CurrencyManager)this.BindingContext[DM.dsGreen, "SERVICETYPEEQUIPMENT"];
			cmEquipment = (CurrencyManager)this.BindingContext[DM.dsGreen, "EQUIPMENT"];

			Brush brush = new SolidBrush(Color.Black);

			//margins
			int leftMargin = e.MarginBounds.Left;
			int topMargin = e.MarginBounds.Top;
			int headingLeftMargin = 50;
			int topMarginDetails = topMargin + 70;
			int rightMargin = e.MarginBounds.Right;

			//print details

			g.DrawString(getOwnerDetails(drInvoices) + getVehicleDetails(drInvoices) + getServiceDetails(drInvoices), headingFont, brush, leftMargin + headingLeftMargin, topMargin);
	
			amountOfInvoicesPrinted++;

			if (!(amountOfInvoicesPrinted == pagesAmountExpected))
			{
				e.HasMorePages = true;
			}
		}

		//return owner details as a string to be printed
		public string getOwnerDetails(DataRow dataRow)
		{
			int aVehicleID = Convert.ToInt32(dataRow["VehicleID"].ToString());
			cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
			DataRow drInvoices = DM.dtVehicle.Rows[cmVehicle.Position];

			int aOwnerID = Convert.ToInt32(drInvoices["OwnerID"].ToString());
			cmOwner.Position = DM.ownerView.Find(aOwnerID);
			DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

			string ownerFullDetails = drOwner["FirstName"].ToString();
			ownerFullDetails += " ";
			ownerFullDetails += drOwner["LastName"].ToString();
			ownerFullDetails += "\r\n";
			ownerFullDetails += (drOwner["StreetAddress"].ToString());
			ownerFullDetails += "\r\n";
			ownerFullDetails += (drOwner["Suburb"].ToString());
			ownerFullDetails += "\r\n";
			ownerFullDetails += "Auckland";
			ownerFullDetails += "\r\n";
			ownerFullDetails += "\r\n";

			return ownerFullDetails;
		}
		//return vehicle details as a string to be printed
		public string getVehicleDetails(DataRow dataRow)
		{
			int aVehicleID = Convert.ToInt32(dataRow["VehicleID"].ToString());
			cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
			DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

			string vehicleFullDetails = "Vehicle ID: ";
			vehicleFullDetails += drVehicle["VehicleID"].ToString();
			vehicleFullDetails += "\t";
			vehicleFullDetails += "Plate Number: ";
			vehicleFullDetails += drVehicle["PlateNumber"].ToString();
			vehicleFullDetails += "\r\n";
			vehicleFullDetails += "Make: ";
			vehicleFullDetails += "\t";
			vehicleFullDetails += (drVehicle["Make"].ToString());
			vehicleFullDetails += "\r\n";
			vehicleFullDetails += "Model: ";
			vehicleFullDetails += (drVehicle["Model"].ToString());
			vehicleFullDetails += "\r\n";
			vehicleFullDetails += "\r\n";

			return vehicleFullDetails;
		}
		//return service details, equipment details and gross due as a string to be printed
		public string getServiceDetails(DataRow dataRow)
		{
			int aServiceID = Convert.ToInt32(dataRow["ServicetypeID"].ToString());
			cmServiceType.Position = DM.serviceTypeView.Find(aServiceID);
			DataRow drService = DM.dtServiceType.Rows[cmServiceType.Position];

			string fullDate = (dataRow["ServiceDate"].ToString());
			string simpleDate = (fullDate.Substring(0, fullDate.Length - 14));

			double dubHours = Convert.ToInt32(dataRow["Hours"].ToString());
			double dubRate = Convert.ToInt32(drService["HourlyRate"].ToString());

			string serviceFullDetails = "Service Type: ";
			serviceFullDetails += drService["Description"].ToString();
			serviceFullDetails += "\r\n";
			serviceFullDetails += "Hourly Rate: ";
			serviceFullDetails += (drService["HourlyRate"].ToString());
			serviceFullDetails += "\r\n";
			serviceFullDetails += "\r\n";
			serviceFullDetails += "Service Hours: ";
			serviceFullDetails += (dataRow["Hours"].ToString());
			serviceFullDetails += "\t";
			serviceFullDetails += "Service Date: ";
			serviceFullDetails += simpleDate;
			serviceFullDetails += "\r\n";
			serviceFullDetails += "\r\n";

			string strFilter = "ServiceTypeID = " + aServiceID;
			string strSort = "ServiceTypeID";
			DataRow[] checkingEquipment = DM.dsGreen.Tables["SERVICETYPEEQUIPMENT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
			if (checkingEquipment.Length != 0)
			{
				serviceFullDetails += "Equipment Used: ";
				serviceFullDetails += "\r\n\t\t";
				foreach (DataRow ServiceTypeID in checkingEquipment)
				{
					int aEquipmentID = Convert.ToInt32(ServiceTypeID["EquipmentID"].ToString());
					cmEquipment.Position = DM.equipmentView.Find(aEquipmentID);
					DataRow drEquipment = DM.dtEquipment.Rows[cmEquipment.Position];
					serviceFullDetails += drEquipment["Description"].ToString();
					serviceFullDetails += "\r\n\t\t";
				}
				serviceFullDetails += "\r\n";
				serviceFullDetails += "\r\n";
			}
			else
			{
				serviceFullDetails += "(No equipment used.)";
				serviceFullDetails += "\r\n";
				serviceFullDetails += "\r\n";
			}

			serviceFullDetails += "Gross Due: NZ$ ";
			serviceFullDetails += (dubHours * dubRate);


			return serviceFullDetails;
		}
	}
}
