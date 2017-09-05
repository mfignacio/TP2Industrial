using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustrialTP2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            using (ABM frmABM = new ABM())
            { frmABM.ShowDialog(); }
        }

        private void btnExplosion_Click(object sender, EventArgs e)
        {
            using (Explosion frmExplosion = new Explosion())
            {
                frmExplosion.ShowDialog();
            }
        }

        private void btnImplosion_Click(object sender, EventArgs e)
        {
            using (Implosion frnImplosion = new Implosion())
            {
                frnImplosion.ShowDialog();
            }
        }
    }
}
