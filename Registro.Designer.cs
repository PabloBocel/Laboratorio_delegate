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
            this.SuspendLayout();
            // 
            // BTnombre
            // 
            this.BTnombre.AutoSize = true;
            this.BTnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnombre.Location = new System.Drawing.Point(154, 87);
            this.BTnombre.Name = "BTnombre";
            this.BTnombre.Size = new System.Drawing.Size(65, 20);
            this.BTnombre.TabIndex = 0;
            this.BTnombre.Text = "Nombre";
            // 
            // BTpassword
            // 
            this.BTpassword.AutoSize = true;
            this.BTpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTpassword.Location = new System.Drawing.Point(140, 127);
            this.BTpassword.Name = "BTpassword";
            this.BTpassword.Size = new System.Drawing.Size(92, 20);
            this.BTpassword.TabIndex = 1;
            this.BTpassword.Text = "Contraseña";
            // 
            // TBnombre
            // 
            this.TBnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(238, 84);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(134, 26);
            this.TBnombre.TabIndex = 2;
            // 
            // TBpass
            // 
            this.TBpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpass.Location = new System.Drawing.Point(238, 127);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(134, 26);
            this.TBpass.TabIndex = 3;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(489, 300);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(129, 47);
            this.Registrar.TabIndex = 4;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Location = new System.Drawing.Point(306, 300);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(129, 47);
            this.BTLimpiar.TabIndex = 5;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTregresar
            // 
            this.BTregresar.Location = new System.Drawing.Point(144, 300);
            this.BTregresar.Name = "BTregresar";
            this.BTregresar.Size = new System.Drawing.Size(129, 47);
            this.BTregresar.TabIndex = 6;
            this.BTregresar.Text = "Regresar";
            this.BTregresar.UseVisualStyleBackColor = true;
            this.BTregresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTregresar);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.BTpassword);
            this.Controls.Add(this.BTnombre);
            this.Name = "Registro";
            this.Text = "Registro";
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
    }
}