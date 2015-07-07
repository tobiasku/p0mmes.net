namespace pOmmes
{
    partial class RestaurantUserControl
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
            this.mtc_RestaurantList = new MetroFramework.Controls.MetroTabControl();
            this.mtp_RestaurantList = new MetroFramework.Controls.MetroTabPage();
            this.mtc_RestaurantList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtc_RestaurantList
            // 
            this.mtc_RestaurantList.Controls.Add(this.mtp_RestaurantList);
            this.mtc_RestaurantList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtc_RestaurantList.Location = new System.Drawing.Point(0, 0);
            this.mtc_RestaurantList.Name = "mtc_RestaurantList";
            this.mtc_RestaurantList.SelectedIndex = 0;
            this.mtc_RestaurantList.Size = new System.Drawing.Size(400, 600);
            this.mtc_RestaurantList.TabIndex = 0;
            this.mtc_RestaurantList.UseSelectable = true;
            // 
            // mtp_RestaurantList
            // 
            this.mtp_RestaurantList.HorizontalScrollbarBarColor = true;
            this.mtp_RestaurantList.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_RestaurantList.HorizontalScrollbarSize = 10;
            this.mtp_RestaurantList.Location = new System.Drawing.Point(4, 38);
            this.mtp_RestaurantList.Name = "mtp_RestaurantList";
            this.mtp_RestaurantList.Size = new System.Drawing.Size(392, 558);
            this.mtp_RestaurantList.TabIndex = 0;
            this.mtp_RestaurantList.Text = "Restaurants";
            this.mtp_RestaurantList.VerticalScrollbarBarColor = true;
            this.mtp_RestaurantList.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_RestaurantList.VerticalScrollbarSize = 10;
            // 
            // RestaurantUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mtc_RestaurantList);
            this.Name = "RestaurantUserControl";
            this.Size = new System.Drawing.Size(400, 600);
            this.Load += new System.EventHandler(this.RestaurantUserControl_Load);
            this.mtc_RestaurantList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtc_RestaurantList;
        private MetroFramework.Controls.MetroTabPage mtp_RestaurantList;
    }
}
