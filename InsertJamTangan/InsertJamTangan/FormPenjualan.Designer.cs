namespace InsertJamTangan
{
    partial class FormPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjualan));
            this.tboxIDJual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxNamaPembeli = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerPenjualan = new System.Windows.Forms.DateTimePicker();
            this.tboxIDReseller = new System.Windows.Forms.TextBox();
            this.cboxNamaProduk = new System.Windows.Forms.ComboBox();
            this.rbutDW = new System.Windows.Forms.RadioButton();
            this.rbutLacoste = new System.Windows.Forms.RadioButton();
            this.rbutTimex = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Jumlah = new System.Windows.Forms.NumericUpDown();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.labelSetelahDiskon = new System.Windows.Forms.Label();
            this.buttonBackPenjualan = new System.Windows.Forms.Button();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelPersen = new System.Windows.Forms.Label();
            this.labeltotalBEFORE = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxIDJual
            // 
            this.tboxIDJual.Enabled = false;
            this.tboxIDJual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxIDJual.Location = new System.Drawing.Point(183, 22);
            this.tboxIDJual.Name = "tboxIDJual";
            this.tboxIDJual.Size = new System.Drawing.Size(266, 30);
            this.tboxIDJual.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(571, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "After Discount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(263, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(729, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(35, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Product Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(859, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(492, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Reseller ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(35, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Buyer Name";
            // 
            // cboxNamaPembeli
            // 
            this.cboxNamaPembeli.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNamaPembeli.FormattingEnabled = true;
            this.cboxNamaPembeli.Location = new System.Drawing.Point(183, 71);
            this.cboxNamaPembeli.Name = "cboxNamaPembeli";
            this.cboxNamaPembeli.Size = new System.Drawing.Size(266, 30);
            this.cboxNamaPembeli.TabIndex = 11;
            this.cboxNamaPembeli.SelectedIndexChanged += new System.EventHandler(this.cboxNamaPembeli_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(951, 571);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(140, 48);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Brown;
            this.buttonDelete.Location = new System.Drawing.Point(793, 571);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 48);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddToCart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddToCart.Location = new System.Drawing.Point(951, 226);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(140, 48);
            this.buttonAddToCart.TabIndex = 14;
            this.buttonAddToCart.Text = "ADD TO CART";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvPenjualan.Location = new System.Drawing.Point(39, 293);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.RowHeadersWidth = 62;
            this.dgvPenjualan.RowTemplate.Height = 28;
            this.dgvPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenjualan.Size = new System.Drawing.Size(1052, 227);
            this.dgvPenjualan.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SKU";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity (pcs)";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price ($)";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Subtotal ($)";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // dateTimePickerPenjualan
            // 
            this.dateTimePickerPenjualan.Enabled = false;
            this.dateTimePickerPenjualan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPenjualan.Location = new System.Drawing.Point(916, 19);
            this.dateTimePickerPenjualan.Name = "dateTimePickerPenjualan";
            this.dateTimePickerPenjualan.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerPenjualan.TabIndex = 16;
            // 
            // tboxIDReseller
            // 
            this.tboxIDReseller.Enabled = false;
            this.tboxIDReseller.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxIDReseller.Location = new System.Drawing.Point(620, 71);
            this.tboxIDReseller.Name = "tboxIDReseller";
            this.tboxIDReseller.Size = new System.Drawing.Size(207, 30);
            this.tboxIDReseller.TabIndex = 17;
            // 
            // cboxNamaProduk
            // 
            this.cboxNamaProduk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNamaProduk.FormattingEnabled = true;
            this.cboxNamaProduk.Location = new System.Drawing.Point(183, 236);
            this.cboxNamaProduk.Name = "cboxNamaProduk";
            this.cboxNamaProduk.Size = new System.Drawing.Size(404, 30);
            this.cboxNamaProduk.TabIndex = 18;
            this.cboxNamaProduk.SelectedIndexChanged += new System.EventHandler(this.cboxNamaProduk_SelectedIndexChanged);
            // 
            // rbutDW
            // 
            this.rbutDW.AutoSize = true;
            this.rbutDW.BackColor = System.Drawing.Color.Transparent;
            this.rbutDW.Checked = true;
            this.rbutDW.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutDW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbutDW.Location = new System.Drawing.Point(183, 125);
            this.rbutDW.Name = "rbutDW";
            this.rbutDW.Size = new System.Drawing.Size(187, 26);
            this.rbutDW.TabIndex = 19;
            this.rbutDW.TabStop = true;
            this.rbutDW.Text = "Daniel Wellington";
            this.rbutDW.UseVisualStyleBackColor = false;
            this.rbutDW.CheckedChanged += new System.EventHandler(this.rbutDW_CheckedChanged);
            // 
            // rbutLacoste
            // 
            this.rbutLacoste.AutoSize = true;
            this.rbutLacoste.BackColor = System.Drawing.Color.Transparent;
            this.rbutLacoste.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutLacoste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbutLacoste.Location = new System.Drawing.Point(183, 155);
            this.rbutLacoste.Name = "rbutLacoste";
            this.rbutLacoste.Size = new System.Drawing.Size(104, 26);
            this.rbutLacoste.TabIndex = 20;
            this.rbutLacoste.Text = "Lacoste";
            this.rbutLacoste.UseVisualStyleBackColor = false;
            this.rbutLacoste.CheckedChanged += new System.EventHandler(this.rbutLacoste_CheckedChanged);
            // 
            // rbutTimex
            // 
            this.rbutTimex.AutoSize = true;
            this.rbutTimex.BackColor = System.Drawing.Color.Transparent;
            this.rbutTimex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutTimex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbutTimex.Location = new System.Drawing.Point(183, 186);
            this.rbutTimex.Name = "rbutTimex";
            this.rbutTimex.Size = new System.Drawing.Size(86, 26);
            this.rbutTimex.TabIndex = 21;
            this.rbutTimex.Text = "Timex";
            this.rbutTimex.UseVisualStyleBackColor = false;
            this.rbutTimex.CheckedChanged += new System.EventHandler(this.rbutTimex_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Brand";
            // 
            // Jumlah
            // 
            this.Jumlah.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jumlah.Location = new System.Drawing.Point(793, 238);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(73, 30);
            this.Jumlah.TabIndex = 23;
            this.Jumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDiskon
            // 
            this.labelDiskon.AutoSize = true;
            this.labelDiskon.BackColor = System.Drawing.Color.Transparent;
            this.labelDiskon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDiskon.Location = new System.Drawing.Point(416, 593);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(64, 22);
            this.labelDiskon.TabIndex = 24;
            this.labelDiskon.Text = "label5";
            // 
            // labelSetelahDiskon
            // 
            this.labelSetelahDiskon.AutoSize = true;
            this.labelSetelahDiskon.BackColor = System.Drawing.Color.Transparent;
            this.labelSetelahDiskon.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetelahDiskon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSetelahDiskon.Location = new System.Drawing.Point(567, 576);
            this.labelSetelahDiskon.Name = "labelSetelahDiskon";
            this.labelSetelahDiskon.Size = new System.Drawing.Size(148, 43);
            this.labelSetelahDiskon.TabIndex = 25;
            this.labelSetelahDiskon.Text = "label11";
            // 
            // buttonBackPenjualan
            // 
            this.buttonBackPenjualan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonBackPenjualan.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackPenjualan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackPenjualan.Location = new System.Drawing.Point(39, 571);
            this.buttonBackPenjualan.Name = "buttonBackPenjualan";
            this.buttonBackPenjualan.Size = new System.Drawing.Size(140, 48);
            this.buttonBackPenjualan.TabIndex = 26;
            this.buttonBackPenjualan.Text = "BACK";
            this.buttonBackPenjualan.UseVisualStyleBackColor = false;
            this.buttonBackPenjualan.Click += new System.EventHandler(this.buttonBackPenjualan_Click);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.BackColor = System.Drawing.Color.Transparent;
            this.labelHarga.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHarga.Location = new System.Drawing.Point(593, 240);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(96, 22);
            this.labelHarga.TabIndex = 27;
            this.labelHarga.Text = "price/pcs";
            // 
            // labelPersen
            // 
            this.labelPersen.AutoSize = true;
            this.labelPersen.BackColor = System.Drawing.Color.Transparent;
            this.labelPersen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPersen.Location = new System.Drawing.Point(346, 593);
            this.labelPersen.Name = "labelPersen";
            this.labelPersen.Size = new System.Drawing.Size(64, 22);
            this.labelPersen.TabIndex = 28;
            this.labelPersen.Text = "label5";
            // 
            // labeltotalBEFORE
            // 
            this.labeltotalBEFORE.AutoSize = true;
            this.labeltotalBEFORE.BackColor = System.Drawing.Color.Transparent;
            this.labeltotalBEFORE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalBEFORE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeltotalBEFORE.Location = new System.Drawing.Point(263, 550);
            this.labeltotalBEFORE.Name = "labeltotalBEFORE";
            this.labeltotalBEFORE.Size = new System.Drawing.Size(100, 22);
            this.labeltotalBEFORE.TabIndex = 29;
            this.labeltotalBEFORE.Text = "Total Price";
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalHarga.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHarga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalHarga.Location = new System.Drawing.Point(416, 550);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(64, 22);
            this.labelTotalHarga.TabIndex = 30;
            this.labelTotalHarga.Text = "label5";
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 668);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.labeltotalBEFORE);
            this.Controls.Add(this.labelPersen);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.buttonBackPenjualan);
            this.Controls.Add(this.labelSetelahDiskon);
            this.Controls.Add(this.labelDiskon);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbutTimex);
            this.Controls.Add(this.rbutLacoste);
            this.Controls.Add(this.rbutDW);
            this.Controls.Add(this.cboxNamaProduk);
            this.Controls.Add(this.tboxIDReseller);
            this.Controls.Add(this.dateTimePickerPenjualan);
            this.Controls.Add(this.dgvPenjualan);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.cboxNamaPembeli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxIDJual);
            this.DoubleBuffered = true;
            this.Name = "FormPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxIDJual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxNamaPembeli;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.DataGridView dgvPenjualan;
        private System.Windows.Forms.DateTimePicker dateTimePickerPenjualan;
        private System.Windows.Forms.TextBox tboxIDReseller;
        private System.Windows.Forms.ComboBox cboxNamaProduk;
        private System.Windows.Forms.RadioButton rbutDW;
        private System.Windows.Forms.RadioButton rbutLacoste;
        private System.Windows.Forms.RadioButton rbutTimex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Jumlah;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.Label labelSetelahDiskon;
        private System.Windows.Forms.Button buttonBackPenjualan;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelPersen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label labeltotalBEFORE;
        private System.Windows.Forms.Label labelTotalHarga;
    }
}