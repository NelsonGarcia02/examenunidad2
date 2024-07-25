namespace PrestamosExamenUnidad2
{
    partial class FrmPrestamos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtPrestamo_Codigo = new TextBox();
            label2 = new Label();
            txtPrestamo_CodigoLibro = new TextBox();
            label3 = new Label();
            txtPrestamos_MiembroId = new TextBox();
            label4 = new Label();
            dateTimePicker1Prestamo = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1Devolucion = new DateTimePicker();
            groupBox2 = new GroupBox();
            btnPrestamo_Salir = new Button();
            btnPrestamo_Modificar = new Button();
            btnPrestamo_Eliminar = new Button();
            btnPrestamo_Guardar = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 237);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo Del Prestamo";
            // 
            // txtPrestamo_Codigo
            // 
            txtPrestamo_Codigo.Location = new Point(170, 229);
            txtPrestamo_Codigo.Name = "txtPrestamo_Codigo";
            txtPrestamo_Codigo.Size = new Size(100, 23);
            txtPrestamo_Codigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 267);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 3;
            label2.Text = "Codigo Del Libro";
            // 
            // txtPrestamo_CodigoLibro
            // 
            txtPrestamo_CodigoLibro.Location = new Point(170, 258);
            txtPrestamo_CodigoLibro.Name = "txtPrestamo_CodigoLibro";
            txtPrestamo_CodigoLibro.Size = new Size(100, 23);
            txtPrestamo_CodigoLibro.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 295);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Miembro Id";
            // 
            // txtPrestamos_MiembroId
            // 
            txtPrestamos_MiembroId.Location = new Point(170, 287);
            txtPrestamos_MiembroId.Name = "txtPrestamos_MiembroId";
            txtPrestamos_MiembroId.Size = new Size(100, 23);
            txtPrestamos_MiembroId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 320);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha Del Prestamo";
            // 
            // dateTimePicker1Prestamo
            // 
            dateTimePicker1Prestamo.Format = DateTimePickerFormat.Short;
            dateTimePicker1Prestamo.Location = new Point(170, 316);
            dateTimePicker1Prestamo.Name = "dateTimePicker1Prestamo";
            dateTimePicker1Prestamo.Size = new Size(101, 23);
            dateTimePicker1Prestamo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 353);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha De Devolucion";
            // 
            // dateTimePicker1Devolucion
            // 
            dateTimePicker1Devolucion.Format = DateTimePickerFormat.Short;
            dateTimePicker1Devolucion.Location = new Point(170, 351);
            dateTimePicker1Devolucion.Name = "dateTimePicker1Devolucion";
            dateTimePicker1Devolucion.Size = new Size(101, 23);
            dateTimePicker1Devolucion.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPrestamo_Salir);
            groupBox2.Controls.Add(btnPrestamo_Modificar);
            groupBox2.Controls.Add(btnPrestamo_Eliminar);
            groupBox2.Controls.Add(btnPrestamo_Guardar);
            groupBox2.Location = new Point(611, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(143, 164);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Accion a Ejecutar";
            // 
            // btnPrestamo_Salir
            // 
            btnPrestamo_Salir.Location = new Point(6, 115);
            btnPrestamo_Salir.Name = "btnPrestamo_Salir";
            btnPrestamo_Salir.Size = new Size(75, 23);
            btnPrestamo_Salir.TabIndex = 7;
            btnPrestamo_Salir.Text = "Salir";
            btnPrestamo_Salir.UseVisualStyleBackColor = true;
            // 
            // btnPrestamo_Modificar
            // 
            btnPrestamo_Modificar.Location = new Point(6, 86);
            btnPrestamo_Modificar.Name = "btnPrestamo_Modificar";
            btnPrestamo_Modificar.Size = new Size(75, 23);
            btnPrestamo_Modificar.TabIndex = 6;
            btnPrestamo_Modificar.Text = "Modificar";
            btnPrestamo_Modificar.UseVisualStyleBackColor = true;
            // 
            // btnPrestamo_Eliminar
            // 
            btnPrestamo_Eliminar.Location = new Point(6, 57);
            btnPrestamo_Eliminar.Name = "btnPrestamo_Eliminar";
            btnPrestamo_Eliminar.Size = new Size(75, 23);
            btnPrestamo_Eliminar.TabIndex = 5;
            btnPrestamo_Eliminar.Text = "Eliminar";
            btnPrestamo_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btnPrestamo_Guardar
            // 
            btnPrestamo_Guardar.Location = new Point(6, 22);
            btnPrestamo_Guardar.Name = "btnPrestamo_Guardar";
            btnPrestamo_Guardar.Size = new Size(75, 23);
            btnPrestamo_Guardar.TabIndex = 4;
            btnPrestamo_Guardar.Text = "Guardar";
            btnPrestamo_Guardar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(348, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagen Del Libro";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(348, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Imagen Del Miembro";
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1Devolucion);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1Prestamo);
            Controls.Add(label4);
            Controls.Add(txtPrestamos_MiembroId);
            Controls.Add(label3);
            Controls.Add(txtPrestamo_CodigoLibro);
            Controls.Add(label2);
            Controls.Add(txtPrestamo_Codigo);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmPrestamos";
            Text = "Prestamos";
            Load += FrmPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtPrestamo_Codigo;
        private Label label2;
        private TextBox txtPrestamo_CodigoLibro;
        private Label label3;
        private TextBox txtPrestamos_MiembroId;
        private Label label4;
        private DateTimePicker dateTimePicker1Prestamo;
        private Label label5;
        private DateTimePicker dateTimePicker1Devolucion;
        private GroupBox groupBox2;
        private Button btnPrestamo_Salir;
        private Button btnPrestamo_Modificar;
        private Button btnPrestamo_Eliminar;
        private Button btnPrestamo_Guardar;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
    }
}
