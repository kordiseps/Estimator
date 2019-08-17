using Estimator.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimator.App
{
    public partial class KitsForm : Form
    {
        public KitsForm()
        {
            InitializeComponent();

            var liste = Kit.Get<Kit>(Kit.KitsPath);
          
            foreach (Kit kit in liste)
            {
                listKits.Items.Add(kit);
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {

            using (Form newKitForm = new Form())
            {
                Kit result = null;

                newKitForm.Text = "Aparat ekle";
                newKitForm.Size = new Size(320, 240);
                newKitForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));


                Label lbName = new Label();
                lbName.Text = "Aparat İsmi";
                newKitForm.Controls.Add(lbName);
                lbName.Location = new Point(12, 9);
                lbName.AutoSize = true;

                TextBox tbName = new TextBox();
                tbName.Location = new Point(13, 9 + 19 + 9);
                tbName.Size = new Size(200, 27);
                newKitForm.Controls.Add(tbName);

                Label lbUnitPrice = new Label();
                lbUnitPrice.Text = "Aparat Birim fiyatı";
                newKitForm.Controls.Add(lbUnitPrice);
                lbUnitPrice.Location = new Point(12, 9 + 19 + 9 + 27 + 9);
                lbUnitPrice.AutoSize = true;

                TextBox tbUnitPrice = new TextBox();
                tbUnitPrice.Location = new Point(13, 9 + 19 + 9 + 27 + 9 + 19 + 9);
                newKitForm.Controls.Add(tbUnitPrice);
                tbUnitPrice.Size = new Size(200, 27);

                Button saveButton = new Button();
                saveButton.Text = "Kaydet";
                saveButton.Location = new Point(12, 9 + 19 + 9 + 27 + 9 + 19 + 9 + 27 + 9);
                saveButton.AutoSize = true;
                saveButton.Click += (s, e2) =>
                {
                    try
                    {
                        result = new Kit();
                        result.Name = tbName.Text;
                        result.UnitPrice = Convert.ToDecimal(tbUnitPrice.Text.Replace(".", ","));
                        newKitForm.DialogResult = DialogResult.OK;
                        newKitForm.Close();
                    }
                    catch (Exception aa)
                    {
                        MessageBox.Show("Kaydedilemedi : " + aa.Message);
                    }
                };

                newKitForm.Controls.Add(saveButton);


                Button cancelButton = new Button();
                cancelButton.Text = "İptal";
                cancelButton.AutoSize = true;
                cancelButton.Location = new Point(12 + 12 + saveButton.Width, 9 + 19 + 9 + 27 + 9 + 19 + 9 + 27 + 9);
                cancelButton.Click += (s, e2) =>
                {
                    try
                    {
                        result = null;
                        newKitForm.DialogResult = DialogResult.Cancel;
                        newKitForm.Close();
                    }
                    catch (Exception aa)
                    {
                        MessageBox.Show("Kaydedilemedi : " + aa.Message);
                    }
                };

                newKitForm.Controls.Add(cancelButton);


                if (newKitForm.ShowDialog() == DialogResult.OK)
                {
                    Kit.Add(result);
                    listKits.Items.Add(result);

                }


            }
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            Kit itemToRemove = (Kit)listKits.SelectedItem;

            if (itemToRemove == null)
            {
                return;
            }

            Kit.Remove(itemToRemove);
            listKits.Items.Remove(listKits.SelectedItem);
        }
    }
}
