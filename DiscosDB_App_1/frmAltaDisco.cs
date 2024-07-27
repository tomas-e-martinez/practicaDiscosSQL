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
    public partial class frmAltaDisco : Form
    {
        private Disco disco = null;

        public frmAltaDisco()
        {
            InitializeComponent();
        }
        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();

            try
            {
                if(disco == null)
                    disco = new Disco();

                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = dtpFecha.Value;
                disco.CantidadCanciones = int.Parse(txtCanciones.Text);
                disco.Estilo = (Estilo)cboEstilo.SelectedItem;
                disco.TipoEdicion = (TipoEdicion)cboTipo.SelectedItem;
                disco.UrlImagenTapa = txtUrlImagen.Text;

                if(disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Disco modificado exitosamente.");
                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Disco agregado exitosamente.");
                }


                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tipoEdicionNegocio = new TipoEdicionNegocio();

            try
            {
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboTipo.DataSource = tipoEdicionNegocio.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";

                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    txtCanciones.Text = disco.CantidadCanciones.ToString();
                    dtpFecha.Value = disco.FechaLanzamiento;
                    txtUrlImagen.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                    cboTipo.SelectedValue = disco.TipoEdicion.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception)
            {
                pbxDisco.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1BhBgvAdx2cQwiyvb-89VbGVzgQbB983tfw&s");
            }
        }
    }
}
