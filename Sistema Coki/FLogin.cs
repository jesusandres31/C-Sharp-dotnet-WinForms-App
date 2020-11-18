using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using Sistema_Coki.Modelo;
using Sistema_Coki.Clases;

namespace Sistema_Coki
{
    public partial class FLogin : Form
    {
        Validacion v = new Validacion();
        public int idusuario = 0;
        public string nombre = " ";
        public FLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (GestionVentasEntities db = new GestionVentasEntities())
            {
                int bandera = 0;
                foreach (var user in db.usuario)
                {
                    if (user.nomusuario.Replace(" ", "") == tbUsuario.Text && user.contraseña.Replace(" ", "") == tbContraseña.Text && user.estado == 1)
                    {
                        int perfil = user.tipo_usuario.idtipousuario;
                        idusuario = user.idusuario;
                        nombre = user.apeynom;

                        switch (perfil)
                        {
                            case 1:
                                bandera = 1;
                                this.Hide();
                                FAdministrador FAdmin = new FAdministrador(idusuario, nombre);
                                FAdmin.Show();    //FAdmin.ShowDialog();
                                //this.Close();
                                break;
                            case 2:
                                bandera = 1;
                                this.Hide();
                                FVendedor FVend = new FVendedor(idusuario, nombre);
                                FVend.Show();    //FVend.ShowDialog();
                                //this.Close();
                                break;
                            case 3:
                                bandera = 1;
                                this.Hide();
                                FSuperadministrador FSupAd = new FSuperadministrador(idusuario, nombre);
                                FSupAd.Show();    //FSupAd.ShowDialog();
                                //this.Close();
                                break;
                            case 4:
                                bandera = 1;
                                this.Hide();
                                FSupervisor FSupVi = new FSupervisor(idusuario, nombre);
                                FSupVi.Show();    //FSupVi.ShowDialog();
                                //this.Close();
                                break;
                            default:
                                bandera = 1;
                                break;
                        }
                    }
                }
                if (bandera == 0)
                {
                    MessageBox.Show("Datos incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsuario.Focus();
                    tbContraseña.Clear();
                }
            }
        }
            

        private void FLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void TBUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasYNumeros(e);
        }

        private void TBContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetrasYNumeros(e);
        }
    }
}
