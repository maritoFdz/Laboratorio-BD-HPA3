namespace EjemploSProyBD
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            imageList1 = new ImageList(components);
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            lblImagen = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBusqueda = new TextBox();
            lblBusqueda = new Label();
            dgvProductos = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-14, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 87);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.2956524F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(412, 57);
            label1.TabIndex = 9;
            label1.Text = "CRUD de Productos";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.Location = new Point(92, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 26);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.WhiteSmoke;
            lblNombre.Location = new Point(19, 126);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.WhiteSmoke;
            txtPrecio.Location = new Point(92, 169);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 26);
            txtPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.WhiteSmoke;
            lblPrecio.Location = new Point(34, 172);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.WhiteSmoke;
            txtCantidad.Location = new Point(92, 214);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(120, 26);
            txtCantidad.TabIndex = 8;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.WhiteSmoke;
            lblCantidad.Location = new Point(15, 217);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 20);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add.png");
            imageList1.Images.SetKeyName(1, "clean-code.png");
            imageList1.Images.SetKeyName(2, "delete.png");
            imageList1.Images.SetKeyName(3, "login.png");
            imageList1.Images.SetKeyName(4, "pencil.png");
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.ImageIndex = 0;
            btnAgregar.ImageList = imageList1;
            btnAgregar.Location = new Point(5, 536);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 42);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.ImageIndex = 4;
            btnModificar.ImageList = imageList1;
            btnModificar.Location = new Point(148, 536);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 42);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.ImageIndex = 2;
            btnEliminar.ImageList = imageList1;
            btnEliminar.Location = new Point(290, 536);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 42);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.WhiteSmoke;
            btnLimpiar.ImageIndex = 1;
            btnLimpiar.ImageList = imageList1;
            btnLimpiar.Location = new Point(434, 536);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 42);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.WhiteSmoke;
            btnSalir.ImageIndex = 3;
            btnSalir.ImageList = imageList1;
            btnSalir.Location = new Point(577, 536);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 42);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightCyan;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(529, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImagen.ForeColor = Color.WhiteSmoke;
            lblImagen.Location = new Point(457, 107);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(66, 20);
            lblImagen.TabIndex = 15;
            lblImagen.Text = "Imagen:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Violet;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtBusqueda);
            panel2.Controls.Add(lblBusqueda);
            panel2.Location = new Point(12, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 56);
            panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(637, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += txtBusqueda_TextChanged;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.WhiteSmoke;
            txtBusqueda.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(129, 12);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(497, 33);
            txtBusqueda.TabIndex = 16;
            txtBusqueda.Click += txtBusqueda_TextChanged;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusqueda.ForeColor = Color.WhiteSmoke;
            lblBusqueda.Location = new Point(21, 15);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(105, 25);
            lblBusqueda.TabIndex = 16;
            lblBusqueda.Text = "Búsqueda:";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(11, 333);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 49;
            dgvProductos.Size = new Size(686, 197);
            dgvProductos.TabIndex = 16;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(711, 590);
            Controls.Add(dgvProductos);
            Controls.Add(lblCantidad);
            Controls.Add(panel2);
            Controls.Add(lblImagen);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "CRUD Productos";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Label label1;
        private ImageList imageList1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Label lblImagen;
        private Panel panel2;
        private Label lblBusqueda;
        private TextBox txtBusqueda;
        private PictureBox pictureBox2;
        private DataGridView dgvProductos;
        private ErrorProvider errorProvider1;
    }
}
