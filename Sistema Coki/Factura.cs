using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Coki
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        public int idfactura { get; set; }

        private void Factura_Load(object sender, EventArgs e)
        {
            DataSetPrincipal.EnforceConstraints = false;
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.DataSetPrincipal.factura, idfactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
