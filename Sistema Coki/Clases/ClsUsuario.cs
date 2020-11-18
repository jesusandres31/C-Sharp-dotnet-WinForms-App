using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Coki.Modelo;
using System.Drawing;
using System.Globalization;

namespace Sistema_Coki.Clases
{
    class ClsUsuario
    {

        public static void guardarUs(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbDni,
            TextBox tbUser, TextBox tbPassword, ComboBox cbTipo, DataGridView dgvUs)
        {
            int idTipo = Convert.ToInt32(cbTipo.SelectedValue);

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                if (db.usuario.Any(usuario => usuario.apeynom == tbNombre.Text || usuario.dni == tbDni.Text ||
                                    usuario.nomusuario == tbUser.Text) == false)
                {
                    usuario oUs = new usuario();
                    oUs.apeynom = tbNombre.Text;
                    oUs.correo = tbCorreo.Text;
                    oUs.tel = tbTel.Text;
                    oUs.dni = tbDni.Text;
                    oUs.nomusuario = tbUser.Text;
                    oUs.contraseña = tbPassword.Text;
                    oUs.idtipousuario = idTipo;
                    oUs.estado = 1;

                    db.usuario.Add(oUs);
                    db.SaveChanges();

                    MessageBox.Show("El usuario: " + tbNombre.Text + " se insertó correctamente", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario que intenta guardar ya existe", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public static void editarUs(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbDni,
            TextBox tbUser, TextBox tbPassword, ComboBox cbTipo, DataGridView dgvUs)
        {
            int idTipo = Convert.ToInt32(cbTipo.SelectedValue);
            int id = Convert.ToInt32(dgvUs.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                //if (db.usuario.Any(usuario => usuario.apeynom == tbNombre.Text && usuario.dni == tbDni.Text) == false)
                //{
                    usuario oUs = db.usuario.FirstOrDefault(x => x.idusuario == id);
                //usuario oUs = new usuario();
                    oUs.apeynom = tbNombre.Text;
                    oUs.correo = tbCorreo.Text;
                    oUs.tel = tbTel.Text;
                    oUs.dni = tbDni.Text;
                    oUs.nomusuario = tbUser.Text;
                    oUs.contraseña = tbPassword.Text;
                    oUs.idtipousuario = idTipo;

                    db.SaveChanges();

                    MessageBox.Show("El usuario: " + tbNombre.Text + " se actuaizó correctamente", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("El usuario que intenta guardar ya existe", "Error",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
        }


        public static void buscarUs(TextBox tbNombre, TextBox tbDni, TextBox tbTel, ComboBox cbTipo, DataGridView dgvUs)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.usuario
                          join t in db.tipo_usuario on d.idtipousuario equals t.idtipousuario
                          where d.apeynom.Contains(tbNombre.Text) && d.dni.Contains(tbDni.Text) && d.tel.Contains(tbTel.Text)
                          && t.descripcion.Contains(cbTipo.Text)

                          select new mostrarUsuario()
                          {
                              idusuario = d.idusuario,
                              apeynom = d.apeynom,
                              tel = d.tel,
                              dni = d.dni,
                              correo = d.correo,
                              tipo_usuario = t.descripcion,
                              nomusuario = d.nomusuario,
                              contraseña = d.contraseña,
                              estado = d.estado
                          };

                dgvUs.DataSource = lst.ToList();
            }
        }

        public static void refrescarUs(DataGridView dgvUs)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.usuario
                          join t in db.tipo_usuario on d.idtipousuario equals t.idtipousuario
                          select new mostrarUsuario()
                          {
                              idusuario = d.idusuario,
                              apeynom = d.apeynom,
                              tel = d.tel,
                              dni = d.dni,
                              correo = d.correo,
                              tipo_usuario = t.descripcion,
                              nomusuario = d.nomusuario,
                              contraseña = d.contraseña,
                              estado = d.estado
                          };

                dgvUs.DataSource = lst.ToList();
            }
        }

        public static void obtenerUsuario(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbDni,
            TextBox tbNomUs, TextBox tbContras, ComboBox cbTipoUs, DataGridView dgvUs)
        {
            tbNombre.Text = dgvUs.SelectedRows[0].Cells[1].Value.ToString();
            tbTel.Text = dgvUs.SelectedRows[0].Cells[2].Value.ToString();
            tbDni.Text = dgvUs.SelectedRows[0].Cells[3].Value.ToString();
            tbCorreo.Text = dgvUs.SelectedRows[0].Cells[4].Value.ToString();
            cbTipoUs.Text = dgvUs.SelectedRows[0].Cells[5].Value.ToString();
            tbNomUs.Text = dgvUs.SelectedRows[0].Cells[6].Value.ToString();
            tbContras.Text = dgvUs.SelectedRows[0].Cells[7].Value.ToString();
        }

        public static void eliminarUs(DataGridView dgvUs)
        {
            int id = Convert.ToInt32(dgvUs.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                usuario oUs = db.usuario.FirstOrDefault(x => x.idusuario == id);
                oUs.estado = 0;

                db.SaveChanges();
            }
        }

        public static void habilitarUs(DataGridView dgvUs)
        {
            int id = Convert.ToInt32(dgvUs.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                usuario oUs = db.usuario.FirstOrDefault(x => x.idusuario == id);
                oUs.estado = 1;

                db.SaveChanges();
            }
        }

        public static void loadUsuarios(ComboBox cbUs)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.tipo_usuario
                          select d;
                cbUs.DataSource = lst.ToList();
                cbUs.DisplayMember = "descripcion";
                cbUs.ValueMember = "idtipousuario";
                cbUs.SelectedValue = "idtipousuario";
            }
        }

    }

    class mostrarUsuario
    {
        public int idusuario { get; set; }
        public string apeynom { get; set; }
        public string tel { get; set; }
        public string dni { get; set; }
        public string correo { get; set; }
        public string tipo_usuario { get; set; }
        public string nomusuario { get; set; }
        public string contraseña { get; set; }
        public int? estado { get; set; }
    }
}
