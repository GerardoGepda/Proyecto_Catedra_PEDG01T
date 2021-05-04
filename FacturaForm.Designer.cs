namespace Proyecto_Catedra_PEDG01T
{
    partial class FacturaForm
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.lbproduc = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lbfecha = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lbcantidad = new System.Windows.Forms.Label();
            this.txtnomesa = new System.Windows.Forms.TextBox();
            this.lbmesa = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.lbmonto = new System.Windows.Forms.Label();
            this.txtnofactura = new System.Windows.Forms.TextBox();
            this.lbno = new System.Windows.Forms.Label();
            this.lbfactura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(799, 599);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(187, 44);
            this.btncancelar.TabIndex = 37;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(30)))));
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(511, 599);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(187, 44);
            this.btnagregar.TabIndex = 36;
            this.btnagregar.Text = "Agregar el pedido";
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(48)))));
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.Location = new System.Drawing.Point(225, 599);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(187, 44);
            this.btnimprimir.TabIndex = 35;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = false;
            // 
            // lbproduc
            // 
            this.lbproduc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbproduc.AutoSize = true;
            this.lbproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproduc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbproduc.Location = new System.Drawing.Point(221, 327);
            this.lbproduc.Name = "lbproduc";
            this.lbproduc.Size = new System.Drawing.Size(100, 24);
            this.lbproduc.TabIndex = 34;
            this.lbproduc.Text = "Productos:";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(225, 352);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(760, 207);
            this.dgv.TabIndex = 33;
            // 
            // txtfecha
            // 
            this.txtfecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(596, 281);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 22);
            this.txtfecha.TabIndex = 32;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbfecha.Location = new System.Drawing.Point(507, 281);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(69, 24);
            this.lbfecha.TabIndex = 31;
            this.lbfecha.Text = "Fecha:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcantidad.Enabled = false;
            this.txtcantidad.Location = new System.Drawing.Point(780, 208);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 22);
            this.txtcantidad.TabIndex = 30;
            // 
            // lbcantidad
            // 
            this.lbcantidad.AutoSize = true;
            this.lbcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbcantidad.Location = new System.Drawing.Point(672, 208);
            this.lbcantidad.Name = "lbcantidad";
            this.lbcantidad.Size = new System.Drawing.Size(89, 24);
            this.lbcantidad.TabIndex = 29;
            this.lbcantidad.Text = "Cantidad:";
            // 
            // txtnomesa
            // 
            this.txtnomesa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnomesa.Enabled = false;
            this.txtnomesa.Location = new System.Drawing.Point(780, 148);
            this.txtnomesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnomesa.Name = "txtnomesa";
            this.txtnomesa.Size = new System.Drawing.Size(100, 22);
            this.txtnomesa.TabIndex = 28;
            // 
            // lbmesa
            // 
            this.lbmesa.AutoSize = true;
            this.lbmesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbmesa.Location = new System.Drawing.Point(672, 148);
            this.lbmesa.Name = "lbmesa";
            this.lbmesa.Size = new System.Drawing.Size(96, 24);
            this.lbmesa.TabIndex = 27;
            this.lbmesa.Text = "No. Mesa:";
            // 
            // txtmonto
            // 
            this.txtmonto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtmonto.Enabled = false;
            this.txtmonto.Location = new System.Drawing.Point(423, 208);
            this.txtmonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 22);
            this.txtmonto.TabIndex = 26;
            // 
            // lbmonto
            // 
            this.lbmonto.AutoSize = true;
            this.lbmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbmonto.Location = new System.Drawing.Point(291, 208);
            this.lbmonto.Name = "lbmonto";
            this.lbmonto.Size = new System.Drawing.Size(68, 24);
            this.lbmonto.TabIndex = 25;
            this.lbmonto.Text = "Monto:";
            // 
            // txtnofactura
            // 
            this.txtnofactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnofactura.Enabled = false;
            this.txtnofactura.Location = new System.Drawing.Point(423, 148);
            this.txtnofactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnofactura.Name = "txtnofactura";
            this.txtnofactura.Size = new System.Drawing.Size(100, 22);
            this.txtnofactura.TabIndex = 24;
            // 
            // lbno
            // 
            this.lbno.AutoSize = true;
            this.lbno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbno.Location = new System.Drawing.Point(291, 148);
            this.lbno.Name = "lbno";
            this.lbno.Size = new System.Drawing.Size(118, 24);
            this.lbno.TabIndex = 23;
            this.lbno.Text = "No.  Factura:";
            // 
            // lbfactura
            // 
            this.lbfactura.AutoSize = true;
            this.lbfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbfactura.Location = new System.Drawing.Point(52, 39);
            this.lbfactura.Name = "lbfactura";
            this.lbfactura.Size = new System.Drawing.Size(107, 31);
            this.lbfactura.TabIndex = 22;
            this.lbfactura.Text = "Factura";
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 714);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.lbproduc);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lbcantidad);
            this.Controls.Add(this.txtnomesa);
            this.Controls.Add(this.lbmesa);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.lbmonto);
            this.Controls.Add(this.txtnofactura);
            this.Controls.Add(this.lbno);
            this.Controls.Add(this.lbfactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FacturaForm";
            this.Text = "FacturaForm";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label lbproduc;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lbcantidad;
        private System.Windows.Forms.TextBox txtnomesa;
        private System.Windows.Forms.Label lbmesa;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label lbmonto;
        private System.Windows.Forms.TextBox txtnofactura;
        private System.Windows.Forms.Label lbno;
        private System.Windows.Forms.Label lbfactura;
    }
}