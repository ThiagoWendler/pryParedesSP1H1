namespace pryParedesSP1H1
{
    partial class frmProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduccion));
            this.cbxLocalidad = new System.Windows.Forms.ComboBox();
            this.cbxCultivo = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantida = new System.Windows.Forms.Label();
            this.btnCrearProd = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocalidad.FormattingEnabled = true;
            this.cbxLocalidad.Location = new System.Drawing.Point(41, 30);
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cbxLocalidad.TabIndex = 15;
            this.cbxLocalidad.SelectedIndexChanged += new System.EventHandler(this.cbxLocalidad_SelectedIndexChanged);
            // 
            // cbxCultivo
            // 
            this.cbxCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCultivo.FormattingEnabled = true;
            this.cbxCultivo.Location = new System.Drawing.Point(41, 84);
            this.cbxCultivo.Name = "cbxCultivo";
            this.cbxCultivo.Size = new System.Drawing.Size(121, 21);
            this.cbxCultivo.TabIndex = 16;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(63, 9);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(80, 18);
            this.lblLocalidad.TabIndex = 17;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivo.Location = new System.Drawing.Point(74, 63);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(60, 18);
            this.lblCultivo.TabIndex = 18;
            this.lblCultivo.Text = "Cultivo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(41, 141);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // lblCantida
            // 
            this.lblCantida.AutoSize = true;
            this.lblCantida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantida.Location = new System.Drawing.Point(63, 120);
            this.lblCantida.Name = "lblCantida";
            this.lblCantida.Size = new System.Drawing.Size(74, 18);
            this.lblCantida.TabIndex = 20;
            this.lblCantida.Text = "Cantidad";
            // 
            // btnCrearProd
            // 
            this.btnCrearProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProd.Location = new System.Drawing.Point(41, 208);
            this.btnCrearProd.Name = "btnCrearProd";
            this.btnCrearProd.Size = new System.Drawing.Size(121, 36);
            this.btnCrearProd.TabIndex = 21;
            this.btnCrearProd.Text = "Crear";
            this.btnCrearProd.UseVisualStyleBackColor = true;
            this.btnCrearProd.Click += new System.EventHandler(this.btnCrearProd_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(41, 167);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 35);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnacepta_Click);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 255);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCrearProd);
            this.Controls.Add(this.lblCantida);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cbxCultivo);
            this.Controls.Add(this.cbxLocalidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxLocalidad;
        private System.Windows.Forms.ComboBox cbxCultivo;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantida;
        private System.Windows.Forms.Button btnCrearProd;
        private System.Windows.Forms.Button btnAceptar;
    }
}