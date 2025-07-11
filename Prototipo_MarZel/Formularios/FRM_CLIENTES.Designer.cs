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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CLIENTES));
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            TXT_CEL = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_DIR = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_NAME = new MaterialSkin.Controls.MaterialTextBox2();
            TXT_RTN = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(626, 123);
            materialLabel1.Margin = new Padding(4, 0, 4, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(352, 19);
            materialLabel1.TabIndex = 17;
            materialLabel1.Text = "Ingresa la identificación del cliente para continuar";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(940, 728);
            materialButton2.Margin = new Padding(4, 7, 4, 7);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(96, 36);
            materialButton2.TabIndex = 16;
            materialButton2.Text = "Cancelar";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Enabled = false;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(703, 728);
            materialButton1.Margin = new Padding(4, 7, 4, 7);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(86, 36);
            materialButton1.TabIndex = 15;
            materialButton1.Text = "Aceptar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(619, 608);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // TXT_CEL
            // 
            TXT_CEL.AnimateReadOnly = false;
            TXT_CEL.BackgroundImageLayout = ImageLayout.None;
            TXT_CEL.CharacterCasing = CharacterCasing.Normal;
            TXT_CEL.Depth = 0;
            TXT_CEL.Enabled = false;
            TXT_CEL.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_CEL.HideSelection = true;
            TXT_CEL.Hint = "Celular";
            TXT_CEL.LeadingIcon = null;
            TXT_CEL.Location = new Point(703, 615);
            TXT_CEL.MaxLength = 32767;
            TXT_CEL.MouseState = MaterialSkin.MouseState.OUT;
            TXT_CEL.Name = "TXT_CEL";
            TXT_CEL.PasswordChar = '\0';
            TXT_CEL.PrefixSuffixText = null;
            TXT_CEL.ReadOnly = false;
            TXT_CEL.RightToLeft = RightToLeft.No;
            TXT_CEL.SelectedText = "";
            TXT_CEL.SelectionLength = 0;
            TXT_CEL.SelectionStart = 0;
            TXT_CEL.ShortcutsEnabled = true;
            TXT_CEL.Size = new Size(374, 48);
            TXT_CEL.TabIndex = 13;
            TXT_CEL.TabStop = false;
            TXT_CEL.TextAlign = HorizontalAlignment.Left;
            TXT_CEL.TrailingIcon = null;
            TXT_CEL.UseSystemPasswordChar = false;
            // 
            // TXT_DIR
            // 
            TXT_DIR.AnimateReadOnly = false;
            TXT_DIR.BackgroundImageLayout = ImageLayout.None;
            TXT_DIR.CharacterCasing = CharacterCasing.Normal;
            TXT_DIR.Depth = 0;
            TXT_DIR.Enabled = false;
            TXT_DIR.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_DIR.HideSelection = true;
            TXT_DIR.Hint = "Dirección";
            TXT_DIR.LeadingIcon = null;
            TXT_DIR.Location = new Point(703, 510);
            TXT_DIR.MaxLength = 32767;
            TXT_DIR.MouseState = MaterialSkin.MouseState.OUT;
            TXT_DIR.Name = "TXT_DIR";
            TXT_DIR.PasswordChar = '\0';
            TXT_DIR.PrefixSuffixText = null;
            TXT_DIR.ReadOnly = false;
            TXT_DIR.RightToLeft = RightToLeft.No;
            TXT_DIR.SelectedText = "";
            TXT_DIR.SelectionLength = 0;
            TXT_DIR.SelectionStart = 0;
            TXT_DIR.ShortcutsEnabled = true;
            TXT_DIR.Size = new Size(374, 48);
            TXT_DIR.TabIndex = 12;
            TXT_DIR.TabStop = false;
            TXT_DIR.TextAlign = HorizontalAlignment.Left;
            TXT_DIR.TrailingIcon = null;
            TXT_DIR.UseSystemPasswordChar = false;
            // 
            // TXT_NAME
            // 
            TXT_NAME.AnimateReadOnly = false;
            TXT_NAME.BackgroundImageLayout = ImageLayout.None;
            TXT_NAME.CharacterCasing = CharacterCasing.Normal;
            TXT_NAME.Depth = 0;
            TXT_NAME.Enabled = false;
            TXT_NAME.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_NAME.HideSelection = true;
            TXT_NAME.Hint = "Nombre";
            TXT_NAME.LeadingIcon = null;
            TXT_NAME.Location = new Point(703, 393);
            TXT_NAME.MaxLength = 32767;
            TXT_NAME.MouseState = MaterialSkin.MouseState.OUT;
            TXT_NAME.Name = "TXT_NAME";
            TXT_NAME.PasswordChar = '\0';
            TXT_NAME.PrefixSuffixText = null;
            TXT_NAME.ReadOnly = false;
            TXT_NAME.RightToLeft = RightToLeft.No;
            TXT_NAME.SelectedText = "";
            TXT_NAME.SelectionLength = 0;
            TXT_NAME.SelectionStart = 0;
            TXT_NAME.ShortcutsEnabled = true;
            TXT_NAME.Size = new Size(374, 48);
            TXT_NAME.TabIndex = 11;
            TXT_NAME.TabStop = false;
            TXT_NAME.TextAlign = HorizontalAlignment.Left;
            TXT_NAME.TrailingIcon = null;
            TXT_NAME.UseSystemPasswordChar = false;
            // 
            // TXT_RTN
            // 
            TXT_RTN.AnimateReadOnly = false;
            TXT_RTN.BackgroundImageLayout = ImageLayout.None;
            TXT_RTN.CharacterCasing = CharacterCasing.Normal;
            TXT_RTN.Depth = 0;
            TXT_RTN.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_RTN.HideSelection = true;
            TXT_RTN.Hint = "RTN";
            TXT_RTN.LeadingIcon = null;
            TXT_RTN.Location = new Point(703, 287);
            TXT_RTN.MaxLength = 32767;
            TXT_RTN.MouseState = MaterialSkin.MouseState.OUT;
            TXT_RTN.Name = "TXT_RTN";
            TXT_RTN.PasswordChar = '\0';
            TXT_RTN.PrefixSuffixText = null;
            TXT_RTN.ReadOnly = false;
            TXT_RTN.RightToLeft = RightToLeft.No;
            TXT_RTN.SelectedText = "";
            TXT_RTN.SelectionLength = 0;
            TXT_RTN.SelectionStart = 0;
            TXT_RTN.ShortcutsEnabled = true;
            TXT_RTN.Size = new Size(374, 48);
            TXT_RTN.TabIndex = 10;
            TXT_RTN.TabStop = false;
            TXT_RTN.TextAlign = HorizontalAlignment.Left;
            TXT_RTN.TrailingIcon = null;
            TXT_RTN.UseSystemPasswordChar = false;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(827, 685);
            materialButton3.Margin = new Padding(4, 7, 4, 7);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(77, 36);
            materialButton3.TabIndex = 18;
            materialButton3.Text = "Buscar";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click;
            // 
            // FRM_CLIENTES
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 842);
            Controls.Add(materialButton3);
            Controls.Add(materialLabel1);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(pictureBox1);
            Controls.Add(TXT_CEL);
            Controls.Add(TXT_DIR);
            Controls.Add(TXT_NAME);
            Controls.Add(TXT_RTN);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FRM_CLIENTES";
            Padding = new Padding(4, 107, 4, 5);
            Text = "FRM_CLIENTES";
            Load += FRM_CLIENTES_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_CEL;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_DIR;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_NAME;
        private MaterialSkin.Controls.MaterialTextBox2 TXT_RTN;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}