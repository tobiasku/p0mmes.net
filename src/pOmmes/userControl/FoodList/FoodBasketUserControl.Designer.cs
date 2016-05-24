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
            this.mlbl_description = new MetroFramework.Controls.MetroLabel();
            this.mlbl_desc_ExtraInformation = new MetroFramework.Controls.MetroLabel();
            this.mtxt_ExtraWishes = new MetroFramework.Controls.MetroTextBox();
            this.mlink_Close = new MetroFramework.Controls.MetroLink();
            this.mlbl_price = new MetroFramework.Controls.MetroLabel();
            this.mbtn_order = new MetroFramework.Controls.MetroButton();
            this.mg_orderdata = new MetroFramework.Controls.MetroGrid();
            this.mpnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mg_orderdata)).BeginInit();
            this.SuspendLayout();
            // 
            // mpnl_Main
            // 
            this.mpnl_Main.BackColor = System.Drawing.Color.Black;
            this.mpnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpnl_Main.Controls.Add(this.mg_orderdata);
            this.mpnl_Main.Controls.Add(this.mlbl_description);
            this.mpnl_Main.Controls.Add(this.mlbl_desc_ExtraInformation);
            this.mpnl_Main.Controls.Add(this.mtxt_ExtraWishes);
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
            // mlbl_description
            // 
            this.mlbl_description.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlbl_description.Location = new System.Drawing.Point(22, 13);
            this.mlbl_description.Name = "mlbl_description";
            this.mlbl_description.Size = new System.Drawing.Size(209, 46);
            this.mlbl_description.TabIndex = 14;
            // 
            // mlbl_desc_ExtraInformation
            // 
            this.mlbl_desc_ExtraInformation.AutoSize = true;
            this.mlbl_desc_ExtraInformation.Location = new System.Drawing.Point(22, 244);
            this.mlbl_desc_ExtraInformation.Name = "mlbl_desc_ExtraInformation";
            this.mlbl_desc_ExtraInformation.Size = new System.Drawing.Size(113, 19);
            this.mlbl_desc_ExtraInformation.TabIndex = 12;
            this.mlbl_desc_ExtraInformation.Text = "Extra Information:";
            // 
            // mtxt_ExtraWishes
            // 
            // 
            // 
            // 
            this.mtxt_ExtraWishes.CustomButton.Image = null;
            this.mtxt_ExtraWishes.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.mtxt_ExtraWishes.CustomButton.Name = "";
            this.mtxt_ExtraWishes.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.mtxt_ExtraWishes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_ExtraWishes.CustomButton.TabIndex = 1;
            this.mtxt_ExtraWishes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_ExtraWishes.CustomButton.UseSelectable = true;
            this.mtxt_ExtraWishes.CustomButton.Visible = false;
            this.mtxt_ExtraWishes.Lines = new string[0];
            this.mtxt_ExtraWishes.Location = new System.Drawing.Point(22, 266);
            this.mtxt_ExtraWishes.MaxLength = 32767;
            this.mtxt_ExtraWishes.Multiline = true;
            this.mtxt_ExtraWishes.Name = "mtxt_ExtraWishes";
            this.mtxt_ExtraWishes.PasswordChar = '\0';
            this.mtxt_ExtraWishes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_ExtraWishes.SelectedText = "";
            this.mtxt_ExtraWishes.SelectionLength = 0;
            this.mtxt_ExtraWishes.SelectionStart = 0;
            this.mtxt_ExtraWishes.Size = new System.Drawing.Size(253, 62);
            this.mtxt_ExtraWishes.TabIndex = 11;
            this.mtxt_ExtraWishes.UseSelectable = true;
            this.mtxt_ExtraWishes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_ExtraWishes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.mbtn_order.BackgroundImage = Resources.pOmmes_Resources.ic_shopping_cart_white_48dp;
            this.mbtn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtn_order.Location = new System.Drawing.Point(180, 334);
            this.mbtn_order.Name = "mbtn_order";
            this.mbtn_order.Size = new System.Drawing.Size(96, 41);
            this.mbtn_order.TabIndex = 5;
            this.mbtn_order.UseSelectable = true;
            this.mbtn_order.Click += new System.EventHandler(this.mbtn_order_Click);
            // 
            // mg_orderdata
            // 
            this.mg_orderdata.AllowUserToResizeRows = false;
            this.mg_orderdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_orderdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_orderdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_orderdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_orderdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mg_orderdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_orderdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.mg_orderdata.EnableHeadersVisualStyles = false;
            this.mg_orderdata.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_orderdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_orderdata.Location = new System.Drawing.Point(22, 62);
            this.mg_orderdata.Name = "mg_orderdata";
            this.mg_orderdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_orderdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mg_orderdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_orderdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_orderdata.Size = new System.Drawing.Size(253, 179);
            this.mg_orderdata.TabIndex = 15;
            // 
            // FoodBasketUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_Main);
            this.Name = "FoodBasketUserControl";
            this.Size = new System.Drawing.Size(280, 380);
            this.mpnl_Main.ResumeLayout(false);
            this.mpnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mg_orderdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_Main;
        private MetroFramework.Controls.MetroLabel mlbl_price;
        private MetroFramework.Controls.MetroButton mbtn_order;
        private MetroFramework.Controls.MetroLink mlink_Close;
        private MetroFramework.Controls.MetroTextBox mtxt_ExtraWishes;
        private MetroFramework.Controls.MetroLabel mlbl_desc_ExtraInformation;
        private MetroFramework.Controls.MetroLabel mlbl_description;
        private MetroFramework.Controls.MetroGrid mg_orderdata;
    }
}