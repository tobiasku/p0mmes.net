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
            this.mpnl_priceInfo = new MetroFramework.Controls.MetroPanel();
            this.pic_shoppingcart = new System.Windows.Forms.PictureBox();
            this.mlbl_Price = new MetroFramework.Controls.MetroLabel();
            this.mlbl_description = new MetroFramework.Controls.MetroLabel();
            this.mlbl_name = new MetroFramework.Controls.MetroLabel();
            this.mpnl_main = new MetroFramework.Controls.MetroPanel();
            this.mpnl_hairline2 = new MetroFramework.Controls.MetroPanel();
            this.mpnl_priceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shoppingcart)).BeginInit();
            this.mpnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnl_priceInfo
            // 
            this.mpnl_priceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.mpnl_priceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpnl_priceInfo.Controls.Add(this.pic_shoppingcart);
            this.mpnl_priceInfo.Controls.Add(this.mlbl_Price);
            this.mpnl_priceInfo.HorizontalScrollbarBarColor = true;
            this.mpnl_priceInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_priceInfo.HorizontalScrollbarSize = 10;
            this.mpnl_priceInfo.Location = new System.Drawing.Point(347, 22);
            this.mpnl_priceInfo.Name = "mpnl_priceInfo";
            this.mpnl_priceInfo.Size = new System.Drawing.Size(42, 42);
            this.mpnl_priceInfo.TabIndex = 2;
            this.mpnl_priceInfo.UseCustomBackColor = true;
            this.mpnl_priceInfo.UseStyleColors = true;
            this.mpnl_priceInfo.VerticalScrollbarBarColor = true;
            this.mpnl_priceInfo.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_priceInfo.VerticalScrollbarSize = 10;
            this.mpnl_priceInfo.Click += new System.EventHandler(this.FoodListUserControl_Click);
            // 
            // pic_shoppingcart
            // 
            this.pic_shoppingcart.BackColor = System.Drawing.Color.Transparent;
            this.pic_shoppingcart.Image = global::pOmmes.Properties.Resources.ic_shopping_cart_white_48dp;
            this.pic_shoppingcart.Location = new System.Drawing.Point(0, 0);
            this.pic_shoppingcart.Name = "pic_shoppingcart";
            this.pic_shoppingcart.Size = new System.Drawing.Size(40, 40);
            this.pic_shoppingcart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_shoppingcart.TabIndex = 4;
            this.pic_shoppingcart.TabStop = false;
            this.pic_shoppingcart.Click += new System.EventHandler(this.FoodListUserControl_Click);
            // 
            // mlbl_Price
            // 
            this.mlbl_Price.AutoSize = true;
            this.mlbl_Price.BackColor = System.Drawing.Color.Transparent;
            this.mlbl_Price.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_Price.ForeColor = System.Drawing.Color.White;
            this.mlbl_Price.Location = new System.Drawing.Point(3, 11);
            this.mlbl_Price.Name = "mlbl_Price";
            this.mlbl_Price.Size = new System.Drawing.Size(0, 0);
            this.mlbl_Price.TabIndex = 3;
            this.mlbl_Price.UseCustomBackColor = true;
            this.mlbl_Price.UseCustomForeColor = true;
            this.mlbl_Price.Click += new System.EventHandler(this.FoodListUserControl_Click);
            // 
            // mlbl_description
            // 
            this.mlbl_description.BackColor = System.Drawing.Color.Transparent;
            this.mlbl_description.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlbl_description.Location = new System.Drawing.Point(0, 25);
            this.mlbl_description.Name = "mlbl_description";
            this.mlbl_description.Size = new System.Drawing.Size(273, 39);
            this.mlbl_description.TabIndex = 1;
            this.mlbl_description.UseCustomBackColor = true;
            // 
            // mlbl_name
            // 
            this.mlbl_name.AutoSize = true;
            this.mlbl_name.BackColor = System.Drawing.Color.Transparent;
            this.mlbl_name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbl_name.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_name.Location = new System.Drawing.Point(0, 0);
            this.mlbl_name.Name = "mlbl_name";
            this.mlbl_name.Size = new System.Drawing.Size(0, 0);
            this.mlbl_name.TabIndex = 0;
            this.mlbl_name.UseCustomBackColor = true;
            // 
            // mpnl_main
            // 
            this.mpnl_main.Controls.Add(this.mpnl_hairline2);
            this.mpnl_main.Controls.Add(this.mlbl_description);
            this.mpnl_main.Controls.Add(this.mpnl_priceInfo);
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
            // 
            // mpnl_hairline2
            // 
            this.mpnl_hairline2.BackColor = System.Drawing.Color.DarkGray;
            this.mpnl_hairline2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mpnl_hairline2.HorizontalScrollbarBarColor = true;
            this.mpnl_hairline2.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_hairline2.HorizontalScrollbarSize = 10;
            this.mpnl_hairline2.Location = new System.Drawing.Point(21, 69);
            this.mpnl_hairline2.Margin = new System.Windows.Forms.Padding(0);
            this.mpnl_hairline2.Name = "mpnl_hairline2";
            this.mpnl_hairline2.Size = new System.Drawing.Size(350, 1);
            this.mpnl_hairline2.Style = MetroFramework.MetroColorStyle.Silver;
            this.mpnl_hairline2.TabIndex = 7;
            this.mpnl_hairline2.UseCustomBackColor = true;
            this.mpnl_hairline2.VerticalScrollbarBarColor = true;
            this.mpnl_hairline2.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_hairline2.VerticalScrollbarSize = 10;
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
            this.mpnl_priceInfo.ResumeLayout(false);
            this.mpnl_priceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shoppingcart)).EndInit();
            this.mpnl_main.ResumeLayout(false);
            this.mpnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlbl_name;
        private MetroFramework.Controls.MetroLabel mlbl_description;
        private MetroFramework.Controls.MetroPanel mpnl_priceInfo;
        private MetroFramework.Controls.MetroLabel mlbl_Price;
        private System.Windows.Forms.PictureBox pic_shoppingcart;
        private MetroFramework.Controls.MetroPanel mpnl_main;
        private MetroFramework.Controls.MetroPanel mpnl_hairline2;
    }
}
