using Estimator.App.Models;
using Estimator.App.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimator.App
{
    public partial class RawMaterialsForm : Form
    {
        //private const string RawMaterialsPath = @"\File\RawMaterials.xml";
        //private const string ProductsPath = @"\File\Products.xml";
        //private const string KitsPath = @"\File\Kits.xml";

        public RawMaterialsForm()
        {


            InitializeComponent();
            var liste = RawMaterial.Get<RawMaterial>(RawMaterial.RawMaterialsPath);
            foreach (RawMaterial rawMaterial in liste)
            {              
                listMaterials.Items.Add(rawMaterial);
            }

            
        }
        private void BtAdd_Click(object sender, EventArgs e)
        {
            using (Form newMaterial = new Form())
            {
                RawMaterial result = null;

                newMaterial.Text = "Ham madde ekle";
                newMaterial.Size = new Size(320, 240);
                newMaterial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));


                Label lbName = new Label();
                lbName.Text = "Ham Madde İsmi";
                newMaterial.Controls.Add(lbName);
                lbName.Location = new Point(12, 9);
                lbName.AutoSize = true;

                TextBox tbName = new TextBox();
                tbName.Location = new Point(13, 9 + 19 + 9);
                tbName.Size = new Size(200, 27);
                newMaterial.Controls.Add(tbName);

                Label lbUnitPrice = new Label();
                lbUnitPrice.Text = "Ham Madde Birim fiyatı";
                newMaterial.Controls.Add(lbUnitPrice);
                lbUnitPrice.Location = new Point(12, 9 + 19 + 9 + 27 + 9);
                lbUnitPrice.AutoSize = true;

                TextBox tbUnitPrice = new TextBox();
                tbUnitPrice.Location = new Point(13, 9 + 19 + 9 + 27 + 9 + 19 + 9);
                newMaterial.Controls.Add(tbUnitPrice);
                tbUnitPrice.Size = new Size(200, 27);

                Button saveButton = new Button();
                saveButton.Text = "Kaydet";
                saveButton.Location = new Point(12, 9 + 19 + 9 + 27 + 9 + 19 + 9 + 27 + 9);
                saveButton.AutoSize = true;
                saveButton.Click += (s, e2) =>
                     {
                         try
                         {
                             result = new RawMaterial();
                             result.Name = tbName.Text;
                             result.UnitPrice = Convert.ToDecimal(tbUnitPrice.Text.Replace(".", ","));
                             newMaterial.DialogResult = DialogResult.OK;
                             newMaterial.Close();
                         }
                         catch (Exception aa)
                         {
                             MessageBox.Show("Kaydedilemedi : " + aa.Message);
                         }
                     };

                newMaterial.Controls.Add(saveButton);


                Button cancelButton = new Button();
                cancelButton.Text = "İptal";
                cancelButton.AutoSize = true;
                cancelButton.Location = new Point(12 + 12 + saveButton.Width, 9 + 19 + 9 + 27 + 9 + 19 + 9 + 27 + 9);
                cancelButton.Click += (s, e2) =>
                {
                    try
                    {
                        result = null;
                        newMaterial.DialogResult = DialogResult.Cancel;
                        newMaterial.Close();
                    }
                    catch (Exception aa)
                    {
                        MessageBox.Show("Kaydedilemedi : " + aa.Message);
                    }
                };

                newMaterial.Controls.Add(cancelButton);


                if (newMaterial.ShowDialog() == DialogResult.OK)
                {
                    RawMaterial.Add(result);
                    listMaterials.Items.Add(result);
                    
                }


            }

        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            RawMaterial itemToRemove = (RawMaterial)listMaterials.SelectedItem;

            if (itemToRemove == null)
            {
                return;
            }

            RawMaterial.Remove(itemToRemove);
            listMaterials.Items.Remove(listMaterials.SelectedItem);
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            RawMaterial itemToEdit = (RawMaterial)listMaterials.SelectedItem;

            if (itemToEdit == null)
            {
                return;
            }

            using (Form newMaterial = new Form())
            {
                RawMaterial result = null;

                newMaterial.Text = "Ham madde düzenle";
                newMaterial.Size = new Size(320, 240);
                newMaterial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));


                Label lbName = new Label();
                lbName.Text = "Ham Madde İsmi";
                newMaterial.Controls.Add(lbName);
                lbName.Location = new Point(12, 9);
                lbName.AutoSize = true;

                TextBox tbName = new TextBox();
                tbName.Location = new Point(13, 9 + 19 + 9);
                tbName.Size = new Size(200, 27);
                tbName.Text = itemToEdit.Name;                
                newMaterial.Controls.Add(tbName);


                Label lbUnitPrice = new Label();
                lbUnitPrice.Text = "Ham Madde Birim fiyatı";
                newMaterial.Controls.Add(lbUnitPrice);
                lbUnitPrice.Location = new Point(12, 9 + 19 + 9 + 27 + 9);
                lbUnitPrice.AutoSize = true;

                TextBox tbUnitPrice = new TextBox();
                tbUnitPrice.Location = new Point(13, 9 + 19 + 9 + 27 + 9 + 19 + 9);
                tbUnitPrice.Size = new Size(200, 27);
                tbUnitPrice.Text = itemToEdit.UnitPrice.ToString();                
                newMaterial.Controls.Add(tbUnitPrice);

                Button saveButton = new Button();
                saveButton.Text = "Kaydet";
                saveButton.AutoSize = true;
                saveButton.Location = new Point(12, 9 + 19 + 9 + 27 + 9 + 19 + 9 + 27 + 9);
                saveButton.Click += (s, e2) =>
                {
                    try
                    {
                        result = new RawMaterial();
                        result.Name = tbName.Text;
                        result.UnitPrice = Convert.ToDecimal(tbUnitPrice.Text.Replace(".", ","));
                        newMaterial.DialogResult = DialogResult.OK;
                        newMaterial.Close();
                    }
                    catch (Exception aa)
                    {
                        MessageBox.Show("Kaydedilemedi : " + aa.Message);
                    }
                };

                newMaterial.Controls.Add(saveButton);


                Button cancelButton = new Button();
                cancelButton.Text = "İptal";
                cancelButton.AutoSize = true;
                cancelButton.Location = new Point(12 + 12 + saveButton.Width, 9 + 19 + 9 + 27 + 9 + 19 + 9 + 27 + 9);
                cancelButton.Click += (s, e2) =>
                {
                    try
                    {
                        result = null;
                        newMaterial.DialogResult = DialogResult.Cancel;
                        newMaterial.Close();
                    }
                    catch (Exception aa)
                    {
                        MessageBox.Show("Kaydedilemedi : " + aa.Message);
                    }
                };

                newMaterial.Controls.Add(cancelButton);


                if (newMaterial.ShowDialog() == DialogResult.OK)
                {
                    RawMaterial.Add(result);
                    listMaterials.Items.Add(result);
                    RawMaterial.Remove(itemToEdit);
                    listMaterials.Items.Remove(itemToEdit);
                }


            }
        }
    }
}
