namespace KelimeOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnBaslat = new Button();
            lblSkor = new Label();
            lblSoru = new Label();
            lblDurum = new Label();
            btnSonraki = new Button();
            btnD = new Button();
            btnC = new Button();
            btnB = new Button();
            btnA = new Button();
            btnBitir = new Button();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.FromArgb(192, 255, 192);
            btnBaslat.Location = new Point(48, 43);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(130, 41);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Sınavı Başlat";
            btnBaslat.UseVisualStyleBackColor = false;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Location = new Point(61, 104);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(103, 15);
            lblSkor.TabIndex = 1;
            lblSkor.Text = "Doğru: 0 | Yanlış: 0";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Font = new Font("Segoe UI", 11F);
            lblSoru.Location = new Point(48, 138);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(143, 20);
            lblSoru.TabIndex = 2;
            lblSoru.Text = "Soru buraya gelecek";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.BackColor = SystemColors.ActiveCaption;
            lblDurum.Location = new Point(48, 319);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(12, 15);
            lblDurum.TabIndex = 3;
            lblDurum.Text = "-";
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.FromArgb(192, 255, 255);
            btnSonraki.Location = new Point(48, 360);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(339, 23);
            btnSonraki.TabIndex = 4;
            btnSonraki.Text = "Sonraki soru";
            btnSonraki.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.Location = new Point(48, 257);
            btnD.Name = "btnD";
            btnD.Size = new Size(130, 40);
            btnD.TabIndex = 5;
            btnD.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(257, 257);
            btnC.Name = "btnC";
            btnC.Size = new Size(130, 40);
            btnC.TabIndex = 6;
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            btnB.Location = new Point(257, 195);
            btnB.Name = "btnB";
            btnB.Size = new Size(130, 40);
            btnB.TabIndex = 7;
            btnB.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            btnA.Location = new Point(48, 195);
            btnA.Name = "btnA";
            btnA.Size = new Size(130, 40);
            btnA.TabIndex = 8;
            btnA.UseVisualStyleBackColor = true;
            // 
            // btnBitir
            // 
            btnBitir.BackColor = Color.FromArgb(255, 192, 192);
            btnBitir.Location = new Point(257, 43);
            btnBitir.Name = "btnBitir";
            btnBitir.Size = new Size(130, 41);
            btnBitir.TabIndex = 9;
            btnBitir.Text = "Sınavı Bitir";
            btnBitir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(btnBitir);
            Controls.Add(btnA);
            Controls.Add(btnB);
            Controls.Add(btnC);
            Controls.Add(btnD);
            Controls.Add(btnSonraki);
            Controls.Add(lblDurum);
            Controls.Add(lblSoru);
            Controls.Add(lblSkor);
            Controls.Add(btnBaslat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "İngilizce kelime sınavı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private Label lblSkor;
        private Label lblSoru;
        private Label lblDurum;
        private Button btnSonraki;
        private Button btnD;
        private Button btnC;
        private Button btnB;
        private Button btnA;
        private Button btnBitir;
    }
}
