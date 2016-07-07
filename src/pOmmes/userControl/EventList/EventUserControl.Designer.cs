namespace pOmmes
{
    partial class EventUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtc_EventList = new MetroFramework.Controls.MetroTabControl();
            this.mtp_EventList = new MetroFramework.Controls.MetroTabPage();
            this.mpnl_refreshButton = new MetroFramework.Controls.MetroPanel();
            this.mps_spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.mtc_EventList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtc_EventList
            // 
            this.mtc_EventList.Controls.Add(this.mtp_EventList);
            this.mtc_EventList.Location = new System.Drawing.Point(0, 0);
            this.mtc_EventList.Name = "mtc_EventList";
            this.mtc_EventList.SelectedIndex = 0;
            this.mtc_EventList.Size = new System.Drawing.Size(400, 600);
            this.mtc_EventList.TabIndex = 1;
            this.mtc_EventList.UseSelectable = true;
            // 
            // mtp_EventList
            // 
            this.mtp_EventList.HorizontalScrollbarBarColor = true;
            this.mtp_EventList.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_EventList.HorizontalScrollbarSize = 10;
            this.mtp_EventList.Location = new System.Drawing.Point(4, 38);
            this.mtp_EventList.Name = "mtp_EventList";
            this.mtp_EventList.Size = new System.Drawing.Size(392, 558);
            this.mtp_EventList.TabIndex = 0;
            this.mtp_EventList.Text = "Events";
            this.mtp_EventList.VerticalScrollbarBarColor = true;
            this.mtp_EventList.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_EventList.VerticalScrollbarSize = 10;
            // 
            // mpnl_refreshButton
            // 
            this.mpnl_refreshButton.BackgroundImage = global::pOmmes.Properties.Resources.ic_autorenew_black_48dp;
            this.mpnl_refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mpnl_refreshButton.HorizontalScrollbarBarColor = true;
            this.mpnl_refreshButton.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_refreshButton.HorizontalScrollbarSize = 10;
            this.mpnl_refreshButton.Location = new System.Drawing.Point(369, 7);
            this.mpnl_refreshButton.Name = "mpnl_refreshButton";
            this.mpnl_refreshButton.Size = new System.Drawing.Size(27, 27);
            this.mpnl_refreshButton.TabIndex = 2;
            this.mpnl_refreshButton.VerticalScrollbarBarColor = true;
            this.mpnl_refreshButton.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_refreshButton.VerticalScrollbarSize = 10;
            this.mpnl_refreshButton.Click += new System.EventHandler(this.mPnl_Main_Click);
            // 
            // mps_spinner
            // 
            this.mps_spinner.Location = new System.Drawing.Point(170, 270);
            this.mps_spinner.Maximum = 100;
            this.mps_spinner.Name = "mps_spinner";
            this.mps_spinner.Size = new System.Drawing.Size(60, 60);
            this.mps_spinner.TabIndex = 2;
            this.mps_spinner.UseSelectable = true;
            this.mps_spinner.Value = 25;
            // 
            // EventUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mps_spinner);
            this.Controls.Add(this.mpnl_refreshButton);
            this.Controls.Add(this.mtc_EventList);
            this.Name = "EventUserControl";
            this.Size = new System.Drawing.Size(400, 600);
            this.Load += new System.EventHandler(this.EventUserControl_Load);
            this.mtc_EventList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtc_EventList;
        private MetroFramework.Controls.MetroTabPage mtp_EventList;
        private MetroFramework.Controls.MetroPanel mpnl_refreshButton;
        private MetroFramework.Controls.MetroProgressSpinner mps_spinner;
    }
}
