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
		public String Folder {
			get {
				String dir = this.cmbDirectory.Text.Trim();
				if (dir.Length > 0 && dir.Substring(dir.Length - 1) == ":") { // Change "C:" to "C:\"
					this.cmbDirectory.Text = dir + "\\";
				}
				return this.cmbDirectory.Text;
			}

			set {
				this.cmbDirectory.Text = value;
			}
		}

		public String File1 {
			get {
				String file = this.txtOldName.Text.Trim();
				if (file.Length > 0 && file.IndexOf(':') < 0) { // Relative path (based on the Folder)
					file = Path.Combine(this.Folder, file);

				}
				return file;
			}

			set {
				this.txtOldName.Text = value;
			}
		}

		public String File2 {
			get {
				String file = this.txtNewName.Text.Trim();
				if (file.Length > 0 && file.IndexOf(':') < 0) { // Relative path (based on the Folder)
					file = Path.Combine(this.Folder, file);
				}
				return file;
			}

			set {
				this.txtNewName.Text = value;
			}
		}

		public List<FileEntry> OldNames { get; set; }
		public List<FileEntry> NewNames { get; set; }

		public MainForm() {
			InitializeComponent();

			// Initialization
			this.OldNames = new List<FileEntry>();
			this.NewNames = new List<FileEntry>();

			// Load Configuration
			this.cmbDirectory.Text = GetConfigString("Directory");
			this.txtOldName.Text = GetConfigString("OldFile", "1.txt");
			this.txtNewName.Text = GetConfigString("NewFile", "2.txt");
			var encoding = GetConfigString("Encoding");
			if (encoding == "UTF8") {
				this.rdoEncodingUTF8.Checked = true;
			}
			else {
				this.rdoEncodingDefault.Checked = true;
			}
			int width = GetConfigInt("Width");
			if ((width >= this.MinimumSize.Width || this.MinimumSize.Width == 0) && (width <= this.MaximumSize.Width || this.MaximumSize.Width == 0)) {
				this.Width = width;
			}
		}

		#region Control Events
		private void btnRename_Click(object sender, EventArgs e) {
			if (!CheckDir()) {
				return;
			}
			else {
				PushToHistory(this.Folder);
			}
			if (!CheckFile(this.File1)) {
				this.txtOldName.SelectAll();
				this.txtOldName.Focus();
				return;
			}
			if (!CheckFile(this.File2)) {
				this.txtNewName.SelectAll();
				this.txtNewName.Focus();
				return;
			}

			var msg = CheckList();
			if (msg.Length > 0) {
				int lineCount = 0;
				foreach (var ch in msg) {
					if (ch == '\n') {
						lineCount++;
					}
				}
				if (lineCount <= 2) {
					MessageBox.Show(msg, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else {
					var form = new InfoDialog(msg) { Title = "Problem" };
					form.ShowDialog(this);
				}
				return;
			}

			if (!PreviewList()) {
				return;
			}

			// Rename files
			int count = 0;
			String lastEntry = "";
			msg = "";
			try {
				for (int i = 0; i < this.OldNames.Count; i++) {
					var n1 = this.OldNames[i];
					var n2 = this.NewNames[i];
					lastEntry = String.Format("Error happened when renaming \"{0}\" to \"{1}\":\r\n" + new String('-', 60), n1.Name, n2.Name);
					if (n1.Type == EntryType.Directory) {
						Directory.Move(n1.Path, n2.Path);
						count++;
					}
					else if (n1.Type == EntryType.File) {
						File.Move(n1.Path, n2.Path);
						count++;
					}
				}
			}
			catch (Exception ex) {
				msg = lastEntry + "\r\n" + ex.Message;
			}
			finally {
				if (msg.Length == 0) { // Success
					msg = String.Format("{0} files and folders have been renamed.", count).PadRight(80);
					MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else { // Exception caught
					msg = String.Format("{0} files and folders have been renamed.\r\n\r\n{1}", count, msg);
					MessageBox.Show(msg, "Failed to Rename", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			this.browserDialog.SelectedPath = this.Folder;
			if (this.browserDialog.ShowDialog() == DialogResult.OK) {
				this.Folder = this.browserDialog.SelectedPath;
			}
		}

		private void btnActionMenu_Click(object sender, EventArgs e) {
			if (e.GetType().Name == "MouseEventArgs") { // Button is clicked by mouse.
				this.menuDirAction.Show(Control.MousePosition);
			}
			else {
				int x = this.btnActionMenu.Left + this.btnActionMenu.Width * 3 / 4;
				int y = this.btnActionMenu.Height + this.btnActionMenu.Width * 1 / 2;
				this.menuDirAction.Show(this, x, y);
			}
		}

		private void menuCopyFileNames_Click(object sender, EventArgs e) {
			if (CheckDir()) {
				string[] names = Directory.GetFileSystemEntries(this.Folder);
				if (names.Length > 0) {
					int start = names[0].LastIndexOf('\\') + 1;
					for (int i = 0; i < names.Length; i++) {
						names[i] = names[i].Substring(start);
					}
					Clipboard.SetText(String.Join("\r\n", names));
				}
				else {
					MessageBox.Show("No file or directory in " + this.Folder, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void menuOpenFolder_Click(object sender, EventArgs e) {
			if (CheckDir()) {
				System.Diagnostics.Process.Start("explorer.exe", this.Folder);
			}
		}

		private void btnSwape_Click(object sender, EventArgs e) {
			var s = this.txtOldName.Text;
			this.txtOldName.Text = this.txtNewName.Text;
			this.txtNewName.Text = s;
		}

		private void btnExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		#endregion

		#region Methods
		private bool CheckDir() {
			String msg = "";

			if (this.Folder == "") {
				msg = "Directory is empty.".PadRight(40);
			}
			else if (!Directory.Exists(this.Folder)) {
				msg = "Directory doesn't exist.".PadRight(40);
			}

			if (msg.Length > 0) {
				MessageBox.Show(msg, "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.cmbDirectory.Focus();
				return false;
			}

			return true;
		}

		private bool CheckFile(String file) {
			String msg = "";

			if (file == "") {
				msg = "File path is empty.".PadRight(40);
			}
			else if (!File.Exists(file)) {
				msg = "File " + GetFileName(file) + " doesn't exist.".PadRight(40);
			}

			if (msg.Length > 0) {
				MessageBox.Show(msg, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private String GetFileName(string path) {
			if (String.IsNullOrEmpty(path)) {
				return "";
			}
			path = path.Trim();
			var start = path.LastIndexOf('\\');
			if (start >= 0) {
				path = path.Substring(start + 1);
			}
			return path;
		}

		private List<String> GetList(String file) {
			String file1 = GetFileName(this.File1);
			String file2 = GetFileName(this.File2);

			Encoding encoding = this.rdoEncodingDefault.Checked ? Encoding.Default : Encoding.UTF8;
			String[] lines = File.ReadAllLines(file, encoding);
			List<String> names = new List<String>();

			for (int i = 0; i < lines.Length; i++) {
				var ln = lines[i].Trim();
				// Ignore empty lines
				if (ln.Length == 0) {
					continue;
				}
				// Ignore name of list files (Command "dir . /b > 1.txt" will put 1.txt in file list. Let's ignore it here.)
				if (ln.Equals(file1, StringComparison.OrdinalIgnoreCase) || ln.Equals(file2, StringComparison.OrdinalIgnoreCase)) {
					continue;
				}
				// Ignore duplication
				if (names.Contains(ln)) {
					continue;
				}
				names.Add(ln);
			}

			return names;
		}

		private String CheckList() {
			List<String> messages = new List<String>();
			var list1 = GetList(this.File1);
			var list2 = GetList(this.File2);
			if (list1.Count != list2.Count) {
				messages.Add(String.Format("Number of files are not match. (Old: {0}, New: {1})", list1.Count, list2.Count));
			}
			else if (list1.Count == 0) {
				messages.Add("Nothing in the list files.");
			}

			if (messages.Count > 0) {
				return String.Join("\r\n", messages.ToArray());
			}

			this.OldNames.Clear();
			this.NewNames.Clear();
			var dir = this.Folder;
			for (int i = 0; i < list1.Count; i++) {
				this.OldNames.Add(new FileEntry(Path.Combine(dir, list1[i])));
				this.NewNames.Add(new FileEntry(Path.Combine(dir, list2[i])));
			}

			List<String> items = new List<String>();
			foreach (var entry in this.OldNames) {
				if (entry.Type == EntryType.None) {
					items.Add("\t" + entry.Name);
				}
			}
			if (items.Count > 0) {
				messages.Add("Following files don't exist:");
				messages.AddRange(items);
			}

			items.Clear();
			foreach (var entry in this.NewNames) {
				if (entry.Type != EntryType.None) {
					items.Add("\t" + entry.Name);
				}
			}
			if (items.Count > 0) {
				if (messages.Count > 0) {
					messages.Add("\r\n");
				}
				messages.Add("Following files already exist and cannot be used as new name:");
				messages.AddRange(items);
			}

			return String.Join("\r\n", messages.ToArray());
		}

		private Boolean PreviewList() {
			int maxChar = 0;
			foreach (var entry in this.OldNames) {
				if (entry.Name.Length > maxChar) {
					maxChar = entry.Name.Length;
				}
			}
			List<String> items = new List<String>();
			for (int i = 0; i < this.OldNames.Count; i++) {
				var n1 = this.OldNames[i];
				var n2 = this.NewNames[i];
				items.Add(String.Format("{0} -->  {1}", n1.Name.PadRight(maxChar), n2.Name));
			}
			var dialog = new PreviewDialog(String.Join("\r\n", items.ToArray()));
			var result = dialog.ShowDialog(this);
			return result == DialogResult.OK;
		}

		// Put the folder into combox
		private void PushToHistory(string text) {
			if (text == null || text.Trim().Length == 0) {
				return;
			}
			var index = this.cmbDirectory.FindStringExact(text);
			if (index >= 0) {
				this.cmbDirectory.Items.RemoveAt(index);
			}
			this.cmbDirectory.Items.Insert(0, text);
		}

		private static string GetConfigString(string key, string defaultValue = "") {
			var config = System.Configuration.ConfigurationManager.AppSettings[key];

			if (!string.IsNullOrEmpty(config)) {
				return config;
			}
			return defaultValue;
		}

		private static int GetConfigInt(string key, int defaultValue = 0) {
			var config = System.Configuration.ConfigurationManager.AppSettings[key];

			int i;
			if (!string.IsNullOrEmpty(config) && int.TryParse(config, out i)) {
				if (i > 0) {
					return i;
				}
			}
			return defaultValue;
		}

		private static bool GetConfigBool(string key, bool defaultValue = false) {
			var config = System.Configuration.ConfigurationManager.AppSettings[key];

			bool b;
			if (!string.IsNullOrEmpty(config) && bool.TryParse(config, out b)) {
				return b;
			}
			return defaultValue;
		}
		#endregion
	}
}