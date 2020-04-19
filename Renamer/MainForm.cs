using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Resources;

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
			var onTop = GetConfigBool("OnTop");
			this.chkOnTop.Checked = onTop;
			chkOnTop_Click(null, null);
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
				int lineCount = 1;
				foreach (var ch in msg) {
					if (ch == '\n') {
						lineCount++;
					}
				}
				if (lineCount < 2) {
					MessageBox.Show(msg, Res.Get("mainform_problem"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else {
					var form = new InfoDialog(msg) { Title = Res.Get("mainform_problem") };
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
					lastEntry = String.Format(Res.Get("mainform_error_when_renaming_format") + "\r\n" + new String('-', 60), n1.Name, n2.Name);
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
					msg = String.Format(Res.Get("mainform_files_renamed_format"), count);
					MessageBox.Show(msg, Res.Get("mainform_success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else { // Exception caught
					msg = String.Format(Res.Get("mainform_files_renamed_format") + "\r\n\r\n{1}", count, msg);
					MessageBox.Show(msg, Res.Get("mainform_fail_to_rename"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					MessageBox.Show(String.Format(Res.Get("mainform_no_file_in_dir_format"), this.Folder), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void menuOpenFolder_Click(object sender, EventArgs e) {
			if (CheckDir()) {
				System.Diagnostics.Process.Start("explorer.exe", this.Folder);
			}
		}

		private void menuAbout_Click(object sender, EventArgs e) {
			var about = new 关于();
			about.ShowDialog(this);
		}

		private void btnSwape_Click(object sender, EventArgs e) {
			var s = this.txtOldName.Text;
			this.txtOldName.Text = this.txtNewName.Text;
			this.txtNewName.Text = s;
		}

		private void btnExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void txtOldName_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				e.Effect = DragDropEffects.Link;
			}
		}

		private void txtOldName_DragDrop(object sender, DragEventArgs e) {
			string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
			if (files != null) {
				if (files.Length == 1) {
					this.txtOldName.Text = GetRelativePath(files[0], this.Folder);
				}
				else if (files.Length >= 2) {
					this.txtOldName.Text = GetRelativePath(files[0], this.Folder);
					this.txtNewName.Text = GetRelativePath(files[1], this.Folder);
				}
			}
		}

		private void txtNewName_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				e.Effect = DragDropEffects.Link;
			}
		}

		private void txtNewName_DragDrop(object sender, DragEventArgs e) {
			string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
			if (files != null) {
				if (files.Length == 1) {
					this.txtNewName.Text = GetRelativePath(files[0], this.Folder);
				}
				else if (files.Length >= 2) {
					this.txtOldName.Text = GetRelativePath(files[0], this.Folder);
					this.txtNewName.Text = GetRelativePath(files[1], this.Folder);
				}
			}
		}

		private void chkOnTop_Click(object sender, EventArgs e) {
			this.TopMost = this.chkOnTop.Checked;
		}
		#endregion

		#region Methods
		private bool CheckDir() {
			String msg = "";

			if (this.Folder == "") {
				msg = Res.Get("mainform_folder_missing").PadRight(40);
			}
			else if (!Directory.Exists(this.Folder)) {
				msg = Res.Get("mainform_dir_not_exist").PadRight(40);
			}

			if (msg.Length > 0) {
				MessageBox.Show(msg, Res.Get("mainform_invalid_dir"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.cmbDirectory.Focus();
				return false;
			}

			return true;
		}

		private bool CheckFile(String file) {
			String msg = "";

			if (file == "") {
				msg = Res.Get("mainform_file_path_empty").PadRight(40);
			}
			else if (!File.Exists(file)) {
				msg = String.Format(Res.Get("mainform_file_not_exist_format"), GetFileName(file)).PadRight(40);
			}

			if (msg.Length > 0) {
				MessageBox.Show(msg, Res.Get("mainform_file_not_found"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				messages.Add(String.Format(Res.Get("mainform_files_count_no_match_format"), list1.Count, list2.Count));
			}
			else {
				// Remove unchanged entries
				for (int i = list1.Count - 1; i >= 0; i--) {
					if (list1[i].Equals(list2[i], StringComparison.InvariantCultureIgnoreCase)) {
						list1.RemoveAt(i);
						list2.RemoveAt(i);
					}
				}
				if (list1.Count == 0) {
					messages.Add(Res.Get("mainform_list_file_empty"));
				}
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
				messages.Add(Res.Get("mainform_following_files_not_exist"));
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
				messages.Add(Res.Get("mainform_following_files_already_exist"));
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
			int indexMaxChar = this.OldNames.Count.ToString().Length;
			List<String> items = new List<String>();
			for (int i = 0; i < this.OldNames.Count; i++) {
				var n1 = this.OldNames[i];
				var n2 = this.NewNames[i];
				items.Add(String.Format("[{2}] {0} -->  {1}", n1.Name.PadRight(maxChar), n2.Name, (i + 1).ToString().PadLeft(indexMaxChar)));
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

		public static string GetConfigString(string key, string defaultValue = "") {
			var config = System.Configuration.ConfigurationManager.AppSettings[key];

			if (!string.IsNullOrEmpty(config)) {
				return config;
			}
			return defaultValue;
		}

		public static int GetConfigInt(string key, int defaultValue = 0) {
			var config = System.Configuration.ConfigurationManager.AppSettings[key];

			int i;
			if (!string.IsNullOrEmpty(config) && int.TryParse(config, out i)) {
				if (i > 0) {
					return i;
				}
			}
			return defaultValue;
		}

		public static bool GetConfigBool(string key, bool defaultValue = false) {
			var config = System.Configuration.ConfigurationManager.AppSettings[key];

			bool b;
			if (!string.IsNullOrEmpty(config) && bool.TryParse(config, out b)) {
				return b;
			}
			return defaultValue;
		}

		private string GetRelativePath(string path, string relativeTo) {
			if (relativeTo == null || relativeTo.Trim().Length == 0) {
				return path;
			}
			if (!relativeTo.EndsWith("\\")) {
				relativeTo += "\\";
			}
			if (path.StartsWith(relativeTo)) {
				path = path.Substring(relativeTo.Length);
			}
			return path;
		}
		#endregion

	}
}