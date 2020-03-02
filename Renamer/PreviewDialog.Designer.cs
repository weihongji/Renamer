namespace Renamer
{
	partial class PreviewDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pnlMiddle = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtList = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlTop.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.pnlMiddle.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.label1);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(484, 34);
			this.pnlTop.TabIndex = 0;
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.btnCancel);
			this.pnlBottom.Controls.Add(this.btnOK);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 408);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(484, 53);
			this.pnlBottom.TabIndex = 1;
			// 
			// pnlMiddle
			// 
			this.pnlMiddle.Controls.Add(this.txtList);
			this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMiddle.Location = new System.Drawing.Point(0, 34);
			this.pnlMiddle.Name = "pnlMiddle";
			this.pnlMiddle.Size = new System.Drawing.Size(484, 374);
			this.pnlMiddle.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(371, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Following files will be renamed. Click OK button to continue.";
			// 
			// txtList
			// 
			this.txtList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtList.Location = new System.Drawing.Point(0, 0);
			this.txtList.Multiline = true;
			this.txtList.Name = "txtList";
			this.txtList.ReadOnly = true;
			this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtList.Size = new System.Drawing.Size(484, 374);
			this.txtList.TabIndex = 0;
			this.txtList.Text = "A red dog jumps over a brown fox.\r\nA RED DOG JUMPS OVER A BROWN FOX.\r\nAAAAAAAAAAA" +
    "AAAAAAAAAAAAAAAAAAAAAA\r\nlllllllllllllllllllllllllllllllll";
			this.txtList.WordWrap = false;
			this.txtList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtList_KeyUp);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(90, 7);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(120, 34);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(274, 7);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 34);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// PreviewDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.pnlMiddle);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTop);
			this.Name = "PreviewDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preview";
			this.Shown += new System.EventHandler(this.PreviewDialog_Shown);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.pnlBottom.ResumeLayout(false);
			this.pnlMiddle.ResumeLayout(false);
			this.pnlMiddle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel pnlMiddle;
		private System.Windows.Forms.TextBox txtList;
	}
}