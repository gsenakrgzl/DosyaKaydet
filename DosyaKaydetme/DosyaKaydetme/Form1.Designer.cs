namespace DosyaKaydetme
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Oku = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.tbKaydet = new System.Windows.Forms.TextBox();
            this.lbOku = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Kaydetme Okuma Silme";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Yellow;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(24, 98);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(88, 46);
            this.btn_Kaydet.TabIndex = 1;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Oku
            // 
            this.btn_Oku.BackColor = System.Drawing.Color.Yellow;
            this.btn_Oku.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Oku.Location = new System.Drawing.Point(24, 174);
            this.btn_Oku.Name = "btn_Oku";
            this.btn_Oku.Size = new System.Drawing.Size(88, 50);
            this.btn_Oku.TabIndex = 2;
            this.btn_Oku.Text = "Oku";
            this.btn_Oku.UseVisualStyleBackColor = false;
            this.btn_Oku.Click += new System.EventHandler(this.btn_Oku_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(24, 255);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(88, 48);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // tbKaydet
            // 
            this.tbKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKaydet.Location = new System.Drawing.Point(195, 110);
            this.tbKaydet.Multiline = true;
            this.tbKaydet.Name = "tbKaydet";
            this.tbKaydet.Size = new System.Drawing.Size(127, 143);
            this.tbKaydet.TabIndex = 4;
            // 
            // lbOku
            // 
            this.lbOku.FormattingEnabled = true;
            this.lbOku.ItemHeight = 16;
            this.lbOku.Location = new System.Drawing.Point(361, 110);
            this.lbOku.Name = "lbOku";
            this.lbOku.Size = new System.Drawing.Size(120, 148);
            this.lbOku.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbOku);
            this.Controls.Add(this.tbKaydet);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Oku);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Oku;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox tbKaydet;
        private System.Windows.Forms.ListBox lbOku;
    }
}

