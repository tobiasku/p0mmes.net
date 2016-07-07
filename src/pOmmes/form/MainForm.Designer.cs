using pOmmes.Properties;

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
            this.mpnlSpaceholder = new MetroFramework.Controls.MetroPanel();
            this.mpnlControls = new MetroFramework.Controls.MetroPanel();
            this.mpnlHome = new MetroFramework.Controls.MetroPanel();
            this.mpnlReturn = new MetroFramework.Controls.MetroPanel();
            this.mpnlMenu = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mpnlControls.SuspendLayout();
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
            this.mpnl_Main.Dock = System.Windows.Forms.DockStyle.Top;
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
            // mpnlSpaceholder
            // 
            this.mpnlSpaceholder.BackgroundImage = global::pOmmes.Properties.Resources.ic_more_horiz_black_48dp;
            this.mpnlSpaceholder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mpnlSpaceholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnlSpaceholder.HorizontalScrollbarBarColor = true;
            this.mpnlSpaceholder.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlSpaceholder.HorizontalScrollbarSize = 10;
            this.mpnlSpaceholder.Location = new System.Drawing.Point(20, 660);
            this.mpnlSpaceholder.Name = "mpnlSpaceholder";
            this.mpnlSpaceholder.Size = new System.Drawing.Size(400, 10);
            this.mpnlSpaceholder.TabIndex = 2;
            this.mpnlSpaceholder.VerticalScrollbarBarColor = true;
            this.mpnlSpaceholder.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlSpaceholder.VerticalScrollbarSize = 10;
            // 
            // mpnlControls
            // 
            this.mpnlControls.Controls.Add(this.mpnlHome);
            this.mpnlControls.Controls.Add(this.mpnlReturn);
            this.mpnlControls.Controls.Add(this.mpnlMenu);
            this.mpnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpnlControls.HorizontalScrollbarBarColor = true;
            this.mpnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlControls.HorizontalScrollbarSize = 10;
            this.mpnlControls.Location = new System.Drawing.Point(20, 670);
            this.mpnlControls.Name = "mpnlControls";
            this.mpnlControls.Size = new System.Drawing.Size(400, 50);
            this.mpnlControls.TabIndex = 6;
            this.mpnlControls.VerticalScrollbarBarColor = true;
            this.mpnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlControls.VerticalScrollbarSize = 10;
            // 
            // mpnlHome
            // 
            this.mpnlHome.BackColor = System.Drawing.Color.Transparent;
            this.mpnlHome.BackgroundImage = global::pOmmes.Properties.Resources.ic_home_black_48dp;
            this.mpnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mpnlHome.HorizontalScrollbarBarColor = true;
            this.mpnlHome.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlHome.HorizontalScrollbarSize = 10;
            this.mpnlHome.Location = new System.Drawing.Point(135, 3);
            this.mpnlHome.Name = "mpnlHome";
            this.mpnlHome.Size = new System.Drawing.Size(130, 44);
            this.mpnlHome.TabIndex = 7;
            this.mpnlHome.VerticalScrollbarBarColor = true;
            this.mpnlHome.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlHome.VerticalScrollbarSize = 10;
            this.mpnlHome.Click += new System.EventHandler(this.mpnlHome_Click_1);
            // 
            // mpnlReturn
            // 
            this.mpnlReturn.BackColor = System.Drawing.Color.Transparent;
            this.mpnlReturn.BackgroundImage = global::pOmmes.Properties.Resources.ic_keyboard_return_black_48dp;
            this.mpnlReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mpnlReturn.HorizontalScrollbarBarColor = true;
            this.mpnlReturn.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlReturn.HorizontalScrollbarSize = 10;
            this.mpnlReturn.Location = new System.Drawing.Point(270, 3);
            this.mpnlReturn.Name = "mpnlReturn";
            this.mpnlReturn.Size = new System.Drawing.Size(130, 44);
            this.mpnlReturn.TabIndex = 6;
            this.mpnlReturn.VerticalScrollbarBarColor = true;
            this.mpnlReturn.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlReturn.VerticalScrollbarSize = 10;
            this.mpnlReturn.Click += new System.EventHandler(this.mpnlReturn_Click);
            // 
            // mpnlMenu
            // 
            this.mpnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.mpnlMenu.BackgroundImage = global::pOmmes.Properties.Resources.ic_menu_black_48dp;
            this.mpnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mpnlMenu.HorizontalScrollbarBarColor = true;
            this.mpnlMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlMenu.HorizontalScrollbarSize = 10;
            this.mpnlMenu.Location = new System.Drawing.Point(0, 3);
            this.mpnlMenu.Name = "mpnlMenu";
            this.mpnlMenu.Size = new System.Drawing.Size(130, 44);
            this.mpnlMenu.TabIndex = 5;
            this.mpnlMenu.VerticalScrollbarBarColor = true;
            this.mpnlMenu.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlMenu.VerticalScrollbarSize = 10;
            this.mpnlMenu.Click += new System.EventHandler(this.mpnlMenu_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 570);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(441, 153);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.MouseHover += new System.EventHandler(this.metroPanel1_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::pOmmes.Properties.Resources.ic_launcher;
            this.BackImagePadding = new System.Windows.Forms.Padding(131, 11, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(440, 723);
            this.Controls.Add(this.mpnlControls);
            this.Controls.Add(this.mpnlSpaceholder);
            this.Controls.Add(this.mpnl_Main);
            this.Controls.Add(this.mlink_CurrentUser);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "pOmmes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mpnlControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MetroFramework.Controls.MetroLink mlink_CurrentUser;
        private MetroFramework.Controls.MetroPanel mpnl_Main;
        private MetroFramework.Controls.MetroPanel mpnlSpaceholder;
        private MetroFramework.Controls.MetroPanel mpnlControls;
        private MetroFramework.Controls.MetroPanel mpnlHome;
        private MetroFramework.Controls.MetroPanel mpnlReturn;
        private MetroFramework.Controls.MetroPanel mpnlMenu;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

