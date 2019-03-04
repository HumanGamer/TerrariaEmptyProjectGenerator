using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaEmptyProjectGenerator
{
	public partial class MainForm : Form
	{
		public string BaseDirectory
		{
			get => txtPath.Text;
			set
			{
				txtPath.Text = value;
				if (txtPath.Text.Trim().Length == 0)
					txtPath.Text = "<Please Select Target Directory>";
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void ValidateInput()
		{
			string pathError = null;
			string nameError = null;
			string idError = null;

			if (!Utils.IsValidDirectoryPath(txtPath.Text))
				pathError = "Path must point to a valid directory, not a file!";

			if (!Utils.IsValidName(txtName.Text))
				nameError = "Invalid Name";

			if (!Utils.IsValidID(txtID.Text))
				idError = "Invalid ID";

			if (pathError == null && nameError == null && idError == null)
			{
				btnGenerate.Enabled = true;
			}
			else
			{
				btnGenerate.Enabled = false;
				// TODO: Display Errors
			}
		}

		private void _generateIDFromName()
		{
			string id = txtName.Text.Replace(" ", "").Trim();
			if (id.Length == 0)
			{
				txtID.Text = "";
				return;
			}

			if (!char.IsLetter(id[0]))
				id = "_" + id;

			StringBuilder sb = new StringBuilder();
			foreach (var c in id)
			{
				if (c == '&')
				{
					sb.Append("And");
					continue;
				}

				if (c == '+')
				{
					sb.Append("Plus");
					continue;
				}

				if (c != '_' && !char.IsLetterOrDigit(c))
					continue;

				sb.Append(c);
			}

			txtID.Text = sb.ToString();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if (chkAutoID.Checked)
				_generateIDFromName();
			
			ValidateInput();
		}

		private void chkAutoID_CheckedChanged(object sender, EventArgs e)
		{
			txtID.ReadOnly = chkAutoID.Checked;
			if (chkAutoID.Checked)
				_generateIDFromName();
			else
				txtID.Text = "";

			ValidateInput();
		}

		private void txtID_TextChanged(object sender, EventArgs e)
		{
			if (chkAutoID.Checked)
				return;
			
			ValidateInput();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.ShowNewFolderButton = true;
			DialogResult result = fbd.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				txtPath.Text = fbd.SelectedPath;
				if (txtPath.Text.Trim().Length == 0)
					txtPath.Text = "<Please Select Target Directory>";
				ValidateInput();
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(BaseDirectory))
				Directory.CreateDirectory(BaseDirectory);

			// TODO: Generate
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
