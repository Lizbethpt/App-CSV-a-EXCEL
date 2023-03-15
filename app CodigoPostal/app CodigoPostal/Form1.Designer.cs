namespace app_CodigoPostal
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.btnGuardarconInterop = new System.Windows.Forms.Button();
            this.btnGuardarconOpenxml = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(28, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
            // 
            // lstvDatos
            // 
            this.lstvDatos.HideSelection = false;
            this.lstvDatos.Location = new System.Drawing.Point(12, 63);
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(418, 366);
            this.lstvDatos.TabIndex = 1;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnGuardarconInterop
            // 
            this.btnGuardarconInterop.Location = new System.Drawing.Point(125, 12);
            this.btnGuardarconInterop.Name = "btnGuardarconInterop";
            this.btnGuardarconInterop.Size = new System.Drawing.Size(116, 23);
            this.btnGuardarconInterop.TabIndex = 3;
            this.btnGuardarconInterop.Text = "Guardar con Interop";
            this.btnGuardarconInterop.UseVisualStyleBackColor = true;
            this.btnGuardarconInterop.Click += new System.EventHandler(this.btnGuardarconInterop_Click);
            // 
            // btnGuardarconOpenxml
            // 
            this.btnGuardarconOpenxml.Location = new System.Drawing.Point(270, 12);
            this.btnGuardarconOpenxml.Name = "btnGuardarconOpenxml";
            this.btnGuardarconOpenxml.Size = new System.Drawing.Size(137, 23);
            this.btnGuardarconOpenxml.TabIndex = 4;
            this.btnGuardarconOpenxml.Text = "Guardar con OpenXml";
            this.btnGuardarconOpenxml.UseVisualStyleBackColor = true;
            this.btnGuardarconOpenxml.Click += new System.EventHandler(this.btnGuardarconOpenxml_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(713, 423);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardarconOpenxml);
            this.Controls.Add(this.btnGuardarconInterop);
            this.Controls.Add(this.lstvDatos);
            this.Controls.Add(this.btnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.Button btnGuardarconInterop;
        private System.Windows.Forms.Button btnGuardarconOpenxml;
        private System.Windows.Forms.Button btnCerrar;
    }
}

