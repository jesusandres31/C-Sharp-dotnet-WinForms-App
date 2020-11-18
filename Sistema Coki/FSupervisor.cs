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

namespace Sistema_Coki
{
    public partial class FSupervisor : Form
    {
        Validacion v = new Validacion();
        private int idUser = 0;

        public FSupervisor(int _idUser, string nombre)
        {
            InitializeComponent();
            idUser = _idUser;
            lblUser.Text = nombre;
        }

        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FSupervisor_Load(object sender, EventArgs e)
        {
            
            ClsProducto.loadProveedores(cbProveedor);
            //cbProveedor.SelectedIndex = 0;

            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.producto_fecha' Puede moverla o quitarla según sea necesario.
            this.producto_fechaTableAdapter.Fill(this.DataSetPrincipal.producto_fecha, dtProd.Value);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.producto_proveedor' Puede moverla o quitarla según sea necesario.
            this.producto_proveedorTableAdapter.Fill(this.DataSetPrincipal.producto_proveedor, Convert.ToInt32(cbProveedor.SelectedValue));  
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.mejores_fechas' Puede moverla o quitarla según sea necesario.
            this.mejores_fechasTableAdapter.Fill(this.DataSetPrincipal.mejores_fechas);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.mejores_clientes' Puede moverla o quitarla según sea necesario.
            this.mejores_clientesTableAdapter.Fill(this.DataSetPrincipal.mejores_clientes);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.mejores_vendedores' Puede moverla o quitarla según sea necesario.
            this.mejores_vendedoresTableAdapter.Fill(this.DataSetPrincipal.mejores_vendedores);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.producto_mas_vend' Puede moverla o quitarla según sea necesario.
            this.producto_mas_vendTableAdapter.Fill(this.DataSetPrincipal.producto_mas_vend);
            
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.producto_proveedorTableAdapter.Fill(this.DataSetPrincipal.producto_proveedor, Convert.ToInt32(cbProveedor.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer5_Load(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer6_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer6_Load_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtProd_ValueChanged(object sender, EventArgs e)
        {
            this.producto_fechaTableAdapter.Fill(this.DataSetPrincipal.producto_fecha, dtProd.Value);
            this.reportViewer6.RefreshReport();
        }

       
    }
}
