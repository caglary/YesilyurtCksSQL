namespace icmaller
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
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMgdToplamKisi = new System.Windows.Forms.Label();
            this.lblMgdToplamDestekTurar = new System.Windows.Forms.Label();
            this.lblFarkOdemesiToplamKisi = new System.Windows.Forms.Label();
            this.lblFarkOdemesiToplamDestekTutari = new System.Windows.Forms.Label();
            this.lblSertifikaliTohumToplamKisi = new System.Windows.Forms.Label();
            this.lblSertifikaliTohumToplamDestekTutari = new System.Windows.Forms.Label();
            this.lblYemBitkileriToplamKisi = new System.Windows.Forms.Label();
            this.lblYemBitkileriToplamDestekTutari = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblToplamDestek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(162, 10);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(196, 27);
            this.txtTc.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(364, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Maroon;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(628, 602);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(665, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "2023 Yılı MGD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(665, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "2023 Yılı Fark Ödemesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(665, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "2023 Yılı Sertifikali Tohum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(665, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "2023 Yılı Yem Bitkileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(690, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Toplam Kişi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(690, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Toplam Destek Miktarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(690, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Toplam Kişi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(690, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Toplam Destek Miktarı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(690, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Toplam Kişi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(690, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Toplam Destek Miktarı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(690, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Toplam Kişi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(690, 543);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Toplam Destek Miktarı:";
            // 
            // lblMgdToplamKisi
            // 
            this.lblMgdToplamKisi.AutoSize = true;
            this.lblMgdToplamKisi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMgdToplamKisi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMgdToplamKisi.Location = new System.Drawing.Point(905, 127);
            this.lblMgdToplamKisi.Name = "lblMgdToplamKisi";
            this.lblMgdToplamKisi.Size = new System.Drawing.Size(97, 18);
            this.lblMgdToplamKisi.TabIndex = 7;
            this.lblMgdToplamKisi.Text = "Toplam Kişi:";
            // 
            // lblMgdToplamDestekTurar
            // 
            this.lblMgdToplamDestekTurar.AutoSize = true;
            this.lblMgdToplamDestekTurar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMgdToplamDestekTurar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMgdToplamDestekTurar.Location = new System.Drawing.Point(905, 160);
            this.lblMgdToplamDestekTurar.Name = "lblMgdToplamDestekTurar";
            this.lblMgdToplamDestekTurar.Size = new System.Drawing.Size(97, 18);
            this.lblMgdToplamDestekTurar.TabIndex = 7;
            this.lblMgdToplamDestekTurar.Text = "Toplam Kişi:";
            // 
            // lblFarkOdemesiToplamKisi
            // 
            this.lblFarkOdemesiToplamKisi.AutoSize = true;
            this.lblFarkOdemesiToplamKisi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFarkOdemesiToplamKisi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFarkOdemesiToplamKisi.Location = new System.Drawing.Point(905, 251);
            this.lblFarkOdemesiToplamKisi.Name = "lblFarkOdemesiToplamKisi";
            this.lblFarkOdemesiToplamKisi.Size = new System.Drawing.Size(97, 18);
            this.lblFarkOdemesiToplamKisi.TabIndex = 7;
            this.lblFarkOdemesiToplamKisi.Text = "Toplam Kişi:";
            // 
            // lblFarkOdemesiToplamDestekTutari
            // 
            this.lblFarkOdemesiToplamDestekTutari.AutoSize = true;
            this.lblFarkOdemesiToplamDestekTutari.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFarkOdemesiToplamDestekTutari.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFarkOdemesiToplamDestekTutari.Location = new System.Drawing.Point(905, 284);
            this.lblFarkOdemesiToplamDestekTutari.Name = "lblFarkOdemesiToplamDestekTutari";
            this.lblFarkOdemesiToplamDestekTutari.Size = new System.Drawing.Size(97, 18);
            this.lblFarkOdemesiToplamDestekTutari.TabIndex = 7;
            this.lblFarkOdemesiToplamDestekTutari.Text = "Toplam Kişi:";
            // 
            // lblSertifikaliTohumToplamKisi
            // 
            this.lblSertifikaliTohumToplamKisi.AutoSize = true;
            this.lblSertifikaliTohumToplamKisi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSertifikaliTohumToplamKisi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSertifikaliTohumToplamKisi.Location = new System.Drawing.Point(905, 378);
            this.lblSertifikaliTohumToplamKisi.Name = "lblSertifikaliTohumToplamKisi";
            this.lblSertifikaliTohumToplamKisi.Size = new System.Drawing.Size(97, 18);
            this.lblSertifikaliTohumToplamKisi.TabIndex = 7;
            this.lblSertifikaliTohumToplamKisi.Text = "Toplam Kişi:";
            // 
            // lblSertifikaliTohumToplamDestekTutari
            // 
            this.lblSertifikaliTohumToplamDestekTutari.AutoSize = true;
            this.lblSertifikaliTohumToplamDestekTutari.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSertifikaliTohumToplamDestekTutari.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSertifikaliTohumToplamDestekTutari.Location = new System.Drawing.Point(905, 411);
            this.lblSertifikaliTohumToplamDestekTutari.Name = "lblSertifikaliTohumToplamDestekTutari";
            this.lblSertifikaliTohumToplamDestekTutari.Size = new System.Drawing.Size(97, 18);
            this.lblSertifikaliTohumToplamDestekTutari.TabIndex = 7;
            this.lblSertifikaliTohumToplamDestekTutari.Text = "Toplam Kişi:";
            // 
            // lblYemBitkileriToplamKisi
            // 
            this.lblYemBitkileriToplamKisi.AutoSize = true;
            this.lblYemBitkileriToplamKisi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYemBitkileriToplamKisi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblYemBitkileriToplamKisi.Location = new System.Drawing.Point(904, 510);
            this.lblYemBitkileriToplamKisi.Name = "lblYemBitkileriToplamKisi";
            this.lblYemBitkileriToplamKisi.Size = new System.Drawing.Size(97, 18);
            this.lblYemBitkileriToplamKisi.TabIndex = 7;
            this.lblYemBitkileriToplamKisi.Text = "Toplam Kişi:";
            // 
            // lblYemBitkileriToplamDestekTutari
            // 
            this.lblYemBitkileriToplamDestekTutari.AutoSize = true;
            this.lblYemBitkileriToplamDestekTutari.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYemBitkileriToplamDestekTutari.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblYemBitkileriToplamDestekTutari.Location = new System.Drawing.Point(904, 543);
            this.lblYemBitkileriToplamDestekTutari.Name = "lblYemBitkileriToplamDestekTutari";
            this.lblYemBitkileriToplamDestekTutari.Size = new System.Drawing.Size(97, 18);
            this.lblYemBitkileriToplamDestekTutari.TabIndex = 7;
            this.lblYemBitkileriToplamDestekTutari.Text = "Toplam Kişi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(665, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(320, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "2023 YILI VERİLEN DESTEKLERİN RAPORU";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "T.C. Kimlik No Giriniz.";
            // 
            // lblToplamDestek
            // 
            this.lblToplamDestek.AutoSize = true;
            this.lblToplamDestek.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamDestek.Location = new System.Drawing.Point(646, 611);
            this.lblToplamDestek.Name = "lblToplamDestek";
            this.lblToplamDestek.Size = new System.Drawing.Size(157, 16);
            this.lblToplamDestek.TabIndex = 7;
            this.lblToplamDestek.Text = "Toplam Destek Miktarı:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1090, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToplamDestek);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblYemBitkileriToplamDestekTutari);
            this.Controls.Add(this.lblYemBitkileriToplamKisi);
            this.Controls.Add(this.lblSertifikaliTohumToplamDestekTutari);
            this.Controls.Add(this.lblSertifikaliTohumToplamKisi);
            this.Controls.Add(this.lblFarkOdemesiToplamDestekTutari);
            this.Controls.Add(this.lblFarkOdemesiToplamKisi);
            this.Controls.Add(this.lblMgdToplamDestekTurar);
            this.Controls.Add(this.lblMgdToplamKisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMgdToplamKisi;
        private System.Windows.Forms.Label lblMgdToplamDestekTurar;
        private System.Windows.Forms.Label lblFarkOdemesiToplamKisi;
        private System.Windows.Forms.Label lblFarkOdemesiToplamDestekTutari;
        private System.Windows.Forms.Label lblSertifikaliTohumToplamKisi;
        private System.Windows.Forms.Label lblSertifikaliTohumToplamDestekTutari;
        private System.Windows.Forms.Label lblYemBitkileriToplamKisi;
        private System.Windows.Forms.Label lblYemBitkileriToplamDestekTutari;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblToplamDestek;
    }
}

