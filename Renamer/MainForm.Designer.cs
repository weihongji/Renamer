namespace Renamer
{
	partial class MainForm
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.txtNewName = new System.Windows.Forms.TextBox();
			this.txtOldName = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnSwape = new System.Windows.Forms.Button();
			this.menuDirAction = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCopyFileNames = new System.Windows.Forms.ToolStripMenuItem();
			this.browserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnRename = new System.Windows.Forms.Button();
			this.lblNewList = new System.Windows.Forms.Label();
			this.lblOrigList = new System.Windows.Forms.Label();
			this.btnActionMenu = new System.Windows.Forms.Button();
			this.lblDirectory = new System.Windows.Forms.Label();
			this.pnlTable = new System.Windows.Forms.TableLayoutPanel();
			this.pnlBrowser = new System.Windows.Forms.Panel();
			this.cmbDirectory = new System.Windows.Forms.ComboBox();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.groupEncoding = new System.Windows.Forms.GroupBox();
			this.lblEncoding = new System.Windows.Forms.Label();
			this.rdoEncodingDefault = new System.Windows.Forms.RadioButton();
			this.rdoEncodingUTF8 = new System.Windows.Forms.RadioButton();
			this.menuDirAction.SuspendLayout();
			this.pnlTable.SuspendLayout();
			this.pnlBrowser.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.groupEncoding.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNewName
			// 
			this.txtNewName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtNewName.Location = new System.Drawing.Point(113, 81);
			this.txtNewName.Name = "txtNewName";
			this.txtNewName.Size = new System.Drawing.Size(408, 21);
			this.txtNewName.TabIndex = 5;
			this.txtNewName.Text = "2.txt";
			this.toolTip1.SetToolTip(this.txtNewName, "Full path of file which has a list of new names for those file/folders.");
			// 
			// txtOldName
			// 
			this.txtOldName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOldName.Location = new System.Drawing.Point(113, 49);
			this.txtOldName.Name = "txtOldName";
			this.txtOldName.Size = new System.Drawing.Size(408, 21);
			this.txtOldName.TabIndex = 3;
			this.txtOldName.Text = "1.txt";
			this.toolTip1.SetToolTip(this.txtOldName, "Full path of file which has a list of renaming file/folders\' original names");
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(3, 0);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "&Browse ...";
			this.toolTip1.SetToolTip(this.btnBrowse, "Select a directory");
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnSwape
			// 
			this.btnSwape.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnSwape.Location = new System.Drawing.Point(527, 67);
			this.btnSwape.Name = "btnSwape";
			this.pnlTable.SetRowSpan(this.btnSwape, 2);
			this.btnSwape.Size = new System.Drawing.Size(75, 23);
			this.btnSwape.TabIndex = 6;
			this.btnSwape.Text = "&Swape";
			this.toolTip1.SetToolTip(this.btnSwape, "Exchange the file in Existing/New Names.");
			this.btnSwape.UseVisualStyleBackColor = true;
			this.btnSwape.Click += new System.EventHandler(this.btnSwape_Click);
			// 
			// menuDirAction
			// 
			this.menuDirAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenFolder,
            this.menuCopyFileNames});
			this.menuDirAction.Name = "menuDirAction";
			this.menuDirAction.Size = new System.Drawing.Size(175, 48);
			// 
			// menuOpenFolder
			// 
			this.menuOpenFolder.Name = "menuOpenFolder";
			this.menuOpenFolder.Size = new System.Drawing.Size(174, 22);
			this.menuOpenFolder.Text = "&Open Folder";
			this.menuOpenFolder.Click += new System.EventHandler(this.menuOpenFolder_Click);
			// 
			// menuCopyFileNames
			// 
			this.menuCopyFileNames.Name = "menuCopyFileNames";
			this.menuCopyFileNames.Size = new System.Drawing.Size(174, 22);
			this.menuCopyFileNames.Text = "&Copy File Names";
			this.menuCopyFileNames.Click += new System.EventHandler(this.menuCopyFileNames_Click);
			// 
			// browserDialog
			// 
			this.browserDialog.ShowNewFolderButton = false;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(340, 93);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(131, 34);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnRename
			// 
			this.btnRename.Location = new System.Drawing.Point(144, 93);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(131, 34);
			this.btnRename.TabIndex = 0;
			this.btnRename.Text = "&Rename";
			this.btnRename.UseVisualStyleBackColor = true;
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// lblNewList
			// 
			this.lblNewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNewList.AutoSize = true;
			this.lblNewList.Location = new System.Drawing.Point(42, 78);
			this.lblNewList.Name = "lblNewList";
			this.lblNewList.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblNewList.Size = new System.Drawing.Size(65, 17);
			this.lblNewList.TabIndex = 4;
			this.lblNewList.Text = "&New Names:";
			// 
			// lblOrigList
			// 
			this.lblOrigList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOrigList.AutoSize = true;
			this.lblOrigList.Location = new System.Drawing.Point(12, 46);
			this.lblOrigList.Name = "lblOrigList";
			this.lblOrigList.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblOrigList.Size = new System.Drawing.Size(95, 17);
			this.lblOrigList.TabIndex = 3;
			this.lblOrigList.Text = "&Existing Names:";
			// 
			// btnActionMenu
			// 
			this.btnActionMenu.ContextMenuStrip = this.menuDirAction;
			this.btnActionMenu.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.btnActionMenu.Location = new System.Drawing.Point(80, 0);
			this.btnActionMenu.Name = "btnActionMenu";
			this.btnActionMenu.Size = new System.Drawing.Size(23, 23);
			this.btnActionMenu.TabIndex = 1;
			this.btnActionMenu.Text = "4";
			this.btnActionMenu.UseVisualStyleBackColor = true;
			this.btnActionMenu.Click += new System.EventHandler(this.btnActionMenu_Click);
			// 
			// lblDirectory
			// 
			this.lblDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDirectory.AutoSize = true;
			this.lblDirectory.Location = new System.Drawing.Point(42, 9);
			this.lblDirectory.Name = "lblDirectory";
			this.lblDirectory.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.lblDirectory.Size = new System.Drawing.Size(65, 21);
			this.lblDirectory.TabIndex = 1;
			this.lblDirectory.Text = "&Directory:";
			// 
			// pnlTable
			// 
			this.pnlTable.ColumnCount = 3;
			this.pnlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.pnlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.pnlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.pnlTable.Controls.Add(this.pnlBrowser, 2, 1);
			this.pnlTable.Controls.Add(this.lblDirectory, 0, 1);
			this.pnlTable.Controls.Add(this.txtNewName, 1, 3);
			this.pnlTable.Controls.Add(this.lblNewList, 0, 3);
			this.pnlTable.Controls.Add(this.lblOrigList, 0, 2);
			this.pnlTable.Controls.Add(this.txtOldName, 1, 2);
			this.pnlTable.Controls.Add(this.cmbDirectory, 1, 1);
			this.pnlTable.Controls.Add(this.btnSwape, 2, 2);
			this.pnlTable.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTable.Location = new System.Drawing.Point(0, 0);
			this.pnlTable.Name = "pnlTable";
			this.pnlTable.RowCount = 4;
			this.pnlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
			this.pnlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.pnlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.pnlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.pnlTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlTable.Size = new System.Drawing.Size(684, 112);
			this.pnlTable.TabIndex = 0;
			// 
			// pnlBrowser
			// 
			this.pnlBrowser.Controls.Add(this.btnBrowse);
			this.pnlBrowser.Controls.Add(this.btnActionMenu);
			this.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBrowser.Location = new System.Drawing.Point(527, 12);
			this.pnlBrowser.Name = "pnlBrowser";
			this.pnlBrowser.Size = new System.Drawing.Size(154, 31);
			this.pnlBrowser.TabIndex = 2;
			// 
			// cmbDirectory
			// 
			this.cmbDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbDirectory.FormattingEnabled = true;
			this.cmbDirectory.Location = new System.Drawing.Point(113, 16);
			this.cmbDirectory.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
			this.cmbDirectory.Name = "cmbDirectory";
			this.cmbDirectory.Size = new System.Drawing.Size(408, 20);
			this.cmbDirectory.TabIndex = 1;
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.groupEncoding);
			this.pnlBottom.Controls.Add(this.btnExit);
			this.pnlBottom.Controls.Add(this.btnRename);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBottom.Location = new System.Drawing.Point(0, 112);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(684, 139);
			this.pnlBottom.TabIndex = 1;
			// 
			// groupEncoding
			// 
			this.groupEncoding.Controls.Add(this.rdoEncodingUTF8);
			this.groupEncoding.Controls.Add(this.rdoEncodingDefault);
			this.groupEncoding.Controls.Add(this.lblEncoding);
			this.groupEncoding.Location = new System.Drawing.Point(113, 6);
			this.groupEncoding.Name = "groupEncoding";
			this.groupEncoding.Size = new System.Drawing.Size(408, 66);
			this.groupEncoding.TabIndex = 2;
			this.groupEncoding.TabStop = false;
			this.groupEncoding.Text = "Encoding";
			// 
			// lblEncoding
			// 
			this.lblEncoding.AutoSize = true;
			this.lblEncoding.Location = new System.Drawing.Point(16, 40);
			this.lblEncoding.Name = "lblEncoding";
			this.lblEncoding.Size = new System.Drawing.Size(263, 12);
			this.lblEncoding.TabIndex = 0;
			this.lblEncoding.Text = "The two list files mush have same encoding.";
			// 
			// rdoEncodingDefault
			// 
			this.rdoEncodingDefault.AutoSize = true;
			this.rdoEncodingDefault.Checked = true;
			this.rdoEncodingDefault.Location = new System.Drawing.Point(70, 18);
			this.rdoEncodingDefault.Name = "rdoEncodingDefault";
			this.rdoEncodingDefault.Size = new System.Drawing.Size(65, 16);
			this.rdoEncodingDefault.TabIndex = 1;
			this.rdoEncodingDefault.TabStop = true;
			this.rdoEncodingDefault.Text = "Default";
			this.rdoEncodingDefault.UseVisualStyleBackColor = true;
			// 
			// rdoEncodingUTF8
			// 
			this.rdoEncodingUTF8.AutoSize = true;
			this.rdoEncodingUTF8.Location = new System.Drawing.Point(197, 17);
			this.rdoEncodingUTF8.Name = "rdoEncodingUTF8";
			this.rdoEncodingUTF8.Size = new System.Drawing.Size(53, 16);
			this.rdoEncodingUTF8.TabIndex = 2;
			this.rdoEncodingUTF8.TabStop = true;
			this.rdoEncodingUTF8.Text = "UTF-8";
			this.rdoEncodingUTF8.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(684, 251);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTable);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1600, 300);
			this.MinimumSize = new System.Drawing.Size(650, 290);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Renamer";
			this.menuDirAction.ResumeLayout(false);
			this.pnlTable.ResumeLayout(false);
			this.pnlTable.PerformLayout();
			this.pnlBrowser.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.groupEncoding.ResumeLayout(false);
			this.groupEncoding.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ContextMenuStrip menuDirAction;
		private System.Windows.Forms.ToolStripMenuItem menuOpenFolder;
		private System.Windows.Forms.ToolStripMenuItem menuCopyFileNames;
		private System.Windows.Forms.FolderBrowserDialog browserDialog;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.TextBox txtNewName;
		private System.Windows.Forms.Label lblNewList;
		private System.Windows.Forms.TextBox txtOldName;
		private System.Windows.Forms.Label lblOrigList;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnActionMenu;
		private System.Windows.Forms.Label lblDirectory;
		private System.Windows.Forms.TableLayoutPanel pnlTable;
		private System.Windows.Forms.Panel pnlBrowser;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.ComboBox cmbDirectory;
		private System.Windows.Forms.Button btnSwape;
		private System.Windows.Forms.GroupBox groupEncoding;
		private System.Windows.Forms.RadioButton rdoEncodingUTF8;
		private System.Windows.Forms.RadioButton rdoEncodingDefault;
		private System.Windows.Forms.Label lblEncoding;
	}
}

