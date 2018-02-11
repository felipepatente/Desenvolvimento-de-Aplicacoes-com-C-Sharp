namespace ConsumoEnergiaCondominio
{
    partial class frmConsumoEnergiaCondominio
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(386, 12);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(86, 26);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr. Casa:";
            // 
            // txtCasa
            // 
            this.txtCasa.Location = new System.Drawing.Point(85, 16);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(71, 20);
            this.txtCasa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumo:";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(265, 16);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo.TabIndex = 4;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.Location = new System.Drawing.Point(15, 365);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(86, 26);
            this.btnProcessar.TabIndex = 5;
            this.btnProcessar.Text = "Processar Dados";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(134, 369);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(338, 18);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Location = new System.Drawing.Point(15, 53);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.Size = new System.Drawing.Size(457, 292);
            this.dgvLeituras.TabIndex = 7;
            // 
            // frmConsumoEnergiaCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 406);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsumoEnergiaCondominio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsumoEnergiaCondominio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvLeituras;
    }
}