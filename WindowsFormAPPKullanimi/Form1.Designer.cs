
namespace WindowsFormAPPKullanimi
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
            this.txt_birinciNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ikinciNot = new System.Windows.Forms.TextBox();
            this.btn_OrtalamaHesapla = new System.Windows.Forms.Button();
            this.lbl_ortalama = new System.Windows.Forms.Label();
            this.lbl_ortalamaSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "1.Notunuzu Giriniz :";
            // 
            // txt_birinciNot
            // 
            this.txt_birinciNot.Location = new System.Drawing.Point(214, 16);
            this.txt_birinciNot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_birinciNot.Name = "txt_birinciNot";
            this.txt_birinciNot.Size = new System.Drawing.Size(204, 26);
            this.txt_birinciNot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.Notunuzu Giriniz :";
            // 
            // txt_ikinciNot
            // 
            this.txt_ikinciNot.Location = new System.Drawing.Point(214, 60);
            this.txt_ikinciNot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ikinciNot.Name = "txt_ikinciNot";
            this.txt_ikinciNot.Size = new System.Drawing.Size(204, 26);
            this.txt_ikinciNot.TabIndex = 3;
            // 
            // btn_OrtalamaHesapla
            // 
            this.btn_OrtalamaHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OrtalamaHesapla.Location = new System.Drawing.Point(17, 113);
            this.btn_OrtalamaHesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_OrtalamaHesapla.Name = "btn_OrtalamaHesapla";
            this.btn_OrtalamaHesapla.Size = new System.Drawing.Size(403, 35);
            this.btn_OrtalamaHesapla.TabIndex = 4;
            this.btn_OrtalamaHesapla.Text = "Ortalamayı Bul";
            this.btn_OrtalamaHesapla.UseVisualStyleBackColor = true;
            this.btn_OrtalamaHesapla.Click += new System.EventHandler(this.btn_OrtalamaHesapla_Click);
            // 
            // lbl_ortalama
            // 
            this.lbl_ortalama.AutoSize = true;
            this.lbl_ortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ortalama.Location = new System.Drawing.Point(288, 179);
            this.lbl_ortalama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ortalama.Name = "lbl_ortalama";
            this.lbl_ortalama.Size = new System.Drawing.Size(92, 20);
            this.lbl_ortalama.TabIndex = 2;
            this.lbl_ortalama.Text = "Ortalama :";
            // 
            // lbl_ortalamaSonuc
            // 
            this.lbl_ortalamaSonuc.AutoSize = true;
            this.lbl_ortalamaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ortalamaSonuc.Location = new System.Drawing.Point(388, 169);
            this.lbl_ortalamaSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ortalamaSonuc.Name = "lbl_ortalamaSonuc";
            this.lbl_ortalamaSonuc.Size = new System.Drawing.Size(30, 31);
            this.lbl_ortalamaSonuc.TabIndex = 2;
            this.lbl_ortalamaSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 199);
            this.Controls.Add(this.btn_OrtalamaHesapla);
            this.Controls.Add(this.txt_ikinciNot);
            this.Controls.Add(this.txt_birinciNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ortalamaSonuc);
            this.Controls.Add(this.lbl_ortalama);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Ortalama Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birinciNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ikinciNot;
        private System.Windows.Forms.Button btn_OrtalamaHesapla;
        private System.Windows.Forms.Label lbl_ortalama;
        private System.Windows.Forms.Label lbl_ortalamaSonuc;
    }
}

