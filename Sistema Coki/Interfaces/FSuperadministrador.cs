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
using Sistema_Coki.Modelo;
using Validaciones;
using System.Configuration;
using System.Data.SqlClient;

namespace Sistema_Coki
{
    public partial class FSuperadministrador : Form
    {
        Validacion v = new Validacion();
        private int idUser = 0;
        private bool agregarUsWasClicked = false;
        private bool editarUsWasClicked = false;

        public FSuperadministrador(int _idUser, string nombre)
        {
            InitializeComponent();
            idUser = _idUser;
            lblUser.Text = nombre;
        }

        private void FSuperadministrador_Load(object sender, EventArgs e)
        {
            ClsUsuario.refrescarUs(dgvUs);

            ClsUsuario.loadUsuarios(cbUsTipoUs);
            ClsUsuario.loadUsuarios(cbUsAgTipoUs);
        }

        private void SalirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Los datos no guardados se perderan. Desea salir?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == DialogResult.Yes)
            {
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
        private void LblVendedor_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbUsNombre_TextChanged(object sender, EventArgs e)
        {
            ClsUsuario.buscarUs(tbUsNombre, tbUsDni, tbUsTel, cbUsTipoUs, dgvUs);
        }

        private void TbUsDni_TextChanged(object sender, EventArgs e)
        {
            ClsUsuario.buscarUs(tbUsNombre, tbUsDni, tbUsTel, cbUsTipoUs, dgvUs);
        }

        private void TbUsTel_TextChanged(object sender, EventArgs e)
        {
            ClsUsuario.buscarUs(tbUsNombre, tbUsDni, tbUsTel, cbUsTipoUs, dgvUs);
        }

        private void cbUsTipoUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsUsuario.buscarUs(tbUsNombre, tbUsDni, tbUsTel, cbUsTipoUs, dgvUs);
        }

        private void TbUsNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void TbUsDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbUsTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void BtnUsLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarBuscUs();
        }

        private void limpiarUs()
        {
            tbUsAgNombre.Clear();
            tbUsAgCorreo.Clear();
            tbUsAgTel.Clear();
            tbUsAgDni.Clear();
            tbUsAgNomUs.Clear();
            tbUsAgContras.Clear();
            cbUsAgTipoUs.SelectedItem = null;
        }

        private void limpiarBuscUs()
        {
            tbUsNombre.Clear();
            tbUsDni.Clear();
            tbUsTel.Clear();
            cbUsTipoUs.SelectedItem = null;
        }

        private void TbUsAgNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void TbUsAgCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TbUsAgTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbUsAgDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void TbUsAgNomUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasYNumeros(e);
        }

        private void TbUsAgContras_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasYNumeros(e);
        }

        private void DgvUs_Click(object sender, EventArgs e)
        {
            this.limpiarUs();
            panelAgregarUs.Enabled = false;
        }

        private void DgvUs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvUs.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[8].Value) == 0)
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.limpiarUs();
            panelAgregarUs.Enabled = true;
            lblAgregarUs.Visible = true;
            lblEditarUs.Visible = false;
            agregarUsWasClicked = true;
            editarUsWasClicked = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            panelAgregarUs.Enabled = true;
            lblAgregarUs.Visible = false;
            lblEditarUs.Visible = true;
            editarUsWasClicked = true;
            agregarUsWasClicked = false;

            ClsUsuario.obtenerUsuario(tbUsAgNombre, tbUsAgCorreo, tbUsAgTel, tbUsAgDni, tbUsAgNomUs, tbUsAgContras, cbUsAgTipoUs, dgvUs);
        }

        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(dgvUs.SelectedRows[0].Cells[8].Value.ToString());

            this.limpiarUs();
            panelAgregarUs.Enabled = false;

            if (estado == 1)
            {
                MessageBox.Show("El usuario seleccionado ya está habilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Habilitar usuario nuevamente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsUsuario.habilitarUs(dgvUs);

                        MessageBox.Show("El usuario está ahora habilitado", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarBuscUs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsUsuario.refrescarUs(dgvUs);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(dgvUs.SelectedRows[0].Cells[8].Value.ToString());

            this.limpiarUs();
            panelAgregarUs.Enabled = false;

            if (estado == 0)
            {
                MessageBox.Show("El usuario seleccionado ya está eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea eliminar usuario?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsUsuario.eliminarUs(dgvUs);

                        MessageBox.Show("El usuario se elimino correctamente", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limpiarBuscUs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsUsuario.refrescarUs(dgvUs);
                }
            }
        }

        private void BtnAgCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarUs();
            panelAgregarUs.Enabled = false;
            lblAgregarUs.Visible = true;
            lblEditarUs.Visible = false;
        }

        private void BtnAgGuardar_Click(object sender, EventArgs e)
        {
            if (agregarUsWasClicked == true)
            {
                this.guardarUs();
            }
            else if (editarUsWasClicked == true)
            {
                this.editarUs();
            }
        }

        private void guardarUs()
        {
            if (tbUsAgCorreo.Text == "" || tbUsAgTel.Text == "" || tbUsAgDni.Text == "" || tbUsAgNomUs.Text == "" ||
                tbUsAgContras.Text == "" || cbUsAgTipoUs.Text == "" || v.isValidEmail(tbUsAgCorreo.Text) == false)
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo usuario?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsUsuario.guardarUs(tbUsAgNombre, tbUsAgCorreo, tbUsAgTel, tbUsAgDni, tbUsAgNomUs,
                            tbUsAgContras, cbUsAgTipoUs, dgvUs);
                        panelAgregarUs.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsUsuario.refrescarUs(dgvUs);
                    this.limpiarUs();
                    agregarUsWasClicked = false;
                }
            }
        }

        private void editarUs()
        {
            if (tbUsAgCorreo.Text == "" || tbUsAgTel.Text == "" || tbUsAgDni.Text == "" || tbUsAgNomUs.Text == "" ||
                tbUsAgContras.Text == "" || cbUsAgTipoUs.Text == "" || v.isValidEmail(tbUsAgCorreo.Text) == false)
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea actualizar usuario?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    try
                    {
                        ClsUsuario.editarUs(tbUsAgNombre, tbUsAgCorreo, tbUsAgTel, tbUsAgDni, tbUsAgNomUs,
                            tbUsAgContras, cbUsAgTipoUs, dgvUs);
                        panelAgregarUs.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClsUsuario.refrescarUs(dgvUs);
                    this.limpiarUs();
                    editarUsWasClicked = false;
                }
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

        private void dgvUs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.contarItemsDgv(sender, e);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////BACKUP///////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void tabBackUp_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }


   



        //SqlConnection con = new SqlConnection(Sistema_Coki.Properties.Settings.Default.GestionVentasConnectionString);

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog dlg = new FolderBrowserDialog();
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    tbUbicacion.Text = dlg.SelectedPath;
            //    btnAceptar.Enabled = true;
            //}
        }

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    string database = con.Database.ToString();
        //    try
        //    {
        //        if (tbUbicacion.Text == string.Empty)
        //        {
        //            MessageBox.Show("please enter backup file location");
        //        }
        //        else
        //        {
        //            string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + tbUbicacion.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

        //            using (SqlCommand command = new SqlCommand(cmd, con))
        //            {
        //                if (con.State != ConnectionState.Open)
        //                {
        //                    con.Open();
        //                }
        //                command.ExecuteNonQuery();
        //                con.Close();
        //                MessageBox.Show("Se realizó el backup exitosamente!");
        //                btnAceptar.Enabled = false;
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Filter = "SQL SERVER database backup files|*.bak";
            //dlg.Title = "Database restore";
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    btnBuscarR.Text = dlg.FileName;
            //    btnAceptarR.Enabled = true;
            //}
        }

        private void btnAceptarR_Click(object sender, EventArgs e)
        {
            //string database = con.Database.ToString();
            //if (con.State != ConnectionState.Open)
            //{
            //    con.Open();
            //}
            //try
            //{
            //    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            //    SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
            //    bu2.ExecuteNonQuery();

            //    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + tbUbicacionR.Text + "'WITH REPLACE;";
            //    SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
            //    bu3.ExecuteNonQuery();

            //    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
            //    SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
            //    bu4.ExecuteNonQuery();

            //    MessageBox.Show("Se restauró la base de datos exitosamente!");
            //    con.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }



        private void panelBackUpD_Paint(object sender, PaintEventArgs e)
        {

        }

        private const string BackUpQuery = "dbo.RealizarBackUp";

        public class Respuesta
        {
            public bool Exito { get; set; }
            public string Mensaje { get; set; }
            public int Id { get; set; }
        }

        private Respuesta Backup()
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                return db.Database.SqlQuery<Respuesta>(BackUpQuery).FirstOrDefault();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var respuesta = Backup();
            MessageBox.Show("BACKUP REALIZADO CON ÉXITO");
        }

        private void cbUsAgTipoUs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
