namespace IndustrialTP2
{
    partial class Form1
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
            this.btnABM = new MetroFramework.Controls.MetroTile();
            this.btnExplosion = new MetroFramework.Controls.MetroTile();
            this.btnImplosion = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnABM
            // 
            this.btnABM.ActiveControl = null;
            this.btnABM.Location = new System.Drawing.Point(90, 88);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(102, 50);
            this.btnABM.TabIndex = 0;
            this.btnABM.Text = "ABM";
            this.btnABM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnABM.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnABM.UseSelectable = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // btnExplosion
            // 
            this.btnExplosion.ActiveControl = null;
            this.btnExplosion.Location = new System.Drawing.Point(90, 168);
            this.btnExplosion.Name = "btnExplosion";
            this.btnExplosion.Size = new System.Drawing.Size(102, 51);
            this.btnExplosion.TabIndex = 1;
            this.btnExplosion.Text = "EXPLOSION";
            this.btnExplosion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExplosion.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnExplosion.UseSelectable = true;
            // 
            // btnImplosion
            // 
            this.btnImplosion.ActiveControl = null;
            this.btnImplosion.Location = new System.Drawing.Point(90, 252);
            this.btnImplosion.Name = "btnImplosion";
            this.btnImplosion.Size = new System.Drawing.Size(102, 50);
            this.btnImplosion.TabIndex = 2;
            this.btnImplosion.Text = "IMPLOSION";
            this.btnImplosion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImplosion.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnImplosion.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 348);
            this.Controls.Add(this.btnImplosion);
            this.Controls.Add(this.btnExplosion);
            this.Controls.Add(this.btnABM);
            this.Name = "Form1";
            this.Text = "Lista de Materiales";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnABM;
        private MetroFramework.Controls.MetroTile btnExplosion;
        private MetroFramework.Controls.MetroTile btnImplosion;
    }
}

