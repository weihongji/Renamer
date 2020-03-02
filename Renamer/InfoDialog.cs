using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Renamer
{
	public partial class InfoDialog : Form
	{
		public InfoDialog() {
			InitializeComponent();
		}

		public InfoDialog(String text) {
			InitializeComponent();
			this.textBox1.Text = text;
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				this.Close();
			}
		}

		private void InfoForm_Load(object sender, EventArgs e) {
			//this.Location = this.Owner.Location;
		}

		private void InfoForm_Shown(object sender, EventArgs e) {
			this.textBox1.SelectionLength = 0;
		}
	}
}
