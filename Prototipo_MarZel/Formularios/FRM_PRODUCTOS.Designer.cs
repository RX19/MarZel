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
            MTBC_MENU = new MaterialSkin.Controls.MaterialTabControl();
            TP_MODIFICAR = new TabPage();
            MC_BUSCAR = new MaterialSkin.Controls.MaterialCard();
            TXT_BUSCA = new MaterialSkin.Controls.MaterialTextBox2();
            MC_FORM = new MaterialSkin.Controls.MaterialCard();
            BTN_WARD = new MaterialSkin.Controls.MaterialButton();
            BTN_CANCEL = new MaterialSkin.Controls.MaterialButton();
            TXT_PC = new MaterialSkin.Controls.MaterialTextBox();
            LBL_PC = new MaterialSkin.Controls.MaterialLabel();
            TXT_PU = new MaterialSkin.Controls.MaterialTextBox();
            LBL_PU = new MaterialSkin.Controls.MaterialLabel();
            TXT_CANTIDAD = new MaterialSkin.Controls.MaterialTextBox();
            LBL_CANTIDAD = new MaterialSkin.Controls.MaterialLabel();
            CBX_CATEGORIA = new MaterialSkin.Controls.MaterialComboBox();
            LBL_CATEGORIA = new MaterialSkin.Controls.MaterialLabel();
            TXT_ISV = new MaterialSkin.Controls.MaterialTextBox();
            LBL_ISV = new MaterialSkin.Controls.MaterialLabel();
            TXT_DESC = new MaterialSkin.Controls.MaterialTextBox();
            LBL_DESC = new MaterialSkin.Controls.MaterialLabel();
            TXT_CODIGO_B = new MaterialSkin.Controls.MaterialTextBox2();
            LBL_CODIGO_B = new MaterialSkin.Controls.MaterialLabel();
            MC_PANEL_DATOS = new MaterialSkin.Controls.MaterialCard();
            DVC_PRODUCTOS = new DataGridView();
            TP_INSERTAR = new TabPage();
            MTBC_MENU.SuspendLayout();
            TP_MODIFICAR.SuspendLayout();
            MC_BUSCAR.SuspendLayout();
            MC_FORM.SuspendLayout();
            MC_PANEL_DATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVC_PRODUCTOS).BeginInit();
            SuspendLayout();
            // 
            // MTBC_MENU
            // 
            MTBC_MENU.Controls.Add(TP_MODIFICAR);
            MTBC_MENU.Controls.Add(TP_INSERTAR);
            MTBC_MENU.Depth = 0;
            MTBC_MENU.Dock = DockStyle.Fill;
            MTBC_MENU.Location = new Point(3, 64);
            MTBC_MENU.MouseState = MaterialSkin.MouseState.HOVER;
            MTBC_MENU.Multiline = true;
            MTBC_MENU.Name = "MTBC_MENU";
            MTBC_MENU.SelectedIndex = 0;
            MTBC_MENU.Size = new Size(1807, 781);
            MTBC_MENU.TabIndex = 0;
            // 
            // TP_MODIFICAR
            // 
            TP_MODIFICAR.Controls.Add(MC_BUSCAR);
            TP_MODIFICAR.Controls.Add(MC_FORM);
            TP_MODIFICAR.Controls.Add(MC_PANEL_DATOS);
            TP_MODIFICAR.Location = new Point(4, 29);
            TP_MODIFICAR.Name = "TP_MODIFICAR";
            TP_MODIFICAR.Padding = new Padding(3);
            TP_MODIFICAR.Size = new Size(1799, 748);
            TP_MODIFICAR.TabIndex = 0;
            TP_MODIFICAR.Text = "Productos";
            TP_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // MC_BUSCAR
            // 
            MC_BUSCAR.BackColor = Color.FromArgb(255, 255, 255);
            MC_BUSCAR.Controls.Add(TXT_BUSCA);
            MC_BUSCAR.Depth = 0;
            MC_BUSCAR.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MC_BUSCAR.Location = new Point(491, 3);
            MC_BUSCAR.Margin = new Padding(14);
            MC_BUSCAR.MouseState = MaterialSkin.MouseState.HOVER;
            MC_BUSCAR.Name = "MC_BUSCAR";
            MC_BUSCAR.Padding = new Padding(14);
            MC_BUSCAR.Size = new Size(1220, 71);
            MC_BUSCAR.TabIndex = 2;
            // 
            // TXT_BUSCA
            // 
            TXT_BUSCA.AnimateReadOnly = false;
            TXT_BUSCA.BackgroundImageLayout = ImageLayout.None;
            TXT_BUSCA.CharacterCasing = CharacterCasing.Normal;
            TXT_BUSCA.Depth = 0;
            TXT_BUSCA.Dock = DockStyle.Fill;
            TXT_BUSCA.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_BUSCA.HideSelection = true;
            TXT_BUSCA.LeadingIcon = null;
            TXT_BUSCA.Location = new Point(14, 14);
            TXT_BUSCA.MaxLength = 32767;
            TXT_BUSCA.MouseState = MaterialSkin.MouseState.OUT;
            TXT_BUSCA.Name = "TXT_BUSCA";
            TXT_BUSCA.PasswordChar = '\0';
            TXT_BUSCA.PrefixSuffixText = null;
            TXT_BUSCA.ReadOnly = false;
            TXT_BUSCA.RightToLeft = RightToLeft.No;
            TXT_BUSCA.SelectedText = "";
            TXT_BUSCA.SelectionLength = 0;
            TXT_BUSCA.SelectionStart = 0;
            TXT_BUSCA.ShortcutsEnabled = true;
            TXT_BUSCA.Size = new Size(1192, 48);
            TXT_BUSCA.TabIndex = 0;
            TXT_BUSCA.TabStop = false;
            TXT_BUSCA.TextAlign = HorizontalAlignment.Left;
            TXT_BUSCA.TrailingIcon = null;
            TXT_BUSCA.UseSystemPasswordChar = false;
            // 
            // MC_FORM
            // 
            MC_FORM.BackColor = Color.FromArgb(255, 255, 255);
            MC_FORM.Controls.Add(BTN_WARD);
            MC_FORM.Controls.Add(BTN_CANCEL);
            MC_FORM.Controls.Add(TXT_PC);
            MC_FORM.Controls.Add(LBL_PC);
            MC_FORM.Controls.Add(TXT_PU);
            MC_FORM.Controls.Add(LBL_PU);
            MC_FORM.Controls.Add(TXT_CANTIDAD);
            MC_FORM.Controls.Add(LBL_CANTIDAD);
            MC_FORM.Controls.Add(CBX_CATEGORIA);
            MC_FORM.Controls.Add(LBL_CATEGORIA);
            MC_FORM.Controls.Add(TXT_ISV);
            MC_FORM.Controls.Add(LBL_ISV);
            MC_FORM.Controls.Add(TXT_DESC);
            MC_FORM.Controls.Add(LBL_DESC);
            MC_FORM.Controls.Add(TXT_CODIGO_B);
            MC_FORM.Controls.Add(LBL_CODIGO_B);
            MC_FORM.Depth = 0;
            MC_FORM.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MC_FORM.Location = new Point(491, 154);
            MC_FORM.Margin = new Padding(14);
            MC_FORM.MouseState = MaterialSkin.MouseState.HOVER;
            MC_FORM.Name = "MC_FORM";
            MC_FORM.Padding = new Padding(14);
            MC_FORM.Size = new Size(1220, 594);
            MC_FORM.TabIndex = 1;
            // 
            // BTN_WARD
            // 
            BTN_WARD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_WARD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_WARD.Depth = 0;
            BTN_WARD.HighEmphasis = true;
            BTN_WARD.Icon = null;
            BTN_WARD.Location = new Point(750, 515);
            BTN_WARD.Margin = new Padding(4, 6, 4, 6);
            BTN_WARD.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_WARD.Name = "BTN_WARD";
            BTN_WARD.NoAccentTextColor = Color.Empty;
            BTN_WARD.Size = new Size(157, 36);
            BTN_WARD.TabIndex = 15;
            BTN_WARD.Text = "Guardar Cambios";
            BTN_WARD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_WARD.UseAccentColor = false;
            BTN_WARD.UseVisualStyleBackColor = true;
            // 
            // BTN_CANCEL
            // 
            BTN_CANCEL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_CANCEL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_CANCEL.Depth = 0;
            BTN_CANCEL.HighEmphasis = true;
            BTN_CANCEL.Icon = null;
            BTN_CANCEL.Location = new Point(389, 515);
            BTN_CANCEL.Margin = new Padding(4, 6, 4, 6);
            BTN_CANCEL.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_CANCEL.Name = "BTN_CANCEL";
            BTN_CANCEL.NoAccentTextColor = Color.Empty;
            BTN_CANCEL.Size = new Size(96, 36);
            BTN_CANCEL.TabIndex = 14;
            BTN_CANCEL.Text = "Cancelar";
            BTN_CANCEL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_CANCEL.UseAccentColor = false;
            BTN_CANCEL.UseVisualStyleBackColor = true;
            BTN_CANCEL.Click += BTN_CANCEL_Click;
            // 
            // TXT_PC
            // 
            TXT_PC.AnimateReadOnly = false;
            TXT_PC.BorderStyle = BorderStyle.None;
            TXT_PC.Depth = 0;
            TXT_PC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PC.LeadingIcon = null;
            TXT_PC.Location = new Point(603, 409);
            TXT_PC.MaxLength = 50;
            TXT_PC.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PC.Multiline = false;
            TXT_PC.Name = "TXT_PC";
            TXT_PC.Size = new Size(89, 50);
            TXT_PC.TabIndex = 13;
            TXT_PC.Text = "";
            TXT_PC.TrailingIcon = null;
            // 
            // LBL_PC
            // 
            LBL_PC.AutoSize = true;
            LBL_PC.Depth = 0;
            LBL_PC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_PC.Location = new Point(480, 424);
            LBL_PC.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_PC.Name = "LBL_PC";
            LBL_PC.Size = new Size(117, 19);
            LBL_PC.TabIndex = 12;
            LBL_PC.Text = "Precio Completo";
            // 
            // TXT_PU
            // 
            TXT_PU.AnimateReadOnly = false;
            TXT_PU.BorderStyle = BorderStyle.None;
            TXT_PU.Depth = 0;
            TXT_PU.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PU.LeadingIcon = null;
            TXT_PU.Location = new Point(282, 409);
            TXT_PU.MaxLength = 50;
            TXT_PU.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PU.Multiline = false;
            TXT_PU.Name = "TXT_PU";
            TXT_PU.Size = new Size(89, 50);
            TXT_PU.TabIndex = 11;
            TXT_PU.Text = "";
            TXT_PU.TrailingIcon = null;
            // 
            // LBL_PU
            // 
            LBL_PU.AutoSize = true;
            LBL_PU.Depth = 0;
            LBL_PU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_PU.Location = new Point(172, 424);
            LBL_PU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_PU.Name = "LBL_PU";
            LBL_PU.Size = new Size(104, 19);
            LBL_PU.TabIndex = 10;
            LBL_PU.Text = "Precio Unitario";
            // 
            // TXT_CANTIDAD
            // 
            TXT_CANTIDAD.AnimateReadOnly = false;
            TXT_CANTIDAD.BorderStyle = BorderStyle.None;
            TXT_CANTIDAD.Depth = 0;
            TXT_CANTIDAD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_CANTIDAD.LeadingIcon = null;
            TXT_CANTIDAD.Location = new Point(113, 334);
            TXT_CANTIDAD.MaxLength = 50;
            TXT_CANTIDAD.MouseState = MaterialSkin.MouseState.OUT;
            TXT_CANTIDAD.Multiline = false;
            TXT_CANTIDAD.Name = "TXT_CANTIDAD";
            TXT_CANTIDAD.Size = new Size(61, 50);
            TXT_CANTIDAD.TabIndex = 9;
            TXT_CANTIDAD.Text = "";
            TXT_CANTIDAD.TrailingIcon = null;
            // 
            // LBL_CANTIDAD
            // 
            LBL_CANTIDAD.AutoSize = true;
            LBL_CANTIDAD.Depth = 0;
            LBL_CANTIDAD.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CANTIDAD.Location = new Point(14, 358);
            LBL_CANTIDAD.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CANTIDAD.Name = "LBL_CANTIDAD";
            LBL_CANTIDAD.Size = new Size(65, 19);
            LBL_CANTIDAD.TabIndex = 8;
            LBL_CANTIDAD.Text = "Cantidad";
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
            CBX_CATEGORIA.Location = new Point(113, 225);
            CBX_CATEGORIA.MaxDropDownItems = 4;
            CBX_CATEGORIA.MouseState = MaterialSkin.MouseState.OUT;
            CBX_CATEGORIA.Name = "CBX_CATEGORIA";
            CBX_CATEGORIA.Size = new Size(151, 49);
            CBX_CATEGORIA.StartIndex = 0;
            CBX_CATEGORIA.TabIndex = 7;
            // 
            // LBL_CATEGORIA
            // 
            LBL_CATEGORIA.AutoSize = true;
            LBL_CATEGORIA.Depth = 0;
            LBL_CATEGORIA.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CATEGORIA.Location = new Point(14, 239);
            LBL_CATEGORIA.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CATEGORIA.Name = "LBL_CATEGORIA";
            LBL_CATEGORIA.Size = new Size(69, 19);
            LBL_CATEGORIA.TabIndex = 6;
            LBL_CATEGORIA.Text = "Categoria";
            // 
            // TXT_ISV
            // 
            TXT_ISV.AnimateReadOnly = false;
            TXT_ISV.BorderStyle = BorderStyle.None;
            TXT_ISV.Depth = 0;
            TXT_ISV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_ISV.LeadingIcon = null;
            TXT_ISV.Location = new Point(113, 278);
            TXT_ISV.MaxLength = 50;
            TXT_ISV.MouseState = MaterialSkin.MouseState.OUT;
            TXT_ISV.Multiline = false;
            TXT_ISV.Name = "TXT_ISV";
            TXT_ISV.Size = new Size(61, 50);
            TXT_ISV.TabIndex = 5;
            TXT_ISV.Text = "";
            TXT_ISV.TrailingIcon = null;
            // 
            // LBL_ISV
            // 
            LBL_ISV.AutoSize = true;
            LBL_ISV.Depth = 0;
            LBL_ISV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_ISV.Location = new Point(14, 293);
            LBL_ISV.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_ISV.Name = "LBL_ISV";
            LBL_ISV.Size = new Size(67, 19);
            LBL_ISV.TabIndex = 4;
            LBL_ISV.Text = "Impuesto";
            // 
            // TXT_DESC
            // 
            TXT_DESC.AnimateReadOnly = false;
            TXT_DESC.BorderStyle = BorderStyle.None;
            TXT_DESC.Depth = 0;
            TXT_DESC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_DESC.LeadingIcon = null;
            TXT_DESC.Location = new Point(113, 169);
            TXT_DESC.MaxLength = 50;
            TXT_DESC.MouseState = MaterialSkin.MouseState.OUT;
            TXT_DESC.Multiline = false;
            TXT_DESC.Name = "TXT_DESC";
            TXT_DESC.Size = new Size(1090, 50);
            TXT_DESC.TabIndex = 3;
            TXT_DESC.Text = "";
            TXT_DESC.TrailingIcon = null;
            // 
            // LBL_DESC
            // 
            LBL_DESC.AutoSize = true;
            LBL_DESC.Depth = 0;
            LBL_DESC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_DESC.Location = new Point(14, 183);
            LBL_DESC.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_DESC.Name = "LBL_DESC";
            LBL_DESC.Size = new Size(84, 19);
            LBL_DESC.TabIndex = 2;
            LBL_DESC.Text = "Descripcion";
            // 
            // TXT_CODIGO_B
            // 
            TXT_CODIGO_B.AnimateReadOnly = false;
            TXT_CODIGO_B.BackgroundImageLayout = ImageLayout.None;
            TXT_CODIGO_B.CharacterCasing = CharacterCasing.Normal;
            TXT_CODIGO_B.Depth = 0;
            TXT_CODIGO_B.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_CODIGO_B.HideSelection = true;
            TXT_CODIGO_B.LeadingIcon = null;
            TXT_CODIGO_B.Location = new Point(113, 115);
            TXT_CODIGO_B.MaxLength = 32767;
            TXT_CODIGO_B.MouseState = MaterialSkin.MouseState.OUT;
            TXT_CODIGO_B.Name = "TXT_CODIGO_B";
            TXT_CODIGO_B.PasswordChar = '\0';
            TXT_CODIGO_B.PrefixSuffixText = null;
            TXT_CODIGO_B.ReadOnly = true;
            TXT_CODIGO_B.RightToLeft = RightToLeft.No;
            TXT_CODIGO_B.SelectedText = "";
            TXT_CODIGO_B.SelectionLength = 0;
            TXT_CODIGO_B.SelectionStart = 0;
            TXT_CODIGO_B.ShortcutsEnabled = true;
            TXT_CODIGO_B.Size = new Size(1093, 48);
            TXT_CODIGO_B.TabIndex = 1;
            TXT_CODIGO_B.TabStop = false;
            TXT_CODIGO_B.TextAlign = HorizontalAlignment.Left;
            TXT_CODIGO_B.TrailingIcon = null;
            TXT_CODIGO_B.UseSystemPasswordChar = false;
            // 
            // LBL_CODIGO_B
            // 
            LBL_CODIGO_B.AutoSize = true;
            LBL_CODIGO_B.Depth = 0;
            LBL_CODIGO_B.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CODIGO_B.Location = new Point(14, 129);
            LBL_CODIGO_B.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CODIGO_B.Name = "LBL_CODIGO_B";
            LBL_CODIGO_B.Size = new Size(93, 19);
            LBL_CODIGO_B.TabIndex = 0;
            LBL_CODIGO_B.Text = "Codigo Barra";
            // 
            // MC_PANEL_DATOS
            // 
            MC_PANEL_DATOS.BackColor = Color.FromArgb(255, 255, 255);
            MC_PANEL_DATOS.Controls.Add(DVC_PRODUCTOS);
            MC_PANEL_DATOS.Depth = 0;
            MC_PANEL_DATOS.Dock = DockStyle.Left;
            MC_PANEL_DATOS.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MC_PANEL_DATOS.Location = new Point(3, 3);
            MC_PANEL_DATOS.Margin = new Padding(14);
            MC_PANEL_DATOS.MouseState = MaterialSkin.MouseState.HOVER;
            MC_PANEL_DATOS.Name = "MC_PANEL_DATOS";
            MC_PANEL_DATOS.Padding = new Padding(14);
            MC_PANEL_DATOS.Size = new Size(356, 742);
            MC_PANEL_DATOS.TabIndex = 0;
            // 
            // DVC_PRODUCTOS
            // 
            DVC_PRODUCTOS.BackgroundColor = SystemColors.ActiveCaption;
            DVC_PRODUCTOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVC_PRODUCTOS.Dock = DockStyle.Fill;
            DVC_PRODUCTOS.EditMode = DataGridViewEditMode.EditProgrammatically;
            DVC_PRODUCTOS.Location = new Point(14, 14);
            DVC_PRODUCTOS.Name = "DVC_PRODUCTOS";
            DVC_PRODUCTOS.RowHeadersWidth = 51;
            DVC_PRODUCTOS.Size = new Size(328, 714);
            DVC_PRODUCTOS.TabIndex = 0;
            DVC_PRODUCTOS.CellContentClick += DVC_PRODUCTOS_CellContentClick;
            // 
            // TP_INSERTAR
            // 
            TP_INSERTAR.Location = new Point(4, 29);
            TP_INSERTAR.Name = "TP_INSERTAR";
            TP_INSERTAR.Padding = new Padding(3);
            TP_INSERTAR.Size = new Size(1799, 748);
            TP_INSERTAR.TabIndex = 1;
            TP_INSERTAR.Text = "Agregar";
            TP_INSERTAR.UseVisualStyleBackColor = true;
            // 
            // FRM_PRODUCTOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1813, 848);
            Controls.Add(MTBC_MENU);
            DrawerTabControl = MTBC_MENU;
            Name = "FRM_PRODUCTOS";
            Text = "Productos";
            FormClosed += FRM_PRODUCTOS_FormClosed;
            Load += FRM_PRODUCTOS_Load;
            MTBC_MENU.ResumeLayout(false);
            TP_MODIFICAR.ResumeLayout(false);
            MC_BUSCAR.ResumeLayout(false);
            MC_FORM.ResumeLayout(false);
            MC_FORM.PerformLayout();
            MC_PANEL_DATOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DVC_PRODUCTOS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MTBC_MENU;
        private TabPage TP_MODIFICAR;
        private TabPage TP_INSERTAR;
        private MaterialSkin.Controls.MaterialCard MC_PANEL_DATOS;
        private DataGridView DVC_PRODUCTOS;
        private MaterialSkin.Controls.MaterialCard MC_FORM;
        private MaterialSkin.Controls.MaterialLabel LBL_CODIGO_B;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_CODIGO_B;
        private MaterialSkin.Controls.MaterialCard MC_BUSCAR;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_BUSCA;
        private MaterialSkin.Controls.MaterialLabel LBL_DESC;
        private MaterialSkin.Controls.MaterialTextBox TXT_DESC;
        private MaterialSkin.Controls.MaterialLabel LBL_CANTIDAD;
        private MaterialSkin.Controls.MaterialComboBox CBX_CATEGORIA;
        private MaterialSkin.Controls.MaterialLabel LBL_CATEGORIA;
        private MaterialSkin.Controls.MaterialTextBox TXT_ISV;
        private MaterialSkin.Controls.MaterialLabel LBL_ISV;
        private MaterialSkin.Controls.MaterialTextBox TXT_PC;
        private MaterialSkin.Controls.MaterialLabel LBL_PC;
        private MaterialSkin.Controls.MaterialTextBox TXT_PU;
        private MaterialSkin.Controls.MaterialLabel LBL_PU;
        private MaterialSkin.Controls.MaterialTextBox TXT_CANTIDAD;
        private MaterialSkin.Controls.MaterialButton BTN_WARD;
        private MaterialSkin.Controls.MaterialButton BTN_CANCEL;
    }
}