namespace Prototipo_MarZel
{
    partial class FRM_PRODUCTOS
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
            dgv_productos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            SuspendLayout();
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Dock = DockStyle.Right;
            dgv_productos.Location = new Point(355, 64);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 51;
            dgv_productos.Size = new Size(442, 383);
            dgv_productos.TabIndex = 0;
            // 
            // FRM_PRODUCTOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_productos);
            Name = "FRM_PRODUCTOS";
            Text = "Menu Productos";
            Load += FRM_PRODUCTOS_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_productos;
    }
}