using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Printing;

namespace Greens_Garage
{
	public partial class InvoiceForm : Form
	{
		private DataModule DM;
		private MainForm frmMenu;
		private CurrencyManager currencyManager;
		private PrintPreviewDialog printPreview;

		private Font printFont;
		private StreamReader streamToPrint;


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
			//try
			//{
			//	streamtoprint = new streamreader
			//		("c:\\temp\\greens garage\\printdoc.txt");
			//	try
			//	{
			//		printfont = new font("arial", 10);
			//		printdocument pd = new printdocument();
			//		pd.printpage += new printpageeventhandler
			//			(this.pd_printpage);
			//		pd.print();
			//	}
			//	finally
			//	{
			//		streamtoprint.close();
			//	}

			//}
			//catch (exception ex)
			//{
			//	messagebox.show(ex.message);
			//}

			streamToPrint = new StreamReader
				("c:\\temp\\greens garage\\printdoc.txt");
			printFont = new Font("arial", 10);
			PrintDocument pd = new PrintDocument();
			printPreview.Document = pd;
			printPreview.ShowDialog();

		}
	}
}
