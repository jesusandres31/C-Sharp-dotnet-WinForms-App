namespace Sistema_Coki
{
    partial class FLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblGoyaGestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(27, 146);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.LblUsuario_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(27, 201);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(30, 162);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(219, 20);
            this.tbUsuario.TabIndex = 2;
            this.tbUsuario.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBUsuario_KeyPress);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(30, 217);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(219, 20);
            this.tbContraseña.TabIndex = 3;
            this.tbContraseña.UseSystemPasswordChar = true;
            this.tbContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBContraseña_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(30, 259);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(219, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblGoyaGestion
            // 
            this.lblGoyaGestion.AutoSize = true;
            this.lblGoyaGestion.Location = new System.Drawing.Point(98, 53);
            this.lblGoyaGestion.Name = "lblGoyaGestion";
            this.lblGoyaGestion.Size = new System.Drawing.Size(68, 13);
            this.lblGoyaGestion.TabIndex = 6;
            this.lblGoyaGestion.Text = "Sistema Coki";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Sistema_Coki.Properties.Resources.usuario;
            this.panel1.Location = new System.Drawing.Point(78, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 120);
            this.panel1.TabIndex = 7;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGoyaGestion);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblGoyaGestion;
        private System.Windows.Forms.Panel panel1;
    }
}