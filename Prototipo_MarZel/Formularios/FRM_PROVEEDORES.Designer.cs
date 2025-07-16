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
            btnEliminarProveedor = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            btnAgregarProveedor.Location = new Point(336, 100);
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
            btnEditarProveedor.Location = new Point(526, 100);
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
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BackgroundColor = SystemColors.InactiveCaption;
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(43, 200);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(1283, 450);
            dgvProveedores.TabIndex = 2;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarProveedor.Depth = 0;
            btnEliminarProveedor.HighEmphasis = true;
            btnEliminarProveedor.Icon = null;
            btnEliminarProveedor.Location = new Point(700, 100);
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(195, 158);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(107, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "materialLabel1";
            // 
            // FRM_PROVEEDORES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 590);
            Controls.Add(materialLabel1);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(dgvProveedores);
            Controls.Add(btnEditarProveedor);
            Controls.Add(btnAgregarProveedor);
            Name = "FRM_PROVEEDORES";
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}