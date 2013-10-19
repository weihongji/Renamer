using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Renamer
{
	public partial class MainForm : Form
	{
		private String _Title = "Renamer";

		public MainForm()
		{
			InitializeComponent();
		}

		#region Subroutines

		private void SelectDirectory()
		{
			this.folderBrowserDialog1.SelectedPath = this.txtDirectory.Text;
			if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				this.txtDirectory.Text = this.folderBrowserDialog1.SelectedPath;
			}
		}

		private void OpenDirectory()
		{
			if (checkDir()) {
				System.Diagnostics.Process.Start("explorer.exe", this.txtDirectory.Text);
			}
		}

		private void CreateFileList()
		{
			if (checkDir()) {
				// To Do;
			}
		}

		private void UpdateListPath()
		{
			if (checkDir()) {
				this.txtOldName.Text = Path.Combine(this.txtDirectory.Text, Path.GetFileName(this.txtOldName.Text));
				this.txtNewName.Text = Path.Combine(this.txtDirectory.Text, Path.GetFileName(this.txtNewName.Text));
			}
		}

		private bool checkDir()
		{
			String dir = this.txtDirectory.Text;
			String msg = "";

			if (dir.Length > 0 && dir.Substring(dir.Length -1) == ":") {
				this.txtDirectory.Text = dir + "\\";
			}

			if (dir == "") {
				msg = "The directory can't be empty.\nPlease enter one.";
			}
			else if (dir.IndexOf(":") < 0) {
				msg = "The directory needs to be a full path.";
			}
			else if (!Directory.Exists(dir)) {
				msg = "The directory does not exist.";
			}

			if (msg.Length > 0) {
				MessageBox.Show(msg, _Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.txtDirectory.SelectAll();
				this.txtDirectory.Focus();
				return false;
			}
			else {
				return true;
			}
		}

		private bool checkFile(TextBox o)
		{
			String msg = "";

			if (o.Text == "") {
				msg = "The file path can't be empty.\nPlease input one.";
			}
			else if (o.Text.IndexOf(":") < 0) {
				String filePath = Path.Combine(this.txtDirectory.Text, o.Text);
				if (File.Exists(filePath)) {
					o.Text = filePath;
				}
				else {
					msg = "The list file needs a full path.";
				}
			}
			else if (!File.Exists(o.Text)) {
				msg = "The list file does not exist.";
			}

			if (msg.Length > 0) {
				MessageBox.Show(msg, _Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
				o.SelectAll();
				o.Focus();
				return false;
			}
			else {
				return true;
			}
		}

		#endregion

		#region Control Events

		private void btnRename_Click(object sender, EventArgs e)
		{
			if (checkDir() && checkFile(this.txtOldName) && checkFile(this.txtNewName)) {
				if (MessageBox.Show("Preivew ...", _Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel) {
					return;
				}
				RenameCore o = new RenameCore();
				o.Directory = this.txtDirectory.Text;
				o.IncludeFile = this.chkFile.Checked;
				o.IncludeFolder = this.chkFolder.Checked;
				int nCount = o.RenameByNameList(this.txtOldName.Text, this.txtNewName.Text);
				if (nCount >= 0) {
					MessageBox.Show(nCount.ToString() + " file or folder " + (nCount > 1 ? "have" : "has") + " been renamed!");
				}
				else {
					MessageBox.Show("Failed to rename.".PadRight(30), _Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnAction_Click(object sender, EventArgs e)
		{
			switch(this.btnAction.Text.Replace("&", "")) {
				case "Browse ...":
					SelectDirectory();
					break;
				case "Open":
					OpenDirectory();
					break;
				case "Create":
					CreateFileList();
					break;
				case "Apply":
					UpdateListPath();
					break;
				default:
					break;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnActionMenu_Click(object sender, EventArgs e)
		{
			if (e.GetType().Name == "MouseEventArgs") { // Button is clicked by mouse.
				this.menuDirAction.Show(Control.MousePosition);
			}
			else {
				int x = this.btnActionMenu.Left + this.btnActionMenu.Width * 3 / 4;
				int y = this.btnActionMenu.Height + this.btnActionMenu.Width * 1 / 2;
				this.menuDirAction.Show(this, x, y);
			}
		}

		private void browseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.btnAction.Text = "&Browse ...";
			this.toolTip1.SetToolTip(this.btnAction, "Select a directory");
			this.btnAction.PerformClick();
		}
		
		private void openThisDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.btnAction.Text = "&Open";
			this.toolTip1.SetToolTip(this.btnAction, "Open this directory");
			this.btnAction.PerformClick();
		}

		private void createFileListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.btnAction.Text = "&Create";
			this.toolTip1.SetToolTip(this.btnAction, "Create a list of files/folder for this direcotry");
			this.btnAction.PerformClick();
		}

		private void updateListPathesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.btnAction.Text = "&Apply";
			this.toolTip1.SetToolTip(this.btnAction, "Apply the directory to list file paths");
			this.btnAction.PerformClick();
		}

		#endregion
	}
}