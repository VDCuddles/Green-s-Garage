namespace Greens_Garage
{
	partial class EquipmentAllocationForm
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
			this.dgvServiceType = new System.Windows.Forms.DataGridView();
			this.dgvServiceTypeEquipment = new System.Windows.Forms.DataGridView();
			this.dgvEquipment = new System.Windows.Forms.DataGridView();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnRemoveEquipment = new System.Windows.Forms.Button();
			this.btnAllocateEquipment = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvServiceType
			// 
			this.dgvServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServiceType.Location = new System.Drawing.Point(186, 25);
			this.dgvServiceType.Name = "dgvServiceType";
			this.dgvServiceType.Size = new System.Drawing.Size(364, 183);
			this.dgvServiceType.TabIndex = 0;
			// 
			// dgvServiceTypeEquipment
			// 
			this.dgvServiceTypeEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServiceTypeEquipment.Location = new System.Drawing.Point(52, 228);
			this.dgvServiceTypeEquipment.Name = "dgvServiceTypeEquipment";
			this.dgvServiceTypeEquipment.Size = new System.Drawing.Size(264, 186);
			this.dgvServiceTypeEquipment.TabIndex = 1;
			// 
			// dgvEquipment
			// 
			this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEquipment.Location = new System.Drawing.Point(502, 228);
			this.dgvEquipment.Name = "dgvEquipment";
			this.dgvEquipment.Size = new System.Drawing.Size(264, 186);
			this.dgvEquipment.TabIndex = 2;
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(692, 431);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(120, 40);
			this.btnReturn.TabIndex = 3;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// btnRemoveEquipment
			// 
			this.btnRemoveEquipment.Location = new System.Drawing.Point(350, 374);
			this.btnRemoveEquipment.Name = "btnRemoveEquipment";
			this.btnRemoveEquipment.Size = new System.Drawing.Size(120, 40);
			this.btnRemoveEquipment.TabIndex = 4;
			this.btnRemoveEquipment.Text = "Remove Equipment";
			this.btnRemoveEquipment.UseVisualStyleBackColor = true;
			this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
			// 
			// btnAllocateEquipment
			// 
			this.btnAllocateEquipment.Location = new System.Drawing.Point(350, 228);
			this.btnAllocateEquipment.Name = "btnAllocateEquipment";
			this.btnAllocateEquipment.Size = new System.Drawing.Size(120, 40);
			this.btnAllocateEquipment.TabIndex = 5;
			this.btnAllocateEquipment.Text = "Allocate Equipment";
			this.btnAllocateEquipment.UseVisualStyleBackColor = true;
			this.btnAllocateEquipment.Click += new System.EventHandler(this.btnAllocateEquipment_Click);
			// 
			// EquipmentAllocationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 493);
			this.Controls.Add(this.btnAllocateEquipment);
			this.Controls.Add(this.btnRemoveEquipment);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.dgvEquipment);
			this.Controls.Add(this.dgvServiceTypeEquipment);
			this.Controls.Add(this.dgvServiceType);
			this.Name = "EquipmentAllocationForm";
			this.Text = "Equipment Allocation";
			((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvServiceType;
		private System.Windows.Forms.DataGridView dgvServiceTypeEquipment;
		private System.Windows.Forms.DataGridView dgvEquipment;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button btnRemoveEquipment;
		private System.Windows.Forms.Button btnAllocateEquipment;
	}
}