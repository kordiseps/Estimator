namespace Estimator.App
{
    partial class KitsForm
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
            this.btEdit = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.listKits = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(316, 144);
            this.btEdit.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(120, 50);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "Düzenle";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.ForeColor = System.Drawing.Color.OrangeRed;
            this.btRemove.Location = new System.Drawing.Point(316, 82);
            this.btRemove.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(120, 50);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "Sil";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAdd.Location = new System.Drawing.Point(316, 19);
            this.btAdd.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(120, 50);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Ekle";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // listKits
            // 
            this.listKits.FormattingEnabled = true;
            this.listKits.ItemHeight = 19;
            this.listKits.Location = new System.Drawing.Point(21, 19);
            this.listKits.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.listKits.Name = "listKits";
            this.listKits.Size = new System.Drawing.Size(279, 175);
            this.listKits.TabIndex = 2;
            // 
            // KitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 201);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listKits);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KitsForm";
            this.Text = "KitsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListBox listKits;
    }
}