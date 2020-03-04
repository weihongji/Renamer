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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.chkOnTop = new System.Windows.Forms.CheckBox();
			this.groupEncoding = new System.Windows.Forms.GroupBox();
			this.rdoEncodingUTF8 = new System.Windows.Forms.RadioButton();
			this.rdoEncodingDefault = new System.Windows.Forms.RadioButton();
			this.lblEncoding = new System.Windows.Forms.Label();
			this.menuDirAction.SuspendLayout();
			this.pnlTable.SuspendLayout();
			this.pnlBrowser.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.groupEncoding.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNewName
			// 
			resources.ApplyResources(this.txtNewName, "txtNewName");
			this.txtNewName.AllowDrop = true;
			this.txtNewName.Name = "txtNewName";
			this.toolTip1.SetToolTip(this.txtNewName, resources.GetString("txtNewName.ToolTip"));
			this.txtNewName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtNewName_DragDrop);
			this.txtNewName.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtNewName_DragEnter);
			// 
			// txtOldName
			// 
			resources.ApplyResources(this.txtOldName, "txtOldName");
			this.txtOldName.AllowDrop = true;
			this.txtOldName.Name = "txtOldName";
			this.toolTip1.SetToolTip(this.txtOldName, resources.GetString("txtOldName.ToolTip"));
			this.txtOldName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtOldName_DragDrop);
			this.txtOldName.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtOldName_DragEnter);
			// 
			// btnBrowse
			// 
			resources.ApplyResources(this.btnBrowse, "btnBrowse");
			this.btnBrowse.Name = "btnBrowse";
			this.toolTip1.SetToolTip(this.btnBrowse, resources.GetString("btnBrowse.ToolTip"));
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnSwape
			// 
			resources.ApplyResources(this.btnSwape, "btnSwape");
			this.btnSwape.Name = "btnSwape";
			this.pnlTable.SetRowSpan(this.btnSwape, 2);
			this.toolTip1.SetToolTip(this.btnSwape, resources.GetString("btnSwape.ToolTip"));
			this.btnSwape.UseVisualStyleBackColor = true;
			this.btnSwape.Click += new System.EventHandler(this.btnSwape_Click);
			// 
			// menuDirAction
			// 
			resources.ApplyResources(this.menuDirAction, "menuDirAction");
			this.menuDirAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenFolder,
            this.menuCopyFileNames});
			this.menuDirAction.Name = "menuDirAction";
			this.toolTip1.SetToolTip(this.menuDirAction, resources.GetString("menuDirAction.ToolTip"));
			// 
			// menuOpenFolder
			// 
			resources.ApplyResources(this.menuOpenFolder, "menuOpenFolder");
			this.menuOpenFolder.Name = "menuOpenFolder";
			this.menuOpenFolder.Click += new System.EventHandler(this.menuOpenFolder_Click);
			// 
			// menuCopyFileNames
			// 
			resources.ApplyResources(this.menuCopyFileNames, "menuCopyFileNames");
			this.menuCopyFileNames.Name = "menuCopyFileNames";
			this.menuCopyFileNames.Click += new System.EventHandler(this.menuCopyFileNames_Click);
			// 
			// browserDialog
			// 
			resources.ApplyResources(this.browserDialog, "browserDialog");
			this.browserDialog.ShowNewFolderButton = false;
			// 
			// btnExit
			// 
			resources.ApplyResources(this.btnExit, "btnExit");
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Name = "btnExit";
			this.toolTip1.SetToolTip(this.btnExit, resources.GetString("btnExit.ToolTip"));
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnRename
			// 
			resources.ApplyResources(this.btnRename, "btnRename");
			this.btnRename.Name = "btnRename";
			this.toolTip1.SetToolTip(this.btnRename, resources.GetString("btnRename.ToolTip"));
			this.btnRename.UseVisualStyleBackColor = true;
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// lblNewList
			// 
			resources.ApplyResources(this.lblNewList, "lblNewList");
			this.lblNewList.Name = "lblNewList";
			this.toolTip1.SetToolTip(this.lblNewList, resources.GetString("lblNewList.ToolTip"));
			// 
			// lblOrigList
			// 
			resources.ApplyResources(this.lblOrigList, "lblOrigList");
			this.lblOrigList.Name = "lblOrigList";
			this.toolTip1.SetToolTip(this.lblOrigList, resources.GetString("lblOrigList.ToolTip"));
			// 
			// btnActionMenu
			// 
			resources.ApplyResources(this.btnActionMenu, "btnActionMenu");
			this.btnActionMenu.ContextMenuStrip = this.menuDirAction;
			this.btnActionMenu.Name = "btnActionMenu";
			this.toolTip1.SetToolTip(this.btnActionMenu, resources.GetString("btnActionMenu.ToolTip"));
			this.btnActionMenu.UseVisualStyleBackColor = true;
			this.btnActionMenu.Click += new System.EventHandler(this.btnActionMenu_Click);
			// 
			// lblDirectory
			// 
			resources.ApplyResources(this.lblDirectory, "lblDirectory");
			this.lblDirectory.Name = "lblDirectory";
			this.toolTip1.SetToolTip(this.lblDirectory, resources.GetString("lblDirectory.ToolTip"));
			// 
			// pnlTable
			// 
			resources.ApplyResources(this.pnlTable, "pnlTable");
			this.pnlTable.Controls.Add(this.pnlBrowser, 2, 1);
			this.pnlTable.Controls.Add(this.lblDirectory, 0, 1);
			this.pnlTable.Controls.Add(this.txtNewName, 1, 3);
			this.pnlTable.Controls.Add(this.lblNewList, 0, 3);
			this.pnlTable.Controls.Add(this.lblOrigList, 0, 2);
			this.pnlTable.Controls.Add(this.txtOldName, 1, 2);
			this.pnlTable.Controls.Add(this.cmbDirectory, 1, 1);
			this.pnlTable.Controls.Add(this.btnSwape, 2, 2);
			this.pnlTable.Name = "pnlTable";
			this.toolTip1.SetToolTip(this.pnlTable, resources.GetString("pnlTable.ToolTip"));
			// 
			// pnlBrowser
			// 
			resources.ApplyResources(this.pnlBrowser, "pnlBrowser");
			this.pnlBrowser.Controls.Add(this.btnBrowse);
			this.pnlBrowser.Controls.Add(this.btnActionMenu);
			this.pnlBrowser.Name = "pnlBrowser";
			this.toolTip1.SetToolTip(this.pnlBrowser, resources.GetString("pnlBrowser.ToolTip"));
			// 
			// cmbDirectory
			// 
			resources.ApplyResources(this.cmbDirectory, "cmbDirectory");
			this.cmbDirectory.FormattingEnabled = true;
			this.cmbDirectory.Name = "cmbDirectory";
			this.toolTip1.SetToolTip(this.cmbDirectory, resources.GetString("cmbDirectory.ToolTip"));
			// 
			// pnlBottom
			// 
			resources.ApplyResources(this.pnlBottom, "pnlBottom");
			this.pnlBottom.Controls.Add(this.chkOnTop);
			this.pnlBottom.Controls.Add(this.groupEncoding);
			this.pnlBottom.Controls.Add(this.btnExit);
			this.pnlBottom.Controls.Add(this.btnRename);
			this.pnlBottom.Name = "pnlBottom";
			this.toolTip1.SetToolTip(this.pnlBottom, resources.GetString("pnlBottom.ToolTip"));
			// 
			// chkOnTop
			// 
			resources.ApplyResources(this.chkOnTop, "chkOnTop");
			this.chkOnTop.Name = "chkOnTop";
			this.toolTip1.SetToolTip(this.chkOnTop, resources.GetString("chkOnTop.ToolTip"));
			this.chkOnTop.UseVisualStyleBackColor = true;
			this.chkOnTop.Click += new System.EventHandler(this.chkOnTop_Click);
			// 
			// groupEncoding
			// 
			resources.ApplyResources(this.groupEncoding, "groupEncoding");
			this.groupEncoding.Controls.Add(this.rdoEncodingUTF8);
			this.groupEncoding.Controls.Add(this.rdoEncodingDefault);
			this.groupEncoding.Controls.Add(this.lblEncoding);
			this.groupEncoding.Name = "groupEncoding";
			this.groupEncoding.TabStop = false;
			this.toolTip1.SetToolTip(this.groupEncoding, resources.GetString("groupEncoding.ToolTip"));
			// 
			// rdoEncodingUTF8
			// 
			resources.ApplyResources(this.rdoEncodingUTF8, "rdoEncodingUTF8");
			this.rdoEncodingUTF8.Name = "rdoEncodingUTF8";
			this.rdoEncodingUTF8.TabStop = true;
			this.toolTip1.SetToolTip(this.rdoEncodingUTF8, resources.GetString("rdoEncodingUTF8.ToolTip"));
			this.rdoEncodingUTF8.UseVisualStyleBackColor = true;
			// 
			// rdoEncodingDefault
			// 
			resources.ApplyResources(this.rdoEncodingDefault, "rdoEncodingDefault");
			this.rdoEncodingDefault.Checked = true;
			this.rdoEncodingDefault.Name = "rdoEncodingDefault";
			this.rdoEncodingDefault.TabStop = true;
			this.toolTip1.SetToolTip(this.rdoEncodingDefault, resources.GetString("rdoEncodingDefault.ToolTip"));
			this.rdoEncodingDefault.UseVisualStyleBackColor = true;
			// 
			// lblEncoding
			// 
			resources.ApplyResources(this.lblEncoding, "lblEncoding");
			this.lblEncoding.Name = "lblEncoding";
			this.toolTip1.SetToolTip(this.lblEncoding, resources.GetString("lblEncoding.ToolTip"));
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTable);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.menuDirAction.ResumeLayout(false);
			this.pnlTable.ResumeLayout(false);
			this.pnlTable.PerformLayout();
			this.pnlBrowser.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
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
		private System.Windows.Forms.CheckBox chkOnTop;
	}
}

