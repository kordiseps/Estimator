namespace Estimator.App
{
    partial class RawMaterialsForm
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
            this.listMaterials = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMaterials
            // 
            this.listMaterials.FormattingEnabled = true;
            this.listMaterials.ItemHeight = 19;
            this.listMaterials.Location = new System.Drawing.Point(18, 17);
            this.listMaterials.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listMaterials.Name = "listMaterials";
            this.listMaterials.Size = new System.Drawing.Size(279, 175);
            this.listMaterials.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAdd.Location = new System.Drawing.Point(307, 17);
            this.btAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(120, 50);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Ekle";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.ForeColor = System.Drawing.Color.OrangeRed;
            this.btRemove.Location = new System.Drawing.Point(307, 84);
            this.btRemove.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(120, 50);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "Sil";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(307, 142);
            this.btEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(120, 50);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Düzenle";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // RawMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 205);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listMaterials);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RawMaterialsForm";
            this.Text = "Ham Maddeler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMaterials;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btEdit;
    }
}