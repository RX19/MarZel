namespace Prototipo_MarZel
{
    partial class FRM_PRODUCTOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_productos = new DataGridView();
            MTC_Conetnido = new MaterialSkin.Controls.MaterialCard();
            CBX_CATEGORIA = new MaterialSkin.Controls.MaterialComboBox();
            LBL_Categoria = new MaterialSkin.Controls.MaterialLabel();
            LBL_PC = new MaterialSkin.Controls.MaterialLabel();
            LBL_PU = new MaterialSkin.Controls.MaterialLabel();
            LBL_CANTIDAD = new MaterialSkin.Controls.MaterialLabel();
            LVL_ISV = new MaterialSkin.Controls.MaterialLabel();
            LBL_DESCRIPCION = new MaterialSkin.Controls.MaterialLabel();
            LBL_CODIGO_BARRA = new MaterialSkin.Controls.MaterialLabel();
            TXT_PC = new MaterialSkin.Controls.MaterialTextBox();
            TXT_PU = new MaterialSkin.Controls.MaterialTextBox();
            TXT_CANTIDAD = new MaterialSkin.Controls.MaterialTextBox();
            TXT_ISV = new MaterialSkin.Controls.MaterialTextBox();
            TXT_DESC = new MaterialSkin.Controls.MaterialTextBox();
            TXT_CODIGO_BARRA = new MaterialSkin.Controls.MaterialTextBox();
            BTN_Limpiar = new MaterialSkin.Controls.MaterialButton();
            BTN_AGREGAR = new MaterialSkin.Controls.MaterialButton();
            BTN_MODIFICAR = new MaterialSkin.Controls.MaterialButton();
            MTB_PRODUCTO = new MaterialSkin.Controls.MaterialTabControl();
            TBP_VISTA = new TabPage();
            TBP_INGRESAR = new TabPage();
            TBP_MODIFICAR = new TabPage();
            MTBS_DETALLE = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            MTC_Conetnido.SuspendLayout();
            MTB_PRODUCTO.SuspendLayout();
            TBP_VISTA.SuspendLayout();
            TBP_INGRESAR.SuspendLayout();
            TBP_MODIFICAR.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_productos
            // 
            dgv_productos.BackgroundColor = SystemColors.Control;
            dgv_productos.BorderStyle = BorderStyle.Fixed3D;
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Dock = DockStyle.Left;
            dgv_productos.Location = new Point(3, 64);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 51;
            dgv_productos.Size = new Size(725, 781);
            dgv_productos.TabIndex = 0;
            dgv_productos.CellClick += dgv_productos_CellClick;
            // 
            // MTC_Conetnido
            // 
            MTC_Conetnido.BackColor = Color.FromArgb(255, 255, 255);
            MTC_Conetnido.BorderStyle = BorderStyle.Fixed3D;
            MTC_Conetnido.Controls.Add(CBX_CATEGORIA);
            MTC_Conetnido.Controls.Add(LBL_Categoria);
            MTC_Conetnido.Controls.Add(LBL_PC);
            MTC_Conetnido.Controls.Add(LBL_PU);
            MTC_Conetnido.Controls.Add(LBL_CANTIDAD);
            MTC_Conetnido.Controls.Add(LVL_ISV);
            MTC_Conetnido.Controls.Add(LBL_DESCRIPCION);
            MTC_Conetnido.Controls.Add(LBL_CODIGO_BARRA);
            MTC_Conetnido.Controls.Add(TXT_PC);
            MTC_Conetnido.Controls.Add(TXT_PU);
            MTC_Conetnido.Controls.Add(TXT_CANTIDAD);
            MTC_Conetnido.Controls.Add(TXT_ISV);
            MTC_Conetnido.Controls.Add(TXT_DESC);
            MTC_Conetnido.Controls.Add(TXT_CODIGO_BARRA);
            MTC_Conetnido.Depth = 0;
            MTC_Conetnido.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MTC_Conetnido.Location = new Point(74, 13);
            MTC_Conetnido.Margin = new Padding(14, 13, 14, 13);
            MTC_Conetnido.MouseState = MaterialSkin.MouseState.HOVER;
            MTC_Conetnido.Name = "MTC_Conetnido";
            MTC_Conetnido.Padding = new Padding(14, 13, 14, 13);
            MTC_Conetnido.Size = new Size(540, 535);
            MTC_Conetnido.TabIndex = 1;
            // 
            // CBX_CATEGORIA
            // 
            CBX_CATEGORIA.AutoResize = false;
            CBX_CATEGORIA.BackColor = Color.FromArgb(255, 255, 255);
            CBX_CATEGORIA.Depth = 0;
            CBX_CATEGORIA.DrawMode = DrawMode.OwnerDrawVariable;
            CBX_CATEGORIA.DropDownHeight = 174;
            CBX_CATEGORIA.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_CATEGORIA.DropDownWidth = 121;
            CBX_CATEGORIA.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBX_CATEGORIA.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBX_CATEGORIA.FormattingEnabled = true;
            CBX_CATEGORIA.IntegralHeight = false;
            CBX_CATEGORIA.ItemHeight = 43;
            CBX_CATEGORIA.Location = new Point(351, 163);
            CBX_CATEGORIA.Margin = new Padding(3, 4, 3, 4);
            CBX_CATEGORIA.MaxDropDownItems = 4;
            CBX_CATEGORIA.MouseState = MaterialSkin.MouseState.OUT;
            CBX_CATEGORIA.Name = "CBX_CATEGORIA";
            CBX_CATEGORIA.Size = new Size(151, 49);
            CBX_CATEGORIA.StartIndex = 0;
            CBX_CATEGORIA.TabIndex = 13;
            // 
            // LBL_Categoria
            // 
            LBL_Categoria.AutoSize = true;
            LBL_Categoria.Depth = 0;
            LBL_Categoria.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_Categoria.Location = new Point(351, 121);
            LBL_Categoria.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_Categoria.Name = "LBL_Categoria";
            LBL_Categoria.Size = new Size(69, 19);
            LBL_Categoria.TabIndex = 12;
            LBL_Categoria.Text = "Categoria";
            // 
            // LBL_PC
            // 
            LBL_PC.AutoSize = true;
            LBL_PC.Depth = 0;
            LBL_PC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_PC.Location = new Point(351, 447);
            LBL_PC.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_PC.Name = "LBL_PC";
            LBL_PC.Size = new Size(21, 19);
            LBL_PC.TabIndex = 11;
            LBL_PC.Text = "PC";
            // 
            // LBL_PU
            // 
            LBL_PU.AutoSize = true;
            LBL_PU.Depth = 0;
            LBL_PU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_PU.Location = new Point(91, 449);
            LBL_PU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_PU.Name = "LBL_PU";
            LBL_PU.Size = new Size(21, 19);
            LBL_PU.TabIndex = 10;
            LBL_PU.Text = "PU";
            // 
            // LBL_CANTIDAD
            // 
            LBL_CANTIDAD.AutoSize = true;
            LBL_CANTIDAD.Depth = 0;
            LBL_CANTIDAD.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CANTIDAD.Location = new Point(27, 293);
            LBL_CANTIDAD.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CANTIDAD.Name = "LBL_CANTIDAD";
            LBL_CANTIDAD.Size = new Size(65, 19);
            LBL_CANTIDAD.TabIndex = 9;
            LBL_CANTIDAD.Text = "Cantidad";
            // 
            // LVL_ISV
            // 
            LVL_ISV.AutoSize = true;
            LVL_ISV.Depth = 0;
            LVL_ISV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LVL_ISV.Location = new Point(27, 203);
            LVL_ISV.MouseState = MaterialSkin.MouseState.HOVER;
            LVL_ISV.Name = "LVL_ISV";
            LVL_ISV.Size = new Size(25, 19);
            LVL_ISV.TabIndex = 8;
            LVL_ISV.Text = "ISV";
            // 
            // LBL_DESCRIPCION
            // 
            LBL_DESCRIPCION.AutoSize = true;
            LBL_DESCRIPCION.Depth = 0;
            LBL_DESCRIPCION.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_DESCRIPCION.Location = new Point(27, 121);
            LBL_DESCRIPCION.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_DESCRIPCION.Name = "LBL_DESCRIPCION";
            LBL_DESCRIPCION.Size = new Size(84, 19);
            LBL_DESCRIPCION.TabIndex = 7;
            LBL_DESCRIPCION.Text = "Descripcion";
            // 
            // LBL_CODIGO_BARRA
            // 
            LBL_CODIGO_BARRA.AutoSize = true;
            LBL_CODIGO_BARRA.Depth = 0;
            LBL_CODIGO_BARRA.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CODIGO_BARRA.Location = new Point(223, 33);
            LBL_CODIGO_BARRA.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CODIGO_BARRA.Name = "LBL_CODIGO_BARRA";
            LBL_CODIGO_BARRA.Size = new Size(114, 19);
            LBL_CODIGO_BARRA.TabIndex = 6;
            LBL_CODIGO_BARRA.Text = "Codigo de Barra";
            // 
            // TXT_PC
            // 
            TXT_PC.AnimateReadOnly = false;
            TXT_PC.BorderStyle = BorderStyle.None;
            TXT_PC.Depth = 0;
            TXT_PC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PC.LeadingIcon = null;
            TXT_PC.Location = new Point(378, 447);
            TXT_PC.MaxLength = 50;
            TXT_PC.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PC.Multiline = false;
            TXT_PC.Name = "TXT_PC";
            TXT_PC.ReadOnly = true;
            TXT_PC.Size = new Size(125, 50);
            TXT_PC.TabIndex = 5;
            TXT_PC.Text = "";
            TXT_PC.TrailingIcon = null;
            // 
            // TXT_PU
            // 
            TXT_PU.AnimateReadOnly = false;
            TXT_PU.BorderStyle = BorderStyle.None;
            TXT_PU.Depth = 0;
            TXT_PU.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PU.LeadingIcon = null;
            TXT_PU.Location = new Point(121, 447);
            TXT_PU.MaxLength = 50;
            TXT_PU.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PU.Multiline = false;
            TXT_PU.Name = "TXT_PU";
            TXT_PU.ReadOnly = true;
            TXT_PU.Size = new Size(125, 50);
            TXT_PU.TabIndex = 4;
            TXT_PU.Text = "";
            TXT_PU.TrailingIcon = null;
            // 
            // TXT_CANTIDAD
            // 
            TXT_CANTIDAD.AnimateReadOnly = false;
            TXT_CANTIDAD.BorderStyle = BorderStyle.None;
            TXT_CANTIDAD.Depth = 0;
            TXT_CANTIDAD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_CANTIDAD.LeadingIcon = null;
            TXT_CANTIDAD.Location = new Point(141, 291);
            TXT_CANTIDAD.MaxLength = 50;
            TXT_CANTIDAD.MouseState = MaterialSkin.MouseState.OUT;
            TXT_CANTIDAD.Multiline = false;
            TXT_CANTIDAD.Name = "TXT_CANTIDAD";
            TXT_CANTIDAD.ReadOnly = true;
            TXT_CANTIDAD.Size = new Size(186, 50);
            TXT_CANTIDAD.TabIndex = 3;
            TXT_CANTIDAD.Text = "";
            TXT_CANTIDAD.TrailingIcon = null;
            // 
            // TXT_ISV
            // 
            TXT_ISV.AnimateReadOnly = false;
            TXT_ISV.BorderStyle = BorderStyle.None;
            TXT_ISV.Depth = 0;
            TXT_ISV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_ISV.LeadingIcon = null;
            TXT_ISV.Location = new Point(141, 203);
            TXT_ISV.MaxLength = 50;
            TXT_ISV.MouseState = MaterialSkin.MouseState.OUT;
            TXT_ISV.Multiline = false;
            TXT_ISV.Name = "TXT_ISV";
            TXT_ISV.ReadOnly = true;
            TXT_ISV.Size = new Size(186, 50);
            TXT_ISV.TabIndex = 2;
            TXT_ISV.Text = "";
            TXT_ISV.TrailingIcon = null;
            // 
            // TXT_DESC
            // 
            TXT_DESC.AnimateReadOnly = false;
            TXT_DESC.BorderStyle = BorderStyle.None;
            TXT_DESC.Depth = 0;
            TXT_DESC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_DESC.LeadingIcon = null;
            TXT_DESC.Location = new Point(141, 121);
            TXT_DESC.MaxLength = 50;
            TXT_DESC.MouseState = MaterialSkin.MouseState.OUT;
            TXT_DESC.Multiline = false;
            TXT_DESC.Name = "TXT_DESC";
            TXT_DESC.ReadOnly = true;
            TXT_DESC.Size = new Size(186, 50);
            TXT_DESC.TabIndex = 1;
            TXT_DESC.Text = "";
            TXT_DESC.TrailingIcon = null;
            // 
            // TXT_CODIGO_BARRA
            // 
            TXT_CODIGO_BARRA.AnimateReadOnly = false;
            TXT_CODIGO_BARRA.BorderStyle = BorderStyle.None;
            TXT_CODIGO_BARRA.Depth = 0;
            TXT_CODIGO_BARRA.DetectUrls = false;
            TXT_CODIGO_BARRA.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_CODIGO_BARRA.LeadingIcon = null;
            TXT_CODIGO_BARRA.Location = new Point(351, 17);
            TXT_CODIGO_BARRA.MaxLength = 50;
            TXT_CODIGO_BARRA.MouseState = MaterialSkin.MouseState.OUT;
            TXT_CODIGO_BARRA.Multiline = false;
            TXT_CODIGO_BARRA.Name = "TXT_CODIGO_BARRA";
            TXT_CODIGO_BARRA.ReadOnly = true;
            TXT_CODIGO_BARRA.Size = new Size(152, 50);
            TXT_CODIGO_BARRA.TabIndex = 0;
            TXT_CODIGO_BARRA.Text = "";
            TXT_CODIGO_BARRA.TrailingIcon = null;
            // 
            // BTN_Limpiar
            // 
            BTN_Limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_Limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_Limpiar.Depth = 0;
            BTN_Limpiar.HighEmphasis = true;
            BTN_Limpiar.Icon = null;
            BTN_Limpiar.Location = new Point(280, 622);
            BTN_Limpiar.Margin = new Padding(5, 8, 5, 8);
            BTN_Limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_Limpiar.Name = "BTN_Limpiar";
            BTN_Limpiar.NoAccentTextColor = Color.Empty;
            BTN_Limpiar.Size = new Size(79, 36);
            BTN_Limpiar.TabIndex = 2;
            BTN_Limpiar.Text = "Limpiar";
            BTN_Limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_Limpiar.UseAccentColor = false;
            BTN_Limpiar.UseVisualStyleBackColor = true;
            BTN_Limpiar.Click += BTN_Limpiar_Click;
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_AGREGAR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_AGREGAR.Depth = 0;
            BTN_AGREGAR.HighEmphasis = true;
            BTN_AGREGAR.Icon = null;
            BTN_AGREGAR.Location = new Point(309, 633);
            BTN_AGREGAR.Margin = new Padding(5, 8, 5, 8);
            BTN_AGREGAR.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.NoAccentTextColor = Color.Empty;
            BTN_AGREGAR.Size = new Size(88, 36);
            BTN_AGREGAR.TabIndex = 3;
            BTN_AGREGAR.Text = "Agregar";
            BTN_AGREGAR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_AGREGAR.UseAccentColor = false;
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            // 
            // BTN_MODIFICAR
            // 
            BTN_MODIFICAR.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_MODIFICAR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_MODIFICAR.Depth = 0;
            BTN_MODIFICAR.HighEmphasis = true;
            BTN_MODIFICAR.Icon = null;
            BTN_MODIFICAR.Location = new Point(304, 594);
            BTN_MODIFICAR.Margin = new Padding(5, 8, 5, 8);
            BTN_MODIFICAR.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_MODIFICAR.Name = "BTN_MODIFICAR";
            BTN_MODIFICAR.NoAccentTextColor = Color.Empty;
            BTN_MODIFICAR.Size = new Size(99, 36);
            BTN_MODIFICAR.TabIndex = 4;
            BTN_MODIFICAR.Text = "MODIFICAR";
            BTN_MODIFICAR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_MODIFICAR.UseAccentColor = false;
            BTN_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // MTB_PRODUCTO
            // 
            MTB_PRODUCTO.Controls.Add(TBP_VISTA);
            MTB_PRODUCTO.Controls.Add(TBP_INGRESAR);
            MTB_PRODUCTO.Controls.Add(TBP_MODIFICAR);
            MTB_PRODUCTO.Depth = 0;
            MTB_PRODUCTO.Dock = DockStyle.Right;
            MTB_PRODUCTO.Location = new Point(832, 64);
            MTB_PRODUCTO.MouseState = MaterialSkin.MouseState.HOVER;
            MTB_PRODUCTO.Multiline = true;
            MTB_PRODUCTO.Name = "MTB_PRODUCTO";
            MTB_PRODUCTO.SelectedIndex = 0;
            MTB_PRODUCTO.Size = new Size(670, 781);
            MTB_PRODUCTO.TabIndex = 5;
            // 
            // TBP_VISTA
            // 
            TBP_VISTA.Controls.Add(BTN_Limpiar);
            TBP_VISTA.Location = new Point(4, 29);
            TBP_VISTA.Name = "TBP_VISTA";
            TBP_VISTA.Padding = new Padding(3);
            TBP_VISTA.Size = new Size(662, 748);
            TBP_VISTA.TabIndex = 0;
            TBP_VISTA.Text = "DETALLE";
            TBP_VISTA.UseVisualStyleBackColor = true;
            // 
            // TBP_INGRESAR
            // 
            TBP_INGRESAR.Controls.Add(BTN_AGREGAR);
            TBP_INGRESAR.Location = new Point(4, 29);
            TBP_INGRESAR.Name = "TBP_INGRESAR";
            TBP_INGRESAR.Padding = new Padding(3);
            TBP_INGRESAR.Size = new Size(662, 748);
            TBP_INGRESAR.TabIndex = 1;
            TBP_INGRESAR.Text = "INGRESAR";
            TBP_INGRESAR.UseVisualStyleBackColor = true;
            // 
            // TBP_MODIFICAR
            // 
            TBP_MODIFICAR.Controls.Add(MTC_Conetnido);
            TBP_MODIFICAR.Controls.Add(BTN_MODIFICAR);
            TBP_MODIFICAR.Location = new Point(4, 29);
            TBP_MODIFICAR.Name = "TBP_MODIFICAR";
            TBP_MODIFICAR.Size = new Size(662, 748);
            TBP_MODIFICAR.TabIndex = 2;
            TBP_MODIFICAR.Text = "MODIFICAR";
            TBP_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // MTBS_DETALLE
            // 
            MTBS_DETALLE.BaseTabControl = MTB_PRODUCTO;
            MTBS_DETALLE.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            MTBS_DETALLE.Depth = 0;
            MTBS_DETALLE.Dock = DockStyle.Fill;
            MTBS_DETALLE.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            MTBS_DETALLE.Location = new Point(728, 64);
            MTBS_DETALLE.MouseState = MaterialSkin.MouseState.HOVER;
            MTBS_DETALLE.Name = "MTBS_DETALLE";
            MTBS_DETALLE.Size = new Size(104, 781);
            MTBS_DETALLE.TabIndex = 3;
            MTBS_DETALLE.Text = "materialTabSelector1";
            // 
            // FRM_PRODUCTOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 848);
            Controls.Add(MTBS_DETALLE);
            Controls.Add(MTB_PRODUCTO);
            Controls.Add(dgv_productos);
            Name = "FRM_PRODUCTOS";
            Text = "Menu Productos";
            Load += FRM_PRODUCTOS_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            MTC_Conetnido.ResumeLayout(false);
            MTC_Conetnido.PerformLayout();
            MTB_PRODUCTO.ResumeLayout(false);
            TBP_VISTA.ResumeLayout(false);
            TBP_VISTA.PerformLayout();
            TBP_INGRESAR.ResumeLayout(false);
            TBP_INGRESAR.PerformLayout();
            TBP_MODIFICAR.ResumeLayout(false);
            TBP_MODIFICAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_productos;
        private MaterialSkin.Controls.MaterialCard MTC_Conetnido;
        private MaterialSkin.Controls.MaterialTextBox TXT_CODIGO_BARRA;
        private MaterialSkin.Controls.MaterialTextBox TXT_ISV;
        private MaterialSkin.Controls.MaterialTextBox TXT_DESC;
        private MaterialSkin.Controls.MaterialTextBox TXT_CANTIDAD;
        private MaterialSkin.Controls.MaterialLabel LBL_CODIGO_BARRA;
        private MaterialSkin.Controls.MaterialTextBox TXT_PC;
        private MaterialSkin.Controls.MaterialTextBox TXT_PU;
        private MaterialSkin.Controls.MaterialLabel LBL_DESCRIPCION;
        private MaterialSkin.Controls.MaterialLabel LBL_PU;
        private MaterialSkin.Controls.MaterialLabel LBL_CANTIDAD;
        private MaterialSkin.Controls.MaterialLabel LVL_ISV;
        private MaterialSkin.Controls.MaterialLabel LBL_PC;
        private MaterialSkin.Controls.MaterialLabel LBL_Categoria;
        private MaterialSkin.Controls.MaterialComboBox CBX_CATEGORIA;
        private MaterialSkin.Controls.MaterialButton BTN_Limpiar;
        private MaterialSkin.Controls.MaterialButton BTN_AGREGAR;
        private MaterialSkin.Controls.MaterialButton BTN_MODIFICAR;
        private MaterialSkin.Controls.MaterialTabControl MTB_PRODUCTO;
        private TabPage TBP_VISTA;
        private TabPage TBP_INGRESAR;
        private TabPage TBP_MODIFICAR;
        private MaterialSkin.Controls.MaterialTabSelector MTBS_DETALLE;
    }
}