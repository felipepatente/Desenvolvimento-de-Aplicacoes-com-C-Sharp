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
    public partial class FormProduto : Form
    {
        private ProdutoController controller;

        public FormProduto(ProdutoController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            dgvProdutos.ClearSelection();
            txtId.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtCusto.Text = string.Empty;
            txtVenda.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtDescricao.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            var produto = new Produto()
            {
                Id = (txtId.Text == string.Empty ? Guid.NewGuid() : new Guid(txtId.Text)),
                Descricao = txtDescricao.Text,
                PrecoDeCusto = Convert.ToDouble(txtCusto.Text),
                PrecoDeVenda = Convert.ToDouble(txtVenda.Text),
                Estoque = Convert.ToDouble(txtEstoque.Text)                
            };

            produto = (txtId.Text == string.Empty ? 
                this.controller.Insert(produto) : 
                this.controller.Update(produto));
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = this.controller.GetAll();
            ClearControls();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o PRODUTO a ser removido no GRID");
            }else
            {
                int index = dgvProdutos.CurrentRow.Index;
                this.controller.Remove(index);
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = this.controller.GetAll();
                ClearControls();
            }            
            }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count != 0 && dgvProdutos.SelectedRows[0].Cells[0].Value != null)
            {
                txtId.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                txtCusto.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                txtVenda.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells[4].Value.ToString();
            }
        }    
    }
}
