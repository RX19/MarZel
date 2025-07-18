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
            txtCodigoBarra.Location = new Point(22, 86);
            txtCodigoBarra.MaxLength = 50;
            txtCodigoBarra.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigoBarra.Multiline = false;
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(100, 50);
            txtCodigoBarra.TabIndex = 0;
            txtCodigoBarra.Text = "";
            txtCodigoBarra.TrailingIcon = null;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AnimateReadOnly = false;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Depth = 0;
            txtDescripcion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescripcion.Hint = "Descripción";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(138, 86);
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
            txtCantidad.Location = new Point(22, 154);
            txtCantidad.MaxLength = 50;
            txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidad.Multiline = false;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 50);
            txtCantidad.TabIndex = 2;
            txtCantidad.Text = "";
            txtCantidad.TrailingIcon = null;
            // 
            // txtCosto
            // 
            txtCosto.AnimateReadOnly = false;
            txtCosto.BorderStyle = BorderStyle.None;
            txtCosto.Depth = 0;
            txtCosto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCosto.Hint = "Costo";
            txtCosto.LeadingIcon = null;
            txtCosto.Location = new Point(138, 154);
            txtCosto.MaxLength = 50;
            txtCosto.MouseState = MaterialSkin.MouseState.OUT;
            txtCosto.Multiline = false;
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 50);
            txtCosto.TabIndex = 3;
            txtCosto.Text = "";
            txtCosto.TrailingIcon = null;
            // 
            // txtPrecioCompleto
            // 
            txtPrecioCompleto.AnimateReadOnly = false;
            txtPrecioCompleto.BorderStyle = BorderStyle.None;
            txtPrecioCompleto.Depth = 0;
            txtPrecioCompleto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioCompleto.Hint = "Precio Comp.";
            txtPrecioCompleto.LeadingIcon = null;
            txtPrecioCompleto.Location = new Point(22, 227);
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
            txtDescuento.Location = new Point(254, 154);
            txtDescuento.MaxLength = 50;
            txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            txtDescuento.Multiline = false;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 50);
            txtDescuento.TabIndex = 4;
            txtDescuento.Text = "";
            txtDescuento.TrailingIcon = null;
            // 
            // txtImporte
            // 
            txtImporte.AnimateReadOnly = false;
            txtImporte.BorderStyle = BorderStyle.None;
            txtImporte.Depth = 0;
            txtImporte.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImporte.Hint = "Importe";
            txtImporte.LeadingIcon = null;
            txtImporte.Location = new Point(360, 154);
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
            txtPrecioUnitario.Location = new Point(138, 227);
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
            cmbTiposISV.Location = new Point(476, 155);
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
            cmbCategorias.Location = new Point(254, 228);
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
            dgvDetallesCompra.Location = new Point(608, 79);
            dgvDetallesCompra.Name = "dgvDetallesCompra";
            dgvDetallesCompra.Size = new Size(183, 168);
            dgvDetallesCompra.TabIndex = 9;
            // 
            // txtAgregarDetalle
            // 
            txtAgregarDetalle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtAgregarDetalle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtAgregarDetalle.Depth = 0;
            txtAgregarDetalle.HighEmphasis = true;
            txtAgregarDetalle.Icon = null;
            txtAgregarDetalle.Location = new Point(396, 241);
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
            // 
            // txtSubtotal
            // 
            txtSubtotal.AnimateReadOnly = false;
            txtSubtotal.BorderStyle = BorderStyle.None;
            txtSubtotal.Depth = 0;
            txtSubtotal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSubtotal.Hint = "Subtotal";
            txtSubtotal.LeadingIcon = null;
            txtSubtotal.Location = new Point(22, 327);
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
            txtGravado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGravado.Hint = "Gravado";
            txtGravado.LeadingIcon = null;
            txtGravado.Location = new Point(138, 327);
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
            txtExento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExento.Hint = "Exento";
            txtExento.LeadingIcon = null;
            txtExento.Location = new Point(254, 326);
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
            txtISV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtISV.Hint = "I.S.V.";
            txtISV.LeadingIcon = null;
            txtISV.Location = new Point(360, 326);
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
            txtTotal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotal.Hint = "Total";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(466, 327);
            txtTotal.MaxLength = 50;
            txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            txtTotal.Multiline = false;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 50);
            txtTotal.TabIndex = 15;
            txtTotal.Text = "";
            txtTotal.TrailingIcon = null;
            // 
            // FRM_GESTIONAR_COMPRA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 700);
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
        private MaterialSkin.Controls.MaterialTextBox txtImporte;
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
    }
}