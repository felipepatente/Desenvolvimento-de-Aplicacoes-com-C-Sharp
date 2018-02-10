namespace IdadeAlunosMatriculados
{
    partial class frmIdadeAlunosMatriculados
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUltimoNascimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCatetoria = new System.Windows.Forms.Label();
            this.lblHoje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(351, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(11, 76);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(167, 26);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Identificar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Ano de Nascimento:";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(134, 46);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(63, 20);
            this.txtNascimento.TabIndex = 4;
            this.txtNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtUltimoNascimento_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "An&o Último Nascimento:";
            // 
            // txtUltimoNascimento
            // 
            this.txtUltimoNascimento.Location = new System.Drawing.Point(360, 50);
            this.txtUltimoNascimento.Name = "txtUltimoNascimento";
            this.txtUltimoNascimento.Size = new System.Drawing.Size(53, 20);
            this.txtUltimoNascimento.TabIndex = 6;
            this.txtUltimoNascimento.Enter += new System.EventHandler(this.txtUltimoNascimento_Enter);
            this.txtUltimoNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtUltimoNascimento_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // lblCatetoria
            // 
            this.lblCatetoria.BackColor = System.Drawing.Color.Yellow;
            this.lblCatetoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCatetoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatetoria.Location = new System.Drawing.Point(277, 82);
            this.lblCatetoria.Name = "lblCatetoria";
            this.lblCatetoria.Size = new System.Drawing.Size(136, 16);
            this.lblCatetoria.TabIndex = 8;
            this.lblCatetoria.Text = "                                          ";
            this.lblCatetoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoje
            // 
            this.lblHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoje.Location = new System.Drawing.Point(12, 108);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(129, 16);
            this.lblHoje.TabIndex = 9;
            this.lblHoje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIdadeAlunosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 133);
            this.Controls.Add(this.lblHoje);
            this.Controls.Add(this.lblCatetoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUltimoNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmIdadeAlunosMatriculados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrícula de aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUltimoNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCatetoria;
        private System.Windows.Forms.Label lblHoje;
    }
}