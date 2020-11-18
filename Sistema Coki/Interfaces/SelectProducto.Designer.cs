namespace Sistema_Coki.Interfaces
{
    partial class SelectProducto
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
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.panelBuscarProd = new System.Windows.Forms.Panel();
            this.cbProdProveed = new System.Windows.Forms.ComboBox();
            this.tbProdDescrip = new System.Windows.Forms.TextBox();
            this.lblProdProveed = new System.Windows.Forms.Label();
            this.lblProdDescrip = new System.Windows.Forms.Label();
            this.btnCliLimpiar = new System.Windows.Forms.Button();
            this.lblBuscarCli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.panelBuscarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToResizeRows = false;
            this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProd.Location = new System.Drawing.Point(12, 145);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(776, 293);
            this.dgvProd.TabIndex = 102;
            this.dgvProd.TabStop = false;
            this.dgvProd.DoubleClick += new System.EventHandler(this.DgvProd_DoubleClick);
            this.dgvProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvProd_KeyDown);
            // 
            // panelBuscarProd
            // 
            this.panelBuscarProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBuscarProd.Controls.Add(this.cbProdProveed);
            this.panelBuscarProd.Controls.Add(this.tbProdDescrip);
            this.panelBuscarProd.Controls.Add(this.lblProdProveed);
            this.panelBuscarProd.Controls.Add(this.lblProdDescrip);
            this.panelBuscarProd.Controls.Add(this.btnCliLimpiar);
            this.panelBuscarProd.Controls.Add(this.lblBuscarCli);
            this.panelBuscarProd.Location = new System.Drawing.Point(12, 12);
            this.panelBuscarProd.Name = "panelBuscarProd";
            this.panelBuscarProd.Size = new System.Drawing.Size(776, 127);
            this.panelBuscarProd.TabIndex = 101;
            this.panelBuscarProd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBuscarProd_Paint);
            // 
            // cbProdProveed
            // 
            this.cbProdProveed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdProveed.FormattingEnabled = true;
            this.cbProdProveed.Location = new System.Drawing.Point(94, 89);
            this.cbProdProveed.Name = "cbProdProveed";
            this.cbProdProveed.Size = new System.Drawing.Size(183, 21);
            this.cbProdProveed.TabIndex = 104;
            this.cbProdProveed.SelectedIndexChanged += new System.EventHandler(this.CbProdProveed_SelectedIndexChanged);
            // 
            // tbProdDescrip
            // 
            this.tbProdDescrip.Location = new System.Drawing.Point(94, 55);
            this.tbProdDescrip.Name = "tbProdDescrip";
            this.tbProdDescrip.Size = new System.Drawing.Size(183, 20);
            this.tbProdDescrip.TabIndex = 103;
            this.tbProdDescrip.TextChanged += new System.EventHandler(this.TbProdDescrip_TextChanged);
            this.tbProdDescrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbProdDescrip_KeyPress);
            // 
            // lblProdProveed
            // 
            this.lblProdProveed.AutoSize = true;
            this.lblProdProveed.Location = new System.Drawing.Point(22, 93);
            this.lblProdProveed.Name = "lblProdProveed";
            this.lblProdProveed.Size = new System.Drawing.Size(59, 13);
            this.lblProdProveed.TabIndex = 102;
            this.lblProdProveed.Text = "Proveedor:";
            // 
            // lblProdDescrip
            // 
            this.lblProdDescrip.AutoSize = true;
            this.lblProdDescrip.Location = new System.Drawing.Point(22, 58);
            this.lblProdDescrip.Name = "lblProdDescrip";
            this.lblProdDescrip.Size = new System.Drawing.Size(66, 13);
            this.lblProdDescrip.TabIndex = 101;
            this.lblProdDescrip.Text = "Descripción:";
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
            // lblBuscarCli
            // 
            this.lblBuscarCli.AutoSize = true;
            this.lblBuscarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCli.Location = new System.Drawing.Point(13, 12);
            this.lblBuscarCli.Name = "lblBuscarCli";
            this.lblBuscarCli.Size = new System.Drawing.Size(170, 24);
            this.lblBuscarCli.TabIndex = 46;
            this.lblBuscarCli.Text = "Buscar Producto:";
            // 
            // SelectProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.panelBuscarProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectProducto";
            this.Load += new System.EventHandler(this.SelectProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.panelBuscarProd.ResumeLayout(false);
            this.panelBuscarProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Panel panelBuscarProd;
        private System.Windows.Forms.Button btnCliLimpiar;
        private System.Windows.Forms.Label lblBuscarCli;
        private System.Windows.Forms.ComboBox cbProdProveed;
        private System.Windows.Forms.TextBox tbProdDescrip;
        private System.Windows.Forms.Label lblProdProveed;
        private System.Windows.Forms.Label lblProdDescrip;
    }
}