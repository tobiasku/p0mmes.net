namespace pOmmes
{
    partial class FoodDetailUserControl
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
            this.mpnl_Main = new MetroFramework.Controls.MetroPanel();
            this.mlbl_desc_UserName = new MetroFramework.Controls.MetroLabel();
            this.mtxt_ExtraWishes = new MetroFramework.Controls.MetroTextBox();
            this.clb_Options = new System.Windows.Forms.CheckedListBox();
            this.mlink_Close = new MetroFramework.Controls.MetroLink();
            this.mcmb_sizes = new MetroFramework.Controls.MetroComboBox();
            this.mlbl_price = new MetroFramework.Controls.MetroLabel();
            this.mbtn_order = new MetroFramework.Controls.MetroButton();
            this.mlbl_name = new MetroFramework.Controls.MetroLabel();
            this.mtxt_Count = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_description = new MetroFramework.Controls.MetroLabel();
            this.mpnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpnl_Main
            // 
            this.mpnl_Main.BackColor = System.Drawing.Color.Black;
            this.mpnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpnl_Main.Controls.Add(this.mlbl_description);
            this.mpnl_Main.Controls.Add(this.mlbl_desc_UserName);
            this.mpnl_Main.Controls.Add(this.mtxt_ExtraWishes);
            this.mpnl_Main.Controls.Add(this.clb_Options);
            this.mpnl_Main.Controls.Add(this.mlink_Close);
            this.mpnl_Main.Controls.Add(this.mcmb_sizes);
            this.mpnl_Main.Controls.Add(this.mlbl_price);
            this.mpnl_Main.Controls.Add(this.mbtn_order);
            this.mpnl_Main.Controls.Add(this.mlbl_name);
            this.mpnl_Main.Controls.Add(this.mtxt_Count);
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
            // mlbl_desc_UserName
            // 
            this.mlbl_desc_UserName.AutoSize = true;
            this.mlbl_desc_UserName.Location = new System.Drawing.Point(22, 244);
            this.mlbl_desc_UserName.Name = "mlbl_desc_UserName";
            this.mlbl_desc_UserName.Size = new System.Drawing.Size(113, 19);
            this.mlbl_desc_UserName.TabIndex = 12;
            this.mlbl_desc_UserName.Text = "Extra Information:";
            // 
            // mtxt_ExtraWishes
            // 
            this.mtxt_ExtraWishes.Lines = new string[0];
            this.mtxt_ExtraWishes.Location = new System.Drawing.Point(22, 266);
            this.mtxt_ExtraWishes.MaxLength = 32767;
            this.mtxt_ExtraWishes.Multiline = true;
            this.mtxt_ExtraWishes.Name = "mtxt_ExtraWishes";
            this.mtxt_ExtraWishes.PasswordChar = '\0';
            this.mtxt_ExtraWishes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_ExtraWishes.SelectedText = "";
            this.mtxt_ExtraWishes.Size = new System.Drawing.Size(253, 62);
            this.mtxt_ExtraWishes.TabIndex = 11;
            this.mtxt_ExtraWishes.UseSelectable = true;
            // 
            // clb_Options
            // 
            this.clb_Options.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Options.CheckOnClick = true;
            this.clb_Options.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Options.FormattingEnabled = true;
            this.clb_Options.Location = new System.Drawing.Point(22, 122);
            this.clb_Options.Name = "clb_Options";
            this.clb_Options.Size = new System.Drawing.Size(253, 119);
            this.clb_Options.TabIndex = 10;
            this.clb_Options.ThreeDCheckBoxes = true;
            this.clb_Options.SelectedValueChanged += new System.EventHandler(this.clb_Options_SelectedValueChanged);
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
            // mcmb_sizes
            // 
            this.mcmb_sizes.FormattingEnabled = true;
            this.mcmb_sizes.ItemHeight = 23;
            this.mcmb_sizes.Location = new System.Drawing.Point(22, 87);
            this.mcmb_sizes.Name = "mcmb_sizes";
            this.mcmb_sizes.Size = new System.Drawing.Size(253, 29);
            this.mcmb_sizes.TabIndex = 7;
            this.mcmb_sizes.UseSelectable = true;
            this.mcmb_sizes.SelectedValueChanged += new System.EventHandler(this.mcmb_sizes_SelectedValueChanged);
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
            // mlbl_name
            // 
            this.mlbl_name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbl_name.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbl_name.Location = new System.Drawing.Point(66, 13);
            this.mlbl_name.Name = "mlbl_name";
            this.mlbl_name.Size = new System.Drawing.Size(178, 25);
            this.mlbl_name.TabIndex = 3;
            this.mlbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxt_Count
            // 
            this.mtxt_Count.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxt_Count.Lines = new string[] {
        "1"};
            this.mtxt_Count.Location = new System.Drawing.Point(22, 13);
            this.mtxt_Count.MaxLength = 1;
            this.mtxt_Count.Name = "mtxt_Count";
            this.mtxt_Count.PasswordChar = '\0';
            this.mtxt_Count.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Count.SelectedText = "";
            this.mtxt_Count.Size = new System.Drawing.Size(38, 25);
            this.mtxt_Count.TabIndex = 2;
            this.mtxt_Count.Text = "1";
            this.mtxt_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_Count.UseSelectable = true;
            this.mtxt_Count.TextChanged += new System.EventHandler(this.mtxt_Count_TextChanged);
            this.mtxt_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_Count_KeyPress);
            // 
            // mlbl_description
            // 
            this.mlbl_description.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlbl_description.Location = new System.Drawing.Point(66, 38);
            this.mlbl_description.Name = "mlbl_description";
            this.mlbl_description.Size = new System.Drawing.Size(209, 46);
            this.mlbl_description.TabIndex = 14;
            // 
            // FoodDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpnl_Main);
            this.Name = "FoodDetailUserControl";
            this.Size = new System.Drawing.Size(280, 380);
            this.Load += new System.EventHandler(this.FoodDetailUserControl_Load);
            this.mpnl_Main.ResumeLayout(false);
            this.mpnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpnl_Main;
        private MetroFramework.Controls.MetroLabel mlbl_name;
        private MetroFramework.Controls.MetroTextBox mtxt_Count;
        private MetroFramework.Controls.MetroLabel mlbl_price;
        private MetroFramework.Controls.MetroButton mbtn_order;
        private MetroFramework.Controls.MetroComboBox mcmb_sizes;
        private MetroFramework.Controls.MetroLink mlink_Close;
        private System.Windows.Forms.CheckedListBox clb_Options;
        private MetroFramework.Controls.MetroTextBox mtxt_ExtraWishes;
        private MetroFramework.Controls.MetroLabel mlbl_desc_UserName;
        private MetroFramework.Controls.MetroLabel mlbl_description;
    }
}
