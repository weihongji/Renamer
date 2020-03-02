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
			this.txtDirectory = new System.Windows.Forms.TextBox();
			this.txtOldName = new System.Windows.Forms.TextBox();
			this.txtNewName = new System.Windows.Forms.TextBox();
			this.lblDirectory = new System.Windows.Forms.Label();
			this.lblOrigList = new System.Windows.Forms.Label();
			this.lblNewList = new System.Windows.Forms.Label();
			this.gbOption = new System.Windows.Forms.GroupBox();
			this.chkFolder = new System.Windows.Forms.CheckBox();
			this.chkFile = new System.Windows.Forms.CheckBox();
			this.btnRename = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnAction = new System.Windows.Forms.Button();
			this.btnActionMenu = new System.Windows.Forms.Button();
			this.menuDirAction = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openThisDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateListPathesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.gbOption.SuspendLayout();
			this.menuDirAction.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtDirectory
			// 
			this.txtDirectory.Location = new System.Drawing.Point(147, 20);
			this.txtDirectory.Name = "txtDirectory";
			this.txtDirectory.Size = new System.Drawing.Size(241, 21);
			this.txtDirectory.TabIndex = 1;
			this.toolTip1.SetToolTip(this.txtDirectory, "Directory where the renaming files or folders are in.");
			// 
			// txtOldName
			// 
			this.txtOldName.Location = new System.Drawing.Point(147, 48);
			this.txtOldName.Name = "txtOldName";
			this.txtOldName.Size = new System.Drawing.Size(241, 21);
			this.txtOldName.TabIndex = 5;
			this.txtOldName.Text = "_OldName.txt";
			this.toolTip1.SetToolTip(this.txtOldName, "Full path of file which has a list of renaming file/folders\' original names");
			// 
			// txtNewName
			// 
			this.txtNewName.Location = new System.Drawing.Point(147, 76);
			this.txtNewName.Name = "txtNewName";
			this.txtNewName.Size = new System.Drawing.Size(241, 21);
			this.txtNewName.TabIndex = 7;
			this.txtNewName.Text = "_NewName.txt";
			this.toolTip1.SetToolTip(this.txtNewName, "Full path of file which has a list of new names for those file/folders.");
			// 
			// lblDirectory
			// 
			this.lblDirectory.AutoSize = true;
			this.lblDirectory.Location = new System.Drawing.Point(47, 24);
			this.lblDirectory.Name = "lblDirectory";
			this.lblDirectory.Size = new System.Drawing.Size(65, 12);
			this.lblDirectory.TabIndex = 0;
			this.lblDirectory.Text = "&Directory:";
			// 
			// lblOrigList
			// 
			this.lblOrigList.AutoSize = true;
			this.lblOrigList.Location = new System.Drawing.Point(47, 52);
			this.lblOrigList.Name = "lblOrigList";
			this.lblOrigList.Size = new System.Drawing.Size(95, 12);
			this.lblOrigList.TabIndex = 4;
			this.lblOrigList.Text = "&Existing names:";
			// 
			// lblNewList
			// 
			this.lblNewList.AutoSize = true;
			this.lblNewList.Location = new System.Drawing.Point(47, 80);
			this.lblNewList.Name = "lblNewList";
			this.lblNewList.Size = new System.Drawing.Size(65, 12);
			this.lblNewList.TabIndex = 6;
			this.lblNewList.Text = "&New names:";
			// 
			// gbOption
			// 
			this.gbOption.Controls.Add(this.chkFolder);
			this.gbOption.Controls.Add(this.chkFile);
			this.gbOption.Location = new System.Drawing.Point(47, 111);
			this.gbOption.Name = "gbOption";
			this.gbOption.Size = new System.Drawing.Size(337, 57);
			this.gbOption.TabIndex = 8;
			this.gbOption.TabStop = false;
			this.gbOption.Text = "Option";
			// 
			// chkFolder
			// 
			this.chkFolder.AutoSize = true;
			this.chkFolder.Checked = true;
			this.chkFolder.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFolder.Location = new System.Drawing.Point(173, 26);
			this.chkFolder.Name = "chkFolder";
			this.chkFolder.Size = new System.Drawing.Size(108, 16);
			this.chkFolder.TabIndex = 10;
			this.chkFolder.Text = "Rename Folders";
			this.chkFolder.UseVisualStyleBackColor = true;
			// 
			// chkFile
			// 
			this.chkFile.AutoSize = true;
			this.chkFile.Checked = true;
			this.chkFile.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFile.Location = new System.Drawing.Point(55, 26);
			this.chkFile.Name = "chkFile";
			this.chkFile.Size = new System.Drawing.Size(96, 16);
			this.chkFile.TabIndex = 9;
			this.chkFile.Text = "Rename Files";
			this.chkFile.UseVisualStyleBackColor = true;
			// 
			// btnRename
			// 
			this.btnRename.Location = new System.Drawing.Point(162, 193);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(85, 23);
			this.btnRename.TabIndex = 11;
			this.btnRename.Text = "&Rename ...";
			this.btnRename.UseVisualStyleBackColor = true;
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(297, 193);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(85, 23);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(400, 19);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(75, 23);
			this.btnAction.TabIndex = 2;
			this.btnAction.Text = "&Browse ...";
			this.toolTip1.SetToolTip(this.btnAction, "Select a directory");
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// btnActionMenu
			// 
			this.btnActionMenu.ContextMenuStrip = this.menuDirAction;
			this.btnActionMenu.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.btnActionMenu.Location = new System.Drawing.Point(474, 19);
			this.btnActionMenu.Name = "btnActionMenu";
			this.btnActionMenu.Size = new System.Drawing.Size(23, 23);
			this.btnActionMenu.TabIndex = 3;
			this.btnActionMenu.Text = "4";
			this.btnActionMenu.UseVisualStyleBackColor = true;
			this.btnActionMenu.Click += new System.EventHandler(this.btnActionMenu_Click);
			// 
			// menuDirAction
			// 
			this.menuDirAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.openThisDirectoryToolStripMenuItem,
            this.createFileListToolStripMenuItem,
            this.updateListPathesToolStripMenuItem});
			this.menuDirAction.Name = "menuDirAction";
			this.menuDirAction.Size = new System.Drawing.Size(189, 92);
			// 
			// browseToolStripMenuItem
			// 
			this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
			this.browseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.browseToolStripMenuItem.Text = "&Browse ...";
			this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
			// 
			// openThisDirectoryToolStripMenuItem
			// 
			this.openThisDirectoryToolStripMenuItem.Name = "openThisDirectoryToolStripMenuItem";
			this.openThisDirectoryToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.openThisDirectoryToolStripMenuItem.Text = "&Open this directory";
			this.openThisDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openThisDirectoryToolStripMenuItem_Click);
			// 
			// createFileListToolStripMenuItem
			// 
			this.createFileListToolStripMenuItem.Name = "createFileListToolStripMenuItem";
			this.createFileListToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.createFileListToolStripMenuItem.Text = "&Create file list";
			this.createFileListToolStripMenuItem.Click += new System.EventHandler(this.createFileListToolStripMenuItem_Click);
			// 
			// updateListPathesToolStripMenuItem
			// 
			this.updateListPathesToolStripMenuItem.Name = "updateListPathesToolStripMenuItem";
			this.updateListPathesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.updateListPathesToolStripMenuItem.Text = "&Apply to list paths";
			this.updateListPathesToolStripMenuItem.Click += new System.EventHandler(this.updateListPathesToolStripMenuItem_Click);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 245);
			this.Controls.Add(this.btnActionMenu);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnRename);
			this.Controls.Add(this.gbOption);
			this.Controls.Add(this.lblNewList);
			this.Controls.Add(this.lblOrigList);
			this.Controls.Add(this.lblDirectory);
			this.Controls.Add(this.txtNewName);
			this.Controls.Add(this.txtOldName);
			this.Controls.Add(this.txtDirectory);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Renamer";
			this.gbOption.ResumeLayout(false);
			this.gbOption.PerformLayout();
			this.menuDirAction.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDirectory;
		private System.Windows.Forms.TextBox txtOldName;
		private System.Windows.Forms.TextBox txtNewName;
		private System.Windows.Forms.Label lblDirectory;
		private System.Windows.Forms.Label lblOrigList;
		private System.Windows.Forms.Label lblNewList;
		private System.Windows.Forms.GroupBox gbOption;
		private System.Windows.Forms.CheckBox chkFolder;
		private System.Windows.Forms.CheckBox chkFile;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.Button btnActionMenu;
		private System.Windows.Forms.ContextMenuStrip menuDirAction;
		private System.Windows.Forms.ToolStripMenuItem openThisDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createFileListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateListPathesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

