namespace pryParedesSP1H1
{
    partial class frmAgricultura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgricultura));
            this.mspAgricultura = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mspAgricultura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mspAgricultura
            // 
            this.mspAgricultura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mspAgricultura.Location = new System.Drawing.Point(0, 0);
            this.mspAgricultura.Name = "mspAgricultura";
            this.mspAgricultura.Size = new System.Drawing.Size(347, 24);
            this.mspAgricultura.TabIndex = 0;
            this.mspAgricultura.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadesToolStripMenuItem,
            this.cultivosToolStripMenuItem,
            this.cantidadToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Image = global::pryParedesSP1H1.Properties.Resources.engra;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Image = global::pryParedesSP1H1.Properties.Resources.pin_gps_location_find_map_search_icon_icons_com_59982;
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // cultivosToolStripMenuItem
            // 
            this.cultivosToolStripMenuItem.Image = global::pryParedesSP1H1.Properties.Resources.amber_1094611;
            this.cultivosToolStripMenuItem.Name = "cultivosToolStripMenuItem";
            this.cultivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cultivosToolStripMenuItem.Text = "Cultivos";
            this.cultivosToolStripMenuItem.Click += new System.EventHandler(this.cultivosToolStripMenuItem_Click);
            // 
            // cantidadToolStripMenuItem
            // 
            this.cantidadToolStripMenuItem.Image = global::pryParedesSP1H1.Properties.Resources.up_sort_amount_icon_195380;
            this.cantidadToolStripMenuItem.Name = "cantidadToolStripMenuItem";
            this.cantidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cantidadToolStripMenuItem.Text = "Produccion";
            this.cantidadToolStripMenuItem.Click += new System.EventHandler(this.cantidadToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::pryParedesSP1H1.Properties.Resources.salir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryParedesSP1H1.Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 112);
            this.Controls.Add(this.mspAgricultura);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspAgricultura;
            this.Name = "frmAgricultura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agricultura - SP1";
            this.mspAgricultura.ResumeLayout(false);
            this.mspAgricultura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspAgricultura;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cantidadToolStripMenuItem;
    }
}

