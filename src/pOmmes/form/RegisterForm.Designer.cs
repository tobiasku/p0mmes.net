using pOmmes.Properties;

namespace pOmmes
{
    partial class RegisterForm
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
            this.mbtn_Register = new MetroFramework.Controls.MetroButton();
            this.mlbl_desc_Password = new MetroFramework.Controls.MetroLabel();
            this.mtxt_Password = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_desc_UserName = new MetroFramework.Controls.MetroLabel();
            this.mtxt_UserName = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_desc_ForeName = new MetroFramework.Controls.MetroLabel();
            this.mtxt_ForeName = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_desc_SurName = new MetroFramework.Controls.MetroLabel();
            this.mtxt_SurName = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_desc_Email = new MetroFramework.Controls.MetroLabel();
            this.mtxt_Email = new MetroFramework.Controls.MetroTextBox();
            this.mcmb_Company = new MetroFramework.Controls.MetroComboBox();
            this.mlbl_desc_Company = new MetroFramework.Controls.MetroLabel();
            this.mbtn_Cancel = new MetroFramework.Controls.MetroButton();
            this.mlbl_desc_RetypePassword = new MetroFramework.Controls.MetroLabel();
            this.mtxt_RetypePassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mbtn_Register
            // 
            this.mbtn_Register.Location = new System.Drawing.Point(215, 405);
            this.mbtn_Register.Name = "mbtn_Register";
            this.mbtn_Register.Size = new System.Drawing.Size(90, 29);
            this.mbtn_Register.TabIndex = 8;
            this.mbtn_Register.Text = "Register";
            this.mbtn_Register.UseSelectable = true;
            this.mbtn_Register.Click += new System.EventHandler(this.mbtn_Register_Click);
            // 
            // mlbl_desc_Password
            // 
            this.mlbl_desc_Password.AutoSize = true;
            this.mlbl_desc_Password.Location = new System.Drawing.Point(23, 252);
            this.mlbl_desc_Password.Name = "mlbl_desc_Password";
            this.mlbl_desc_Password.Size = new System.Drawing.Size(66, 19);
            this.mlbl_desc_Password.TabIndex = 8;
            this.mlbl_desc_Password.Text = "Password:";
            // 
            // mtxt_Password
            // 
            // 
            // 
            // 
            this.mtxt_Password.CustomButton.Image = null;
            this.mtxt_Password.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxt_Password.CustomButton.Name = "";
            this.mtxt_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Password.CustomButton.TabIndex = 1;
            this.mtxt_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Password.CustomButton.UseSelectable = true;
            this.mtxt_Password.CustomButton.Visible = false;
            this.mtxt_Password.Lines = new string[0];
            this.mtxt_Password.Location = new System.Drawing.Point(23, 274);
            this.mtxt_Password.MaxLength = 32767;
            this.mtxt_Password.Name = "mtxt_Password";
            this.mtxt_Password.PasswordChar = '●';
            this.mtxt_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Password.SelectedText = "";
            this.mtxt_Password.SelectionLength = 0;
            this.mtxt_Password.SelectionStart = 0;
            this.mtxt_Password.Size = new System.Drawing.Size(282, 23);
            this.mtxt_Password.TabIndex = 5;
            this.mtxt_Password.UseSelectable = true;
            this.mtxt_Password.UseSystemPasswordChar = true;
            this.mtxt_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_desc_UserName
            // 
            this.mlbl_desc_UserName.AutoSize = true;
            this.mlbl_desc_UserName.Location = new System.Drawing.Point(23, 60);
            this.mlbl_desc_UserName.Name = "mlbl_desc_UserName";
            this.mlbl_desc_UserName.Size = new System.Drawing.Size(71, 19);
            this.mlbl_desc_UserName.TabIndex = 6;
            this.mlbl_desc_UserName.Text = "Username:";
            // 
            // mtxt_UserName
            // 
            // 
            // 
            // 
            this.mtxt_UserName.CustomButton.Image = null;
            this.mtxt_UserName.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxt_UserName.CustomButton.Name = "";
            this.mtxt_UserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_UserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_UserName.CustomButton.TabIndex = 1;
            this.mtxt_UserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_UserName.CustomButton.UseSelectable = true;
            this.mtxt_UserName.CustomButton.Visible = false;
            this.mtxt_UserName.Lines = new string[0];
            this.mtxt_UserName.Location = new System.Drawing.Point(23, 82);
            this.mtxt_UserName.MaxLength = 32767;
            this.mtxt_UserName.Name = "mtxt_UserName";
            this.mtxt_UserName.PasswordChar = '\0';
            this.mtxt_UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_UserName.SelectedText = "";
            this.mtxt_UserName.SelectionLength = 0;
            this.mtxt_UserName.SelectionStart = 0;
            this.mtxt_UserName.Size = new System.Drawing.Size(282, 23);
            this.mtxt_UserName.TabIndex = 1;
            this.mtxt_UserName.UseSelectable = true;
            this.mtxt_UserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_UserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_desc_ForeName
            // 
            this.mlbl_desc_ForeName.AutoSize = true;
            this.mlbl_desc_ForeName.Location = new System.Drawing.Point(23, 108);
            this.mlbl_desc_ForeName.Name = "mlbl_desc_ForeName";
            this.mlbl_desc_ForeName.Size = new System.Drawing.Size(72, 19);
            this.mlbl_desc_ForeName.TabIndex = 11;
            this.mlbl_desc_ForeName.Text = "Forename:";
            // 
            // mtxt_ForeName
            // 
            // 
            // 
            // 
            this.mtxt_ForeName.CustomButton.Image = null;
            this.mtxt_ForeName.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxt_ForeName.CustomButton.Name = "";
            this.mtxt_ForeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_ForeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_ForeName.CustomButton.TabIndex = 1;
            this.mtxt_ForeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_ForeName.CustomButton.UseSelectable = true;
            this.mtxt_ForeName.CustomButton.Visible = false;
            this.mtxt_ForeName.Lines = new string[0];
            this.mtxt_ForeName.Location = new System.Drawing.Point(23, 130);
            this.mtxt_ForeName.MaxLength = 32767;
            this.mtxt_ForeName.Name = "mtxt_ForeName";
            this.mtxt_ForeName.PasswordChar = '\0';
            this.mtxt_ForeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_ForeName.SelectedText = "";
            this.mtxt_ForeName.SelectionLength = 0;
            this.mtxt_ForeName.SelectionStart = 0;
            this.mtxt_ForeName.Size = new System.Drawing.Size(282, 23);
            this.mtxt_ForeName.TabIndex = 2;
            this.mtxt_ForeName.UseSelectable = true;
            this.mtxt_ForeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_ForeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_desc_SurName
            // 
            this.mlbl_desc_SurName.AutoSize = true;
            this.mlbl_desc_SurName.Location = new System.Drawing.Point(23, 156);
            this.mlbl_desc_SurName.Name = "mlbl_desc_SurName";
            this.mlbl_desc_SurName.Size = new System.Drawing.Size(64, 19);
            this.mlbl_desc_SurName.TabIndex = 13;
            this.mlbl_desc_SurName.Text = "Surname:";
            // 
            // mtxt_SurName
            // 
            // 
            // 
            // 
            this.mtxt_SurName.CustomButton.Image = null;
            this.mtxt_SurName.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxt_SurName.CustomButton.Name = "";
            this.mtxt_SurName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_SurName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_SurName.CustomButton.TabIndex = 1;
            this.mtxt_SurName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_SurName.CustomButton.UseSelectable = true;
            this.mtxt_SurName.CustomButton.Visible = false;
            this.mtxt_SurName.Lines = new string[0];
            this.mtxt_SurName.Location = new System.Drawing.Point(23, 178);
            this.mtxt_SurName.MaxLength = 32767;
            this.mtxt_SurName.Name = "mtxt_SurName";
            this.mtxt_SurName.PasswordChar = '\0';
            this.mtxt_SurName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_SurName.SelectedText = "";
            this.mtxt_SurName.SelectionLength = 0;
            this.mtxt_SurName.SelectionStart = 0;
            this.mtxt_SurName.Size = new System.Drawing.Size(282, 23);
            this.mtxt_SurName.TabIndex = 3;
            this.mtxt_SurName.UseSelectable = true;
            this.mtxt_SurName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_SurName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_desc_Email
            // 
            this.mlbl_desc_Email.AutoSize = true;
            this.mlbl_desc_Email.Location = new System.Drawing.Point(23, 204);
            this.mlbl_desc_Email.Name = "mlbl_desc_Email";
            this.mlbl_desc_Email.Size = new System.Drawing.Size(44, 19);
            this.mlbl_desc_Email.TabIndex = 15;
            this.mlbl_desc_Email.Text = "Email:";
            // 
            // mtxt_Email
            // 
            // 
            // 
            // 
            this.mtxt_Email.CustomButton.Image = null;
            this.mtxt_Email.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxt_Email.CustomButton.Name = "";
            this.mtxt_Email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Email.CustomButton.TabIndex = 1;
            this.mtxt_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Email.CustomButton.UseSelectable = true;
            this.mtxt_Email.CustomButton.Visible = false;
            this.mtxt_Email.Lines = new string[0];
            this.mtxt_Email.Location = new System.Drawing.Point(23, 226);
            this.mtxt_Email.MaxLength = 32767;
            this.mtxt_Email.Name = "mtxt_Email";
            this.mtxt_Email.PasswordChar = '\0';
            this.mtxt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Email.SelectedText = "";
            this.mtxt_Email.SelectionLength = 0;
            this.mtxt_Email.SelectionStart = 0;
            this.mtxt_Email.Size = new System.Drawing.Size(282, 23);
            this.mtxt_Email.TabIndex = 4;
            this.mtxt_Email.UseSelectable = true;
            this.mtxt_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mcmb_Company
            // 
            this.mcmb_Company.FormattingEnabled = true;
            this.mcmb_Company.ItemHeight = 23;
            this.mcmb_Company.Location = new System.Drawing.Point(23, 370);
            this.mcmb_Company.Name = "mcmb_Company";
            this.mcmb_Company.Size = new System.Drawing.Size(282, 29);
            this.mcmb_Company.TabIndex = 7;
            this.mcmb_Company.UseSelectable = true;
            // 
            // mlbl_desc_Company
            // 
            this.mlbl_desc_Company.AutoSize = true;
            this.mlbl_desc_Company.Location = new System.Drawing.Point(23, 348);
            this.mlbl_desc_Company.Name = "mlbl_desc_Company";
            this.mlbl_desc_Company.Size = new System.Drawing.Size(69, 19);
            this.mlbl_desc_Company.TabIndex = 17;
            this.mlbl_desc_Company.Text = "Company:";
            // 
            // mbtn_Cancel
            // 
            this.mbtn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtn_Cancel.Location = new System.Drawing.Point(119, 411);
            this.mbtn_Cancel.Name = "mbtn_Cancel";
            this.mbtn_Cancel.Size = new System.Drawing.Size(90, 23);
            this.mbtn_Cancel.TabIndex = 9;
            this.mbtn_Cancel.TabStop = false;
            this.mbtn_Cancel.Text = "Cancel";
            this.mbtn_Cancel.UseSelectable = true;
            this.mbtn_Cancel.Click += new System.EventHandler(this.mbtn_Cancel_Click);
            // 
            // mlbl_desc_RetypePassword
            // 
            this.mlbl_desc_RetypePassword.AutoSize = true;
            this.mlbl_desc_RetypePassword.Location = new System.Drawing.Point(23, 300);
            this.mlbl_desc_RetypePassword.Name = "mlbl_desc_RetypePassword";
            this.mlbl_desc_RetypePassword.Size = new System.Drawing.Size(111, 19);
            this.mlbl_desc_RetypePassword.TabIndex = 20;
            this.mlbl_desc_RetypePassword.Text = "Repeat Password:";
            // 
            // mtxt_RetypePassword
            // 
            // 
            // 
            // 
            this.mtxt_RetypePassword.CustomButton.Image = null;
            this.mtxt_RetypePassword.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxt_RetypePassword.CustomButton.Name = "";
            this.mtxt_RetypePassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_RetypePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_RetypePassword.CustomButton.TabIndex = 1;
            this.mtxt_RetypePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_RetypePassword.CustomButton.UseSelectable = true;
            this.mtxt_RetypePassword.CustomButton.Visible = false;
            this.mtxt_RetypePassword.Lines = new string[0];
            this.mtxt_RetypePassword.Location = new System.Drawing.Point(23, 322);
            this.mtxt_RetypePassword.MaxLength = 32767;
            this.mtxt_RetypePassword.Name = "mtxt_RetypePassword";
            this.mtxt_RetypePassword.PasswordChar = '●';
            this.mtxt_RetypePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_RetypePassword.SelectedText = "";
            this.mtxt_RetypePassword.SelectionLength = 0;
            this.mtxt_RetypePassword.SelectionStart = 0;
            this.mtxt_RetypePassword.Size = new System.Drawing.Size(282, 23);
            this.mtxt_RetypePassword.TabIndex = 6;
            this.mtxt_RetypePassword.UseSelectable = true;
            this.mtxt_RetypePassword.UseSystemPasswordChar = true;
            this.mtxt_RetypePassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_RetypePassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.mbtn_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = Resources.ic_launcher;
            this.BackImagePadding = new System.Windows.Forms.Padding(115, 12, 0, 0);
            this.BackMaxSize = 50;
            this.CancelButton = this.mbtn_Cancel;
            this.ClientSize = new System.Drawing.Size(320, 442);
            this.Controls.Add(this.mlbl_desc_RetypePassword);
            this.Controls.Add(this.mtxt_RetypePassword);
            this.Controls.Add(this.mbtn_Cancel);
            this.Controls.Add(this.mlbl_desc_Company);
            this.Controls.Add(this.mcmb_Company);
            this.Controls.Add(this.mlbl_desc_Email);
            this.Controls.Add(this.mtxt_Email);
            this.Controls.Add(this.mlbl_desc_SurName);
            this.Controls.Add(this.mtxt_SurName);
            this.Controls.Add(this.mlbl_desc_ForeName);
            this.Controls.Add(this.mtxt_ForeName);
            this.Controls.Add(this.mbtn_Register);
            this.Controls.Add(this.mlbl_desc_Password);
            this.Controls.Add(this.mtxt_Password);
            this.Controls.Add(this.mlbl_desc_UserName);
            this.Controls.Add(this.mtxt_UserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MetroFramework.Controls.MetroButton mbtn_Register;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Password;
        private MetroFramework.Controls.MetroTextBox mtxt_Password;
        private MetroFramework.Controls.MetroLabel mlbl_desc_UserName;
        private MetroFramework.Controls.MetroTextBox mtxt_UserName;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Company;
        private MetroFramework.Controls.MetroComboBox mcmb_Company;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Email;
        private MetroFramework.Controls.MetroTextBox mtxt_Email;
        private MetroFramework.Controls.MetroLabel mlbl_desc_SurName;
        private MetroFramework.Controls.MetroTextBox mtxt_SurName;
        private MetroFramework.Controls.MetroLabel mlbl_desc_ForeName;
        private MetroFramework.Controls.MetroTextBox mtxt_ForeName;
        private MetroFramework.Controls.MetroButton mbtn_Cancel;
        private MetroFramework.Controls.MetroLabel mlbl_desc_RetypePassword;
        private MetroFramework.Controls.MetroTextBox mtxt_RetypePassword;
    }
}