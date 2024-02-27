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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBcantidad = new System.Windows.Forms.TextBox();
            this.BTCompras = new System.Windows.Forms.Button();
            this.BTVentas = new System.Windows.Forms.Button();
            this.TBCompras = new System.Windows.Forms.TextBox();
            this.TBVentas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BTSalir = new System.Windows.Forms.Button();
            this.TBCompraNum = new System.Windows.Forms.TextBox();
            this.TBVentaNum = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBNombreproducto
            // 
            this.TBNombreproducto.Location = new System.Drawing.Point(149, 70);
            this.TBNombreproducto.Name = "TBNombreproducto";
            this.TBNombreproducto.Size = new System.Drawing.Size(100, 20);
            this.TBNombreproducto.TabIndex = 1;
            // 
            // LBproductos
            // 
            this.LBproductos.FormattingEnabled = true;
            this.LBproductos.Location = new System.Drawing.Point(535, 37);
            this.LBproductos.Name = "LBproductos";
            this.LBproductos.Size = new System.Drawing.Size(246, 316);
            this.LBproductos.TabIndex = 2;
            this.LBproductos.SelectedIndexChanged += new System.EventHandler(this.LBproductos_SelectedIndexChanged);
            // 
            // BTAgregar
            // 
            this.BTAgregar.BackColor = System.Drawing.Color.PowderBlue;
            this.BTAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregar.Location = new System.Drawing.Point(285, 95);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(114, 40);
            this.BTAgregar.TabIndex = 3;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.UseVisualStyleBackColor = false;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // BTBuscarProducto
            // 
            this.BTBuscarProducto.BackColor = System.Drawing.Color.Thistle;
            this.BTBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBuscarProducto.Location = new System.Drawing.Point(448, 245);
            this.BTBuscarProducto.Name = "BTBuscarProducto";
            this.BTBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.BTBuscarProducto.TabIndex = 4;
            this.BTBuscarProducto.Text = "Buscar";
            this.BTBuscarProducto.UseVisualStyleBackColor = false;
            this.BTBuscarProducto.Click += new System.EventHandler(this.BTBuscarProducto_Click);
            // 
            // TBPrecioProd
            // 
            this.TBPrecioProd.Location = new System.Drawing.Point(149, 122);
            this.TBPrecioProd.Name = "TBPrecioProd";
            this.TBPrecioProd.Size = new System.Drawing.Size(100, 20);
            this.TBPrecioProd.TabIndex = 5;
            // 
            // TBDescripcionprod
            // 
            this.TBDescripcionprod.Location = new System.Drawing.Point(149, 96);
            this.TBDescripcionprod.Name = "TBDescripcionprod";
            this.TBDescripcionprod.Size = new System.Drawing.Size(100, 20);
            this.TBDescripcionprod.TabIndex = 6;
            // 
            // TbConsultarprod
            // 
            this.TbConsultarprod.Location = new System.Drawing.Point(205, 293);
            this.TbConsultarprod.Name = "TbConsultarprod";
            this.TbConsultarprod.Size = new System.Drawing.Size(100, 20);
            this.TbConsultarprod.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 43);
            this.label5.TabIndex = 12;
            this.label5.Text = "Consulta de productos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Info de producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad";
            // 
            // TBcantidad
            // 
            this.TBcantidad.Location = new System.Drawing.Point(149, 153);
            this.TBcantidad.Name = "TBcantidad";
            this.TBcantidad.Size = new System.Drawing.Size(100, 20);
            this.TBcantidad.TabIndex = 15;
            // 
            // BTCompras
            // 
            this.BTCompras.BackColor = System.Drawing.Color.Thistle;
            this.BTCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCompras.Location = new System.Drawing.Point(448, 287);
            this.BTCompras.Name = "BTCompras";
            this.BTCompras.Size = new System.Drawing.Size(75, 23);
            this.BTCompras.TabIndex = 16;
            this.BTCompras.Text = "Comprar";
            this.BTCompras.UseVisualStyleBackColor = false;
            this.BTCompras.Click += new System.EventHandler(this.BTCompras_Click);
            // 
            // BTVentas
            // 
            this.BTVentas.BackColor = System.Drawing.Color.Thistle;
            this.BTVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVentas.Location = new System.Drawing.Point(448, 330);
            this.BTVentas.Name = "BTVentas";
            this.BTVentas.Size = new System.Drawing.Size(75, 23);
            this.BTVentas.TabIndex = 17;
            this.BTVentas.Text = "Vender";
            this.BTVentas.UseVisualStyleBackColor = false;
            this.BTVentas.Click += new System.EventHandler(this.BTVentas_Click);
            // 
            // TBCompras
            // 
            this.TBCompras.Location = new System.Drawing.Point(205, 332);
            this.TBCompras.Name = "TBCompras";
            this.TBCompras.Size = new System.Drawing.Size(100, 20);
            this.TBCompras.TabIndex = 18;
            // 
            // TBVentas
            // 
            this.TBVentas.Location = new System.Drawing.Point(205, 371);
            this.TBVentas.Name = "TBVentas";
            this.TBVentas.Size = new System.Drawing.Size(100, 20);
            this.TBVentas.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Compra de producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Venta de producto";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(545, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Salir del programa";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // BTSalir
            // 
            this.BTSalir.BackColor = System.Drawing.Color.Orchid;
            this.BTSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSalir.Location = new System.Drawing.Point(701, 357);
            this.BTSalir.Name = "BTSalir";
            this.BTSalir.Size = new System.Drawing.Size(75, 34);
            this.BTSalir.TabIndex = 23;
            this.BTSalir.Text = "Salir";
            this.BTSalir.UseVisualStyleBackColor = false;
            this.BTSalir.Click += new System.EventHandler(this.BTSalir_Click);
            // 
            // TBCompraNum
            // 
            this.TBCompraNum.Location = new System.Drawing.Point(322, 306);
            this.TBCompraNum.Name = "TBCompraNum";
            this.TBCompraNum.Size = new System.Drawing.Size(100, 20);
            this.TBCompraNum.TabIndex = 24;
            // 
            // TBVentaNum
            // 
            this.TBVentaNum.Location = new System.Drawing.Point(322, 348);
            this.TBVentaNum.Name = "TBVentaNum";
            this.TBVentaNum.Size = new System.Drawing.Size(100, 20);
            this.TBVentaNum.TabIndex = 25;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(213, 248);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(75, 42);
            this.Nombre.TabIndex = 26;
            this.Nombre.Text = "Ingresar\r\n nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 56);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ingresar \r\ncantidad";
            // 
            // Listaproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TBVentaNum);
            this.Controls.Add(this.TBCompraNum);
            this.Controls.Add(this.BTSalir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBVentas);
            this.Controls.Add(this.TBCompras);
            this.Controls.Add(this.BTVentas);
            this.Controls.Add(this.BTCompras);
            this.Controls.Add(this.TBcantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Load += new System.EventHandler(this.Listaproductos_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBcantidad;
        private System.Windows.Forms.Button BTCompras;
        private System.Windows.Forms.Button BTVentas;
        private System.Windows.Forms.TextBox TBCompras;
        private System.Windows.Forms.TextBox TBVentas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTSalir;
        private System.Windows.Forms.TextBox TBCompraNum;
        private System.Windows.Forms.TextBox TBVentaNum;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label11;
    }
}