
namespace Yesilyurt_Ciftci_Kayit.Forms
{
    partial class ListelerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListelerForm));
            this.btnSertifikaliTohumDestegi = new System.Windows.Forms.Button();
            this.btnFarkOdemesiDestegi = new System.Windows.Forms.Button();
            this.btnYemBitkisiDestegi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchByDosyaNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchByTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCksListesi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.groupBoxYemKontrolDurumu = new System.Windows.Forms.GroupBox();
            this.radioButtonAraziKontrolEdilmedi = new System.Windows.Forms.RadioButton();
            this.radioButtonUygunDegil = new System.Windows.Forms.RadioButton();
            this.radioButtonUygun = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxYemKontrolDurumu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSertifikaliTohumDestegi
            // 
            this.btnSertifikaliTohumDestegi.Image = ((System.Drawing.Image)(resources.GetObject("btnSertifikaliTohumDestegi.Image")));
            this.btnSertifikaliTohumDestegi.Location = new System.Drawing.Point(301, 38);
            this.btnSertifikaliTohumDestegi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSertifikaliTohumDestegi.Name = "btnSertifikaliTohumDestegi";
            this.btnSertifikaliTohumDestegi.Size = new System.Drawing.Size(129, 91);
            this.btnSertifikaliTohumDestegi.TabIndex = 5;
            this.btnSertifikaliTohumDestegi.Text = "Sertifikali Tohum Desteği";
            this.btnSertifikaliTohumDestegi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSertifikaliTohumDestegi.UseVisualStyleBackColor = true;
            this.btnSertifikaliTohumDestegi.Click += new System.EventHandler(this.btnSertifikaliTohumDestegi_Click);
            // 
            // btnFarkOdemesiDestegi
            // 
            this.btnFarkOdemesiDestegi.Image = ((System.Drawing.Image)(resources.GetObject("btnFarkOdemesiDestegi.Image")));
            this.btnFarkOdemesiDestegi.Location = new System.Drawing.Point(167, 38);
            this.btnFarkOdemesiDestegi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFarkOdemesiDestegi.Name = "btnFarkOdemesiDestegi";
            this.btnFarkOdemesiDestegi.Size = new System.Drawing.Size(129, 91);
            this.btnFarkOdemesiDestegi.TabIndex = 4;
            this.btnFarkOdemesiDestegi.Text = "Fark Ödemesi Desteği";
            this.btnFarkOdemesiDestegi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFarkOdemesiDestegi.UseVisualStyleBackColor = true;
            this.btnFarkOdemesiDestegi.Click += new System.EventHandler(this.btnFarkOdemesiDestegi_Click);
            // 
            // btnYemBitkisiDestegi
            // 
            this.btnYemBitkisiDestegi.Image = ((System.Drawing.Image)(resources.GetObject("btnYemBitkisiDestegi.Image")));
            this.btnYemBitkisiDestegi.Location = new System.Drawing.Point(32, 38);
            this.btnYemBitkisiDestegi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYemBitkisiDestegi.Name = "btnYemBitkisiDestegi";
            this.btnYemBitkisiDestegi.Size = new System.Drawing.Size(129, 91);
            this.btnYemBitkisiDestegi.TabIndex = 3;
            this.btnYemBitkisiDestegi.Text = "Yem Bitkisi Desteği";
            this.btnYemBitkisiDestegi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYemBitkisiDestegi.UseVisualStyleBackColor = true;
            this.btnYemBitkisiDestegi.Click += new System.EventHandler(this.btnYemBitkisiDestegi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwListe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 272);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 404);
            this.panel1.TabIndex = 6;
            // 
            // dgwListe
            // 
            this.dgwListe.AllowUserToAddRows = false;
            this.dgwListe.AllowUserToDeleteRows = false;
            this.dgwListe.BackgroundColor = System.Drawing.Color.White;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwListe.Location = new System.Drawing.Point(0, 0);
            this.dgwListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.ReadOnly = true;
            this.dgwListe.RowHeadersWidth = 51;
            this.dgwListe.RowTemplate.Height = 24;
            this.dgwListe.Size = new System.Drawing.Size(1235, 404);
            this.dgwListe.TabIndex = 0;
            this.dgwListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListe_CellClick);
            this.dgwListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListe_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearchByDosyaNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchByTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchByName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(503, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listede içerisinde arama işlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dosya No ile Arama";
            // 
            // txtSearchByDosyaNo
            // 
            this.txtSearchByDosyaNo.Location = new System.Drawing.Point(283, 107);
            this.txtSearchByDosyaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByDosyaNo.Name = "txtSearchByDosyaNo";
            this.txtSearchByDosyaNo.Size = new System.Drawing.Size(209, 22);
            this.txtSearchByDosyaNo.TabIndex = 0;
            this.txtSearchByDosyaNo.TextChanged += new System.EventHandler(this.txtSearchByDosyaNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc Kimlik No ile Arama";
            // 
            // txtSearchByTc
            // 
            this.txtSearchByTc.Location = new System.Drawing.Point(283, 71);
            this.txtSearchByTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByTc.Name = "txtSearchByTc";
            this.txtSearchByTc.Size = new System.Drawing.Size(209, 22);
            this.txtSearchByTc.TabIndex = 0;
            this.txtSearchByTc.TextChanged += new System.EventHandler(this.txtSearchByTc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim Soyisim ile Arama";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(283, 34);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(209, 22);
            this.txtSearchByName.TabIndex = 0;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(12, 176);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(195, 57);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Listeyi Excele Aktar";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCksListesi
            // 
            this.btnCksListesi.Image = ((System.Drawing.Image)(resources.GetObject("btnCksListesi.Image")));
            this.btnCksListesi.Location = new System.Drawing.Point(437, 38);
            this.btnCksListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCksListesi.Name = "btnCksListesi";
            this.btnCksListesi.Size = new System.Drawing.Size(129, 91);
            this.btnCksListesi.TabIndex = 5;
            this.btnCksListesi.Text = "ÇKS Listesi";
            this.btnCksListesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCksListesi.UseVisualStyleBackColor = true;
            this.btnCksListesi.Click += new System.EventHandler(this.btnCksListesi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(27, -5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(491, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Görmek istediğiniz listeye ait butona tıklayınız.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnYemBitkisiDestegi);
            this.groupBox2.Controls.Add(this.btnFarkOdemesiDestegi);
            this.groupBox2.Controls.Add(this.btnCksListesi);
            this.groupBox2.Controls.Add(this.btnSertifikaliTohumDestegi);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(613, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(607, 159);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitSayisi.ForeColor = System.Drawing.Color.Sienna;
            this.lblKayitSayisi.Location = new System.Drawing.Point(25, 247);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(22, 23);
            this.lblKayitSayisi.TabIndex = 1;
            this.lblKayitSayisi.Text = "--";
            // 
            // groupBoxYemKontrolDurumu
            // 
            this.groupBoxYemKontrolDurumu.Controls.Add(this.radioButtonAraziKontrolEdilmedi);
            this.groupBoxYemKontrolDurumu.Controls.Add(this.radioButtonUygunDegil);
            this.groupBoxYemKontrolDurumu.Controls.Add(this.radioButtonUygun);
            this.groupBoxYemKontrolDurumu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxYemKontrolDurumu.Location = new System.Drawing.Point(613, 176);
            this.groupBoxYemKontrolDurumu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxYemKontrolDurumu.Name = "groupBoxYemKontrolDurumu";
            this.groupBoxYemKontrolDurumu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxYemKontrolDurumu.Size = new System.Drawing.Size(467, 78);
            this.groupBoxYemKontrolDurumu.TabIndex = 9;
            this.groupBoxYemKontrolDurumu.TabStop = false;
            this.groupBoxYemKontrolDurumu.Text = "Kontrol Durumu";
            // 
            // radioButtonAraziKontrolEdilmedi
            // 
            this.radioButtonAraziKontrolEdilmedi.AutoSize = true;
            this.radioButtonAraziKontrolEdilmedi.Location = new System.Drawing.Point(271, 33);
            this.radioButtonAraziKontrolEdilmedi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAraziKontrolEdilmedi.Name = "radioButtonAraziKontrolEdilmedi";
            this.radioButtonAraziKontrolEdilmedi.Size = new System.Drawing.Size(180, 24);
            this.radioButtonAraziKontrolEdilmedi.TabIndex = 2;
            this.radioButtonAraziKontrolEdilmedi.TabStop = true;
            this.radioButtonAraziKontrolEdilmedi.Text = "Arazi Kontrol Edilmedi";
            this.radioButtonAraziKontrolEdilmedi.UseVisualStyleBackColor = true;
            this.radioButtonAraziKontrolEdilmedi.Click += new System.EventHandler(this.radioButtonAraziKontrolEdilmedi_Click);
            // 
            // radioButtonUygunDegil
            // 
            this.radioButtonUygunDegil.AutoSize = true;
            this.radioButtonUygunDegil.Location = new System.Drawing.Point(135, 33);
            this.radioButtonUygunDegil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUygunDegil.Name = "radioButtonUygunDegil";
            this.radioButtonUygunDegil.Size = new System.Drawing.Size(112, 24);
            this.radioButtonUygunDegil.TabIndex = 1;
            this.radioButtonUygunDegil.TabStop = true;
            this.radioButtonUygunDegil.Text = "Uygun Değil";
            this.radioButtonUygunDegil.UseVisualStyleBackColor = true;
            this.radioButtonUygunDegil.Click += new System.EventHandler(this.radioButtonUygunDegil_Click);
            // 
            // radioButtonUygun
            // 
            this.radioButtonUygun.AutoSize = true;
            this.radioButtonUygun.Location = new System.Drawing.Point(37, 32);
            this.radioButtonUygun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUygun.Name = "radioButtonUygun";
            this.radioButtonUygun.Size = new System.Drawing.Size(72, 24);
            this.radioButtonUygun.TabIndex = 0;
            this.radioButtonUygun.TabStop = true;
            this.radioButtonUygun.Text = "Uygun";
            this.radioButtonUygun.UseVisualStyleBackColor = true;
            this.radioButtonUygun.Click += new System.EventHandler(this.radioButtonUygun_Click);
            // 
            // ListelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 676);
            this.Controls.Add(this.groupBoxYemKontrolDurumu);
            this.Controls.Add(this.lblKayitSayisi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListelerForm";
            this.Text = "Listeler";
            this.Load += new System.EventHandler(this.ListelerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxYemKontrolDurumu.ResumeLayout(false);
            this.groupBoxYemKontrolDurumu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSertifikaliTohumDestegi;
        private System.Windows.Forms.Button btnFarkOdemesiDestegi;
        private System.Windows.Forms.Button btnYemBitkisiDestegi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchByDosyaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchByTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCksListesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.GroupBox groupBoxYemKontrolDurumu;
        private System.Windows.Forms.RadioButton radioButtonAraziKontrolEdilmedi;
        private System.Windows.Forms.RadioButton radioButtonUygunDegil;
        private System.Windows.Forms.RadioButton radioButtonUygun;
    }
}