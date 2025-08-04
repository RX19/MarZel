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
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            TXT_DESCUENTO = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            CBX_TIPOISV = new MaterialSkin.Controls.MaterialComboBox();
            BTN_WARD = new MaterialSkin.Controls.MaterialButton();
            BTN_CANCEL = new MaterialSkin.Controls.MaterialButton();
            TXT_PC = new MaterialSkin.Controls.MaterialTextBox();
            LBL_PC = new MaterialSkin.Controls.MaterialLabel();
            TXT_PU = new MaterialSkin.Controls.MaterialTextBox();
            LBL_PU = new MaterialSkin.Controls.MaterialLabel();
            TXT_EXISTENCIA = new MaterialSkin.Controls.MaterialTextBox();
            LBL_EXISTENCIA = new MaterialSkin.Controls.MaterialLabel();
            CBX_CATEGORIA = new MaterialSkin.Controls.MaterialComboBox();
            LBL_CATEGORIA = new MaterialSkin.Controls.MaterialLabel();
            LBL_ISV = new MaterialSkin.Controls.MaterialLabel();
            TXT_DESC = new MaterialSkin.Controls.MaterialTextBox();
            LBL_DESC = new MaterialSkin.Controls.MaterialLabel();
            TXT_CODIGO_B = new MaterialSkin.Controls.MaterialTextBox2();
            LBL_CODIGO_B = new MaterialSkin.Controls.MaterialLabel();
            MC_PANEL_DATOS = new MaterialSkin.Controls.MaterialCard();
            DVC_PRODUCTOS = new DataGridView();
            TP_INSERTAR = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            txtDescuento = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtExistencia = new MaterialSkin.Controls.MaterialTextBox2();
            lblExistencia = new MaterialSkin.Controls.MaterialLabel();
            cmbTiposISV = new MaterialSkin.Controls.MaterialComboBox();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            txtPrecioCompleto = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txtPrecioUnitario = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            cmbCaregorias = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txtDescripcion = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txtCodigoBarra = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            TP_HISTORIAL = new TabPage();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            TXT_FILTRO_PRODUCTO = new MaterialSkin.Controls.MaterialTextBox2();
            BTN_FILTRAR = new MaterialSkin.Controls.MaterialButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            DVC_HISTORIAL = new DataGridView();
            MTBC_MENU.SuspendLayout();
            TP_MODIFICAR.SuspendLayout();
            MC_BUSCAR.SuspendLayout();
            MC_FORM.SuspendLayout();
            MC_PANEL_DATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVC_PRODUCTOS).BeginInit();
            TP_INSERTAR.SuspendLayout();
            materialCard1.SuspendLayout();
            TP_HISTORIAL.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVC_HISTORIAL).BeginInit();
            SuspendLayout();
            // 
            // MTBC_MENU
            // 
            MTBC_MENU.Controls.Add(TP_MODIFICAR);
            MTBC_MENU.Controls.Add(TP_INSERTAR);
            MTBC_MENU.Controls.Add(TP_HISTORIAL);
            MTBC_MENU.Depth = 0;
            MTBC_MENU.Dock = DockStyle.Fill;
            MTBC_MENU.Location = new Point(3, 48);
            MTBC_MENU.Margin = new Padding(3, 2, 3, 2);
            MTBC_MENU.MouseState = MaterialSkin.MouseState.HOVER;
            MTBC_MENU.Multiline = true;
            MTBC_MENU.Name = "MTBC_MENU";
            MTBC_MENU.SelectedIndex = 0;
            MTBC_MENU.Size = new Size(1364, 643);
            MTBC_MENU.TabIndex = 0;
            MTBC_MENU.SelectedIndexChanged += MTBC_MENU_SelectedIndexChanged_1;
            // 
            // TP_MODIFICAR
            // 
            TP_MODIFICAR.Controls.Add(MC_BUSCAR);
            TP_MODIFICAR.Controls.Add(MC_FORM);
            TP_MODIFICAR.Controls.Add(MC_PANEL_DATOS);
            TP_MODIFICAR.Location = new Point(4, 24);
            TP_MODIFICAR.Margin = new Padding(3, 2, 3, 2);
            TP_MODIFICAR.Name = "TP_MODIFICAR";
            TP_MODIFICAR.Padding = new Padding(3, 2, 3, 2);
            TP_MODIFICAR.Size = new Size(1356, 615);
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
            MC_BUSCAR.Location = new Point(430, 2);
            MC_BUSCAR.Margin = new Padding(12, 10, 12, 10);
            MC_BUSCAR.MouseState = MaterialSkin.MouseState.HOVER;
            MC_BUSCAR.Name = "MC_BUSCAR";
            MC_BUSCAR.Padding = new Padding(12, 10, 12, 10);
            MC_BUSCAR.Size = new Size(1068, 53);
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
            TXT_BUSCA.Location = new Point(12, 10);
            TXT_BUSCA.Margin = new Padding(3, 2, 3, 2);
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
            TXT_BUSCA.Size = new Size(1044, 48);
            TXT_BUSCA.TabIndex = 0;
            TXT_BUSCA.TabStop = false;
            TXT_BUSCA.TextAlign = HorizontalAlignment.Left;
            TXT_BUSCA.TrailingIcon = null;
            TXT_BUSCA.UseSystemPasswordChar = false;
            TXT_BUSCA.TextChanged += TXT_BUSCA_TextChanged;
            // 
            // MC_FORM
            // 
            MC_FORM.BackColor = Color.FromArgb(255, 255, 255);
            MC_FORM.Controls.Add(btnEliminar);
            MC_FORM.Controls.Add(TXT_DESCUENTO);
            MC_FORM.Controls.Add(materialLabel7);
            MC_FORM.Controls.Add(CBX_TIPOISV);
            MC_FORM.Controls.Add(BTN_WARD);
            MC_FORM.Controls.Add(BTN_CANCEL);
            MC_FORM.Controls.Add(TXT_PC);
            MC_FORM.Controls.Add(LBL_PC);
            MC_FORM.Controls.Add(TXT_PU);
            MC_FORM.Controls.Add(LBL_PU);
            MC_FORM.Controls.Add(TXT_EXISTENCIA);
            MC_FORM.Controls.Add(LBL_EXISTENCIA);
            MC_FORM.Controls.Add(CBX_CATEGORIA);
            MC_FORM.Controls.Add(LBL_CATEGORIA);
            MC_FORM.Controls.Add(LBL_ISV);
            MC_FORM.Controls.Add(TXT_DESC);
            MC_FORM.Controls.Add(LBL_DESC);
            MC_FORM.Controls.Add(TXT_CODIGO_B);
            MC_FORM.Controls.Add(LBL_CODIGO_B);
            MC_FORM.Depth = 0;
            MC_FORM.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MC_FORM.Location = new Point(430, 116);
            MC_FORM.Margin = new Padding(12, 10, 12, 10);
            MC_FORM.MouseState = MaterialSkin.MouseState.HOVER;
            MC_FORM.Name = "MC_FORM";
            MC_FORM.Padding = new Padding(12, 10, 12, 10);
            MC_FORM.Size = new Size(1068, 446);
            MC_FORM.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(630, 386);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(88, 36);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // TXT_DESCUENTO
            // 
            TXT_DESCUENTO.AnimateReadOnly = false;
            TXT_DESCUENTO.BorderStyle = BorderStyle.None;
            TXT_DESCUENTO.Depth = 0;
            TXT_DESCUENTO.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_DESCUENTO.LeadingIcon = null;
            TXT_DESCUENTO.Location = new Point(538, 143);
            TXT_DESCUENTO.Margin = new Padding(3, 2, 3, 2);
            TXT_DESCUENTO.MaxLength = 50;
            TXT_DESCUENTO.MouseState = MaterialSkin.MouseState.OUT;
            TXT_DESCUENTO.Multiline = false;
            TXT_DESCUENTO.Name = "TXT_DESCUENTO";
            TXT_DESCUENTO.Size = new Size(78, 50);
            TXT_DESCUENTO.TabIndex = 18;
            TXT_DESCUENTO.Text = "";
            TXT_DESCUENTO.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(420, 154);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(76, 19);
            materialLabel7.TabIndex = 17;
            materialLabel7.Text = "Descuento";
            // 
            // CBX_TIPOISV
            // 
            CBX_TIPOISV.AutoResize = false;
            CBX_TIPOISV.BackColor = Color.FromArgb(255, 255, 255);
            CBX_TIPOISV.Depth = 0;
            CBX_TIPOISV.DrawMode = DrawMode.OwnerDrawVariable;
            CBX_TIPOISV.DropDownHeight = 174;
            CBX_TIPOISV.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_TIPOISV.DropDownWidth = 121;
            CBX_TIPOISV.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CBX_TIPOISV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CBX_TIPOISV.FormattingEnabled = true;
            CBX_TIPOISV.IntegralHeight = false;
            CBX_TIPOISV.ItemHeight = 43;
            CBX_TIPOISV.Location = new Point(110, 200);
            CBX_TIPOISV.Margin = new Padding(3, 2, 3, 2);
            CBX_TIPOISV.MaxDropDownItems = 4;
            CBX_TIPOISV.MouseState = MaterialSkin.MouseState.OUT;
            CBX_TIPOISV.Name = "CBX_TIPOISV";
            CBX_TIPOISV.Size = new Size(132, 49);
            CBX_TIPOISV.StartIndex = 0;
            CBX_TIPOISV.TabIndex = 16;
            // 
            // BTN_WARD
            // 
            BTN_WARD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_WARD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_WARD.Depth = 0;
            BTN_WARD.HighEmphasis = true;
            BTN_WARD.Icon = null;
            BTN_WARD.Location = new Point(443, 386);
            BTN_WARD.Margin = new Padding(4);
            BTN_WARD.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_WARD.Name = "BTN_WARD";
            BTN_WARD.NoAccentTextColor = Color.Empty;
            BTN_WARD.Size = new Size(157, 36);
            BTN_WARD.TabIndex = 15;
            BTN_WARD.Text = "Guardar Cambios";
            BTN_WARD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_WARD.UseAccentColor = false;
            BTN_WARD.UseVisualStyleBackColor = true;
            BTN_WARD.Click += BTN_WARD_Click;
            // 
            // BTN_CANCEL
            // 
            BTN_CANCEL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_CANCEL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_CANCEL.Depth = 0;
            BTN_CANCEL.HighEmphasis = true;
            BTN_CANCEL.Icon = null;
            BTN_CANCEL.Location = new Point(300, 386);
            BTN_CANCEL.Margin = new Padding(4);
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
            TXT_PC.Location = new Point(538, 307);
            TXT_PC.Margin = new Padding(3, 2, 3, 2);
            TXT_PC.MaxLength = 50;
            TXT_PC.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PC.Multiline = false;
            TXT_PC.Name = "TXT_PC";
            TXT_PC.Size = new Size(78, 50);
            TXT_PC.TabIndex = 13;
            TXT_PC.Text = "";
            TXT_PC.TrailingIcon = null;
            // 
            // LBL_PC
            // 
            LBL_PC.AutoSize = true;
            LBL_PC.Depth = 0;
            LBL_PC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_PC.Location = new Point(420, 318);
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
            TXT_PU.Location = new Point(263, 307);
            TXT_PU.Margin = new Padding(3, 2, 3, 2);
            TXT_PU.MaxLength = 50;
            TXT_PU.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PU.Multiline = false;
            TXT_PU.Name = "TXT_PU";
            TXT_PU.Size = new Size(78, 50);
            TXT_PU.TabIndex = 11;
            TXT_PU.Text = "";
            TXT_PU.TrailingIcon = null;
            // 
            // LBL_PU
            // 
            LBL_PU.AutoSize = true;
            LBL_PU.Depth = 0;
            LBL_PU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_PU.Location = new Point(150, 318);
            LBL_PU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_PU.Name = "LBL_PU";
            LBL_PU.Size = new Size(104, 19);
            LBL_PU.TabIndex = 10;
            LBL_PU.Text = "Precio Unitario";
            // 
            // TXT_EXISTENCIA
            // 
            TXT_EXISTENCIA.AnimateReadOnly = false;
            TXT_EXISTENCIA.BorderStyle = BorderStyle.None;
            TXT_EXISTENCIA.Depth = 0;
            TXT_EXISTENCIA.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_EXISTENCIA.LeadingIcon = null;
            TXT_EXISTENCIA.Location = new Point(110, 256);
            TXT_EXISTENCIA.Margin = new Padding(3, 2, 3, 2);
            TXT_EXISTENCIA.MaxLength = 50;
            TXT_EXISTENCIA.MouseState = MaterialSkin.MouseState.OUT;
            TXT_EXISTENCIA.Multiline = false;
            TXT_EXISTENCIA.Name = "TXT_EXISTENCIA";
            TXT_EXISTENCIA.Size = new Size(53, 50);
            TXT_EXISTENCIA.TabIndex = 9;
            TXT_EXISTENCIA.Text = "";
            TXT_EXISTENCIA.TrailingIcon = null;
            // 
            // LBL_EXISTENCIA
            // 
            LBL_EXISTENCIA.AutoSize = true;
            LBL_EXISTENCIA.Depth = 0;
            LBL_EXISTENCIA.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_EXISTENCIA.Location = new Point(16, 268);
            LBL_EXISTENCIA.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_EXISTENCIA.Name = "LBL_EXISTENCIA";
            LBL_EXISTENCIA.Size = new Size(73, 19);
            LBL_EXISTENCIA.TabIndex = 8;
            LBL_EXISTENCIA.Text = "Existencia";
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
            CBX_CATEGORIA.Location = new Point(110, 142);
            CBX_CATEGORIA.Margin = new Padding(3, 2, 3, 2);
            CBX_CATEGORIA.MaxDropDownItems = 4;
            CBX_CATEGORIA.MouseState = MaterialSkin.MouseState.OUT;
            CBX_CATEGORIA.Name = "CBX_CATEGORIA";
            CBX_CATEGORIA.Size = new Size(132, 49);
            CBX_CATEGORIA.StartIndex = 0;
            CBX_CATEGORIA.TabIndex = 7;
            // 
            // LBL_CATEGORIA
            // 
            LBL_CATEGORIA.AutoSize = true;
            LBL_CATEGORIA.Depth = 0;
            LBL_CATEGORIA.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CATEGORIA.Location = new Point(12, 154);
            LBL_CATEGORIA.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CATEGORIA.Name = "LBL_CATEGORIA";
            LBL_CATEGORIA.Size = new Size(69, 19);
            LBL_CATEGORIA.TabIndex = 6;
            LBL_CATEGORIA.Text = "Categoria";
            // 
            // LBL_ISV
            // 
            LBL_ISV.AutoSize = true;
            LBL_ISV.Depth = 0;
            LBL_ISV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_ISV.Location = new Point(12, 214);
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
            TXT_DESC.Location = new Point(110, 82);
            TXT_DESC.Margin = new Padding(3, 2, 3, 2);
            TXT_DESC.MaxLength = 50;
            TXT_DESC.MouseState = MaterialSkin.MouseState.OUT;
            TXT_DESC.Multiline = false;
            TXT_DESC.Name = "TXT_DESC";
            TXT_DESC.Size = new Size(940, 50);
            TXT_DESC.TabIndex = 3;
            TXT_DESC.Text = "";
            TXT_DESC.TrailingIcon = null;
            // 
            // LBL_DESC
            // 
            LBL_DESC.AutoSize = true;
            LBL_DESC.Depth = 0;
            LBL_DESC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_DESC.Location = new Point(12, 95);
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
            TXT_CODIGO_B.Location = new Point(110, 28);
            TXT_CODIGO_B.Margin = new Padding(3, 2, 3, 2);
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
            TXT_CODIGO_B.Size = new Size(942, 48);
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
            LBL_CODIGO_B.Location = new Point(12, 40);
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
            MC_PANEL_DATOS.Location = new Point(3, 2);
            MC_PANEL_DATOS.Margin = new Padding(12, 10, 12, 10);
            MC_PANEL_DATOS.MouseState = MaterialSkin.MouseState.HOVER;
            MC_PANEL_DATOS.Name = "MC_PANEL_DATOS";
            MC_PANEL_DATOS.Padding = new Padding(12, 10, 12, 10);
            MC_PANEL_DATOS.Size = new Size(312, 611);
            MC_PANEL_DATOS.TabIndex = 0;
            // 
            // DVC_PRODUCTOS
            // 
            DVC_PRODUCTOS.AllowUserToAddRows = false;
            DVC_PRODUCTOS.AllowUserToDeleteRows = false;
            DVC_PRODUCTOS.AllowUserToResizeColumns = false;
            DVC_PRODUCTOS.AllowUserToResizeRows = false;
            DVC_PRODUCTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DVC_PRODUCTOS.BackgroundColor = SystemColors.ActiveCaption;
            DVC_PRODUCTOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVC_PRODUCTOS.Dock = DockStyle.Fill;
            DVC_PRODUCTOS.EditMode = DataGridViewEditMode.EditProgrammatically;
            DVC_PRODUCTOS.Location = new Point(12, 10);
            DVC_PRODUCTOS.Margin = new Padding(3, 2, 3, 2);
            DVC_PRODUCTOS.MultiSelect = false;
            DVC_PRODUCTOS.Name = "DVC_PRODUCTOS";
            DVC_PRODUCTOS.RowHeadersWidth = 51;
            DVC_PRODUCTOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DVC_PRODUCTOS.Size = new Size(288, 591);
            DVC_PRODUCTOS.TabIndex = 0;
            DVC_PRODUCTOS.CellClick += DVC_PRODUCTOS_CellClick;
            // 
            // TP_INSERTAR
            // 
            TP_INSERTAR.Controls.Add(materialCard1);
            TP_INSERTAR.Location = new Point(4, 24);
            TP_INSERTAR.Margin = new Padding(3, 2, 3, 2);
            TP_INSERTAR.Name = "TP_INSERTAR";
            TP_INSERTAR.Padding = new Padding(3, 2, 3, 2);
            TP_INSERTAR.Size = new Size(1356, 615);
            TP_INSERTAR.TabIndex = 1;
            TP_INSERTAR.Text = "Agregar";
            TP_INSERTAR.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtDescuento);
            materialCard1.Controls.Add(materialLabel8);
            materialCard1.Controls.Add(txtExistencia);
            materialCard1.Controls.Add(lblExistencia);
            materialCard1.Controls.Add(cmbTiposISV);
            materialCard1.Controls.Add(btnGuardar);
            materialCard1.Controls.Add(btnCancelar);
            materialCard1.Controls.Add(txtPrecioCompleto);
            materialCard1.Controls.Add(materialLabel6);
            materialCard1.Controls.Add(txtPrecioUnitario);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(cmbCaregorias);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(txtDescripcion);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(txtCodigoBarra);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(12, 10);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(1078, 507);
            materialCard1.TabIndex = 0;
            // 
            // txtDescuento
            // 
            txtDescuento.AnimateReadOnly = false;
            txtDescuento.BackgroundImageLayout = ImageLayout.None;
            txtDescuento.CharacterCasing = CharacterCasing.Normal;
            txtDescuento.Depth = 0;
            txtDescuento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescuento.HideSelection = true;
            txtDescuento.LeadingIcon = null;
            txtDescuento.Location = new Point(551, 252);
            txtDescuento.Margin = new Padding(3, 2, 3, 2);
            txtDescuento.MaxLength = 32767;
            txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PasswordChar = '\0';
            txtDescuento.PrefixSuffixText = null;
            txtDescuento.ReadOnly = false;
            txtDescuento.RightToLeft = RightToLeft.No;
            txtDescuento.SelectedText = "";
            txtDescuento.SelectionLength = 0;
            txtDescuento.SelectionStart = 0;
            txtDescuento.ShortcutsEnabled = true;
            txtDescuento.Size = new Size(113, 48);
            txtDescuento.TabIndex = 18;
            txtDescuento.TabStop = false;
            txtDescuento.TextAlign = HorizontalAlignment.Left;
            txtDescuento.TrailingIcon = null;
            txtDescuento.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(477, 263);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(76, 19);
            materialLabel8.TabIndex = 17;
            materialLabel8.Text = "Descuento";
            // 
            // txtExistencia
            // 
            txtExistencia.AnimateReadOnly = false;
            txtExistencia.BackgroundImageLayout = ImageLayout.None;
            txtExistencia.CharacterCasing = CharacterCasing.Normal;
            txtExistencia.Depth = 0;
            txtExistencia.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExistencia.HideSelection = true;
            txtExistencia.LeadingIcon = null;
            txtExistencia.Location = new Point(551, 180);
            txtExistencia.Margin = new Padding(3, 2, 3, 2);
            txtExistencia.MaxLength = 32767;
            txtExistencia.MouseState = MaterialSkin.MouseState.OUT;
            txtExistencia.Name = "txtExistencia";
            txtExistencia.PasswordChar = '\0';
            txtExistencia.PrefixSuffixText = null;
            txtExistencia.ReadOnly = false;
            txtExistencia.RightToLeft = RightToLeft.No;
            txtExistencia.SelectedText = "";
            txtExistencia.SelectionLength = 0;
            txtExistencia.SelectionStart = 0;
            txtExistencia.ShortcutsEnabled = true;
            txtExistencia.Size = new Size(113, 48);
            txtExistencia.TabIndex = 16;
            txtExistencia.TabStop = false;
            txtExistencia.TextAlign = HorizontalAlignment.Left;
            txtExistencia.TrailingIcon = null;
            txtExistencia.UseSystemPasswordChar = false;
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Depth = 0;
            lblExistencia.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblExistencia.Location = new Point(477, 191);
            lblExistencia.MouseState = MaterialSkin.MouseState.HOVER;
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(73, 19);
            lblExistencia.TabIndex = 15;
            lblExistencia.Text = "Existencia";
            // 
            // cmbTiposISV
            // 
            cmbTiposISV.AutoResize = false;
            cmbTiposISV.BackColor = Color.FromArgb(255, 255, 255);
            cmbTiposISV.Depth = 0;
            cmbTiposISV.DrawMode = DrawMode.OwnerDrawVariable;
            cmbTiposISV.DropDownHeight = 174;
            cmbTiposISV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTiposISV.DropDownWidth = 121;
            cmbTiposISV.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbTiposISV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbTiposISV.FormattingEnabled = true;
            cmbTiposISV.IntegralHeight = false;
            cmbTiposISV.ItemHeight = 43;
            cmbTiposISV.Location = new Point(185, 180);
            cmbTiposISV.Margin = new Padding(3, 2, 3, 2);
            cmbTiposISV.MaxDropDownItems = 4;
            cmbTiposISV.MouseState = MaterialSkin.MouseState.OUT;
            cmbTiposISV.Name = "cmbTiposISV";
            cmbTiposISV.Size = new Size(133, 49);
            cmbTiposISV.StartIndex = 0;
            cmbTiposISV.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(628, 452);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(262, 452);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecioCompleto
            // 
            txtPrecioCompleto.AnimateReadOnly = false;
            txtPrecioCompleto.BackgroundImageLayout = ImageLayout.None;
            txtPrecioCompleto.CharacterCasing = CharacterCasing.Normal;
            txtPrecioCompleto.Depth = 0;
            txtPrecioCompleto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioCompleto.HideSelection = true;
            txtPrecioCompleto.LeadingIcon = null;
            txtPrecioCompleto.Location = new Point(620, 369);
            txtPrecioCompleto.Margin = new Padding(3, 2, 3, 2);
            txtPrecioCompleto.MaxLength = 32767;
            txtPrecioCompleto.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecioCompleto.Name = "txtPrecioCompleto";
            txtPrecioCompleto.PasswordChar = '\0';
            txtPrecioCompleto.PrefixSuffixText = null;
            txtPrecioCompleto.ReadOnly = false;
            txtPrecioCompleto.RightToLeft = RightToLeft.No;
            txtPrecioCompleto.SelectedText = "";
            txtPrecioCompleto.SelectionLength = 0;
            txtPrecioCompleto.SelectionStart = 0;
            txtPrecioCompleto.ShortcutsEnabled = true;
            txtPrecioCompleto.Size = new Size(133, 48);
            txtPrecioCompleto.TabIndex = 11;
            txtPrecioCompleto.TabStop = false;
            txtPrecioCompleto.TextAlign = HorizontalAlignment.Left;
            txtPrecioCompleto.TrailingIcon = null;
            txtPrecioCompleto.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(477, 380);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(117, 19);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "Precio Completo";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.AnimateReadOnly = false;
            txtPrecioUnitario.BackgroundImageLayout = ImageLayout.None;
            txtPrecioUnitario.CharacterCasing = CharacterCasing.Normal;
            txtPrecioUnitario.Depth = 0;
            txtPrecioUnitario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioUnitario.HideSelection = true;
            txtPrecioUnitario.LeadingIcon = null;
            txtPrecioUnitario.Location = new Point(180, 369);
            txtPrecioUnitario.Margin = new Padding(3, 2, 3, 2);
            txtPrecioUnitario.MaxLength = 32767;
            txtPrecioUnitario.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.PasswordChar = '\0';
            txtPrecioUnitario.PrefixSuffixText = null;
            txtPrecioUnitario.ReadOnly = false;
            txtPrecioUnitario.RightToLeft = RightToLeft.No;
            txtPrecioUnitario.SelectedText = "";
            txtPrecioUnitario.SelectionLength = 0;
            txtPrecioUnitario.SelectionStart = 0;
            txtPrecioUnitario.ShortcutsEnabled = true;
            txtPrecioUnitario.Size = new Size(136, 48);
            txtPrecioUnitario.TabIndex = 9;
            txtPrecioUnitario.TabStop = false;
            txtPrecioUnitario.TextAlign = HorizontalAlignment.Left;
            txtPrecioUnitario.TrailingIcon = null;
            txtPrecioUnitario.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(66, 380);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(104, 19);
            materialLabel5.TabIndex = 8;
            materialLabel5.Text = "Precio Unitario";
            // 
            // cmbCaregorias
            // 
            cmbCaregorias.AutoResize = false;
            cmbCaregorias.BackColor = Color.FromArgb(255, 255, 255);
            cmbCaregorias.Depth = 0;
            cmbCaregorias.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCaregorias.DropDownHeight = 174;
            cmbCaregorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaregorias.DropDownWidth = 121;
            cmbCaregorias.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCaregorias.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCaregorias.FormattingEnabled = true;
            cmbCaregorias.IntegralHeight = false;
            cmbCaregorias.ItemHeight = 43;
            cmbCaregorias.Location = new Point(185, 252);
            cmbCaregorias.Margin = new Padding(3, 2, 3, 2);
            cmbCaregorias.MaxDropDownItems = 4;
            cmbCaregorias.MouseState = MaterialSkin.MouseState.OUT;
            cmbCaregorias.Name = "cmbCaregorias";
            cmbCaregorias.Size = new Size(133, 49);
            cmbCaregorias.StartIndex = 0;
            cmbCaregorias.TabIndex = 7;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(66, 261);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(69, 19);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Categoria";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(66, 191);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(25, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "ISV";
            // 
            // txtDescripcion
            // 
            txtDescripcion.AnimateReadOnly = false;
            txtDescripcion.BackgroundImageLayout = ImageLayout.None;
            txtDescripcion.CharacterCasing = CharacterCasing.Normal;
            txtDescripcion.Depth = 0;
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescripcion.HideSelection = true;
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(185, 122);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.MaxLength = 32767;
            txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PasswordChar = '\0';
            txtDescripcion.PrefixSuffixText = null;
            txtDescripcion.ReadOnly = false;
            txtDescripcion.RightToLeft = RightToLeft.No;
            txtDescripcion.SelectedText = "";
            txtDescripcion.SelectionLength = 0;
            txtDescripcion.SelectionStart = 0;
            txtDescripcion.ShortcutsEnabled = true;
            txtDescripcion.Size = new Size(853, 48);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.TabStop = false;
            txtDescripcion.TextAlign = HorizontalAlignment.Left;
            txtDescripcion.TrailingIcon = null;
            txtDescripcion.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(66, 134);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(84, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Descripcion";
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.AnimateReadOnly = false;
            txtCodigoBarra.BackgroundImageLayout = ImageLayout.None;
            txtCodigoBarra.CharacterCasing = CharacterCasing.Normal;
            txtCodigoBarra.Depth = 0;
            txtCodigoBarra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigoBarra.HideSelection = true;
            txtCodigoBarra.LeadingIcon = null;
            txtCodigoBarra.Location = new Point(185, 59);
            txtCodigoBarra.Margin = new Padding(3, 2, 3, 2);
            txtCodigoBarra.MaxLength = 32767;
            txtCodigoBarra.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.PasswordChar = '\0';
            txtCodigoBarra.PrefixSuffixText = null;
            txtCodigoBarra.ReadOnly = false;
            txtCodigoBarra.RightToLeft = RightToLeft.No;
            txtCodigoBarra.SelectedText = "";
            txtCodigoBarra.SelectionLength = 0;
            txtCodigoBarra.SelectionStart = 0;
            txtCodigoBarra.ShortcutsEnabled = true;
            txtCodigoBarra.Size = new Size(853, 48);
            txtCodigoBarra.TabIndex = 1;
            txtCodigoBarra.TabStop = false;
            txtCodigoBarra.TextAlign = HorizontalAlignment.Left;
            txtCodigoBarra.TrailingIcon = null;
            txtCodigoBarra.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(66, 73);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(114, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Codigo de Barra";
            // 
            // TP_HISTORIAL
            // 
            TP_HISTORIAL.Controls.Add(materialCard3);
            TP_HISTORIAL.Controls.Add(BTN_FILTRAR);
            TP_HISTORIAL.Controls.Add(materialCard2);
            TP_HISTORIAL.Location = new Point(4, 24);
            TP_HISTORIAL.Margin = new Padding(3, 2, 3, 2);
            TP_HISTORIAL.Name = "TP_HISTORIAL";
            TP_HISTORIAL.Size = new Size(1356, 615);
            TP_HISTORIAL.TabIndex = 2;
            TP_HISTORIAL.Text = "Historial";
            TP_HISTORIAL.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(TXT_FILTRO_PRODUCTO);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(24, 10);
            materialCard3.Margin = new Padding(12, 10, 12, 10);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(12, 10, 12, 10);
            materialCard3.Size = new Size(395, 46);
            materialCard3.TabIndex = 4;
            // 
            // TXT_FILTRO_PRODUCTO
            // 
            TXT_FILTRO_PRODUCTO.AnimateReadOnly = false;
            TXT_FILTRO_PRODUCTO.BackgroundImageLayout = ImageLayout.None;
            TXT_FILTRO_PRODUCTO.CharacterCasing = CharacterCasing.Normal;
            TXT_FILTRO_PRODUCTO.Depth = 0;
            TXT_FILTRO_PRODUCTO.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_FILTRO_PRODUCTO.HideSelection = true;
            TXT_FILTRO_PRODUCTO.LeadingIcon = null;
            TXT_FILTRO_PRODUCTO.Location = new Point(15, 2);
            TXT_FILTRO_PRODUCTO.Margin = new Padding(3, 2, 3, 2);
            TXT_FILTRO_PRODUCTO.MaxLength = 32767;
            TXT_FILTRO_PRODUCTO.MouseState = MaterialSkin.MouseState.OUT;
            TXT_FILTRO_PRODUCTO.Name = "TXT_FILTRO_PRODUCTO";
            TXT_FILTRO_PRODUCTO.PasswordChar = '\0';
            TXT_FILTRO_PRODUCTO.PrefixSuffixText = null;
            TXT_FILTRO_PRODUCTO.ReadOnly = false;
            TXT_FILTRO_PRODUCTO.RightToLeft = RightToLeft.No;
            TXT_FILTRO_PRODUCTO.SelectedText = "";
            TXT_FILTRO_PRODUCTO.SelectionLength = 0;
            TXT_FILTRO_PRODUCTO.SelectionStart = 0;
            TXT_FILTRO_PRODUCTO.ShortcutsEnabled = true;
            TXT_FILTRO_PRODUCTO.Size = new Size(367, 48);
            TXT_FILTRO_PRODUCTO.TabIndex = 3;
            TXT_FILTRO_PRODUCTO.TabStop = false;
            TXT_FILTRO_PRODUCTO.TextAlign = HorizontalAlignment.Left;
            TXT_FILTRO_PRODUCTO.TrailingIcon = null;
            TXT_FILTRO_PRODUCTO.UseSystemPasswordChar = false;
            // 
            // BTN_FILTRAR
            // 
            BTN_FILTRAR.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_FILTRAR.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_FILTRAR.Depth = 0;
            BTN_FILTRAR.HighEmphasis = true;
            BTN_FILTRAR.Icon = null;
            BTN_FILTRAR.Location = new Point(434, 22);
            BTN_FILTRAR.Margin = new Padding(4);
            BTN_FILTRAR.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_FILTRAR.Name = "BTN_FILTRAR";
            BTN_FILTRAR.NoAccentTextColor = Color.Empty;
            BTN_FILTRAR.Size = new Size(79, 36);
            BTN_FILTRAR.TabIndex = 2;
            BTN_FILTRAR.Text = "Filtrar";
            BTN_FILTRAR.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_FILTRAR.UseAccentColor = false;
            BTN_FILTRAR.UseVisualStyleBackColor = true;
            BTN_FILTRAR.Click += BTN_FILTRAR_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(DVC_HISTORIAL);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(9, 61);
            materialCard2.Margin = new Padding(12, 10, 12, 10);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(12, 10, 12, 10);
            materialCard2.Size = new Size(863, 306);
            materialCard2.TabIndex = 0;
            // 
            // DVC_HISTORIAL
            // 
            DVC_HISTORIAL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVC_HISTORIAL.Location = new Point(15, 13);
            DVC_HISTORIAL.Margin = new Padding(3, 2, 3, 2);
            DVC_HISTORIAL.Name = "DVC_HISTORIAL";
            DVC_HISTORIAL.RowHeadersWidth = 51;
            DVC_HISTORIAL.Size = new Size(833, 280);
            DVC_HISTORIAL.TabIndex = 0;
            // 
            // FRM_PRODUCTOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 693);
            Controls.Add(MTBC_MENU);
            DrawerTabControl = MTBC_MENU;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FRM_PRODUCTOS";
            Padding = new Padding(3, 48, 3, 2);
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
            TP_INSERTAR.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            TP_HISTORIAL.ResumeLayout(false);
            TP_HISTORIAL.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DVC_HISTORIAL).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel LBL_EXISTENCIA;
        private MaterialSkin.Controls.MaterialComboBox CBX_CATEGORIA;
        private MaterialSkin.Controls.MaterialLabel LBL_CATEGORIA;
        private MaterialSkin.Controls.MaterialLabel LBL_ISV;
        private MaterialSkin.Controls.MaterialTextBox TXT_PC;
        private MaterialSkin.Controls.MaterialLabel LBL_PC;
        private MaterialSkin.Controls.MaterialTextBox TXT_PU;
        private MaterialSkin.Controls.MaterialLabel LBL_PU;
        private MaterialSkin.Controls.MaterialTextBox TXT_EXISTENCIA;
        private MaterialSkin.Controls.MaterialButton BTN_WARD;
        private MaterialSkin.Controls.MaterialButton BTN_CANCEL;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtDescripcion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigoBarra;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cmbCaregorias;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioCompleto;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioUnitario;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private TabPage TP_HISTORIAL;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private DataGridView DVC_HISTORIAL;
        private MaterialSkin.Controls.MaterialButton BTN_FILTRAR;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_FILTRO_PRODUCTO;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialComboBox CBX_TIPOISV;
        private MaterialSkin.Controls.MaterialComboBox cmbTiposISV;
        private MaterialSkin.Controls.MaterialLabel lblExistencia;
        private MaterialSkin.Controls.MaterialTextBox2 txtExistencia;
        private MaterialSkin.Controls.MaterialTextBox TXT_DESCUENTO;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 txtDescuento;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
    }
}