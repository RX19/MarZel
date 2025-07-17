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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialTextBox25 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox24 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            MTBC_MENU.SuspendLayout();
            TP_MODIFICAR.SuspendLayout();
            MC_BUSCAR.SuspendLayout();
            MC_FORM.SuspendLayout();
            MC_PANEL_DATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVC_PRODUCTOS).BeginInit();
            TP_INSERTAR.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // MTBC_MENU
            // 
            MTBC_MENU.Controls.Add(TP_MODIFICAR);
            MTBC_MENU.Controls.Add(TP_INSERTAR);
            MTBC_MENU.Depth = 0;
            MTBC_MENU.Dock = DockStyle.Fill;
            MTBC_MENU.Location = new Point(3, 48);
            MTBC_MENU.Margin = new Padding(3, 2, 3, 2);
            MTBC_MENU.MouseState = MaterialSkin.MouseState.HOVER;
            MTBC_MENU.Multiline = true;
            MTBC_MENU.Name = "MTBC_MENU";
            MTBC_MENU.SelectedIndex = 0;
            MTBC_MENU.Size = new Size(1207, 541);
            MTBC_MENU.TabIndex = 0;
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
            TP_MODIFICAR.Size = new Size(1199, 513);
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
            MC_FORM.Location = new Point(430, 116);
            MC_FORM.Margin = new Padding(12, 10, 12, 10);
            MC_FORM.MouseState = MaterialSkin.MouseState.HOVER;
            MC_FORM.Name = "MC_FORM";
            MC_FORM.Padding = new Padding(12, 10, 12, 10);
            MC_FORM.Size = new Size(1068, 446);
            MC_FORM.TabIndex = 1;
            // 
            // BTN_WARD
            // 
            BTN_WARD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_WARD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_WARD.Depth = 0;
            BTN_WARD.HighEmphasis = true;
            BTN_WARD.Icon = null;
            BTN_WARD.Location = new Point(656, 386);
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
            BTN_CANCEL.Location = new Point(340, 386);
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
            // TXT_CANTIDAD
            // 
            TXT_CANTIDAD.AnimateReadOnly = false;
            TXT_CANTIDAD.BorderStyle = BorderStyle.None;
            TXT_CANTIDAD.Depth = 0;
            TXT_CANTIDAD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_CANTIDAD.LeadingIcon = null;
            TXT_CANTIDAD.Location = new Point(110, 256);
            TXT_CANTIDAD.Margin = new Padding(3, 2, 3, 2);
            TXT_CANTIDAD.MaxLength = 50;
            TXT_CANTIDAD.MouseState = MaterialSkin.MouseState.OUT;
            TXT_CANTIDAD.Multiline = false;
            TXT_CANTIDAD.Name = "TXT_CANTIDAD";
            TXT_CANTIDAD.Size = new Size(53, 50);
            TXT_CANTIDAD.TabIndex = 9;
            TXT_CANTIDAD.Text = "";
            TXT_CANTIDAD.TrailingIcon = null;
            // 
            // LBL_CANTIDAD
            // 
            LBL_CANTIDAD.AutoSize = true;
            LBL_CANTIDAD.Depth = 0;
            LBL_CANTIDAD.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CANTIDAD.Location = new Point(16, 268);
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
            // TXT_ISV
            // 
            TXT_ISV.AnimateReadOnly = false;
            TXT_ISV.BorderStyle = BorderStyle.None;
            TXT_ISV.Depth = 0;
            TXT_ISV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_ISV.LeadingIcon = null;
            TXT_ISV.Location = new Point(110, 200);
            TXT_ISV.Margin = new Padding(3, 2, 3, 2);
            TXT_ISV.MaxLength = 50;
            TXT_ISV.MouseState = MaterialSkin.MouseState.OUT;
            TXT_ISV.Multiline = false;
            TXT_ISV.Name = "TXT_ISV";
            TXT_ISV.Size = new Size(53, 50);
            TXT_ISV.TabIndex = 5;
            TXT_ISV.Text = "";
            TXT_ISV.TrailingIcon = null;
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
            MC_PANEL_DATOS.Size = new Size(312, 509);
            MC_PANEL_DATOS.TabIndex = 0;
            // 
            // DVC_PRODUCTOS
            // 
            DVC_PRODUCTOS.BackgroundColor = SystemColors.ActiveCaption;
            DVC_PRODUCTOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVC_PRODUCTOS.Dock = DockStyle.Fill;
            DVC_PRODUCTOS.EditMode = DataGridViewEditMode.EditProgrammatically;
            DVC_PRODUCTOS.Location = new Point(12, 10);
            DVC_PRODUCTOS.Margin = new Padding(3, 2, 3, 2);
            DVC_PRODUCTOS.Name = "DVC_PRODUCTOS";
            DVC_PRODUCTOS.RowHeadersWidth = 51;
            DVC_PRODUCTOS.Size = new Size(288, 489);
            DVC_PRODUCTOS.TabIndex = 0;
            DVC_PRODUCTOS.CellContentClick += DVC_PRODUCTOS_CellContentClick;
            // 
            // TP_INSERTAR
            // 
            TP_INSERTAR.Controls.Add(materialCard1);
            TP_INSERTAR.Location = new Point(4, 24);
            TP_INSERTAR.Margin = new Padding(3, 2, 3, 2);
            TP_INSERTAR.Name = "TP_INSERTAR";
            TP_INSERTAR.Padding = new Padding(3, 2, 3, 2);
            TP_INSERTAR.Size = new Size(1199, 513);
            TP_INSERTAR.TabIndex = 1;
            TP_INSERTAR.Text = "Agregar";
            TP_INSERTAR.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialButton2);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(materialTextBox25);
            materialCard1.Controls.Add(materialLabel6);
            materialCard1.Controls.Add(materialTextBox24);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(materialComboBox1);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(materialTextBox23);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialTextBox22);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialTextBox21);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(238, 73);
            materialCard1.Margin = new Padding(12, 10, 12, 10);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(12, 10, 12, 10);
            materialCard1.Size = new Size(1078, 507);
            materialCard1.TabIndex = 0;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(628, 452);
            materialButton2.Margin = new Padding(4);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(88, 36);
            materialButton2.TabIndex = 13;
            materialButton2.Text = "GUARDAR";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(262, 452);
            materialButton1.Margin = new Padding(4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(96, 36);
            materialButton1.TabIndex = 12;
            materialButton1.Text = "CANCELAR";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialTextBox25
            // 
            materialTextBox25.AnimateReadOnly = false;
            materialTextBox25.BackgroundImageLayout = ImageLayout.None;
            materialTextBox25.CharacterCasing = CharacterCasing.Normal;
            materialTextBox25.Depth = 0;
            materialTextBox25.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox25.HideSelection = true;
            materialTextBox25.LeadingIcon = null;
            materialTextBox25.Location = new Point(620, 369);
            materialTextBox25.Margin = new Padding(3, 2, 3, 2);
            materialTextBox25.MaxLength = 32767;
            materialTextBox25.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox25.Name = "materialTextBox25";
            materialTextBox25.PasswordChar = '\0';
            materialTextBox25.PrefixSuffixText = null;
            materialTextBox25.ReadOnly = false;
            materialTextBox25.RightToLeft = RightToLeft.No;
            materialTextBox25.SelectedText = "";
            materialTextBox25.SelectionLength = 0;
            materialTextBox25.SelectionStart = 0;
            materialTextBox25.ShortcutsEnabled = true;
            materialTextBox25.Size = new Size(133, 48);
            materialTextBox25.TabIndex = 11;
            materialTextBox25.TabStop = false;
            materialTextBox25.TextAlign = HorizontalAlignment.Left;
            materialTextBox25.TrailingIcon = null;
            materialTextBox25.UseSystemPasswordChar = false;
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
            // materialTextBox24
            // 
            materialTextBox24.AnimateReadOnly = false;
            materialTextBox24.BackgroundImageLayout = ImageLayout.None;
            materialTextBox24.CharacterCasing = CharacterCasing.Normal;
            materialTextBox24.Depth = 0;
            materialTextBox24.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox24.HideSelection = true;
            materialTextBox24.LeadingIcon = null;
            materialTextBox24.Location = new Point(180, 369);
            materialTextBox24.Margin = new Padding(3, 2, 3, 2);
            materialTextBox24.MaxLength = 32767;
            materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox24.Name = "materialTextBox24";
            materialTextBox24.PasswordChar = '\0';
            materialTextBox24.PrefixSuffixText = null;
            materialTextBox24.ReadOnly = false;
            materialTextBox24.RightToLeft = RightToLeft.No;
            materialTextBox24.SelectedText = "";
            materialTextBox24.SelectionLength = 0;
            materialTextBox24.SelectionStart = 0;
            materialTextBox24.ShortcutsEnabled = true;
            materialTextBox24.Size = new Size(136, 48);
            materialTextBox24.TabIndex = 9;
            materialTextBox24.TabStop = false;
            materialTextBox24.TextAlign = HorizontalAlignment.Left;
            materialTextBox24.TrailingIcon = null;
            materialTextBox24.UseSystemPasswordChar = false;
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
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(185, 252);
            materialComboBox1.Margin = new Padding(3, 2, 3, 2);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(133, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 7;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(66, 261);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(137, 19);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Categoria Producto";
            // 
            // materialTextBox23
            // 
            materialTextBox23.AnimateReadOnly = false;
            materialTextBox23.BackgroundImageLayout = ImageLayout.None;
            materialTextBox23.CharacterCasing = CharacterCasing.Normal;
            materialTextBox23.Depth = 0;
            materialTextBox23.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox23.HideSelection = true;
            materialTextBox23.LeadingIcon = null;
            materialTextBox23.Location = new Point(185, 179);
            materialTextBox23.Margin = new Padding(3, 2, 3, 2);
            materialTextBox23.MaxLength = 32767;
            materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox23.Name = "materialTextBox23";
            materialTextBox23.PasswordChar = '\0';
            materialTextBox23.PrefixSuffixText = null;
            materialTextBox23.ReadOnly = false;
            materialTextBox23.RightToLeft = RightToLeft.No;
            materialTextBox23.SelectedText = "";
            materialTextBox23.SelectionLength = 0;
            materialTextBox23.SelectionStart = 0;
            materialTextBox23.ShortcutsEnabled = true;
            materialTextBox23.Size = new Size(150, 48);
            materialTextBox23.TabIndex = 5;
            materialTextBox23.TabStop = false;
            materialTextBox23.TextAlign = HorizontalAlignment.Left;
            materialTextBox23.TrailingIcon = null;
            materialTextBox23.UseSystemPasswordChar = false;
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
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(185, 122);
            materialTextBox22.Margin = new Padding(3, 2, 3, 2);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(853, 48);
            materialTextBox22.TabIndex = 3;
            materialTextBox22.TabStop = false;
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
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
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(185, 59);
            materialTextBox21.Margin = new Padding(3, 2, 3, 2);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(853, 48);
            materialTextBox21.TabIndex = 1;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
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
            // FRM_PRODUCTOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox25;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}