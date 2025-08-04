namespace Prototipo_MarZel.Formularios
{
    partial class FRM_GESTIONAR_PRODUCTO_COMPRA
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
            txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            txtImporte = new MaterialSkin.Controls.MaterialTextBox();
            txtPrecioCompleto = new MaterialSkin.Controls.MaterialTextBox();
            txtPrecioUnitario = new MaterialSkin.Controls.MaterialTextBox();
            cmbTiposISV = new MaterialSkin.Controls.MaterialComboBox();
            cmbCategorias = new MaterialSkin.Controls.MaterialComboBox();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
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
            txtCodigoBarra.Location = new Point(80, 145);
            txtCodigoBarra.Margin = new Padding(4, 5, 4, 5);
            txtCodigoBarra.MaxLength = 50;
            txtCodigoBarra.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigoBarra.Multiline = false;
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(294, 50);
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
            txtDescripcion.Location = new Point(383, 145);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            txtDescripcion.Multiline = false;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(494, 50);
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
            txtCantidad.Location = new Point(80, 243);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.MaxLength = 50;
            txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidad.Multiline = false;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(143, 50);
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
            txtCosto.Location = new Point(231, 243);
            txtCosto.Margin = new Padding(4, 5, 4, 5);
            txtCosto.MaxLength = 50;
            txtCosto.MouseState = MaterialSkin.MouseState.OUT;
            txtCosto.Multiline = false;
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(143, 50);
            txtCosto.TabIndex = 3;
            txtCosto.Text = "";
            txtCosto.TrailingIcon = null;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // txtDescuento
            // 
            txtDescuento.AnimateReadOnly = false;
            txtDescuento.BorderStyle = BorderStyle.None;
            txtDescuento.Depth = 0;
            txtDescuento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescuento.Hint = "Descuento";
            txtDescuento.LeadingIcon = null;
            txtDescuento.Location = new Point(383, 243);
            txtDescuento.Margin = new Padding(4, 5, 4, 5);
            txtDescuento.MaxLength = 50;
            txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            txtDescuento.Multiline = false;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(160, 50);
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
            txtImporte.Location = new Point(551, 243);
            txtImporte.Margin = new Padding(4, 5, 4, 5);
            txtImporte.MaxLength = 50;
            txtImporte.MouseState = MaterialSkin.MouseState.OUT;
            txtImporte.Multiline = false;
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(143, 50);
            txtImporte.TabIndex = 5;
            txtImporte.Text = "";
            txtImporte.TrailingIcon = null;
            // 
            // txtPrecioCompleto
            // 
            txtPrecioCompleto.AnimateReadOnly = false;
            txtPrecioCompleto.BorderStyle = BorderStyle.None;
            txtPrecioCompleto.Depth = 0;
            txtPrecioCompleto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioCompleto.Hint = "Precio Comp.";
            txtPrecioCompleto.LeadingIcon = null;
            txtPrecioCompleto.Location = new Point(80, 348);
            txtPrecioCompleto.Margin = new Padding(4, 5, 4, 5);
            txtPrecioCompleto.MaxLength = 50;
            txtPrecioCompleto.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecioCompleto.Multiline = false;
            txtPrecioCompleto.Name = "txtPrecioCompleto";
            txtPrecioCompleto.Size = new Size(214, 50);
            txtPrecioCompleto.TabIndex = 7;
            txtPrecioCompleto.Text = "";
            txtPrecioCompleto.TrailingIcon = null;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.AnimateReadOnly = false;
            txtPrecioUnitario.BorderStyle = BorderStyle.None;
            txtPrecioUnitario.Depth = 0;
            txtPrecioUnitario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioUnitario.Hint = "Precio Unit.";
            txtPrecioUnitario.LeadingIcon = null;
            txtPrecioUnitario.Location = new Point(303, 348);
            txtPrecioUnitario.Margin = new Padding(4, 5, 4, 5);
            txtPrecioUnitario.MaxLength = 50;
            txtPrecioUnitario.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecioUnitario.Multiline = false;
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(240, 50);
            txtPrecioUnitario.TabIndex = 8;
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
            cmbTiposISV.Hint = "Tipo de ISV";
            cmbTiposISV.IntegralHeight = false;
            cmbTiposISV.ItemHeight = 43;
            cmbTiposISV.Location = new Point(703, 245);
            cmbTiposISV.Margin = new Padding(4, 5, 4, 5);
            cmbTiposISV.MaxDropDownItems = 4;
            cmbTiposISV.MouseState = MaterialSkin.MouseState.OUT;
            cmbTiposISV.Name = "cmbTiposISV";
            cmbTiposISV.Size = new Size(173, 49);
            cmbTiposISV.StartIndex = 0;
            cmbTiposISV.TabIndex = 9;
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
            cmbCategorias.Location = new Point(551, 350);
            cmbCategorias.Margin = new Padding(4, 5, 4, 5);
            cmbCategorias.MaxDropDownItems = 4;
            cmbCategorias.MouseState = MaterialSkin.MouseState.OUT;
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(324, 49);
            cmbCategorias.StartIndex = 0;
            cmbCategorias.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(551, 487);
            btnGuardar.Margin = new Padding(6, 10, 6, 10);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(157, 36);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(149, 487);
            btnEliminar.Margin = new Padding(6, 10, 6, 10);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(88, 36);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FRM_GESTIONAR_PRODUCTO_COMPRA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 583);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCategorias);
            Controls.Add(cmbTiposISV);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtPrecioCompleto);
            Controls.Add(txtImporte);
            Controls.Add(txtDescuento);
            Controls.Add(txtCosto);
            Controls.Add(txtCantidad);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigoBarra);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(971, 583);
            MinimumSize = new Size(971, 583);
            Name = "FRM_GESTIONAR_PRODUCTO_COMPRA";
            Padding = new Padding(4, 107, 4, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Producto";
            Load += FRM_GESTIONAR_PRODUCTO_COMPRA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtCodigoBarra;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialTextBox txtCosto;
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialTextBox txtImporte;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioCompleto;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioUnitario;
        private MaterialSkin.Controls.MaterialComboBox cmbTiposISV;
        private MaterialSkin.Controls.MaterialComboBox cmbCategorias;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
    }
}