namespace numero1_10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.continuar = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(140, 28);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un número:";
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(246, 28);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(67, 20);
            this.continuar.TabIndex = 2;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3});
            this.tabla.Location = new System.Drawing.Point(375, 12);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(343, 188);
            this.tabla.TabIndex = 3;
            // 
            // columna1
            // 
            this.columna1.HeaderText = "Número ingresado";
            this.columna1.Name = "columna1";
            // 
            // columna2
            // 
            this.columna2.HeaderText = "Multiplicar por";
            this.columna2.Name = "columna2";
            // 
            // columna3
            // 
            this.columna3.HeaderText = "Total";
            this.columna3.Name = "columna3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 212);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Multiplicar con ciclo para.";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
    }
}

