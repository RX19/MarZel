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
            TP_PRODUCTOS = new TabPage();
            TP_FACTURACION = new TabPage();
            TP_ADMIN = new TabPage();
            MTBC_MENU.SuspendLayout();
            SuspendLayout();
            // 
            // MTBC_MENU
            // 
            MTBC_MENU.Controls.Add(TP_INICIO);
            MTBC_MENU.Controls.Add(TP_PRODUCTOS);
            MTBC_MENU.Controls.Add(TP_FACTURACION);
            MTBC_MENU.Controls.Add(TP_ADMIN);
            MTBC_MENU.Depth = 0;
            MTBC_MENU.Dock = DockStyle.Fill;
            MTBC_MENU.Location = new Point(3, 80);
            MTBC_MENU.MouseState = MaterialSkin.MouseState.HOVER;
            MTBC_MENU.Multiline = true;
            MTBC_MENU.Name = "MTBC_MENU";
            MTBC_MENU.SelectedIndex = 0;
            MTBC_MENU.Size = new Size(794, 367);
            MTBC_MENU.TabIndex = 1;
            MTBC_MENU.SelectedIndexChanged += MTBC_MENU_SelectedIndexChanged;
            // 
            // TP_INICIO
            // 
            TP_INICIO.BackColor = Color.WhiteSmoke;
            TP_INICIO.ForeColor = SystemColors.Control;
            TP_INICIO.Location = new Point(4, 29);
            TP_INICIO.Name = "TP_INICIO";
            TP_INICIO.Padding = new Padding(3);
            TP_INICIO.Size = new Size(786, 334);
            TP_INICIO.TabIndex = 0;
            TP_INICIO.Text = "Inicio";
            // 
            // TP_PRODUCTOS
            // 
            TP_PRODUCTOS.BackColor = Color.WhiteSmoke;
            TP_PRODUCTOS.ForeColor = SystemColors.Control;
            TP_PRODUCTOS.Location = new Point(4, 29);
            TP_PRODUCTOS.Name = "TP_PRODUCTOS";
            TP_PRODUCTOS.Padding = new Padding(3);
            TP_PRODUCTOS.Size = new Size(786, 334);
            TP_PRODUCTOS.TabIndex = 2;
            TP_PRODUCTOS.Text = "Productos";
            // 
            // TP_FACTURACION
            // 
            TP_FACTURACION.BackColor = Color.WhiteSmoke;
            TP_FACTURACION.ForeColor = SystemColors.Control;
            TP_FACTURACION.Location = new Point(4, 29);
            TP_FACTURACION.Name = "TP_FACTURACION";
            TP_FACTURACION.Padding = new Padding(3);
            TP_FACTURACION.Size = new Size(786, 334);
            TP_FACTURACION.TabIndex = 1;
            TP_FACTURACION.Text = "Facturacion";
            // 
            // TP_ADMIN
            // 
            TP_ADMIN.Location = new Point(4, 29);
            TP_ADMIN.Name = "TP_ADMIN";
            TP_ADMIN.Size = new Size(786, 334);
            TP_ADMIN.TabIndex = 3;
            TP_ADMIN.Text = "Usuarios";
            TP_ADMIN.UseVisualStyleBackColor = true;
            // 
            // FRM_MAIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(MTBC_MENU);
            DrawerTabControl = MTBC_MENU;
            ForeColor = SystemColors.Desktop;
            FormStyle = FormStyles.ActionBar_56;
            Name = "FRM_MAIN";
            Padding = new Padding(3, 80, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            TransparencyKey = SystemColors.ActiveCaptionText;
            Load += FRM_MAIN_Load;
            MTBC_MENU.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl MTBC_MENU;
        private TabPage TP_INICIO;
        private TabPage TP_FACTURACION;
        private TabPage TP_PRODUCTOS;
        private TabPage TP_ADMIN;
    }
}
