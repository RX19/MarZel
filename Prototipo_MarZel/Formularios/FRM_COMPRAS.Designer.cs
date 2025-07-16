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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            txtBuscar.Location = new Point(350, 108);
            txtBuscar.MaxLength = 50;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(350, 50);
            txtBuscar.TabIndex = 11;
            txtBuscar.Text = "";
            txtBuscar.TrailingIcon = null;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Depth = 0;
            lblBuscar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBuscar.Location = new Point(281, 124);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCompras.Location = new Point(50, 200);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(1200, 450);
            dgvCompras.TabIndex = 8;
            // 
            // btnEditarCompra
            // 
            btnEditarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarCompra.Depth = 0;
            btnEditarCompra.HighEmphasis = true;
            btnEditarCompra.Icon = null;
            btnEditarCompra.Location = new Point(882, 115);
            btnEditarCompra.Margin = new Padding(4, 6, 4, 6);
            btnEditarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarCompra.Name = "btnEditarCompra";
            btnEditarCompra.NoAccentTextColor = Color.Empty;
            btnEditarCompra.Size = new Size(136, 36);
            btnEditarCompra.TabIndex = 7;
            btnEditarCompra.Text = "Editar Compra";
            btnEditarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarCompra.UseAccentColor = false;
            btnEditarCompra.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarCompra.Depth = 0;
            btnAgregarCompra.HighEmphasis = true;
            btnAgregarCompra.Icon = null;
            btnAgregarCompra.Location = new Point(715, 115);
            btnAgregarCompra.Margin = new Padding(4, 6, 4, 6);
            btnAgregarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.NoAccentTextColor = Color.Empty;
            btnAgregarCompra.Size = new Size(152, 36);
            btnAgregarCompra.TabIndex = 6;
            btnAgregarCompra.Text = "Agregar Compra";
            btnAgregarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarCompra.UseAccentColor = false;
            btnAgregarCompra.UseVisualStyleBackColor = true;
            // 
            // FRM_COMPRAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 700);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(dgvCompras);
            Controls.Add(btnEditarCompra);
            Controls.Add(btnAgregarCompra);
            MaximizeBox = false;
            Name = "FRM_COMPRAS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_COMPRAS";
            WindowState = FormWindowState.Maximized;
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