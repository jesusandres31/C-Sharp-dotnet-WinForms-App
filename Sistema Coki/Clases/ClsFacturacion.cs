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
    class ClsFacturacion
    {


        public static void idFactura(Label idClien)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = db.factura_cabecera
                       .OrderByDescending(p => p.idfactura)
                       .FirstOrDefault();
                if (lst == null)
                {
                    idClien.Text = "0";
                }
                else
                {
                    idClien.Text = Convert.ToString(lst.idfactura + 1);
                }

            }
        }


        public static void guardarFactura(TextBox tbClien, DateTimePicker dtFecha, ComboBox cbTipo, TextBox tbDirec,
                            TextBox tbTel, TextBox tbDni, DataGridView dgvFact, Label idnum, decimal total,
                            int idclien, int idUser)
        {
            int idTipo = Convert.ToInt32(cbTipo.SelectedIndex);
            DateTime datt = dtFecha.Value;
            string s = Convert.ToString(datt);

            using (GestionVentasEntities db_c = new GestionVentasEntities())
            {
                factura_cabecera oFac = new factura_cabecera();
                oFac.idcliente = idclien;
                oFac.idusuario = idUser;
                oFac.idtipoventa = idTipo;
                oFac.fecha = dtFecha.Value;
                oFac.total = total;
                oFac.estado = 1;

                db_c.factura_cabecera.Add(oFac);
                db_c.SaveChanges();

                foreach (DataGridViewRow row in dgvFact.Rows)
                {
                    using (GestionVentasEntities db_d = new GestionVentasEntities())
                    {
                        pedido_detalle oPed = new pedido_detalle();
                        oPed.idproducto = Convert.ToInt32(row.Cells[0].Value.ToString());
                        oPed.peso = Convert.ToDecimal(row.Cells[2].Value.ToString());
                        oPed.cantidad = Convert.ToDecimal(row.Cells[3].Value.ToString());
                        using (GestionVentasEntities db_p = new GestionVentasEntities())
                        {
                            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                            producto oProd = db_p.producto.FirstOrDefault(x => x.idproducto == id);
                            oProd.stock = oProd.stock - oPed.cantidad;
                            db_p.SaveChanges();
                        }
                        oPed.descuento = Convert.ToDecimal(row.Cells[6].Value.ToString());
                        oPed.subtotal = Convert.ToDecimal(row.Cells[7].Value.ToString());
                        oPed.idfactura = oFac.idfactura;

                        db_d.pedido_detalle.Add(oPed);
                        db_d.SaveChanges();
                    }
                }
            }
            MessageBox.Show("Factura guardada", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void refrscarFacturasV(DataGridView dgvCabe, int idUser)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from f in db.factura_cabecera
                          join c in db.cliente on f.idcliente equals c.idcliente
                          join t in db.tipo_venta on f.idtipoventa equals t.idtipoventa
                          where f.idusuario == idUser
                          select new mostrarFacturaV()
                          {
                              idfactura = f.idfactura,
                              cliente = c.nombre,
                              tipo_venta = t.descripcion,
                              fecha = f.fecha,
                              total = f.total,
                          };

                dgvCabe.DataSource = lst.ToList();
            }
        }

        public static void refrescarPedidos(DataGridView dgvCabe, DataGridView dgvDetall)
        {
            try
            {
                int idFact = Convert.ToInt32(dgvCabe.SelectedRows[0].Cells[0].Value.ToString());

                using (GestionVentasEntities db = new GestionVentasEntities())
                {
                    var lst = from d in db.pedido_detalle
                              join p in db.producto on d.idproducto equals p.idproducto
                              where d.idfactura == idFact
                              select new mostrarPedido()
                              {
                                  descripcion = p.descripcion,
                                  peso = d.peso,
                                  unidad_m = p.unidad,
                                  precio_unit = p.precio,
                                  cantidad = d.cantidad,
                                  descuento = d.descuento,
                                  subtotal = d.subtotal,
                              };

                    dgvDetall.DataSource = lst.ToList();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void buscarFactFechaV(TextBox tbClien, ComboBox cbTipo, DateTime fecha,
                            DataGridView dgvCabec, int idUser)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from f in db.factura_cabecera
                          join c in db.cliente on f.idcliente equals c.idcliente
                          join t in db.tipo_venta on f.idtipoventa equals t.idtipoventa
                          where c.nombre.Contains(tbClien.Text) && t.descripcion.Contains(cbTipo.Text) 
                          && f.fecha == fecha
                          && f.idusuario == idUser
                          select new mostrarFacturaV()
                          {
                              idfactura = f.idfactura,
                              cliente = c.nombre,
                              tipo_venta = t.descripcion,
                              fecha = f.fecha,
                              total = f.total,
                          };

                dgvCabec.DataSource = lst.ToList();
            }
        }

        public static void buscarFactFechaDesHasV(TextBox tbClien, ComboBox cbTipo,
                            DateTime fechaD, DateTime fechaH, DataGridView dgvCabec, int idUser)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from f in db.factura_cabecera
                          join c in db.cliente on f.idcliente equals c.idcliente
                          join t in db.tipo_venta on f.idtipoventa equals t.idtipoventa
                          where c.nombre.Contains(tbClien.Text) && t.descripcion.Contains(cbTipo.Text)
                          && f.fecha >= fechaD && f.fecha <= fechaH
                          && f.idusuario == idUser
                          select new mostrarFacturaV()
                          {
                              idfactura = f.idfactura,
                              cliente = c.nombre,
                              tipo_venta = t.descripcion,
                              fecha = f.fecha,
                              total = f.total,
                          };

                dgvCabec.DataSource = lst.ToList();
            }
        }
        public static void buscarFactV(TextBox tbClien, ComboBox cbTipo, DataGridView dgvCabec, int idUser)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from f in db.factura_cabecera
                          join c in db.cliente on f.idcliente equals c.idcliente
                          join t in db.tipo_venta on f.idtipoventa equals t.idtipoventa
                          where c.nombre.Contains(tbClien.Text) && t.descripcion.Contains(cbTipo.Text)
                          && f.idusuario == idUser
                          select new mostrarFacturaV()
                          {
                              idfactura = f.idfactura,
                              cliente = c.nombre,
                              tipo_venta = t.descripcion,
                              fecha = f.fecha,
                              total = f.total,
                          };

                dgvCabec.DataSource = lst.ToList();
            }
        }

        public static void buscarFactFechaA(TextBox tbClien, ComboBox cbTipo, DateTime fecha, DataGridView dgvCabec)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from f in db.factura_cabecera
                          join c in db.cliente on f.idcliente equals c.idcliente
                          join t in db.tipo_venta on f.idtipoventa equals t.idtipoventa
                          join u in db.usuario on f.idusuario equals u.idusuario
                          where c.nombre.Contains(tbClien.Text) && t.descripcion.Contains(cbTipo.Text)
                          && f.fecha == fecha
                          select new mostrarFacturaA()
                          {
                              idfactura = f.idfactura,
                              vendedor = u.apeynom,
                              cliente = c.nombre,
                              tipo_venta = t.descripcion,
                              fecha = f.fecha,
                              total = f.total,
                          };

                dgvCabec.DataSource = lst.ToList();
            }
        }

        public static void buscarFactFechaDesHasA(TextBox tbClien, ComboBox cbTipo,
                            DateTime fechaD, DateTime fechaH, DataGridView dgvCabec)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from f in db.factura_cabecera
                          join c in db.cliente on f.idcliente equals c.idcliente
                          join t in db.tipo_venta on f.idtipoventa equals t.idtipoventa
                          join u in db.usuario on f.idusuario equals u.idusuario
                          where c.nombre.Contains(tbClien.Text) && t.descripcion.Contains(cbTipo.Text)
                          && f.fecha >= fechaD && f.fecha <= fechaH
                          select new mostrarFacturaA()
                          {
                              idfactura = f.idfactura,
                              vendedor = u.apeynom,
                              cliente = c.nombre,
                              tipo_venta = t.descripcion,
                              fecha = f.fecha,
                              total = f.total,
                          };

                dgvCabec.DataSource = lst.ToList();
            }
        }

        public static void buscarFactA(TextBox tbClien, ComboBox cbTipo, DataGridView dgvCabec)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from f in db.factura_cabecera
                          join c in db.cliente on f.idcliente equals c.idcliente
                          join t in db.tipo_venta on f.idtipoventa equals t.idtipoventa
                          join u in db.usuario on f.idusuario equals u.idusuario
                          where c.nombre.Contains(tbClien.Text) && t.descripcion.Contains(cbTipo.Text)
                          select new mostrarFacturaA()
                          {
                              idfactura = f.idfactura,
                              vendedor = u.apeynom,
                              cliente = c.nombre,
                              tipo_venta = t.descripcion,
                              fecha = f.fecha,
                              total = f.total,
                          };

                dgvCabec.DataSource = lst.ToList();
            }
        }

        public static void refrscarFacturasA(DataGridView dgvCabe)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                var lst = from f in db.factura_cabecera
                          join c in db.cliente on f.idcliente equals c.idcliente
                          join t in db.tipo_venta on f.idtipoventa equals t.idtipoventa
                          join u in db.usuario on f.idusuario equals u.idusuario
                          select new mostrarFacturaA()
                          {
                              idfactura = f.idfactura,
                              vendedor = u.apeynom,
                              cliente = c.nombre,
                              tipo_venta = t.descripcion,
                              fecha = f.fecha,
                              total = f.total,
                          };

                dgvCabe.DataSource = lst.ToList();
            }
        }

        class mostrarFacturaA
        {
            public int idfactura { get; set; }
            public string vendedor { get; set; }
            public string cliente { get; set; }
            public string tipo_venta { get; set; }
            public DateTime? fecha { get; set; }
            public decimal? total { get; set; }
        }

        class mostrarFacturaV
        {
            public int idfactura { get; set; }
            public string cliente { get; set; }
            public string tipo_venta { get; set; }
            public DateTime? fecha { get; set; }
            public decimal? total { get; set; }
        }


        class mostrarPedido
        {
            public string descripcion { get; set; }
            public decimal? peso { get; set; }
            public string unidad_m { get; set; }
            public decimal? precio_unit { get; set; }
            public decimal? cantidad { get; set; }
            public decimal? descuento { get; set; }
            public decimal? subtotal { get; set; }
        }
    }
}
