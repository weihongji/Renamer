using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Renamer
{
	class RenameCore
	{
		private String _sDirectory = "";
		private bool _bIncludeFile = true;
		private bool _bIncludeFolder = true;

		public String Directory {
			set {
				if (value.Length < 3) { // The directory is not a full path or invalid.
					this._sDirectory = "";
				}
				else {
					this._sDirectory = value;
				}
			}
			get { return this._sDirectory; }
		}

		public bool IncludeFile {
			set { this._bIncludeFile = value; }
			get { return this._bIncludeFile; }
		}

		public bool IncludeFolder {
			set { this._bIncludeFolder = value; }
			get { return this._bIncludeFolder; }
		}

		// Return the count of files that has been renamed successfully. If encounters error, return -1.
		public int RenameByNameList(String ExistingNameListPath, String NewNameListPath) {
			int count = 0;
			try {
				String[,] fullPathes = GetRenameList(ExistingNameListPath, NewNameListPath);
				int iLength = fullPathes.GetUpperBound(0) + 1;
				for (int i = 0; i < iLength; i++) {
					if (System.IO.File.Exists(fullPathes[i, 0])) {
						System.IO.File.Move(fullPathes[i, 0], fullPathes[i, 1]);
						count++;
					}
					else {
						System.IO.Directory.Move(fullPathes[i, 0], fullPathes[i, 1]);
						count++;
					}
				}
				return count;
			}
			catch {
				return -1;
			}
		}

		// Get the list of full pathes of files/folders that will be renamed.
		// Since there is the possibility that some files in the name list file can not be renamed successful,this function will get the actual ones.
		public String[,] GetRenameList(String ExistingNameListPath, String NewNameListPath) {
			String[] OldFileNames = File.ReadAllLines(ExistingNameListPath, Encoding.Default);
			String[] NewFileNames = File.ReadAllLines(NewNameListPath, Encoding.Default);
			List<String> oldPathList = new List<String>();
			List<String> newPathList = new List<String>();

			for (int i = 0; i < OldFileNames.Length; i++) {
				if (OldFileNames[i].Length > 0 && NewFileNames[i].Length > 0 && String.Compare(OldFileNames[i], NewFileNames[i], true) != 0) {
					if (this._bIncludeFolder && System.IO.Directory.Exists(Path.Combine(this._sDirectory, OldFileNames[i]))) {
						oldPathList.Add(Path.Combine(this._sDirectory, OldFileNames[i]));
						newPathList.Add(Path.Combine(this._sDirectory, NewFileNames[i]));
					}
					else if (this._bIncludeFile && System.IO.File.Exists(Path.Combine(this._sDirectory, OldFileNames[i]))) {
						oldPathList.Add(Path.Combine(this._sDirectory, OldFileNames[i]));
						newPathList.Add(Path.Combine(this._sDirectory, NewFileNames[i]));
					}
				}
			}
			String[,] ValidNames = new string[oldPathList.Count, 2];
			int iLength = ValidNames.GetUpperBound(0) + 1;
			for (int i = 0; i < iLength; i++) {
				ValidNames[i, 0] = oldPathList[i];
				ValidNames[i, 1] = newPathList[i];
			}
			return ValidNames;
		}
	}
}
