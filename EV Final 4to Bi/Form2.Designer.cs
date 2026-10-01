namespace EV_Final_4to_Bi
{
    partial class TextVar1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextVar2 = new System.Windows.Forms.TextBox();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnPotencia = new System.Windows.Forms.Button();
            this.BtnDivicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Vacio";
            // 
            // TextVar2
            // 
            this.TextVar2.Location = new System.Drawing.Point(380, 60);
            this.TextVar2.Name = "TextVar2";
            this.TextVar2.Size = new System.Drawing.Size(100, 22);
            this.TextVar2.TabIndex = 1;
            this.TextVar2.Text = "Vacio";
            // 
            // BtnProducto
            // 
            this.BtnProducto.Location = new System.Drawing.Point(106, 162);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnProducto.TabIndex = 2;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = true;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(356, 162);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 3;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = true;
            // 
            // BtnPotencia
            // 
            this.BtnPotencia.Location = new System.Drawing.Point(509, 152);
            this.BtnPotencia.Name = "BtnPotencia";
            this.BtnPotencia.Size = new System.Drawing.Size(75, 23);
            this.BtnPotencia.TabIndex = 4;
            this.BtnPotencia.Text = "Potencia";
            this.BtnPotencia.UseVisualStyleBackColor = true;
            // 
            // BtnDivicion
            // 
            this.BtnDivicion.Location = new System.Drawing.Point(106, 338);
            this.BtnDivicion.Name = "BtnDivicion";
            this.BtnDivicion.Size = new System.Drawing.Size(75, 23);
            this.BtnDivicion.TabIndex = 5;
            this.BtnDivicion.Text = "Divicion ";
            this.BtnDivicion.UseVisualStyleBackColor = true;
            // 
            // TextVar1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDivicion);
            this.Controls.Add(this.BtnPotencia);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.TextVar2);
            this.Controls.Add(this.textBox1);
            this.Name = "TextVar1";
            this.Text = "Vacio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextVar2;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnPotencia;
        private System.Windows.Forms.Button BtnDivicion;

        public static string Text { get; internal set; }
    }
}