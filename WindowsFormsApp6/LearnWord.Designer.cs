namespace WindowsFormsApp6
{
    partial class LearnWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnWord));
            this.bunifuImageButton12 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton13 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton13)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton12
            // 
            this.bunifuImageButton12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton12.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton12.Image")));
            this.bunifuImageButton12.ImageActive = null;
            this.bunifuImageButton12.Location = new System.Drawing.Point(237, 313);
            this.bunifuImageButton12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton12.Name = "bunifuImageButton12";
            this.bunifuImageButton12.Size = new System.Drawing.Size(89, 71);
            this.bunifuImageButton12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton12.TabIndex = 36;
            this.bunifuImageButton12.TabStop = false;
            this.bunifuImageButton12.Zoom = 20;
            // 
            // bunifuImageButton13
            // 
            this.bunifuImageButton13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton13.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton13.Image")));
            this.bunifuImageButton13.ImageActive = null;
            this.bunifuImageButton13.Location = new System.Drawing.Point(144, 313);
            this.bunifuImageButton13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton13.Name = "bunifuImageButton13";
            this.bunifuImageButton13.Size = new System.Drawing.Size(87, 71);
            this.bunifuImageButton13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton13.TabIndex = 35;
            this.bunifuImageButton13.TabStop = false;
            this.bunifuImageButton13.Zoom = 20;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(184, 50);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(95, 45);
            this.bunifuCustomLabel3.TabIndex = 32;
            this.bunifuCustomLabel3.Text = "Hello";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Göster";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 25;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Purple;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Violet;
            this.bunifuThinButton21.Location = new System.Drawing.Point(163, 133);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(135, 55);
            this.bunifuThinButton21.TabIndex = 34;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(155, 225);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(150, 45);
            this.bunifuCustomLabel2.TabIndex = 33;
            this.bunifuCustomLabel2.Text = "Merhaba";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCircleProgressbar1);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Lavender;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Orchid;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(568, 0);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(197, 487);
            this.bunifuGradientPanel2.TabIndex = 37;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 40;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(11, 274);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Red;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(177, 177);
            this.bunifuCircleProgressbar1.TabIndex = 2;
            this.bunifuCircleProgressbar1.Value = 75;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenilen Kelimeler";
            // 
            // LearnWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuImageButton12);
            this.Controls.Add(this.bunifuImageButton13);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LearnWord";
            this.Size = new System.Drawing.Size(765, 487);
            this.Load += new System.EventHandler(this.LearnWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton13)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton12;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
    }
}
