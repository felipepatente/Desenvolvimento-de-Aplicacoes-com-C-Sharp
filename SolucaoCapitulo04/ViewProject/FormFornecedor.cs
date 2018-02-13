using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller;

        public FormFornecedor(FornecedorController controller)
        {           
            InitializeComponent();
            this.controller = controller;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
            {
                Id = (txtId.Text == string.Empty ? Guid.NewGuid() : new Guid(txtId.Text)),
                Nome = txtNome.Text,
                Cnpj = txtCnpj.Text
            };
            
            fornecedor = (txtId.Text == string.Empty ?
            this.controller.Insert(fornecedor) :
            this.controller.Update(fornecedor));            
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
            ClearControls();
            
        }

        private void ClearControls()
        {
            dgvFornecedores.ClearSelection();
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCnpj.Text = string.Empty;
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count != 0 && dgvFornecedores.SelectedRows[0].Cells[0].Value != null)
            {
                txtId.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
                txtCnpj.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            

            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o FORNECEDOR  a ser removido no GRID");
            }else
            {
                
                int index = dgvFornecedores.CurrentRow.Index;
                this.controller.Remove(index);

                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = this.controller.GetAll();
                ClearControls();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
