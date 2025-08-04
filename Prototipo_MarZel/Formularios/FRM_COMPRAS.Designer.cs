namespace Prototipo_MarZel.Formularios
{
    partial class FRM_COMPRAS
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
            txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            lblBuscar = new MaterialSkin.Controls.MaterialLabel();
            dgvCompras = new DataGridView();
            btnEditarCompra = new MaterialSkin.Controls.MaterialButton();
            btnAgregarCompra = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(500, 180);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MaxLength = 50;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(500, 50);
            txtBuscar.TabIndex = 11;
            txtBuscar.Text = "";
            txtBuscar.TrailingIcon = null;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Depth = 0;
            lblBuscar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBuscar.Location = new Point(401, 207);
            lblBuscar.Margin = new Padding(4, 0, 4, 0);
            lblBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 19);
            lblBuscar.TabIndex = 10;
            lblBuscar.Text = "Buscar:";
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.AllowUserToResizeColumns = false;
            dgvCompras.AllowUserToResizeRows = false;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.BackgroundColor = SystemColors.InactiveCaption;
            dgvCompras.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompras.ColumnHeadersHeight = 34;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCompras.Location = new Point(71, 333);
            dgvCompras.Margin = new Padding(4, 5, 4, 5);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(1714, 750);
            dgvCompras.TabIndex = 8;
            // 
            // btnEditarCompra
            // 
            btnEditarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarCompra.Depth = 0;
            btnEditarCompra.HighEmphasis = true;
            btnEditarCompra.Icon = null;
            btnEditarCompra.Location = new Point(1260, 192);
            btnEditarCompra.Margin = new Padding(6, 10, 6, 10);
            btnEditarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarCompra.Name = "btnEditarCompra";
            btnEditarCompra.NoAccentTextColor = Color.Empty;
            btnEditarCompra.Size = new Size(136, 36);
            btnEditarCompra.TabIndex = 7;
            btnEditarCompra.Text = "Editar Compra";
            btnEditarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarCompra.UseAccentColor = false;
            btnEditarCompra.UseVisualStyleBackColor = true;
            btnEditarCompra.Click += btnEditarCompra_Click;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarCompra.Depth = 0;
            btnAgregarCompra.HighEmphasis = true;
            btnAgregarCompra.Icon = null;
            btnAgregarCompra.Location = new Point(1021, 192);
            btnAgregarCompra.Margin = new Padding(6, 10, 6, 10);
            btnAgregarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.NoAccentTextColor = Color.Empty;
            btnAgregarCompra.Size = new Size(152, 36);
            btnAgregarCompra.TabIndex = 6;
            btnAgregarCompra.Text = "Agregar Compra";
            btnAgregarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarCompra.UseAccentColor = false;
            btnAgregarCompra.UseVisualStyleBackColor = true;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // FRM_COMPRAS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1857, 1167);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(dgvCompras);
            Controls.Add(btnEditarCompra);
            Controls.Add(btnAgregarCompra);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FRM_COMPRAS";
            Padding = new Padding(4, 107, 4, 5);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            WindowState = FormWindowState.Maximized;
            FormClosed += FRM_COMPRAS_FormClosed;
            Load += FRM_COMPRAS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialLabel lblBuscar;
        private DataGridView dgvCompras;
        private MaterialSkin.Controls.MaterialButton btnEditarCompra;
        private MaterialSkin.Controls.MaterialButton btnAgregarCompra;
    }
}