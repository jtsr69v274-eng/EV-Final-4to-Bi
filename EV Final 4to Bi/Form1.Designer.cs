namespace EV_Final_4to_Bi
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
            this.Textusuario = new System.Windows.Forms.TextBox();
            this.Textcontraseña = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LBL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Textusuario
            // 
            this.Textusuario.Location = new System.Drawing.Point(160, 58);
            this.Textusuario.Name = "Textusuario";
            this.Textusuario.Size = new System.Drawing.Size(100, 22);
            this.Textusuario.TabIndex = 0;
            this.Textusuario.Text = "Vacio";
            this.Textusuario.TextChanged += new System.EventHandler(this.Textusuario_TextChanged);
            // 
            // Textcontraseña
            // 
            this.Textcontraseña.Location = new System.Drawing.Point(431, 58);
            this.Textcontraseña.Name = "Textcontraseña";
            this.Textcontraseña.Size = new System.Drawing.Size(100, 22);
            this.Textcontraseña.TabIndex = 1;
            this.Textcontraseña.Text = "Vacio";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(160, 209);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(472, 209);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(88, 16);
            this.LBL1.TabIndex = 3;
            this.LBL1.Text = "Examen Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.Textcontraseña);
            this.Controls.Add(this.Textusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textusuario;
        private System.Windows.Forms.TextBox Textcontraseña;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LBL1;
    }
}

