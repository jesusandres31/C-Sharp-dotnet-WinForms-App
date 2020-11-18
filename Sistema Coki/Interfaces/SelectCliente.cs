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
    public partial class SelectCliente : Form
    {
        Validacion v = new Validacion();

        public SelectCliente()
        {
            InitializeComponent();
        }

        private void SelectCliente_Load(object sender, EventArgs e)
        {
            ClsCliente.refrescarClientesHabilitados(dgvClien);
            this.dgvClien.Columns["estado"].Visible = false;
        }

        private void TbCliNombre_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.buscarCliente(tbCliNombre, tbCliTel, tbCliCuit, tbCliDirec, dgvClien);
        }

        private void TbCliTel_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.buscarCliente(tbCliNombre, tbCliTel, tbCliCuit, tbCliDirec, dgvClien);
        }

        private void TbCliCuit_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.buscarCliente(tbCliNombre, tbCliTel, tbCliCuit, tbCliDirec, dgvClien);
        }

        private void TbCliDirec_TextChanged(object sender, EventArgs e)
        {
            ClsCliente.buscarCliente(tbCliNombre, tbCliTel, tbCliCuit, tbCliDirec, dgvClien);
        }

        private void TbCliDirec_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasNumerosYEspacio(e);
        }

        private void TbCliTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbCliNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void TbCliCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void BtnCliLimpiar_Click(object sender, EventArgs e)
        {
            tbCliNombre.Clear();
            tbCliTel.Clear();
            tbCliCuit.Clear();
            tbCliDirec.Clear();
        }

        private void DgvClien_Enter(object sender, EventArgs e)
        {

        }

        private void DgvClien_DoubleClick(object sender, EventArgs e)
        {
            this.seleccionar();
        }

        private void DgvClien_KeyDown(object sender, KeyEventArgs e)
        {
            this.seleccionar();
        }

        private void seleccionar()
        {
            FAdministrador oAdmin = (FAdministrador)Application.OpenForms["FAdministrador"];

            oAdmin.idClien = Convert.ToInt32(dgvClien.SelectedRows[0].Cells[0].Value.ToString());
            oAdmin.tbFCliente.Text = dgvClien.SelectedRows[0].Cells[1].Value.ToString();
            oAdmin.tbFTel.Text = dgvClien.SelectedRows[0].Cells[3].Value.ToString();
            oAdmin.tbFDni.Text = dgvClien.SelectedRows[0].Cells[4].Value.ToString();
            oAdmin.tbFDirec.Text = dgvClien.SelectedRows[0].Cells[5].Value.ToString();

            oAdmin.btnFBuscarCli.Enabled = false;
            oAdmin.btnFBuscarProd.Enabled = true;
            oAdmin.btnFCancelarFactura.Enabled = true;
            oAdmin.panelFDetalle.Enabled = true;

            this.Close();
        }

        private void DgvClien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
