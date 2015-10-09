namespace pOmmes
{
    partial class FoodUserControl
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
            this.mtc_FoodList = new MetroFramework.Controls.MetroTabControl();
            this.mbtn_order = new MetroFramework.Controls.MetroButton();
            this.mlbl_Restaurant = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mtc_FoodList
            // 
            this.mtc_FoodList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtc_FoodList.Location = new System.Drawing.Point(0, 50);
            this.mtc_FoodList.Name = "mtc_FoodList";
            this.mtc_FoodList.Size = new System.Drawing.Size(400, 550);
            this.mtc_FoodList.TabIndex = 1;
            this.mtc_FoodList.UseSelectable = true;
            // 
            // mbtn_order
            // 
            this.mbtn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.mbtn_order.BackgroundImage = Resources.pOmmes_Resources.ic_shopping_cart_white_48dp;
            this.mbtn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtn_order.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtn_order.ForeColor = System.Drawing.Color.White;
            this.mbtn_order.Location = new System.Drawing.Point(319, 3);
            this.mbtn_order.Name = "mbtn_order";
            this.mbtn_order.Size = new System.Drawing.Size(78, 41);
            this.mbtn_order.TabIndex = 6;
            this.mbtn_order.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtn_order.UseCustomForeColor = true;
            this.mbtn_order.UseSelectable = true;
            this.mbtn_order.Visible = false;
            // 
            // mlbl_Restaurant
            // 
            this.mlbl_Restaurant.AutoSize = true;
            this.mlbl_Restaurant.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbl_Restaurant.Location = new System.Drawing.Point(3, 19);
            this.mlbl_Restaurant.Name = "mlbl_Restaurant";
            this.mlbl_Restaurant.Size = new System.Drawing.Size(150, 25);
            this.mlbl_Restaurant.TabIndex = 8;
            this.mlbl_Restaurant.Text = "Pizzeria Florentina";
            // 
            // FoodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mlbl_Restaurant);
            this.Controls.Add(this.mbtn_order);
            this.Controls.Add(this.mtc_FoodList);
            this.Name = "FoodUserControl";
            this.Size = new System.Drawing.Size(400, 600);
            this.Load += new System.EventHandler(this.FoodUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtc_FoodList;
        private MetroFramework.Controls.MetroButton mbtn_order;
        private MetroFramework.Controls.MetroLabel mlbl_Restaurant;
    }
}
