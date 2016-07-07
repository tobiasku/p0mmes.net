namespace pOmmes
{
    partial class ResetPasswordForm
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
            this.mlbl_desc_Email = new MetroFramework.Controls.MetroLabel();
            this.mtxt_Email = new MetroFramework.Controls.MetroTextBox();
            this.mbtn_Cancel = new MetroFramework.Controls.MetroButton();
            this.mbtn_ResetPassword = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mlbl_desc_Email
            // 
            this.mlbl_desc_Email.AutoSize = true;
            this.mlbl_desc_Email.Location = new System.Drawing.Point(23, 60);
            this.mlbl_desc_Email.Name = "mlbl_desc_Email";
            this.mlbl_desc_Email.Size = new System.Drawing.Size(44, 19);
            this.mlbl_desc_Email.TabIndex = 3;
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
            this.mtxt_Email.Location = new System.Drawing.Point(23, 82);
            this.mtxt_Email.MaxLength = 32767;
            this.mtxt_Email.Name = "mtxt_Email";
            this.mtxt_Email.PasswordChar = '\0';
            this.mtxt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Email.SelectedText = "";
            this.mtxt_Email.SelectionLength = 0;
            this.mtxt_Email.SelectionStart = 0;
            this.mtxt_Email.Size = new System.Drawing.Size(282, 23);
            this.mtxt_Email.TabIndex = 1;
            this.mtxt_Email.UseSelectable = true;
            this.mtxt_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtn_Cancel
            // 
            this.mbtn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtn_Cancel.Location = new System.Drawing.Point(134, 117);
            this.mbtn_Cancel.Name = "mbtn_Cancel";
            this.mbtn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.mbtn_Cancel.TabIndex = 3;
            this.mbtn_Cancel.TabStop = false;
            this.mbtn_Cancel.Text = "Cancel";
            this.mbtn_Cancel.UseSelectable = true;
            this.mbtn_Cancel.Click += new System.EventHandler(this.mbtn_Cancel_Click);
            // 
            // mbtn_ResetPassword
            // 
            this.mbtn_ResetPassword.Location = new System.Drawing.Point(215, 111);
            this.mbtn_ResetPassword.Name = "mbtn_ResetPassword";
            this.mbtn_ResetPassword.Size = new System.Drawing.Size(90, 29);
            this.mbtn_ResetPassword.TabIndex = 2;
            this.mbtn_ResetPassword.Text = "Reset";
            this.mbtn_ResetPassword.UseSelectable = true;
            this.mbtn_ResetPassword.Click += new System.EventHandler(this.mbtn_ResetPassword_Click);
            // 
            // ResetPasswordForm
            // 
            this.AcceptButton = this.mbtn_ResetPassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::pOmmes.Resources.pOmmes_Resources.ic_launcher;
            this.BackImagePadding = new System.Windows.Forms.Padding(190, 12, 0, 0);
            this.BackMaxSize = 50;
            this.CancelButton = this.mbtn_Cancel;
            this.ClientSize = new System.Drawing.Size(320, 153);
            this.Controls.Add(this.mbtn_Cancel);
            this.Controls.Add(this.mbtn_ResetPassword);
            this.Controls.Add(this.mlbl_desc_Email);
            this.Controls.Add(this.mtxt_Email);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPasswordForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MetroFramework.Controls.MetroLabel mlbl_desc_Email;
        private MetroFramework.Controls.MetroTextBox mtxt_Email;
        private MetroFramework.Controls.MetroButton mbtn_Cancel;
        private MetroFramework.Controls.MetroButton mbtn_ResetPassword;
    }
}