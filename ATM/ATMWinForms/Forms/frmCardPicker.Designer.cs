﻿
namespace ATMWinForms.Forms
{
	partial class frmCardPicker
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtPIN = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCard = new System.Windows.Forms.ComboBox();
			this.btnChoose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "PIN";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtPIN
			// 
			this.txtPIN.Location = new System.Drawing.Point(138, 92);
			this.txtPIN.Name = "txtPIN";
			this.txtPIN.Size = new System.Drawing.Size(121, 22);
			this.txtPIN.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Card:";
			// 
			// cbCard
			// 
			this.cbCard.FormattingEnabled = true;
			this.cbCard.Location = new System.Drawing.Point(138, 62);
			this.cbCard.Name = "cbCard";
			this.cbCard.Size = new System.Drawing.Size(121, 24);
			this.cbCard.TabIndex = 3;
			// 
			// btnChoose
			// 
			this.btnChoose.Location = new System.Drawing.Point(79, 120);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(180, 36);
			this.btnChoose.TabIndex = 4;
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseVisualStyleBackColor = true;
			// 
			// frmCardPicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 206);
			this.Controls.Add(this.btnChoose);
			this.Controls.Add(this.cbCard);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPIN);
			this.Controls.Add(this.label1);
			this.Name = "frmCardPicker";
			this.Text = "frmCardPicker";
			this.Load += new System.EventHandler(this.frmCardPicker_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPIN;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCard;
		private System.Windows.Forms.Button btnChoose;
	}
}