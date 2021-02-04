
namespace Notepad
{
    partial class frmAbout
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
            this.btnOK = new System.Windows.Forms.Button();
            this.separatorBar = new System.Windows.Forms.Label();
            this.lblWindows = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.notepadPic = new System.Windows.Forms.PictureBox();
            this.WindowsPic = new System.Windows.Forms.PictureBox();
            this.lblLicenceUser = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCopyrightInfo = new System.Windows.Forms.Label();
            this.lblWindowsBuild = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notepadPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(357, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // separatorBar
            // 
            this.separatorBar.AllowDrop = true;
            this.separatorBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorBar.Location = new System.Drawing.Point(19, 94);
            this.separatorBar.Name = "separatorBar";
            this.separatorBar.Size = new System.Drawing.Size(400, 2);
            this.separatorBar.TabIndex = 2;
            // 
            // lblWindows
            // 
            this.lblWindows.AutoSize = true;
            this.lblWindows.Location = new System.Drawing.Point(49, 109);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(97, 13);
            this.lblWindows.TabIndex = 3;
            this.lblWindows.Text = "Microsoft Windows";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(49, 186);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(348, 58);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "The Windows 10 Home operating system and its user interface are protected by trad" +
    "emark and other pending or existing intellectual property rights in the United S" +
    "tates and other countries/regions.";
            // 
            // notepadPic
            // 
            this.notepadPic.Image = global::Notepad.Properties.Resources.notepad_icon;
            this.notepadPic.Location = new System.Drawing.Point(15, 109);
            this.notepadPic.Name = "notepadPic";
            this.notepadPic.Size = new System.Drawing.Size(30, 30);
            this.notepadPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notepadPic.TabIndex = 5;
            this.notepadPic.TabStop = false;
            // 
            // WindowsPic
            // 
            this.WindowsPic.Image = global::Notepad.Properties.Resources.windows_logo;
            this.WindowsPic.Location = new System.Drawing.Point(19, 12);
            this.WindowsPic.Name = "WindowsPic";
            this.WindowsPic.Size = new System.Drawing.Size(400, 73);
            this.WindowsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WindowsPic.TabIndex = 1;
            this.WindowsPic.TabStop = false;
            // 
            // lblLicenceUser
            // 
            this.lblLicenceUser.Location = new System.Drawing.Point(49, 275);
            this.lblLicenceUser.Name = "lblLicenceUser";
            this.lblLicenceUser.Size = new System.Drawing.Size(328, 32);
            this.lblLicenceUser.TabIndex = 6;
            this.lblLicenceUser.Text = "This product is licensed under the Microsoft Software License Terms to:";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(64, 315);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(340, 19);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // lblCopyrightInfo
            // 
            this.lblCopyrightInfo.Location = new System.Drawing.Point(49, 145);
            this.lblCopyrightInfo.Name = "lblCopyrightInfo";
            this.lblCopyrightInfo.Size = new System.Drawing.Size(355, 19);
            this.lblCopyrightInfo.TabIndex = 8;
            this.lblCopyrightInfo.Text = "© 2019 Microsoft Corporation. All rights reserved.";
            // 
            // lblWindowsBuild
            // 
            this.lblWindowsBuild.Location = new System.Drawing.Point(49, 127);
            this.lblWindowsBuild.Name = "lblWindowsBuild";
            this.lblWindowsBuild.Size = new System.Drawing.Size(355, 19);
            this.lblWindowsBuild.TabIndex = 9;
            this.lblWindowsBuild.Text = "windowsBuild info";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 384);
            this.Controls.Add(this.lblWindowsBuild);
            this.Controls.Add(this.lblCopyrightInfo);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLicenceUser);
            this.Controls.Add(this.notepadPic);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblWindows);
            this.Controls.Add(this.separatorBar);
            this.Controls.Add(this.WindowsPic);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Notepad";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notepadPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox WindowsPic;
        private System.Windows.Forms.Label separatorBar;
        private System.Windows.Forms.Label lblWindows;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox notepadPic;
        private System.Windows.Forms.Label lblLicenceUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCopyrightInfo;
        private System.Windows.Forms.Label lblWindowsBuild;
    }
}