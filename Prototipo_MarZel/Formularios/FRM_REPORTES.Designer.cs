namespace Prototipo_MarZel.Formularios
{
    partial class FRM_REPORTES
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
            WV_Reportes = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WV_Reportes).BeginInit();
            SuspendLayout();
            // 
            // WV_Reportes
            // 
            WV_Reportes.AllowExternalDrop = true;
            WV_Reportes.CreationProperties = null;
            WV_Reportes.DefaultBackgroundColor = Color.White;
            WV_Reportes.Dock = DockStyle.Fill;
            WV_Reportes.Location = new Point(3, 64);
            WV_Reportes.Name = "WV_Reportes";
            WV_Reportes.Size = new Size(794, 383);
            WV_Reportes.TabIndex = 0;
            WV_Reportes.ZoomFactor = 1D;
            // 
            // FRM_REPORTES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WV_Reportes);
            Name = "FRM_REPORTES";
            Text = "FRM_REPORTES";
            Load += FRM_REPORTES_Load;
            ((System.ComponentModel.ISupportInitialize)WV_Reportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WV_Reportes;
    }
}