namespace Prototipo_MarZel.Formularios
{
    partial class FRM_GESTIONAR_VENTA
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtFactura = new MaterialSkin.Controls.MaterialTextBox();
            dtpFecha = new DateTimePicker();
            txtRTN = new MaterialSkin.Controls.MaterialTextBox();
            btnRTN = new MaterialSkin.Controls.MaterialButton();
            dgvDetallesVenta = new DataGridView();
            Editar = new DataGridViewLinkColumn();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            txtCodigoBarra = new MaterialSkin.Controls.MaterialTextBox();
            btnEliminar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            txtTotal = new MaterialSkin.Controls.MaterialTextBox();
            txtISV = new MaterialSkin.Controls.MaterialTextBox();
            txtExento = new MaterialSkin.Controls.MaterialTextBox();
            txtGravado = new MaterialSkin.Controls.MaterialTextBox();
            txtSubtotal = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).BeginInit();
            SuspendLayout();
            // 
            // txtFactura
            // 
            txtFactura.AnimateReadOnly = false;
            txtFactura.BorderStyle = BorderStyle.None;
            txtFactura.Depth = 0;
            txtFactura.Enabled = false;
            txtFactura.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFactura.Hint = "No. Factura";
            txtFactura.LeadingIcon = null;
            txtFactura.Location = new Point(338, 133);
            txtFactura.MaxLength = 50;
            txtFactura.MouseState = MaterialSkin.MouseState.OUT;
            txtFactura.Multiline = false;
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(215, 50);
            txtFactura.TabIndex = 27;
            txtFactura.Text = "";
            txtFactura.TrailingIcon = null;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(458, 95);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(95, 23);
            dtpFecha.TabIndex = 26;
            dtpFecha.Value = new DateTime(2025, 7, 21, 11, 24, 57, 0);
            // 
            // txtRTN
            // 
            txtRTN.AnimateReadOnly = false;
            txtRTN.BorderStyle = BorderStyle.None;
            txtRTN.Depth = 0;
            txtRTN.Enabled = false;
            txtRTN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRTN.Hint = "R.T.N.";
            txtRTN.LeadingIcon = null;
            txtRTN.Location = new Point(103, 133);
            txtRTN.MaxLength = 50;
            txtRTN.MouseState = MaterialSkin.MouseState.OUT;
            txtRTN.Multiline = false;
            txtRTN.Name = "txtRTN";
            txtRTN.Size = new Size(229, 50);
            txtRTN.TabIndex = 25;
            txtRTN.Text = "";
            txtRTN.TrailingIcon = null;
            // 
            // btnRTN
            // 
            btnRTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRTN.Depth = 0;
            btnRTN.HighEmphasis = true;
            btnRTN.Icon = null;
            btnRTN.Location = new Point(23, 140);
            btnRTN.Margin = new Padding(4, 6, 4, 6);
            btnRTN.MouseState = MaterialSkin.MouseState.HOVER;
            btnRTN.Name = "btnRTN";
            btnRTN.NoAccentTextColor = Color.Empty;
            btnRTN.Size = new Size(64, 36);
            btnRTN.TabIndex = 24;
            btnRTN.Text = "☺";
            btnRTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRTN.UseAccentColor = false;
            btnRTN.UseVisualStyleBackColor = true;
            btnRTN.Click += btnRTN_Click;
            // 
            // dgvDetallesVenta
            // 
            dgvDetallesVenta.AllowUserToAddRows = false;
            dgvDetallesVenta.AllowUserToDeleteRows = false;
            dgvDetallesVenta.AllowUserToResizeColumns = false;
            dgvDetallesVenta.AllowUserToResizeRows = false;
            dgvDetallesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesVenta.BackgroundColor = SystemColors.InactiveCaption;
            dgvDetallesVenta.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetallesVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetallesVenta.Columns.AddRange(new DataGridViewColumn[] { Editar });
            dgvDetallesVenta.Location = new Point(568, 95);
            dgvDetallesVenta.Name = "dgvDetallesVenta";
            dgvDetallesVenta.ReadOnly = true;
            dgvDetallesVenta.RowHeadersVisible = false;
            dgvDetallesVenta.RowHeadersWidth = 51;
            dgvDetallesVenta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallesVenta.Size = new Size(750, 168);
            dgvDetallesVenta.TabIndex = 23;
            dgvDetallesVenta.CellContentClick += dgvDetallesVenta_CellContentClick;
            // 
            // Editar
            // 
            Editar.ActiveLinkColor = SystemColors.ControlText;
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForLinkValue = true;
            Editar.Width = 50;
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
            txtNombre.Location = new Point(23, 189);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(279, 50);
            txtNombre.TabIndex = 22;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.AnimateReadOnly = false;
            txtCodigoBarra.BorderStyle = BorderStyle.None;
            txtCodigoBarra.Depth = 0;
            txtCodigoBarra.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigoBarra.Hint = "Código de Barra";
            txtCodigoBarra.LeadingIcon = null;
            txtCodigoBarra.Location = new Point(308, 189);
            txtCodigoBarra.MaxLength = 50;
            txtCodigoBarra.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigoBarra.Multiline = false;
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(245, 50);
            txtCodigoBarra.TabIndex = 21;
            txtCodigoBarra.Text = "";
            txtCodigoBarra.TrailingIcon = null;
            txtCodigoBarra.TextChanged += txtCodigoBarra_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminar.Depth = 0;
            btnEliminar.HighEmphasis = true;
            btnEliminar.Icon = null;
            btnEliminar.Location = new Point(149, 427);
            btnEliminar.Margin = new Padding(4, 6, 4, 6);
            btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.NoAccentTextColor = Color.Empty;
            btnEliminar.Size = new Size(88, 36);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "ELIMINAR";
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
            btnGuardar.Location = new Point(34, 427);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            txtTotal.Location = new Point(264, 413);
            txtTotal.MaxLength = 50;
            txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            txtTotal.Multiline = false;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(215, 50);
            txtTotal.TabIndex = 32;
            txtTotal.Text = "";
            txtTotal.TrailingIcon = null;
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
            txtISV.Location = new Point(379, 344);
            txtISV.MaxLength = 50;
            txtISV.MouseState = MaterialSkin.MouseState.OUT;
            txtISV.Multiline = false;
            txtISV.Name = "txtISV";
            txtISV.Size = new Size(100, 50);
            txtISV.TabIndex = 31;
            txtISV.Text = "";
            txtISV.TrailingIcon = null;
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
            txtExento.Location = new Point(264, 344);
            txtExento.MaxLength = 50;
            txtExento.MouseState = MaterialSkin.MouseState.OUT;
            txtExento.Multiline = false;
            txtExento.Name = "txtExento";
            txtExento.Size = new Size(100, 50);
            txtExento.TabIndex = 30;
            txtExento.Text = "";
            txtExento.TrailingIcon = null;
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
            txtGravado.Location = new Point(149, 344);
            txtGravado.MaxLength = 50;
            txtGravado.MouseState = MaterialSkin.MouseState.OUT;
            txtGravado.Multiline = false;
            txtGravado.Name = "txtGravado";
            txtGravado.Size = new Size(100, 50);
            txtGravado.TabIndex = 29;
            txtGravado.Text = "";
            txtGravado.TrailingIcon = null;
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
            txtSubtotal.Location = new Point(34, 344);
            txtSubtotal.MaxLength = 50;
            txtSubtotal.MouseState = MaterialSkin.MouseState.OUT;
            txtSubtotal.Multiline = false;
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 50);
            txtSubtotal.TabIndex = 28;
            txtSubtotal.Text = "";
            txtSubtotal.TrailingIcon = null;
            // 
            // FRM_GESTIONAR_VENTA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 641);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTotal);
            Controls.Add(txtISV);
            Controls.Add(txtExento);
            Controls.Add(txtGravado);
            Controls.Add(txtSubtotal);
            Controls.Add(txtFactura);
            Controls.Add(dtpFecha);
            Controls.Add(txtRTN);
            Controls.Add(btnRTN);
            Controls.Add(dgvDetallesVenta);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigoBarra);
            MaximizeBox = false;
            Name = "FRM_GESTIONAR_VENTA";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_GESTIONAR_VENTA";
            WindowState = FormWindowState.Maximized;
            Load += FRM_GESTIONAR_VENTA_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtFactura;
        private DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialTextBox txtRTN;
        private MaterialSkin.Controls.MaterialButton btnRTN;
        private DataGridView dgvDetallesVenta;
        private DataGridViewLinkColumn Editar;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoBarra;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox txtTotal;
        private MaterialSkin.Controls.MaterialTextBox txtISV;
        private MaterialSkin.Controls.MaterialTextBox txtExento;
        private MaterialSkin.Controls.MaterialTextBox txtGravado;
        private MaterialSkin.Controls.MaterialTextBox txtSubtotal;
    }
}