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
    class ClsCliente
    {
        public static void guardarCliente(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbCuit,
            TextBox tbDirec, DataGridView dgvClien)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                if (db.cliente.Any(cliente => cliente.nombre == tbNombre.Text && cliente.correo == tbCorreo.Text
                    && cliente.tel == tbTel.Text && cliente.dni == tbCuit.Text && cliente.direccion == tbDirec.Text) == false)
                {
                    cliente oClien = new cliente();
                    oClien.nombre = tbNombre.Text;
                    oClien.correo = tbCorreo.Text;
                    oClien.tel = tbTel.Text;
                    oClien.dni = tbCuit.Text;
                    oClien.direccion = tbDirec.Text;
                    oClien.estado = 1;

                    db.cliente.Add(oClien);
                    db.SaveChanges();

                    MessageBox.Show("El cliente: " + tbNombre.Text + " se insertó correctamente", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cliente que intenta guardar ya existe", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void editarCliente(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbCuit,
            TextBox tbDirec, DataGridView dgvClien)
        {
            int id = Convert.ToInt32(dgvClien.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                if (db.cliente.Any(cliente => cliente.nombre == tbNombre.Text && cliente.correo == tbCorreo.Text 
                    && cliente.tel == tbTel.Text && cliente.dni == tbCuit.Text && cliente.direccion == tbDirec.Text) == false)
                {
                    cliente oClien = db.cliente.FirstOrDefault(x => x.idcliente == id);
                    oClien.nombre = tbNombre.Text;
                    oClien.correo = tbCorreo.Text;
                    oClien.tel = tbTel.Text;
                    oClien.dni = tbCuit.Text;
                    oClien.direccion = tbDirec.Text;

                    db.SaveChanges();

                    MessageBox.Show("El cliente: " + tbNombre.Text + " se actuaizó correctamente", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cliente que intenta guardar ya existe", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void obtenerCliente(TextBox tbNombre, TextBox tbCorreo, TextBox tbTel, TextBox tbCuit,
            TextBox tbDirec, DataGridView dgvClien)
        {
            tbNombre.Text = dgvClien.SelectedRows[0].Cells[1].Value.ToString();
            tbCorreo.Text = dgvClien.SelectedRows[0].Cells[2].Value.ToString();
            tbTel.Text = dgvClien.SelectedRows[0].Cells[3].Value.ToString();
            tbCuit.Text = dgvClien.SelectedRows[0].Cells[4].Value.ToString();
            tbDirec.Text = dgvClien.SelectedRows[0].Cells[5].Value.ToString();
        }

        public static void eliminarCliente(DataGridView dgvClien)
        {
            int id = Convert.ToInt32(dgvClien.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                cliente oProv = db.cliente.FirstOrDefault(x => x.idcliente == id);
                oProv.estado = 0;

                db.SaveChanges();
            }
        }

        public static void habilitarCliente(DataGridView dgvClien)
        {
            int id = Convert.ToInt32(dgvClien.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                cliente oClien = db.cliente.FirstOrDefault(x => x.idcliente == id);
                oClien.estado = 1;

                db.SaveChanges();
            }
        }

        public static void refrescarCliente(DataGridView dgvClien)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.cliente
                          select new mostrarCliente()
                          {
                              idcliente = d.idcliente,
                              nombre = d.nombre,
                              correo = d.correo,
                              tel = d.tel,
                              dni = d.dni,
                              direccion = d.direccion,
                              estado = d.estado
                          };

                dgvClien.DataSource = lst.ToList();
            }
        }


        public static void refrescarClientesHabilitados(DataGridView dgvClien)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.cliente where d.estado == 1
                          select new mostrarCliente() 
                          {
                              idcliente = d.idcliente,
                              nombre = d.nombre,
                              correo = d.correo,
                              tel = d.tel,
                              dni = d.dni,
                              direccion = d.direccion,
                              estado = d.estado
                          };

                dgvClien.DataSource = lst.ToList();
            }
        }
        

        public static void buscarCliente(TextBox tbNombre, TextBox tbTel, TextBox tbCuit,
            TextBox tbDirec, DataGridView dgvClien)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.cliente
                          where d.nombre.Contains(tbNombre.Text) && d.tel.Contains(tbTel.Text) && d.dni.Contains(tbCuit.Text)
                                    && d.direccion.Contains(tbDirec.Text)
                          select new mostrarCliente()
                          {
                              idcliente = d.idcliente,
                              nombre = d.nombre,
                              correo = d.correo,
                              tel = d.tel,
                              dni = d.dni,
                              direccion = d.direccion,
                              estado = d.estado
                          };

                dgvClien.DataSource = lst.ToList();
            }
        }

    }

    class mostrarCliente
    {
        public int idcliente { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string tel { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public int? estado { get; set; }
    }

}