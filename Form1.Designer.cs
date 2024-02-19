namespace Laboratorio_delegate
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.BTiniciosesion = new System.Windows.Forms.Button();
            this.BTregistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(269, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(205, 31);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Chepe te vende";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTiniciosesion
            // 
            this.BTiniciosesion.Location = new System.Drawing.Point(217, 180);
            this.BTiniciosesion.Name = "BTiniciosesion";
            this.BTiniciosesion.Size = new System.Drawing.Size(117, 23);
            this.BTiniciosesion.TabIndex = 1;
            this.BTiniciosesion.Text = "Inicio de sesion";
            this.BTiniciosesion.UseVisualStyleBackColor = true;
            this.BTiniciosesion.Click += new System.EventHandler(this.BTiniciosesion_Click);
            // 
            // BTregistro
            // 
            this.BTregistro.Location = new System.Drawing.Point(416, 180);
            this.BTregistro.Name = "BTregistro";
            this.BTregistro.Size = new System.Drawing.Size(117, 23);
            this.BTregistro.TabIndex = 2;
            this.BTregistro.Text = "Registro";
            this.BTregistro.UseVisualStyleBackColor = true;
            this.BTregistro.Click += new System.EventHandler(this.BTregistro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 412);
            this.Controls.Add(this.BTregistro);
            this.Controls.Add(this.BTiniciosesion);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BTiniciosesion;
        private System.Windows.Forms.Button BTregistro;
    }
}

