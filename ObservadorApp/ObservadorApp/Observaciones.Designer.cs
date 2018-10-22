namespace ObservadorApp
{
    partial class Observaciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idObservacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObservadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaObservacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaOservacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observacionesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observacionesDataSet = new ObservadorApp.ObservacionesDataSet();
            this.observacionTableAdapter = new ObservadorApp.ObservacionesDataSetTableAdapters.observacionTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbObservadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObservacionDataGridViewTextBoxColumn,
            this.idObservadorDataGridViewTextBoxColumn,
            this.idEspecieDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fechaObservacionDataGridViewTextBoxColumn,
            this.horaOservacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.observacionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 107);
            this.dataGridView1.TabIndex = 0;
            // 
            // idObservacionDataGridViewTextBoxColumn
            // 
            this.idObservacionDataGridViewTextBoxColumn.DataPropertyName = "idObservacion";
            this.idObservacionDataGridViewTextBoxColumn.HeaderText = "idObservacion";
            this.idObservacionDataGridViewTextBoxColumn.Name = "idObservacionDataGridViewTextBoxColumn";
            this.idObservacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idObservadorDataGridViewTextBoxColumn
            // 
            this.idObservadorDataGridViewTextBoxColumn.DataPropertyName = "idObservador";
            this.idObservadorDataGridViewTextBoxColumn.HeaderText = "idObservador";
            this.idObservadorDataGridViewTextBoxColumn.Name = "idObservadorDataGridViewTextBoxColumn";
            // 
            // idEspecieDataGridViewTextBoxColumn
            // 
            this.idEspecieDataGridViewTextBoxColumn.DataPropertyName = "idEspecie";
            this.idEspecieDataGridViewTextBoxColumn.HeaderText = "idEspecie";
            this.idEspecieDataGridViewTextBoxColumn.Name = "idEspecieDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // fechaObservacionDataGridViewTextBoxColumn
            // 
            this.fechaObservacionDataGridViewTextBoxColumn.DataPropertyName = "fechaObservacion";
            this.fechaObservacionDataGridViewTextBoxColumn.HeaderText = "fechaObservacion";
            this.fechaObservacionDataGridViewTextBoxColumn.Name = "fechaObservacionDataGridViewTextBoxColumn";
            // 
            // horaOservacionDataGridViewTextBoxColumn
            // 
            this.horaOservacionDataGridViewTextBoxColumn.DataPropertyName = "horaOservacion";
            this.horaOservacionDataGridViewTextBoxColumn.HeaderText = "horaOservacion";
            this.horaOservacionDataGridViewTextBoxColumn.Name = "horaOservacionDataGridViewTextBoxColumn";
            // 
            // observacionBindingSource
            // 
            this.observacionBindingSource.DataMember = "observacion";
            this.observacionBindingSource.DataSource = this.observacionesDataSetBindingSource;
            // 
            // observacionesDataSetBindingSource
            // 
            this.observacionesDataSetBindingSource.DataSource = this.observacionesDataSet;
            this.observacionesDataSetBindingSource.Position = 0;
            // 
            // observacionesDataSet
            // 
            this.observacionesDataSet.DataSetName = "ObservacionesDataSet";
            this.observacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // observacionTableAdapter
            // 
            this.observacionTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbObservadores
            // 
            this.cmbObservadores.FormattingEnabled = true;
            this.cmbObservadores.Location = new System.Drawing.Point(36, 34);
            this.cmbObservadores.Name = "cmbObservadores";
            this.cmbObservadores.Size = new System.Drawing.Size(59, 21);
            this.cmbObservadores.TabIndex = 3;
            this.cmbObservadores.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo de Observador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo de Especie";
            // 
            // cmbEspecies
            // 
            this.cmbEspecies.FormattingEnabled = true;
            this.cmbEspecies.Location = new System.Drawing.Point(142, 34);
            this.cmbEspecies.Name = "cmbEspecies";
            this.cmbEspecies.Size = new System.Drawing.Size(64, 21);
            this.cmbEspecies.TabIndex = 6;
            this.cmbEspecies.Click += new System.EventHandler(this.comboBox1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha y hora de observacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbCantidad.Location = new System.Drawing.Point(441, 34);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(64, 21);
            this.cmbCantidad.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Observaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEspecies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbObservadores);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Observaciones";
            this.Text = "Observaciones";
            this.Load += new System.EventHandler(this.Observaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource observacionesDataSetBindingSource;
        private ObservacionesDataSet observacionesDataSet;
        private System.Windows.Forms.BindingSource observacionBindingSource;
        private ObservacionesDataSetTableAdapters.observacionTableAdapter observacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObservacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObservadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaObservacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaOservacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbObservadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspecies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Button button1;
    }
}