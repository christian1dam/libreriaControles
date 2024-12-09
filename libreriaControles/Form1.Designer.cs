namespace libreriaControles
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
            this.botonCircular1 = new libreriaControles.botonCircular();
            this.botonCircular2 = new libreriaControles.botonCircular();
            this.SuspendLayout();
            // 
            // botonCircular1
            // 
            this.botonCircular1.DefaultColor = System.Drawing.Color.MediumVioletRed;
            this.botonCircular1.HoverColor = System.Drawing.Color.GreenYellow;
            this.botonCircular1.Location = new System.Drawing.Point(231, 154);
            this.botonCircular1.Name = "botonCircular1";
            this.botonCircular1.Size = new System.Drawing.Size(100, 100);
            this.botonCircular1.TabIndex = 0;
            this.botonCircular1.Text = "botonCircular1";
            // 
            // botonCircular2
            // 
            this.botonCircular2.DefaultColor = System.Drawing.Color.Blue;
            this.botonCircular2.HoverColor = System.Drawing.Color.LightBlue;
            this.botonCircular2.Location = new System.Drawing.Point(520, 154);
            this.botonCircular2.Name = "botonCircular2";
            this.botonCircular2.Size = new System.Drawing.Size(100, 100);
            this.botonCircular2.TabIndex = 1;
            this.botonCircular2.Text = "botonCircular2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.botonCircular2);
            this.Controls.Add(this.botonCircular1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private botonCircular botonCircular1;
        private botonCircular botonCircular2;
    }
}

