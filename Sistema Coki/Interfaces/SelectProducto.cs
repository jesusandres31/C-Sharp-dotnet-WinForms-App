using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Coki.Clases;
using Validaciones;

namespace Sistema_Coki.Interfaces
{
    public partial class SelectProducto : Form
    {
        Validacion v = new Validacion();
        public SelectProducto()
        {
            InitializeComponent();
        }

        private void SelectProducto_Load(object sender, EventArgs e)
        {
            ClsProducto.loadProveedores(cbProdProveed);
            ClsProducto.refrescarProductosHabilitados(dgvProd);
            this.dgvProd.Columns["estado"].Visible = false;
        }

        private void TbProdDescrip_TextChanged(object sender, EventArgs e)
        {
            ClsProducto.buscarProd(tbProdDescrip, cbProdProveed, cbProdProveed, dgvProd);
        }

        private void TbProdDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasNumerosYEspacio(e);
        }

        private void BtnCliLimpiar_Click(object sender, EventArgs e)
        {
            tbProdDescrip.Clear();
            cbProdProveed.SelectedItem = null;
        }

        private void CbProdProveed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsProducto.buscarProd(tbProdDescrip, cbProdProveed, cbProdProveed, dgvProd);
        }

        private void DgvProd_KeyDown(object sender, KeyEventArgs e)
        {
            this.seleccionar();
        }

        private void DgvProd_DoubleClick(object sender, EventArgs e)
        {
            this.seleccionar();
        }

        private void seleccionar()
        {
            FAdministrador oAdmin = (FAdministrador)Application.OpenForms["FAdministrador"];

            oAdmin.idProducto = Convert.ToInt32(dgvProd.SelectedRows[0].Cells[0].Value.ToString());
            oAdmin.stock = Convert.ToDecimal(dgvProd.SelectedRows[0].Cells[3].Value.ToString());
            oAdmin.tbFArticulo.Text = dgvProd.SelectedRows[0].Cells[1].Value.ToString();
            oAdmin.tbFPrecio.Text = dgvProd.SelectedRows[0].Cells[5].Value.ToString();

            if (dgvProd.SelectedRows[0].Cells[4].Value.ToString() == "Ud")
            {
                oAdmin.unidadKg = false;
                oAdmin.tbFPeso.Enabled = false;
                oAdmin.lblFKg.Enabled = false;
                oAdmin.lblFPeso.Enabled = false;
            }
            else if (dgvProd.SelectedRows[0].Cells[4].Value.ToString() == "Kg")
            {
                oAdmin.unidadKg = true;
                oAdmin.tbFPeso.Enabled = true;
                oAdmin.lblFKg.Enabled = true;
                oAdmin.lblFPeso.Enabled = true;
            }

            foreach (DataGridViewRow row in oAdmin.dgvFacturacion.Rows)
            {
                if (Convert.ToString(row.Cells[1].Value) == oAdmin.tbFArticulo.Text)
                {
                    MessageBox.Show("Producto ya ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    oAdmin.limpiarProdFacturac();
                    oAdmin.btnFAceptar.Enabled = false;
                    oAdmin.lblFKg.Enabled = false;
                    oAdmin.lblFPeso.Enabled = false;
                    oAdmin.tbFPeso.Enabled = false;
                    break;
                }
            }
            this.Close();
            oAdmin.btnFAceptar.Enabled = true;
        }

        private void panelBuscarProd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



//        foreach (DataGridViewRow row in oVend.dgvFacturacion.Rows)
//{
//    if (row.Cells[0].Value == oVend.tbFArticulo.Text)
//    {
//        MessageBox.Show("Row already exists");
//        break;
//    }
//}


//if (oVend.dgvFacturacion.DataSource != null)
//{
//    oVend.dgvFacturacion.DataSource = null;
//}
//else
//{
//    oVend.dgvFacturacion.Rows.Clear();
//}

//int index = oVend.dgvFacturacion.Rows.Add();
//oVend.dgvFacturacion.Rows[index].Cells[0].Value = dgvProd.SelectedRows[0].Cells[1].Value.ToString();
//oVend.dgvFacturacion.Rows[index].Cells[1].Value = dgvProd.SelectedRows[0].Cells[1].Value.ToString();