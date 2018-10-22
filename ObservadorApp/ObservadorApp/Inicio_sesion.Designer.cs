namespace ObservadorApp
{
    partial class Inicio_sesion
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
            this.components = new System.ComponentModel.Container();
            this.tBUsuario = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gBUsuario = new System.Windows.Forms.GroupBox();
            this.gBContrasenia = new System.Windows.Forms.GroupBox();
            this.tBContrasenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContrasenia = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBUsuario.SuspendLayout();
            this.gBContrasenia.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasenia)).BeginInit();
            this.SuspendLayout();
            // 
            // tBUsuario
            // 
            this.tBUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUsuario.Location = new System.Drawing.Point(6, 26);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(237, 26);
            this.tBUsuario.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(341, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIngresar.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Location = new System.Drawing.Point(96, 264);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(249, 34);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // gBUsuario
            // 
            this.gBUsuario.BackColor = System.Drawing.Color.Silver;
            this.gBUsuario.Controls.Add(this.tBUsuario);
            this.gBUsuario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBUsuario.Location = new System.Drawing.Point(96, 105);
            this.gBUsuario.Name = "gBUsuario";
            this.gBUsuario.Size = new System.Drawing.Size(249, 66);
            this.gBUsuario.TabIndex = 14;
            this.gBUsuario.TabStop = false;
            this.gBUsuario.Text = "Usuario:";
            // 
            // gBContrasenia
            // 
            this.gBContrasenia.BackColor = System.Drawing.Color.Silver;
            this.gBContrasenia.Controls.Add(this.tBContrasenia);
            this.gBContrasenia.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBContrasenia.Location = new System.Drawing.Point(96, 182);
            this.gBContrasenia.Name = "gBContrasenia";
            this.gBContrasenia.Size = new System.Drawing.Size(249, 66);
            this.gBContrasenia.TabIndex = 15;
            this.gBContrasenia.TabStop = false;
            this.gBContrasenia.Text = "Contraseña:";
            // 
            // tBContrasenia
            // 
            this.tBContrasenia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBContrasenia.Location = new System.Drawing.Point(6, 26);
            this.tBContrasenia.Name = "tBContrasenia";
            this.tBContrasenia.Size = new System.Drawing.Size(237, 26);
            this.tBContrasenia.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraLight", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "Inicio de sesión";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 95);
            this.panel1.TabIndex = 18;
            // 
            // errorUsuario
            // 
            this.errorUsuario.ContainerControl = this;
            // 
            // errorContrasenia
            // 
            this.errorContrasenia.ContainerControl = this;
            // 
            // Inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(444, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBContrasenia);
            this.Controls.Add(this.gBUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Inicio_sesion";
            this.Text = "Inicio de sesión";
            this.gBUsuario.ResumeLayout(false);
            this.gBUsuario.PerformLayout();
            this.gBContrasenia.ResumeLayout(false);
            this.gBContrasenia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox gBUsuario;
        private System.Windows.Forms.GroupBox gBContrasenia;
        private System.Windows.Forms.TextBox tBContrasenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorUsuario;
        private System.Windows.Forms.ErrorProvider errorContrasenia;
    }
}