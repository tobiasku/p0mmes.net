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
            this.mlink_CurrentUser = new MetroFramework.Controls.MetroLink();
            this.mpnl_Main = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mlink_CurrentUser
            // 
            this.mlink_CurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlink_CurrentUser.AutoSize = true;
            this.mlink_CurrentUser.Location = new System.Drawing.Point(188, 26);
            this.mlink_CurrentUser.Name = "mlink_CurrentUser";
            this.mlink_CurrentUser.Size = new System.Drawing.Size(229, 23);
            this.mlink_CurrentUser.TabIndex = 0;
            this.mlink_CurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlink_CurrentUser.UseSelectable = true;
            this.mlink_CurrentUser.Click += new System.EventHandler(this.mlink_CurrentUser_Click);
            this.mlink_CurrentUser.MouseEnter += new System.EventHandler(this.mlink_CurrentUser_MouseEnter);
            this.mlink_CurrentUser.MouseLeave += new System.EventHandler(this.mlink_CurrentUser_MouseLeave);
            // 
            // mpnl_Main
            // 
            this.mpnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_Main.HorizontalScrollbarBarColor = true;
            this.mpnl_Main.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_Main.HorizontalScrollbarSize = 10;
            this.mpnl_Main.Location = new System.Drawing.Point(20, 60);
            this.mpnl_Main.Name = "mpnl_Main";
            this.mpnl_Main.Size = new System.Drawing.Size(400, 600);
            this.mpnl_Main.TabIndex = 1;
            this.mpnl_Main.VerticalScrollbarBarColor = true;
            this.mpnl_Main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_Main.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::pOmmes.Resources.pOmmes_Resources.ic_launcher;
            this.BackImagePadding = new System.Windows.Forms.Padding(131, 11, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(440, 680);
            this.Controls.Add(this.mpnl_Main);
            this.Controls.Add(this.mlink_CurrentUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "pOmmes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MetroFramework.Controls.MetroLink mlink_CurrentUser;
        private MetroFramework.Controls.MetroPanel mpnl_Main;
    }
}

