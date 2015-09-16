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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mpnl_Main = new MetroFramework.Controls.MetroPanel();
            this.mlink_Close = new MetroFramework.Controls.MetroLink();
            this.mlbl_price = new MetroFramework.Controls.MetroLabel();
            this.mbtn_order = new MetroFramework.Controls.MetroButton();
            this.mg_orderPositions = new MetroFramework.Controls.MetroGrid();
            this.mpnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mg_orderPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // mpnl_Main
            // 
            this.mpnl_Main.BackColor = System.Drawing.Color.Black;
            this.mpnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpnl_Main.Controls.Add(this.mg_orderPositions);
            this.mpnl_Main.Controls.Add(this.mlink_Close);
            this.mpnl_Main.Controls.Add(this.mlbl_price);
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
            // mlbl_price
            // 
            this.mlbl_price.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbl_price.Location = new System.Drawing.Point(22, 334);
            this.mlbl_price.Name = "mlbl_price";
            this.mlbl_price.Size = new System.Drawing.Size(152, 41);
            this.mlbl_price.TabIndex = 6;
            // 
            // mbtn_order
            // 
            this.mbtn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.mbtn_order.BackgroundImage = global::pOmmes.Properties.Resources.ic_shopping_cart_white_48dp;
            this.mbtn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtn_order.Location = new System.Drawing.Point(180, 334);
            this.mbtn_order.Name = "mbtn_order";
            this.mbtn_order.Size = new System.Drawing.Size(96, 41);
            this.mbtn_order.TabIndex = 5;
            this.mbtn_order.UseSelectable = true;
            this.mbtn_order.Click += new System.EventHandler(this.mbtn_order_Click);
            // 
            // mg_orderPositions
            // 
            this.mg_orderPositions.AllowUserToResizeRows = false;
            this.mg_orderPositions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_orderPositions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_orderPositions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_orderPositions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_orderPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mg_orderPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_orderPositions.DefaultCellStyle = dataGridViewCellStyle2;
            this.mg_orderPositions.EnableHeadersVisualStyles = false;
            this.mg_orderPositions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_orderPositions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_orderPositions.Location = new System.Drawing.Point(3, 57);
            this.mg_orderPositions.Name = "mg_orderPositions";
            this.mg_orderPositions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_orderPositions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mg_orderPositions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_orderPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_orderPositions.Size = new System.Drawing.Size(272, 271);
            this.mg_orderPositions.TabIndex = 10;
            // 
            // FoodBasketUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_Main);
            this.Name = "FoodBasketUserControl";
            this.Size = new System.Drawing.Size(280, 380);
            this.Load += new System.EventHandler(this.FoodDetailUserControl_Load);
            this.mpnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mg_orderPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_Main;
        private MetroFramework.Controls.MetroLabel mlbl_price;
        private MetroFramework.Controls.MetroButton mbtn_order;
        private MetroFramework.Controls.MetroLink mlink_Close;
        private MetroFramework.Controls.MetroGrid mg_orderPositions;
    }
}
