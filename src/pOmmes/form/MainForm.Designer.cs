namespace pOmmes
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mlink_CurrentUser = new MetroFramework.Controls.MetroLink();
            this.mtbc_Main = new MetroFramework.Controls.MetroTabControl();
            this.mtp_Event = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.mtbc_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Silver;
            // 
            // mlink_CurrentUser
            // 
            this.mlink_CurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlink_CurrentUser.AutoSize = true;
            this.mlink_CurrentUser.Location = new System.Drawing.Point(487, 26);
            this.mlink_CurrentUser.Name = "mlink_CurrentUser";
            this.mlink_CurrentUser.Size = new System.Drawing.Size(40, 23);
            this.mlink_CurrentUser.TabIndex = 0;
            this.mlink_CurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlink_CurrentUser.UseSelectable = true;
            this.mlink_CurrentUser.Click += new System.EventHandler(this.mlink_CurrentUser_Click);
            this.mlink_CurrentUser.MouseEnter += new System.EventHandler(this.mlink_CurrentUser_MouseEnter);
            this.mlink_CurrentUser.MouseLeave += new System.EventHandler(this.mlink_CurrentUser_MouseLeave);
            // 
            // mtbc_Main
            // 
            this.mtbc_Main.Controls.Add(this.mtp_Event);
            this.mtbc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbc_Main.Location = new System.Drawing.Point(20, 60);
            this.mtbc_Main.Name = "mtbc_Main";
            this.mtbc_Main.SelectedIndex = 0;
            this.mtbc_Main.Size = new System.Drawing.Size(510, 283);
            this.mtbc_Main.TabIndex = 1;
            this.mtbc_Main.UseSelectable = true;
            // 
            // mtp_Event
            // 
            this.mtp_Event.Location = new System.Drawing.Point(4, 38);
            this.mtp_Event.Name = "mtp_Event";
            this.mtp_Event.Size = new System.Drawing.Size(502, 241);
            this.mtp_Event.TabIndex = 0;
            this.mtp_Event.Text = "Events";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::pOmmes.Properties.Resources.ic_launcher;
            this.BackImagePadding = new System.Windows.Forms.Padding(130, 12, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(550, 363);
            this.Controls.Add(this.mtbc_Main);
            this.Controls.Add(this.mlink_CurrentUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.StyleManager = this.metroStyleManager;
            this.Text = "pOmmes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mtbc_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroLink mlink_CurrentUser;
        private MetroFramework.Controls.MetroTabControl mtbc_Main;
        private System.Windows.Forms.TabPage mtp_Event;
    }
}

