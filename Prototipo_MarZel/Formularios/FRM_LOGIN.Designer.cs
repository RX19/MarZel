namespace Prototipo_MarZel.Formularios
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            TXT_USUARIO = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_PASSWORD = new MaterialSkin.Controls.MaterialTextBox2();
            pictureBox1 = new PictureBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TXT_USUARIO
            // 
            TXT_USUARIO.AnimateReadOnly = false;
            TXT_USUARIO.BackgroundImageLayout = ImageLayout.None;
            TXT_USUARIO.CharacterCasing = CharacterCasing.Normal;
            TXT_USUARIO.Depth = 0;
            TXT_USUARIO.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TXT_USUARIO.HideSelection = true;
            TXT_USUARIO.Hint = "Usuario";
            TXT_USUARIO.LeadingIcon = null;
            TXT_USUARIO.Location = new Point(549, 123);
            TXT_USUARIO.MaxLength = 32767;
            TXT_USUARIO.MouseState = MaterialSkin.MouseState.OUT;
            TXT_USUARIO.Name = "TXT_USUARIO";
            TXT_USUARIO.PasswordChar = '\0';
            TXT_USUARIO.PrefixSuffixText = null;
            TXT_USUARIO.ReadOnly = false;
            TXT_USUARIO.RightToLeft = RightToLeft.No;
            TXT_USUARIO.SelectedText = "";
            TXT_USUARIO.SelectionLength = 0;
            TXT_USUARIO.SelectionStart = 0;
            TXT_USUARIO.ShortcutsEnabled = true;
            TXT_USUARIO.Size = new Size(309, 48);
            TXT_USUARIO.TabIndex = 0;
            TXT_USUARIO.TabStop = false;
            TXT_USUARIO.TextAlign = HorizontalAlignment.Left;
            TXT_USUARIO.TrailingIcon = null;
            TXT_USUARIO.UseSystemPasswordChar = false;
            // 
            // TXT_PASSWORD
            // 
            TXT_PASSWORD.AnimateReadOnly = false;
            TXT_PASSWORD.BackgroundImageLayout = ImageLayout.None;
            TXT_PASSWORD.CharacterCasing = CharacterCasing.Normal;
            TXT_PASSWORD.Depth = 0;
            TXT_PASSWORD.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PASSWORD.HideSelection = true;
            TXT_PASSWORD.Hint = "Contraseña";
            TXT_PASSWORD.LeadingIcon = null;
            TXT_PASSWORD.Location = new Point(549, 240);
            TXT_PASSWORD.MaxLength = 32767;
            TXT_PASSWORD.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PASSWORD.Name = "TXT_PASSWORD";
            TXT_PASSWORD.PasswordChar = '●';
            TXT_PASSWORD.PrefixSuffixText = null;
            TXT_PASSWORD.ReadOnly = false;
            TXT_PASSWORD.RightToLeft = RightToLeft.No;
            TXT_PASSWORD.SelectedText = "";
            TXT_PASSWORD.SelectionLength = 0;
            TXT_PASSWORD.SelectionStart = 0;
            TXT_PASSWORD.ShortcutsEnabled = true;
            TXT_PASSWORD.Size = new Size(309, 48);
            TXT_PASSWORD.TabIndex = 1;
            TXT_PASSWORD.TabStop = false;
            TXT_PASSWORD.TextAlign = HorizontalAlignment.Left;
            TXT_PASSWORD.TrailingIcon = null;
            TXT_PASSWORD.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 372);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(629, 433);
            materialButton1.Margin = new Padding(4, 7, 4, 7);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(101, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Comenzar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(524, 350);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(233, 37);
            materialCheckbox1.TabIndex = 5;
            materialCheckbox1.Text = "Mostrar/Ocultar Contraseña";
            materialCheckbox1.UseVisualStyleBackColor = true;
            materialCheckbox1.CheckedChanged += materialCheckbox1_CheckedChanged;
            // 
            // FRM_LOGIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 515);
            Controls.Add(materialCheckbox1);
            Controls.Add(materialButton1);
            Controls.Add(pictureBox1);
            Controls.Add(TXT_PASSWORD);
            Controls.Add(TXT_USUARIO);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_LOGIN";
            Padding = new Padding(3, 63, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesion";
            Load += FRM_LOGIN_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TXT_USUARIO;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_PASSWORD;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
    }
}