using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace DiscosDB_App_1
{
    public partial class frmEstilos : Form
    {
        private List<Estilo> listaEstilos;
        public frmEstilos()
        {
            InitializeComponent();
        }

        private void frmEstilos_Load(object sender, EventArgs e)
        {
            EstiloNegocio negocio = new EstiloNegocio();
            listaEstilos = negocio.listar();
            dgvEstilos.DataSource = listaEstilos;
        }
    }
}
