
namespace ATMWinForms.Forms
{
	partial class frmChangePIN
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
			this.components = new System.ComponentModel.Container();
			this.btnChange = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCurrent = new System.Windows.Forms.TextBox();
			this.txtNew = new System.Windows.Forms.TextBox();
			this.err = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
			this.SuspendLayout();
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(149, 110);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 31);
			this.btnChange.TabIndex = 0;
			this.btnChange.Text = "Change";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Current PIN:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "New PIN";
			// 
			// txtCurrent
			// 
			this.txtCurrent.Location = new System.Drawing.Point(107, 28);
			this.txtCurrent.Name = "txtCurrent";
			this.txtCurrent.Size = new System.Drawing.Size(117, 22);
			this.txtCurrent.TabIndex = 3;
			// 
			// txtNew
			// 
			this.txtNew.Location = new System.Drawing.Point(107, 70);
			this.txtNew.Name = "txtNew";
			this.txtNew.PasswordChar = 'X';
			this.txtNew.Size = new System.Drawing.Size(117, 22);
			this.txtNew.TabIndex = 4;
			// 
			// err
			// 
			this.err.ContainerControl = this;
			// 
			// frmChangePIN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 153);
			this.Controls.Add(this.txtNew);
			this.Controls.Add(this.txtCurrent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnChange);
			this.Name = "frmChangePIN";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmChangePIN";
			((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCurrent;
		private System.Windows.Forms.TextBox txtNew;
		private System.Windows.Forms.ErrorProvider err;
	}
}