using pOmmes.Properties;

namespace pOmmes
{
    partial class LoginForm
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
            this.mtxt_UserName = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_desc_UserName = new MetroFramework.Controls.MetroLabel();
            this.mlbl_desc_Password = new MetroFramework.Controls.MetroLabel();
            this.mtxt_Password = new MetroFramework.Controls.MetroTextBox();
            this.mbtn_Login = new MetroFramework.Controls.MetroButton();
            this.mbtn_Cancel = new MetroFramework.Controls.MetroButton();
            this.mlink_Register = new MetroFramework.Controls.MetroLink();
            this.mlink_ForgotPassword = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mtxt_UserName
            // 
            this.mtxt_UserName.Lines = new string[0];
            this.mtxt_UserName.Location = new System.Drawing.Point(23, 82);
            this.mtxt_UserName.MaxLength = 32767;
            this.mtxt_UserName.Name = "mtxt_UserName";
            this.mtxt_UserName.PasswordChar = '\0';
            this.mtxt_UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_UserName.SelectedText = "";
            this.mtxt_UserName.Size = new System.Drawing.Size(282, 23);
            this.mtxt_UserName.TabIndex = 1;
            this.mtxt_UserName.UseSelectable = true;
            // 
            // mlbl_desc_UserName
            // 
            this.mlbl_desc_UserName.AutoSize = true;
            this.mlbl_desc_UserName.Location = new System.Drawing.Point(23, 60);
            this.mlbl_desc_UserName.Name = "mlbl_desc_UserName";
            this.mlbl_desc_UserName.Size = new System.Drawing.Size(71, 19);
            this.mlbl_desc_UserName.TabIndex = 1;
            this.mlbl_desc_UserName.Text = "Username:";
            // 
            // mlbl_desc_Password
            // 
            this.mlbl_desc_Password.AutoSize = true;
            this.mlbl_desc_Password.Location = new System.Drawing.Point(23, 108);
            this.mlbl_desc_Password.Name = "mlbl_desc_Password";
            this.mlbl_desc_Password.Size = new System.Drawing.Size(67, 19);
            this.mlbl_desc_Password.TabIndex = 3;
            this.mlbl_desc_Password.Text = "Password:";
            // 
            // mtxt_Password
            // 
            this.mtxt_Password.Lines = new string[0];
            this.mtxt_Password.Location = new System.Drawing.Point(23, 130);
            this.mtxt_Password.MaxLength = 32767;
            this.mtxt_Password.Name = "mtxt_Password";
            this.mtxt_Password.PasswordChar = '\0';
            this.mtxt_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Password.SelectedText = "";
            this.mtxt_Password.Size = new System.Drawing.Size(282, 23);
            this.mtxt_Password.TabIndex = 2;
            this.mtxt_Password.UseSelectable = true;
            // 
            // mbtn_Login
            // 
            this.mbtn_Login.Location = new System.Drawing.Point(215, 159);
            this.mbtn_Login.Name = "mbtn_Login";
            this.mbtn_Login.Size = new System.Drawing.Size(90, 29);
            this.mbtn_Login.TabIndex = 3;
            this.mbtn_Login.Text = "Login";
            this.mbtn_Login.UseSelectable = true;
            this.mbtn_Login.Click += new System.EventHandler(this.mbtn_Login_Click);
            // 
            // mbtn_Cancel
            // 
            this.mbtn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtn_Cancel.Location = new System.Drawing.Point(134, 165);
            this.mbtn_Cancel.Name = "mbtn_Cancel";
            this.mbtn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.mbtn_Cancel.TabIndex = 4;
            this.mbtn_Cancel.TabStop = false;
            this.mbtn_Cancel.Text = "Cancel";
            this.mbtn_Cancel.UseSelectable = true;
            this.mbtn_Cancel.Click += new System.EventHandler(this.mbtn_Cancel_Click);
            // 
            // mlink_Register
            // 
            this.mlink_Register.Location = new System.Drawing.Point(23, 232);
            this.mlink_Register.Name = "mlink_Register";
            this.mlink_Register.Size = new System.Drawing.Size(282, 23);
            this.mlink_Register.TabIndex = 4;
            this.mlink_Register.TabStop = false;
            this.mlink_Register.Text = "No Account? Register here!";
            this.mlink_Register.UseSelectable = true;
            this.mlink_Register.Click += new System.EventHandler(this.mlink_Register_Click);
            // 
            // mlink_ForgotPassword
            // 
            this.mlink_ForgotPassword.Location = new System.Drawing.Point(23, 203);
            this.mlink_ForgotPassword.Name = "mlink_ForgotPassword";
            this.mlink_ForgotPassword.Size = new System.Drawing.Size(282, 23);
            this.mlink_ForgotPassword.TabIndex = 4;
            this.mlink_ForgotPassword.TabStop = false;
            this.mlink_ForgotPassword.Text = "Forgot Password?";
            this.mlink_ForgotPassword.UseSelectable = true;
            this.mlink_ForgotPassword.Click += new System.EventHandler(this.mlink_ForgotPassword_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.mbtn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = Resources.ic_launcher;
            this.BackImagePadding = new System.Windows.Forms.Padding(90, 12, 0, 0);
            this.BackMaxSize = 50;
            this.CancelButton = this.mbtn_Cancel;
            this.ClientSize = new System.Drawing.Size(320, 278);
            this.Controls.Add(this.mlink_ForgotPassword);
            this.Controls.Add(this.mlink_Register);
            this.Controls.Add(this.mbtn_Cancel);
            this.Controls.Add(this.mbtn_Login);
            this.Controls.Add(this.mlbl_desc_Password);
            this.Controls.Add(this.mtxt_Password);
            this.Controls.Add(this.mlbl_desc_UserName);
            this.Controls.Add(this.mtxt_UserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MetroFramework.Controls.MetroButton mbtn_Login;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Password;
        private MetroFramework.Controls.MetroTextBox mtxt_Password;
        private MetroFramework.Controls.MetroLabel mlbl_desc_UserName;
        private MetroFramework.Controls.MetroTextBox mtxt_UserName;
        private MetroFramework.Controls.MetroLink mlink_ForgotPassword;
        private MetroFramework.Controls.MetroLink mlink_Register;
        private MetroFramework.Controls.MetroButton mbtn_Cancel;
    }
}