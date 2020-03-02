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
		public String Title { get; set; }

		public InfoDialog() {
			InitializeComponent();
		}

		public InfoDialog(String text) {
			InitializeComponent();
			this.textBox1.Text = text;
		}

		private void InfoForm_Load(object sender, EventArgs e) {
			if (!String.IsNullOrEmpty(this.Title)) {
				this.Text = this.Title;
			}
		}

		private void InfoForm_Shown(object sender, EventArgs e) {
			this.textBox1.SelectionLength = 0;
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				this.Close();
			}
		}
	}
}
