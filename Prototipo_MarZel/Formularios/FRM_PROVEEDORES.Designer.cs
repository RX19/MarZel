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
            btnAgregarProveedor.Location = new Point(500, 100);
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
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarProveedor.Depth = 0;
            btnEditarProveedor.HighEmphasis = true;
            btnEditarProveedor.Icon = null;
            btnEditarProveedor.Location = new Point(691, 100);
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
            dgvProveedores.Size = new Size(1283, 450);
            dgvProveedores.TabIndex = 2;
            // 
            // FRM_PROVEEDORES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 720);
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
    }
}