namespace pOmmes
{
    partial class ArticleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mbtn_Save = new MetroFramework.Controls.MetroButton();
            this.mlbl_desc_UserName = new MetroFramework.Controls.MetroLabel();
            this.mtxt_Name = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_desc_Description = new MetroFramework.Controls.MetroLabel();
            this.mtxt_Description = new MetroFramework.Controls.MetroTextBox();
            this.mcmb_Restaurant = new MetroFramework.Controls.MetroComboBox();
            this.mlbl_desc_Restaurant = new MetroFramework.Controls.MetroLabel();
            this.mbtn_Cancel = new MetroFramework.Controls.MetroButton();
            this.mlbl_desc_Number = new MetroFramework.Controls.MetroLabel();
            this.mtxt_Number = new MetroFramework.Controls.MetroTextBox();
            this.mlbl_desc_Category = new MetroFramework.Controls.MetroLabel();
            this.mcmb_Category = new MetroFramework.Controls.MetroComboBox();
            this.mg_Sizes = new MetroFramework.Controls.MetroGrid();
            this.mg_Sizes_clm_Size = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mg_Sizes_txt_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlbl_desc_Sizes = new MetroFramework.Controls.MetroLabel();
            this.mlbl_desc_Options = new MetroFramework.Controls.MetroLabel();
            this.mg_Options = new MetroFramework.Controls.MetroGrid();
            this.mg_Options_clm_Option = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mg_Options_clm_Size = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mg_Options_txt_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mg_Sizes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mg_Options)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtn_Save
            // 
            this.mbtn_Save.Location = new System.Drawing.Point(215, 646);
            this.mbtn_Save.Name = "mbtn_Save";
            this.mbtn_Save.Size = new System.Drawing.Size(90, 29);
            this.mbtn_Save.TabIndex = 8;
            this.mbtn_Save.Text = "Save";
            this.mbtn_Save.UseSelectable = true;
            this.mbtn_Save.Click += new System.EventHandler(this.mbtn_Save_Click);
            // 
            // mlbl_desc_UserName
            // 
            this.mlbl_desc_UserName.AutoSize = true;
            this.mlbl_desc_UserName.Location = new System.Drawing.Point(23, 60);
            this.mlbl_desc_UserName.Name = "mlbl_desc_UserName";
            this.mlbl_desc_UserName.Size = new System.Drawing.Size(48, 19);
            this.mlbl_desc_UserName.TabIndex = 6;
            this.mlbl_desc_UserName.Text = "Name:";
            // 
            // mtxt_Name
            // 
            this.mtxt_Name.CustomButton.Image = null;
            this.mtxt_Name.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxt_Name.CustomButton.Name = "";
            this.mtxt_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Name.CustomButton.TabIndex = 1;
            this.mtxt_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Name.CustomButton.UseSelectable = true;
            this.mtxt_Name.CustomButton.Visible = false;
            this.mtxt_Name.Lines = new string[0];
            this.mtxt_Name.Location = new System.Drawing.Point(23, 82);
            this.mtxt_Name.MaxLength = 32767;
            this.mtxt_Name.Name = "mtxt_Name";
            this.mtxt_Name.PasswordChar = '\0';
            this.mtxt_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Name.SelectedText = "";
            this.mtxt_Name.SelectionLength = 0;
            this.mtxt_Name.SelectionStart = 0;
            this.mtxt_Name.Size = new System.Drawing.Size(282, 23);
            this.mtxt_Name.TabIndex = 1;
            this.mtxt_Name.UseSelectable = true;
            this.mtxt_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_desc_Description
            // 
            this.mlbl_desc_Description.AutoSize = true;
            this.mlbl_desc_Description.Location = new System.Drawing.Point(23, 156);
            this.mlbl_desc_Description.Name = "mlbl_desc_Description";
            this.mlbl_desc_Description.Size = new System.Drawing.Size(77, 19);
            this.mlbl_desc_Description.TabIndex = 11;
            this.mlbl_desc_Description.Text = "Description:";
            // 
            // mtxt_Description
            // 
            this.mtxt_Description.CustomButton.Image = null;
            this.mtxt_Description.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.mtxt_Description.CustomButton.Name = "";
            this.mtxt_Description.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.mtxt_Description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Description.CustomButton.TabIndex = 1;
            this.mtxt_Description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Description.CustomButton.UseSelectable = true;
            this.mtxt_Description.CustomButton.Visible = false;
            this.mtxt_Description.Lines = new string[0];
            this.mtxt_Description.Location = new System.Drawing.Point(23, 178);
            this.mtxt_Description.MaxLength = 32767;
            this.mtxt_Description.Multiline = true;
            this.mtxt_Description.Name = "mtxt_Description";
            this.mtxt_Description.PasswordChar = '\0';
            this.mtxt_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Description.SelectedText = "";
            this.mtxt_Description.SelectionLength = 0;
            this.mtxt_Description.SelectionStart = 0;
            this.mtxt_Description.Size = new System.Drawing.Size(282, 80);
            this.mtxt_Description.TabIndex = 2;
            this.mtxt_Description.UseSelectable = true;
            this.mtxt_Description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mcmb_Restaurant
            // 
            this.mcmb_Restaurant.FormattingEnabled = true;
            this.mcmb_Restaurant.ItemHeight = 23;
            this.mcmb_Restaurant.Location = new System.Drawing.Point(23, 611);
            this.mcmb_Restaurant.Name = "mcmb_Restaurant";
            this.mcmb_Restaurant.Size = new System.Drawing.Size(282, 29);
            this.mcmb_Restaurant.TabIndex = 7;
            this.mcmb_Restaurant.UseSelectable = true;
            // 
            // mlbl_desc_Restaurant
            // 
            this.mlbl_desc_Restaurant.AutoSize = true;
            this.mlbl_desc_Restaurant.Location = new System.Drawing.Point(23, 589);
            this.mlbl_desc_Restaurant.Name = "mlbl_desc_Restaurant";
            this.mlbl_desc_Restaurant.Size = new System.Drawing.Size(73, 19);
            this.mlbl_desc_Restaurant.TabIndex = 17;
            this.mlbl_desc_Restaurant.Text = "Restaurant:";
            // 
            // mbtn_Cancel
            // 
            this.mbtn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtn_Cancel.Location = new System.Drawing.Point(119, 652);
            this.mbtn_Cancel.Name = "mbtn_Cancel";
            this.mbtn_Cancel.Size = new System.Drawing.Size(90, 23);
            this.mbtn_Cancel.TabIndex = 9;
            this.mbtn_Cancel.TabStop = false;
            this.mbtn_Cancel.Text = "Cancel";
            this.mbtn_Cancel.UseSelectable = true;
            this.mbtn_Cancel.Click += new System.EventHandler(this.mbtn_Cancel_Click);
            // 
            // mlbl_desc_Number
            // 
            this.mlbl_desc_Number.AutoSize = true;
            this.mlbl_desc_Number.Location = new System.Drawing.Point(23, 108);
            this.mlbl_desc_Number.Name = "mlbl_desc_Number";
            this.mlbl_desc_Number.Size = new System.Drawing.Size(61, 19);
            this.mlbl_desc_Number.TabIndex = 19;
            this.mlbl_desc_Number.Text = "Number:";
            // 
            // mtxt_Number
            // 
            this.mtxt_Number.CustomButton.Image = null;
            this.mtxt_Number.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxt_Number.CustomButton.Name = "";
            this.mtxt_Number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxt_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxt_Number.CustomButton.TabIndex = 1;
            this.mtxt_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxt_Number.CustomButton.UseSelectable = true;
            this.mtxt_Number.CustomButton.Visible = false;
            this.mtxt_Number.Lines = new string[0];
            this.mtxt_Number.Location = new System.Drawing.Point(23, 130);
            this.mtxt_Number.MaxLength = 32767;
            this.mtxt_Number.Name = "mtxt_Number";
            this.mtxt_Number.PasswordChar = '\0';
            this.mtxt_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxt_Number.SelectedText = "";
            this.mtxt_Number.SelectionLength = 0;
            this.mtxt_Number.SelectionStart = 0;
            this.mtxt_Number.Size = new System.Drawing.Size(282, 23);
            this.mtxt_Number.TabIndex = 18;
            this.mtxt_Number.UseSelectable = true;
            this.mtxt_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxt_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlbl_desc_Category
            // 
            this.mlbl_desc_Category.AutoSize = true;
            this.mlbl_desc_Category.Location = new System.Drawing.Point(23, 535);
            this.mlbl_desc_Category.Name = "mlbl_desc_Category";
            this.mlbl_desc_Category.Size = new System.Drawing.Size(66, 19);
            this.mlbl_desc_Category.TabIndex = 21;
            this.mlbl_desc_Category.Text = "Category:";
            // 
            // mcmb_Category
            // 
            this.mcmb_Category.FormattingEnabled = true;
            this.mcmb_Category.ItemHeight = 23;
            this.mcmb_Category.Location = new System.Drawing.Point(23, 557);
            this.mcmb_Category.Name = "mcmb_Category";
            this.mcmb_Category.Size = new System.Drawing.Size(282, 29);
            this.mcmb_Category.TabIndex = 20;
            this.mcmb_Category.UseSelectable = true;
            // 
            // mg_Sizes
            // 
            this.mg_Sizes.AllowUserToResizeRows = false;
            this.mg_Sizes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_Sizes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_Sizes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_Sizes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_Sizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mg_Sizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mg_Sizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mg_Sizes_clm_Size,
            this.mg_Sizes_txt_Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_Sizes.DefaultCellStyle = dataGridViewCellStyle2;
            this.mg_Sizes.EnableHeadersVisualStyles = false;
            this.mg_Sizes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_Sizes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_Sizes.Location = new System.Drawing.Point(23, 283);
            this.mg_Sizes.Name = "mg_Sizes";
            this.mg_Sizes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_Sizes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mg_Sizes.RowHeadersVisible = false;
            this.mg_Sizes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_Sizes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_Sizes.Size = new System.Drawing.Size(333, 112);
            this.mg_Sizes.TabIndex = 22;
            this.mg_Sizes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mg_Sizes_CellValueChanged);
            this.mg_Sizes.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.mg_Sizes_UserAddedRow);
            this.mg_Sizes.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.mg_Sizes_UserDeletedRow);
            // 
            // mg_Sizes_clm_Size
            // 
            this.mg_Sizes_clm_Size.HeaderText = "Size:";
            this.mg_Sizes_clm_Size.Name = "mg_Sizes_clm_Size";
            // 
            // mg_Sizes_txt_Price
            // 
            this.mg_Sizes_txt_Price.HeaderText = "Price:";
            this.mg_Sizes_txt_Price.Name = "mg_Sizes_txt_Price";
            // 
            // mlbl_desc_Sizes
            // 
            this.mlbl_desc_Sizes.AutoSize = true;
            this.mlbl_desc_Sizes.Location = new System.Drawing.Point(23, 261);
            this.mlbl_desc_Sizes.Name = "mlbl_desc_Sizes";
            this.mlbl_desc_Sizes.Size = new System.Drawing.Size(40, 19);
            this.mlbl_desc_Sizes.TabIndex = 23;
            this.mlbl_desc_Sizes.Text = "Sizes:";
            // 
            // mlbl_desc_Options
            // 
            this.mlbl_desc_Options.AutoSize = true;
            this.mlbl_desc_Options.Location = new System.Drawing.Point(23, 398);
            this.mlbl_desc_Options.Name = "mlbl_desc_Options";
            this.mlbl_desc_Options.Size = new System.Drawing.Size(58, 19);
            this.mlbl_desc_Options.TabIndex = 25;
            this.mlbl_desc_Options.Text = "Options:";
            // 
            // mg_Options
            // 
            this.mg_Options.AllowUserToResizeRows = false;
            this.mg_Options.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_Options.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_Options.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_Options.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_Options.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mg_Options.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mg_Options.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mg_Options_clm_Option,
            this.mg_Options_clm_Size,
            this.mg_Options_txt_Price});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_Options.DefaultCellStyle = dataGridViewCellStyle5;
            this.mg_Options.EnableHeadersVisualStyles = false;
            this.mg_Options.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_Options.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_Options.Location = new System.Drawing.Point(23, 420);
            this.mg_Options.Name = "mg_Options";
            this.mg_Options.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_Options.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mg_Options.RowHeadersVisible = false;
            this.mg_Options.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_Options.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_Options.Size = new System.Drawing.Size(333, 112);
            this.mg_Options.TabIndex = 24;
            // 
            // mg_Options_clm_Option
            // 
            this.mg_Options_clm_Option.HeaderText = "Option:";
            this.mg_Options_clm_Option.Name = "mg_Options_clm_Option";
            // 
            // mg_Options_clm_Size
            // 
            this.mg_Options_clm_Size.HeaderText = "Size:";
            this.mg_Options_clm_Size.Name = "mg_Options_clm_Size";
            // 
            // mg_Options_txt_Price
            // 
            this.mg_Options_txt_Price.HeaderText = "Price:";
            this.mg_Options_txt_Price.Name = "mg_Options_txt_Price";
            // 
            // ArticleForm
            // 
            this.AcceptButton = this.mbtn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = Resources.pOmmes_Resources.ic_launcher;
            this.BackImagePadding = new System.Windows.Forms.Padding(115, 12, 0, 0);
            this.BackMaxSize = 50;
            this.CancelButton = this.mbtn_Cancel;
            this.ClientSize = new System.Drawing.Size(379, 694);
            this.Controls.Add(this.mlbl_desc_Options);
            this.Controls.Add(this.mg_Options);
            this.Controls.Add(this.mlbl_desc_Sizes);
            this.Controls.Add(this.mg_Sizes);
            this.Controls.Add(this.mlbl_desc_Category);
            this.Controls.Add(this.mcmb_Category);
            this.Controls.Add(this.mlbl_desc_Number);
            this.Controls.Add(this.mtxt_Number);
            this.Controls.Add(this.mbtn_Cancel);
            this.Controls.Add(this.mlbl_desc_Restaurant);
            this.Controls.Add(this.mcmb_Restaurant);
            this.Controls.Add(this.mlbl_desc_Description);
            this.Controls.Add(this.mtxt_Description);
            this.Controls.Add(this.mbtn_Save);
            this.Controls.Add(this.mlbl_desc_UserName);
            this.Controls.Add(this.mtxt_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArticleForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Article";
            ((System.ComponentModel.ISupportInitialize)(this.mg_Sizes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mg_Options)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtn_Save;
        private MetroFramework.Controls.MetroLabel mlbl_desc_UserName;
        private MetroFramework.Controls.MetroTextBox mtxt_Name;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Restaurant;
        private MetroFramework.Controls.MetroComboBox mcmb_Restaurant;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Description;
        private MetroFramework.Controls.MetroTextBox mtxt_Description;
        private MetroFramework.Controls.MetroButton mbtn_Cancel;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Number;
        private MetroFramework.Controls.MetroTextBox mtxt_Number;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Category;
        private MetroFramework.Controls.MetroComboBox mcmb_Category;
        private MetroFramework.Controls.MetroGrid mg_Sizes;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Sizes;
        private MetroFramework.Controls.MetroLabel mlbl_desc_Options;
        private MetroFramework.Controls.MetroGrid mg_Options;
        private System.Windows.Forms.DataGridViewComboBoxColumn mg_Sizes_clm_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn mg_Sizes_txt_Price;
        private System.Windows.Forms.DataGridViewComboBoxColumn mg_Options_clm_Option;
        private System.Windows.Forms.DataGridViewComboBoxColumn mg_Options_clm_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn mg_Options_txt_Price;
    }
}