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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewDialog));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlMiddle = new System.Windows.Forms.Panel();
			this.txtList = new System.Windows.Forms.TextBox();
			this.pnlTop.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.pnlMiddle.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			resources.ApplyResources(this.pnlTop, "pnlTop");
			this.pnlTop.Controls.Add(this.label1);
			this.pnlTop.Name = "pnlTop";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// pnlBottom
			// 
			resources.ApplyResources(this.pnlBottom, "pnlBottom");
			this.pnlBottom.Controls.Add(this.btnCancel);
			this.pnlBottom.Controls.Add(this.btnOK);
			this.pnlBottom.Name = "pnlBottom";
			// 
			// btnCancel
			// 
			resources.ApplyResources(this.btnCancel, "btnCancel");
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			resources.ApplyResources(this.btnOK, "btnOK");
			this.btnOK.Name = "btnOK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pnlMiddle
			// 
			resources.ApplyResources(this.pnlMiddle, "pnlMiddle");
			this.pnlMiddle.Controls.Add(this.txtList);
			this.pnlMiddle.Name = "pnlMiddle";
			// 
			// txtList
			// 
			resources.ApplyResources(this.txtList, "txtList");
			this.txtList.Name = "txtList";
			this.txtList.ReadOnly = true;
			this.txtList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtList_KeyUp);
			// 
			// PreviewDialog
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.Controls.Add(this.pnlMiddle);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTop);
			this.Name = "PreviewDialog";
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