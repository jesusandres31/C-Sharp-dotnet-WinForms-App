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
    public partial class Reparto : Form
    {
        public Reparto()
        {
            InitializeComponent();
        }

        public DateTime fecha { get; set; }

        private void Reparto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.reparto' Puede moverla o quitarla según sea necesario.
            this.repartoTableAdapter.Fill(this.DataSetPrincipal.reparto, fecha);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
