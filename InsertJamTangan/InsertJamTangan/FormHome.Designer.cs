
namespace InsertJamTangan
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.buttonPenjualan = new System.Windows.Forms.Button();
            this.buttonLaporan = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonAcc = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPenjualan
            // 
            this.buttonPenjualan.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPenjualan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPenjualan.Location = new System.Drawing.Point(67, 403);
            this.buttonPenjualan.Name = "buttonPenjualan";
            this.buttonPenjualan.Size = new System.Drawing.Size(483, 62);
            this.buttonPenjualan.TabIndex = 6;
            this.buttonPenjualan.Text = "Sale";
            this.buttonPenjualan.UseVisualStyleBackColor = false;
            this.buttonPenjualan.Click += new System.EventHandler(this.buttonPenjualan_Click);
            // 
            // buttonLaporan
            // 
            this.buttonLaporan.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaporan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaporan.Location = new System.Drawing.Point(67, 556);
            this.buttonLaporan.Name = "buttonLaporan";
            this.buttonLaporan.Size = new System.Drawing.Size(483, 62);
            this.buttonLaporan.TabIndex = 5;
            this.buttonLaporan.Text = "Report";
            this.buttonLaporan.UseVisualStyleBackColor = false;
            this.buttonLaporan.Click += new System.EventHandler(this.buttonLaporan_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOff.Location = new System.Drawing.Point(1009, 12);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(129, 78);
            this.buttonOff.TabIndex = 4;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonAcc
            // 
            this.buttonAcc.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcc.Location = new System.Drawing.Point(67, 634);
            this.buttonAcc.Name = "buttonAcc";
            this.buttonAcc.Size = new System.Drawing.Size(483, 62);
            this.buttonAcc.TabIndex = 2;
            this.buttonAcc.Text = "Acc";
            this.buttonAcc.UseVisualStyleBackColor = false;
            this.buttonAcc.Click += new System.EventHandler(this.buttonAcc_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStock.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.Location = new System.Drawing.Point(67, 325);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(483, 62);
            this.buttonStock.TabIndex = 1;
            this.buttonStock.Text = "Stock";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(67, 480);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(483, 62);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 724);
            this.Controls.Add(this.buttonPenjualan);
            this.Controls.Add(this.buttonAcc);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonLaporan);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonAcc;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonLaporan;
        private System.Windows.Forms.Button buttonPenjualan;
    }
}