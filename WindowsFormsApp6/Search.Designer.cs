namespace WindowsFormsApp6
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.searchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.searchListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addListButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteWordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updateWordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.randomButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.myListButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.ActiveBorderThickness = 1;
            this.searchButton.ActiveCornerRadius = 20;
            this.searchButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.searchButton.ActiveForecolor = System.Drawing.Color.White;
            this.searchButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.ButtonText = "Ara";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.searchButton.IdleBorderThickness = 1;
            this.searchButton.IdleCornerRadius = 20;
            this.searchButton.IdleFillColor = System.Drawing.Color.White;
            this.searchButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.searchButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.searchButton.Location = new System.Drawing.Point(397, 12);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(55, 45);
            this.searchButton.TabIndex = 14;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.searchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchText.HintForeColor = System.Drawing.Color.Empty;
            this.searchText.HintText = "Aradığınız kelimenin Türkçe veya İngilizcesini giriniz";
            this.searchText.isPassword = false;
            this.searchText.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchText.LineIdleColor = System.Drawing.Color.Gray;
            this.searchText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchText.LineThickness = 3;
            this.searchText.Location = new System.Drawing.Point(16, 13);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(377, 39);
            this.searchText.TabIndex = 13;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // searchListView
            // 
            this.searchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.searchListView.Location = new System.Drawing.Point(11, 67);
            this.searchListView.Name = "searchListView";
            this.searchListView.Size = new System.Drawing.Size(559, 260);
            this.searchListView.TabIndex = 15;
            this.searchListView.UseCompatibleStateImageBehavior = false;
            this.searchListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 44;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Türkçe";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İngilizce";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sahibi";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Liste Durumu";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Liste Seviye";
            this.columnHeader5.Width = 70;
            // 
            // addListButton
            // 
            this.addListButton.ActiveBorderThickness = 1;
            this.addListButton.ActiveCornerRadius = 20;
            this.addListButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addListButton.ActiveForecolor = System.Drawing.Color.White;
            this.addListButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addListButton.BackColor = System.Drawing.Color.White;
            this.addListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addListButton.BackgroundImage")));
            this.addListButton.ButtonText = "Listeme Ekle";
            this.addListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addListButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addListButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.addListButton.IdleBorderThickness = 1;
            this.addListButton.IdleCornerRadius = 20;
            this.addListButton.IdleFillColor = System.Drawing.Color.White;
            this.addListButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addListButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addListButton.Location = new System.Drawing.Point(11, 334);
            this.addListButton.Margin = new System.Windows.Forms.Padding(4);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(131, 43);
            this.addListButton.TabIndex = 16;
            this.addListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteWordButton
            // 
            this.deleteWordButton.ActiveBorderThickness = 1;
            this.deleteWordButton.ActiveCornerRadius = 20;
            this.deleteWordButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.ActiveForecolor = System.Drawing.Color.White;
            this.deleteWordButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.BackColor = System.Drawing.Color.White;
            this.deleteWordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteWordButton.BackgroundImage")));
            this.deleteWordButton.ButtonText = "Kelimeyi Sil";
            this.deleteWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteWordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWordButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.IdleBorderThickness = 1;
            this.deleteWordButton.IdleCornerRadius = 20;
            this.deleteWordButton.IdleFillColor = System.Drawing.Color.White;
            this.deleteWordButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.Location = new System.Drawing.Point(150, 332);
            this.deleteWordButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteWordButton.Name = "deleteWordButton";
            this.deleteWordButton.Size = new System.Drawing.Size(105, 45);
            this.deleteWordButton.TabIndex = 17;
            this.deleteWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateWordButton
            // 
            this.updateWordButton.ActiveBorderThickness = 1;
            this.updateWordButton.ActiveCornerRadius = 20;
            this.updateWordButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.ActiveForecolor = System.Drawing.Color.White;
            this.updateWordButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.BackColor = System.Drawing.Color.White;
            this.updateWordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateWordButton.BackgroundImage")));
            this.updateWordButton.ButtonText = "Kelimeyi Güncelle";
            this.updateWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateWordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateWordButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.IdleBorderThickness = 1;
            this.updateWordButton.IdleCornerRadius = 20;
            this.updateWordButton.IdleFillColor = System.Drawing.Color.White;
            this.updateWordButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.Location = new System.Drawing.Point(263, 332);
            this.updateWordButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateWordButton.Name = "updateWordButton";
            this.updateWordButton.Size = new System.Drawing.Size(156, 45);
            this.updateWordButton.TabIndex = 18;
            this.updateWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(526, 334);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(44, 43);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 19;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            // 
            // randomButton
            // 
            this.randomButton.ActiveBorderThickness = 1;
            this.randomButton.ActiveCornerRadius = 20;
            this.randomButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.randomButton.ActiveForecolor = System.Drawing.Color.White;
            this.randomButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.randomButton.BackColor = System.Drawing.Color.White;
            this.randomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randomButton.BackgroundImage")));
            this.randomButton.ButtonText = "Random";
            this.randomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.randomButton.IdleBorderThickness = 1;
            this.randomButton.IdleCornerRadius = 20;
            this.randomButton.IdleFillColor = System.Drawing.Color.White;
            this.randomButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.randomButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.randomButton.Location = new System.Drawing.Point(424, 331);
            this.randomButton.Margin = new System.Windows.Forms.Padding(4);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(79, 45);
            this.randomButton.TabIndex = 20;
            this.randomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.randomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // myListButton
            // 
            this.myListButton.ActiveBorderThickness = 1;
            this.myListButton.ActiveCornerRadius = 20;
            this.myListButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.myListButton.ActiveForecolor = System.Drawing.Color.White;
            this.myListButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.myListButton.BackColor = System.Drawing.Color.White;
            this.myListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myListButton.BackgroundImage")));
            this.myListButton.ButtonText = "Benim Listem";
            this.myListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myListButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myListButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.myListButton.IdleBorderThickness = 1;
            this.myListButton.IdleCornerRadius = 20;
            this.myListButton.IdleFillColor = System.Drawing.Color.White;
            this.myListButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.myListButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.myListButton.Location = new System.Drawing.Point(460, 11);
            this.myListButton.Margin = new System.Windows.Forms.Padding(4);
            this.myListButton.Name = "myListButton";
            this.myListButton.Size = new System.Drawing.Size(110, 45);
            this.myListButton.TabIndex = 21;
            this.myListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myListButton.Click += new System.EventHandler(this.MyListButton_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.myListButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.updateWordButton);
            this.Controls.Add(this.deleteWordButton);
            this.Controls.Add(this.addListButton);
            this.Controls.Add(this.searchListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(574, 396);
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 searchButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchText;
        private System.Windows.Forms.ListView searchListView;
        private Bunifu.Framework.UI.BunifuThinButton2 addListButton;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteWordButton;
        private Bunifu.Framework.UI.BunifuThinButton2 updateWordButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private Bunifu.Framework.UI.BunifuThinButton2 randomButton;
        private Bunifu.Framework.UI.BunifuThinButton2 myListButton;
    }
}
