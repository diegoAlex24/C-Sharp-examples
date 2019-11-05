namespace program_2
{
    partial class FormPrincipal
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
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(55, 76);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(177, 29);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Hello Visual C#";
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(90, 140);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(102, 33);
            this.buttonClick.TabIndex = 1;
            this.buttonClick.Text = "Haz Click";
            this.buttonClick.UseVisualStyleBackColor = true;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.labelHello);
            this.Name = "FormPrincipal";
            this.Text = "Interfaz principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonClick;
    }
}

