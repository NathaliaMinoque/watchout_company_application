
namespace InsertJamTangan
{
    partial class FormStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.cboxMerk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBackStock = new System.Windows.Forms.Button();
            this.labelJmlproduk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(85, 131);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(946, 371);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stock_cellclick);
            // 
            // cboxMerk
            // 
            this.cboxMerk.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMerk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxMerk.FormattingEnabled = true;
            this.cboxMerk.Items.AddRange(new object[] {
            "All",
            "Daniel Wellington",
            "Lacoste",
            "Timex"});
            this.cboxMerk.Location = new System.Drawing.Point(197, 69);
            this.cboxMerk.Name = "cboxMerk";
            this.cboxMerk.Size = new System.Drawing.Size(318, 27);
            this.cboxMerk.TabIndex = 19;
            this.cboxMerk.SelectedIndexChanged += new System.EventHandler(this.cboxMerk_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(92, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Brand";
            // 
            // buttonBackStock
            // 
            this.buttonBackStock.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonBackStock.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackStock.Location = new System.Drawing.Point(85, 538);
            this.buttonBackStock.Name = "buttonBackStock";
            this.buttonBackStock.Size = new System.Drawing.Size(167, 70);
            this.buttonBackStock.TabIndex = 27;
            this.buttonBackStock.Text = "Back";
            this.buttonBackStock.UseVisualStyleBackColor = false;
            this.buttonBackStock.Click += new System.EventHandler(this.buttonBackStock_Click);
            // 
            // labelJmlproduk
            // 
            this.labelJmlproduk.AutoSize = true;
            this.labelJmlproduk.BackColor = System.Drawing.Color.Transparent;
            this.labelJmlproduk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJmlproduk.ForeColor = System.Drawing.SystemColors.Control;
            this.labelJmlproduk.Location = new System.Drawing.Point(755, 69);
            this.labelJmlproduk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJmlproduk.Name = "labelJmlproduk";
            this.labelJmlproduk.Size = new System.Drawing.Size(276, 28);
            this.labelJmlproduk.TabIndex = 29;
            this.labelJmlproduk.Text = "Total Active Product : 0";
            this.labelJmlproduk.Click += new System.EventHandler(this.labelJmlproduk_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 668);
            this.Controls.Add(this.labelJmlproduk);
            this.Controls.Add(this.buttonBackStock);
            this.Controls.Add(this.cboxMerk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStock);
            this.DoubleBuffered = true;
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.ComboBox cboxMerk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBackStock;
        private System.Windows.Forms.Label labelJmlproduk;
    }
}