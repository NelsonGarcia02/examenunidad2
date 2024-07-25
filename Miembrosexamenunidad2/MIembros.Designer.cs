namespace Miembrosexamenunidad2
{
    partial class FrmMiembros
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
            dataGridView1miembro = new DataGridView();
            label1 = new Label();
            txtMiembro_Codigo = new TextBox();
            label2 = new Label();
            txtMiembro_Nombre = new TextBox();
            label3 = new Label();
            txtMiembro_Direccion = new TextBox();
            label4 = new Label();
            txtMiembro_Telefono = new TextBox();
            label5 = new Label();
            dateTimePicker1Miembro = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnMiembro_Salir = new Button();
            btnMiembro_Modificar = new Button();
            btnMiembro_Eliminar = new Button();
            btnMiembro_Guardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1miembro).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1miembro
            // 
            dataGridView1miembro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1miembro.Location = new Point(12, 12);
            dataGridView1miembro.Name = "dataGridView1miembro";
            dataGridView1miembro.Size = new Size(776, 150);
            dataGridView1miembro.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 237);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo Del Miembro";
            // 
            // txtMiembro_Codigo
            // 
            txtMiembro_Codigo.Location = new Point(174, 229);
            txtMiembro_Codigo.Name = "txtMiembro_Codigo";
            txtMiembro_Codigo.Size = new Size(95, 23);
            txtMiembro_Codigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 273);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre Del MIembro";
            // 
            // txtMiembro_Nombre
            // 
            txtMiembro_Nombre.Location = new Point(174, 265);
            txtMiembro_Nombre.Name = "txtMiembro_Nombre";
            txtMiembro_Nombre.Size = new Size(95, 23);
            txtMiembro_Nombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 301);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 5;
            label3.Text = "Direccion Del Miembro";
            // 
            // txtMiembro_Direccion
            // 
            txtMiembro_Direccion.Location = new Point(174, 298);
            txtMiembro_Direccion.Name = "txtMiembro_Direccion";
            txtMiembro_Direccion.Size = new Size(95, 23);
            txtMiembro_Direccion.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 335);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 7;
            label4.Text = "Numero De Telefono ";
            // 
            // txtMiembro_Telefono
            // 
            txtMiembro_Telefono.Location = new Point(174, 327);
            txtMiembro_Telefono.Name = "txtMiembro_Telefono";
            txtMiembro_Telefono.Size = new Size(95, 23);
            txtMiembro_Telefono.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 365);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha De Inscripcion";
            // 
            // dateTimePicker1Miembro
            // 
            dateTimePicker1Miembro.Format = DateTimePickerFormat.Short;
            dateTimePicker1Miembro.Location = new Point(174, 359);
            dateTimePicker1Miembro.Name = "dateTimePicker1Miembro";
            dateTimePicker1Miembro.Size = new Size(95, 23);
            dateTimePicker1Miembro.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(344, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagen Del Miembro";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMiembro_Salir);
            groupBox2.Controls.Add(btnMiembro_Modificar);
            groupBox2.Controls.Add(btnMiembro_Eliminar);
            groupBox2.Controls.Add(btnMiembro_Guardar);
            groupBox2.Location = new Point(609, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(143, 164);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Accion a Ejecutar";
            // 
            // btnMiembro_Salir
            // 
            btnMiembro_Salir.Location = new Point(6, 115);
            btnMiembro_Salir.Name = "btnMiembro_Salir";
            btnMiembro_Salir.Size = new Size(75, 23);
            btnMiembro_Salir.TabIndex = 7;
            btnMiembro_Salir.Text = "Salir";
            btnMiembro_Salir.UseVisualStyleBackColor = true;
            // 
            // btnMiembro_Modificar
            // 
            btnMiembro_Modificar.Location = new Point(6, 86);
            btnMiembro_Modificar.Name = "btnMiembro_Modificar";
            btnMiembro_Modificar.Size = new Size(75, 23);
            btnMiembro_Modificar.TabIndex = 6;
            btnMiembro_Modificar.Text = "Modificar";
            btnMiembro_Modificar.UseVisualStyleBackColor = true;
            // 
            // btnMiembro_Eliminar
            // 
            btnMiembro_Eliminar.Location = new Point(6, 57);
            btnMiembro_Eliminar.Name = "btnMiembro_Eliminar";
            btnMiembro_Eliminar.Size = new Size(75, 23);
            btnMiembro_Eliminar.TabIndex = 5;
            btnMiembro_Eliminar.Text = "Eliminar";
            btnMiembro_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btnMiembro_Guardar
            // 
            btnMiembro_Guardar.Location = new Point(6, 22);
            btnMiembro_Guardar.Name = "btnMiembro_Guardar";
            btnMiembro_Guardar.Size = new Size(75, 23);
            btnMiembro_Guardar.TabIndex = 4;
            btnMiembro_Guardar.Text = "Guardar";
            btnMiembro_Guardar.UseVisualStyleBackColor = true;
            // 
            // FrmMiembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1Miembro);
            Controls.Add(label5);
            Controls.Add(txtMiembro_Telefono);
            Controls.Add(label4);
            Controls.Add(txtMiembro_Direccion);
            Controls.Add(label3);
            Controls.Add(txtMiembro_Nombre);
            Controls.Add(label2);
            Controls.Add(txtMiembro_Codigo);
            Controls.Add(label1);
            Controls.Add(dataGridView1miembro);
            Name = "FrmMiembros";
            Text = "Miembros";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1miembro).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1miembro;
        private Label label1;
        private TextBox txtMiembro_Codigo;
        private Label label2;
        private TextBox txtMiembro_Nombre;
        private Label label3;
        private TextBox txtMiembro_Direccion;
        private Label label4;
        private TextBox txtMiembro_Telefono;
        private Label label5;
        private DateTimePicker dateTimePicker1Miembro;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnMiembro_Salir;
        private Button btnMiembro_Modificar;
        private Button btnMiembro_Eliminar;
        private Button btnMiembro_Guardar;
    }
}
