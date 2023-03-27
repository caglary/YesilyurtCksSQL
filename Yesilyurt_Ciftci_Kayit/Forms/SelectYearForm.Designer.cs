namespace Yesilyurt_Ciftci_Kayit.Forms
{
    partial class SelectYearForm
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
            this.btn_2021 = new System.Windows.Forms.Button();
            this.btn_2022 = new System.Windows.Forms.Button();
            this.btn_2023 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_2021
            // 
            this.btn_2021.Location = new System.Drawing.Point(12, 63);
            this.btn_2021.Name = "btn_2021";
            this.btn_2021.Size = new System.Drawing.Size(100, 73);
            this.btn_2021.TabIndex = 0;
            this.btn_2021.Text = "2021";
            this.btn_2021.UseVisualStyleBackColor = true;
            this.btn_2021.Click += new System.EventHandler(this.btn_2021_Click);
            // 
            // btn_2022
            // 
            this.btn_2022.Location = new System.Drawing.Point(118, 63);
            this.btn_2022.Name = "btn_2022";
            this.btn_2022.Size = new System.Drawing.Size(100, 73);
            this.btn_2022.TabIndex = 0;
            this.btn_2022.Text = "2022";
            this.btn_2022.UseVisualStyleBackColor = true;
            this.btn_2022.Click += new System.EventHandler(this.btn_2022_Click);
            // 
            // btn_2023
            // 
            this.btn_2023.Location = new System.Drawing.Point(224, 63);
            this.btn_2023.Name = "btn_2023";
            this.btn_2023.Size = new System.Drawing.Size(100, 73);
            this.btn_2023.TabIndex = 0;
            this.btn_2023.Text = "2023";
            this.btn_2023.UseVisualStyleBackColor = true;
            this.btn_2023.Click += new System.EventHandler(this.btn_2023_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hangi yıl için çalışmak istiyor sunuz?";
            // 
            // SelectYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 157);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_2023);
            this.Controls.Add(this.btn_2022);
            this.Controls.Add(this.btn_2021);
            this.Name = "SelectYearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectYearForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_2021;
        private System.Windows.Forms.Button btn_2022;
        private System.Windows.Forms.Button btn_2023;
        private System.Windows.Forms.Label label1;
    }
}