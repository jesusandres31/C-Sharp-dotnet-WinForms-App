namespace Sistema_Coki.Interfaces
{
    partial class SelectCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBuscarCli = new System.Windows.Forms.Panel();
            this.tbCliDirec = new System.Windows.Forms.TextBox();
            this.lblCliDirec = new System.Windows.Forms.Label();
            this.btnCliLimpiar = new System.Windows.Forms.Button();
            this.tbCliCuit = new System.Windows.Forms.TextBox();
            this.tbCliTel = new System.Windows.Forms.TextBox();
            this.tbCliNombre = new System.Windows.Forms.TextBox();
            this.lblCliCuit = new System.Windows.Forms.Label();
            this.lblCliTelef = new System.Windows.Forms.Label();
            this.lblBuscarCli = new System.Windows.Forms.Label();
            this.lblCliNombre = new System.Windows.Forms.Label();
            this.dgvClien = new System.Windows.Forms.DataGridView();
            this.panelBuscarCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscarCli
            // 
            this.panelBuscarCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBuscarCli.Controls.Add(this.tbCliDirec);
            this.panelBuscarCli.Controls.Add(this.lblCliDirec);
            this.panelBuscarCli.Controls.Add(this.btnCliLimpiar);
            this.panelBuscarCli.Controls.Add(this.tbCliCuit);
            this.panelBuscarCli.Controls.Add(this.tbCliTel);
            this.panelBuscarCli.Controls.Add(this.tbCliNombre);
            this.panelBuscarCli.Controls.Add(this.lblCliCuit);
            this.panelBuscarCli.Controls.Add(this.lblCliTelef);
            this.panelBuscarCli.Controls.Add(this.lblBuscarCli);
            this.panelBuscarCli.Controls.Add(this.lblCliNombre);
            this.panelBuscarCli.Location = new System.Drawing.Point(12, 12);
            this.panelBuscarCli.Name = "panelBuscarCli";
            this.panelBuscarCli.Size = new System.Drawing.Size(776, 127);
            this.panelBuscarCli.TabIndex = 90;
            // 
            // tbCliDirec
            // 
            this.tbCliDirec.Location = new System.Drawing.Point(348, 86);
            this.tbCliDirec.Name = "tbCliDirec";
            this.tbCliDirec.Size = new System.Drawing.Size(183, 20);
            this.tbCliDirec.TabIndex = 99;
            this.tbCliDirec.TextChanged += new System.EventHandler(this.TbCliDirec_TextChanged);
            this.tbCliDirec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCliDirec_KeyPress);
            // 
            // lblCliDirec
            // 
            this.lblCliDirec.AutoSize = true;
            this.lblCliDirec.Location = new System.Drawing.Point(287, 89);
            this.lblCliDirec.Name = "lblCliDirec";
            this.lblCliDirec.Size = new System.Drawing.Size(55, 13);
            this.lblCliDirec.TabIndex = 97;
            this.lblCliDirec.Text = "Direccion:";
            // 
            // btnCliLimpiar
            // 
            this.btnCliLimpiar.Location = new System.Drawing.Point(666, 81);
            this.btnCliLimpiar.Name = "btnCliLimpiar";
            this.btnCliLimpiar.Size = new System.Drawing.Size(92, 29);
            this.btnCliLimpiar.TabIndex = 83;
            this.btnCliLimpiar.Text = "Limpiar";
            this.btnCliLimpiar.UseVisualStyleBackColor = true;
            this.btnCliLimpiar.Click += new System.EventHandler(this.BtnCliLimpiar_Click);
            // 
            // tbCliCuit
            // 
            this.tbCliCuit.Location = new System.Drawing.Point(348, 51);
            this.tbCliCuit.Name = "tbCliCuit";
            this.tbCliCuit.Size = new System.Drawing.Size(183, 20);
            this.tbCliCuit.TabIndex = 82;
            this.tbCliCuit.TextChanged += new System.EventHandler(this.TbCliCuit_TextChanged);
            this.tbCliCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCliCuit_KeyPress);
            // 
            // tbCliTel
            // 
            this.tbCliTel.Location = new System.Drawing.Point(77, 86);
            this.tbCliTel.Name = "tbCliTel";
            this.tbCliTel.Size = new System.Drawing.Size(183, 20);
            this.tbCliTel.TabIndex = 81;
            this.tbCliTel.TextChanged += new System.EventHandler(this.TbCliTel_TextChanged);
            this.tbCliTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCliTel_KeyPress);
            // 
            // tbCliNombre
            // 
            this.tbCliNombre.Location = new System.Drawing.Point(77, 51);
            this.tbCliNombre.Name = "tbCliNombre";
            this.tbCliNombre.Size = new System.Drawing.Size(183, 20);
            this.tbCliNombre.TabIndex = 80;
            this.tbCliNombre.TextChanged += new System.EventHandler(this.TbCliNombre_TextChanged);
            this.tbCliNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCliNombre_KeyPress);
            // 
            // lblCliCuit
            // 
            this.lblCliCuit.AutoSize = true;
            this.lblCliCuit.Location = new System.Drawing.Point(289, 54);
            this.lblCliCuit.Name = "lblCliCuit";
            this.lblCliCuit.Size = new System.Drawing.Size(35, 13);
            this.lblCliCuit.TabIndex = 73;
            this.lblCliCuit.Text = "CUIT:";
            // 
            // lblCliTelef
            // 
            this.lblCliTelef.AutoSize = true;
            this.lblCliTelef.Location = new System.Drawing.Point(15, 89);
            this.lblCliTelef.Name = "lblCliTelef";
            this.lblCliTelef.Size = new System.Drawing.Size(52, 13);
            this.lblCliTelef.TabIndex = 72;
            this.lblCliTelef.Text = "Telefono:";
            // 
            // lblBuscarCli
            // 
            this.lblBuscarCli.AutoSize = true;
            this.lblBuscarCli.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCli.Location = new System.Drawing.Point(13, 12);
            this.lblBuscarCli.Name = "lblBuscarCli";
            this.lblBuscarCli.Size = new System.Drawing.Size(156, 25);
            this.lblBuscarCli.TabIndex = 46;
            this.lblBuscarCli.Text = "Buscar Cliente:";
            // 
            // lblCliNombre
            // 
            this.lblCliNombre.AutoSize = true;
            this.lblCliNombre.Location = new System.Drawing.Point(15, 54);
            this.lblCliNombre.Name = "lblCliNombre";
            this.lblCliNombre.Size = new System.Drawing.Size(47, 13);
            this.lblCliNombre.TabIndex = 71;
            this.lblCliNombre.Text = "Nombre:";
            // 
            // dgvClien
            // 
            this.dgvClien.AllowUserToResizeRows = false;
            this.dgvClien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClien.Location = new System.Drawing.Point(12, 145);
            this.dgvClien.Name = "dgvClien";
            this.dgvClien.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClien.Size = new System.Drawing.Size(776, 293);
            this.dgvClien.TabIndex = 100;
            this.dgvClien.TabStop = false;
            this.dgvClien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClien_CellContentClick);
            this.dgvClien.DoubleClick += new System.EventHandler(this.DgvClien_DoubleClick);
            this.dgvClien.Enter += new System.EventHandler(this.DgvClien_Enter);
            this.dgvClien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvClien_KeyDown);
            // 
            // SelectCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClien);
            this.Controls.Add(this.panelBuscarCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCliente";
            this.Load += new System.EventHandler(this.SelectCliente_Load);
            this.panelBuscarCli.ResumeLayout(false);
            this.panelBuscarCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBuscarCli;
        private System.Windows.Forms.TextBox tbCliDirec;
        private System.Windows.Forms.Label lblCliDirec;
        private System.Windows.Forms.Button btnCliLimpiar;
        private System.Windows.Forms.TextBox tbCliCuit;
        private System.Windows.Forms.TextBox tbCliTel;
        private System.Windows.Forms.TextBox tbCliNombre;
        private System.Windows.Forms.Label lblCliCuit;
        private System.Windows.Forms.Label lblCliTelef;
        private System.Windows.Forms.Label lblBuscarCli;
        private System.Windows.Forms.Label lblCliNombre;
        private System.Windows.Forms.DataGridView dgvClien;
    }
}