﻿namespace Proyecto_Catedra_PEDG01T
{
    partial class PedidosForm
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
            this.btnentregar = new System.Windows.Forms.Button();
            this.lblpedidos = new System.Windows.Forms.Label();
            this.lblencola = new System.Windows.Forms.Label();
            this.btnfactura = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dgvpedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnentregar
            // 
            this.btnentregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnentregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnentregar.FlatAppearance.BorderSize = 0;
            this.btnentregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentregar.ForeColor = System.Drawing.Color.White;
            this.btnentregar.Location = new System.Drawing.Point(333, 77);
            this.btnentregar.Name = "btnentregar";
            this.btnentregar.Size = new System.Drawing.Size(107, 33);
            this.btnentregar.TabIndex = 0;
            this.btnentregar.Text = "Entregar pedido";
            this.btnentregar.UseVisualStyleBackColor = false;
            // 
            // lblpedidos
            // 
            this.lblpedidos.AutoSize = true;
            this.lblpedidos.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpedidos.Location = new System.Drawing.Point(34, 27);
            this.lblpedidos.Name = "lblpedidos";
            this.lblpedidos.Size = new System.Drawing.Size(94, 27);
            this.lblpedidos.TabIndex = 4;
            this.lblpedidos.Text = "Pedidos";
            // 
            // lblencola
            // 
            this.lblencola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblencola.AutoSize = true;
            this.lblencola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblencola.Location = new System.Drawing.Point(54, 144);
            this.lblencola.Name = "lblencola";
            this.lblencola.Size = new System.Drawing.Size(105, 16);
            this.lblencola.TabIndex = 5;
            this.lblencola.Text = "Pedido en cola: ";
            // 
            // btnfactura
            // 
            this.btnfactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfactura.BackColor = System.Drawing.Color.Brown;
            this.btnfactura.FlatAppearance.BorderSize = 0;
            this.btnfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfactura.ForeColor = System.Drawing.Color.White;
            this.btnfactura.Location = new System.Drawing.Point(460, 77);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(107, 33);
            this.btnfactura.TabIndex = 6;
            this.btnfactura.Text = "Mostrar factura";
            this.btnfactura.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            this.btneditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(589, 77);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(107, 33);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.Red;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(716, 77);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(107, 33);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // dgvpedidos
            // 
            this.dgvpedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvpedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedidos.Location = new System.Drawing.Point(57, 172);
            this.dgvpedidos.Name = "dgvpedidos";
            this.dgvpedidos.Size = new System.Drawing.Size(766, 340);
            this.dgvpedidos.TabIndex = 9;
            // 
            // PedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.dgvpedidos);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnfactura);
            this.Controls.Add(this.lblencola);
            this.Controls.Add(this.lblpedidos);
            this.Controls.Add(this.btnentregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidosForm";
            this.Text = "PedidosForm";
            this.Load += new System.EventHandler(this.PedidosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnentregar;
        private System.Windows.Forms.Label lblpedidos;
        private System.Windows.Forms.Label lblencola;
        private System.Windows.Forms.Button btnfactura;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView dgvpedidos;
    }
}