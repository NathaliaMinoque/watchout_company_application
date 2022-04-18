namespace InsertJamTangan
{
    partial class FormLaporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporan));
            this.label2 = new System.Windows.Forms.Label();
            this.cboxJenis = new System.Windows.Forms.ComboBox();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.gbLaporan = new System.Windows.Forms.GroupBox();
            this.buttonBackLap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.gbLaporan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // cboxJenis
            // 
            this.cboxJenis.FormattingEnabled = true;
            this.cboxJenis.Items.AddRange(new object[] {
            "Restock",
            "Best Seller",
            "Top Reseller"});
            this.cboxJenis.Location = new System.Drawing.Point(100, 37);
            this.cboxJenis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxJenis.Name = "cboxJenis";
            this.cboxJenis.Size = new System.Drawing.Size(312, 36);
            this.cboxJenis.TabIndex = 2;
            this.cboxJenis.SelectedIndexChanged += new System.EventHandler(this.cboxJenis_SelectedIndexChanged);
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(9, 95);
            this.dgvLaporan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 62;
            this.dgvLaporan.Size = new System.Drawing.Size(940, 344);
            this.dgvLaporan.TabIndex = 3;
            // 
            // gbLaporan
            // 
            this.gbLaporan.Controls.Add(this.cboxJenis);
            this.gbLaporan.Controls.Add(this.label2);
            this.gbLaporan.Controls.Add(this.dgvLaporan);
            this.gbLaporan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLaporan.Location = new System.Drawing.Point(47, 37);
            this.gbLaporan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLaporan.Name = "gbLaporan";
            this.gbLaporan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLaporan.Size = new System.Drawing.Size(957, 449);
            this.gbLaporan.TabIndex = 4;
            this.gbLaporan.TabStop = false;
            this.gbLaporan.Text = "Report";
            // 
            // buttonBackLap
            // 
            this.buttonBackLap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonBackLap.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackLap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackLap.Location = new System.Drawing.Point(47, 532);
            this.buttonBackLap.Name = "buttonBackLap";
            this.buttonBackLap.Size = new System.Drawing.Size(188, 72);
            this.buttonBackLap.TabIndex = 5;
            this.buttonBackLap.Text = "Back";
            this.buttonBackLap.UseVisualStyleBackColor = false;
            this.buttonBackLap.Click += new System.EventHandler(this.buttonBackLap_Click);
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 668);
            this.Controls.Add(this.buttonBackLap);
            this.Controls.Add(this.gbLaporan);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.gbLaporan.ResumeLayout(false);
            this.gbLaporan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxJenis;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.GroupBox gbLaporan;
        private System.Windows.Forms.Button buttonBackLap;
    }
}