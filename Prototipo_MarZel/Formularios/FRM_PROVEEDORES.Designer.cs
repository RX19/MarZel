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
            btnAgregarProveedor = new MaterialSkin.Controls.MaterialButton();
            btnEditarProveedor = new MaterialSkin.Controls.MaterialButton();
            dgvProveedores = new DataGridView();
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
            btnAgregarProveedor.Location = new Point(571, 133);
            btnAgregarProveedor.Margin = new Padding(5, 8, 5, 8);
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
            btnEditarProveedor.Location = new Point(790, 133);
            btnEditarProveedor.Margin = new Padding(5, 8, 5, 8);
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
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BackgroundColor = SystemColors.InactiveCaption;
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(49, 267);
            dgvProveedores.Margin = new Padding(3, 4, 3, 4);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(1466, 600);
            dgvProveedores.TabIndex = 2;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // FRM_PROVEEDORES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 960);
            Controls.Add(dgvProveedores);
            Controls.Add(btnEditarProveedor);
            Controls.Add(btnAgregarProveedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRM_PROVEEDORES";
            Padding = new Padding(3, 85, 3, 4);
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
    }
}