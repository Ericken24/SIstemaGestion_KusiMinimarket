namespace SIstemaGestion_KusiMinimarket
{
    partial class Form1
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
            label1 = new Label();
            dgvTablaClientes = new DataGridView();
            Número_Orden = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Productos_Cantidad = new DataGridViewTextBoxColumn();
            Hora_Llegada = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtCliente = new TextBox();
            label3 = new Label();
            btnRegistrar = new Button();
            btnAtenderSiguiente = new Button();
            nudContadorProductos = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvTablaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudContadorProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, 21);
            label1.Name = "label1";
            label1.Size = new Size(389, 58);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestión de Ventas\r\nKusi Minimarket";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvTablaClientes
            // 
            dgvTablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaClientes.Columns.AddRange(new DataGridViewColumn[] { Número_Orden, Cliente, Productos_Cantidad, Hora_Llegada });
            dgvTablaClientes.Location = new Point(303, 222);
            dgvTablaClientes.Name = "dgvTablaClientes";
            dgvTablaClientes.RowHeadersWidth = 51;
            dgvTablaClientes.Size = new Size(554, 344);
            dgvTablaClientes.TabIndex = 1;
            dgvTablaClientes.CellContentClick += dgvTablaClientes_CellContentClick;
            // 
            // Número_Orden
            // 
            Número_Orden.HeaderText = "Número (Orden)";
            Número_Orden.MinimumWidth = 6;
            Número_Orden.Name = "Número_Orden";
            Número_Orden.ReadOnly = true;
            Número_Orden.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 125;
            // 
            // Productos_Cantidad
            // 
            Productos_Cantidad.HeaderText = "Productos";
            Productos_Cantidad.MinimumWidth = 6;
            Productos_Cantidad.Name = "Productos_Cantidad";
            Productos_Cantidad.ReadOnly = true;
            Productos_Cantidad.Width = 125;
            // 
            // Hora_Llegada
            // 
            Hora_Llegada.HeaderText = "Hora de llegada";
            Hora_Llegada.MinimumWidth = 6;
            Hora_Llegada.Name = "Hora_Llegada";
            Hora_Llegada.ReadOnly = true;
            Hora_Llegada.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 114);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre del cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(302, 137);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(234, 27);
            txtCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(643, 114);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 4;
            label3.Text = "Cantidad de productos:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ActiveCaption;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(348, 170);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(155, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "+ Agregar a la fila";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnAtenderSiguiente
            // 
            btnAtenderSiguiente.BackColor = Color.LimeGreen;
            btnAtenderSiguiente.Location = new Point(674, 170);
            btnAtenderSiguiente.Name = "btnAtenderSiguiente";
            btnAtenderSiguiente.Size = new Size(183, 29);
            btnAtenderSiguiente.TabIndex = 7;
            btnAtenderSiguiente.Text = "➡️ Antender Siguiente";
            btnAtenderSiguiente.UseVisualStyleBackColor = false;
            btnAtenderSiguiente.Click += btnAtenderSiguiente_Click;
            // 
            // nudContadorProductos
            // 
            nudContadorProductos.Location = new Point(643, 138);
            nudContadorProductos.Name = "nudContadorProductos";
            nudContadorProductos.Size = new Size(234, 27);
            nudContadorProductos.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 731);
            Controls.Add(nudContadorProductos);
            Controls.Add(btnAtenderSiguiente);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(txtCliente);
            Controls.Add(label2);
            Controls.Add(dgvTablaClientes);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudContadorProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTablaClientes;
        private DataGridViewTextBoxColumn Número_Orden;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Productos_Cantidad;
        private DataGridViewTextBoxColumn Hora_Llegada;
        private Label label2;
        private TextBox txtCliente;
        private Label label3;
        private Button btnRegistrar;
        private Button btnAtenderSiguiente;
        private NumericUpDown nudContadorProductos;
    }
}
