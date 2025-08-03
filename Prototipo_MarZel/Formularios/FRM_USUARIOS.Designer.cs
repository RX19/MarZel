namespace Prototipo_MarZel.Formularios
{
    partial class FRM_USUARIOS
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
            BTN_PANEL_CREAR_USUARIO = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // BTN_PANEL_CREAR_USUARIO
            // 
            BTN_PANEL_CREAR_USUARIO.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_PANEL_CREAR_USUARIO.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_PANEL_CREAR_USUARIO.Depth = 0;
            BTN_PANEL_CREAR_USUARIO.HighEmphasis = true;
            BTN_PANEL_CREAR_USUARIO.Icon = null;
            BTN_PANEL_CREAR_USUARIO.Location = new Point(27, 93);
            BTN_PANEL_CREAR_USUARIO.Margin = new Padding(5, 5, 5, 5);
            BTN_PANEL_CREAR_USUARIO.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_PANEL_CREAR_USUARIO.Name = "BTN_PANEL_CREAR_USUARIO";
            BTN_PANEL_CREAR_USUARIO.NoAccentTextColor = Color.Empty;
            BTN_PANEL_CREAR_USUARIO.Size = new Size(132, 36);
            BTN_PANEL_CREAR_USUARIO.TabIndex = 0;
            BTN_PANEL_CREAR_USUARIO.Text = "Crear Usuario";
            BTN_PANEL_CREAR_USUARIO.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_PANEL_CREAR_USUARIO.UseAccentColor = false;
            BTN_PANEL_CREAR_USUARIO.UseVisualStyleBackColor = true;
            BTN_PANEL_CREAR_USUARIO.Click += BTN_PANEL_CREAR_USUARIO_Click;
            // 
            // FRM_USUARIOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 657);
            Controls.Add(BTN_PANEL_CREAR_USUARIO);
            Name = "FRM_USUARIOS";
            Text = "Administrador";
            FormClosed += FRM_Administrador_FormClosed;
            Load += FRM_Administrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialButton BTN_PANEL_CREAR_USUARIO;
    }
}