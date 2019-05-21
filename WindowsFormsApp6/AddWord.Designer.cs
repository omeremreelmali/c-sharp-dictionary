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
            this.enWordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.trWordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addWordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // enWordTextBox
            // 
            this.enWordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enWordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enWordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enWordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.enWordTextBox.HintText = "İngilizce kelimeyi giriniz";
            this.enWordTextBox.isPassword = false;
            this.enWordTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.enWordTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.enWordTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.enWordTextBox.LineThickness = 3;
            this.enWordTextBox.Location = new System.Drawing.Point(158, 110);
            this.enWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.enWordTextBox.Name = "enWordTextBox";
            this.enWordTextBox.Size = new System.Drawing.Size(241, 32);
            this.enWordTextBox.TabIndex = 14;
            this.enWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // trWordTextBox
            // 
            this.trWordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trWordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trWordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trWordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.trWordTextBox.HintText = "Türkçe kelimeyi giriniz";
            this.trWordTextBox.isPassword = false;
            this.trWordTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.trWordTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.trWordTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.trWordTextBox.LineThickness = 3;
            this.trWordTextBox.Location = new System.Drawing.Point(158, 162);
            this.trWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.trWordTextBox.Name = "trWordTextBox";
            this.trWordTextBox.Size = new System.Drawing.Size(241, 32);
            this.trWordTextBox.TabIndex = 15;
            this.trWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.addWordButton.Location = new System.Drawing.Point(158, 219);
            this.addWordButton.Margin = new System.Windows.Forms.Padding(4);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(241, 45);
            this.addWordButton.TabIndex = 19;
            this.addWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addWordButton.Click += new System.EventHandler(this.AddWordButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(113, 110);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addWordButton);
            this.Controls.Add(this.trWordTextBox);
            this.Controls.Add(this.enWordTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddWord";
            this.Size = new System.Drawing.Size(574, 396);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox enWordTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox trWordTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 addWordButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
