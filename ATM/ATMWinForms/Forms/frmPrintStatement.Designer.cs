
namespace ATMWinForms.Forms
{
	partial class frmPrintStatement
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
			this.dgvTransakcije = new System.Windows.Forms.DataGridView();
			this.lblDate = new System.Windows.Forms.Label();
			this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTransakcije
			// 
			this.dgvTransakcije.AllowUserToAddRows = false;
			this.dgvTransakcije.AllowUserToDeleteRows = false;
			this.dgvTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransakcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Tip,
            this.Kolicina});
			this.dgvTransakcije.Location = new System.Drawing.Point(13, 36);
			this.dgvTransakcije.Name = "dgvTransakcije";
			this.dgvTransakcije.ReadOnly = true;
			this.dgvTransakcije.RowHeadersWidth = 51;
			this.dgvTransakcije.RowTemplate.Height = 24;
			this.dgvTransakcije.Size = new System.Drawing.Size(561, 271);
			this.dgvTransakcije.TabIndex = 0;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(13, 13);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(46, 17);
			this.lblDate.TabIndex = 1;
			this.lblDate.Text = "label1";
			// 
			// Datum
			// 
			this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Datum.DataPropertyName = "Datum";
			this.Datum.HeaderText = "Datum";
			this.Datum.MinimumWidth = 150;
			this.Datum.Name = "Datum";
			this.Datum.ReadOnly = true;
			// 
			// Tip
			// 
			this.Tip.DataPropertyName = "Type";
			this.Tip.HeaderText = "Tip transakcije";
			this.Tip.MinimumWidth = 6;
			this.Tip.Name = "Tip";
			this.Tip.ReadOnly = true;
			this.Tip.Width = 150;
			// 
			// Kolicina
			// 
			this.Kolicina.DataPropertyName = "Kolicina";
			this.Kolicina.HeaderText = "Kolicina";
			this.Kolicina.MinimumWidth = 6;
			this.Kolicina.Name = "Kolicina";
			this.Kolicina.ReadOnly = true;
			this.Kolicina.Width = 125;
			// 
			// frmPrintStatement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 319);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.dgvTransakcije);
			this.Name = "frmPrintStatement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPrintStatement";
			this.Load += new System.EventHandler(this.frmPrintStatement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTransakcije;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
	}
}