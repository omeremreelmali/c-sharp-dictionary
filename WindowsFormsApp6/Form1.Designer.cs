namespace WindowsFormsApp6
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton11 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton10 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.MainBaseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddWordPageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.LearnWordPageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchPageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TabSignUpButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainBaseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddWordPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearnWordPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabSignUpButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton11);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton10);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton9);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(638, 51);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 11);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 25);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Learn English - Redvizor Software";
            // 
            // bunifuImageButton11
            // 
            this.bunifuImageButton11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton11.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton11.Image")));
            this.bunifuImageButton11.ImageActive = null;
            this.bunifuImageButton11.Location = new System.Drawing.Point(551, 10);
            this.bunifuImageButton11.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton11.Name = "bunifuImageButton11";
            this.bunifuImageButton11.Size = new System.Drawing.Size(34, 28);
            this.bunifuImageButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton11.TabIndex = 13;
            this.bunifuImageButton11.TabStop = false;
            this.bunifuImageButton11.Zoom = 30;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(614, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(22, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // bunifuImageButton10
            // 
            this.bunifuImageButton10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
            this.bunifuImageButton10.ImageActive = null;
            this.bunifuImageButton10.Location = new System.Drawing.Point(501, 10);
            this.bunifuImageButton10.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton10.Name = "bunifuImageButton10";
            this.bunifuImageButton10.Size = new System.Drawing.Size(36, 28);
            this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton10.TabIndex = 12;
            this.bunifuImageButton10.TabStop = false;
            this.bunifuImageButton10.Zoom = 30;
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(452, 10);
            this.bunifuImageButton9.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(34, 28);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 11;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuImageButton9.Zoom = 30;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.MainBaseButton);
            this.bunifuGradientPanel2.Controls.Add(this.AddWordPageButton);
            this.bunifuGradientPanel2.Controls.Add(this.LearnWordPageButton);
            this.bunifuGradientPanel2.Controls.Add(this.panel4);
            this.bunifuGradientPanel2.Controls.Add(this.SearchPageButton);
            this.bunifuGradientPanel2.Controls.Add(this.panel3);
            this.bunifuGradientPanel2.Controls.Add(this.TabSignUpButton);
            this.bunifuGradientPanel2.Controls.Add(this.panel1);
            this.bunifuGradientPanel2.Controls.Add(this.panel2);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Gainsboro;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 51);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(64, 396);
            this.bunifuGradientPanel2.TabIndex = 1;
             // 
            // MainBaseButton
            // 
            this.MainBaseButton.BackColor = System.Drawing.Color.Transparent;
            this.MainBaseButton.Image = ((System.Drawing.Image)(resources.GetObject("MainBaseButton.Image")));
            this.MainBaseButton.ImageActive = null;
            this.MainBaseButton.Location = new System.Drawing.Point(6, 15);
            this.MainBaseButton.Margin = new System.Windows.Forms.Padding(2);
            this.MainBaseButton.Name = "MainBaseButton";
            this.MainBaseButton.Size = new System.Drawing.Size(53, 58);
            this.MainBaseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainBaseButton.TabIndex = 24;
            this.MainBaseButton.TabStop = false;
            this.MainBaseButton.Zoom = 10;
            this.MainBaseButton.Click += new System.EventHandler(this.MainBaseButton_Click);
            // 
            // AddWordPageButton
            // 
            this.AddWordPageButton.BackColor = System.Drawing.Color.Transparent;
            this.AddWordPageButton.Image = ((System.Drawing.Image)(resources.GetObject("AddWordPageButton.Image")));
            this.AddWordPageButton.ImageActive = null;
            this.AddWordPageButton.Location = new System.Drawing.Point(16, 171);
            this.AddWordPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddWordPageButton.Name = "AddWordPageButton";
            this.AddWordPageButton.Size = new System.Drawing.Size(42, 50);
            this.AddWordPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddWordPageButton.TabIndex = 15;
            this.AddWordPageButton.TabStop = false;
            this.AddWordPageButton.Zoom = 20;
            this.AddWordPageButton.Click += new System.EventHandler(this.AddWordPageButton_Click);
            this.AddWordPageButton.MouseEnter += new System.EventHandler(this.BunifuImageButton3_MouseEnter);
            this.AddWordPageButton.MouseLeave += new System.EventHandler(this.BunifuImageButton3_MouseLeave);
            // 
            // LearnWordPageButton
            // 
            this.LearnWordPageButton.BackColor = System.Drawing.Color.Transparent;
            this.LearnWordPageButton.Image = ((System.Drawing.Image)(resources.GetObject("LearnWordPageButton.Image")));
            this.LearnWordPageButton.ImageActive = null;
            this.LearnWordPageButton.Location = new System.Drawing.Point(16, 93);
            this.LearnWordPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.LearnWordPageButton.Name = "LearnWordPageButton";
            this.LearnWordPageButton.Size = new System.Drawing.Size(42, 50);
            this.LearnWordPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LearnWordPageButton.TabIndex = 14;
            this.LearnWordPageButton.TabStop = false;
            this.LearnWordPageButton.Zoom = 20;
            this.LearnWordPageButton.Click += new System.EventHandler(this.LearnWordPageButton_Click);
            this.LearnWordPageButton.MouseEnter += new System.EventHandler(this.BunifuImageButton2_MouseEnter);
            this.LearnWordPageButton.MouseLeave += new System.EventHandler(this.BunifuImageButton2_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Location = new System.Drawing.Point(5, 327);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 50);
            this.panel4.TabIndex = 19;
            this.panel4.Visible = false;
            // 
            // SearchPageButton
            // 
            this.SearchPageButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchPageButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchPageButton.Image")));
            this.SearchPageButton.ImageActive = null;
            this.SearchPageButton.Location = new System.Drawing.Point(16, 249);
            this.SearchPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPageButton.Name = "SearchPageButton";
            this.SearchPageButton.Size = new System.Drawing.Size(42, 50);
            this.SearchPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchPageButton.TabIndex = 17;
            this.SearchPageButton.TabStop = false;
            this.SearchPageButton.Zoom = 20;
            this.SearchPageButton.Click += new System.EventHandler(this.SearchPageButton_Click);
            this.SearchPageButton.MouseEnter += new System.EventHandler(this.BunifuImageButton4_MouseEnter);
            this.SearchPageButton.MouseLeave += new System.EventHandler(this.BunifuImageButton4_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Location = new System.Drawing.Point(5, 249);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 50);
            this.panel3.TabIndex = 20;
            this.panel3.Visible = false;
            // 
            // TabSignUpButton
            // 
            this.TabSignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.TabSignUpButton.Image = ((System.Drawing.Image)(resources.GetObject("TabSignUpButton.Image")));
            this.TabSignUpButton.ImageActive = null;
            this.TabSignUpButton.Location = new System.Drawing.Point(16, 327);
            this.TabSignUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.TabSignUpButton.Name = "TabSignUpButton";
            this.TabSignUpButton.Size = new System.Drawing.Size(42, 50);
            this.TabSignUpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TabSignUpButton.TabIndex = 21;
            this.TabSignUpButton.TabStop = false;
            this.TabSignUpButton.Zoom = 20;
            this.TabSignUpButton.Click += new System.EventHandler(this.TabSignUpButton_Click);
            this.TabSignUpButton.MouseEnter += new System.EventHandler(this.BunifuImageButton5_MouseEnter);
            this.TabSignUpButton.MouseLeave += new System.EventHandler(this.BunifuImageButton5_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Location = new System.Drawing.Point(5, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 50);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Location = new System.Drawing.Point(5, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 50);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.GradientBottomLeft = System.Drawing.Color.GhostWhite;
            this.panelMain.GradientBottomRight = System.Drawing.Color.GhostWhite;
            this.panelMain.GradientTopLeft = System.Drawing.Color.GhostWhite;
            this.panelMain.GradientTopRight = System.Drawing.Color.GhostWhite;
            this.panelMain.Location = new System.Drawing.Point(64, 51);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Quality = 10;
            this.panelMain.Size = new System.Drawing.Size(574, 396);
            this.panelMain.TabIndex = 3;
             // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelMain;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 447);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainBaseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddWordPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearnWordPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabSignUpButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMain;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton11;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton10;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton9;
        private Bunifu.Framework.UI.BunifuImageButton MainBaseButton;
        private Bunifu.Framework.UI.BunifuImageButton AddWordPageButton;
        private Bunifu.Framework.UI.BunifuImageButton LearnWordPageButton;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton SearchPageButton;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton TabSignUpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

