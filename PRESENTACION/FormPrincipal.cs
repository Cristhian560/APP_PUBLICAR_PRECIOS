using AppPublicarPrecios.ACCESO_A_DATOS.IMPLEMENTACIONES;
using AppPublicarPrecios.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPublicarPrecios.PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        private LeerExcel leerExcel;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnPublicar.Enabled = false;
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }
        private void CargarGrillaProductos(List<CodigoProducto> lista)
        {
            dgvProductos.Rows.Clear();
            foreach (CodigoProducto s in lista)
            {
                dgvProductos.Rows.Add(new object[] { s.Codigo });
            }
            lblTotalCodigoProducto.Text = lista.Count().ToString()+" Productos";
        }
        private void CargarGrillaProveedores(List<CodigoProveedor> lista)
        {
            dgvProveedores.Rows.Clear();
            foreach (CodigoProveedor s in lista)
            {
                dgvProveedores.Rows.Add(new object[] { s.Codigo });
            }
            lblTotalCodigoProveedores.Text=lista.Count().ToString()+" Proveedores";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFileDialog.ShowDialog();

            try
            {
                leerExcel = new LeerExcel(openFileDialog.FileName);
                CargarGrillaProductos(leerExcel.ListaCodigoProducto());
                CargarGrillaProveedores(leerExcel.ListaCodigoProveedor());
                btnPublicar.Enabled = true;
            }
            catch
            {
                btnPublicar.Enabled=false;
            }
        }
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Publicar ?", "PUBLICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CodigosDAO p = new CodigosDAO();
                if (leerExcel.lista_codigo_productos.Count() > 0)
                {
                    if (p.PublicarProducto(leerExcel.lista_codigo_productos))
                    {
                        MessageBox.Show("Se actualizaron los precios de los PRODUCTOS", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (leerExcel.lista_codigos_proveedores.Count() > 0)
                {
                    if (p.PublicarProveedor(leerExcel.lista_codigos_proveedores))
                    {
                        MessageBox.Show("Se actualizaron los precios de todos los productos de los PROVEEDORES", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
