
namespace ATMWinForms.Forms
{
	partial class frmMain
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
			this.btnWithdraw = new System.Windows.Forms.Button();
			this.btnBalance = new System.Windows.Forms.Button();
			this.btnPrintStatement = new System.Windows.Forms.Button();
			this.btnPrintBalance = new System.Windows.Forms.Button();
			this.btnChangePIN = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnWithdraw
			// 
			this.btnWithdraw.Location = new System.Drawing.Point(12, 25);
			this.btnWithdraw.Name = "btnWithdraw";
			this.btnWithdraw.Size = new System.Drawing.Size(171, 41);
			this.btnWithdraw.TabIndex = 0;
			this.btnWithdraw.Text = "Withdraw";
			this.btnWithdraw.UseVisualStyleBackColor = true;
			// 
			// btnBalance
			// 
			this.btnBalance.Location = new System.Drawing.Point(12, 82);
			this.btnBalance.Name = "btnBalance";
			this.btnBalance.Size = new System.Drawing.Size(171, 41);
			this.btnBalance.TabIndex = 1;
			this.btnBalance.Text = "Balance";
			this.btnBalance.UseVisualStyleBackColor = true;
			// 
			// btnPrintStatement
			// 
			this.btnPrintStatement.Location = new System.Drawing.Point(12, 139);
			this.btnPrintStatement.Name = "btnPrintStatement";
			this.btnPrintStatement.Size = new System.Drawing.Size(171, 41);
			this.btnPrintStatement.TabIndex = 2;
			this.btnPrintStatement.Text = "Print statement";
			this.btnPrintStatement.UseVisualStyleBackColor = true;
			// 
			// btnPrintBalance
			// 
			this.btnPrintBalance.Location = new System.Drawing.Point(285, 82);
			this.btnPrintBalance.Name = "btnPrintBalance";
			this.btnPrintBalance.Size = new System.Drawing.Size(171, 41);
			this.btnPrintBalance.TabIndex = 3;
			this.btnPrintBalance.Text = "Print balance";
			this.btnPrintBalance.UseVisualStyleBackColor = true;
			// 
			// btnChangePIN
			// 
			this.btnChangePIN.Location = new System.Drawing.Point(285, 25);
			this.btnChangePIN.Name = "btnChangePIN";
			this.btnChangePIN.Size = new System.Drawing.Size(171, 41);
			this.btnChangePIN.TabIndex = 4;
			this.btnChangePIN.Text = "Change PIN number";
			this.btnChangePIN.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(285, 139);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(171, 41);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 196);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnChangePIN);
			this.Controls.Add(this.btnPrintBalance);
			this.Controls.Add(this.btnPrintStatement);
			this.Controls.Add(this.btnBalance);
			this.Controls.Add(this.btnWithdraw);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMain";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnWithdraw;
		private System.Windows.Forms.Button btnBalance;
		private System.Windows.Forms.Button btnPrintStatement;
		private System.Windows.Forms.Button btnPrintBalance;
		private System.Windows.Forms.Button btnChangePIN;
		private System.Windows.Forms.Button btnExit;
	}
}