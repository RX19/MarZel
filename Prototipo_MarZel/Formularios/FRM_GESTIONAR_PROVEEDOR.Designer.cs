namespace Prototipo_MarZel.Formularios
{
    partial class FRM_GESTIONAR_PROVEEDOR
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
            txtRTN = new MaterialSkin.Controls.MaterialTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            txtCelular = new MaterialSkin.Controls.MaterialTextBox();
            txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            chkSinRTN = new MaterialSkin.Controls.MaterialCheckbox();
            SuspendLayout();
            // 
            // txtRTN
            // 
            txtRTN.AnimateReadOnly = true;
            txtRTN.BackColor = SystemColors.MenuText;
            txtRTN.BorderStyle = BorderStyle.None;
            txtRTN.Depth = 0;
            txtRTN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRTN.ForeColor = Color.Black;
            txtRTN.Hint = "R.T.N.";
            txtRTN.LeadingIcon = null;
            txtRTN.Location = new Point(50, 227);
            txtRTN.Margin = new Padding(4, 5, 4, 5);
            txtRTN.MaxLength = 50;
            txtRTN.MouseState = MaterialSkin.MouseState.OUT;
            txtRTN.Multiline = false;
            txtRTN.Name = "txtRTN";
            txtRTN.ScrollBars = RichTextBoxScrollBars.None;
            txtRTN.Size = new Size(357, 50);
            txtRTN.TabIndex = 0;
            txtRTN.Text = "";
            txtRTN.TrailingIcon = null;
            txtRTN.TextChanged += txtRTN_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = true;
            txtNombre.BackColor = SystemColors.MenuText;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Hint = "Nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(421, 227);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ScrollBars = RichTextBoxScrollBars.None;
            txtNombre.Size = new Size(500, 50);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // txtCelular
            // 
            txtCelular.AnimateReadOnly = true;
            txtCelular.BackColor = SystemColors.MenuText;
            txtCelular.BorderStyle = BorderStyle.None;
            txtCelular.Depth = 0;
            txtCelular.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCelular.ForeColor = Color.Black;
            txtCelular.Hint = "Celular";
            txtCelular.LeadingIcon = null;
            txtCelular.Location = new Point(564, 343);
            txtCelular.Margin = new Padding(4, 5, 4, 5);
            txtCelular.MaxLength = 50;
            txtCelular.MouseState = MaterialSkin.MouseState.OUT;
            txtCelular.Multiline = false;
            txtCelular.Name = "txtCelular";
            txtCelular.ScrollBars = RichTextBoxScrollBars.None;
            txtCelular.Size = new Size(357, 50);
            txtCelular.TabIndex = 3;
            txtCelular.Text = "";
            txtCelular.TrailingIcon = null;
            // 
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = true;
            txtDireccion.BackColor = SystemColors.MenuText;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Hint = "Dirección";
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(50, 343);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.MaxLength = 50;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Multiline = false;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ScrollBars = RichTextBoxScrollBars.None;
            txtDireccion.Size = new Size(500, 50);
            txtDireccion.TabIndex = 2;
            txtDireccion.Text = "";
            txtDireccion.TrailingIcon = null;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(796, 465);
            btnGuardar.Margin = new Padding(6, 10, 6, 10);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkSinRTN
            // 
            chkSinRTN.AutoSize = true;
            chkSinRTN.Depth = 0;
            chkSinRTN.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSinRTN.Location = new Point(50, 143);
            chkSinRTN.Margin = new Padding(0);
            chkSinRTN.MouseLocation = new Point(-1, -1);
            chkSinRTN.MouseState = MaterialSkin.MouseState.HOVER;
            chkSinRTN.Name = "chkSinRTN";
            chkSinRTN.ReadOnly = false;
            chkSinRTN.Ripple = true;
            chkSinRTN.Size = new Size(105, 37);
            chkSinRTN.TabIndex = 6;
            chkSinRTN.Text = "Sin R.T.N.";
            chkSinRTN.UseVisualStyleBackColor = true;
            chkSinRTN.Visible = false;
            chkSinRTN.CheckedChanged += chkSinRTN_CheckedChanged;
            // 
            // FRM_GESTIONAR_PROVEEDOR
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 583);
            Controls.Add(chkSinRTN);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(txtCelular);
            Controls.Add(txtNombre);
            Controls.Add(txtRTN);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(971, 583);
            MinimumSize = new Size(971, 583);
            Name = "FRM_GESTIONAR_PROVEEDOR";
            Padding = new Padding(4, 107, 4, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Proveedor";
            Load += FRM_GESTIONAR_PROVEEDOR_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtRTN;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtCelular;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialCheckbox chkSinRTN;
    }
}