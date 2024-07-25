namespace examenunidad2
{
    partial class FrmLibros
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
            txtLibro_Codigo = new TextBox();
            label2 = new Label();
            txtLibro_Titulo = new TextBox();
            txtLibro_Autor = new Label();
            txtLibroAutor = new TextBox();
            label3 = new Label();
            cbLibro_Categoria = new ComboBox();
            label4 = new Label();
            dateTimePicker1Libro = new DateTimePicker();
            label5 = new Label();
            txtLibro_Cantidad = new TextBox();
            label6 = new Label();
            txtLibro_PrecioCompra = new TextBox();
            label7 = new Label();
            txtLibro_PrecioVenta = new TextBox();
            groupBox1 = new GroupBox();
            btnLibro_Guardar = new Button();
            btnLibro_Eliminar = new Button();
            btnLibro_Modificar = new Button();
            btnLibro_Salir = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(894, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 190);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo Del Libro";
            // 
            // txtLibro_Codigo
            // 
            txtLibro_Codigo.Location = new Point(222, 182);
            txtLibro_Codigo.Name = "txtLibro_Codigo";
            txtLibro_Codigo.Size = new Size(100, 23);
            txtLibro_Codigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 221);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Titulo Del Libro";
            // 
            // txtLibro_Titulo
            // 
            txtLibro_Titulo.Location = new Point(222, 211);
            txtLibro_Titulo.Name = "txtLibro_Titulo";
            txtLibro_Titulo.Size = new Size(100, 23);
            txtLibro_Titulo.TabIndex = 4;
            // 
            // txtLibro_Autor
            // 
            txtLibro_Autor.AutoSize = true;
            txtLibro_Autor.Location = new Point(46, 248);
            txtLibro_Autor.Name = "txtLibro_Autor";
            txtLibro_Autor.Size = new Size(87, 15);
            txtLibro_Autor.TabIndex = 5;
            txtLibro_Autor.Text = "Autor Del Libro";
            // 
            // txtLibroAutor
            // 
            txtLibroAutor.Location = new Point(222, 239);
            txtLibroAutor.Name = "txtLibroAutor";
            txtLibroAutor.Size = new Size(100, 23);
            txtLibroAutor.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 274);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 7;
            label3.Text = "Categoria Del Libro";
            // 
            // cbLibro_Categoria
            // 
            cbLibro_Categoria.FormattingEnabled = true;
            cbLibro_Categoria.Location = new Point(222, 269);
            cbLibro_Categoria.Name = "cbLibro_Categoria";
            cbLibro_Categoria.Size = new Size(102, 23);
            cbLibro_Categoria.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 300);
            label4.Name = "label4";
            label4.Size = new Size(170, 15);
            label4.TabIndex = 9;
            label4.Text = "Fecha De Publicacion Del Libro";
            // 
            // dateTimePicker1Libro
            // 
            dateTimePicker1Libro.Format = DateTimePickerFormat.Short;
            dateTimePicker1Libro.Location = new Point(222, 298);
            dateTimePicker1Libro.Name = "dateTimePicker1Libro";
            dateTimePicker1Libro.Size = new Size(100, 23);
            dateTimePicker1Libro.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 331);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 11;
            label5.Text = "Cantidad Del Libro";
            // 
            // txtLibro_Cantidad
            // 
            txtLibro_Cantidad.Location = new Point(222, 327);
            txtLibro_Cantidad.Name = "txtLibro_Cantidad";
            txtLibro_Cantidad.Size = new Size(100, 23);
            txtLibro_Cantidad.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 358);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 13;
            label6.Text = "Precio De Compra";
            // 
            // txtLibro_PrecioCompra
            // 
            txtLibro_PrecioCompra.Location = new Point(222, 350);
            txtLibro_PrecioCompra.Name = "txtLibro_PrecioCompra";
            txtLibro_PrecioCompra.Size = new Size(100, 23);
            txtLibro_PrecioCompra.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 386);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 15;
            label7.Text = "Precio  De Venta Libro";
            // 
            // txtLibro_PrecioVenta
            // 
            txtLibro_PrecioVenta.Location = new Point(222, 378);
            txtLibro_PrecioVenta.Name = "txtLibro_PrecioVenta";
            txtLibro_PrecioVenta.Size = new Size(100, 23);
            txtLibro_PrecioVenta.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLibro_Salir);
            groupBox1.Controls.Add(btnLibro_Modificar);
            groupBox1.Controls.Add(btnLibro_Eliminar);
            groupBox1.Controls.Add(btnLibro_Guardar);
            groupBox1.Location = new Point(752, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(116, 157);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Accion a Ejecutar";
            // 
            // btnLibro_Guardar
            // 
            btnLibro_Guardar.Location = new Point(15, 27);
            btnLibro_Guardar.Name = "btnLibro_Guardar";
            btnLibro_Guardar.Size = new Size(75, 23);
            btnLibro_Guardar.TabIndex = 0;
            btnLibro_Guardar.Text = "Guardar";
            btnLibro_Guardar.UseVisualStyleBackColor = true;
            // 
            // btnLibro_Eliminar
            // 
            btnLibro_Eliminar.Location = new Point(16, 58);
            btnLibro_Eliminar.Name = "btnLibro_Eliminar";
            btnLibro_Eliminar.Size = new Size(75, 23);
            btnLibro_Eliminar.TabIndex = 1;
            btnLibro_Eliminar.Text = "Eliminar";
            btnLibro_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btnLibro_Modificar
            // 
            btnLibro_Modificar.Location = new Point(17, 92);
            btnLibro_Modificar.Name = "btnLibro_Modificar";
            btnLibro_Modificar.Size = new Size(75, 23);
            btnLibro_Modificar.TabIndex = 2;
            btnLibro_Modificar.Text = "Modificar";
            btnLibro_Modificar.UseVisualStyleBackColor = true;
            // 
            // btnLibro_Salir
            // 
            btnLibro_Salir.Location = new Point(15, 121);
            btnLibro_Salir.Name = "btnLibro_Salir";
            btnLibro_Salir.Size = new Size(75, 23);
            btnLibro_Salir.TabIndex = 3;
            btnLibro_Salir.Text = "Salir";
            btnLibro_Salir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(446, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Imagen Del Libro";
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtLibro_PrecioVenta);
            Controls.Add(label7);
            Controls.Add(txtLibro_PrecioCompra);
            Controls.Add(label6);
            Controls.Add(txtLibro_Cantidad);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1Libro);
            Controls.Add(label4);
            Controls.Add(cbLibro_Categoria);
            Controls.Add(label3);
            Controls.Add(txtLibroAutor);
            Controls.Add(txtLibro_Autor);
            Controls.Add(txtLibro_Titulo);
            Controls.Add(label2);
            Controls.Add(txtLibro_Codigo);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmLibros";
            Text = "Libros";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtLibro_Codigo;
        private Label label2;
        private TextBox txtLibro_Titulo;
        private Label txtLibro_Autor;
        private TextBox txtLibroAutor;
        private Label label3;
        private ComboBox cbLibro_Categoria;
        private Label label4;
        private DateTimePicker dateTimePicker1Libro;
        private Label label5;
        private TextBox txtLibro_Cantidad;
        private Label label6;
        private TextBox txtLibro_PrecioCompra;
        private Label label7;
        private TextBox txtLibro_PrecioVenta;
        private GroupBox groupBox1;
        private Button btnLibro_Modificar;
        private Button btnLibro_Eliminar;
        private Button btnLibro_Guardar;
        private Button btnLibro_Salir;
        private GroupBox groupBox2;
    }
}
