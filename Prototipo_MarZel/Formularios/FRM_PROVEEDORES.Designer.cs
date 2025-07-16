namespace Prototipo_MarZel.Formularios
{
    partial class FRM_PROVEEDORES
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
            btnAgregarProveedor = new MaterialSkin.Controls.MaterialButton();
            btnEditarProveedor = new MaterialSkin.Controls.MaterialButton();
            dgvProveedores = new DataGridView();
            btnEliminarProveedor = new MaterialSkin.Controls.MaterialButton();
            lblBuscar = new MaterialSkin.Controls.MaterialLabel();
            txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarProveedor.Depth = 0;
            btnAgregarProveedor.HighEmphasis = true;
            btnAgregarProveedor.Icon = null;
            btnAgregarProveedor.Location = new Point(566, 115);
            btnAgregarProveedor.Margin = new Padding(4, 6, 4, 6);
            btnAgregarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.NoAccentTextColor = Color.Empty;
            btnAgregarProveedor.Size = new Size(175, 36);
            btnAgregarProveedor.TabIndex = 0;
            btnAgregarProveedor.Text = "Agregar Proveedor";
            btnAgregarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarProveedor.UseAccentColor = false;
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarProveedor.Depth = 0;
            btnEditarProveedor.HighEmphasis = true;
            btnEditarProveedor.Icon = null;
            btnEditarProveedor.Location = new Point(766, 115);
            btnEditarProveedor.Margin = new Padding(4, 6, 4, 6);
            btnEditarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.NoAccentTextColor = Color.Empty;
            btnEditarProveedor.Size = new Size(159, 36);
            btnEditarProveedor.TabIndex = 1;
            btnEditarProveedor.Text = "Editar Proveedor";
            btnEditarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarProveedor.UseAccentColor = false;
            btnEditarProveedor.UseVisualStyleBackColor = true;
            btnEditarProveedor.Click += btnEditarProveedor_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AllowUserToResizeColumns = false;
            dgvProveedores.AllowUserToResizeRows = false;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BackgroundColor = SystemColors.InactiveCaption;
            dgvProveedores.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProveedores.Location = new Point(50, 200);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(1200, 450);
            dgvProveedores.TabIndex = 2;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarProveedor.Depth = 0;
            btnEliminarProveedor.HighEmphasis = true;
            btnEliminarProveedor.Icon = null;
            btnEliminarProveedor.Location = new Point(950, 115);
            btnEliminarProveedor.Margin = new Padding(4, 6, 4, 6);
            btnEliminarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.NoAccentTextColor = Color.Empty;
            btnEliminarProveedor.Size = new Size(176, 36);
            btnEliminarProveedor.TabIndex = 3;
            btnEliminarProveedor.Text = "Eliminar Proveedor";
            btnEliminarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminarProveedor.UseAccentColor = false;
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Depth = 0;
            lblBuscar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBuscar.Location = new Point(106, 124);
            lblBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 19);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(174, 108);
            txtBuscar.MaxLength = 50;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(350, 50);
            txtBuscar.TabIndex = 5;
            txtBuscar.Text = "";
            txtBuscar.TrailingIcon = null;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // FRM_PROVEEDORES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 700);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(dgvProveedores);
            Controls.Add(btnEditarProveedor);
            Controls.Add(btnAgregarProveedor);
            MaximizeBox = false;
            Name = "FRM_PROVEEDORES";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_PROVEEDORES";
            WindowState = FormWindowState.Maximized;
            Load += FRM_PROVEEDORES_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAgregarProveedor;
        private MaterialSkin.Controls.MaterialButton btnEditarProveedor;
        private DataGridView dgvProveedores;
        private MaterialSkin.Controls.MaterialButton btnEliminarProveedor;
        private MaterialSkin.Controls.MaterialLabel lblBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
    }
}