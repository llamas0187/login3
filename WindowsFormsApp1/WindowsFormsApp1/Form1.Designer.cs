namespace WindowsFormsApp1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Textusuario = new System.Windows.Forms.TextBox();
            this.Textcontra = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "contraseña";
            // 
            // Textusuario
            // 
            this.Textusuario.Location = new System.Drawing.Point(181, 43);
            this.Textusuario.Name = "Textusuario";
            this.Textusuario.Size = new System.Drawing.Size(130, 20);
            this.Textusuario.TabIndex = 2;
            // 
            // Textcontra
            // 
            this.Textcontra.Location = new System.Drawing.Point(181, 131);
            this.Textcontra.Name = "Textcontra";
            this.Textcontra.Size = new System.Drawing.Size(130, 20);
            this.Textcontra.TabIndex = 3;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Aceptar.Location = new System.Drawing.Point(589, 276);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(114, 68);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Salir.Location = new System.Drawing.Point(39, 276);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(117, 68);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click_1);
            // 
            // Form1
            // 
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.selfie_gato;
            this.ClientSize = new System.Drawing.Size(715, 373);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Textcontra);
            this.Controls.Add(this.Textusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Iniciar sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Textusuario;
        private System.Windows.Forms.TextBox Textcontra;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Salir;
    }
}

