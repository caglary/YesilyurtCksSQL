
namespace Yesilyurt_Ciftci_Kayit.Forms
{
    partial class UrunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunAdiGuncelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUrunCesidiGuncelle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdiEkle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunCesidiEkle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwListe);
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(380, 200);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Listesi";
            // 
            // dgwListe
            // 
            this.dgwListe.AllowUserToAddRows = false;
            this.dgwListe.AllowUserToDeleteRows = false;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwListe.Location = new System.Drawing.Point(3, 17);
            this.dgwListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.ReadOnly = true;
            this.dgwListe.RowHeadersWidth = 51;
            this.dgwListe.RowTemplate.Height = 24;
            this.dgwListe.Size = new System.Drawing.Size(374, 181);
            this.dgwListe.TabIndex = 0;
            this.dgwListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListe_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUrunAdiGuncelle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtUrunCesidiGuncelle);
            this.groupBox2.Location = new System.Drawing.Point(400, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(380, 200);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelleme İşlemleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün Adı:";
            // 
            // txtUrunAdiGuncelle
            // 
            this.txtUrunAdiGuncelle.Location = new System.Drawing.Point(135, 56);
            this.txtUrunAdiGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAdiGuncelle.Name = "txtUrunAdiGuncelle";
            this.txtUrunAdiGuncelle.Size = new System.Drawing.Size(201, 22);
            this.txtUrunAdiGuncelle.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Çeşidi:";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(135, 135);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(229, 135);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 39);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUrunCesidiGuncelle
            // 
            this.txtUrunCesidiGuncelle.Location = new System.Drawing.Point(135, 84);
            this.txtUrunCesidiGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunCesidiGuncelle.Name = "txtUrunCesidiGuncelle";
            this.txtUrunCesidiGuncelle.Size = new System.Drawing.Size(201, 22);
            this.txtUrunCesidiGuncelle.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUrunAdiEkle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUrunCesidiEkle);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(14, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(380, 200);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekleme İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtUrunAdiEkle
            // 
            this.txtUrunAdiEkle.Location = new System.Drawing.Point(135, 61);
            this.txtUrunAdiEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAdiEkle.Name = "txtUrunAdiEkle";
            this.txtUrunAdiEkle.Size = new System.Drawing.Size(201, 22);
            this.txtUrunAdiEkle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Çeşidi:";
            // 
            // txtUrunCesidiEkle
            // 
            this.txtUrunCesidiEkle.Location = new System.Drawing.Point(135, 89);
            this.txtUrunCesidiEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunCesidiEkle.Name = "txtUrunCesidiEkle";
            this.txtUrunCesidiEkle.Size = new System.Drawing.Size(201, 22);
            this.txtUrunCesidiEkle.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(244, 135);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UrunForm";
            this.Text = "Ürün Form ";
            this.Load += new System.EventHandler(this.UrunForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrunAdiGuncelle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUrunCesidiGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdiEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunCesidiEkle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}