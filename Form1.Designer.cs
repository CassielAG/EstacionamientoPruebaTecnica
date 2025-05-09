namespace Estacionamiento
{
    partial class FrmEst
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
            this.txtBxPlaca = new System.Windows.Forms.TextBox();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.cmBxTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxPlaca
            // 
            this.txtBxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPlaca.Location = new System.Drawing.Point(34, 35);
            this.txtBxPlaca.Name = "txtBxPlaca";
            this.txtBxPlaca.Size = new System.Drawing.Size(721, 36);
            this.txtBxPlaca.TabIndex = 0;
            this.txtBxPlaca.Text = "Ingresa tu número de placa";
            this.txtBxPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(136, 186);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(192, 43);
            this.btnRegistrarEntrada.TabIndex = 1;
            this.btnRegistrarEntrada.Text = "Registrar entrada";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AllowUserToAddRows = false;
            this.dtGrdVw.AllowUserToDeleteRows = false;
            this.dtGrdVw.AllowUserToOrderColumns = true;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Location = new System.Drawing.Point(34, 255);
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.RowHeadersWidth = 51;
            this.dtGrdVw.RowTemplate.Height = 24;
            this.dtGrdVw.Size = new System.Drawing.Size(721, 233);
            this.dtGrdVw.TabIndex = 2;
            this.dtGrdVw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVw_CellClick);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(257, 99);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(269, 24);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Selecciona un tipo de vehículo";
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSalida.Location = new System.Drawing.Point(467, 186);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(167, 43);
            this.btnRegistrarSalida.TabIndex = 7;
            this.btnRegistrarSalida.Text = "Registrar Salida";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // cmBxTipo
            // 
            this.cmBxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxTipo.FormattingEnabled = true;
            this.cmBxTipo.Items.AddRange(new object[] {
            "Residente",
            "No residente",
            "Vehiculo oficial"});
            this.cmBxTipo.Location = new System.Drawing.Point(236, 136);
            this.cmBxTipo.Name = "cmBxTipo";
            this.cmBxTipo.Size = new System.Drawing.Size(304, 28);
            this.cmBxTipo.TabIndex = 8;
            // 
            // FrmEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.cmBxTipo);
            this.Controls.Add(this.btnRegistrarSalida);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.dtGrdVw);
            this.Controls.Add(this.btnRegistrarEntrada);
            this.Controls.Add(this.txtBxPlaca);
            this.Name = "FrmEst";
            this.Text = "Estacionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxPlaca;
        private System.Windows.Forms.Button btnRegistrarEntrada;
        private System.Windows.Forms.DataGridView dtGrdVw;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.ComboBox cmBxTipo;
    }
}

