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
            this.mtc_EventList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtc_EventList
            // 
            this.mtc_EventList.Controls.Add(this.mtp_EventList);
            this.mtc_EventList.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // EventUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
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
    }
}
