namespace ATM_Uygulaması_3
{
    partial class ParaCekme
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cekilecek_tutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "DEVAM ET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cekilecek_tutar
            // 
            this.txt_cekilecek_tutar.Location = new System.Drawing.Point(250, 159);
            this.txt_cekilecek_tutar.Name = "txt_cekilecek_tutar";
            this.txt_cekilecek_tutar.Size = new System.Drawing.Size(281, 20);
            this.txt_cekilecek_tutar.TabIndex = 4;
            this.txt_cekilecek_tutar.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(210, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "LÜTFEN ÇEKMEK İSTEDİĞİNİZ TUTARI GİRİNİZ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(646, 393);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 35);
            this.button6.TabIndex = 7;
            this.button6.Text = "Çıkış Yap";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(510, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 35);
            this.button5.TabIndex = 8;
            this.button5.Text = "Ana Menüye Dön";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "İsim :";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(115, 332);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(13, 13);
            this.lbl_isim.TabIndex = 9;
            this.lbl_isim.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soyisim :";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(115, 374);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(35, 13);
            this.lbl_soyisim.TabIndex = 9;
            this.lbl_soyisim.Text = "label2";
            // 
            // ParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_cekilecek_tutar);
            this.Controls.Add(this.label1);
            this.Name = "ParaCekme";
            this.Text = "ParaCekme";
            this.Load += new System.EventHandler(this.ParaCekme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cekilecek_tutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_soyisim;
    }
}