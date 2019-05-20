namespace WindowsFormsApp6
{
    partial class AddWord
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWord));
            this.userNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.trWord = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addWordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameText.HintForeColor = System.Drawing.Color.Empty;
            this.userNameText.HintText = "İngilizce kelimeyi giriniz";
            this.userNameText.isPassword = false;
            this.userNameText.LineFocusedColor = System.Drawing.Color.Blue;
            this.userNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.userNameText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userNameText.LineThickness = 3;
            this.userNameText.Location = new System.Drawing.Point(211, 136);
            this.userNameText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(321, 39);
            this.userNameText.TabIndex = 14;
            this.userNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // trWord
            // 
            this.trWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trWord.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trWord.HintForeColor = System.Drawing.Color.Empty;
            this.trWord.HintText = "Türkçe kelimeyi giriniz";
            this.trWord.isPassword = false;
            this.trWord.LineFocusedColor = System.Drawing.Color.Blue;
            this.trWord.LineIdleColor = System.Drawing.Color.Gray;
            this.trWord.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.trWord.LineThickness = 3;
            this.trWord.Location = new System.Drawing.Point(211, 200);
            this.trWord.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.trWord.Name = "trWord";
            this.trWord.Size = new System.Drawing.Size(321, 39);
            this.trWord.TabIndex = 15;
            this.trWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addWordButton
            // 
            this.addWordButton.ActiveBorderThickness = 1;
            this.addWordButton.ActiveCornerRadius = 20;
            this.addWordButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addWordButton.ActiveForecolor = System.Drawing.Color.White;
            this.addWordButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addWordButton.BackColor = System.Drawing.Color.White;
            this.addWordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addWordButton.BackgroundImage")));
            this.addWordButton.ButtonText = "Kelimeyi Ekle";
            this.addWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWordButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.addWordButton.IdleBorderThickness = 1;
            this.addWordButton.IdleCornerRadius = 20;
            this.addWordButton.IdleFillColor = System.Drawing.Color.White;
            this.addWordButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addWordButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addWordButton.Location = new System.Drawing.Point(211, 269);
            this.addWordButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(321, 55);
            this.addWordButton.TabIndex = 19;
            this.addWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(151, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addWordButton);
            this.Controls.Add(this.trWord);
            this.Controls.Add(this.userNameText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddWord";
            this.Size = new System.Drawing.Size(765, 487);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox trWord;
        private Bunifu.Framework.UI.BunifuThinButton2 addWordButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
