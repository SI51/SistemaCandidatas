using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Logica.Modelo;
using Escritorio.Controlador;

namespace Escritorio.Vista
{
    public partial class frmMunicipio : Form
    {
        public void CargarDatos()
        {
            this.dgvDatosMunicipio.DataSource = MunicipioManager.ListarTodo();
        }
        public frmMunicipio()
        {
            InitializeComponent();
            //dgvDatosMunicipio.AutoGenerateColumns = false;
        }

        private void frmMunicipio_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
    }
}
