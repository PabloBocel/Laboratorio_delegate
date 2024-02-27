namespace Laboratorio_delegate
{
    partial class InicioDeSesion
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
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.BTiniciarsesion = new System.Windows.Forms.Button();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.BTpassword = new System.Windows.Forms.Label();
            this.BTnombre = new System.Windows.Forms.Label();
            this.BTregresar = new System.Windows.Forms.Button();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.BTCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.BackColor = System.Drawing.Color.DarkSalmon;
            this.BTLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTLimpiar.Location = new System.Drawing.Point(399, 246);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(156, 45);
            this.BTLimpiar.TabIndex = 11;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = false;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // BTiniciarsesion
            // 
            this.BTiniciarsesion.BackColor = System.Drawing.Color.DarkSalmon;
            this.BTiniciarsesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTiniciarsesion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTiniciarsesion.Location = new System.Drawing.Point(223, 246);
            this.BTiniciarsesion.Name = "BTiniciarsesion";
            this.BTiniciarsesion.Size = new System.Drawing.Size(156, 45);
            this.BTiniciarsesion.TabIndex = 10;
            this.BTiniciarsesion.Text = "Iniciar Sesion";
            this.BTiniciarsesion.UseVisualStyleBackColor = false;
            this.BTiniciarsesion.Click += new System.EventHandler(this.BTiniciarsesion_Click);
            // 
            // TBpass
            // 
            this.TBpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpass.Location = new System.Drawing.Point(200, 192);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(322, 26);
            this.TBpass.TabIndex = 9;
            this.TBpass.TextChanged += new System.EventHandler(this.TBpass_TextChanged);
            // 
            // TBnombre
            // 
            this.TBnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(202, 98);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(322, 26);
            this.TBnombre.TabIndex = 8;
            this.TBnombre.TextChanged += new System.EventHandler(this.TBnombre_TextChanged);
            // 
            // BTpassword
            // 
            this.BTpassword.AutoSize = true;
            this.BTpassword.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTpassword.Location = new System.Drawing.Point(50, 187);
            this.BTpassword.Name = "BTpassword";
            this.BTpassword.Size = new System.Drawing.Size(144, 31);
            this.BTpassword.TabIndex = 7;
            this.BTpassword.Text = "Contraseña";
            this.BTpassword.Click += new System.EventHandler(this.BTpassword_Click);
            // 
            // BTnombre
            // 
            this.BTnombre.AutoSize = true;
            this.BTnombre.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnombre.Location = new System.Drawing.Point(50, 92);
            this.BTnombre.Name = "BTnombre";
            this.BTnombre.Size = new System.Drawing.Size(109, 31);
            this.BTnombre.TabIndex = 6;
            this.BTnombre.Text = "Nombre";
            this.BTnombre.Click += new System.EventHandler(this.BTnombre_Click);
            // 
            // BTregresar
            // 
            this.BTregresar.BackColor = System.Drawing.Color.DarkSalmon;
            this.BTregresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTregresar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTregresar.Location = new System.Drawing.Point(41, 246);
            this.BTregresar.Name = "BTregresar";
            this.BTregresar.Size = new System.Drawing.Size(156, 45);
            this.BTregresar.TabIndex = 12;
            this.BTregresar.Text = "Regresar";
            this.BTregresar.UseVisualStyleBackColor = false;
            this.BTregresar.Click += new System.EventHandler(this.BTregresar_Click);
            // 
            // TBCorreo
            // 
            this.TBCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreo.Location = new System.Drawing.Point(202, 148);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(322, 26);
            this.TBCorreo.TabIndex = 14;
            this.TBCorreo.TextChanged += new System.EventHandler(this.TBCorreo_TextChanged);
            // 
            // BTCorreo
            // 
            this.BTCorreo.AutoSize = true;
            this.BTCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCorreo.Location = new System.Drawing.Point(50, 142);
            this.BTCorreo.Name = "BTCorreo";
            this.BTCorreo.Size = new System.Drawing.Size(92, 31);
            this.BTCorreo.TabIndex = 13;
            this.BTCorreo.Text = "Correo";
            this.BTCorreo.Click += new System.EventHandler(this.BTCorreo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "INICIO  DE SESIÓN ";
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(585, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.BTCorreo);
            this.Controls.Add(this.BTregresar);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.BTiniciarsesion);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.BTpassword);
            this.Controls.Add(this.BTnombre);
            this.Name = "InicioDeSesion";
            this.Text = "InicioDeSesion";
            this.Load += new System.EventHandler(this.InicioDeSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Button BTiniciarsesion;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Label BTpassword;
        private System.Windows.Forms.Label BTnombre;
        private System.Windows.Forms.Button BTregresar;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Label BTCorreo;
        private System.Windows.Forms.Label label1;
    }
}