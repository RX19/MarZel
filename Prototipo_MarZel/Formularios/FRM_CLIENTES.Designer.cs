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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            btnAgregarCliente = new MaterialSkin.Controls.MaterialButton();
            btnEditarCliente = new MaterialSkin.Controls.MaterialButton();
            dgvClientes = new System.Windows.Forms.DataGridView();
            btnEliminarCliente = new MaterialSkin.Controls.MaterialButton();
            lblBuscar = new MaterialSkin.Controls.MaterialLabel();
            txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarCliente.Depth = 0;
            btnAgregarCliente.HighEmphasis = true;
            btnAgregarCliente.Icon = null;
            btnAgregarCliente.Location = new System.Drawing.Point(566, 115);
            btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            btnAgregarCliente.Size = new System.Drawing.Size(153, 36);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarCliente.UseAccentColor = false;
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnEditarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarCliente.Depth = 0;
            btnEditarCliente.HighEmphasis = true;
            btnEditarCliente.Icon = null;
            btnEditarCliente.Location = new System.Drawing.Point(766, 115);
            btnEditarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            btnEditarCliente.Size = new System.Drawing.Size(137, 36);
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
            dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Location = new System.Drawing.Point(50, 200);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new System.Drawing.Size(1200, 450);
            dgvClientes.TabIndex = 2;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnEliminarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarCliente.Depth = 0;
            btnEliminarCliente.HighEmphasis = true;
            btnEliminarCliente.Icon = null;
            btnEliminarCliente.Location = new System.Drawing.Point(950, 115);
            btnEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnEliminarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            btnEliminarCliente.Size = new System.Drawing.Size(154, 36);
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
            lblBuscar.Depth = 0;
            lblBuscar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblBuscar.Location = new System.Drawing.Point(106, 124);
            lblBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(54, 19);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new System.Drawing.Point(174, 108);
            txtBuscar.MaxLength = 50;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(350, 50);
            txtBuscar.TabIndex = 5;
            txtBuscar.Text = "";
            txtBuscar.TrailingIcon = null;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // FRM_CLIENTES
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1300, 700);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnEliminarCliente);
            Controls.Add(dgvClientes);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnAgregarCliente);
            MaximizeBox = false;
            Name = "FRM_CLIENTES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FRM_CLIENTES";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
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