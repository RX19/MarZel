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
            MTC_Conetnido = new MaterialSkin.Controls.MaterialCard();
            LBL_PC = new MaterialSkin.Controls.MaterialLabel();
            LBL_PU = new MaterialSkin.Controls.MaterialLabel();
            LBL_CANTIDAD = new MaterialSkin.Controls.MaterialLabel();
            LVL_ISV = new MaterialSkin.Controls.MaterialLabel();
            LBL_DESCRIPCION = new MaterialSkin.Controls.MaterialLabel();
            LBL_CODIGO_BARRA = new MaterialSkin.Controls.MaterialLabel();
            TXT_PC = new MaterialSkin.Controls.MaterialTextBox();
            TXT_PU = new MaterialSkin.Controls.MaterialTextBox();
            TXT_CANTIDAD = new MaterialSkin.Controls.MaterialTextBox();
            TXT_ISV = new MaterialSkin.Controls.MaterialTextBox();
            TXT_DESC = new MaterialSkin.Controls.MaterialTextBox();
            TXT_CODIGO_BARRA = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            MTC_Conetnido.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_productos
            // 
            dgv_productos.BackgroundColor = SystemColors.Control;
            dgv_productos.BorderStyle = BorderStyle.Fixed3D;
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Dock = DockStyle.Left;
            dgv_productos.Location = new Point(3, 64);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 51;
            dgv_productos.Size = new Size(1081, 801);
            dgv_productos.TabIndex = 0;
            dgv_productos.CellClick += dgv_productos_CellClick;
            // 
            // MTC_Conetnido
            // 
            MTC_Conetnido.BackColor = Color.FromArgb(255, 255, 255);
            MTC_Conetnido.BorderStyle = BorderStyle.Fixed3D;
            MTC_Conetnido.Controls.Add(LBL_PC);
            MTC_Conetnido.Controls.Add(LBL_PU);
            MTC_Conetnido.Controls.Add(LBL_CANTIDAD);
            MTC_Conetnido.Controls.Add(LVL_ISV);
            MTC_Conetnido.Controls.Add(LBL_DESCRIPCION);
            MTC_Conetnido.Controls.Add(LBL_CODIGO_BARRA);
            MTC_Conetnido.Controls.Add(TXT_PC);
            MTC_Conetnido.Controls.Add(TXT_PU);
            MTC_Conetnido.Controls.Add(TXT_CANTIDAD);
            MTC_Conetnido.Controls.Add(TXT_ISV);
            MTC_Conetnido.Controls.Add(TXT_DESC);
            MTC_Conetnido.Controls.Add(TXT_CODIGO_BARRA);
            MTC_Conetnido.Depth = 0;
            MTC_Conetnido.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MTC_Conetnido.Location = new Point(1243, 78);
            MTC_Conetnido.Margin = new Padding(14);
            MTC_Conetnido.MouseState = MaterialSkin.MouseState.HOVER;
            MTC_Conetnido.Name = "MTC_Conetnido";
            MTC_Conetnido.Padding = new Padding(14);
            MTC_Conetnido.Size = new Size(540, 534);
            MTC_Conetnido.TabIndex = 1;
            // 
            // LBL_PC
            // 
            LBL_PC.AutoSize = true;
            LBL_PC.Depth = 0;
            LBL_PC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_PC.Location = new Point(351, 447);
            LBL_PC.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_PC.Name = "LBL_PC";
            LBL_PC.Size = new Size(21, 19);
            LBL_PC.TabIndex = 11;
            LBL_PC.Text = "PC";
            // 
            // LBL_PU
            // 
            LBL_PU.AutoSize = true;
            LBL_PU.Depth = 0;
            LBL_PU.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_PU.Location = new Point(91, 449);
            LBL_PU.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_PU.Name = "LBL_PU";
            LBL_PU.Size = new Size(21, 19);
            LBL_PU.TabIndex = 10;
            LBL_PU.Text = "PU";
            // 
            // LBL_CANTIDAD
            // 
            LBL_CANTIDAD.AutoSize = true;
            LBL_CANTIDAD.Depth = 0;
            LBL_CANTIDAD.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CANTIDAD.Location = new Point(28, 293);
            LBL_CANTIDAD.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CANTIDAD.Name = "LBL_CANTIDAD";
            LBL_CANTIDAD.Size = new Size(65, 19);
            LBL_CANTIDAD.TabIndex = 9;
            LBL_CANTIDAD.Text = "Cantidad";
            // 
            // LVL_ISV
            // 
            LVL_ISV.AutoSize = true;
            LVL_ISV.Depth = 0;
            LVL_ISV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LVL_ISV.Location = new Point(28, 203);
            LVL_ISV.MouseState = MaterialSkin.MouseState.HOVER;
            LVL_ISV.Name = "LVL_ISV";
            LVL_ISV.Size = new Size(25, 19);
            LVL_ISV.TabIndex = 8;
            LVL_ISV.Text = "ISV";
            // 
            // LBL_DESCRIPCION
            // 
            LBL_DESCRIPCION.AutoSize = true;
            LBL_DESCRIPCION.Depth = 0;
            LBL_DESCRIPCION.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_DESCRIPCION.Location = new Point(28, 121);
            LBL_DESCRIPCION.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_DESCRIPCION.Name = "LBL_DESCRIPCION";
            LBL_DESCRIPCION.Size = new Size(84, 19);
            LBL_DESCRIPCION.TabIndex = 7;
            LBL_DESCRIPCION.Text = "Descripcion";
            // 
            // LBL_CODIGO_BARRA
            // 
            LBL_CODIGO_BARRA.AutoSize = true;
            LBL_CODIGO_BARRA.Depth = 0;
            LBL_CODIGO_BARRA.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LBL_CODIGO_BARRA.Location = new Point(223, 33);
            LBL_CODIGO_BARRA.MouseState = MaterialSkin.MouseState.HOVER;
            LBL_CODIGO_BARRA.Name = "LBL_CODIGO_BARRA";
            LBL_CODIGO_BARRA.Size = new Size(114, 19);
            LBL_CODIGO_BARRA.TabIndex = 6;
            LBL_CODIGO_BARRA.Text = "Codigo de Barra";
            // 
            // TXT_PC
            // 
            TXT_PC.AnimateReadOnly = false;
            TXT_PC.BorderStyle = BorderStyle.None;
            TXT_PC.Depth = 0;
            TXT_PC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PC.LeadingIcon = null;
            TXT_PC.Location = new Point(378, 447);
            TXT_PC.MaxLength = 50;
            TXT_PC.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PC.Multiline = false;
            TXT_PC.Name = "TXT_PC";
            TXT_PC.ReadOnly = true;
            TXT_PC.Size = new Size(125, 50);
            TXT_PC.TabIndex = 5;
            TXT_PC.Text = "";
            TXT_PC.TrailingIcon = null;
            // 
            // TXT_PU
            // 
            TXT_PU.AnimateReadOnly = false;
            TXT_PU.BorderStyle = BorderStyle.None;
            TXT_PU.Depth = 0;
            TXT_PU.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_PU.LeadingIcon = null;
            TXT_PU.Location = new Point(121, 447);
            TXT_PU.MaxLength = 50;
            TXT_PU.MouseState = MaterialSkin.MouseState.OUT;
            TXT_PU.Multiline = false;
            TXT_PU.Name = "TXT_PU";
            TXT_PU.ReadOnly = true;
            TXT_PU.Size = new Size(125, 50);
            TXT_PU.TabIndex = 4;
            TXT_PU.Text = "";
            TXT_PU.TrailingIcon = null;
            // 
            // TXT_CANTIDAD
            // 
            TXT_CANTIDAD.AnimateReadOnly = false;
            TXT_CANTIDAD.BorderStyle = BorderStyle.None;
            TXT_CANTIDAD.Depth = 0;
            TXT_CANTIDAD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_CANTIDAD.LeadingIcon = null;
            TXT_CANTIDAD.Location = new Point(141, 291);
            TXT_CANTIDAD.MaxLength = 50;
            TXT_CANTIDAD.MouseState = MaterialSkin.MouseState.OUT;
            TXT_CANTIDAD.Multiline = false;
            TXT_CANTIDAD.Name = "TXT_CANTIDAD";
            TXT_CANTIDAD.ReadOnly = true;
            TXT_CANTIDAD.Size = new Size(186, 50);
            TXT_CANTIDAD.TabIndex = 3;
            TXT_CANTIDAD.Text = "";
            TXT_CANTIDAD.TrailingIcon = null;
            // 
            // TXT_ISV
            // 
            TXT_ISV.AnimateReadOnly = false;
            TXT_ISV.BorderStyle = BorderStyle.None;
            TXT_ISV.Depth = 0;
            TXT_ISV.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_ISV.LeadingIcon = null;
            TXT_ISV.Location = new Point(141, 203);
            TXT_ISV.MaxLength = 50;
            TXT_ISV.MouseState = MaterialSkin.MouseState.OUT;
            TXT_ISV.Multiline = false;
            TXT_ISV.Name = "TXT_ISV";
            TXT_ISV.ReadOnly = true;
            TXT_ISV.Size = new Size(186, 50);
            TXT_ISV.TabIndex = 2;
            TXT_ISV.Text = "";
            TXT_ISV.TrailingIcon = null;
            // 
            // TXT_DESC
            // 
            TXT_DESC.AnimateReadOnly = false;
            TXT_DESC.BorderStyle = BorderStyle.None;
            TXT_DESC.Depth = 0;
            TXT_DESC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_DESC.LeadingIcon = null;
            TXT_DESC.Location = new Point(141, 121);
            TXT_DESC.MaxLength = 50;
            TXT_DESC.MouseState = MaterialSkin.MouseState.OUT;
            TXT_DESC.Multiline = false;
            TXT_DESC.Name = "TXT_DESC";
            TXT_DESC.ReadOnly = true;
            TXT_DESC.Size = new Size(186, 50);
            TXT_DESC.TabIndex = 1;
            TXT_DESC.Text = "";
            TXT_DESC.TrailingIcon = null;
            // 
            // TXT_CODIGO_BARRA
            // 
            TXT_CODIGO_BARRA.AnimateReadOnly = false;
            TXT_CODIGO_BARRA.BorderStyle = BorderStyle.None;
            TXT_CODIGO_BARRA.Depth = 0;
            TXT_CODIGO_BARRA.DetectUrls = false;
            TXT_CODIGO_BARRA.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TXT_CODIGO_BARRA.LeadingIcon = null;
            TXT_CODIGO_BARRA.Location = new Point(351, 17);
            TXT_CODIGO_BARRA.MaxLength = 50;
            TXT_CODIGO_BARRA.MouseState = MaterialSkin.MouseState.OUT;
            TXT_CODIGO_BARRA.Multiline = false;
            TXT_CODIGO_BARRA.Name = "TXT_CODIGO_BARRA";
            TXT_CODIGO_BARRA.ReadOnly = true;
            TXT_CODIGO_BARRA.Size = new Size(152, 50);
            TXT_CODIGO_BARRA.TabIndex = 0;
            TXT_CODIGO_BARRA.Text = "";
            TXT_CODIGO_BARRA.TrailingIcon = null;
            // 
            // FRM_PRODUCTOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1870, 868);
            Controls.Add(MTC_Conetnido);
            Controls.Add(dgv_productos);
            Name = "FRM_PRODUCTOS";
            Text = "Menu Productos";
            Load += FRM_PRODUCTOS_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            MTC_Conetnido.ResumeLayout(false);
            MTC_Conetnido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_productos;
        private MaterialSkin.Controls.MaterialCard MTC_Conetnido;
        private MaterialSkin.Controls.MaterialTextBox TXT_CODIGO_BARRA;
        private MaterialSkin.Controls.MaterialTextBox TXT_ISV;
        private MaterialSkin.Controls.MaterialTextBox TXT_DESC;
        private MaterialSkin.Controls.MaterialTextBox TXT_CANTIDAD;
        private MaterialSkin.Controls.MaterialLabel LBL_CODIGO_BARRA;
        private MaterialSkin.Controls.MaterialTextBox TXT_PC;
        private MaterialSkin.Controls.MaterialTextBox TXT_PU;
        private MaterialSkin.Controls.MaterialLabel LBL_DESCRIPCION;
        private MaterialSkin.Controls.MaterialLabel LBL_PU;
        private MaterialSkin.Controls.MaterialLabel LBL_CANTIDAD;
        private MaterialSkin.Controls.MaterialLabel LVL_ISV;
        private MaterialSkin.Controls.MaterialLabel LBL_PC;
    }
}