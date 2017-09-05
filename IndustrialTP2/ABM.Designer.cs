namespace IndustrialTP2
{
    partial class ABM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoProducto = new MetroFramework.Controls.MetroTile();
            this.cboSemana = new MetroFramework.Controls.MetroComboBox();
            this.Semana = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarAlternatia = new MetroFramework.Controls.MetroTile();
            this.btnAgregarHijo = new MetroFramework.Controls.MetroTile();
            this.cboAlternativa = new MetroFramework.Controls.MetroComboBox();
            this.cboComponente = new MetroFramework.Controls.MetroComboBox();
            this.cboProductos = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnModificar = new MetroFramework.Controls.MetroTile();
            this.btnEliminar = new MetroFramework.Controls.MetroTile();
            this.btnHecho = new MetroFramework.Controls.MetroTile();
            this.treeViewABM = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewABM);
            this.groupBox1.Controls.Add(this.btnNuevoProducto);
            this.groupBox1.Controls.Add(this.cboSemana);
            this.groupBox1.Controls.Add(this.Semana);
            this.groupBox1.Controls.Add(this.btnAgregarAlternatia);
            this.groupBox1.Controls.Add(this.btnAgregarHijo);
            this.groupBox1.Controls.Add(this.cboAlternativa);
            this.groupBox1.Controls.Add(this.cboComponente);
            this.groupBox1.Controls.Add(this.cboProductos);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.ActiveControl = null;
            this.btnNuevoProducto.Location = new System.Drawing.Point(360, 61);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(163, 36);
            this.btnNuevoProducto.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnNuevoProducto.TabIndex = 12;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoProducto.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoProducto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNuevoProducto.UseSelectable = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // cboSemana
            // 
            this.cboSemana.FormattingEnabled = true;
            this.cboSemana.ItemHeight = 23;
            this.cboSemana.Location = new System.Drawing.Point(106, 24);
            this.cboSemana.Name = "cboSemana";
            this.cboSemana.Size = new System.Drawing.Size(236, 29);
            this.cboSemana.TabIndex = 11;
            this.cboSemana.UseSelectable = true;
            // 
            // Semana
            // 
            this.Semana.AutoSize = true;
            this.Semana.Location = new System.Drawing.Point(6, 27);
            this.Semana.Name = "Semana";
            this.Semana.Size = new System.Drawing.Size(56, 19);
            this.Semana.TabIndex = 10;
            this.Semana.Text = "Semana";
            // 
            // btnAgregarAlternatia
            // 
            this.btnAgregarAlternatia.ActiveControl = null;
            this.btnAgregarAlternatia.Location = new System.Drawing.Point(360, 150);
            this.btnAgregarAlternatia.Name = "btnAgregarAlternatia";
            this.btnAgregarAlternatia.Size = new System.Drawing.Size(163, 43);
            this.btnAgregarAlternatia.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAgregarAlternatia.TabIndex = 9;
            this.btnAgregarAlternatia.Text = "Agregar Alternativa";
            this.btnAgregarAlternatia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarAlternatia.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAgregarAlternatia.UseSelectable = true;
            this.btnAgregarAlternatia.Click += new System.EventHandler(this.btnAgregarAlternatia_Click);
            // 
            // btnAgregarHijo
            // 
            this.btnAgregarHijo.ActiveControl = null;
            this.btnAgregarHijo.Location = new System.Drawing.Point(360, 103);
            this.btnAgregarHijo.Name = "btnAgregarHijo";
            this.btnAgregarHijo.Size = new System.Drawing.Size(163, 41);
            this.btnAgregarHijo.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAgregarHijo.TabIndex = 8;
            this.btnAgregarHijo.Text = "Agregar Hijo";
            this.btnAgregarHijo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarHijo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAgregarHijo.UseSelectable = true;
            this.btnAgregarHijo.Click += new System.EventHandler(this.btnAgregarHijo_Click);
            // 
            // cboAlternativa
            // 
            this.cboAlternativa.FormattingEnabled = true;
            this.cboAlternativa.ItemHeight = 23;
            this.cboAlternativa.Location = new System.Drawing.Point(106, 164);
            this.cboAlternativa.Name = "cboAlternativa";
            this.cboAlternativa.Size = new System.Drawing.Size(236, 29);
            this.cboAlternativa.TabIndex = 7;
            this.cboAlternativa.UseSelectable = true;
            // 
            // cboComponente
            // 
            this.cboComponente.FormattingEnabled = true;
            this.cboComponente.ItemHeight = 23;
            this.cboComponente.Location = new System.Drawing.Point(106, 115);
            this.cboComponente.Name = "cboComponente";
            this.cboComponente.Size = new System.Drawing.Size(236, 29);
            this.cboComponente.TabIndex = 6;
            this.cboComponente.UseSelectable = true;
            this.cboComponente.SelectedIndexChanged += new System.EventHandler(this.cboComponente_SelectedIndexChanged);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.ItemHeight = 23;
            this.cboProductos.Location = new System.Drawing.Point(106, 69);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(236, 29);
            this.cboProductos.TabIndex = 5;
            this.cboProductos.UseSelectable = true;
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Estructura Final:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Alternativa:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Componente:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Producto:";
            // 
            // btnModificar
            // 
            this.btnModificar.ActiveControl = null;
            this.btnModificar.Location = new System.Drawing.Point(30, 540);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(233, 41);
            this.btnModificar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnModificar.UseSelectable = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveControl = null;
            this.btnEliminar.Location = new System.Drawing.Point(269, 540);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(250, 41);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnEliminar.UseSelectable = true;
            // 
            // btnHecho
            // 
            this.btnHecho.ActiveControl = null;
            this.btnHecho.Location = new System.Drawing.Point(526, 540);
            this.btnHecho.Name = "btnHecho";
            this.btnHecho.Size = new System.Drawing.Size(232, 41);
            this.btnHecho.TabIndex = 3;
            this.btnHecho.Text = "Hecho";
            this.btnHecho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHecho.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnHecho.UseSelectable = true;
            this.btnHecho.Click += new System.EventHandler(this.btnHecho_Click);
            // 
            // treeViewABM
            // 
            this.treeViewABM.Location = new System.Drawing.Point(7, 236);
            this.treeViewABM.Name = "treeViewABM";
            this.treeViewABM.Size = new System.Drawing.Size(727, 199);
            this.treeViewABM.TabIndex = 13;
            // 
            // ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 604);
            this.Controls.Add(this.btnHecho);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABM";
            this.Text = "ABM";
            this.Load += new System.EventHandler(this.ABM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btnAgregarAlternatia;
        private MetroFramework.Controls.MetroTile btnAgregarHijo;
        private MetroFramework.Controls.MetroComboBox cboAlternativa;
        private MetroFramework.Controls.MetroComboBox cboComponente;
        private MetroFramework.Controls.MetroComboBox cboProductos;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile btnModificar;
        private MetroFramework.Controls.MetroTile btnEliminar;
        private MetroFramework.Controls.MetroTile btnHecho;
        private MetroFramework.Controls.MetroComboBox cboSemana;
        private MetroFramework.Controls.MetroLabel Semana;
        private MetroFramework.Controls.MetroTile btnNuevoProducto;
        private System.Windows.Forms.TreeView treeViewABM;
    }
}