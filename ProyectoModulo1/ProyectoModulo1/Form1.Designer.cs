
namespace ProyectoModulo1
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
            this.inicio_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inicio_btn
            // 
            this.inicio_btn.Location = new System.Drawing.Point(135, 134);
            this.inicio_btn.Name = "inicio_btn";
            this.inicio_btn.Size = new System.Drawing.Size(139, 59);
            this.inicio_btn.TabIndex = 1;
            this.inicio_btn.Text = "Inicio de sesión";
            this.inicio_btn.UseVisualStyleBackColor = true;
            this.inicio_btn.Click += new System.EventHandler(this.inicio_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inicio_btn);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "¿Quién quiere ser millonario?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inicio_btn;
        private System.Windows.Forms.Button button1;
    }
}

