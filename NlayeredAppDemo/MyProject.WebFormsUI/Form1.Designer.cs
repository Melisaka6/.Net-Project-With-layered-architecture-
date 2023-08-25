namespace MyProject.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbx_kategori = new System.Windows.Forms.GroupBox();
            this.cbx_kategori = new System.Windows.Forms.ComboBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.gbx_urun = new System.Windows.Forms.GroupBox();
            this.txt_urun = new System.Windows.Forms.TextBox();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.gbxproduct_add = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbx_categoriadd = new System.Windows.Forms.ComboBox();
            this.txt_unitpcs = new System.Windows.Forms.TextBox();
            this.txt_stockquantity = new System.Windows.Forms.TextBox();
            this.txt_priceadd = new System.Windows.Forms.TextBox();
            this.txt_productadd = new System.Windows.Forms.TextBox();
            this.lbl_unitadd = new System.Windows.Forms.Label();
            this.lbl_stockadd = new System.Windows.Forms.Label();
            this.lbl_priceadd = new System.Windows.Forms.Label();
            this.lbl_categoryıdadd = new System.Windows.Forms.Label();
            this.lbl_productnameadd = new System.Windows.Forms.Label();
            this.gbx_update = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_Categorupdate = new System.Windows.Forms.ComboBox();
            this.txt_unitupdate = new System.Windows.Forms.TextBox();
            this.txt_stockupdate = new System.Windows.Forms.TextBox();
            this.txt_priceupdate = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_unitupdate = new System.Windows.Forms.Label();
            this.lbl_Stockupdate = new System.Windows.Forms.Label();
            this.lbl_priceupdate = new System.Windows.Forms.Label();
            this.lcl_Categoryupdate = new System.Windows.Forms.Label();
            this.lbl_productupdate = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbx_kategori.SuspendLayout();
            this.gbx_urun.SuspendLayout();
            this.gbxproduct_add.SuspendLayout();
            this.gbx_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(26, 192);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(863, 155);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbx_kategori
            // 
            this.gbx_kategori.Controls.Add(this.cbx_kategori);
            this.gbx_kategori.Controls.Add(this.lbl_kategori);
            this.gbx_kategori.Location = new System.Drawing.Point(36, 12);
            this.gbx_kategori.Name = "gbx_kategori";
            this.gbx_kategori.Size = new System.Drawing.Size(720, 84);
            this.gbx_kategori.TabIndex = 1;
            this.gbx_kategori.TabStop = false;
            this.gbx_kategori.Text = "Kategoriye Göre Ara";
            // 
            // cbx_kategori
            // 
            this.cbx_kategori.FormattingEnabled = true;
            this.cbx_kategori.Location = new System.Drawing.Point(115, 33);
            this.cbx_kategori.Name = "cbx_kategori";
            this.cbx_kategori.Size = new System.Drawing.Size(134, 21);
            this.cbx_kategori.TabIndex = 1;
            this.cbx_kategori.SelectedIndexChanged += new System.EventHandler(this.cbx_kategori_SelectedIndexChanged);
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Location = new System.Drawing.Point(35, 33);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(49, 13);
            this.lbl_kategori.TabIndex = 0;
            this.lbl_kategori.Text = "Kategori:";
            // 
            // gbx_urun
            // 
            this.gbx_urun.Controls.Add(this.txt_urun);
            this.gbx_urun.Controls.Add(this.lbl_urun);
            this.gbx_urun.Location = new System.Drawing.Point(36, 102);
            this.gbx_urun.Name = "gbx_urun";
            this.gbx_urun.Size = new System.Drawing.Size(720, 84);
            this.gbx_urun.TabIndex = 1;
            this.gbx_urun.TabStop = false;
            this.gbx_urun.Text = "Ürün Adına göre ara";
            // 
            // txt_urun
            // 
            this.txt_urun.Location = new System.Drawing.Point(115, 44);
            this.txt_urun.Name = "txt_urun";
            this.txt_urun.Size = new System.Drawing.Size(134, 20);
            this.txt_urun.TabIndex = 1;
            this.txt_urun.TextChanged += new System.EventHandler(this.txt_urun_TextChanged);
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Location = new System.Drawing.Point(35, 47);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(51, 13);
            this.lbl_urun.TabIndex = 0;
            this.lbl_urun.Text = "Ürün Adı:";
            // 
            // gbxproduct_add
            // 
            this.gbxproduct_add.Controls.Add(this.btn_add);
            this.gbxproduct_add.Controls.Add(this.cbx_categoriadd);
            this.gbxproduct_add.Controls.Add(this.txt_unitpcs);
            this.gbxproduct_add.Controls.Add(this.txt_stockquantity);
            this.gbxproduct_add.Controls.Add(this.txt_priceadd);
            this.gbxproduct_add.Controls.Add(this.txt_productadd);
            this.gbxproduct_add.Controls.Add(this.lbl_unitadd);
            this.gbxproduct_add.Controls.Add(this.lbl_stockadd);
            this.gbxproduct_add.Controls.Add(this.lbl_priceadd);
            this.gbxproduct_add.Controls.Add(this.lbl_categoryıdadd);
            this.gbxproduct_add.Controls.Add(this.lbl_productnameadd);
            this.gbxproduct_add.Location = new System.Drawing.Point(26, 369);
            this.gbxproduct_add.Name = "gbxproduct_add";
            this.gbxproduct_add.Size = new System.Drawing.Size(299, 250);
            this.gbxproduct_add.TabIndex = 2;
            this.gbxproduct_add.TabStop = false;
            this.gbxproduct_add.Text = "Yeni Ürün Ekle";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.IndianRed;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(203, 214);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 30);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "EKLE";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbx_categoriadd
            // 
            this.cbx_categoriadd.FormattingEnabled = true;
            this.cbx_categoriadd.Location = new System.Drawing.Point(97, 68);
            this.cbx_categoriadd.Name = "cbx_categoriadd";
            this.cbx_categoriadd.Size = new System.Drawing.Size(100, 21);
            this.cbx_categoriadd.TabIndex = 2;
            // 
            // txt_unitpcs
            // 
            this.txt_unitpcs.Location = new System.Drawing.Point(97, 191);
            this.txt_unitpcs.Name = "txt_unitpcs";
            this.txt_unitpcs.Size = new System.Drawing.Size(100, 20);
            this.txt_unitpcs.TabIndex = 1;
            // 
            // txt_stockquantity
            // 
            this.txt_stockquantity.Location = new System.Drawing.Point(97, 151);
            this.txt_stockquantity.Name = "txt_stockquantity";
            this.txt_stockquantity.Size = new System.Drawing.Size(100, 20);
            this.txt_stockquantity.TabIndex = 1;
            // 
            // txt_priceadd
            // 
            this.txt_priceadd.Location = new System.Drawing.Point(97, 110);
            this.txt_priceadd.Name = "txt_priceadd";
            this.txt_priceadd.Size = new System.Drawing.Size(100, 20);
            this.txt_priceadd.TabIndex = 1;
            // 
            // txt_productadd
            // 
            this.txt_productadd.Location = new System.Drawing.Point(97, 23);
            this.txt_productadd.Name = "txt_productadd";
            this.txt_productadd.Size = new System.Drawing.Size(100, 20);
            this.txt_productadd.TabIndex = 1;
            // 
            // lbl_unitadd
            // 
            this.lbl_unitadd.AutoSize = true;
            this.lbl_unitadd.Location = new System.Drawing.Point(19, 191);
            this.lbl_unitadd.Name = "lbl_unitadd";
            this.lbl_unitadd.Size = new System.Drawing.Size(59, 13);
            this.lbl_unitadd.TabIndex = 0;
            this.lbl_unitadd.Text = "Birim Adedi";
            // 
            // lbl_stockadd
            // 
            this.lbl_stockadd.AutoSize = true;
            this.lbl_stockadd.Location = new System.Drawing.Point(19, 154);
            this.lbl_stockadd.Name = "lbl_stockadd";
            this.lbl_stockadd.Size = new System.Drawing.Size(59, 13);
            this.lbl_stockadd.TabIndex = 0;
            this.lbl_stockadd.Text = "Stok Adedi";
            // 
            // lbl_priceadd
            // 
            this.lbl_priceadd.AutoSize = true;
            this.lbl_priceadd.Location = new System.Drawing.Point(19, 110);
            this.lbl_priceadd.Name = "lbl_priceadd";
            this.lbl_priceadd.Size = new System.Drawing.Size(29, 13);
            this.lbl_priceadd.TabIndex = 0;
            this.lbl_priceadd.Text = "Fiyat";
            // 
            // lbl_categoryıdadd
            // 
            this.lbl_categoryıdadd.AutoSize = true;
            this.lbl_categoryıdadd.Location = new System.Drawing.Point(19, 68);
            this.lbl_categoryıdadd.Name = "lbl_categoryıdadd";
            this.lbl_categoryıdadd.Size = new System.Drawing.Size(46, 13);
            this.lbl_categoryıdadd.TabIndex = 0;
            this.lbl_categoryıdadd.Text = "Kategori";
            // 
            // lbl_productnameadd
            // 
            this.lbl_productnameadd.AutoSize = true;
            this.lbl_productnameadd.Location = new System.Drawing.Point(19, 30);
            this.lbl_productnameadd.Name = "lbl_productnameadd";
            this.lbl_productnameadd.Size = new System.Drawing.Size(48, 13);
            this.lbl_productnameadd.TabIndex = 0;
            this.lbl_productnameadd.Text = "Ürün Adı";
            // 
            // gbx_update
            // 
            this.gbx_update.Controls.Add(this.btn_update);
            this.gbx_update.Controls.Add(this.txt_Categorupdate);
            this.gbx_update.Controls.Add(this.txt_unitupdate);
            this.gbx_update.Controls.Add(this.txt_stockupdate);
            this.gbx_update.Controls.Add(this.txt_priceupdate);
            this.gbx_update.Controls.Add(this.textBox4);
            this.gbx_update.Controls.Add(this.lbl_unitupdate);
            this.gbx_update.Controls.Add(this.lbl_Stockupdate);
            this.gbx_update.Controls.Add(this.lbl_priceupdate);
            this.gbx_update.Controls.Add(this.lcl_Categoryupdate);
            this.gbx_update.Controls.Add(this.lbl_productupdate);
            this.gbx_update.Location = new System.Drawing.Point(457, 369);
            this.gbx_update.Name = "gbx_update";
            this.gbx_update.Size = new System.Drawing.Size(299, 250);
            this.gbx_update.TabIndex = 2;
            this.gbx_update.TabStop = false;
            this.gbx_update.Text = "Ürün Güncelle";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.IndianRed;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(203, 214);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 30);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Categorupdate
            // 
            this.txt_Categorupdate.FormattingEnabled = true;
            this.txt_Categorupdate.Location = new System.Drawing.Point(97, 68);
            this.txt_Categorupdate.Name = "txt_Categorupdate";
            this.txt_Categorupdate.Size = new System.Drawing.Size(100, 21);
            this.txt_Categorupdate.TabIndex = 2;
            // 
            // txt_unitupdate
            // 
            this.txt_unitupdate.Location = new System.Drawing.Point(97, 191);
            this.txt_unitupdate.Name = "txt_unitupdate";
            this.txt_unitupdate.Size = new System.Drawing.Size(100, 20);
            this.txt_unitupdate.TabIndex = 1;
            // 
            // txt_stockupdate
            // 
            this.txt_stockupdate.Location = new System.Drawing.Point(97, 151);
            this.txt_stockupdate.Name = "txt_stockupdate";
            this.txt_stockupdate.Size = new System.Drawing.Size(100, 20);
            this.txt_stockupdate.TabIndex = 1;
            // 
            // txt_priceupdate
            // 
            this.txt_priceupdate.Location = new System.Drawing.Point(97, 110);
            this.txt_priceupdate.Name = "txt_priceupdate";
            this.txt_priceupdate.Size = new System.Drawing.Size(100, 20);
            this.txt_priceupdate.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // lbl_unitupdate
            // 
            this.lbl_unitupdate.AutoSize = true;
            this.lbl_unitupdate.Location = new System.Drawing.Point(19, 191);
            this.lbl_unitupdate.Name = "lbl_unitupdate";
            this.lbl_unitupdate.Size = new System.Drawing.Size(59, 13);
            this.lbl_unitupdate.TabIndex = 0;
            this.lbl_unitupdate.Text = "Birim Adedi";
            // 
            // lbl_Stockupdate
            // 
            this.lbl_Stockupdate.AutoSize = true;
            this.lbl_Stockupdate.Location = new System.Drawing.Point(19, 154);
            this.lbl_Stockupdate.Name = "lbl_Stockupdate";
            this.lbl_Stockupdate.Size = new System.Drawing.Size(59, 13);
            this.lbl_Stockupdate.TabIndex = 0;
            this.lbl_Stockupdate.Text = "Stok Adedi";
            // 
            // lbl_priceupdate
            // 
            this.lbl_priceupdate.AutoSize = true;
            this.lbl_priceupdate.Location = new System.Drawing.Point(19, 110);
            this.lbl_priceupdate.Name = "lbl_priceupdate";
            this.lbl_priceupdate.Size = new System.Drawing.Size(29, 13);
            this.lbl_priceupdate.TabIndex = 0;
            this.lbl_priceupdate.Text = "Fiyat";
            // 
            // lcl_Categoryupdate
            // 
            this.lcl_Categoryupdate.AutoSize = true;
            this.lcl_Categoryupdate.Location = new System.Drawing.Point(19, 68);
            this.lcl_Categoryupdate.Name = "lcl_Categoryupdate";
            this.lcl_Categoryupdate.Size = new System.Drawing.Size(46, 13);
            this.lcl_Categoryupdate.TabIndex = 0;
            this.lcl_Categoryupdate.Text = "Kategori";
            // 
            // lbl_productupdate
            // 
            this.lbl_productupdate.AutoSize = true;
            this.lbl_productupdate.Location = new System.Drawing.Point(19, 30);
            this.lbl_productupdate.Name = "lbl_productupdate";
            this.lbl_productupdate.Size = new System.Drawing.Size(48, 13);
            this.lbl_productupdate.TabIndex = 0;
            this.lbl_productupdate.Text = "Ürün Adı";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Orange;
            this.btn_sil.ForeColor = System.Drawing.Color.Black;
            this.btn_sil.Location = new System.Drawing.Point(785, 55);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(116, 60);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 632);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.gbx_update);
            this.Controls.Add(this.gbxproduct_add);
            this.Controls.Add(this.gbx_urun);
            this.Controls.Add(this.gbx_kategori);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbx_kategori.ResumeLayout(false);
            this.gbx_kategori.PerformLayout();
            this.gbx_urun.ResumeLayout(false);
            this.gbx_urun.PerformLayout();
            this.gbxproduct_add.ResumeLayout(false);
            this.gbxproduct_add.PerformLayout();
            this.gbx_update.ResumeLayout(false);
            this.gbx_update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbx_kategori;
        private System.Windows.Forms.ComboBox cbx_kategori;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.GroupBox gbx_urun;
        private System.Windows.Forms.TextBox txt_urun;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.GroupBox gbxproduct_add;
        private System.Windows.Forms.TextBox txt_productadd;
        private System.Windows.Forms.Label lbl_unitadd;
        private System.Windows.Forms.Label lbl_stockadd;
        private System.Windows.Forms.Label lbl_priceadd;
        private System.Windows.Forms.Label lbl_categoryıdadd;
        private System.Windows.Forms.Label lbl_productnameadd;
        private System.Windows.Forms.ComboBox cbx_categoriadd;
        private System.Windows.Forms.TextBox txt_unitpcs;
        private System.Windows.Forms.TextBox txt_stockquantity;
        private System.Windows.Forms.TextBox txt_priceadd;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox gbx_update;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox txt_Categorupdate;
        private System.Windows.Forms.TextBox txt_unitupdate;
        private System.Windows.Forms.TextBox txt_stockupdate;
        private System.Windows.Forms.TextBox txt_priceupdate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_unitupdate;
        private System.Windows.Forms.Label lbl_Stockupdate;
        private System.Windows.Forms.Label lbl_priceupdate;
        private System.Windows.Forms.Label lcl_Categoryupdate;
        private System.Windows.Forms.Label lbl_productupdate;
        private System.Windows.Forms.Button btn_sil;
    }
}

