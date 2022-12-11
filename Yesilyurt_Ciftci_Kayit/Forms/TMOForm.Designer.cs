
namespace Yesilyurt_Ciftci_Kayit.Forms
{
    partial class TMOForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCiftciBilgi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFaturaTarihiAdd = new System.Windows.Forms.DateTimePicker();
            this.btnArpa = new System.Windows.Forms.Button();
            this.btnBugday = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtFaturaHarf = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFark1 = new System.Windows.Forms.CheckBox();
            this.checkBoxNormalDonem = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEvrakKayitTarihiAdd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtEvrakKayitNo = new System.Windows.Forms.TextBox();
            this.txtUpdateFaturaNo = new System.Windows.Forms.TextBox();
            this.txtUpdateAmount = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEvrakKayitTarihiUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFaturaTarihiUpdate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateEvrakKayitNo = new System.Windows.Forms.TextBox();
            this.txtNoteUpdate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.btnTumListe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKimlikNo.Location = new System.Drawing.Point(133, 16);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(170, 27);
            this.txtTcKimlikNo.TabIndex = 1;
            this.txtTcKimlikNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCiftciBilgi
            // 
            this.lblCiftciBilgi.AutoSize = true;
            this.lblCiftciBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiftciBilgi.Location = new System.Drawing.Point(14, 53);
            this.lblCiftciBilgi.Name = "lblCiftciBilgi";
            this.lblCiftciBilgi.Size = new System.Drawing.Size(23, 18);
            this.lblCiftciBilgi.TabIndex = 0;
            this.lblCiftciBilgi.Text = "...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 166);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fatura No:";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaNo.Location = new System.Drawing.Point(194, 91);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(91, 24);
            this.txtFaturaNo.TabIndex = 3;
            this.txtFaturaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fatura Tarihi:";
            // 
            // dateTimePickerFaturaTarihiAdd
            // 
            this.dateTimePickerFaturaTarihiAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerFaturaTarihiAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFaturaTarihiAdd.Location = new System.Drawing.Point(147, 121);
            this.dateTimePickerFaturaTarihiAdd.Name = "dateTimePickerFaturaTarihiAdd";
            this.dateTimePickerFaturaTarihiAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFaturaTarihiAdd.Size = new System.Drawing.Size(154, 24);
            this.dateTimePickerFaturaTarihiAdd.TabIndex = 4;
            // 
            // btnArpa
            // 
            this.btnArpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnArpa.Location = new System.Drawing.Point(253, 223);
            this.btnArpa.Name = "btnArpa";
            this.btnArpa.Size = new System.Drawing.Size(124, 40);
            this.btnArpa.TabIndex = 9;
            this.btnArpa.Text = "Arpa";
            this.btnArpa.UseVisualStyleBackColor = false;
            this.btnArpa.Click += new System.EventHandler(this.btnArpa_Click);
            // 
            // btnBugday
            // 
            this.btnBugday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBugday.Location = new System.Drawing.Point(383, 224);
            this.btnBugday.Name = "btnBugday";
            this.btnBugday.Size = new System.Drawing.Size(124, 40);
            this.btnBugday.TabIndex = 10;
            this.btnBugday.Text = "Buğday";
            this.btnBugday.UseVisualStyleBackColor = false;
            this.btnBugday.Click += new System.EventHandler(this.btnBugday_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Miktar";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(147, 151);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(88, 24);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFaturaHarf
            // 
            this.txtFaturaHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaHarf.Location = new System.Drawing.Point(147, 91);
            this.txtFaturaHarf.Name = "txtFaturaHarf";
            this.txtFaturaHarf.Size = new System.Drawing.Size(41, 24);
            this.txtFaturaHarf.TabIndex = 2;
            this.txtFaturaHarf.Text = "A";
            this.txtFaturaHarf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFark1);
            this.groupBox1.Controls.Add(this.checkBoxNormalDonem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerEvrakKayitTarihiAdd);
            this.groupBox1.Controls.Add(this.dateTimePickerFaturaTarihiAdd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBugday);
            this.groupBox1.Controls.Add(this.txtFaturaNo);
            this.groupBox1.Controls.Add(this.txtFaturaHarf);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.btnArpa);
            this.groupBox1.Controls.Add(this.txtEvrakKayitNo);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Location = new System.Drawing.Point(18, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 270);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt İşlemi";
            // 
            // checkBoxFark1
            // 
            this.checkBoxFark1.AutoSize = true;
            this.checkBoxFark1.Location = new System.Drawing.Point(152, 187);
            this.checkBoxFark1.Name = "checkBoxFark1";
            this.checkBoxFark1.Size = new System.Drawing.Size(76, 22);
            this.checkBoxFark1.TabIndex = 7;
            this.checkBoxFark1.Text = "1. Fark";
            this.checkBoxFark1.UseVisualStyleBackColor = true;
            // 
            // checkBoxNormalDonem
            // 
            this.checkBoxNormalDonem.AutoSize = true;
            this.checkBoxNormalDonem.Location = new System.Drawing.Point(6, 187);
            this.checkBoxNormalDonem.Name = "checkBoxNormalDonem";
            this.checkBoxNormalDonem.Size = new System.Drawing.Size(132, 22);
            this.checkBoxNormalDonem.TabIndex = 6;
            this.checkBoxNormalDonem.Text = "Normal Dönem";
            this.checkBoxNormalDonem.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEvrakKayitTarihiAdd
            // 
            this.dateTimePickerEvrakKayitTarihiAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerEvrakKayitTarihiAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEvrakKayitTarihiAdd.Location = new System.Drawing.Point(147, 61);
            this.dateTimePickerEvrakKayitTarihiAdd.Name = "dateTimePickerEvrakKayitTarihiAdd";
            this.dateTimePickerEvrakKayitTarihiAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerEvrakKayitTarihiAdd.Size = new System.Drawing.Size(154, 24);
            this.dateTimePickerEvrakKayitTarihiAdd.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(305, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Not:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Evrak Kayıt Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Evrak Kayıt No:";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNote.Location = new System.Drawing.Point(347, 27);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(146, 79);
            this.txtNote.TabIndex = 8;
            // 
            // txtEvrakKayitNo
            // 
            this.txtEvrakKayitNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEvrakKayitNo.Location = new System.Drawing.Point(147, 31);
            this.txtEvrakKayitNo.Name = "txtEvrakKayitNo";
            this.txtEvrakKayitNo.Size = new System.Drawing.Size(88, 24);
            this.txtEvrakKayitNo.TabIndex = 0;
            this.txtEvrakKayitNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUpdateFaturaNo
            // 
            this.txtUpdateFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateFaturaNo.Location = new System.Drawing.Point(147, 94);
            this.txtUpdateFaturaNo.Name = "txtUpdateFaturaNo";
            this.txtUpdateFaturaNo.Size = new System.Drawing.Size(154, 24);
            this.txtUpdateFaturaNo.TabIndex = 2;
            this.txtUpdateFaturaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUpdateAmount
            // 
            this.txtUpdateAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateAmount.Location = new System.Drawing.Point(147, 154);
            this.txtUpdateAmount.Name = "txtUpdateAmount";
            this.txtUpdateAmount.Size = new System.Drawing.Size(88, 24);
            this.txtUpdateAmount.TabIndex = 4;
            this.txtUpdateAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(371, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Kayıt Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fatura Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Miktar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fatura No:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(241, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePickerEvrakKayitTarihiUpdate);
            this.groupBox2.Controls.Add(this.dateTimePickerFaturaTarihiUpdate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtUpdateAmount);
            this.groupBox2.Controls.Add(this.txtUpdateFaturaNo);
            this.groupBox2.Controls.Add(this.txtUpdateEvrakKayitNo);
            this.groupBox2.Controls.Add(this.txtNoteUpdate);
            this.groupBox2.Location = new System.Drawing.Point(549, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncelleme işlemi";
            // 
            // dateTimePickerEvrakKayitTarihiUpdate
            // 
            this.dateTimePickerEvrakKayitTarihiUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerEvrakKayitTarihiUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEvrakKayitTarihiUpdate.Location = new System.Drawing.Point(147, 64);
            this.dateTimePickerEvrakKayitTarihiUpdate.Name = "dateTimePickerEvrakKayitTarihiUpdate";
            this.dateTimePickerEvrakKayitTarihiUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerEvrakKayitTarihiUpdate.Size = new System.Drawing.Size(154, 24);
            this.dateTimePickerEvrakKayitTarihiUpdate.TabIndex = 1;
            // 
            // dateTimePickerFaturaTarihiUpdate
            // 
            this.dateTimePickerFaturaTarihiUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerFaturaTarihiUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFaturaTarihiUpdate.Location = new System.Drawing.Point(147, 124);
            this.dateTimePickerFaturaTarihiUpdate.Name = "dateTimePickerFaturaTarihiUpdate";
            this.dateTimePickerFaturaTarihiUpdate.Size = new System.Drawing.Size(154, 24);
            this.dateTimePickerFaturaTarihiUpdate.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(315, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Not:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Evrak Kayıt Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Evrak Kayıt No:";
            // 
            // txtUpdateEvrakKayitNo
            // 
            this.txtUpdateEvrakKayitNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateEvrakKayitNo.Location = new System.Drawing.Point(147, 34);
            this.txtUpdateEvrakKayitNo.Name = "txtUpdateEvrakKayitNo";
            this.txtUpdateEvrakKayitNo.Size = new System.Drawing.Size(88, 24);
            this.txtUpdateEvrakKayitNo.TabIndex = 0;
            this.txtUpdateEvrakKayitNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNoteUpdate
            // 
            this.txtNoteUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNoteUpdate.Location = new System.Drawing.Point(360, 20);
            this.txtNoteUpdate.Multiline = true;
            this.txtNoteUpdate.Name = "txtNoteUpdate";
            this.txtNoteUpdate.Size = new System.Drawing.Size(146, 79);
            this.txtNoteUpdate.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(14, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1048, 189);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Location = new System.Drawing.Point(759, 563);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(145, 31);
            this.btnToExcel.TabIndex = 5;
            this.btnToExcel.Text = "Listeyi Excele Aktar";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // btnTumListe
            // 
            this.btnTumListe.Location = new System.Drawing.Point(914, 563);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(145, 31);
            this.btnTumListe.TabIndex = 6;
            this.btnTumListe.Text = "Tüm Liste Göster";
            this.btnTumListe.UseVisualStyleBackColor = true;
            this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yesilyurt_Ciftci_Kayit.Properties.Resources.tmo;
            this.pictureBox1.Location = new System.Drawing.Point(964, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(787, 12);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(20, 18);
            this.lblKisiSayisi.TabIndex = 0;
            this.lblKisiSayisi.Text = "...";
            // 
            // TMOForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTumListe);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTcKimlikNo);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCiftciBilgi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "TMOForm";
            this.Text = "TMOForm";
            this.Load += new System.EventHandler(this.TMOForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCiftciBilgi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnArpa;
        private System.Windows.Forms.Button btnBugday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtFaturaHarf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtEvrakKayitNo;
        private System.Windows.Forms.TextBox txtUpdateFaturaNo;
        private System.Windows.Forms.TextBox txtUpdateAmount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFaturaTarihiUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdateEvrakKayitNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNoteUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerFaturaTarihiAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvrakKayitTarihiAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvrakKayitTarihiUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.CheckBox checkBoxFark1;
        private System.Windows.Forms.CheckBox checkBoxNormalDonem;
        private System.Windows.Forms.Button btnTumListe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKisiSayisi;
    }
}