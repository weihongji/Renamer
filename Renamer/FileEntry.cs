using System;
using System.Collections.Generic;
using System.Text;

namespace Renamer
{
	public class FileEntry
	{
		public String Name { get; set; }
		public String Directory { get; set; }
		public String Path { get; set; }
		public EntryType Type { get; set; }

		public FileEntry() {
			PopulateDefault();
		}

		public FileEntry(String path) {
			PopulateDefault();

			path = path == null ? "" : path.Trim();
	
			// If the last character is a slash, remove it.
			if (path.Length > 0 && path[path.Length - 1] == '\\') {
				path = path.Substring(0, path.Length - 1);
			}
			if (path.Length == 0) {
				return;
			}

			var start = path.LastIndexOf('\\');
			if (start < 0) {
				this.Name = path;
			}
			else {
				this.Name = path.Substring(start + 1);
				this.Directory = path.Substring(0, start);
				this.Path = path;
				if (System.IO.File.Exists(path)) {
					this.Type = EntryType.File;
				}
				else if (System.IO.Directory.Exists(path)) {
					this.Type = EntryType.Directory;
				}
			}
		}

		private void PopulateDefault() {
			this.Name = this.Directory = this.Path = "";
			this.Type = EntryType.None;
		}

		public override string ToString() {
			return String.Format("{0}: {1} in {2}", this.Type.ToString(), this.Name, this.Directory);
		}
	}

	public enum EntryType
	{
		None,
		File,
		Directory,
	}
}
