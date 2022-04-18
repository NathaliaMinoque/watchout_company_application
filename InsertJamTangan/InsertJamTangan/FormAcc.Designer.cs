
namespace InsertJamTangan
{
    partial class FormAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcc));
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.buttonBackAcc = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAcc
            // 
            this.dgvAcc.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcc.Location = new System.Drawing.Point(119, 91);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.RowHeadersWidth = 62;
            this.dgvAcc.RowTemplate.Height = 28;
            this.dgvAcc.Size = new System.Drawing.Size(889, 397);
            this.dgvAcc.TabIndex = 0;
            this.dgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcc_CellClick);
            this.dgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcc_CellDoubleClick);
            // 
            // buttonBackAcc
            // 
            this.buttonBackAcc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonBackAcc.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackAcc.Location = new System.Drawing.Point(119, 532);
            this.buttonBackAcc.Name = "buttonBackAcc";
            this.buttonBackAcc.Size = new System.Drawing.Size(172, 55);
            this.buttonBackAcc.TabIndex = 2;
            this.buttonBackAcc.Text = "Back";
            this.buttonBackAcc.UseVisualStyleBackColor = false;
            this.buttonBackAcc.Click += new System.EventHandler(this.buttonBackAcc_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDetail.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDetail.Location = new System.Drawing.Point(836, 532);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(172, 55);
            this.buttonDetail.TabIndex = 3;
            this.buttonDetail.Text = "See Details";
            this.buttonDetail.UseVisualStyleBackColor = false;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // FormAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 668);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonBackAcc);
            this.Controls.Add(this.dgvAcc);
            this.DoubleBuffered = true;
            this.Name = "FormAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acc";
            this.Load += new System.EventHandler(this.FormAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAcc;
        private System.Windows.Forms.Button buttonBackAcc;
        private System.Windows.Forms.Button buttonDetail;
    }
}