namespace Proyecto_Catedra_PEDG01T
{
    partial class MenuForm
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
            this.lblmenu = new System.Windows.Forms.Label();
            this.lblseleccion = new System.Windows.Forms.Label();
            this.cbxnmesas = new System.Windows.Forms.ComboBox();
            this.btncrearpedido = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblmenu.Location = new System.Drawing.Point(39, 32);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(74, 29);
            this.lblmenu.TabIndex = 0;
            this.lblmenu.Text = "Menú";
            // 
            // lblseleccion
            // 
            this.lblseleccion.AutoSize = true;
            this.lblseleccion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblseleccion.Location = new System.Drawing.Point(521, 45);
            this.lblseleccion.Name = "lblseleccion";
            this.lblseleccion.Size = new System.Drawing.Size(172, 15);
            this.lblseleccion.TabIndex = 1;
            this.lblseleccion.Text = "Selecciona número de mesa:";
            // 
            // cbxnmesas
            // 
            this.cbxnmesas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxnmesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxnmesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxnmesas.FormattingEnabled = true;
            this.cbxnmesas.Location = new System.Drawing.Point(694, 42);
            this.cbxnmesas.Name = "cbxnmesas";
            this.cbxnmesas.Size = new System.Drawing.Size(167, 21);
            this.cbxnmesas.TabIndex = 2;
            // 
            // btncrearpedido
            // 
            this.btncrearpedido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncrearpedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(30)))));
            this.btncrearpedido.FlatAppearance.BorderSize = 0;
            this.btncrearpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearpedido.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearpedido.ForeColor = System.Drawing.Color.White;
            this.btncrearpedido.Location = new System.Drawing.Point(201, 528);
            this.btncrearpedido.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btncrearpedido.Name = "btncrearpedido";
            this.btncrearpedido.Size = new System.Drawing.Size(140, 40);
            this.btncrearpedido.TabIndex = 8;
            this.btncrearpedido.Text = "Generar pedido y factura";
            this.btncrearpedido.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(48)))));
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(377, 528);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(140, 40);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar formulario";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(553, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlProductos
            // 
            this.pnlProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductos.AutoScroll = true;
            this.pnlProductos.Location = new System.Drawing.Point(12, 69);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(882, 441);
            this.pnlProductos.TabIndex = 11;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.btncrearpedido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.cbxnmesas);
            this.Controls.Add(this.lblseleccion);
            this.Controls.Add(this.lblmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.Label lblseleccion;
        private System.Windows.Forms.ComboBox cbxnmesas;
        private System.Windows.Forms.Button btncrearpedido;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlProductos;
    }
}