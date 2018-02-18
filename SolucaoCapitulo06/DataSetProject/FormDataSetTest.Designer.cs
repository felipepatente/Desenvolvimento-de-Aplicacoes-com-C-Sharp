namespace DataSetProject
{
    partial class FormDataSetTest
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
            this.btnCrirarDataSet = new System.Windows.Forms.Button();
            this.btnInserirDados = new System.Windows.Forms.Button();
            this.btnVisualizarXML = new System.Windows.Forms.Button();
            this.btnVisualizarControes = new System.Windows.Forms.Button();
            this.tcResultados = new System.Windows.Forms.TabControl();
            this.tpXML = new System.Windows.Forms.TabPage();
            this.tpComboEGrid = new System.Windows.Forms.TabPage();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.dgCidades = new System.Windows.Forms.DataGridView();
            this.tcResultados.SuspendLayout();
            this.tpXML.SuspendLayout();
            this.tpComboEGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrirarDataSet
            // 
            this.btnCrirarDataSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrirarDataSet.ForeColor = System.Drawing.Color.Blue;
            this.btnCrirarDataSet.Location = new System.Drawing.Point(12, 23);
            this.btnCrirarDataSet.Name = "btnCrirarDataSet";
            this.btnCrirarDataSet.Size = new System.Drawing.Size(125, 28);
            this.btnCrirarDataSet.TabIndex = 0;
            this.btnCrirarDataSet.Text = "Criar DataSet";
            this.btnCrirarDataSet.UseVisualStyleBackColor = true;
            this.btnCrirarDataSet.Click += new System.EventHandler(this.btnCrirarDataSet_Click);
            // 
            // btnInserirDados
            // 
            this.btnInserirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirDados.ForeColor = System.Drawing.Color.Blue;
            this.btnInserirDados.Location = new System.Drawing.Point(158, 23);
            this.btnInserirDados.Name = "btnInserirDados";
            this.btnInserirDados.Size = new System.Drawing.Size(125, 28);
            this.btnInserirDados.TabIndex = 1;
            this.btnInserirDados.Text = "Inserir Dados";
            this.btnInserirDados.UseVisualStyleBackColor = true;
            this.btnInserirDados.Click += new System.EventHandler(this.btnInserirDados_Click);
            // 
            // btnVisualizarXML
            // 
            this.btnVisualizarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarXML.ForeColor = System.Drawing.Color.Blue;
            this.btnVisualizarXML.Location = new System.Drawing.Point(296, 23);
            this.btnVisualizarXML.Name = "btnVisualizarXML";
            this.btnVisualizarXML.Size = new System.Drawing.Size(142, 28);
            this.btnVisualizarXML.TabIndex = 2;
            this.btnVisualizarXML.Text = "Visualizar XML";
            this.btnVisualizarXML.UseVisualStyleBackColor = true;
            this.btnVisualizarXML.Click += new System.EventHandler(this.btnVisualizarXML_Click);
            // 
            // btnVisualizarControes
            // 
            this.btnVisualizarControes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarControes.ForeColor = System.Drawing.Color.Blue;
            this.btnVisualizarControes.Location = new System.Drawing.Point(451, 23);
            this.btnVisualizarControes.Name = "btnVisualizarControes";
            this.btnVisualizarControes.Size = new System.Drawing.Size(152, 28);
            this.btnVisualizarControes.TabIndex = 4;
            this.btnVisualizarControes.Text = "Controles Visuais";
            this.btnVisualizarControes.UseVisualStyleBackColor = true;
            this.btnVisualizarControes.Click += new System.EventHandler(this.btnVisualizarControes_Click);
            // 
            // tcResultados
            // 
            this.tcResultados.Controls.Add(this.tpXML);
            this.tcResultados.Controls.Add(this.tpComboEGrid);
            this.tcResultados.Location = new System.Drawing.Point(12, 69);
            this.tcResultados.Name = "tcResultados";
            this.tcResultados.SelectedIndex = 0;
            this.tcResultados.Size = new System.Drawing.Size(591, 405);
            this.tcResultados.TabIndex = 5;
            // 
            // tpXML
            // 
            this.tpXML.Controls.Add(this.txtXML);
            this.tpXML.Location = new System.Drawing.Point(4, 22);
            this.tpXML.Name = "tpXML";
            this.tpXML.Padding = new System.Windows.Forms.Padding(3);
            this.tpXML.Size = new System.Drawing.Size(583, 379);
            this.tpXML.TabIndex = 0;
            this.tpXML.Text = "Dados em XML";
            this.tpXML.UseVisualStyleBackColor = true;
            // 
            // tpComboEGrid
            // 
            this.tpComboEGrid.Controls.Add(this.dgCidades);
            this.tpComboEGrid.Controls.Add(this.cbEstados);
            this.tpComboEGrid.Controls.Add(this.label1);
            this.tpComboEGrid.Location = new System.Drawing.Point(4, 22);
            this.tpComboEGrid.Name = "tpComboEGrid";
            this.tpComboEGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tpComboEGrid.Size = new System.Drawing.Size(583, 379);
            this.tpComboEGrid.TabIndex = 1;
            this.tpComboEGrid.Text = "Dados em Controles";
            this.tpComboEGrid.UseVisualStyleBackColor = true;
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(6, 6);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(571, 367);
            this.txtXML.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(87, 16);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(471, 21);
            this.cbEstados.TabIndex = 1;
            // 
            // dgCidades
            // 
            this.dgCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCidades.Location = new System.Drawing.Point(21, 54);
            this.dgCidades.Name = "dgCidades";
            this.dgCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCidades.Size = new System.Drawing.Size(537, 305);
            this.dgCidades.TabIndex = 2;
            // 
            // FormDataSetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 486);
            this.Controls.Add(this.tcResultados);
            this.Controls.Add(this.btnVisualizarControes);
            this.Controls.Add(this.btnVisualizarXML);
            this.Controls.Add(this.btnInserirDados);
            this.Controls.Add(this.btnCrirarDataSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDataSetTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testes com DataSet e seus Componentes";
            this.tcResultados.ResumeLayout(false);
            this.tpXML.ResumeLayout(false);
            this.tpXML.PerformLayout();
            this.tpComboEGrid.ResumeLayout(false);
            this.tpComboEGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrirarDataSet;
        private System.Windows.Forms.Button btnInserirDados;
        private System.Windows.Forms.Button btnVisualizarXML;
        private System.Windows.Forms.Button btnVisualizarControes;
        private System.Windows.Forms.TabControl tcResultados;
        private System.Windows.Forms.TabPage tpXML;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.TabPage tpComboEGrid;
        private System.Windows.Forms.DataGridView dgCidades;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Label label1;
    }
}