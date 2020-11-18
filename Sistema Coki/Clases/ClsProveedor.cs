using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Coki.Modelo;
using System.Drawing;

namespace Sistema_Coki.Clases
{
    class ClsProveedor
    {
        public static void guardarProv(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbCuit, DataGridView dgvProv)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                if (db.proveedor.Any(proveedor => proveedor.nombre == tbNombre.Text && proveedor.correo == tbCorreo.Text &&
                    proveedor.tel == tbTel.Text && proveedor.dni == tbCuit.Text) == false)
                {
                    proveedor oProv = new proveedor();
                    oProv.nombre = tbNombre.Text;
                    oProv.tel = tbTel.Text;
                    oProv.dni = tbCuit.Text;
                    oProv.correo = tbCorreo.Text;
                    oProv.estado = 1;

                    db.proveedor.Add(oProv);
                    db.SaveChanges();

                    MessageBox.Show("El proveedor: " + tbNombre.Text + " se insertó correctamente", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El proveedor que intenta guardar ya existe", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void editarProv(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbCuit, DataGridView dgvProv)
        {
            int id = Convert.ToInt32(dgvProv.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                if (db.proveedor.Any(proveedor => proveedor.nombre == tbNombre.Text && proveedor.correo == tbCorreo.Text
                    && proveedor.tel == tbTel.Text && proveedor.dni == tbCuit.Text) == false)
                {
                    proveedor oProv = db.proveedor.FirstOrDefault(x => x.idproveedor == id);
                    oProv.nombre = tbNombre.Text;
                    oProv.tel = tbTel.Text;
                    oProv.dni = tbCuit.Text;
                    oProv.correo = tbCorreo.Text;

                    db.SaveChanges();

                    MessageBox.Show("El proveedor: " + tbNombre.Text + " se actuaizó correctamente", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El proveedor que intenta guardar ya existe", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public static void obtenerProv(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbCuit, DataGridView dgvProv)
        {
            tbNombre.Text = dgvProv.SelectedRows[0].Cells[1].Value.ToString();
            tbCorreo.Text = dgvProv.SelectedRows[0].Cells[2].Value.ToString();
            tbTel.Text = dgvProv.SelectedRows[0].Cells[3].Value.ToString();
            tbCuit.Text = dgvProv.SelectedRows[0].Cells[4].Value.ToString();
        }

        public static void eliminarProv(DataGridView dgvProv)
        {
            int id = Convert.ToInt32(dgvProv.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                proveedor oProv = db.proveedor.FirstOrDefault(x => x.idproveedor == id);
                oProv.estado = 0;

                db.SaveChanges();
            }
        }

        public static void habilitarProv(DataGridView dgvProv)
        {
            int id = Convert.ToInt32(dgvProv.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                proveedor oProv = db.proveedor.FirstOrDefault(x => x.idproveedor == id);
                oProv.estado = 1;

                db.SaveChanges();
            }
        }

        public static void refrescarProv(DataGridView dgvProv)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.proveedor
                          select new mostrarProveedor()
                          {
                              idproveedor = d.idproveedor,
                              nombre = d.nombre,
                              correo = d.correo,
                              tel = d.tel,
                              dni = d.dni,
                              estado = d.estado
                          };

                dgvProv.DataSource = lst.ToList();
            }
        }

        public static void buscarProv(TextBox tbNombre, TextBox tbTel, TextBox tbCuit, DataGridView dgvProv)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.proveedor where d.nombre.Contains(tbNombre.Text) && d.tel.Contains(tbTel.Text)
                          && d.dni.Contains(tbCuit.Text)
                          select new mostrarProveedor()
                          {
                              idproveedor = d.idproveedor,
                              nombre = d.nombre,
                              correo = d.correo,
                              tel = d.tel,
                              dni = d.dni,
                              estado = d.estado
                          };

                dgvProv.DataSource = lst.ToList();
            }
        }

    }

    class mostrarProveedor
    {
        public int idproveedor { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string tel { get; set; }
        public string dni { get; set; }
        public int? estado { get; set; }
    }
}
