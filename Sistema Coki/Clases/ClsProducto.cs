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
    class ClsProducto
    {
        public static void guardarProd(TextBox tbDesc, ComboBox cbProv, TextBox tbStock, string unidad,
            TextBox tbPrecio, DataGridView dgvProd)
        {
            int idProv = Convert.ToInt32(cbProv.SelectedValue);
            decimal stock = Convert.ToDecimal(tbStock.Text);
            decimal precio = Convert.ToDecimal(tbPrecio.Text);

            //decimal stock = Convert.ToDecimal(tbStock.Text, new CultureInfo("en-US"));
            //decimal precio = Convert.ToDecimal(tbPrecio.Text, new CultureInfo("en-US"));

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                if (db.producto.Any(producto => producto.descripcion == tbDesc.Text) == false)
                {
                    producto oProd = new producto();
                    oProd.descripcion = tbDesc.Text;
                    oProd.idproveedor = idProv;
                    oProd.stock = stock;
                    oProd.unidad = unidad;
                    oProd.precio = precio;
                    oProd.estado = 1;

                    db.producto.Add(oProd);
                    db.SaveChanges();

                    MessageBox.Show("El producto: " + tbDesc.Text + " se insertó correctamente", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El producto que intenta guardar ya existe", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public static void editarProd(TextBox tbDesc, ComboBox cbProv, TextBox tbStock, string unidad,
            TextBox tbPrecio, DataGridView dgvProd)
        {
            int id = Convert.ToInt32(dgvProd.SelectedRows[0].Cells[0].Value.ToString());

            int idProv = Convert.ToInt32(cbProv.SelectedValue);
            decimal stock = Convert.ToDecimal(tbStock.Text);
            decimal precio = Convert.ToDecimal(tbPrecio.Text);

            //decimal stock = Convert.ToDecimal(tbStock.Text, new CultureInfo("en-US"));
            //decimal precio = Convert.ToDecimal(tbPrecio.Text, new CultureInfo("en-US"));

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                if (db.producto.Any(producto => producto.descripcion == tbDesc.Text && producto.idproveedor == idProv
                    && producto.stock == stock && producto.unidad == unidad && producto.precio == precio) == false)
                {
                    producto oProd = db.producto.FirstOrDefault(x => x.idproducto == id);
                    oProd.descripcion = tbDesc.Text;
                    oProd.idproveedor = idProv;
                    oProd.stock = stock;
                    oProd.unidad = unidad;
                    oProd.precio = precio; 

                    db.SaveChanges();

                    MessageBox.Show("El producto: " + tbDesc.Text + " se actuaizó correctamente", "Guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El producto que intenta guardar ya existe", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void obtenerProd(TextBox tbDesc, ComboBox cbProv, TextBox tbStock, RadioButton rbUd, RadioButton rbKg,
            TextBox tbPrecio, DataGridView dgvProd)
        {
            tbDesc.Text = dgvProd.SelectedRows[0].Cells[1].Value.ToString();
            cbProv.Text = dgvProd.SelectedRows[0].Cells[2].Value.ToString();
            tbStock.Text = dgvProd.SelectedRows[0].Cells[3].Value.ToString();
            if (dgvProd.SelectedRows[0].Cells[4].Value.ToString() == "Ud")
            {
                rbUd.Checked = true;
                rbKg.Checked = false;
            }
            else if (dgvProd.SelectedRows[0].Cells[4].Value.ToString() == "Kg")
            {
                rbUd.Checked = false;
                rbKg.Checked = true;
            }
            tbPrecio.Text = dgvProd.SelectedRows[0].Cells[5].Value.ToString();
        }

        public static void eliminarProd(DataGridView dgvProd)
        {
            int id = Convert.ToInt32(dgvProd.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                producto oProd = db.producto.FirstOrDefault(x => x.idproducto == id);
                oProd.estado = 0;

                db.SaveChanges();
            }
        }

        public static void habilitarProd(DataGridView dgvProd)
        {
            int id = Convert.ToInt32(dgvProd.SelectedRows[0].Cells[0].Value.ToString());

            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                producto oProd = db.producto.FirstOrDefault(x => x.idproducto == id);
                oProd.estado = 1;

                db.SaveChanges();
            }
        }

        public static void refrescarProd(DataGridView dgvProd)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.producto
                          join p in db.proveedor on d.idproveedor equals p.idproveedor
                          select new mostrarProducto()
                          {
                              idproducto = d.idproducto,
                              descripcion = d.descripcion,
                              proveedor = p.nombre,
                              stock = d.stock,
                              unidad = d.unidad,
                              precio = d.precio,
                              estado = d.estado
                          };

                dgvProd.DataSource = lst.ToList();
            }
        }

        public static void buscarProd(TextBox tbDescrip, ComboBox cbProv, ComboBox cbUnidad, DataGridView dgvProd)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.producto
                          join p in db.proveedor on d.idproveedor equals p.idproveedor
                          where d.descripcion.Contains(tbDescrip.Text) && p.nombre.Contains(cbProv.Text)
                          && d.unidad.Contains(cbUnidad.Text)

                          select new mostrarProducto()
                          {
                              idproducto = d.idproducto,
                              descripcion = d.descripcion,
                              proveedor = p.nombre,
                              stock = d.stock,
                              unidad = d.unidad,
                              precio = d.precio,
                              estado = d.estado
                          };

                dgvProd.DataSource = lst.ToList();
            }
        }

        public static void loadProveedores(ComboBox cbProv)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.proveedor
                          select d;
                cbProv.DataSource = lst.ToList();
                cbProv.DisplayMember = "nombre";
                cbProv.ValueMember = "idproveedor";
                cbProv.SelectedValue = "idproveedor";
            }
        }

        public static void refrescarProductosHabilitados(DataGridView dgvProd)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from d in db.producto
                          join p in db.proveedor on d.idproveedor equals p.idproveedor
                          where d.estado == 1 && d.stock > 0
                          select new mostrarProducto()
                          {
                              idproducto = d.idproducto,
                              descripcion = d.descripcion,
                              proveedor = p.nombre,
                              stock = d.stock,
                              unidad = d.unidad,
                              precio = d.precio,
                              estado = d.estado
                          };

                dgvProd.DataSource = lst.ToList();
            }
        }


    }

    class mostrarProducto
    {
        public int idproducto { get; set; }
        public string descripcion { get; set; }
        public string proveedor { get; set; }
        //public int? idproveedor { get; set; }
        public decimal? stock { get; set; }
        public string unidad { get; set; }
        public decimal? precio { get; set; }
        public int? estado { get; set; }
    }

}