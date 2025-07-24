namespace Prototipo_MarZel.Formularios
{
    partial class FRM_GESTIONAR_COMPRA
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
            txtCodigoBarra = new MaterialSkin.Controls.MaterialTextBox();
            txtDescripcion = new MaterialSkin.Controls.MaterialTextBox();
            txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            txtCosto = new MaterialSkin.Controls.MaterialTextBox();
            txtPrecioCompleto = new MaterialSkin.Controls.MaterialTextBox();
            txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            txtImporte = new MaterialSkin.Controls.MaterialTextBox();
            txtPrecioUnitario = new MaterialSkin.Controls.MaterialTextBox();
            cmbTiposISV = new MaterialSkin.Controls.MaterialComboBox();
            cmbCategorias = new MaterialSkin.Controls.MaterialComboBox();
            dgvDetallesCompra = new DataGridView();
            txtAgregarDetalle = new MaterialSkin.Controls.MaterialButton();
            txtSubtotal = new MaterialSkin.Controls.MaterialTextBox();
            txtGravado = new MaterialSkin.Controls.MaterialTextBox();
            txtExento = new MaterialSkin.Controls.MaterialTextBox();
            txtISV = new MaterialSkin.Controls.MaterialTextBox();
            txtTotal = new MaterialSkin.Controls.MaterialTextBox();
            btnRTN = new MaterialSkin.Controls.MaterialButton();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            txtFactura = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesCompra).BeginInit();
            SuspendLayout();
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.AnimateReadOnly = false;
            txtCodigoBarra.BorderStyle = BorderStyle.None;
            txtCodigoBarra.Depth = 0;
            txtCodigoBarra.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigoBarra.Hint = "Código de Barra";
            txtCodigoBarra.LeadingIcon = null;
            txtCodigoBarra.Location = new Point(32, 221);
            txtCodigoBarra.MaxLength = 50;
            txtCodigoBarra.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigoBarra.Multiline = false;
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(100, 50);
            txtCodigoBarra.TabIndex = 0;
            txtCodigoBarra.Text = "";
            txtCodigoBarra.TrailingIcon = null;
            txtCodigoBarra.TextChanged += txtCodigoBarra_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AnimateReadOnly = false;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Depth = 0;
            txtDescripcion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescripcion.Hint = "Descripción";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(148, 221);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            txtDescripcion.Multiline = false;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 50);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.Text = "";
            txtDescripcion.TrailingIcon = null;
            // 
            // txtCantidad
            // 
            txtCantidad.AnimateReadOnly = false;
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Depth = 0;
            txtCantidad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidad.Hint = "Cantidad";
            txtCantidad.LeadingIcon = null;
            txtCantidad.Location = new Point(32, 289);
            txtCantidad.MaxLength = 50;
            txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidad.Multiline = false;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 50);
            txtCantidad.TabIndex = 2;
            txtCantidad.Text = "";
            txtCantidad.TrailingIcon = null;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtCosto
            // 
            txtCosto.AnimateReadOnly = false;
            txtCosto.BorderStyle = BorderStyle.None;
            txtCosto.Depth = 0;
            txtCosto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCosto.Hint = "Costo";
            txtCosto.LeadingIcon = null;
            txtCosto.Location = new Point(148, 289);
            txtCosto.MaxLength = 50;
            txtCosto.MouseState = MaterialSkin.MouseState.OUT;
            txtCosto.Multiline = false;
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 50);
            txtCosto.TabIndex = 3;
            txtCosto.Text = "";
            txtCosto.TrailingIcon = null;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // txtPrecioCompleto
            // 
            txtPrecioCompleto.AnimateReadOnly = false;
            txtPrecioCompleto.BorderStyle = BorderStyle.None;
            txtPrecioCompleto.Depth = 0;
            txtPrecioCompleto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioCompleto.Hint = "Precio Comp.";
            txtPrecioCompleto.LeadingIcon = null;
            txtPrecioCompleto.Location = new Point(32, 362);
            txtPrecioCompleto.MaxLength = 50;
            txtPrecioCompleto.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecioCompleto.Multiline = false;
            txtPrecioCompleto.Name = "txtPrecioCompleto";
            txtPrecioCompleto.Size = new Size(100, 50);
            txtPrecioCompleto.TabIndex = 4;
            txtPrecioCompleto.Text = "";
            txtPrecioCompleto.TrailingIcon = null;
            // 
            // txtDescuento
            // 
            txtDescuento.AnimateReadOnly = false;
            txtDescuento.BorderStyle = BorderStyle.None;
            txtDescuento.Depth = 0;
            txtDescuento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescuento.Hint = "Descuento";
            txtDescuento.LeadingIcon = null;
            txtDescuento.Location = new Point(264, 289);
            txtDescuento.MaxLength = 50;
            txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            txtDescuento.Multiline = false;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 50);
            txtDescuento.TabIndex = 4;
            txtDescuento.Text = "";
            txtDescuento.TrailingIcon = null;
            txtDescuento.TextChanged += txtDescuento_TextChanged;
            // 
            // txtImporte
            // 
            txtImporte.AnimateReadOnly = false;
            txtImporte.BorderStyle = BorderStyle.None;
            txtImporte.Depth = 0;
            txtImporte.Enabled = false;
            txtImporte.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImporte.Hint = "Importe";
            txtImporte.LeadingIcon = null;
            txtImporte.Location = new Point(370, 289);
            txtImporte.MaxLength = 50;
            txtImporte.MouseState = MaterialSkin.MouseState.OUT;
            txtImporte.Multiline = false;
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(100, 50);
            txtImporte.TabIndex = 5;
            txtImporte.Text = "";
            txtImporte.TrailingIcon = null;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.AnimateReadOnly = false;
            txtPrecioUnitario.BorderStyle = BorderStyle.None;
            txtPrecioUnitario.Depth = 0;
            txtPrecioUnitario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioUnitario.Hint = "Precio Unit.";
            txtPrecioUnitario.LeadingIcon = null;
            txtPrecioUnitario.Location = new Point(148, 362);
            txtPrecioUnitario.MaxLength = 50;
            txtPrecioUnitario.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecioUnitario.Multiline = false;
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(100, 50);
            txtPrecioUnitario.TabIndex = 6;
            txtPrecioUnitario.Text = "";
            txtPrecioUnitario.TrailingIcon = null;
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
            cmbTiposISV.Hint = "ISV";
            cmbTiposISV.IntegralHeight = false;
            cmbTiposISV.ItemHeight = 43;
            cmbTiposISV.Location = new Point(486, 290);
            cmbTiposISV.MaxDropDownItems = 4;
            cmbTiposISV.MouseState = MaterialSkin.MouseState.OUT;
            cmbTiposISV.Name = "cmbTiposISV";
            cmbTiposISV.Size = new Size(121, 49);
            cmbTiposISV.StartIndex = 0;
            cmbTiposISV.TabIndex = 7;
            // 
            // cmbCategorias
            // 
            cmbCategorias.AutoResize = false;
            cmbCategorias.BackColor = Color.FromArgb(255, 255, 255);
            cmbCategorias.Depth = 0;
            cmbCategorias.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCategorias.DropDownHeight = 174;
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.DropDownWidth = 121;
            cmbCategorias.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCategorias.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Hint = "Categoría";
            cmbCategorias.IntegralHeight = false;
            cmbCategorias.ItemHeight = 43;
            cmbCategorias.Location = new Point(264, 363);
            cmbCategorias.MaxDropDownItems = 4;
            cmbCategorias.MouseState = MaterialSkin.MouseState.OUT;
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(121, 49);
            cmbCategorias.StartIndex = 0;
            cmbCategorias.TabIndex = 8;
            // 
            // dgvDetallesCompra
            // 
            dgvDetallesCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesCompra.Location = new Point(685, 103);
            dgvDetallesCompra.Name = "dgvDetallesCompra";
            dgvDetallesCompra.RowHeadersWidth = 51;
            dgvDetallesCompra.Size = new Size(497, 168);
            dgvDetallesCompra.TabIndex = 9;
            // 
            // txtAgregarDetalle
            // 
            txtAgregarDetalle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtAgregarDetalle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtAgregarDetalle.Depth = 0;
            txtAgregarDetalle.HighEmphasis = true;
            txtAgregarDetalle.Icon = null;
            txtAgregarDetalle.Location = new Point(406, 376);
            txtAgregarDetalle.Margin = new Padding(4, 6, 4, 6);
            txtAgregarDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            txtAgregarDetalle.Name = "txtAgregarDetalle";
            txtAgregarDetalle.NoAccentTextColor = Color.Empty;
            txtAgregarDetalle.Size = new Size(64, 36);
            txtAgregarDetalle.TabIndex = 10;
            txtAgregarDetalle.Text = "+";
            txtAgregarDetalle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            txtAgregarDetalle.UseAccentColor = false;
            txtAgregarDetalle.UseVisualStyleBackColor = true;
            txtAgregarDetalle.Click += txtAgregarDetalle_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.AnimateReadOnly = false;
            txtSubtotal.BorderStyle = BorderStyle.None;
            txtSubtotal.Depth = 0;
            txtSubtotal.Enabled = false;
            txtSubtotal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSubtotal.Hint = "Subtotal";
            txtSubtotal.LeadingIcon = null;
            txtSubtotal.Location = new Point(32, 484);
            txtSubtotal.MaxLength = 50;
            txtSubtotal.MouseState = MaterialSkin.MouseState.OUT;
            txtSubtotal.Multiline = false;
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 50);
            txtSubtotal.TabIndex = 11;
            txtSubtotal.Text = "";
            txtSubtotal.TrailingIcon = null;
            // 
            // txtGravado
            // 
            txtGravado.AnimateReadOnly = false;
            txtGravado.BorderStyle = BorderStyle.None;
            txtGravado.Depth = 0;
            txtGravado.Enabled = false;
            txtGravado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGravado.Hint = "Gravado";
            txtGravado.LeadingIcon = null;
            txtGravado.Location = new Point(148, 484);
            txtGravado.MaxLength = 50;
            txtGravado.MouseState = MaterialSkin.MouseState.OUT;
            txtGravado.Multiline = false;
            txtGravado.Name = "txtGravado";
            txtGravado.Size = new Size(100, 50);
            txtGravado.TabIndex = 12;
            txtGravado.Text = "";
            txtGravado.TrailingIcon = null;
            // 
            // txtExento
            // 
            txtExento.AnimateReadOnly = false;
            txtExento.BorderStyle = BorderStyle.None;
            txtExento.Depth = 0;
            txtExento.Enabled = false;
            txtExento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExento.Hint = "Exento";
            txtExento.LeadingIcon = null;
            txtExento.Location = new Point(264, 483);
            txtExento.MaxLength = 50;
            txtExento.MouseState = MaterialSkin.MouseState.OUT;
            txtExento.Multiline = false;
            txtExento.Name = "txtExento";
            txtExento.Size = new Size(100, 50);
            txtExento.TabIndex = 13;
            txtExento.Text = "";
            txtExento.TrailingIcon = null;
            // 
            // txtISV
            // 
            txtISV.AnimateReadOnly = false;
            txtISV.BorderStyle = BorderStyle.None;
            txtISV.Depth = 0;
            txtISV.Enabled = false;
            txtISV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtISV.Hint = "I.S.V.";
            txtISV.LeadingIcon = null;
            txtISV.Location = new Point(370, 483);
            txtISV.MaxLength = 50;
            txtISV.MouseState = MaterialSkin.MouseState.OUT;
            txtISV.Multiline = false;
            txtISV.Name = "txtISV";
            txtISV.Size = new Size(100, 50);
            txtISV.TabIndex = 14;
            txtISV.Text = "";
            txtISV.TrailingIcon = null;
            // 
            // txtTotal
            // 
            txtTotal.AnimateReadOnly = false;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Depth = 0;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotal.Hint = "Total";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(476, 484);
            txtTotal.MaxLength = 50;
            txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            txtTotal.Multiline = false;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 50);
            txtTotal.TabIndex = 15;
            txtTotal.Text = "";
            txtTotal.TrailingIcon = null;
            // 
            // btnRTN
            // 
            btnRTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRTN.Depth = 0;
            btnRTN.HighEmphasis = true;
            btnRTN.Icon = null;
            btnRTN.Location = new Point(22, 131);
            btnRTN.Margin = new Padding(4, 6, 4, 6);
            btnRTN.MouseState = MaterialSkin.MouseState.HOVER;
            btnRTN.Name = "btnRTN";
            btnRTN.NoAccentTextColor = Color.Empty;
            btnRTN.Size = new Size(64, 36);
            btnRTN.TabIndex = 16;
            btnRTN.Text = "☺";
            btnRTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRTN.UseAccentColor = false;
            btnRTN.UseVisualStyleBackColor = true;
            btnRTN.Click += btnRTN_Click;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.Hint = "Nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(93, 123);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 50);
            txtNombre.TabIndex = 17;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(554, 136);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(96, 23);
            dtpFecha.TabIndex = 18;
            dtpFecha.Value = new DateTime(2025, 7, 21, 11, 24, 57, 0);
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(594, 497);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtFactura
            // 
            txtFactura.AnimateReadOnly = false;
            txtFactura.BorderStyle = BorderStyle.None;
            txtFactura.Depth = 0;
            txtFactura.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFactura.Hint = "No. Factura";
            txtFactura.LeadingIcon = null;
            txtFactura.Location = new Point(395, 123);
            txtFactura.MaxLength = 50;
            txtFactura.MouseState = MaterialSkin.MouseState.OUT;
            txtFactura.Multiline = false;
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(153, 50);
            txtFactura.TabIndex = 20;
            txtFactura.Text = "";
            txtFactura.TrailingIcon = null;
            // 
            // FRM_GESTIONAR_COMPRA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
            Controls.Add(txtFactura);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(txtNombre);
            Controls.Add(btnRTN);
            Controls.Add(txtTotal);
            Controls.Add(txtISV);
            Controls.Add(txtExento);
            Controls.Add(txtGravado);
            Controls.Add(txtSubtotal);
            Controls.Add(txtAgregarDetalle);
            Controls.Add(dgvDetallesCompra);
            Controls.Add(cmbCategorias);
            Controls.Add(cmbTiposISV);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtImporte);
            Controls.Add(txtDescuento);
            Controls.Add(txtPrecioCompleto);
            Controls.Add(txtCosto);
            Controls.Add(txtCantidad);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigoBarra);
            MaximizeBox = false;
            Name = "FRM_GESTIONAR_COMPRA";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_GESTIONAR_COMPRA";
            WindowState = FormWindowState.Maximized;
            Load += FRM_GESTIONAR_COMPRA_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtCodigoBarra;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialTextBox txtCosto;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioCompleto;
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioUnitario;
        private MaterialSkin.Controls.MaterialComboBox cmbTiposISV;
        private MaterialSkin.Controls.MaterialComboBox cmbCategorias;
        private DataGridView dgvDetallesCompra;
        private MaterialSkin.Controls.MaterialButton txtAgregarDetalle;
        private MaterialSkin.Controls.MaterialTextBox txtSubtotal;
        private MaterialSkin.Controls.MaterialTextBox txtGravado;
        private MaterialSkin.Controls.MaterialTextBox txtExento;
        private MaterialSkin.Controls.MaterialTextBox txtISV;
        private MaterialSkin.Controls.MaterialTextBox txtTotal;
        private MaterialSkin.Controls.MaterialTextBox txtImporte;
        private MaterialSkin.Controls.MaterialButton btnRTN;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox txtFactura;
    }
}