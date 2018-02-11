namespace ReajusteDeFolhaDePagamento
{
    partial class FrmReajusteDeFolhaDePagamento
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
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblPercentualDoReajuste = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(12, 165);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.Size = new System.Drawing.Size(555, 150);
            this.dgvLeitura.TabIndex = 0;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(13, 22);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(523, 20);
            this.txtArquivo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(13, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 89);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.1385F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8615F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSemReajuste, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualDoReajuste, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComReajuste, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total sem reajuste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LawnGreen;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(151, 2);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(174, 27);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Total com reajuste";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(5, 29);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(140, 28);
            this.lblTotalSemReajuste.TabIndex = 3;
            this.lblTotalSemReajuste.Text = "Resultado";
            this.lblTotalSemReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.Location = new System.Drawing.Point(151, 29);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(174, 28);
            this.lblTotalComReajuste.TabIndex = 4;
            this.lblTotalComReajuste.Text = "Resultado";
            this.lblTotalComReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentualDoReajuste
            // 
            this.lblPercentualDoReajuste.AutoSize = true;
            this.lblPercentualDoReajuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPercentualDoReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualDoReajuste.Location = new System.Drawing.Point(331, 29);
            this.lblPercentualDoReajuste.Name = "lblPercentualDoReajuste";
            this.lblPercentualDoReajuste.Size = new System.Drawing.Size(175, 28);
            this.lblPercentualDoReajuste.TabIndex = 5;
            this.lblPercentualDoReajuste.Text = "Resultado";
            this.lblPercentualDoReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.LawnGreen;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(331, 2);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(175, 27);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Percentual reajuste";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmReajusteDeFolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.dgvLeitura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmReajusteDeFolhaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitura de arquivo para reajuste de salários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPercentualDoReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.Label lbl;
    }
}