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
            MTBC_MENU.Location = new Point(3, 80);
            MTBC_MENU.MouseState = MaterialSkin.MouseState.HOVER;
            MTBC_MENU.Multiline = true;
            MTBC_MENU.Name = "MTBC_MENU";
            MTBC_MENU.SelectedIndex = 0;
            MTBC_MENU.Size = new Size(794, 367);
            MTBC_MENU.TabIndex = 1;
            // 
            // TP_INICIO
            // 
            TP_INICIO.Location = new Point(4, 29);
            TP_INICIO.Name = "TP_INICIO";
            TP_INICIO.Padding = new Padding(3);
            TP_INICIO.Size = new Size(786, 334);
            TP_INICIO.TabIndex = 0;
            TP_INICIO.Text = "Inicio";
            TP_INICIO.UseVisualStyleBackColor = true;
            // 
            // TP_PRODUCTOS
            // 
            TP_PRODUCTOS.Controls.Add(materialCard1);
            TP_PRODUCTOS.Location = new Point(4, 29);
            TP_PRODUCTOS.Name = "TP_PRODUCTOS";
            TP_PRODUCTOS.Padding = new Padding(3);
            TP_PRODUCTOS.Size = new Size(786, 334);
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
            materialCard1.Location = new Point(10, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(770, 306);
            materialCard1.TabIndex = 0;
            materialCard1.Paint += materialCard1_Paint;
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Location = new Point(368, 6);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 51;
            dgv_productos.Size = new Size(385, 283);
            dgv_productos.TabIndex = 0;
            // 
            // TP_FACTURACION
            // 
            TP_FACTURACION.Location = new Point(4, 29);
            TP_FACTURACION.Name = "TP_FACTURACION";
            TP_FACTURACION.Padding = new Padding(3);
            TP_FACTURACION.Size = new Size(786, 334);
            TP_FACTURACION.TabIndex = 1;
            TP_FACTURACION.Text = "Facturacion";
            TP_FACTURACION.UseVisualStyleBackColor = true;
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
