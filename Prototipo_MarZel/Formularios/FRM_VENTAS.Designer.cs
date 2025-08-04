namespace Prototipo_MarZel.Formularios
{
    partial class FRM_VENTAS
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            lblBuscar = new MaterialSkin.Controls.MaterialLabel();
            dgvVentas = new DataGridView();
            btnEditarVenta = new MaterialSkin.Controls.MaterialButton();
            btnAgregarVenta = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(500, 178);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MaxLength = 50;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(500, 50);
            txtBuscar.TabIndex = 16;
            txtBuscar.Text = "";
            txtBuscar.TrailingIcon = null;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Depth = 0;
            lblBuscar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBuscar.Location = new Point(401, 205);
            lblBuscar.Margin = new Padding(4, 0, 4, 0);
            lblBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 19);
            lblBuscar.TabIndex = 15;
            lblBuscar.Text = "Buscar:";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeColumns = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = SystemColors.InactiveCaption;
            dgvVentas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeight = 34;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.Location = new Point(71, 332);
            dgvVentas.Margin = new Padding(4, 5, 4, 5);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1714, 750);
            dgvVentas.TabIndex = 14;
            // 
            // btnEditarVenta
            // 
            btnEditarVenta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarVenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarVenta.Depth = 0;
            btnEditarVenta.HighEmphasis = true;
            btnEditarVenta.Icon = null;
            btnEditarVenta.Location = new Point(1260, 190);
            btnEditarVenta.Margin = new Padding(6, 10, 6, 10);
            btnEditarVenta.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarVenta.Name = "btnEditarVenta";
            btnEditarVenta.NoAccentTextColor = Color.Empty;
            btnEditarVenta.Size = new Size(122, 36);
            btnEditarVenta.TabIndex = 13;
            btnEditarVenta.Text = "Editar Venta";
            btnEditarVenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarVenta.UseAccentColor = false;
            btnEditarVenta.UseVisualStyleBackColor = true;
            btnEditarVenta.Click += btnEditarVenta_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarVenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarVenta.Depth = 0;
            btnAgregarVenta.HighEmphasis = true;
            btnAgregarVenta.Icon = null;
            btnAgregarVenta.Location = new Point(1051, 188);
            btnAgregarVenta.Margin = new Padding(6, 10, 6, 10);
            btnAgregarVenta.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.NoAccentTextColor = Color.Empty;
            btnAgregarVenta.Size = new Size(138, 36);
            btnAgregarVenta.TabIndex = 12;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarVenta.UseAccentColor = false;
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // FRM_VENTAS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1857, 1167);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(dgvVentas);
            Controls.Add(btnEditarVenta);
            Controls.Add(btnAgregarVenta);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FRM_VENTAS";
            Padding = new Padding(4, 107, 4, 5);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            FormClosed += FRM_VENTAS_FormClosed;
            Load += FRM_VENTAS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialLabel lblBuscar;
        private DataGridView dgvVentas;
        private MaterialSkin.Controls.MaterialButton btnEditarVenta;
        private MaterialSkin.Controls.MaterialButton btnAgregarVenta;
    }
}