
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
			this.lblUser = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnWithdraw
			// 
			this.btnWithdraw.Location = new System.Drawing.Point(12, 66);
			this.btnWithdraw.Name = "btnWithdraw";
			this.btnWithdraw.Size = new System.Drawing.Size(171, 41);
			this.btnWithdraw.TabIndex = 0;
			this.btnWithdraw.Text = "Withdraw";
			this.btnWithdraw.UseVisualStyleBackColor = true;
			this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
			// 
			// btnBalance
			// 
			this.btnBalance.Location = new System.Drawing.Point(12, 123);
			this.btnBalance.Name = "btnBalance";
			this.btnBalance.Size = new System.Drawing.Size(171, 41);
			this.btnBalance.TabIndex = 1;
			this.btnBalance.Text = "Balance";
			this.btnBalance.UseVisualStyleBackColor = true;
			this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
			// 
			// btnPrintStatement
			// 
			this.btnPrintStatement.Location = new System.Drawing.Point(12, 180);
			this.btnPrintStatement.Name = "btnPrintStatement";
			this.btnPrintStatement.Size = new System.Drawing.Size(171, 41);
			this.btnPrintStatement.TabIndex = 2;
			this.btnPrintStatement.Text = "Print statement";
			this.btnPrintStatement.UseVisualStyleBackColor = true;
			this.btnPrintStatement.Click += new System.EventHandler(this.btnPrintStatement_Click);
			// 
			// btnPrintBalance
			// 
			this.btnPrintBalance.Location = new System.Drawing.Point(285, 123);
			this.btnPrintBalance.Name = "btnPrintBalance";
			this.btnPrintBalance.Size = new System.Drawing.Size(171, 41);
			this.btnPrintBalance.TabIndex = 3;
			this.btnPrintBalance.Text = "Print balance";
			this.btnPrintBalance.UseVisualStyleBackColor = true;
			this.btnPrintBalance.Click += new System.EventHandler(this.btnPrintBalance_Click);
			// 
			// btnChangePIN
			// 
			this.btnChangePIN.Location = new System.Drawing.Point(285, 66);
			this.btnChangePIN.Name = "btnChangePIN";
			this.btnChangePIN.Size = new System.Drawing.Size(171, 41);
			this.btnChangePIN.TabIndex = 4;
			this.btnChangePIN.Text = "Change PIN number";
			this.btnChangePIN.UseVisualStyleBackColor = true;
			this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(285, 180);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(171, 41);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(12, 19);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(116, 26);
			this.lblUser.TabIndex = 6;
			this.lblUser.Text = "Welcome, ";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 235);
			this.Controls.Add(this.lblUser);
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
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnWithdraw;
		private System.Windows.Forms.Button btnBalance;
		private System.Windows.Forms.Button btnPrintStatement;
		private System.Windows.Forms.Button btnPrintBalance;
		private System.Windows.Forms.Button btnChangePIN;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblUser;
	}
}