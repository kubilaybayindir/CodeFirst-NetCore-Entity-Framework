namespace _4_CodeFirst_NetCoreEF
{
    partial class FormLazyLoadingEagerLoading
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
            this.LbxCategories = new System.Windows.Forms.ListBox();
            this.LbxProducts = new System.Windows.Forms.ListBox();
            this.BtGetCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbxCategories
            // 
            this.LbxCategories.FormattingEnabled = true;
            this.LbxCategories.ItemHeight = 17;
            this.LbxCategories.Location = new System.Drawing.Point(35, 135);
            this.LbxCategories.Name = "LbxCategories";
            this.LbxCategories.Size = new System.Drawing.Size(231, 293);
            this.LbxCategories.TabIndex = 3;
            this.LbxCategories.SelectedIndexChanged += new System.EventHandler(this.LbxCategories_SelectedIndexChanged);
            // 
            // LbxProducts
            // 
            this.LbxProducts.FormattingEnabled = true;
            this.LbxProducts.ItemHeight = 17;
            this.LbxProducts.Location = new System.Drawing.Point(293, 135);
            this.LbxProducts.Name = "LbxProducts";
            this.LbxProducts.Size = new System.Drawing.Size(231, 293);
            this.LbxProducts.TabIndex = 4;
            // 
            // BtGetCategories
            // 
            this.BtGetCategories.Location = new System.Drawing.Point(35, 28);
            this.BtGetCategories.Name = "BtGetCategories";
            this.BtGetCategories.Size = new System.Drawing.Size(181, 28);
            this.BtGetCategories.TabIndex = 5;
            this.BtGetCategories.Text = "Get Categories";
            this.BtGetCategories.UseVisualStyleBackColor = true;
            this.BtGetCategories.Click += new System.EventHandler(this.BtGetCategories_Click);
            // 
            // FormLazyLoadingEagerLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 510);
            this.Controls.Add(this.BtGetCategories);
            this.Controls.Add(this.LbxProducts);
            this.Controls.Add(this.LbxCategories);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormLazyLoadingEagerLoading";
            this.Text = "FormLazyLoadingEagerLoading";
            this.Load += new System.EventHandler(this.FormLazyLoadingEagerLoading_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LbxCategories;
        private ListBox LbxProducts;
        private Button BtGetCategories;
    }
}