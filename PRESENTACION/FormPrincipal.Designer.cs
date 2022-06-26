namespace AppPublicarPrecios.PRESENTACION
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new RJCodeAdvance.RJControls.RJButton();
            this.btnAyuda = new RJCodeAdvance.RJControls.RJButton();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new RJCodeAdvance.RJControls.RJButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPublicar = new RJCodeAdvance.RJControls.RJButton();
            this.lblTotalCodigoProducto = new System.Windows.Forms.Label();
            this.lblTotalCodigoProveedores = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.BackgroundColor = System.Drawing.Color.Red;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 40);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAyuda.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAyuda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAyuda.BorderRadius = 0;
            this.btnAyuda.BorderSize = 0;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(12, 352);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(150, 40);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextColor = System.Drawing.Color.White;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProductos.Location = new System.Drawing.Point(332, 39);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(172, 322);
            this.dgvProductos.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Productos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeColumns = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProveedores.EnableHeadersVisualStyles = false;
            this.dgvProveedores.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProveedores.Location = new System.Drawing.Point(510, 39);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowTemplate.Height = 25;
            this.dgvProveedores.Size = new System.Drawing.Size(172, 322);
            this.dgvProveedores.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "Proveedores";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 0;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(12, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 40);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPublicar.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPublicar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPublicar.BorderRadius = 0;
            this.btnPublicar.BorderSize = 0;
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.ForeColor = System.Drawing.Color.White;
            this.btnPublicar.Location = new System.Drawing.Point(12, 150);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(150, 40);
            this.btnPublicar.TabIndex = 8;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.TextColor = System.Drawing.Color.White;
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // lblTotalCodigoProducto
            // 
            this.lblTotalCodigoProducto.AutoSize = true;
            this.lblTotalCodigoProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCodigoProducto.Location = new System.Drawing.Point(332, 377);
            this.lblTotalCodigoProducto.Name = "lblTotalCodigoProducto";
            this.lblTotalCodigoProducto.Size = new System.Drawing.Size(0, 20);
            this.lblTotalCodigoProducto.TabIndex = 9;
            // 
            // lblTotalCodigoProveedores
            // 
            this.lblTotalCodigoProveedores.AutoSize = true;
            this.lblTotalCodigoProveedores.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCodigoProveedores.Location = new System.Drawing.Point(510, 377);
            this.lblTotalCodigoProveedores.Name = "lblTotalCodigoProveedores";
            this.lblTotalCodigoProveedores.Size = new System.Drawing.Size(0, 20);
            this.lblTotalCodigoProveedores.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(332, 377);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 11;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalCodigoProveedores);
            this.Controls.Add(this.lblTotalCodigoProducto);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnSalir;
        private RJCodeAdvance.RJControls.RJButton btnAyuda;
        private DataGridView dgvProductos;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private RJCodeAdvance.RJControls.RJButton btnBuscar;
        private OpenFileDialog openFileDialog1;
        private RJCodeAdvance.RJControls.RJButton btnPublicar;
        private Label lblTotalCodigoProducto;
        private Label lblTotalCodigoProveedores;
        private Label lblTotal;
    }
}