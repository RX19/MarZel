namespace Prototipo_MarZel
{
    partial class FRM_MAIN
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
            MTBC_MENU = new MaterialSkin.Controls.MaterialTabControl();
            TP_INICIO = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            LBL_CORREO = new MaterialSkin.Controls.MaterialLabel();
            LBL_APELLIDO = new MaterialSkin.Controls.MaterialLabel();
            LBL_NOMBRE = new MaterialSkin.Controls.MaterialLabel();
            LBL_CORREO_USU = new MaterialSkin.Controls.MaterialLabel();
            LBL_APELLIDO_USU = new MaterialSkin.Controls.MaterialLabel();
            LBL_NOMBRE_USU = new MaterialSkin.Controls.MaterialLabel();
            LBL_USUARIO = new MaterialSkin.Controls.MaterialLabel();
            LBL_USUARIO_USU = new MaterialSkin.Controls.MaterialLabel();
            PB_Foto = new PictureBox();
            TP_PRODUCTOS = new TabPage();
            TP_FACTURACION = new TabPage();
            TP_ADMIN = new TabPage();
            TP_PROVEEDORES = new TabPage();
            TP_COMPRAS = new TabPage();
            MTBC_MENU.SuspendLayout();
            TP_INICIO.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Foto).BeginInit();
            SuspendLayout();
            // 
            // MTBC_MENU
            // 
            MTBC_MENU.Controls.Add(TP_INICIO);
            MTBC_MENU.Controls.Add(TP_PRODUCTOS);
            MTBC_MENU.Controls.Add(TP_FACTURACION);
            MTBC_MENU.Controls.Add(TP_ADMIN);
            MTBC_MENU.Controls.Add(TP_PROVEEDORES);
            MTBC_MENU.Controls.Add(TP_COMPRAS);
            MTBC_MENU.Depth = 0;
            MTBC_MENU.Dock = DockStyle.Fill;
            MTBC_MENU.Location = new Point(3, 60);
            MTBC_MENU.Margin = new Padding(3, 2, 3, 2);
            MTBC_MENU.MouseState = MaterialSkin.MouseState.HOVER;
            MTBC_MENU.Multiline = true;
            MTBC_MENU.Name = "MTBC_MENU";
            MTBC_MENU.SelectedIndex = 0;
            MTBC_MENU.Size = new Size(1101, 504);
            MTBC_MENU.TabIndex = 1;
            MTBC_MENU.SelectedIndexChanged += MTBC_MENU_SelectedIndexChanged;
            // 
            // TP_INICIO
            // 
            TP_INICIO.BackColor = Color.WhiteSmoke;
            TP_INICIO.Controls.Add(materialCard1);
            TP_INICIO.ForeColor = SystemColors.Control;
            TP_INICIO.Location = new Point(4, 24);
            TP_INICIO.Margin = new Padding(3, 2, 3, 2);
            TP_INICIO.Name = "TP_INICIO";
            TP_INICIO.Padding = new Padding(3, 2, 3, 2);
            TP_INICIO.Size = new Size(1093, 476);
            TP_INICIO.TabIndex = 0;
            TP_INICIO.Text = "Inicio";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(LBL_CORREO);
            materialCard1.Controls.Add(LBL_APELLIDO);
            materialCard1.Controls.Add(LBL_NOMBRE);
            materialCard1.Controls.Add(LBL_CORREO_USU);
            materialCard1.Controls.Add(LBL_APELLIDO_USU);
            materialCard1.Controls.Add(LBL_NOMBRE_USU);
            materialCard1.Controls.Add(LBL_USUARIO);
            materialCard1.Controls.Add(LBL_USUARIO_USU);
            materialCard1.Controls.Add(PB_Foto);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(106, 56);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(720, 311);
            materialCard1.TabIndex = 0;
            // 
            // LBL_CORREO
            // 
            LBL_CORREO.AutoSize = true;
            LBL_CORREO.Depth = 0;
            LBL_CORREO.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CORREO.Location = new Point(500, 169);
            LBL_CORREO.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CORREO.Name = "LBL_CORREO";
            LBL_CORREO.Size = new Size(107, 19);
            LBL_CORREO.TabIndex = 8;
            LBL_CORREO.Text = "materialLabel1";
            // 
            // LBL_APELLIDO
            // 
            LBL_APELLIDO.AutoSize = true;
            LBL_APELLIDO.Depth = 0;
            LBL_APELLIDO.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_APELLIDO.Location = new Point(500, 140);
            LBL_APELLIDO.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_APELLIDO.Name = "LBL_APELLIDO";
            LBL_APELLIDO.Size = new Size(107, 19);
            LBL_APELLIDO.TabIndex = 7;
            LBL_APELLIDO.Text = "materialLabel1";
            // 
            // LBL_NOMBRE
            // 
            LBL_NOMBRE.AutoSize = true;
            LBL_NOMBRE.Depth = 0;
            LBL_NOMBRE.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_NOMBRE.Location = new Point(500, 108);
            LBL_NOMBRE.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_NOMBRE.Name = "LBL_NOMBRE";
            LBL_NOMBRE.Size = new Size(107, 19);
            LBL_NOMBRE.TabIndex = 6;
            LBL_NOMBRE.Text = "materialLabel1";
            // 
            // LBL_CORREO_USU
            // 
            LBL_CORREO_USU.AutoSize = true;
            LBL_CORREO_USU.Depth = 0;
            LBL_CORREO_USU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CORREO_USU.Location = new Point(429, 169);
            LBL_CORREO_USU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CORREO_USU.Name = "LBL_CORREO_USU";
            LBL_CORREO_USU.Size = new Size(51, 19);
            LBL_CORREO_USU.TabIndex = 5;
            LBL_CORREO_USU.Text = "Correo:";
            // 
            // LBL_APELLIDO_USU
            // 
            LBL_APELLIDO_USU.AutoSize = true;
            LBL_APELLIDO_USU.Depth = 0;
            LBL_APELLIDO_USU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_APELLIDO_USU.Location = new Point(429, 140);
            LBL_APELLIDO_USU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_APELLIDO_USU.Name = "LBL_APELLIDO_USU";
            LBL_APELLIDO_USU.Size = new Size(62, 19);
            LBL_APELLIDO_USU.TabIndex = 4;
            LBL_APELLIDO_USU.Text = "Apellido:";
            // 
            // LBL_NOMBRE_USU
            // 
            LBL_NOMBRE_USU.AutoSize = true;
            LBL_NOMBRE_USU.Depth = 0;
            LBL_NOMBRE_USU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_NOMBRE_USU.Location = new Point(429, 108);
            LBL_NOMBRE_USU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_NOMBRE_USU.Name = "LBL_NOMBRE_USU";
            LBL_NOMBRE_USU.Size = new Size(61, 19);
            LBL_NOMBRE_USU.TabIndex = 3;
            LBL_NOMBRE_USU.Text = "Nombre:";
            // 
            // LBL_USUARIO
            // 
            LBL_USUARIO.AutoSize = true;
            LBL_USUARIO.Depth = 0;
            LBL_USUARIO.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_USUARIO.Location = new Point(500, 61);
            LBL_USUARIO.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_USUARIO.Name = "LBL_USUARIO";
            LBL_USUARIO.Size = new Size(107, 19);
            LBL_USUARIO.TabIndex = 2;
            LBL_USUARIO.Text = "materialLabel1";
            // 
            // LBL_USUARIO_USU
            // 
            LBL_USUARIO_USU.AutoSize = true;
            LBL_USUARIO_USU.Depth = 0;
            LBL_USUARIO_USU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_USUARIO_USU.Location = new Point(429, 61);
            LBL_USUARIO_USU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_USUARIO_USU.Name = "LBL_USUARIO_USU";
            LBL_USUARIO_USU.Size = new Size(59, 19);
            LBL_USUARIO_USU.TabIndex = 1;
            LBL_USUARIO_USU.Text = "Usuario:";
            // 
            // PB_Foto
            // 
            PB_Foto.BackColor = Color.Black;
            PB_Foto.BackgroundImageLayout = ImageLayout.Zoom;
            PB_Foto.Image = Properties.Resources.Usuario;
            PB_Foto.Location = new Point(15, 13);
            PB_Foto.Margin = new Padding(3, 2, 3, 2);
            PB_Foto.Name = "PB_Foto";
            PB_Foto.Size = new Size(357, 274);
            PB_Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Foto.TabIndex = 0;
            PB_Foto.TabStop = false;
            // 
            // TP_PRODUCTOS
            // 
            TP_PRODUCTOS.BackColor = Color.WhiteSmoke;
            TP_PRODUCTOS.ForeColor = SystemColors.Control;
            TP_PRODUCTOS.Location = new Point(4, 24);
            TP_PRODUCTOS.Margin = new Padding(3, 2, 3, 2);
            TP_PRODUCTOS.Name = "TP_PRODUCTOS";
            TP_PRODUCTOS.Padding = new Padding(3, 2, 3, 2);
            TP_PRODUCTOS.Size = new Size(1093, 476);
            TP_PRODUCTOS.TabIndex = 2;
            TP_PRODUCTOS.Text = "Productos";
            // 
            // TP_FACTURACION
            // 
            TP_FACTURACION.BackColor = Color.WhiteSmoke;
            TP_FACTURACION.ForeColor = SystemColors.Control;
            TP_FACTURACION.Location = new Point(4, 24);
            TP_FACTURACION.Margin = new Padding(3, 2, 3, 2);
            TP_FACTURACION.Name = "TP_FACTURACION";
            TP_FACTURACION.Padding = new Padding(3, 2, 3, 2);
            TP_FACTURACION.Size = new Size(1093, 476);
            TP_FACTURACION.TabIndex = 1;
            TP_FACTURACION.Text = "Facturacion";
            // 
            // TP_ADMIN
            // 
            TP_ADMIN.Location = new Point(4, 24);
            TP_ADMIN.Margin = new Padding(3, 2, 3, 2);
            TP_ADMIN.Name = "TP_ADMIN";
            TP_ADMIN.Size = new Size(1093, 476);
            TP_ADMIN.TabIndex = 3;
            TP_ADMIN.Text = "Usuarios";
            TP_ADMIN.UseVisualStyleBackColor = true;
            // 
            // TP_PROVEEDORES
            // 
            TP_PROVEEDORES.Location = new Point(4, 24);
            TP_PROVEEDORES.Name = "TP_PROVEEDORES";
            TP_PROVEEDORES.Padding = new Padding(3);
            TP_PROVEEDORES.Size = new Size(1093, 476);
            TP_PROVEEDORES.TabIndex = 4;
            TP_PROVEEDORES.Text = "Proveedores";
            TP_PROVEEDORES.UseVisualStyleBackColor = true;
            // 
            // TP_COMPRAS
            // 
            TP_COMPRAS.Location = new Point(4, 24);
            TP_COMPRAS.Name = "TP_COMPRAS";
            TP_COMPRAS.Padding = new Padding(3);
            TP_COMPRAS.Size = new Size(1093, 476);
            TP_COMPRAS.TabIndex = 5;
            TP_COMPRAS.Text = "Compras";
            TP_COMPRAS.UseVisualStyleBackColor = true;
            // 
            // FRM_MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1107, 566);
            Controls.Add(MTBC_MENU);
            DrawerTabControl = MTBC_MENU;
            ForeColor = SystemColors.Desktop;
            FormStyle = FormStyles.ActionBar_56;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FRM_MAIN";
            Padding = new Padding(3, 60, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            TransparencyKey = SystemColors.ActiveCaptionText;
            Load += FRM_MAIN_Load;
            MTBC_MENU.ResumeLayout(false);
            TP_INICIO.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Foto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl MTBC_MENU;
        private TabPage TP_INICIO;
        private TabPage TP_FACTURACION;
        private TabPage TP_PRODUCTOS;
        private TabPage TP_ADMIN;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox PB_Foto;
        private MaterialSkin.Controls.MaterialLabel LBL_USUARIO;
        private MaterialSkin.Controls.MaterialLabel LBL_USUARIO_USU;
        private MaterialSkin.Controls.MaterialLabel LBL_NOMBRE_USU;
        private MaterialSkin.Controls.MaterialLabel LBL_NOMBRE;
        private MaterialSkin.Controls.MaterialLabel LBL_CORREO_USU;
        private MaterialSkin.Controls.MaterialLabel LBL_APELLIDO_USU;
        private MaterialSkin.Controls.MaterialLabel LBL_CORREO;
        private MaterialSkin.Controls.MaterialLabel LBL_APELLIDO;
        private TabPage TP_PROVEEDORES;
        private TabPage TP_COMPRAS;
    }
}
