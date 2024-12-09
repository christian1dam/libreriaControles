namespace libreriaControles
{
    partial class selectorFechaHora
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.numHora = new System.Windows.Forms.NumericUpDown();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.chkHora = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(107, 26);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(270, 22);
            this.datePicker.TabIndex = 0;
            // 
            // numHora
            // 
            this.numHora.Location = new System.Drawing.Point(107, 95);
            this.numHora.Name = "numHora";
            this.numHora.Size = new System.Drawing.Size(120, 22);
            this.numHora.TabIndex = 1;
            // 
            // numMinutos
            // 
            this.numMinutos.Location = new System.Drawing.Point(107, 166);
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(120, 22);
            this.numMinutos.TabIndex = 2;
            // 
            // chkHora
            // 
            this.chkHora.AutoSize = true;
            this.chkHora.Location = new System.Drawing.Point(107, 211);
            this.chkHora.Name = "chkHora";
            this.chkHora.Size = new System.Drawing.Size(189, 20);
            this.chkHora.TabIndex = 3;
            this.chkHora.Text = "Habilitar selección de hora";
            this.chkHora.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minutos";
            // 
            // selectorFechaHora
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkHora);
            this.Controls.Add(this.numMinutos);
            this.Controls.Add(this.numHora);
            this.Controls.Add(this.datePicker);
            this.Name = "selectorFechaHora";
            this.Size = new System.Drawing.Size(484, 323);
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown numHora;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.CheckBox chkHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
