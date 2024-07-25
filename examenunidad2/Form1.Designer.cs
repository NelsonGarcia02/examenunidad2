namespace ExamenUnidad2
{
    partial class frmLibros
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCodigoLibro = new TextBox();
            txtTituloLibro = new TextBox();
            txtAutorLibro = new TextBox();
            cmbCategoriaLibro = new ComboBox();
            dtpFechaPubliLibro = new DateTimePicker();
            txtCantidadLibro = new TextBox();
            txtCompraLibro = new TextBox();
            textBox6 = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo Del Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 62);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Titulo Del Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 116);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Autor Del Libro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 173);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 221);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha De Publicacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 281);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 339);
            label7.Name = "label7";
            label7.Size = new Size(152, 15);
            label7.TabIndex = 6;
            label7.Text = "Precio de Compra Del Libro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 386);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 7;
            label8.Text = "Precio Venta Del Libro";
            // 
            // txtCodigoLibro
            // 
            txtCodigoLibro.Location = new Point(207, 12);
            txtCodigoLibro.Name = "txtCodigoLibro";
            txtCodigoLibro.Size = new Size(100, 23);
            txtCodigoLibro.TabIndex = 8;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(207, 54);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(100, 23);
            txtTituloLibro.TabIndex = 9;
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.Location = new Point(207, 108);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.Size = new Size(100, 23);
            txtAutorLibro.TabIndex = 10;
            // 
            // cmbCategoriaLibro
            // 
            cmbCategoriaLibro.FormattingEnabled = true;
            cmbCategoriaLibro.Location = new Point(207, 165);
            cmbCategoriaLibro.Name = "cmbCategoriaLibro";
            cmbCategoriaLibro.Size = new Size(100, 23);
            cmbCategoriaLibro.TabIndex = 11;
            // 
            // dtpFechaPubliLibro
            // 
            dtpFechaPubliLibro.Format = DateTimePickerFormat.Short;
            dtpFechaPubliLibro.Location = new Point(207, 213);
            dtpFechaPubliLibro.Name = "dtpFechaPubliLibro";
            dtpFechaPubliLibro.Size = new Size(100, 23);
            dtpFechaPubliLibro.TabIndex = 12;
            // 
            // txtCantidadLibro
            // 
            txtCantidadLibro.Location = new Point(207, 273);
            txtCantidadLibro.Name = "txtCantidadLibro";
            txtCantidadLibro.Size = new Size(100, 23);
            txtCantidadLibro.TabIndex = 13;
            // 
            // txtCompraLibro
            // 
            txtCompraLibro.Location = new Point(207, 331);
            txtCompraLibro.Name = "txtCompraLibro";
            txtCompraLibro.Size = new Size(100, 23);
            txtCompraLibro.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(207, 378);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(331, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            button3.Location = new Point(108, 44);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(13, 65);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(13, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(457, 150);
            dataGridView1.TabIndex = 17;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(textBox6);
            Controls.Add(txtCompraLibro);
            Controls.Add(txtCantidadLibro);
            Controls.Add(dtpFechaPubliLibro);
            Controls.Add(cmbCategoriaLibro);
            Controls.Add(txtAutorLibro);
            Controls.Add(txtTituloLibro);
            Controls.Add(txtCodigoLibro);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLibros";
            Text = "Libros";
            Load += frmLibros_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCodigoLibro;
        private TextBox txtTituloLibro;
        private TextBox txtAutorLibro;
        private ComboBox cmbCategoriaLibro;
        private DateTimePicker dtpFechaPubliLibro;
        private TextBox txtCantidadLibro;
        private TextBox txtCompraLibro;
        private TextBox textBox6;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private ImageList imageList1;
        private ImageList imageList2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
