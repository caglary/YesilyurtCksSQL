namespace Yesilyurt_Ciftci_Kayit.Forms
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.btn_2024 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_2021
            // 
            this.btn_2021.Location = new System.Drawing.Point(12, 12);
            this.btn_2021.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2021.Name = "btn_2021";
            this.btn_2021.Size = new System.Drawing.Size(100, 73);
            this.btn_2021.TabIndex = 0;
            this.btn_2021.Text = "2021";
            this.btn_2021.UseVisualStyleBackColor = true;
            this.btn_2021.Click += new System.EventHandler(this.btn_2021_Click);
            // 
            // btn_2022
            // 
            this.btn_2022.Location = new System.Drawing.Point(117, 12);
            this.btn_2022.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2022.Name = "btn_2022";
            this.btn_2022.Size = new System.Drawing.Size(100, 73);
            this.btn_2022.TabIndex = 0;
            this.btn_2022.Text = "2022";
            this.btn_2022.UseVisualStyleBackColor = true;
            this.btn_2022.Click += new System.EventHandler(this.btn_2022_Click);
            // 
            // btn_2023
            // 
            this.btn_2023.Location = new System.Drawing.Point(224, 12);
            this.btn_2023.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2023.Name = "btn_2023";
            this.btn_2023.Size = new System.Drawing.Size(100, 73);
            this.btn_2023.TabIndex = 0;
            this.btn_2023.Text = "2023";
            this.btn_2023.UseVisualStyleBackColor = true;
            this.btn_2023.Click += new System.EventHandler(this.btn_2023_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Controls.Add(this.btn_2021);
            this.panel1.Controls.Add(this.btn_2024);
            this.panel1.Controls.Add(this.btn_2023);
            this.panel1.Controls.Add(this.btn_2022);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 117);
            this.panel1.TabIndex = 3;
            // 
            // welcome
            // 
            this.welcome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(1096, 12);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(61, 16);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "welcome";
            // 
            // btn_2024
            // 
            this.btn_2024.BackColor = System.Drawing.SystemColors.Control;
            this.btn_2024.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2024.Location = new System.Drawing.Point(330, 11);
            this.btn_2024.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2024.Name = "btn_2024";
            this.btn_2024.Size = new System.Drawing.Size(100, 73);
            this.btn_2024.TabIndex = 0;
            this.btn_2024.Text = "2024";
            this.btn_2024.UseVisualStyleBackColor = true;
            this.btn_2024.Click += new System.EventHandler(this.btn_2024_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 734);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çks App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectYearForm_FormClosed);
            this.Load += new System.EventHandler(this.SelectYearForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_2021;
        private System.Windows.Forms.Button btn_2022;
        private System.Windows.Forms.Button btn_2023;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button btn_2024;
    }
}