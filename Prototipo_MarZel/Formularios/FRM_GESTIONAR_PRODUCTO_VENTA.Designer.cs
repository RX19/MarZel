namespace Prototipo_MarZel.Formularios
{
    partial class FRM_GESTIONAR_PRODUCTO_VENTA
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
            cmbTiposISV = new MaterialSkin.Controls.MaterialComboBox();
            txtDescripcion = new MaterialSkin.Controls.MaterialTextBox();
            txtCodigoBarra = new MaterialSkin.Controls.MaterialTextBox();
            txtImporte = new MaterialSkin.Controls.MaterialTextBox();
            txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            txtPrecio = new MaterialSkin.Controls.MaterialTextBox();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            optPrecioCompleto = new MaterialSkin.Controls.MaterialRadioButton();
            optPrecioUnitario = new MaterialSkin.Controls.MaterialRadioButton();
            label1 = new Label();
            SuspendLayout();
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
            cmbTiposISV.Enabled = false;
            cmbTiposISV.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbTiposISV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbTiposISV.FormattingEnabled = true;
            cmbTiposISV.Hint = "Tipo de ISV";
            cmbTiposISV.IntegralHeight = false;
            cmbTiposISV.ItemHeight = 43;
            cmbTiposISV.Location = new Point(639, 167);
            cmbTiposISV.Margin = new Padding(4, 5, 4, 5);
            cmbTiposISV.MaxDropDownItems = 4;
            cmbTiposISV.MouseState = MaterialSkin.MouseState.OUT;
            cmbTiposISV.Name = "cmbTiposISV";
            cmbTiposISV.Size = new Size(213, 49);
            cmbTiposISV.StartIndex = 0;
            cmbTiposISV.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AnimateReadOnly = false;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Depth = 0;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescripcion.Hint = "Descripción";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(339, 168);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            txtDescripcion.Multiline = false;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(257, 50);
            txtDescripcion.TabIndex = 11;
            txtDescripcion.Text = "";
            txtDescripcion.TrailingIcon = null;
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.AnimateReadOnly = false;
            txtCodigoBarra.BorderStyle = BorderStyle.None;
            txtCodigoBarra.Depth = 0;
            txtCodigoBarra.Enabled = false;
            txtCodigoBarra.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigoBarra.Hint = "Código de Barra";
            txtCodigoBarra.LeadingIcon = null;
            txtCodigoBarra.Location = new Point(99, 168);
            txtCodigoBarra.Margin = new Padding(4, 5, 4, 5);
            txtCodigoBarra.MaxLength = 50;
            txtCodigoBarra.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigoBarra.Multiline = false;
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(214, 50);
            txtCodigoBarra.TabIndex = 10;
            txtCodigoBarra.Text = "";
            txtCodigoBarra.TrailingIcon = null;
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
            txtImporte.Location = new Point(681, 355);
            txtImporte.Margin = new Padding(4, 5, 4, 5);
            txtImporte.MaxLength = 50;
            txtImporte.MouseState = MaterialSkin.MouseState.OUT;
            txtImporte.Multiline = false;
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(171, 50);
            txtImporte.TabIndex = 13;
            txtImporte.Text = "";
            txtImporte.TrailingIcon = null;
            // 
            // txtDescuento
            // 
            txtDescuento.AnimateReadOnly = false;
            txtDescuento.BorderStyle = BorderStyle.None;
            txtDescuento.Depth = 0;
            txtDescuento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescuento.Hint = "Descuento";
            txtDescuento.LeadingIcon = null;
            txtDescuento.Location = new Point(99, 355);
            txtDescuento.Margin = new Padding(4, 5, 4, 5);
            txtDescuento.MaxLength = 50;
            txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            txtDescuento.Multiline = false;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(171, 50);
            txtDescuento.TabIndex = 15;
            txtDescuento.Text = "";
            txtDescuento.TrailingIcon = null;
            txtDescuento.TextChanged += txtDescuento_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.AnimateReadOnly = false;
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Depth = 0;
            txtCantidad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidad.Hint = "Cantidad";
            txtCantidad.LeadingIcon = null;
            txtCantidad.Location = new Point(99, 262);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.MaxLength = 50;
            txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidad.Multiline = false;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(171, 50);
            txtCantidad.TabIndex = 14;
            txtCantidad.Text = "";
            txtCantidad.TrailingIcon = null;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.AnimateReadOnly = false;
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Depth = 0;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecio.Hint = "Precio";
            txtPrecio.LeadingIcon = null;
            txtPrecio.Location = new Point(681, 262);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.MaxLength = 50;
            txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecio.Multiline = false;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(171, 50);
            txtPrecio.TabIndex = 16;
            txtPrecio.Text = "";
            txtPrecio.TrailingIcon = null;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(217, 477);
            btnEliminar.Margin = new Padding(6, 10, 6, 10);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(88, 36);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminar.UseAccentColor = false;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(550, 477);
            btnGuardar.Margin = new Padding(6, 10, 6, 10);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(157, 36);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // optPrecioCompleto
            // 
            optPrecioCompleto.AutoSize = true;
            optPrecioCompleto.Depth = 0;
            optPrecioCompleto.FlatStyle = FlatStyle.System;
            optPrecioCompleto.Location = new Point(339, 293);
            optPrecioCompleto.Margin = new Padding(0);
            optPrecioCompleto.MouseLocation = new Point(-1, -1);
            optPrecioCompleto.MouseState = MaterialSkin.MouseState.HOVER;
            optPrecioCompleto.Name = "optPrecioCompleto";
            optPrecioCompleto.Ripple = true;
            optPrecioCompleto.Size = new Size(151, 37);
            optPrecioCompleto.TabIndex = 19;
            optPrecioCompleto.TabStop = true;
            optPrecioCompleto.Text = "Precio Completo";
            optPrecioCompleto.UseVisualStyleBackColor = true;
            optPrecioCompleto.CheckedChanged += optPrecioCompleto_CheckedChanged;
            // 
            // optPrecioUnitario
            // 
            optPrecioUnitario.AutoSize = true;
            optPrecioUnitario.Depth = 0;
            optPrecioUnitario.FlatStyle = FlatStyle.System;
            optPrecioUnitario.Location = new Point(339, 347);
            optPrecioUnitario.Margin = new Padding(0);
            optPrecioUnitario.MouseLocation = new Point(-1, -1);
            optPrecioUnitario.MouseState = MaterialSkin.MouseState.HOVER;
            optPrecioUnitario.Name = "optPrecioUnitario";
            optPrecioUnitario.Ripple = true;
            optPrecioUnitario.Size = new Size(138, 37);
            optPrecioUnitario.TabIndex = 20;
            optPrecioUnitario.TabStop = true;
            optPrecioUnitario.Text = "Precio Unitario";
            optPrecioUnitario.UseVisualStyleBackColor = true;
            optPrecioUnitario.CheckedChanged += optPrecioUnitario_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 268);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 21;
            label1.Text = "Seleccione un Precio:";
            // 
            // FRM_GESTIONAR_PRODUCTO_VENTA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 583);
            Controls.Add(label1);
            Controls.Add(optPrecioUnitario);
            Controls.Add(optPrecioCompleto);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescuento);
            Controls.Add(txtCantidad);
            Controls.Add(txtImporte);
            Controls.Add(cmbTiposISV);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigoBarra);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(971, 583);
            MinimumSize = new Size(971, 583);
            Name = "FRM_GESTIONAR_PRODUCTO_VENTA";
            Padding = new Padding(4, 107, 4, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Producto";
            Load += FRM_GESTIONAR_PRODUCTO_VENTA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbTiposISV;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoBarra;
        private MaterialSkin.Controls.MaterialTextBox txtImporte;
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private MaterialSkin.Controls.MaterialTextBox txtPrecio;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialRadioButton optPrecioCompleto;
        private MaterialSkin.Controls.MaterialRadioButton optPrecioUnitario;
        private Label label1;
    }
}