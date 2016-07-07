using pOmmes.Properties;

namespace pOmmes
{
    partial class FoodBasketUserControl
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
            this.mbtn_order = new MetroFramework.Controls.MetroButton();
            this.mlink_Close = new MetroFramework.Controls.MetroLink();
            this.mpnl_Main = new MetroFramework.Controls.MetroPanel();
            this.mpnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbtn_order
            // 
            this.mbtn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.mbtn_order.BackgroundImage = Resources.ic_shopping_cart_white_48dp;
            this.mbtn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtn_order.Location = new System.Drawing.Point(180, 334);
            this.mbtn_order.Name = "mbtn_order";
            this.mbtn_order.Size = new System.Drawing.Size(96, 41);
            this.mbtn_order.TabIndex = 5;
            this.mbtn_order.UseSelectable = true;
            this.mbtn_order.Click += new System.EventHandler(this.mbtn_order_Click);
            // 
            // mlink_Close
            // 
            this.mlink_Close.Location = new System.Drawing.Point(250, 2);
            this.mlink_Close.Name = "mlink_Close";
            this.mlink_Close.Size = new System.Drawing.Size(25, 23);
            this.mlink_Close.TabIndex = 9;
            this.mlink_Close.Text = "X";
            this.mlink_Close.UseSelectable = true;
            this.mlink_Close.Click += new System.EventHandler(this.mlink_Close_Click);
            // 
            // mpnl_Main
            // 
            this.mpnl_Main.BackColor = System.Drawing.Color.Black;
            this.mpnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpnl_Main.Controls.Add(this.mlink_Close);
            this.mpnl_Main.Controls.Add(this.mbtn_order);
            this.mpnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpnl_Main.HorizontalScrollbarBarColor = true;
            this.mpnl_Main.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_Main.HorizontalScrollbarSize = 10;
            this.mpnl_Main.Location = new System.Drawing.Point(0, 0);
            this.mpnl_Main.Name = "mpnl_Main";
            this.mpnl_Main.Size = new System.Drawing.Size(280, 380);
            this.mpnl_Main.TabIndex = 0;
            this.mpnl_Main.VerticalScrollbarBarColor = true;
            this.mpnl_Main.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_Main.VerticalScrollbarSize = 10;
            // 
            // FoodBasketUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_Main);
            this.Name = "FoodBasketUserControl";
            this.Size = new System.Drawing.Size(280, 380);
            this.Load += new System.EventHandler(this.FoodBasketUserControl_Load);
            this.mpnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtn_order;
        private MetroFramework.Controls.MetroLink mlink_Close;
        private MetroFramework.Controls.MetroPanel mpnl_Main;
    }
}
