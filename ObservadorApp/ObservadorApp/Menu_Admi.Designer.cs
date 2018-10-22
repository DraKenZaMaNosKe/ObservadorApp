namespace ObservadorApp
{
    partial class Menu_Admi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Admi));
            this.btnZona = new System.Windows.Forms.Button();
            this.btnEspecie = new System.Windows.Forms.Button();
            this.btnObservador = new System.Windows.Forms.Button();
            this.btnAsociacion = new System.Windows.Forms.Button();
            this.btnObservacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZona
            // 
            this.btnZona.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZona.Location = new System.Drawing.Point(102, 148);
            this.btnZona.Name = "btnZona";
            this.btnZona.Size = new System.Drawing.Size(212, 35);
            this.btnZona.TabIndex = 0;
            this.btnZona.Text = "Registrar zona";
            this.btnZona.UseVisualStyleBackColor = true;
            this.btnZona.Click += new System.EventHandler(this.btnZona_Click);
            // 
            // btnEspecie
            // 
            this.btnEspecie.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecie.Location = new System.Drawing.Point(102, 209);
            this.btnEspecie.Name = "btnEspecie";
            this.btnEspecie.Size = new System.Drawing.Size(212, 36);
            this.btnEspecie.TabIndex = 1;
            this.btnEspecie.Text = "Registrar especie";
            this.btnEspecie.UseVisualStyleBackColor = true;
            this.btnEspecie.Click += new System.EventHandler(this.btnEspecie_Click);
            // 
            // btnObservador
            // 
            this.btnObservador.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservador.Location = new System.Drawing.Point(102, 86);
            this.btnObservador.Name = "btnObservador";
            this.btnObservador.Size = new System.Drawing.Size(212, 36);
            this.btnObservador.TabIndex = 2;
            this.btnObservador.Text = "Registrar observador";
            this.btnObservador.UseVisualStyleBackColor = true;
            this.btnObservador.Click += new System.EventHandler(this.btnObservador_Click);
            // 
            // btnAsociacion
            // 
            this.btnAsociacion.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociacion.Location = new System.Drawing.Point(102, 271);
            this.btnAsociacion.Name = "btnAsociacion";
            this.btnAsociacion.Size = new System.Drawing.Size(212, 36);
            this.btnAsociacion.TabIndex = 3;
            this.btnAsociacion.Text = "Registrar asociación";
            this.btnAsociacion.UseVisualStyleBackColor = true;
            this.btnAsociacion.Click += new System.EventHandler(this.btnAsociacion_Click);
            // 
            // btnObservacion
            // 
            this.btnObservacion.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservacion.Location = new System.Drawing.Point(102, 333);
            this.btnObservacion.Name = "btnObservacion";
            this.btnObservacion.Size = new System.Drawing.Size(212, 36);
            this.btnObservacion.TabIndex = 8;
            this.btnObservacion.Text = "Observación";
            this.btnObservacion.UseVisualStyleBackColor = true;
            this.btnObservacion.Click += new System.EventHandler(this.btnObservacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Admi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnObservacion);
            this.Controls.Add(this.btnAsociacion);
            this.Controls.Add(this.btnObservador);
            this.Controls.Add(this.btnEspecie);
            this.Controls.Add(this.btnZona);
            this.Name = "Menu_Admi";
            this.Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZona;
        private System.Windows.Forms.Button btnEspecie;
        private System.Windows.Forms.Button btnObservador;
        private System.Windows.Forms.Button btnAsociacion;
        private System.Windows.Forms.Button btnObservacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}