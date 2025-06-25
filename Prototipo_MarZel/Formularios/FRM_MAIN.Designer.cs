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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            MTBC_MENU = new MaterialSkin.Controls.MaterialTabControl();
            TP_INICIO = new TabPage();
            TP_PRODUCTOS = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            dgv_productos = new DataGridView();
            TP_FACTURACION = new TabPage();
            MTBC_MENU.SuspendLayout();
            TP_PRODUCTOS.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MTBC_MENU
            // 
            MTBC_MENU.Controls.Add(TP_INICIO);
            MTBC_MENU.Controls.Add(TP_PRODUCTOS);
            MTBC_MENU.Controls.Add(TP_FACTURACION);
            MTBC_MENU.Depth = 0;
            MTBC_MENU.Dock = DockStyle.Fill;
            MTBC_MENU.Location = new Point(3, 60);
            MTBC_MENU.Margin = new Padding(3, 2, 3, 2);
            MTBC_MENU.MouseState = MaterialSkin.MouseState.HOVER;
            MTBC_MENU.Multiline = true;
            MTBC_MENU.Name = "MTBC_MENU";
            MTBC_MENU.SelectedIndex = 0;
            MTBC_MENU.Size = new Size(694, 276);
            MTBC_MENU.TabIndex = 1;
            // 
            // TP_INICIO
            // 
            TP_INICIO.Location = new Point(4, 24);
            TP_INICIO.Margin = new Padding(3, 2, 3, 2);
            TP_INICIO.Name = "TP_INICIO";
            TP_INICIO.Padding = new Padding(3, 2, 3, 2);
            TP_INICIO.Size = new Size(686, 248);
            TP_INICIO.TabIndex = 0;
            TP_INICIO.Text = "Inicio";
            TP_INICIO.UseVisualStyleBackColor = true;
            TP_INICIO.Click += TP_INICIO_Click;
            // 
            // TP_PRODUCTOS
            // 
            TP_PRODUCTOS.Controls.Add(materialCard1);
            TP_PRODUCTOS.Location = new Point(4, 24);
            TP_PRODUCTOS.Margin = new Padding(3, 2, 3, 2);
            TP_PRODUCTOS.Name = "TP_PRODUCTOS";
            TP_PRODUCTOS.Padding = new Padding(3, 2, 3, 2);
            TP_PRODUCTOS.Size = new Size(687, 247);
            TP_PRODUCTOS.TabIndex = 2;
            TP_PRODUCTOS.Text = "Productos";
            TP_PRODUCTOS.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dgv_productos);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(9, 10);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(674, 230);
            materialCard1.TabIndex = 0;
            materialCard1.Paint += materialCard1_Paint;
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Location = new Point(322, 4);
            dgv_productos.Margin = new Padding(3, 2, 3, 2);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 51;
            dgv_productos.Size = new Size(337, 212);
            dgv_productos.TabIndex = 0;
            // 
            // TP_FACTURACION
            // 
            TP_FACTURACION.Location = new Point(4, 24);
            TP_FACTURACION.Margin = new Padding(3, 2, 3, 2);
            TP_FACTURACION.Name = "TP_FACTURACION";
            TP_FACTURACION.Padding = new Padding(3, 2, 3, 2);
            TP_FACTURACION.Size = new Size(687, 247);
            TP_FACTURACION.TabIndex = 1;
            TP_FACTURACION.Text = "Facturacion";
            TP_FACTURACION.UseVisualStyleBackColor = true;
            // 
            // FRM_MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(700, 338);
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
            TP_PRODUCTOS.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialTabControl MTBC_MENU;
        private TabPage TP_INICIO;
        private TabPage TP_FACTURACION;
        private TabPage TP_PRODUCTOS;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private DataGridView dgv_productos;
    }
}
