namespace Greens_Garage
{
	partial class InvoiceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
			this.btnPrintInvoices = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.pnlPrintText = new System.Windows.Forms.Panel();
			this.txtPrintText = new System.Windows.Forms.TextBox();
			this.prvInvoices = new System.Windows.Forms.PrintPreviewDialog();
			this.printInvoices = new System.Drawing.Printing.PrintDocument();
			this.pnlPrintText.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPrintInvoices
			// 
			this.btnPrintInvoices.Location = new System.Drawing.Point(67, 49);
			this.btnPrintInvoices.Name = "btnPrintInvoices";
			this.btnPrintInvoices.Size = new System.Drawing.Size(200, 40);
			this.btnPrintInvoices.TabIndex = 0;
			this.btnPrintInvoices.Text = "Print Invoices";
			this.btnPrintInvoices.UseVisualStyleBackColor = true;
			this.btnPrintInvoices.Click += new System.EventHandler(this.btnPrintInvoices_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(585, 49);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(200, 40);
			this.btnReturn.TabIndex = 1;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// pnlPrintText
			// 
			this.pnlPrintText.Controls.Add(this.txtPrintText);
			this.pnlPrintText.Location = new System.Drawing.Point(313, 26);
			this.pnlPrintText.Name = "pnlPrintText";
			this.pnlPrintText.Size = new System.Drawing.Size(200, 100);
			this.pnlPrintText.TabIndex = 2;
			this.pnlPrintText.Visible = false;
			// 
			// txtPrintText
			// 
			this.txtPrintText.Location = new System.Drawing.Point(81, 42);
			this.txtPrintText.Name = "txtPrintText";
			this.txtPrintText.Size = new System.Drawing.Size(100, 20);
			this.txtPrintText.TabIndex = 0;
			// 
			// prvInvoices
			// 
			this.prvInvoices.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.prvInvoices.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.prvInvoices.ClientSize = new System.Drawing.Size(400, 300);
			this.prvInvoices.Document = this.printInvoices;
			this.prvInvoices.Enabled = true;
			this.prvInvoices.Icon = ((System.Drawing.Icon)(resources.GetObject("prvInvoices.Icon")));
			this.prvInvoices.Name = "prvInvoices";
			this.prvInvoices.Visible = false;
			// 
			// printInvoices
			// 
			this.printInvoices.DocumentName = "Invoice Document";
			this.printInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoices_PrintPage);
			// 
			// InvoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 138);
			this.Controls.Add(this.pnlPrintText);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnPrintInvoices);
			this.Name = "InvoiceForm";
			this.Text = "Invoice Form";
			this.pnlPrintText.ResumeLayout(false);
			this.pnlPrintText.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPrintInvoices;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Panel pnlPrintText;
		private System.Windows.Forms.TextBox txtPrintText;
		private System.Windows.Forms.PrintPreviewDialog prvInvoices;
		private System.Drawing.Printing.PrintDocument printInvoices;
	}
}