namespace TerrariaEmptyProjectGenerator
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
			if (disposing && (components != null))
			{
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
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.pbMain = new System.Windows.Forms.ProgressBar();
			this.chkAutoID = new System.Windows.Forms.CheckBox();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.lblPath = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.picPath = new System.Windows.Forms.PictureBox();
			this.picName = new System.Windows.Forms.PictureBox();
			this.picID = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picPath)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picID)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGenerate
			// 
			this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerate.Enabled = false;
			this.btnGenerate.Location = new System.Drawing.Point(383, 125);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 2;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(15, 125);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(58, 38);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(394, 20);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtID
			// 
			this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtID.Location = new System.Drawing.Point(58, 64);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(346, 20);
			this.txtID.TabIndex = 1;
			this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(14, 41);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name:";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(14, 68);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(21, 13);
			this.lblID.TabIndex = 5;
			this.lblID.Text = "ID:";
			// 
			// pbMain
			// 
			this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbMain.Location = new System.Drawing.Point(15, 96);
			this.pbMain.Name = "pbMain";
			this.pbMain.Size = new System.Drawing.Size(443, 23);
			this.pbMain.TabIndex = 4;
			// 
			// chkAutoID
			// 
			this.chkAutoID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkAutoID.AutoSize = true;
			this.chkAutoID.Checked = true;
			this.chkAutoID.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAutoID.Location = new System.Drawing.Point(410, 67);
			this.chkAutoID.Name = "chkAutoID";
			this.chkAutoID.Size = new System.Drawing.Size(48, 17);
			this.chkAutoID.TabIndex = 6;
			this.chkAutoID.Text = "Auto";
			this.chkAutoID.UseVisualStyleBackColor = true;
			this.chkAutoID.CheckedChanged += new System.EventHandler(this.chkAutoID_CheckedChanged);
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(58, 12);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(360, 20);
			this.txtPath.TabIndex = 7;
			this.txtPath.Text = "<Please Select Target Directory>";
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(14, 15);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(32, 13);
			this.lblPath.TabIndex = 8;
			this.lblPath.Text = "Path:";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(424, 12);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(28, 23);
			this.btnBrowse.TabIndex = 9;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// picPath
			// 
			this.picPath.Location = new System.Drawing.Point(458, 12);
			this.picPath.Name = "picPath";
			this.picPath.Size = new System.Drawing.Size(20, 20);
			this.picPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPath.TabIndex = 10;
			this.picPath.TabStop = false;
			// 
			// picName
			// 
			this.picName.Location = new System.Drawing.Point(458, 38);
			this.picName.Name = "picName";
			this.picName.Size = new System.Drawing.Size(20, 20);
			this.picName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picName.TabIndex = 11;
			this.picName.TabStop = false;
			// 
			// picID
			// 
			this.picID.Location = new System.Drawing.Point(458, 64);
			this.picID.Name = "picID";
			this.picID.Size = new System.Drawing.Size(20, 20);
			this.picID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picID.TabIndex = 12;
			this.picID.TabStop = false;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnGenerate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(490, 160);
			this.Controls.Add(this.picID);
			this.Controls.Add(this.picName);
			this.Controls.Add(this.picPath);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.chkAutoID);
			this.Controls.Add(this.pbMain);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnGenerate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Terraria Empty Project Generator";
			((System.ComponentModel.ISupportInitialize)(this.picPath)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picID)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.ProgressBar pbMain;
		private System.Windows.Forms.CheckBox chkAutoID;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.PictureBox picPath;
		private System.Windows.Forms.PictureBox picName;
		private System.Windows.Forms.PictureBox picID;
	}
}