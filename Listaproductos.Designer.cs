namespace Laboratorio_delegate
{
    partial class Listaproductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBNombreproducto = new System.Windows.Forms.TextBox();
            this.LBproductos = new System.Windows.Forms.ListBox();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.BTBuscarProducto = new System.Windows.Forms.Button();
            this.TBPrecioProd = new System.Windows.Forms.TextBox();
            this.TBDescripcionprod = new System.Windows.Forms.TextBox();
            this.TbConsultarprod = new System.Windows.Forms.TextBox();
            this.BTcompra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBcantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBNombreproducto
            // 
            this.TBNombreproducto.Location = new System.Drawing.Point(138, 127);
            this.TBNombreproducto.Name = "TBNombreproducto";
            this.TBNombreproducto.Size = new System.Drawing.Size(100, 20);
            this.TBNombreproducto.TabIndex = 1;
            // 
            // LBproductos
            // 
            this.LBproductos.FormattingEnabled = true;
            this.LBproductos.Location = new System.Drawing.Point(495, 96);
            this.LBproductos.Name = "LBproductos";
            this.LBproductos.Size = new System.Drawing.Size(279, 316);
            this.LBproductos.TabIndex = 2;
            // 
            // BTAgregar
            // 
            this.BTAgregar.Location = new System.Drawing.Point(272, 155);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(75, 23);
            this.BTAgregar.TabIndex = 3;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.UseVisualStyleBackColor = true;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // BTBuscarProducto
            // 
            this.BTBuscarProducto.Location = new System.Drawing.Point(272, 315);
            this.BTBuscarProducto.Name = "BTBuscarProducto";
            this.BTBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.BTBuscarProducto.TabIndex = 4;
            this.BTBuscarProducto.Text = "Buscar";
            this.BTBuscarProducto.UseVisualStyleBackColor = true;
            this.BTBuscarProducto.Click += new System.EventHandler(this.BTBuscarProducto_Click);
            // 
            // TBPrecioProd
            // 
            this.TBPrecioProd.Location = new System.Drawing.Point(138, 179);
            this.TBPrecioProd.Name = "TBPrecioProd";
            this.TBPrecioProd.Size = new System.Drawing.Size(100, 20);
            this.TBPrecioProd.TabIndex = 5;
            // 
            // TBDescripcionprod
            // 
            this.TBDescripcionprod.Location = new System.Drawing.Point(138, 153);
            this.TBDescripcionprod.Name = "TBDescripcionprod";
            this.TBDescripcionprod.Size = new System.Drawing.Size(100, 20);
            this.TBDescripcionprod.TabIndex = 6;
            // 
            // TbConsultarprod
            // 
            this.TbConsultarprod.Location = new System.Drawing.Point(138, 318);
            this.TbConsultarprod.Name = "TbConsultarprod";
            this.TbConsultarprod.Size = new System.Drawing.Size(100, 20);
            this.TbConsultarprod.TabIndex = 7;
            // 
            // BTcompra
            // 
            this.BTcompra.Location = new System.Drawing.Point(163, 402);
            this.BTcompra.Name = "BTcompra";
            this.BTcompra.Size = new System.Drawing.Size(184, 23);
            this.BTcompra.TabIndex = 8;
            this.BTcompra.Text = "Compra/venta";
            this.BTcompra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 73);
            this.label5.TabIndex = 12;
            this.label5.Text = "Consulta de productos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre de producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad";
            // 
            // TBcantidad
            // 
            this.TBcantidad.Location = new System.Drawing.Point(138, 210);
            this.TBcantidad.Name = "TBcantidad";
            this.TBcantidad.Size = new System.Drawing.Size(100, 20);
            this.TBcantidad.TabIndex = 15;
            // 
            // Listaproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBcantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTcompra);
            this.Controls.Add(this.TbConsultarprod);
            this.Controls.Add(this.TBDescripcionprod);
            this.Controls.Add(this.TBPrecioProd);
            this.Controls.Add(this.BTBuscarProducto);
            this.Controls.Add(this.BTAgregar);
            this.Controls.Add(this.LBproductos);
            this.Controls.Add(this.TBNombreproducto);
            this.Controls.Add(this.label1);
            this.Name = "Listaproductos";
            this.Text = "Listaproductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNombreproducto;
        private System.Windows.Forms.ListBox LBproductos;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Button BTBuscarProducto;
        private System.Windows.Forms.TextBox TBPrecioProd;
        private System.Windows.Forms.TextBox TBDescripcionprod;
        private System.Windows.Forms.TextBox TbConsultarprod;
        private System.Windows.Forms.Button BTcompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBcantidad;
    }
}