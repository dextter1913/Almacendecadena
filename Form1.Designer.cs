namespace AlmacenDeCadena
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
            this.btniniciarsesionem = new System.Windows.Forms.Button();
            this.txtusuarioem = new System.Windows.Forms.TextBox();
            this.txtcontraseñaem = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btniniciarsesionem
            // 
            resources.ApplyResources(this.btniniciarsesionem, "btniniciarsesionem");
            this.btniniciarsesionem.Name = "btniniciarsesionem";
            this.btniniciarsesionem.UseVisualStyleBackColor = true;
            this.btniniciarsesionem.Click += new System.EventHandler(this.btniniciarsesionem_Click);
            // 
            // txtusuarioem
            // 
            resources.ApplyResources(this.txtusuarioem, "txtusuarioem");
            this.txtusuarioem.Name = "txtusuarioem";
            // 
            // txtcontraseñaem
            // 
            resources.ApplyResources(this.txtcontraseñaem, "txtcontraseñaem");
            this.txtcontraseñaem.Name = "txtcontraseñaem";
            this.txtcontraseñaem.UseSystemPasswordChar = true;
            // 
            // btncancelar
            // 
            resources.ApplyResources(this.btncancelar, "btncancelar");
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btniniciarsesionem);
            this.Controls.Add(this.txtusuarioem);
            this.Controls.Add(this.txtcontraseñaem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.2D;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniniciarsesionem;
        private System.Windows.Forms.TextBox txtusuarioem;
        private System.Windows.Forms.TextBox txtcontraseñaem;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

