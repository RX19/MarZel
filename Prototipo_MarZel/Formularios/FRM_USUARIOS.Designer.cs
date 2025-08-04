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
            DVC_USUARIOS = new DataGridView();
            BTN_PANEL_ELIMINAR_USUARIO = new MaterialSkin.Controls.MaterialButton();
            BTN_PANEL_EDITAR_USUARIO = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)DVC_USUARIOS).BeginInit();
            SuspendLayout();
            // 
            // BTN_PANEL_CREAR_USUARIO
            // 
            BTN_PANEL_CREAR_USUARIO.AutoSize = false;
            BTN_PANEL_CREAR_USUARIO.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_PANEL_CREAR_USUARIO.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_PANEL_CREAR_USUARIO.Depth = 0;
            BTN_PANEL_CREAR_USUARIO.HighEmphasis = true;
            BTN_PANEL_CREAR_USUARIO.Icon = null;
            BTN_PANEL_CREAR_USUARIO.Location = new Point(27, 93);
            BTN_PANEL_CREAR_USUARIO.Margin = new Padding(5);
            BTN_PANEL_CREAR_USUARIO.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_PANEL_CREAR_USUARIO.Name = "BTN_PANEL_CREAR_USUARIO";
            BTN_PANEL_CREAR_USUARIO.NoAccentTextColor = Color.Empty;
            BTN_PANEL_CREAR_USUARIO.Size = new Size(153, 36);
            BTN_PANEL_CREAR_USUARIO.TabIndex = 0;
            BTN_PANEL_CREAR_USUARIO.Text = "Crear Usuario";
            BTN_PANEL_CREAR_USUARIO.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_PANEL_CREAR_USUARIO.UseAccentColor = false;
            BTN_PANEL_CREAR_USUARIO.UseVisualStyleBackColor = true;
            BTN_PANEL_CREAR_USUARIO.Click += BTN_PANEL_CREAR_USUARIO_Click;
            // 
            // DVC_USUARIOS
            // 
            DVC_USUARIOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVC_USUARIOS.Location = new Point(205, 93);
            DVC_USUARIOS.Name = "DVC_USUARIOS";
            DVC_USUARIOS.RowHeadersWidth = 51;
            DVC_USUARIOS.Size = new Size(647, 361);
            DVC_USUARIOS.TabIndex = 1;
            // 
            // BTN_PANEL_ELIMINAR_USUARIO
            // 
            BTN_PANEL_ELIMINAR_USUARIO.AutoSize = false;
            BTN_PANEL_ELIMINAR_USUARIO.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_PANEL_ELIMINAR_USUARIO.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_PANEL_ELIMINAR_USUARIO.Depth = 0;
            BTN_PANEL_ELIMINAR_USUARIO.HighEmphasis = true;
            BTN_PANEL_ELIMINAR_USUARIO.Icon = null;
            BTN_PANEL_ELIMINAR_USUARIO.Location = new Point(27, 160);
            BTN_PANEL_ELIMINAR_USUARIO.Margin = new Padding(4, 6, 4, 6);
            BTN_PANEL_ELIMINAR_USUARIO.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_PANEL_ELIMINAR_USUARIO.Name = "BTN_PANEL_ELIMINAR_USUARIO";
            BTN_PANEL_ELIMINAR_USUARIO.NoAccentTextColor = Color.Empty;
            BTN_PANEL_ELIMINAR_USUARIO.Size = new Size(153, 36);
            BTN_PANEL_ELIMINAR_USUARIO.TabIndex = 2;
            BTN_PANEL_ELIMINAR_USUARIO.Text = "Eliminar Usuario";
            BTN_PANEL_ELIMINAR_USUARIO.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_PANEL_ELIMINAR_USUARIO.UseAccentColor = false;
            BTN_PANEL_ELIMINAR_USUARIO.UseVisualStyleBackColor = true;
            BTN_PANEL_ELIMINAR_USUARIO.Click += BTN_PANEL_ELIMINAR_USUARIO_Click;
            // 
            // BTN_PANEL_EDITAR_USUARIO
            // 
            BTN_PANEL_EDITAR_USUARIO.AutoSize = false;
            BTN_PANEL_EDITAR_USUARIO.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_PANEL_EDITAR_USUARIO.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_PANEL_EDITAR_USUARIO.Depth = 0;
            BTN_PANEL_EDITAR_USUARIO.HighEmphasis = true;
            BTN_PANEL_EDITAR_USUARIO.Icon = null;
            BTN_PANEL_EDITAR_USUARIO.Location = new Point(27, 225);
            BTN_PANEL_EDITAR_USUARIO.Margin = new Padding(4, 6, 4, 6);
            BTN_PANEL_EDITAR_USUARIO.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_PANEL_EDITAR_USUARIO.Name = "BTN_PANEL_EDITAR_USUARIO";
            BTN_PANEL_EDITAR_USUARIO.NoAccentTextColor = Color.Empty;
            BTN_PANEL_EDITAR_USUARIO.Size = new Size(153, 36);
            BTN_PANEL_EDITAR_USUARIO.TabIndex = 3;
            BTN_PANEL_EDITAR_USUARIO.Text = "EDITAR USUARIO";
            BTN_PANEL_EDITAR_USUARIO.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_PANEL_EDITAR_USUARIO.UseAccentColor = false;
            BTN_PANEL_EDITAR_USUARIO.UseVisualStyleBackColor = true;
            BTN_PANEL_EDITAR_USUARIO.Click += BTN_PANEL_EDITAR_USUARIO_Click;
            // 
            // FRM_USUARIOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 657);
            Controls.Add(BTN_PANEL_EDITAR_USUARIO);
            Controls.Add(BTN_PANEL_ELIMINAR_USUARIO);
            Controls.Add(DVC_USUARIOS);
            Controls.Add(BTN_PANEL_CREAR_USUARIO);
            Name = "FRM_USUARIOS";
            Text = "Usuarios";
            FormClosed += FRM_Administrador_FormClosed;
            Load += FRM_Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)DVC_USUARIOS).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialButton BTN_PANEL_CREAR_USUARIO;
        private DataGridView DVC_USUARIOS;
        private MaterialSkin.Controls.MaterialButton BTN_PANEL_ELIMINAR_USUARIO;
        private MaterialSkin.Controls.MaterialButton BTN_PANEL_EDITAR_USUARIO;
    }
}