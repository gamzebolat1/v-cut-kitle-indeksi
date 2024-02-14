namespace vücut_kitle_indeksi
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
            this.txtboy = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.lblboy = new System.Windows.Forms.Label();
            this.lblkilo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(207, 152);
            this.txtboy.Multiline = true;
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(124, 25);
            this.txtboy.TabIndex = 0;
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.SteelBlue;
            this.btnhesapla.Location = new System.Drawing.Point(207, 255);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(124, 37);
            this.btnhesapla.TabIndex = 1;
            this.btnhesapla.Text = "hesapla";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(207, 202);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(124, 26);
            this.txtkilo.TabIndex = 2;
            // 
            // lblboy
            // 
            this.lblboy.AutoSize = true;
            this.lblboy.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblboy.Location = new System.Drawing.Point(1, 152);
            this.lblboy.Name = "lblboy";
            this.lblboy.Size = new System.Drawing.Size(200, 25);
            this.lblboy.TabIndex = 3;
            this.lblboy.Text = "Boyunuz(m)(ör:1,80)";
            // 
            // lblkilo
            // 
            this.lblkilo.AutoSize = true;
            this.lblkilo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkilo.Location = new System.Drawing.Point(1, 203);
            this.lblkilo.Name = "lblkilo";
            this.lblkilo.Size = new System.Drawing.Size(177, 25);
            this.lblkilo.TabIndex = 4;
            this.lblkilo.Text = "Kilonuz(kg)(ör:70)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(447, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 88);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vücut kitle indeksi (VKİ), \r\nkişinin vücudundaki kilo fazlalığı \r\nve yağ oranı ha" +
    "kkında fikir vermek\r\n için kullanılır.";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(12, 349);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(73, 25);
            this.lblsonuc.TabIndex = 7;
            this.lblsonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblkilo);
            this.Controls.Add(this.lblboy);
            this.Controls.Add(this.txtkilo);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtboy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Vücut Kitle İndeksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboy;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.Label lblboy;
        private System.Windows.Forms.Label lblkilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsonuc;
    }
}

