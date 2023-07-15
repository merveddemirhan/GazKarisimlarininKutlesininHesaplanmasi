namespace GazKarisimlarininKutlesininHesaplanmasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwElement = new System.Windows.Forms.DataGridView();
            this.gbxEkran = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxortamHacim = new System.Windows.Forms.TextBox();
            this.lblortamHacim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAtomAgirligi = new System.Windows.Forms.Label();
            this.lblElementNo = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblHacim = new System.Windows.Forms.Label();
            this.tbxHacim = new System.Windows.Forms.TextBox();
            this.tbxElementAdi = new System.Windows.Forms.TextBox();
            this.lblElementSembolu = new System.Windows.Forms.Label();
            this.tbxElementSembolu = new System.Windows.Forms.TextBox();
            this.tbxMolSayısı = new System.Windows.Forms.TextBox();
            this.tbxElementNo = new System.Windows.Forms.TextBox();
            this.lblMolSayisi = new System.Windows.Forms.Label();
            this.tbxElementAtomAgirligi = new System.Windows.Forms.TextBox();
            this.btnHesap = new System.Windows.Forms.Button();
            this.gbxCıktı = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCıktı = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElement)).BeginInit();
            this.gbxEkran.SuspendLayout();
            this.gbxCıktı.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearch.ForeColor = System.Drawing.Color.White;
            this.gbxSearch.Location = new System.Drawing.Point(0, 14);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearch.Size = new System.Drawing.Size(886, 70);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Element Adina Göre Listele";
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.tbxSearch.ForeColor = System.Drawing.Color.Gray;
            this.tbxSearch.Location = new System.Drawing.Point(112, 31);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(112, 27);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(7, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(99, 34);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ara";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwElement
            // 
            this.dgwElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwElement.Location = new System.Drawing.Point(0, 91);
            this.dgwElement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwElement.Name = "dgwElement";
            this.dgwElement.RowHeadersWidth = 51;
            this.dgwElement.RowTemplate.Height = 24;
            this.dgwElement.Size = new System.Drawing.Size(890, 176);
            this.dgwElement.TabIndex = 1;
            this.dgwElement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwElement_CellClick);
            // 
            // gbxEkran
            // 
            this.gbxEkran.Controls.Add(this.groupBox1);
            this.gbxEkran.Controls.Add(this.tbxortamHacim);
            this.gbxEkran.Controls.Add(this.lblortamHacim);
            this.gbxEkran.Controls.Add(this.label2);
            this.gbxEkran.Controls.Add(this.lblAtomAgirligi);
            this.gbxEkran.Controls.Add(this.lblElementNo);
            this.gbxEkran.Controls.Add(this.btnEkle);
            this.gbxEkran.Controls.Add(this.lblHacim);
            this.gbxEkran.Controls.Add(this.tbxHacim);
            this.gbxEkran.Controls.Add(this.tbxElementAdi);
            this.gbxEkran.Controls.Add(this.lblElementSembolu);
            this.gbxEkran.Controls.Add(this.tbxElementSembolu);
            this.gbxEkran.Controls.Add(this.tbxMolSayısı);
            this.gbxEkran.Controls.Add(this.tbxElementNo);
            this.gbxEkran.Controls.Add(this.lblMolSayisi);
            this.gbxEkran.Controls.Add(this.tbxElementAtomAgirligi);
            this.gbxEkran.Controls.Add(this.btnHesap);
            this.gbxEkran.Location = new System.Drawing.Point(14, 275);
            this.gbxEkran.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEkran.Name = "gbxEkran";
            this.gbxEkran.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEkran.Size = new System.Drawing.Size(680, 246);
            this.gbxEkran.TabIndex = 2;
            this.gbxEkran.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(790, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(83, 97);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbxortamHacim
            // 
            this.tbxortamHacim.Location = new System.Drawing.Point(168, 28);
            this.tbxortamHacim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxortamHacim.Name = "tbxortamHacim";
            this.tbxortamHacim.Size = new System.Drawing.Size(112, 27);
            this.tbxortamHacim.TabIndex = 18;
            this.tbxortamHacim.TextChanged += new System.EventHandler(this.tbxYogunluk_TextChanged);
            // 
            // lblortamHacim
            // 
            this.lblortamHacim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblortamHacim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblortamHacim.Location = new System.Drawing.Point(35, 15);
            this.lblortamHacim.Name = "lblortamHacim";
            this.lblortamHacim.Size = new System.Drawing.Size(108, 40);
            this.lblortamHacim.TabIndex = 17;
            this.lblortamHacim.Text = "Toplam Hacim(NM3):";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Element Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtomAgirligi
            // 
            this.lblAtomAgirligi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAtomAgirligi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAtomAgirligi.Location = new System.Drawing.Point(369, 24);
            this.lblAtomAgirligi.Name = "lblAtomAgirligi";
            this.lblAtomAgirligi.Size = new System.Drawing.Size(130, 55);
            this.lblAtomAgirligi.TabIndex = 4;
            this.lblAtomAgirligi.Text = "Element Atom Ağırlığı:";
            this.lblAtomAgirligi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblElementNo
            // 
            this.lblElementNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblElementNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElementNo.Location = new System.Drawing.Point(35, 70);
            this.lblElementNo.Name = "lblElementNo";
            this.lblElementNo.Size = new System.Drawing.Size(108, 31);
            this.lblElementNo.TabIndex = 0;
            this.lblElementNo.Text = "Element No:";
            this.lblElementNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(508, 192);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(132, 38);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Molekül Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblHacim
            // 
            this.lblHacim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHacim.CausesValidation = false;
            this.lblHacim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHacim.Location = new System.Drawing.Point(369, 138);
            this.lblHacim.Name = "lblHacim";
            this.lblHacim.Size = new System.Drawing.Size(130, 40);
            this.lblHacim.TabIndex = 12;
            this.lblHacim.Text = "Hacim Oranları(%):";
            this.lblHacim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHacim
            // 
            this.tbxHacim.Location = new System.Drawing.Point(528, 146);
            this.tbxHacim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHacim.Name = "tbxHacim";
            this.tbxHacim.Size = new System.Drawing.Size(112, 27);
            this.tbxHacim.TabIndex = 13;
            // 
            // tbxElementAdi
            // 
            this.tbxElementAdi.Location = new System.Drawing.Point(168, 168);
            this.tbxElementAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxElementAdi.Name = "tbxElementAdi";
            this.tbxElementAdi.Size = new System.Drawing.Size(112, 27);
            this.tbxElementAdi.TabIndex = 9;
            // 
            // lblElementSembolu
            // 
            this.lblElementSembolu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblElementSembolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblElementSembolu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElementSembolu.ForeColor = System.Drawing.Color.Black;
            this.lblElementSembolu.Location = new System.Drawing.Point(35, 111);
            this.lblElementSembolu.Name = "lblElementSembolu";
            this.lblElementSembolu.Size = new System.Drawing.Size(108, 50);
            this.lblElementSembolu.TabIndex = 2;
            this.lblElementSembolu.Text = "Element Sembolü:";
            this.lblElementSembolu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxElementSembolu
            // 
            this.tbxElementSembolu.Location = new System.Drawing.Point(168, 111);
            this.tbxElementSembolu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxElementSembolu.Name = "tbxElementSembolu";
            this.tbxElementSembolu.Size = new System.Drawing.Size(112, 27);
            this.tbxElementSembolu.TabIndex = 3;
            // 
            // tbxMolSayısı
            // 
            this.tbxMolSayısı.Location = new System.Drawing.Point(528, 97);
            this.tbxMolSayısı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxMolSayısı.Name = "tbxMolSayısı";
            this.tbxMolSayısı.Size = new System.Drawing.Size(112, 27);
            this.tbxMolSayısı.TabIndex = 7;
            // 
            // tbxElementNo
            // 
            this.tbxElementNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxElementNo.Location = new System.Drawing.Point(168, 75);
            this.tbxElementNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxElementNo.Name = "tbxElementNo";
            this.tbxElementNo.Size = new System.Drawing.Size(116, 25);
            this.tbxElementNo.TabIndex = 1;
            this.tbxElementNo.TextChanged += new System.EventHandler(this.tbxElementNo_TextChanged);
            // 
            // lblMolSayisi
            // 
            this.lblMolSayisi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMolSayisi.Cursor = System.Windows.Forms.Cursors.No;
            this.lblMolSayisi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMolSayisi.Location = new System.Drawing.Point(369, 94);
            this.lblMolSayisi.Name = "lblMolSayisi";
            this.lblMolSayisi.Size = new System.Drawing.Size(130, 31);
            this.lblMolSayisi.TabIndex = 6;
            this.lblMolSayisi.Text = "Mol Sayısı:";
            this.lblMolSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxElementAtomAgirligi
            // 
            this.tbxElementAtomAgirligi.Location = new System.Drawing.Point(528, 35);
            this.tbxElementAtomAgirligi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxElementAtomAgirligi.Name = "tbxElementAtomAgirligi";
            this.tbxElementAtomAgirligi.Size = new System.Drawing.Size(112, 27);
            this.tbxElementAtomAgirligi.TabIndex = 5;
            // 
            // btnHesap
            // 
            this.btnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.Location = new System.Drawing.Point(190, 203);
            this.btnHesap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(90, 38);
            this.btnHesap.TabIndex = 10;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // gbxCıktı
            // 
            this.gbxCıktı.BackgroundImage = global::GazKarisimlarininKutlesininHesaplanmasi.Properties.Resources.about;
            this.gbxCıktı.Controls.Add(this.lbl_result);
            this.gbxCıktı.Controls.Add(this.label1);
            this.gbxCıktı.Controls.Add(this.lblCıktı);
            this.gbxCıktı.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxCıktı.Location = new System.Drawing.Point(711, 275);
            this.gbxCıktı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCıktı.Name = "gbxCıktı";
            this.gbxCıktı.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCıktı.Size = new System.Drawing.Size(176, 238);
            this.gbxCıktı.TabIndex = 3;
            this.gbxCıktı.TabStop = false;
            this.gbxCıktı.Enter += new System.EventHandler(this.gbxCıktı_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kg";
            // 
            // lblCıktı
            // 
            this.lblCıktı.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCıktı.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCıktı.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCıktı.Location = new System.Drawing.Point(3, 75);
            this.lblCıktı.Name = "lblCıktı";
            this.lblCıktı.Size = new System.Drawing.Size(168, 54);
            this.lblCıktı.TabIndex = 0;
            // 
            // lbl_result
            // 
            this.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_result.Location = new System.Drawing.Point(3, 24);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(167, 45);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "Toplam Gaz Ağırlığı(kg):";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GazKarisimlarininKutlesininHesaplanmasi.Properties.Resources.policy;
            this.ClientSize = new System.Drawing.Size(902, 534);
            this.Controls.Add(this.gbxCıktı);
            this.Controls.Add(this.gbxEkran);
            this.Controls.Add(this.dgwElement);
            this.Controls.Add(this.gbxSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Gaz Karışımlarının Ağırlığının Hesaplanması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElement)).EndInit();
            this.gbxEkran.ResumeLayout(false);
            this.gbxEkran.PerformLayout();
            this.gbxCıktı.ResumeLayout(false);
            this.gbxCıktı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwElement;
        private System.Windows.Forms.GroupBox gbxEkran;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.TextBox tbxElementAdi;
        private System.Windows.Forms.TextBox tbxMolSayısı;
        private System.Windows.Forms.Label lblMolSayisi;
        private System.Windows.Forms.TextBox tbxElementAtomAgirligi;
        private System.Windows.Forms.Label lblAtomAgirligi;
        private System.Windows.Forms.TextBox tbxElementSembolu;
        private System.Windows.Forms.Label lblElementSembolu;
        private System.Windows.Forms.TextBox tbxElementNo;
        private System.Windows.Forms.Label lblElementNo;
        private System.Windows.Forms.TextBox tbxHacim;
        private System.Windows.Forms.Label lblHacim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxortamHacim;
        private System.Windows.Forms.Label lblortamHacim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxCıktı;
        private System.Windows.Forms.Label lblCıktı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_result;
    }
}

