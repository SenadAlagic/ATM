
namespace ATMWinForms.Forms
{
	partial class frmAmount
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
			this.btnEnter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.err = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(271, 21);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(75, 22);
			this.btnEnter.TabIndex = 0;
			this.btnEnter.Text = "Enter";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Amount";
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(85, 21);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(180, 22);
			this.txtAmount.TabIndex = 2;
			// 
			// err
			// 
			this.err.ContainerControl = this;
			// 
			// frmAmount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 66);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEnter);
			this.Name = "frmAmount";
			this.Text = "frmAmount";
			((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.ErrorProvider err;
	}
}