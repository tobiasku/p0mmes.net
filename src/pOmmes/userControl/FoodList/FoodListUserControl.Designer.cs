namespace pOmmes
{
    partial class FoodListUserControl
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
            this.mlbl_description = new MetroFramework.Controls.MetroLabel();
            this.mlbl_name = new MetroFramework.Controls.MetroLabel();
            this.mpnl_main = new MetroFramework.Controls.MetroPanel();
            this.mlbl_price = new MetroFramework.Controls.MetroLabel();
            this.mpnl_hairline2 = new MetroFramework.Controls.MetroPanel();
            this.mpnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlbl_description
            // 
            this.mlbl_description.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlbl_description.Location = new System.Drawing.Point(0, 25);
            this.mlbl_description.Name = "mlbl_description";
            this.mlbl_description.Size = new System.Drawing.Size(273, 39);
            this.mlbl_description.TabIndex = 1;
            this.mlbl_description.Click += new System.EventHandler(this.FoodListUserControl_Click);
            // 
            // mlbl_name
            // 
            this.mlbl_name.AutoSize = true;
            this.mlbl_name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbl_name.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_name.Location = new System.Drawing.Point(0, 0);
            this.mlbl_name.Name = "mlbl_name";
            this.mlbl_name.Size = new System.Drawing.Size(0, 0);
            this.mlbl_name.TabIndex = 0;
            this.mlbl_name.Click += new System.EventHandler(this.FoodListUserControl_Click);
            // 
            // mpnl_main
            // 
            this.mpnl_main.Controls.Add(this.mlbl_price);
            this.mpnl_main.Controls.Add(this.mpnl_hairline2);
            this.mpnl_main.Controls.Add(this.mlbl_description);
            this.mpnl_main.Controls.Add(this.mlbl_name);
            this.mpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_main.HorizontalScrollbarBarColor = true;
            this.mpnl_main.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_main.HorizontalScrollbarSize = 10;
            this.mpnl_main.Location = new System.Drawing.Point(0, 0);
            this.mpnl_main.Name = "mpnl_main";
            this.mpnl_main.Size = new System.Drawing.Size(392, 72);
            this.mpnl_main.TabIndex = 3;
            this.mpnl_main.VerticalScrollbarBarColor = true;
            this.mpnl_main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_main.VerticalScrollbarSize = 10;
            this.mpnl_main.Click += new System.EventHandler(this.FoodListUserControl_Click);
            // 
            // mlbl_price
            // 
            this.mlbl_price.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlbl_price.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_price.Location = new System.Drawing.Point(279, 39);
            this.mlbl_price.Name = "mlbl_price";
            this.mlbl_price.Size = new System.Drawing.Size(110, 25);
            this.mlbl_price.TabIndex = 8;
            this.mlbl_price.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.mlbl_price.Click += new System.EventHandler(this.FoodListUserControl_Click);
            // 
            // mpnl_hairline2
            // 
            this.mpnl_hairline2.BackColor = System.Drawing.Color.DarkGray;
            this.mpnl_hairline2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mpnl_hairline2.Location = new System.Drawing.Point(21, 69);
            this.mpnl_hairline2.Margin = new System.Windows.Forms.Padding(0);
            this.mpnl_hairline2.Name = "mpnl_hairline2";
            this.mpnl_hairline2.Size = new System.Drawing.Size(350, 1);
            this.mpnl_hairline2.TabIndex = 7;
            this.mpnl_hairline2.Click += new System.EventHandler(this.FoodListUserControl_Click);
            // 
            // FoodListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mpnl_main);
            this.Name = "FoodListUserControl";
            this.Size = new System.Drawing.Size(392, 72);
            this.Load += new System.EventHandler(this.FoodListUserControl_Load);
            this.Click += new System.EventHandler(this.FoodListUserControl_Click);
            this.mpnl_main.ResumeLayout(false);
            this.mpnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlbl_name;
        private MetroFramework.Controls.MetroLabel mlbl_description;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private MetroFramework.Controls.MetroPanel mpnl_hairline2;
        private MetroFramework.Controls.MetroLabel mlbl_price;
    }
}
