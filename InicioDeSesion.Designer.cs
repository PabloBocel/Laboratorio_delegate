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
            this.SuspendLayout();
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Location = new System.Drawing.Point(319, 310);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(129, 47);
            this.BTLimpiar.TabIndex = 11;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // BTiniciarsesion
            // 
            this.BTiniciarsesion.Location = new System.Drawing.Point(510, 310);
            this.BTiniciarsesion.Name = "BTiniciarsesion";
            this.BTiniciarsesion.Size = new System.Drawing.Size(129, 47);
            this.BTiniciarsesion.TabIndex = 10;
            this.BTiniciarsesion.Text = "Iniciar Sesion";
            this.BTiniciarsesion.UseVisualStyleBackColor = true;
            this.BTiniciarsesion.Click += new System.EventHandler(this.BTiniciarsesion_Click);
            // 
            // TBpass
            // 
            this.TBpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpass.Location = new System.Drawing.Point(259, 183);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(300, 26);
            this.TBpass.TabIndex = 9;
            // 
            // TBnombre
            // 
            this.TBnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(259, 94);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(300, 26);
            this.TBnombre.TabIndex = 8;
            // 
            // BTpassword
            // 
            this.BTpassword.AutoSize = true;
            this.BTpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTpassword.Location = new System.Drawing.Point(161, 183);
            this.BTpassword.Name = "BTpassword";
            this.BTpassword.Size = new System.Drawing.Size(92, 20);
            this.BTpassword.TabIndex = 7;
            this.BTpassword.Text = "Contraseña";
            // 
            // BTnombre
            // 
            this.BTnombre.AutoSize = true;
            this.BTnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnombre.Location = new System.Drawing.Point(175, 97);
            this.BTnombre.Name = "BTnombre";
            this.BTnombre.Size = new System.Drawing.Size(65, 20);
            this.BTnombre.TabIndex = 6;
            this.BTnombre.Text = "Nombre";
            // 
            // BTregresar
            // 
            this.BTregresar.Location = new System.Drawing.Point(124, 310);
            this.BTregresar.Name = "BTregresar";
            this.BTregresar.Size = new System.Drawing.Size(129, 47);
            this.BTregresar.TabIndex = 12;
            this.BTregresar.Text = "Regresar";
            this.BTregresar.UseVisualStyleBackColor = true;
            this.BTregresar.Click += new System.EventHandler(this.BTregresar_Click);
            // 
            // TBCorreo
            // 
            this.TBCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreo.Location = new System.Drawing.Point(259, 138);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(300, 26);
            this.TBCorreo.TabIndex = 14;
            // 
            // BTCorreo
            // 
            this.BTCorreo.AutoSize = true;
            this.BTCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCorreo.Location = new System.Drawing.Point(175, 141);
            this.BTCorreo.Name = "BTCorreo";
            this.BTCorreo.Size = new System.Drawing.Size(57, 20);
            this.BTCorreo.TabIndex = 13;
            this.BTCorreo.Text = "Correo";
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}