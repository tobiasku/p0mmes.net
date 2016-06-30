namespace pOmmes
{
    partial class EventListUserControl
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
            this.mlbl_name = new MetroFramework.Controls.MetroLabel();
            this.mpnl_main = new MetroFramework.Controls.MetroPanel();
            this.mpnl_hairline = new MetroFramework.Controls.MetroPanel();
            this.mlbl_restaurant = new MetroFramework.Controls.MetroLabel();
            this.mlbl_description = new MetroFramework.Controls.MetroLabel();
            this.pic_state = new System.Windows.Forms.PictureBox();
            this.mpnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_state)).BeginInit();
            this.SuspendLayout();
            // 
            // mlbl_name
            // 
            this.mlbl_name.AutoSize = true;
            this.mlbl_name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbl_name.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbl_name.Location = new System.Drawing.Point(69, 3);
            this.mlbl_name.Name = "mlbl_name";
            this.mlbl_name.Size = new System.Drawing.Size(0, 0);
            this.mlbl_name.TabIndex = 0;
            this.mlbl_name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventListUserControl_MouseUp);
            // 
            // mpnl_main
            // 
            this.mpnl_main.BackColor = System.Drawing.Color.DarkOrange;
            this.mpnl_main.Controls.Add(this.mpnl_hairline);
            this.mpnl_main.Controls.Add(this.mlbl_name);
            this.mpnl_main.Controls.Add(this.mlbl_restaurant);
            this.mpnl_main.Controls.Add(this.mlbl_description);
            this.mpnl_main.Controls.Add(this.pic_state);
            this.mpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_main.HorizontalScrollbarBarColor = true;
            this.mpnl_main.HorizontalScrollbarHighlightOnWheel = true;
            this.mpnl_main.HorizontalScrollbarSize = 10;
            this.mpnl_main.Location = new System.Drawing.Point(0, 0);
            this.mpnl_main.Name = "mpnl_main";
            this.mpnl_main.Size = new System.Drawing.Size(392, 90);
            this.mpnl_main.TabIndex = 1;
            this.mpnl_main.VerticalScrollbarBarColor = false;
            this.mpnl_main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_main.VerticalScrollbarSize = 10;
            this.mpnl_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventListUserControl_MouseUp);
            // 
            // mpnl_hairline
            // 
            this.mpnl_hairline.BackColor = System.Drawing.Color.DarkGray;
            this.mpnl_hairline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mpnl_hairline.HorizontalScrollbarBarColor = true;
            this.mpnl_hairline.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_hairline.HorizontalScrollbarSize = 10;
            this.mpnl_hairline.Location = new System.Drawing.Point(25, 86);
            this.mpnl_hairline.Margin = new System.Windows.Forms.Padding(0);
            this.mpnl_hairline.Name = "mpnl_hairline";
            this.mpnl_hairline.Size = new System.Drawing.Size(350, 1);
            this.mpnl_hairline.TabIndex = 6;
            this.mpnl_hairline.UseCustomBackColor = true;
            this.mpnl_hairline.VerticalScrollbarBarColor = true;
            this.mpnl_hairline.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_hairline.VerticalScrollbarSize = 10;
            this.mpnl_hairline.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventListUserControl_MouseUp);
            // 
            // mlbl_restaurant
            // 
            this.mlbl_restaurant.AutoSize = true;
            this.mlbl_restaurant.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbl_restaurant.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_restaurant.Location = new System.Drawing.Point(69, 36);
            this.mlbl_restaurant.Name = "mlbl_restaurant";
            this.mlbl_restaurant.Size = new System.Drawing.Size(0, 0);
            this.mlbl_restaurant.TabIndex = 5;
            this.mlbl_restaurant.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventListUserControl_MouseUp);
            // 
            // mlbl_description
            // 
            this.mlbl_description.AutoSize = true;
            this.mlbl_description.Location = new System.Drawing.Point(25, 67);
            this.mlbl_description.Name = "mlbl_description";
            this.mlbl_description.Size = new System.Drawing.Size(0, 0);
            this.mlbl_description.TabIndex = 3;
            this.mlbl_description.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventListUserControl_MouseUp);
            // 
            // pic_state
            // 
            this.pic_state.BackColor = System.Drawing.Color.Transparent;
            this.pic_state.Location = new System.Drawing.Point(25, 15);
            this.pic_state.Name = "pic_state";
            this.pic_state.Size = new System.Drawing.Size(36, 36);
            this.pic_state.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_state.TabIndex = 2;
            this.pic_state.TabStop = false;
            this.pic_state.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventListUserControl_MouseUp);
            // 
            // EventListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mpnl_main);
            this.Name = "EventListUserControl";
            this.Size = new System.Drawing.Size(392, 90);
            this.Load += new System.EventHandler(this.EventListUserControl_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EventListUserControl_MouseUp);
            this.mpnl_main.ResumeLayout(false);
            this.mpnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_state)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private MetroFramework.Controls.MetroLabel mlbl_name;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private System.Windows.Forms.PictureBox pic_state;
        private MetroFramework.Controls.MetroLabel mlbl_restaurant;
        private MetroFramework.Controls.MetroLabel mlbl_description;
        private MetroFramework.Controls.MetroPanel mpnl_hairline;
    }
}
