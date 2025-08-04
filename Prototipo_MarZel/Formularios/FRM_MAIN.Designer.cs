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
            BTN_PRUEBA = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            LBL_CORREO = new MaterialSkin.Controls.MaterialLabel();
            LBL_NOMBRE = new MaterialSkin.Controls.MaterialLabel();
            LBL_CORREO_USU = new MaterialSkin.Controls.MaterialLabel();
            LBL_NOMBRE_USU = new MaterialSkin.Controls.MaterialLabel();
            LBL_USUARIO = new MaterialSkin.Controls.MaterialLabel();
            LBL_USUARIO_USU = new MaterialSkin.Controls.MaterialLabel();
            PB_Foto = new PictureBox();
            TP_PRODUCTOS = new TabPage();
            TP_ADMIN = new TabPage();
            TP_PROVEEDORES = new TabPage();
            TP_CLIENTES = new TabPage();
            TP_COMPRAS = new TabPage();
            TP_VENTAS = new TabPage();
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
            MTBC_MENU.Controls.Add(TP_ADMIN);
            MTBC_MENU.Controls.Add(TP_PROVEEDORES);
            MTBC_MENU.Controls.Add(TP_CLIENTES);
            MTBC_MENU.Controls.Add(TP_COMPRAS);
            MTBC_MENU.Controls.Add(TP_VENTAS);
            MTBC_MENU.Depth = 0;
            MTBC_MENU.Dock = DockStyle.Fill;
            MTBC_MENU.Location = new Point(3, 80);
            MTBC_MENU.Margin = new Padding(3, 2, 3, 2);
            MTBC_MENU.MouseState = MaterialSkin.MouseState.HOVER;
            MTBC_MENU.Multiline = true;
            MTBC_MENU.Name = "MTBC_MENU";
            MTBC_MENU.SelectedIndex = 0;
            MTBC_MENU.Size = new Size(1103, 548);
            MTBC_MENU.TabIndex = 1;
            MTBC_MENU.SelectedIndexChanged += MTBC_MENU_SelectedIndexChanged;
            // 
            // TP_INICIO
            // 
            TP_INICIO.BackColor = Color.WhiteSmoke;
            TP_INICIO.Controls.Add(BTN_PRUEBA);
            TP_INICIO.Controls.Add(materialCard1);
            TP_INICIO.ForeColor = SystemColors.Control;
            TP_INICIO.Location = new Point(4, 29);
            TP_INICIO.Margin = new Padding(3, 2, 3, 2);
            TP_INICIO.Name = "TP_INICIO";
            TP_INICIO.Padding = new Padding(3, 2, 3, 2);
            TP_INICIO.Size = new Size(1095, 515);
            TP_INICIO.TabIndex = 0;
            TP_INICIO.Text = "Inicio";
            TP_INICIO.Click += TP_INICIO_Click;
            // 
            // BTN_PRUEBA
            // 
            BTN_PRUEBA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_PRUEBA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_PRUEBA.Depth = 0;
            BTN_PRUEBA.HighEmphasis = true;
            BTN_PRUEBA.Icon = null;
            BTN_PRUEBA.Location = new Point(962, 104);
            BTN_PRUEBA.Margin = new Padding(5, 8, 5, 8);
            BTN_PRUEBA.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_PRUEBA.Name = "BTN_PRUEBA";
            BTN_PRUEBA.NoAccentTextColor = Color.Empty;
            BTN_PRUEBA.Size = new Size(137, 36);
            BTN_PRUEBA.TabIndex = 1;
            BTN_PRUEBA.Text = "pRUEBA CORREO";
            BTN_PRUEBA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_PRUEBA.UseAccentColor = false;
            BTN_PRUEBA.UseVisualStyleBackColor = true;
            BTN_PRUEBA.Click += BTN_PRUEBA_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(LBL_CORREO);
            materialCard1.Controls.Add(LBL_NOMBRE);
            materialCard1.Controls.Add(LBL_CORREO_USU);
            materialCard1.Controls.Add(LBL_NOMBRE_USU);
            materialCard1.Controls.Add(LBL_USUARIO);
            materialCard1.Controls.Add(LBL_USUARIO_USU);
            materialCard1.Controls.Add(PB_Foto);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(121, 74);
            materialCard1.Margin = new Padding(14, 14, 14, 14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 14, 14, 14);
            materialCard1.Size = new Size(823, 414);
            materialCard1.TabIndex = 0;
            // 
            // LBL_CORREO
            // 
            LBL_CORREO.AutoSize = true;
            LBL_CORREO.Depth = 0;
            LBL_CORREO.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CORREO.Location = new Point(571, 267);
            LBL_CORREO.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CORREO.Name = "LBL_CORREO";
            LBL_CORREO.Size = new Size(107, 19);
            LBL_CORREO.TabIndex = 8;
            LBL_CORREO.Text = "materialLabel1";
            // 
            // LBL_NOMBRE
            // 
            LBL_NOMBRE.AutoSize = true;
            LBL_NOMBRE.Depth = 0;
            LBL_NOMBRE.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_NOMBRE.Location = new Point(571, 181);
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
            LBL_CORREO_USU.Location = new Point(490, 267);
            LBL_CORREO_USU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CORREO_USU.Name = "LBL_CORREO_USU";
            LBL_CORREO_USU.Size = new Size(51, 19);
            LBL_CORREO_USU.TabIndex = 5;
            LBL_CORREO_USU.Text = "Correo:";
            // 
            // LBL_NOMBRE_USU
            // 
            LBL_NOMBRE_USU.AutoSize = true;
            LBL_NOMBRE_USU.Depth = 0;
            LBL_NOMBRE_USU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_NOMBRE_USU.Location = new Point(490, 181);
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
            LBL_USUARIO.Location = new Point(571, 82);
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
            LBL_USUARIO_USU.Location = new Point(490, 82);
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
            PB_Foto.Location = new Point(17, 18);
            PB_Foto.Margin = new Padding(3, 2, 3, 2);
            PB_Foto.Name = "PB_Foto";
            PB_Foto.Size = new Size(408, 366);
            PB_Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Foto.TabIndex = 0;
            PB_Foto.TabStop = false;
            // 
            // TP_PRODUCTOS
            // 
            TP_PRODUCTOS.BackColor = Color.WhiteSmoke;
            TP_PRODUCTOS.ForeColor = SystemColors.Control;
            TP_PRODUCTOS.Location = new Point(4, 29);
            TP_PRODUCTOS.Margin = new Padding(3, 2, 3, 2);
            TP_PRODUCTOS.Name = "TP_PRODUCTOS";
            TP_PRODUCTOS.Padding = new Padding(3, 2, 3, 2);
            TP_PRODUCTOS.Size = new Size(1094, 515);
            TP_PRODUCTOS.TabIndex = 2;
            TP_PRODUCTOS.Text = "Productos";
            // 
            // TP_ADMIN
            // 
            TP_ADMIN.Location = new Point(4, 29);
            TP_ADMIN.Margin = new Padding(3, 2, 3, 2);
            TP_ADMIN.Name = "TP_ADMIN";
            TP_ADMIN.Size = new Size(1094, 515);
            TP_ADMIN.TabIndex = 3;
            TP_ADMIN.Text = "Usuarios";
            TP_ADMIN.UseVisualStyleBackColor = true;
            // 
            // TP_PROVEEDORES
            // 
            TP_PROVEEDORES.Location = new Point(4, 29);
            TP_PROVEEDORES.Margin = new Padding(3, 4, 3, 4);
            TP_PROVEEDORES.Name = "TP_PROVEEDORES";
            TP_PROVEEDORES.Padding = new Padding(3, 4, 3, 4);
            TP_PROVEEDORES.Size = new Size(1094, 515);
            TP_PROVEEDORES.TabIndex = 4;
            TP_PROVEEDORES.Text = "Proveedores";
            TP_PROVEEDORES.UseVisualStyleBackColor = true;
            // 
            // TP_CLIENTES
            // 
            TP_CLIENTES.Location = new Point(4, 29);
            TP_CLIENTES.Margin = new Padding(2, 2, 2, 2);
            TP_CLIENTES.Name = "TP_CLIENTES";
            TP_CLIENTES.Padding = new Padding(2, 2, 2, 2);
            TP_CLIENTES.Size = new Size(1094, 515);
            TP_CLIENTES.TabIndex = 6;
            TP_CLIENTES.Text = "Clientes";
            TP_CLIENTES.UseVisualStyleBackColor = true;
            // 
            // TP_COMPRAS
            // 
            TP_COMPRAS.Location = new Point(4, 29);
            TP_COMPRAS.Margin = new Padding(3, 4, 3, 4);
            TP_COMPRAS.Name = "TP_COMPRAS";
            TP_COMPRAS.Padding = new Padding(3, 4, 3, 4);
            TP_COMPRAS.Size = new Size(1094, 515);
            TP_COMPRAS.TabIndex = 5;
            TP_COMPRAS.Text = "Compras";
            TP_COMPRAS.UseVisualStyleBackColor = true;
            // 
            // TP_VENTAS
            // 
            TP_VENTAS.Location = new Point(4, 29);
            TP_VENTAS.Margin = new Padding(3, 4, 3, 4);
            TP_VENTAS.Name = "TP_VENTAS";
            TP_VENTAS.Size = new Size(1094, 515);
            TP_VENTAS.TabIndex = 7;
            TP_VENTAS.Text = "Ventas";
            TP_VENTAS.UseVisualStyleBackColor = true;
            // 
            // FRM_MAIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1109, 630);
            Controls.Add(MTBC_MENU);
            DrawerTabControl = MTBC_MENU;
            ForeColor = SystemColors.Desktop;
            FormStyle = FormStyles.ActionBar_56;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FRM_MAIN";
            Padding = new Padding(3, 80, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            TransparencyKey = SystemColors.ActiveCaptionText;
            Load += FRM_MAIN_Load;
            MTBC_MENU.ResumeLayout(false);
            TP_INICIO.ResumeLayout(false);
            TP_INICIO.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Foto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl MTBC_MENU;
        private TabPage TP_INICIO;
        private TabPage TP_PRODUCTOS;
        private TabPage TP_ADMIN;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox PB_Foto;
        private MaterialSkin.Controls.MaterialLabel LBL_USUARIO;
        private MaterialSkin.Controls.MaterialLabel LBL_USUARIO_USU;
        private MaterialSkin.Controls.MaterialLabel LBL_NOMBRE_USU;
        private MaterialSkin.Controls.MaterialLabel LBL_NOMBRE;
        private MaterialSkin.Controls.MaterialLabel LBL_CORREO_USU;
        private MaterialSkin.Controls.MaterialLabel LBL_CORREO;
        private TabPage TP_PROVEEDORES;
        private TabPage TP_COMPRAS;
        private MaterialSkin.Controls.MaterialButton BTN_PRUEBA;
        private TabPage TP_CLIENTES;
        private TabPage TP_VENTAS;
    }
}
