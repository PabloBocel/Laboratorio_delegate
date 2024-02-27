namespace Laboratorio_delegate
{
    partial class Registro
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
            this.BTnombre = new System.Windows.Forms.Label();
            this.BTpassword = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.BTregresar = new System.Windows.Forms.Button();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.BTCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTnombre
            // 
            this.BTnombre.AutoSize = true;
            this.BTnombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnombre.Location = new System.Drawing.Point(75, 98);
            this.BTnombre.Name = "BTnombre";
            this.BTnombre.Size = new System.Drawing.Size(128, 36);
            this.BTnombre.TabIndex = 0;
            this.BTnombre.Text = "Nombre";
            // 
            // BTpassword
            // 
            this.BTpassword.AutoSize = true;
            this.BTpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTpassword.Location = new System.Drawing.Point(75, 185);
            this.BTpassword.Name = "BTpassword";
            this.BTpassword.Size = new System.Drawing.Size(170, 36);
            this.BTpassword.TabIndex = 1;
            this.BTpassword.Text = "Contraseña";
            // 
            // TBnombre
            // 
            this.TBnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(250, 108);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(300, 26);
            this.TBnombre.TabIndex = 2;
            // 
            // TBpass
            // 
            this.TBpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpass.Location = new System.Drawing.Point(250, 198);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(300, 26);
            this.TBpass.TabIndex = 3;
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.Color.Plum;
            this.Registrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(433, 270);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(157, 47);
            this.Registrar.TabIndex = 4;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.BackColor = System.Drawing.Color.Plum;
            this.BTLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLimpiar.Location = new System.Drawing.Point(250, 270);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(157, 47);
            this.BTLimpiar.TabIndex = 5;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = false;
            this.BTLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTregresar
            // 
            this.BTregresar.BackColor = System.Drawing.Color.Plum;
            this.BTregresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTregresar.Location = new System.Drawing.Point(63, 270);
            this.BTregresar.Name = "BTregresar";
            this.BTregresar.Size = new System.Drawing.Size(157, 47);
            this.BTregresar.TabIndex = 6;
            this.BTregresar.Text = "Regresar";
            this.BTregresar.UseVisualStyleBackColor = false;
            this.BTregresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TBCorreo
            // 
            this.TBCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreo.Location = new System.Drawing.Point(250, 153);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(300, 26);
            this.TBCorreo.TabIndex = 8;
            this.TBCorreo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTCorreo
            // 
            this.BTCorreo.AutoSize = true;
            this.BTCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCorreo.Location = new System.Drawing.Point(75, 143);
            this.BTCorreo.Name = "BTCorreo";
            this.BTCorreo.Size = new System.Drawing.Size(107, 36);
            this.BTCorreo.TabIndex = 7;
            this.BTCorreo.Text = "Correo";
            this.BTCorreo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "REGISTRO";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(666, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.BTCorreo);
            this.Controls.Add(this.BTregresar);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.BTpassword);
            this.Controls.Add(this.BTnombre);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BTnombre;
        private System.Windows.Forms.Label BTpassword;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Button BTregresar;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Label BTCorreo;
        private System.Windows.Forms.Label label1;
    }
}