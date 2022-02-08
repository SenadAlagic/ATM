
namespace ATMWinForms.Forms
{
	partial class frmWithdraw
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
			this.btn10 = new System.Windows.Forms.Button();
			this.btn20 = new System.Windows.Forms.Button();
			this.btn50 = new System.Windows.Forms.Button();
			this.btn100 = new System.Windows.Forms.Button();
			this.btn200 = new System.Windows.Forms.Button();
			this.btnCustom = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn10
			// 
			this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn10.Location = new System.Drawing.Point(12, 52);
			this.btn10.Name = "btn10";
			this.btn10.Size = new System.Drawing.Size(119, 37);
			this.btn10.TabIndex = 0;
			this.btn10.Text = "10";
			this.btn10.UseVisualStyleBackColor = true;
			this.btn10.Click += new System.EventHandler(this.btn10_Click);
			// 
			// btn20
			// 
			this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn20.Location = new System.Drawing.Point(12, 95);
			this.btn20.Name = "btn20";
			this.btn20.Size = new System.Drawing.Size(119, 37);
			this.btn20.TabIndex = 1;
			this.btn20.Text = "20";
			this.btn20.UseVisualStyleBackColor = true;
			this.btn20.Click += new System.EventHandler(this.btn20_Click);
			// 
			// btn50
			// 
			this.btn50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn50.Location = new System.Drawing.Point(12, 138);
			this.btn50.Name = "btn50";
			this.btn50.Size = new System.Drawing.Size(119, 37);
			this.btn50.TabIndex = 2;
			this.btn50.Text = "50";
			this.btn50.UseVisualStyleBackColor = true;
			this.btn50.Click += new System.EventHandler(this.btn50_Click);
			// 
			// btn100
			// 
			this.btn100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn100.Location = new System.Drawing.Point(218, 52);
			this.btn100.Name = "btn100";
			this.btn100.Size = new System.Drawing.Size(119, 37);
			this.btn100.TabIndex = 3;
			this.btn100.Text = "100";
			this.btn100.UseVisualStyleBackColor = true;
			this.btn100.Click += new System.EventHandler(this.btn100_Click);
			// 
			// btn200
			// 
			this.btn200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn200.Location = new System.Drawing.Point(218, 95);
			this.btn200.Name = "btn200";
			this.btn200.Size = new System.Drawing.Size(119, 37);
			this.btn200.TabIndex = 4;
			this.btn200.Text = "200";
			this.btn200.UseVisualStyleBackColor = true;
			this.btn200.Click += new System.EventHandler(this.btn200_Click);
			// 
			// btnCustom
			// 
			this.btnCustom.Location = new System.Drawing.Point(218, 138);
			this.btnCustom.Name = "btnCustom";
			this.btnCustom.Size = new System.Drawing.Size(119, 37);
			this.btnCustom.TabIndex = 5;
			this.btnCustom.Text = "Custom amount";
			this.btnCustom.UseVisualStyleBackColor = true;
			this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 26);
			this.label1.TabIndex = 6;
			this.label1.Text = "Please, select an amount";
			// 
			// frmWithdraw
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 198);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCustom);
			this.Controls.Add(this.btn200);
			this.Controls.Add(this.btn100);
			this.Controls.Add(this.btn50);
			this.Controls.Add(this.btn20);
			this.Controls.Add(this.btn10);
			this.Name = "frmWithdraw";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmWithdraw";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn10;
		private System.Windows.Forms.Button btn20;
		private System.Windows.Forms.Button btn50;
		private System.Windows.Forms.Button btn100;
		private System.Windows.Forms.Button btn200;
		private System.Windows.Forms.Button btnCustom;
		private System.Windows.Forms.Label label1;
	}
}