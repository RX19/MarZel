
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
            PicBox_Login = new PictureBox();
            USR_TXB_LOGIN = new MaterialSkin.Controls.MaterialTextBox();
            PSW_TXB_LOGIN = new MaterialSkin.Controls.MaterialTextBox();
            BTN_LOGIN = new MaterialSkin.Controls.MaterialButton();
            SHW_CHK_LOGIN = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)PicBox_Login).BeginInit();
            SuspendLayout();
            // 
            // PicBox_Login
            // 
            PicBox_Login.Image = (Image)resources.GetObject("PicBox_Login.Image");
            PicBox_Login.Location = new Point(5, 68);
            PicBox_Login.Name = "PicBox_Login";
            PicBox_Login.Size = new Size(343, 377);
            PicBox_Login.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_Login.TabIndex = 0;
            PicBox_Login.TabStop = false;
            // 
            // USR_TXB_LOGIN
            // 
            USR_TXB_LOGIN.AnimateReadOnly = false;
            USR_TXB_LOGIN.BorderStyle = BorderStyle.None;
            USR_TXB_LOGIN.Depth = 0;
            USR_TXB_LOGIN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            USR_TXB_LOGIN.Hint = "Usuario";
            USR_TXB_LOGIN.LeadingIcon = null;
            USR_TXB_LOGIN.Location = new Point(413, 133);
            USR_TXB_LOGIN.MaxLength = 50;
            USR_TXB_LOGIN.MouseState = MaterialSkin.MouseState.OUT;
            USR_TXB_LOGIN.Multiline = false;
            USR_TXB_LOGIN.Name = "USR_TXB_LOGIN";
            USR_TXB_LOGIN.Size = new Size(220, 50);
            USR_TXB_LOGIN.TabIndex = 3;
            USR_TXB_LOGIN.Text = "";
            USR_TXB_LOGIN.TrailingIcon = null;
            // 
            // PSW_TXB_LOGIN
            // 
            PSW_TXB_LOGIN.AnimateReadOnly = false;
            PSW_TXB_LOGIN.BorderStyle = BorderStyle.None;
            PSW_TXB_LOGIN.Depth = 0;
            PSW_TXB_LOGIN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PSW_TXB_LOGIN.Hint = "Contraseña";
            PSW_TXB_LOGIN.LeadingIcon = null;
            PSW_TXB_LOGIN.Location = new Point(413, 219);
            PSW_TXB_LOGIN.MaxLength = 50;
            PSW_TXB_LOGIN.MouseState = MaterialSkin.MouseState.OUT;
            PSW_TXB_LOGIN.Multiline = false;
            PSW_TXB_LOGIN.Name = "PSW_TXB_LOGIN";
            PSW_TXB_LOGIN.Password = true;
            PSW_TXB_LOGIN.Size = new Size(220, 50);
            PSW_TXB_LOGIN.TabIndex = 4;
            PSW_TXB_LOGIN.Text = "";
            PSW_TXB_LOGIN.TrailingIcon = null;
            PSW_TXB_LOGIN.TextChanged += PSW_TXB_LOGIN_TextChanged;
            // 
            // BTN_LOGIN
            // 
            BTN_LOGIN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BTN_LOGIN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BTN_LOGIN.Depth = 0;
            BTN_LOGIN.HighEmphasis = true;
            BTN_LOGIN.Icon = null;
            BTN_LOGIN.Location = new Point(470, 356);
            BTN_LOGIN.Margin = new Padding(4, 6, 4, 6);
            BTN_LOGIN.MouseState = MaterialSkin.MouseState.HOVER;
            BTN_LOGIN.Name = "BTN_LOGIN";
            BTN_LOGIN.NoAccentTextColor = Color.Empty;
            BTN_LOGIN.Size = new Size(104, 36);
            BTN_LOGIN.TabIndex = 5;
            BTN_LOGIN.Text = " COMENZAR";
            BTN_LOGIN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BTN_LOGIN.UseAccentColor = false;
            BTN_LOGIN.UseVisualStyleBackColor = true;
            BTN_LOGIN.Click += materialButton1_Click;
            // 
            // SHW_CHK_LOGIN
            // 
            SHW_CHK_LOGIN.AutoSize = true;
            SHW_CHK_LOGIN.Depth = 0;
            SHW_CHK_LOGIN.Location = new Point(413, 300);
            SHW_CHK_LOGIN.Margin = new Padding(0);
            SHW_CHK_LOGIN.MouseLocation = new Point(-1, -1);
            SHW_CHK_LOGIN.MouseState = MaterialSkin.MouseState.HOVER;
            SHW_CHK_LOGIN.Name = "SHW_CHK_LOGIN";
            SHW_CHK_LOGIN.ReadOnly = false;
            SHW_CHK_LOGIN.Ripple = true;
            SHW_CHK_LOGIN.Size = new Size(175, 37);
            SHW_CHK_LOGIN.TabIndex = 6;
            SHW_CHK_LOGIN.Text = "Mostrar Contraseña";
            SHW_CHK_LOGIN.UseVisualStyleBackColor = true;
            SHW_CHK_LOGIN.CheckedChanged += SHW_CHK_LOGIN_CheckedChanged;
            // 
            // FRM_LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 453);
            Controls.Add(SHW_CHK_LOGIN);
            Controls.Add(BTN_LOGIN);
            Controls.Add(PSW_TXB_LOGIN);
            Controls.Add(USR_TXB_LOGIN);
            Controls.Add(PicBox_Login);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO DE SESION";
            Load += FRM_LOGIN_Load;
            ((System.ComponentModel.ISupportInitialize)PicBox_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => BTN_LOGIN.Focus()));

        }

        #endregion

        private PictureBox PicBox_Login;
        private MaterialSkin.Controls.MaterialTextBox USR_TXB_LOGIN;
        private MaterialSkin.Controls.MaterialTextBox PSW_TXB_LOGIN;
        private MaterialSkin.Controls.MaterialButton BTN_LOGIN;
        private MaterialSkin.Controls.MaterialCheckbox SHW_CHK_LOGIN;
    }
}