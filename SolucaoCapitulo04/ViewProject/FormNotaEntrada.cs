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
    public partial class FormNotaEntrada : Form
    {
        private NotaEntradaController controller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;

        private NotaEntrada notaAtual;

        public FormNotaEntrada(NotaEntradaController controller,
            FornecedorController fornecedorController,
            ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicializarComboBoxs();
        }

        private void InicializarComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();

            foreach (Fornecedor  fornecedor in this.fornecedorController.GetAll())
            {
                cbxFornecedor.Items.Add(fornecedor);
            }

            foreach (Produto produto in this.produtoController.GetAll())
            {
                cbxProduto.Items.Add(produto.Descricao);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void ClearControlsNota()
        {
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            txtIdNotaEntrada.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cbxFornecedor.Focus();            
        }

        private void btnGravarNota_Click(object sender, EventArgs e)
        {
            var notaEntrada = new NotaEntrada()
            {
                Id = (txtIdNotaEntrada.Text == string.Empty ?
                Guid.NewGuid() : new Guid(txtIdNotaEntrada.Text)),
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                FornecedorNota = (Fornecedor) cbxFornecedor.SelectedItem,
                Numero = txtNumero.Text
            };

            notaEntrada = (txtIdNotaEntrada.Text == string.Empty ?
                this.controller.Insert(notaEntrada) :
                this.controller.Update(notaEntrada));
            dgvNotasEntrada.DataSource = null;
            dgvNotasEntrada.DataSource = this.controller.GetAll();
            ClearControlsNota();
        }

        private void btnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void btnRemoverNota_Click(object sender, EventArgs e)
        {
            if (txtIdNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA a ser removida no GRID");
            }else
            {
                this.controller.Remove(
                    new NotaEntrada()
                    {
                        Id = new Guid(txtIdNotaEntrada.Text)
                    }
                );
                dgvNotasEntrada.DataSource = null;
                dgvNotasEntrada.DataSource = this.controller.GetAll();
                ClearControlsNota();                
            }
        }

        private void dgvNotasEntrada_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.
                    GetNotaEntradaById((Guid)dgvNotasEntrada.
                    CurrentRow.Cells[0].Value);
                txtIdNotaEntrada.Text = notaAtual.Id.
                    ToString();
                txtNumero.Text = notaAtual.Numero;
                cbxFornecedor.SelectedItem = notaAtual.
                    FornecedorNota;
                dtpEmissao.Value = notaAtual.DataEmissao;
                dtpEntrada.Value = notaAtual.DataEntrada;
                UpdateProdutosGrid();
            }
            catch
            {
                this.notaAtual = new NotaEntrada();
            }
        }

        private void UpdateProdutosGrid()
        {
            dgvProdutos.DataSource = null;

            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvProdutos.DataSource = this.notaAtual.Produtos;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            if (txtIdNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA, que terá inserção de produtos, no GRID");
            }else
            {
                ChangeStatusOfControls(true);
            }
        }

        private void ChangeStatusOfControls(bool newStatus)
        {
            cbxProduto.Enabled = newStatus;
            txtCusto.Enabled = newStatus;
            txtQuantidade.Enabled = newStatus;
            btnNovoProduto.Enabled = !newStatus;
            btnGravarProduto.Enabled = newStatus;
            btnCancelarProduto.Enabled = newStatus;
            btnRemoverProduto.Enabled = newStatus;
        }

        private void btnGravarProduto_Click(object sender, EventArgs e)
        {
            var produtoNota = new ProdutoNotaEntrada()
            {
                Id = (txtIdProduto.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIdProduto.Text)),
                ProdutoNota = cbxProduto.SelectedItem.ToString(),
                PrecoCustoCompra = Convert.ToDouble(txtCusto.Text),
                QuantidadeComprada = Convert.ToDouble(txtQuantidade.Text)
            };

            this.notaAtual.RegistrarProduto(produtoNota);
            this.notaAtual = this.controller.Update(this.notaAtual);
            ChangeStatusOfControls(false);
            UpdateProdutosGrid();
            ClearControlsProduto();                        
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            ChangeStatusOfControls(false);
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            this.notaAtual.RemoverProduto(new ProdutoNotaEntrada()
            {
                Id = new Guid(txtIdProduto.Text)
            });

            this.controller.Update(this.notaAtual);
            UpdateProdutosGrid();
            ClearControlsProduto();
            ChangeStatusOfControls(false);
        }

        private void ClearControlsProduto()
        {
            txtIdProduto.Text = string.Empty;
            cbxProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            dgvProdutos.ClearSelection();
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count != 0 && dgvProdutos.SelectedRows[0].Cells[0].Value != null)
            {
                txtIdProduto.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                cbxProduto.SelectedItem = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                txtCusto.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                txtQuantidade.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
