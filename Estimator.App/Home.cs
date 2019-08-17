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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void RawMaterialMenuItem_Click(object sender, EventArgs e)
        {
            using (RawMaterialsForm newMaterial = new RawMaterialsForm())
            {
                newMaterial.ShowDialog();
            }
        }

        private void KitMenuItem_Click(object sender, EventArgs e)
        {

            using (KitsForm newKit = new KitsForm())
            {
                newKit.ShowDialog();
            }
        }
    }
}
