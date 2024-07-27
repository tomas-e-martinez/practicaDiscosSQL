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
    public partial class Form1 : Form
    {
        private List<Disco> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDiscos.Load(imagen);
            }
            catch (Exception)
            {
                pbxDiscos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1BhBgvAdx2cQwiyvb-89VbGVzgQbB983tfw&s");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
        }

        private void cargar()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                listaDiscos = negocio.listar();
                dgvDiscos.DataSource = listaDiscos;
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                dgvDiscos.Columns["Id"].Visible = false;
                cargarImagen(listaDiscos[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEstilos_Click(object sender, EventArgs e)
        {
            frmEstilos frmEstilos = new frmEstilos();
            frmEstilos.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco frmAltaDisco = new frmAltaDisco();
            frmAltaDisco.Text = "Agregar disco";
            frmAltaDisco.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            frmAltaDisco frmModificarDisco = new frmAltaDisco(seleccionado);

            frmModificarDisco.Text = "Modificar disco";

            
            
            frmModificarDisco.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();

            try
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Eliminar '" + seleccionado.Titulo + "'?", "Eliminar disco", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado);
                    MessageBox.Show("'" + seleccionado.Titulo + "' eliminado con éxito.");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
