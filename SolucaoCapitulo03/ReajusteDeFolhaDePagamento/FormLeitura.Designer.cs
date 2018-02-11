namespace ReajusteDeFolhaDePagamento
{
    partial class FormLeitura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroFuncionarios = new System.Windows.Forms.TextBox();
            this.btnCriarLinhas = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. de Funcionários:";
            // 
            // txtNumeroFuncionarios
            // 
            this.txtNumeroFuncionarios.Location = new System.Drawing.Point(160, 15);
            this.txtNumeroFuncionarios.Name = "txtNumeroFuncionarios";
            this.txtNumeroFuncionarios.Size = new System.Drawing.Size(44, 20);
            this.txtNumeroFuncionarios.TabIndex = 1;
            // 
            // btnCriarLinhas
            // 
            this.btnCriarLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarLinhas.Location = new System.Drawing.Point(229, 15);
            this.btnCriarLinhas.Name = "btnCriarLinhas";
            this.btnCriarLinhas.Size = new System.Drawing.Size(192, 23);
            this.btnCriarLinhas.TabIndex = 2;
            this.btnCriarLinhas.Text = "Criar linhas para registro";
            this.btnCriarLinhas.UseVisualStyleBackColor = true;
            this.btnCriarLinhas.Click += new System.EventHandler(this.btnCriarLinhas_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(15, 58);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(405, 157);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(229, 237);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(107, 23);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Enabled = false;
            this.btnCriarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarArquivo.Location = new System.Drawing.Point(94, 237);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(113, 23);
            this.btnCriarArquivo.TabIndex = 5;
            this.btnCriarArquivo.Text = "Criar arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos textos|*.txt";
            this.sfdGravarArquivo.Title = "Dados para geração de arquivo";
            // 
            // FormLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 281);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCriarLinhas);
            this.Controls.Add(this.txtNumeroFuncionarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLeitura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados para geração de arquivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroFuncionarios;
        private System.Windows.Forms.Button btnCriarLinhas;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
    }
}