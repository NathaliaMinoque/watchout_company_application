
namespace InsertJamTangan
{
    partial class FormDetailAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailAcc));
            this.dgvDetailAcc = new System.Windows.Forms.DataGridView();
            this.buttonBackAcc = new System.Windows.Forms.Button();
            this.buttonAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetailAcc
            // 
            this.dgvDetailAcc.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDetailAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailAcc.Location = new System.Drawing.Point(100, 81);
            this.dgvDetailAcc.Name = "dgvDetailAcc";
            this.dgvDetailAcc.RowHeadersWidth = 62;
            this.dgvDetailAcc.RowTemplate.Height = 28;
            this.dgvDetailAcc.Size = new System.Drawing.Size(927, 409);
            this.dgvDetailAcc.TabIndex = 0;
            this.dgvDetailAcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailAcc_CellContentClick);
            // 
            // buttonBackAcc
            // 
            this.buttonBackAcc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonBackAcc.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackAcc.Location = new System.Drawing.Point(100, 532);
            this.buttonBackAcc.Name = "buttonBackAcc";
            this.buttonBackAcc.Size = new System.Drawing.Size(148, 59);
            this.buttonBackAcc.TabIndex = 3;
            this.buttonBackAcc.Text = "Back";
            this.buttonBackAcc.UseVisualStyleBackColor = false;
            this.buttonBackAcc.Click += new System.EventHandler(this.buttonBackAcc_Click);
            // 
            // buttonAcc
            // 
            this.buttonAcc.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAcc.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAcc.Location = new System.Drawing.Point(879, 532);
            this.buttonAcc.Name = "buttonAcc";
            this.buttonAcc.Size = new System.Drawing.Size(148, 59);
            this.buttonAcc.TabIndex = 4;
            this.buttonAcc.Text = "Accept";
            this.buttonAcc.UseVisualStyleBackColor = false;
            this.buttonAcc.Click += new System.EventHandler(this.buttonAcc_Click);
            // 
            // FormDetailAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 668);
            this.Controls.Add(this.buttonAcc);
            this.Controls.Add(this.buttonBackAcc);
            this.Controls.Add(this.dgvDetailAcc);
            this.DoubleBuffered = true;
            this.Name = "FormDetailAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailAcc";
            this.Load += new System.EventHandler(this.FormDetailAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetailAcc;
        private System.Windows.Forms.Button buttonBackAcc;
        private System.Windows.Forms.Button buttonAcc;
    }
}