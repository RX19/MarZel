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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnAgregarCliente = new MaterialSkin.Controls.MaterialButton();
            btnEditarCliente = new MaterialSkin.Controls.MaterialButton();
            dgvClientes = new DataGridView();
            btnEliminarCliente = new MaterialSkin.Controls.MaterialButton();
            lblBuscar = new MaterialSkin.Controls.MaterialLabel();
            txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarCliente.Depth = 0;
            btnAgregarCliente.HighEmphasis = true;
            btnAgregarCliente.Icon = null;
            btnAgregarCliente.Location = new Point(1193, 166);
            btnAgregarCliente.Margin = new Padding(6, 10, 6, 10);
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
            btnEditarCliente.Location = new Point(743, 166);
            btnEditarCliente.Margin = new Padding(6, 10, 6, 10);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeight = 29;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Location = new Point(233, 255);
            dgvClientes.Margin = new Padding(4, 5, 4, 5);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(609, 225);
            dgvClientes.TabIndex = 2;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarCliente.Depth = 0;
            btnEliminarCliente.HighEmphasis = true;
            btnEliminarCliente.Icon = null;
            btnEliminarCliente.Location = new Point(954, 166);
            btnEliminarCliente.Margin = new Padding(6, 10, 6, 10);
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
            lblBuscar.Location = new Point(104, 180);
            lblBuscar.Margin = new Padding(4, 0, 4, 0);
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
            txtBuscar.Location = new Point(233, 163);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.MaxLength = 50;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(500, 50);
            txtBuscar.TabIndex = 5;
            txtBuscar.Text = "";
            txtBuscar.TrailingIcon = null;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // FRM_CLIENTES
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 730);
            Controls.Add(lblBuscar);
            Controls.Add(dgvClientes);
            Controls.Add(txtBuscar);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnAgregarCliente);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FRM_CLIENTES";
            Padding = new Padding(4, 106, 4, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_CLIENTES";
            WindowState = FormWindowState.Maximized;
            Load += FRM_CLIENTES_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAgregarCliente;
        private MaterialSkin.Controls.MaterialButton btnEditarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private MaterialSkin.Controls.MaterialButton btnEliminarCliente;
        private MaterialSkin.Controls.MaterialLabel lblBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
    }
}