namespace Ev_Final_4ToBii
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
            this.LbL1 = new System.Windows.Forms.Label();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbL1
            // 
            this.LbL1.BackColor = System.Drawing.Color.Yellow;
            this.LbL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LbL1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbL1.Location = new System.Drawing.Point(325, 78);
            this.LbL1.Name = "LbL1";
            this.LbL1.Size = new System.Drawing.Size(171, 35);
            this.LbL1.TabIndex = 10;
            this.LbL1.Text = "Examen Final";
            // 
            // TextContraseña
            // 
            this.TextContraseña.Location = new System.Drawing.Point(459, 216);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(107, 22);
            this.TextContraseña.TabIndex = 9;
            // 
            // TextUsuario
            // 
            this.TextUsuario.Location = new System.Drawing.Point(237, 216);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(112, 22);
            this.TextUsuario.TabIndex = 8;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Red;
            this.BtnIngresar.Location = new System.Drawing.Point(354, 291);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(115, 37);
            this.BtnIngresar.TabIndex = 7;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 459);
            this.Controls.Add(this.LbL1);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextUsuario);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbL1;
        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.Button BtnIngresar;
    }
}

