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
            this.SuspendLayout();
            // 
            // mtc_FoodList
            // 
            this.mtc_FoodList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtc_FoodList.Location = new System.Drawing.Point(0, 0);
            this.mtc_FoodList.Name = "mtc_FoodList";
            this.mtc_FoodList.Size = new System.Drawing.Size(400, 600);
            this.mtc_FoodList.TabIndex = 1;
            this.mtc_FoodList.UseSelectable = true;
            // 
            // FoodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mtc_FoodList);
            this.Name = "FoodUserControl";
            this.Size = new System.Drawing.Size(400, 600);
            this.Load += new System.EventHandler(this.FoodUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtc_FoodList;


    }
}
