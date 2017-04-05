using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escritorio.Vista.frmMunicipio municipio = new Vista.frmMunicipio();
            municipio.Show();
        }
    }
}
