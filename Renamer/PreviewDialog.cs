using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renamer
{
	public partial class PreviewDialog : Form
	{
		public PreviewDialog() {
			InitializeComponent();
		}

		public PreviewDialog(String text) {
			InitializeComponent();
			this.txtList.Text = text;
		}

		private void btnOK_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void PreviewDialog_Shown(object sender, EventArgs e) {
			this.txtList.SelectionLength = 0;
		}

		private void txtList_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				this.Close();
			}
		}
	}
}
