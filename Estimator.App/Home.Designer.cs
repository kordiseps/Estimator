namespace Estimator.App
{
    partial class Home
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
            this.listProducts = new System.Windows.Forms.ListBox();
            this.lbListHeader = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btMarkAsMade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HeaderMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConst = new System.Windows.Forms.ToolStripMenuItem();
            this.RawMaterialMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProducts
            // 
            this.listProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listProducts.FormattingEnabled = true;
            this.listProducts.ItemHeight = 25;
            this.listProducts.Location = new System.Drawing.Point(24, 63);
            this.listProducts.Margin = new System.Windows.Forms.Padding(4);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(358, 304);
            this.listProducts.TabIndex = 0;
            // 
            // lbListHeader
            // 
            this.lbListHeader.AutoSize = true;
            this.lbListHeader.Location = new System.Drawing.Point(20, 40);
            this.lbListHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListHeader.Name = "lbListHeader";
            this.lbListHeader.Size = new System.Drawing.Size(89, 19);
            this.lbListHeader.TabIndex = 1;
            this.lbListHeader.Text = "Ürün Listesi";
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(24, 374);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(358, 86);
            this.btNew.TabIndex = 2;
            this.btNew.Text = "Ürün Ekle";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(389, 63);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(129, 51);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Ürün Düzenle";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(389, 120);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(148, 51);
            this.btView.TabIndex = 2;
            this.btView.Text = "Ürün Görüntüle";
            this.btView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btView.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(389, 177);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(88, 51);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "Ürün Sil";
            this.btRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btMarkAsMade
            // 
            this.btMarkAsMade.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btMarkAsMade.Location = new System.Drawing.Point(389, 234);
            this.btMarkAsMade.Name = "btMarkAsMade";
            this.btMarkAsMade.Size = new System.Drawing.Size(148, 51);
            this.btMarkAsMade.TabIndex = 2;
            this.btMarkAsMade.Text = "Tamamlandı Olarak İşaretle";
            this.btMarkAsMade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMarkAsMade.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(389, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tamamlanmadı Olarak İşaretle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HeaderMenu
            // 
            this.HeaderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuConst});
            this.HeaderMenu.Location = new System.Drawing.Point(0, 0);
            this.HeaderMenu.Name = "HeaderMenu";
            this.HeaderMenu.Size = new System.Drawing.Size(562, 24);
            this.HeaderMenu.TabIndex = 3;
            this.HeaderMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportMenuItem,
            this.ExportMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(51, 20);
            this.menuFile.Text = "Dosya";
            // 
            // ImportMenuItem
            // 
            this.ImportMenuItem.Name = "ImportMenuItem";
            this.ImportMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ImportMenuItem.Text = "Dosyadan İçe Aktar";
            // 
            // ExportMenuItem
            // 
            this.ExportMenuItem.Name = "ExportMenuItem";
            this.ExportMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ExportMenuItem.Text = "Dosyaya Dışa aktar";
            // 
            // menuConst
            // 
            this.menuConst.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RawMaterialMenuItem,
            this.KitMenuItem});
            this.menuConst.Name = "menuConst";
            this.menuConst.Size = new System.Drawing.Size(92, 20);
            this.menuConst.Text = "Sabit Değerler";
            // 
            // RawMaterialMenuItem
            // 
            this.RawMaterialMenuItem.Name = "RawMaterialMenuItem";
            this.RawMaterialMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RawMaterialMenuItem.Text = "Ham Madde Listesi";
            this.RawMaterialMenuItem.Click += new System.EventHandler(this.RawMaterialMenuItem_Click);
            // 
            // KitMenuItem
            // 
            this.KitMenuItem.Name = "KitMenuItem";
            this.KitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.KitMenuItem.Text = "Aparat Listesi";
            this.KitMenuItem.Click += new System.EventHandler(this.KitMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 476);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btMarkAsMade);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.lbListHeader);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.HeaderMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.MainMenuStrip = this.HeaderMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Maliyet Hesaplayıcı";
            this.HeaderMenu.ResumeLayout(false);
            this.HeaderMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.Label lbListHeader;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btMarkAsMade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip HeaderMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem ImportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConst;
        private System.Windows.Forms.ToolStripMenuItem RawMaterialMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KitMenuItem;
    }
}

