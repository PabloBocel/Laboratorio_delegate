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
            this.Titulo.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(109, 53);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(419, 65);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Chepe te vende";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTiniciosesion
            // 
            this.BTiniciosesion.BackColor = System.Drawing.Color.Lime;
            this.BTiniciosesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTiniciosesion.Location = new System.Drawing.Point(120, 167);
            this.BTiniciosesion.Name = "BTiniciosesion";
            this.BTiniciosesion.Size = new System.Drawing.Size(157, 83);
            this.BTiniciosesion.TabIndex = 1;
            this.BTiniciosesion.Text = "Inicio de sesion";
            this.BTiniciosesion.UseVisualStyleBackColor = false;
            this.BTiniciosesion.Click += new System.EventHandler(this.BTiniciosesion_Click);
            // 
            // BTregistro
            // 
            this.BTregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTregistro.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTregistro.Location = new System.Drawing.Point(343, 180);
            this.BTregistro.Name = "BTregistro";
            this.BTregistro.Size = new System.Drawing.Size(196, 56);
            this.BTregistro.TabIndex = 2;
            this.BTregistro.Text = "Registro";
            this.BTregistro.UseVisualStyleBackColor = false;
            this.BTregistro.Click += new System.EventHandler(this.BTregistro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 330);
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

