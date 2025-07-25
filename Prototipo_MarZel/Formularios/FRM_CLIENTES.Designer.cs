namespace Prototipo_MarZel.Formularios
{
    partial class FRM_CLIENTES
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
            btnAgregarCliente = new MaterialSkin.Controls.MaterialButton();
            btnEditarCliente = new MaterialSkin.Controls.MaterialButton();
            dgvClientes = new DataGridView();
            btnEliminarCliente = new MaterialSkin.Controls.MaterialButton();
            lblBuscar = new MaterialSkin.Controls.MaterialLabel();
            txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarCliente.Depth = 0;
            btnAgregarCliente.HighEmphasis = true;
            btnAgregarCliente.Icon = null;
            btnAgregarCliente.Location = new Point(916, 51);
            btnAgregarCliente.Margin = new Padding(5, 8, 5, 8);
            btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.NoAccentTextColor = Color.Empty;
            btnAgregarCliente.Size = new Size(150, 36);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarCliente.UseAccentColor = false;
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarCliente.Depth = 0;
            btnEditarCliente.HighEmphasis = true;
            btnEditarCliente.Icon = null;
            btnEditarCliente.Location = new Point(556, 51);
            btnEditarCliente.Margin = new Padding(5, 8, 5, 8);
            btnEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.NoAccentTextColor = Color.Empty;
            btnEditarCliente.Size = new Size(133, 36);
            btnEditarCliente.TabIndex = 1;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarCliente.UseAccentColor = false;
            btnEditarCliente.UseVisualStyleBackColor = true;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = SystemColors.InactiveCaption;
            dgvClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeight = 29;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Location = new Point(246, 318);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(487, 180);
            dgvClientes.TabIndex = 2;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarCliente.Depth = 0;
            btnEliminarCliente.HighEmphasis = true;
            btnEliminarCliente.Icon = null;
            btnEliminarCliente.Location = new Point(725, 51);
            btnEliminarCliente.Margin = new Padding(5, 8, 5, 8);
            btnEliminarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.NoAccentTextColor = Color.Empty;
            btnEliminarCliente.Size = new Size(150, 36);
            btnEliminarCliente.TabIndex = 3;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminarCliente.UseAccentColor = false;
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Depth = 0;
            lblBuscar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBuscar.Location = new Point(45, 62);
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
            txtBuscar.Location = new Point(148, 49);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.MaxLength = 50;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(400, 50);
            txtBuscar.TabIndex = 5;
            txtBuscar.Text = "";
            txtBuscar.TrailingIcon = null;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 85);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1480, 844);
            materialTabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblBuscar);
            tabPage1.Controls.Add(dgvClientes);
            tabPage1.Controls.Add(btnEliminarCliente);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(btnAgregarCliente);
            tabPage1.Controls.Add(btnEditarCliente);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1472, 811);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1472, 811);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FRM_CLIENTES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 933);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FRM_CLIENTES";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_CLIENTES";
            WindowState = FormWindowState.Maximized;
            Load += FRM_CLIENTES_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAgregarCliente;
        private MaterialSkin.Controls.MaterialButton btnEditarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private MaterialSkin.Controls.MaterialButton btnEliminarCliente;
        private MaterialSkin.Controls.MaterialLabel lblBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}