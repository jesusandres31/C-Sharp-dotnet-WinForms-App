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
using Sistema_Coki.Interfaces;

namespace Sistema_Coki
{
    public partial class FAdministrador : Form
    {
        Validacion v = new Validacion();
        private int idUser = 0;
        private bool agregarPvWasClicked = false;
        private bool editarPvWasClicked = false;

        private bool agregarCliWasClicked = false;
        private bool editarCliWasClicked = false;

        private bool agregarPrdWasClicked = false;
        private bool editarPrdWasClicked = false;


        public bool unidadKg = false;
        public int idClien = 0;
        public int idProducto = 0;
        public decimal stock = 0;
        public decimal total = 0;
        private bool editarWasClicked = false;



        public FAdministrador(int _idUser, string nombre)
        {
            InitializeComponent();
            idUser = _idUser;
            lblUser.Text = nombre;
        }

        private void FAdministrador_Load(object sender, EventArgs e)
        {
            cbFTipoVenta.SelectedIndex = 0;
            ClsFacturacion.idFactura(lblFIDnum);

            ClsProveedor.refrescarProv(dgvProv);
            ClsCliente.refrescarCliente(dgvClien);
            ClsProducto.refrescarProd(dgvProd);

            ClsProducto.loadProveedores(cbProdProveed);
            ClsProducto.loadProveedores(cbPrdAgProveed);

            ClsFacturacion.refrscarFacturasA(dgvCabec);
        }




        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Los datos no guardados se perderan. Desea salir?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == DialogResult.Yes)
            {
                FLogin FLog = (FLogin)Application.OpenForms["FLogin"];
                FLog.Close();
                this.Close();
            }
        }

        private void CerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Los datos no guardados se perderan. Desea cerrar sesion?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == DialogResult.Yes)
            {
                this.Hide();
                FLogin FLog = new FLogin();
                FLog.ShowDialog();
                this.Close();
            }
        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CbTipoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbBulto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumerosReales(sender, e);
        }

        private void TbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (unidadKg == false)
            {
                v.soloNumeros(e);
            }
            else
            {
                v.soloNumerosReales(sender, e);
            }

        }

        private void TbDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumerosReales(sender, e);
        }

        private void TbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumerosReales(sender, e);
        }

        private void TbPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void CbTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LblFArticulo_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCliLimpiar_Click(object sender, EventArgs e)
        {
            SelectCliente oForm = new SelectCliente();
            oForm.ShowDialog();
        }

        public void seleccionar()
        {
            btnFBuscarCli.Enabled = false;
            btnFCancelarFactura.Enabled = true;
            btnFAceptarFactura.Enabled = true;
            btnFAceptar.Enabled = true;
            btnFCancelar.Enabled = true;
            btnFEditar.Enabled = true;
        }

        private void BtnFBuscarProd_Click(object sender, EventArgs e)
        {
            this.cerrarSelectProduct();
            SelectProducto oForm = new SelectProducto();
            oForm.Show();
        }

        private void cerrarSelectProduct()
        {
            if (Application.OpenForms.OfType<SelectProducto>().Count() == 1)
                Application.OpenForms.OfType<SelectProducto>().First().Close();
        }

        private void BtnFCancelarFactura_Click(object sender, EventArgs e)
        {
            this.cerrarSelectProduct();
            DialogResult ask = MessageBox.Show("Los datos no se guardara. Cancelar factura?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == DialogResult.Yes)
            {
                tbFCliente.Clear();
                tbFTel.Clear();
                tbFDni.Clear();
                tbFDirec.Clear();
                this.limpiarProdFacturac();
                dgvFacturacion.Rows.Clear();
                dgvFacturacion.Refresh();

                panelFDetalle.Enabled = false;
                btnFBuscarCli.Enabled = true;
                btnFBuscarProd.Enabled = false;
                btnFCancelar.Enabled = false;
                btnFAceptar.Enabled = false;
                btnFEditar.Enabled = false;
                dtFFecha.Value = DateTime.Now;
                btnFAceptarFactura.Enabled = false;
                btnFCancelarFactura.Enabled = false;
                cbFTipoVenta.SelectedIndex = 0;
            }
        }

        public void limpiarProdFacturac()
        {
            tbFArticulo.Clear();
            tbFPeso.Clear();
            tbFCantidad.Clear();
            tbFPrecio.Clear();
            tbFDescuento.Clear();
            unidadKg = false;
        }


        public void BtnFAceptar_Click(object sender, EventArgs e)
        {
            bool peso = true;
            if (unidadKg == true)
            {
                if (tbFPeso.Text == "")
                {
                    peso = false;
                }
            }

            decimal des = 0;

            if (String.IsNullOrEmpty(tbFDescuento.Text))
            {
                des = 0;
            }
            else
            {
                des = Convert.ToDecimal(tbFDescuento.Text);
            }

            if (tbFCantidad.Text == "" || peso == false)
            {
                MessageBox.Show("Debe ingresar los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool stockValido = false;
                decimal cantidad = Convert.ToDecimal(tbFCantidad.Text);
                if (stock < cantidad)
                {
                    stockValido = false;
                }
                else
                {
                    stockValido = true;
                }

                if (stockValido == false)
                {
                    MessageBox.Show("No hay suficiente stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (tbFDescuento.Text == "")
                        {
                            tbFDescuento.Text = "0";
                        }

                        decimal pesoOCantidad = 0;
                        if (unidadKg == true)
                        {
                            pesoOCantidad = Convert.ToDecimal(tbFPeso.Text);
                        }
                        else
                        {
                            pesoOCantidad = Convert.ToDecimal(tbFCantidad.Text);
                        }
                        decimal precio = Convert.ToDecimal(tbFPrecio.Text);
                        decimal descuento = Convert.ToDecimal(tbFDescuento.Text);
                        decimal subtotal = (pesoOCantidad * precio) - ((pesoOCantidad * precio) * descuento / 100);
                        decimal subtotalRound = Convert.ToDecimal(string.Format("{0:F2}", subtotal));

                        total = total + subtotal;
                        decimal decimalRounded = Decimal.Parse(total.ToString("0.00"));
                        lblFTotal.Text = Convert.ToString(decimalRounded);


                        string UM = " ";
                        if (unidadKg == false)
                        {
                            UM = "Ud";
                        }
                        else
                        {
                            UM = "Kg";
                        }

                        int index = dgvFacturacion.Rows.Add();
                        dgvFacturacion.Rows[index].Cells[0].Value = idProducto;
                        dgvFacturacion.Rows[index].Cells[1].Value = tbFArticulo.Text;
                        if (unidadKg == false)
                        {
                            dgvFacturacion.Rows[index].Cells[2].Value = 0;
                        }
                        else
                        {
                            dgvFacturacion.Rows[index].Cells[2].Value = tbFPeso.Text;
                        }
                        dgvFacturacion.Rows[index].Cells[3].Value = tbFCantidad.Text;
                        dgvFacturacion.Rows[index].Cells[4].Value = tbFPrecio.Text;
                        dgvFacturacion.Rows[index].Cells[5].Value = UM;
                        dgvFacturacion.Rows[index].Cells[6].Value = tbFDescuento.Text;
                        dgvFacturacion.Rows[index].Cells[7].Value = Convert.ToString(subtotalRound);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    this.limpiarProdFacturac();
                    unidadKg = false;
                    tbFPeso.Enabled = false;
                    lblFKg.Enabled = false;
                    lblFPeso.Enabled = false;
                    btnFAceptar.Enabled = false;
                    btnFBuscarProd.Enabled = true;
                    btnFBuscarProd.Focus();
                    btnFCancelar.Enabled = true;
                    btnFEditar.Enabled = true;
                    btnFAceptarFactura.Enabled = true;

                    if (editarWasClicked == true)
                    {
                        btnFAceptar.Enabled = false;
                        editarWasClicked = false;
                    }
                }
            }
        }

        private void BtnFCancelar_Click(object sender, EventArgs e)
        {
            if (dgvFacturacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay nada seleccionado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea eliminar item?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    total = total - Convert.ToDecimal(dgvFacturacion.SelectedRows[0].Cells[7].Value.ToString());
                    lblFTotal.Text = Convert.ToString(total);
                    foreach (DataGridViewRow item in this.dgvFacturacion.SelectedRows)
                    {
                        dgvFacturacion.Rows.RemoveAt(item.Index);
                    }
                }
                this.limpiarProdFacturac();
                btnFBuscarProd.Enabled = true;
            }
        }


        private void BtnFEditar_Click(object sender, EventArgs e)
        {
            if (dgvFacturacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay nada seleccionado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbFArticulo.Text = dgvFacturacion.SelectedRows[0].Cells[1].Value.ToString();
                tbFPeso.Text = dgvFacturacion.SelectedRows[0].Cells[2].Value.ToString();
                tbFCantidad.Text = dgvFacturacion.SelectedRows[0].Cells[3].Value.ToString();
                tbFPrecio.Text = dgvFacturacion.SelectedRows[0].Cells[4].Value.ToString();
                tbFDescuento.Text = dgvFacturacion.SelectedRows[0].Cells[6].Value.ToString();

                if (dgvFacturacion.SelectedRows[0].Cells[5].Value.ToString() == "Kg")
                {
                    tbFPeso.Enabled = true;
                    lblFKg.Enabled = true;
                    lblFPeso.Enabled = true;
                    unidadKg = true;
                }
                else if (dgvFacturacion.SelectedRows[0].Cells[5].Value.ToString() == "Ud")
                {
                    tbFPeso.Enabled = false;
                    lblFKg.Enabled = false;
                    lblFPeso.Enabled = false;
                    unidadKg = false;
                }

                total = total - Convert.ToDecimal(dgvFacturacion.SelectedRows[0].Cells[7].Value.ToString());
                lblFTotal.Text = Convert.ToString(total);
                foreach (DataGridViewRow item in this.dgvFacturacion.SelectedRows)
                {
                    dgvFacturacion.Rows.RemoveAt(item.Index);
                }
                btnFCancelar.Enabled = false;
                btnFEditar.Enabled = false;
                btnFAceptar.Enabled = true;
                btnFBuscarProd.Enabled = false;
                btnFAceptarFactura.Enabled = false;
                editarWasClicked = true;
            }
        }

        private void BtnFAceptarFactura_Click(object sender, EventArgs e)
        {
            this.cerrarSelectProduct();
            DialogResult ask = MessageBox.Show("Aceptar factura?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                ClsFacturacion.guardarFactura(tbFCliente, dtFFecha, cbFTipoVenta, tbFDirec, tbFTel, tbFDni,
                                                dgvFacturacion, lblFIDnum, total, idClien, idUser);

                ClsFacturacion.refrscarFacturasV(dgvCabec, idUser);

                btnFCancelar.Enabled = false;
                btnFAceptar.Enabled = false;
                btnFEditar.Enabled = false;
                btnFAceptarFactura.Enabled = false;
                btnFCancelarFactura.Enabled = false;
                btnFBuscarCli.Enabled = false;
                btnFBuscarProd.Enabled = false;
                cbFTipoVenta.Enabled = false;
                btnFImprimirFact.Enabled = true;
                btnFNuevaFact.Enabled = true;
            }
        }

        private void BtnFNuevaFact_Click(object sender, EventArgs e)
        {
            this.nuevaFact();
        }

        private void nuevaFact()
        {
            btnFBuscarCli.Focus();
            btnFBuscarCli.Enabled = true;
            this.limpiarProdFacturac();
            unidadKg = false;
            tbFPeso.Enabled = false;
            lblFKg.Enabled = false;
            lblFPeso.Enabled = false;
            btnFAceptar.Enabled = false;
            btnFCancelar.Enabled = false;
            btnFEditar.Enabled = false;
            btnFAceptarFactura.Enabled = false;
            btnFCancelarFactura.Enabled = false;
            btnFImprimirFact.Enabled = false;
            btnFNuevaFact.Enabled = false;
            btnFBuscarProd.Enabled = false;

            dgvFacturacion.Rows.Clear();
            dgvFacturacion.Refresh();
            tbFCliente.Clear();
            dtFFecha.Value = DateTime.Now;
            cbFTipoVenta.SelectedIndex = 0;
            cbFTipoVenta.Enabled = true;
            ClsFacturacion.idFactura(lblFIDnum);
            tbFDirec.Clear();
            tbFTel.Clear();
            tbFDni.Clear();

            total = 0;
            lblFTotal.Text = Convert.ToString(total);

            ClsFacturacion.idFactura(lblFIDnum);
        }

        private void DgvFacturacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void contarItemsDgvFactur(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //est afuncion musetra num item en datagridview
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void DgvFacturacion_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.contarItemsDgvFactur(sender, e);
        }

        private void PanelFCabecera_Paint(object sender, PaintEventArgs e)
        {

        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //PROVEEDOR////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void panelBuscarProv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabProveedores_Click(object sender, EventArgs e)
        {

        }

        private void BtPvAgGuardar_Click(object sender, EventArgs e)
        {
            if (agregarPvWasClicked == true)
            {
                this.guardarProv();
            }
            else if (editarPvWasClicked == true)
            {
                this.editarProv();
            }
        }

        private void TbPvNombre_TextChanged(object sender, EventArgs e)
        {
            ClsProveedor.buscarProv(tbPvNombre, tbPvTel, tbPvDni, dgvProv);
        }

        private void TbPvTel_TextChanged(object sender, EventArgs e)
        {
            ClsProveedor.buscarProv(tbPvNombre, tbPvTel, tbPvDni, dgvProv);
        }

        private void TbPvCuil_TextChanged(object sender, EventArgs e)
        {
            ClsProveedor.buscarProv(tbPvNombre, tbPvTel, tbPvDni, dgvProv);
        }

        private void BtPvAgCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarPv();
            panelAgregarProv.Enabled = false;
            lblAgregarProv.Visible = true;
            lblEditarProv.Visible = false;
        }

        private void BtnPvLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarBuscPv();
        }

        private void PanelAgregarProv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Los datos no guardados se perderan. Desea salir?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == DialogResult.Yes)
            {
                FLogin FLog = (FLogin)Application.OpenForms["FLogin"];
                FLog.Close();
                this.Close();
            }
        }

        private void CerrarSersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Los datos no guardados se perderan. Desea cerrar sesion?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == DialogResult.Yes)
            {
                this.Hide();
                FLogin FLog = new FLogin();
                FLog.ShowDialog();
                this.Close();
            }
        }

        private void TbPvNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void TbPvTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbPvCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbPvAgNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasNumerosYEspacio(e);
        }

        private void TbPvAgTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbPvAgDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void btnPvAgregar_Click(object sender, EventArgs e)
        {
            this.limpiarPv();
            panelAgregarProv.Enabled = true;
            lblAgregarProv.Visible = true;
            lblEditarProv.Visible = false;
            agregarPvWasClicked = true;
            editarPvWasClicked = false;
        }

        private void BtnPvEditar_Click(object sender, EventArgs e)
        {
            panelAgregarProv.Enabled = true;
            lblAgregarProv.Visible = false;
            lblEditarProv.Visible = true;
            editarPvWasClicked = true;
            agregarPvWasClicked = false;

            ClsProveedor.obtenerProv(tbPvAgNombre, email, tbPvAgTel, tbPvAgDni, dgvProv);
        }

        private void BtnPvEliminar_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(dgvProv.SelectedRows[0].Cells[5].Value.ToString());

            this.limpiarPv();
            panelAgregarProv.Enabled = false;

            if (estado == 0)
            {
                MessageBox.Show("El proveedor seleccionado ya está eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea eliminar proveedor?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsProveedor.eliminarProv(dgvProv);

                        MessageBox.Show("El proveedor se elimino correctamente", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarBuscPv();

                        ClsProveedor.refrescarProv(dgvProv);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsProveedor.refrescarProv(dgvProv);
                }
            }
        }

        private void BtnPvHabilitar_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(dgvProv.SelectedRows[0].Cells[5].Value.ToString());

            this.limpiarPv();
            panelAgregarProv.Enabled = false;

            if (estado == 1)
            {
                MessageBox.Show("El proveedor seleccionado ya está habilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Habilitar proveedor nuevamente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsProveedor.habilitarProv(dgvProv);

                        MessageBox.Show("El proveedor está ahora habilitado", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarBuscPv();

                        ClsProveedor.refrescarProv(dgvProv);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsProveedor.refrescarProv(dgvProv);
                }
            }
        }


        private void guardarProv()
        {
            if (tbPvAgNombre.Text == "" || tbPvAgTel.Text == "" || tbPvAgDni.Text == "")
            {
                MessageBox.Show("Debe completar los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo proveedor?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsProveedor.guardarProv(tbPvAgNombre, email, tbPvAgTel, tbPvAgDni, dgvProv);
                        panelAgregarProv.Enabled = false;

                        ClsProveedor.refrescarProv(dgvProv);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsProveedor.refrescarProv(dgvProv);
                    this.limpiarPv();
                    agregarPvWasClicked = false;
                }
            }
        }

        private void editarProv()
        {
            if (tbPvAgNombre.Text == "" || tbPvAgTel.Text == "" || tbPvAgDni.Text == "")
            {
                MessageBox.Show("Debe completar los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea actualizar proveedor?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsProveedor.editarProv(tbPvAgNombre, email, tbPvAgTel, tbPvAgDni, dgvProv);
                        panelAgregarProv.Enabled = false;

                        ClsProveedor.refrescarProv(dgvProv);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsProveedor.refrescarProv(dgvProv);
                    this.limpiarPv();
                    editarPvWasClicked = false;
                    ClsProducto.loadProveedores(cbProdProveed);
                    ClsProducto.loadProveedores(cbPrdAgProveed);
                }
            }
        }

        private void limpiarPv()
        {
            tbPvAgDni.Clear();
            email.Clear();
            tbPvAgNombre.Clear();
            tbPvAgTel.Clear();
        }

        private void limpiarBuscPv()
        {
            tbPvDni.Clear();
            email.Clear();
            tbPvNombre.Clear();
            tbPvTel.Clear();
        }

        private void DgvProv_Click(object sender, EventArgs e)
        {
            this.limpiarPv();
            panelAgregarProv.Enabled = false;
        }

        private void DgvProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvProv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvProv.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[5].Value) == 0)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Salmon;
                }
            }

            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "estado" && e.RowIndex >= 0 && dgv["estado", e.RowIndex].Value is int)
            {
                switch ((int)dgv["estado", e.RowIndex].Value)
                {
                    case 0:
                        e.Value = "Inactivo";
                        e.FormattingApplied = true;
                        break;
                    case 1:
                        e.Value = "Activo";
                        e.FormattingApplied = true;
                        break;
                }
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //CLIENTES/////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void TbCliNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void TbCliTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbCliCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbCliDirec_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasNumerosYEspacio(e);
        }

        private void TbCliAgDirec_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasNumerosYEspacio(e);
        }

        private void TbCliAgCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbCliAgTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbCliAgNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void TbCliAgCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnCliLimpiarBuscCl_Click(object sender, EventArgs e)
        {
            this.limpiarBuscCl();
        }

        private void limpiarBuscCl()
        {
            tbCliNombre.Clear();
            tbCliTel.Clear();
            tbCliDni.Clear();
            tbCliDirec.Clear();
        }

        private void limpiarCl()
        {
            tbCliAgNombre.Clear();
            tbCliAgTel.Clear();
            tbCliAgCorreo.Clear();
            tbCliAgDni.Clear();
            tbCliAgDirec.Clear();
        }

        private void BtnCliHabilitar_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(dgvClien.SelectedRows[0].Cells[6].Value.ToString());

            this.limpiarCl();
            panelAgregarClien.Enabled = false;

            if (estado == 1)
            {
                MessageBox.Show("El cliente seleccionado ya está habilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Habilitar cliente nuevamente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsCliente.habilitarCliente(dgvClien);

                        MessageBox.Show("El cliente está ahora habilitado", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarBuscCl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsCliente.refrescarCliente(dgvClien);
                }
            }
        }

        private void BtnCliEliminar_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(dgvClien.SelectedRows[0].Cells[6].Value.ToString());

            this.limpiarCl();
            panelAgregarClien.Enabled = false;

            if (estado == 0)
            {
                MessageBox.Show("El cliente seleccionado ya está eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea eliminar cliente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsCliente.eliminarCliente(dgvClien);

                        MessageBox.Show("El cliente se elimino correctamente", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarBuscCl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsCliente.refrescarCliente(dgvClien);
                }
            }
        }

        private void BtnCliAgregar_Click(object sender, EventArgs e)
        {
            this.limpiarCl();
            panelAgregarClien.Enabled = true;
            lblAgregarClien.Visible = true;
            lblEditarClien.Visible = false;
            agregarCliWasClicked = true;
            editarCliWasClicked = false;
        }

        private void BtnCliEditar_Click(object sender, EventArgs e)
        {
            panelAgregarClien.Enabled = true;
            lblAgregarClien.Visible = false;
            lblEditarClien.Visible = true;
            editarCliWasClicked = true;
            agregarCliWasClicked = false;

            ClsCliente.obtenerCliente(tbCliAgNombre, tbCliAgCorreo, tbCliAgTel, tbCliAgDni, tbCliAgDirec, dgvClien);
        }

        private void BtnCliAgGuardar_Click(object sender, EventArgs e)
        {
            if (agregarCliWasClicked == true)
            {
                this.guardarClien();
            }
            else if (editarCliWasClicked == true)
            {
                this.editarClien();
            }
        }

        private void guardarClien()
        {
            if (tbCliAgNombre.Text == "" || tbCliAgTel.Text == "" || tbCliAgDni.Text == "" || tbCliAgDirec.Text == ""
                || v.isValidEmail(tbCliAgCorreo.Text) == false)
            {
                MessageBox.Show("Debe completar los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo cliente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsCliente.guardarCliente(tbCliAgNombre, tbCliAgCorreo, tbCliAgTel, tbCliAgDni, tbCliAgDirec, dgvClien);
                        panelAgregarClien.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsCliente.refrescarCliente(dgvClien);
                    this.limpiarCl();
                    agregarCliWasClicked = false;
                }
            }
        }

        private void editarClien()
        {
            if (tbCliAgNombre.Text == "" || tbCliAgTel.Text == "" || tbCliAgDni.Text == "" || tbCliAgDirec.Text == ""
                || v.isValidEmail(tbCliAgCorreo.Text) == false)
            {
                MessageBox.Show("Debe completar los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea actualizar cliente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsCliente.editarCliente(tbCliAgNombre, tbCliAgCorreo, tbCliAgTel, tbCliAgDni, tbCliAgDirec, dgvClien);
                        panelAgregarClien.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsCliente.refrescarCliente(dgvClien);
                    this.limpiarCl();
                    editarCliWasClicked = false;
                }
            }
        }

        private void BtnCliAgCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarCl();
            panelAgregarClien.Enabled = false;
            lblAgregarClien.Visible = true;
            lblEditarClien.Visible = false;
        }

        private void DgvClien_Click(object sender, EventArgs e)
        {
            this.limpiarCl();
            panelAgregarClien.Enabled = false;
        }

        private void DgvClien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvClien.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[6].Value) == 0)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Salmon;
                }
            }

            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "estado" && e.RowIndex >= 0 && dgv["estado", e.RowIndex].Value is int)
            {
                switch ((int)dgv["estado", e.RowIndex].Value)
                {
                    case 0:
                        e.Value = "Inactivo";
                        e.FormattingApplied = true;
                        break;
                    case 1:
                        e.Value = "Activo";
                        e.FormattingApplied = true;
                        break;
                }
            }
        }

        private void TbCliNombre_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.buscarCliente(tbCliNombre, tbCliTel, tbCliDni, tbCliDirec, dgvClien);
        }

        private void TbCliTel_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.buscarCliente(tbCliNombre, tbCliTel, tbCliDni, tbCliDirec, dgvClien);
        }

        private void TbCliCuit_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.buscarCliente(tbCliNombre, tbCliTel, tbCliDni, tbCliDirec, dgvClien);
        }

        private void TbCliDirec_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.buscarCliente(tbCliNombre, tbCliTel, tbCliDni, tbCliDirec, dgvClien);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //PRODUCTOS////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbProdDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasNumerosYEspacio(e);
        }

        private void TbPvAgCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TbPrdAgDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasNumerosYEspacio(e);
        }

        private void TbPrdAgStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumerosReales(sender, e);
        }

        private void TbPrdAgPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumerosReales(sender, e);
        }

        private void limpiarProd()
        {
            tbPrdAgDescrip.Clear();
            tbPrdAgStock.Clear();
            tbPrdAgPrecio.Clear();
            cbPrdAgProveed.SelectedItem = null;
            rbPrdAgUd.Checked = true;
            rbPrdAgKg.Checked = false;
        }

        private void limpiarBuscProd()
        {
            tbProdDescrip.Clear();
            cbProdProveed.SelectedItem = null;
            cbProdUnidad.SelectedItem = null;
        }

        private void BtnProdHabilitar_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(dgvProd.SelectedRows[0].Cells[6].Value.ToString());

            this.limpiarProd();
            panelAgregarProd.Enabled = false;

            if (estado == 1)
            {
                MessageBox.Show("El producto seleccionado ya está habilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Habilitar producto nuevamente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsProducto.habilitarProd(dgvProd);

                        MessageBox.Show("El producto está ahora habilitado", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarBuscCl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsProducto.refrescarProd(dgvProd);
                }
            }
        }

        private void BtnProdEliminar_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(dgvProd.SelectedRows[0].Cells[6].Value.ToString());

            this.limpiarProd();
            panelAgregarProd.Enabled = false;

            if (estado == 0)
            {
                MessageBox.Show("El producto seleccionado ya está eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea eliminar producto?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsProducto.eliminarProd(dgvProd);

                        MessageBox.Show("El producto se elimino correctamente", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarBuscCl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsProducto.refrescarProd(dgvProd);
                }
            }
        }

        private void BtnProdAgregar_Click(object sender, EventArgs e)
        {
            this.limpiarProd();
            panelAgregarProd.Enabled = true;
            lblAgregarProd.Visible = true;
            lblEditarProd.Visible = false;
            agregarPrdWasClicked = true;
            editarPrdWasClicked = false;
        }

        private void BtnProdEditar_Click(object sender, EventArgs e)
        {
            panelAgregarProd.Enabled = true;
            lblAgregarProd.Visible = false;
            lblEditarProd.Visible = true;
            editarPrdWasClicked = true;
            agregarPrdWasClicked = false;

            ClsProducto.obtenerProd(tbPrdAgDescrip, cbPrdAgProveed, tbPrdAgStock, rbPrdAgUd, rbPrdAgKg, tbPrdAgPrecio, dgvProd);
        }

        private void BtnProdLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarBuscProd();
        }

        private void BtnProdAgGuardar_Click(object sender, EventArgs e)
        {
            if (agregarPrdWasClicked == true)
            {
                this.guardarProd();
            }
            else if (editarPrdWasClicked == true)
            {
                this.editarProd();
            }
        }

        private void BtnProdAgCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarProd();
            panelAgregarProd.Enabled = false;
            lblAgregarProd.Visible = true;
            lblEditarProd.Visible = false;
        }

        private void guardarProd()
        {
            if (tbPrdAgDescrip.Text == "" || cbPrdAgProveed.Text == "" || tbPrdAgStock.Text == "" || tbPrdAgPrecio.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo producto?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        string unidad = " ";

                        if (rbPrdAgUd.Checked == true && rbPrdAgKg.Checked == false)
                        {
                            unidad = "Ud";
                        }
                        else if (rbPrdAgUd.Checked == false && rbPrdAgKg.Checked == true)
                        {
                            unidad = "Kg";
                        }

                        ClsProducto.guardarProd(tbPrdAgDescrip, cbPrdAgProveed, tbPrdAgStock, unidad, tbPrdAgPrecio, dgvProv);
                        panelAgregarProd.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsProducto.refrescarProd(dgvProd);
                    this.limpiarProd();
                    agregarPrdWasClicked = false;
                }
            }
        }

        public void editarProd()
        {
            if (tbPrdAgDescrip.Text == "" || cbPrdAgProveed.Text == "" || tbPrdAgStock.Text == "" || tbPrdAgPrecio.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea actualizar producto?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        string unidad = " ";

                        if (rbPrdAgUd.Checked == true && rbPrdAgKg.Checked == false)
                        {
                            unidad = "Ud";
                        }
                        else if (rbPrdAgUd.Checked == false && rbPrdAgKg.Checked == true)
                        {
                            unidad = "Kg";
                        }

                        ClsProducto.editarProd(tbPrdAgDescrip, cbPrdAgProveed, tbPrdAgStock, unidad, tbPrdAgPrecio, dgvProd);
                        panelAgregarProd.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsProducto.refrescarProd(dgvProd);
                    this.limpiarProd();
                    editarPrdWasClicked = false;
                }
            }
        }


        private void DgvProd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvProd.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[6].Value) == 0)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Salmon;
                }

                DataGridView dgv = (DataGridView)sender;
                if (dgv.Columns[e.ColumnIndex].Name == "estado" && e.RowIndex >= 0 && dgv["estado", e.RowIndex].Value is int)
                {
                    switch ((int)dgv["estado", e.RowIndex].Value)
                    {
                        case 0:
                            e.Value = "Inactivo";
                            e.FormattingApplied = true;
                            break;
                        case 1:
                            e.Value = "Activo";
                            e.FormattingApplied = true;
                            break;
                    }
                }
            }
        }

        private void TbProdDescrip_TextChanged(object sender, EventArgs e)
        {
            ClsProducto.buscarProd(tbProdDescrip, cbProdProveed, cbProdUnidad, dgvProd);
        }

        private void CbProdProveed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsProducto.buscarProd(tbProdDescrip, cbProdProveed, cbProdUnidad, dgvProd);
        }

        private void cbProdUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsProducto.buscarProd(tbProdDescrip, cbProdProveed, cbProdUnidad, dgvProd);
        }

        private void DgvProd_Click(object sender, EventArgs e)
        {
            this.limpiarProd();
            panelAgregarProd.Enabled = false;
        }

        private void TabProductos_Click(object sender, EventArgs e)
        {

        }

        private void menuStripVend_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnRLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnRSelec_Click(object sender, EventArgs e)
        {

        }

        private void cbRTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRBLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void tbRCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvCabec_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCabec_Click(object sender, EventArgs e)
        {

        }

        private void cbRFechaHasB_CheckedChanged(object sender, EventArgs e)
        {

        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////REPORTE/////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnRHoy_Click(object sender, EventArgs e)
        {
            dtRFecha.Value = DateTime.Now;
        }

        private void btnRBLimpiar_Click_1(object sender, EventArgs e)
        {
            this.limpiarBusquedaRep();
        }

        private void btnRBVerDetalle_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Imprimir factura?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                Factura oFact = new Factura();
                oFact.idfactura = Convert.ToInt32(dgvCabec.SelectedRows[0].Cells[0].Value.ToString());
                oFact.ShowDialog();
            }
        }

        private void cbRFechaDesHasB_CheckedChanged(object sender, EventArgs e)
        {
            if (dtRFechaDesB.Enabled == false && dtRFechaHasB.Enabled == false)
            {
                dtRFechaDesB.Enabled = true;
                dtRFechaHasB.Enabled = true;
            }
            else
            {
                dtRFechaDesB.Enabled = false;
                dtRFechaHasB.Enabled = false;
                ClsFacturacion.refrscarFacturasA(dgvCabec);
            }

            if (cbRFechaB.Checked == true)
                cbRFechaB.Checked = false;
            dtRFechaB.Enabled = false;
        }

        private void cbRFechaB_CheckedChanged(object sender, EventArgs e)
        {
            if (dtRFechaB.Enabled == true)
            {
                dtRFechaB.Enabled = false;
                ClsFacturacion.refrscarFacturasA(dgvCabec);
            }
            else
            {
                dtRFechaB.Enabled = true;
            }

            if (cbRFechaDesHasB.Checked == true)
                cbRFechaDesHasB.Checked = false;
            dtRFechaDesB.Enabled = false;
            dtRFechaHasB.Enabled = false;
        }

        private void tbRCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void tbRCliente_TextChanged_1(object sender, EventArgs e)
        {
            this.filtrarFactura();
        }

        private void cbRTipoVenta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.filtrarFactura();
        }

        private void dgvCabec_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ClsFacturacion.refrescarPedidos(dgvCabec, dgvDetall);
        }

        private void limpiarBusquedaRep()
        {
            cbRTipoVenta.SelectedIndex = -1;
            tbRCliente.Clear();
            dtRFechaB.Value = DateTime.Now;
            dtRFechaDesB.Value = DateTime.Now;
            dtRFechaHasB.Value = DateTime.Now;
            cbRFechaB.Checked = false;
            cbRFechaDesHasB.Checked = false;
            ClsFacturacion.refrscarFacturasA(dgvCabec);
        }

        private void filtrarFactura()
        {
            if (cbRFechaB.Checked == true && cbRFechaDesHasB.Checked == false)
            {
                DateTime fecha = Convert.ToDateTime(dtRFechaB.Value.ToShortDateString());
                ClsFacturacion.buscarFactFechaA(tbRCliente, cbRTipoVenta, fecha, dgvCabec);
            }
            else if (cbRFechaB.Checked == false && cbRFechaDesHasB.Checked == true)
            {
                DateTime fechaD = Convert.ToDateTime(dtRFechaDesB.Value.ToShortDateString());
                DateTime fechaH = Convert.ToDateTime(dtRFechaHasB.Value.ToShortDateString());

                if (fechaD > fechaH)
                {
                    MessageBox.Show("La fecha 'Desde' es superior a la fecha 'Hasta'", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClsFacturacion.refrscarFacturasA(dgvCabec);
                    this.limpiarBusquedaRep();
                }
                else
                {
                    ClsFacturacion.buscarFactFechaDesHasA(tbRCliente, cbRTipoVenta, fechaD, fechaH, dgvCabec);
                }
            }
            else
            {
                ClsFacturacion.buscarFactA(tbRCliente, cbRTipoVenta, dgvCabec);
            }
        }

        private void contarItemsDgv(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //est afuncion musetra num item en datagridview
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dgvProd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.contarItemsDgv(sender, e);
        }

        private void dgvClien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.contarItemsDgv(sender, e);
        }

        private void dgvProv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.contarItemsDgv(sender, e);
        }

        private void dgvCabec_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.contarItemsDgv(sender, e);
        }

        private void dgvDetall_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.contarItemsDgv(sender, e);
        }

        private void tabReportes_Click(object sender, EventArgs e)
        {

        }

        private void dtRFechaB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtRFechaDesB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtRFechaHasB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRBBuscar_Click(object sender, EventArgs e)
        {
            this.filtrarFactura();
        }

        private void btnRSelec_Click_1(object sender, EventArgs e)
        {
            Reparto oRep = new Reparto();
            oRep.fecha = dtRFecha.Value;
            oRep.ShowDialog();
        }

        private void tbPvAgNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPvAgCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFImprimirFact_Click(object sender, EventArgs e)
        {

        }
    }
}
