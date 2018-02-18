using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NETProject01
{
    public partial class FormNotaEntrada : Form
    {
        private DAL_NotaEntrada dal = new DAL_NotaEntrada();
        private DAL_Fornecedor dalFornecedor = new DAL_Fornecedor();
        private DAL_Produtos dalProduto = new DAL_Produtos();
        private DAL_ProdutosComprados dalProdComprados = new DAL_ProdutosComprados();
        private NotaEntrada notaAtual;
        private ProdutoNotaEntrada produtoNotaAtual;

        public FormNotaEntrada()
        {
            InitializeComponent();
            InicializarComboBoxs();
            GetAllNotas();
        }

        private void InicializarComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();
            foreach (Fornecedor fornecedor in this.dalFornecedor.GetAllAsIList())
            {
                cbxFornecedor.Items.Add(fornecedor);                
            }

            foreach (Produto produto in this.dalProduto.GetAllAsIList())
            {
                cbxProduto.Items.Add(produto);
            }
        }

        private void btnGravarNota_Click(object sender, EventArgs e)
        {
            dal.Save(new NotaEntrada()
            {
                Id = string.IsNullOrEmpty(txtIdNotaEntrada.Text) ? (long?)null : Convert.ToInt64(txtIdNotaEntrada.Text),
                Numero = txtNumero.Text,
                DataEmissao = Convert.ToDateTime(dtpEmissao.Value),
                DataEntrada = Convert.ToDateTime(dtpEntrada.Value),
                FornecedorNota = (Fornecedor)cbxFornecedor.SelectedItem
            });

            MessageBox.Show("Manutenção realizada com sucesso");            
            ClearControls();
        }

        private void ClearControls()
        {
            txtIdNotaEntrada.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            GetAllNotas();
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            cbxFornecedor.Focus();
        }

        private void GetAllNotas()
        {
            dgvNotasEntrada.DataSource = dal.GetAllAsIList();
        }

        private void GetAllNotasProdutos()
        {
            dgvProdutos.DataSource = dalProdComprados.GetAllAsIListProdutosComprado();
        }

        private void dgvNotasEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            this.notaAtual = dal.GetById(Convert.ToInt64(dgvNotasEntrada.Rows[e.RowIndex].Cells[0].Value));
            txtIdNotaEntrada.Text = notaAtual.Id.ToString();
            txtNumero.Text = notaAtual.Numero;
            dtpEmissao.Value = notaAtual.DataEmissao;
            dtpEntrada.Value = notaAtual.DataEntrada;
            cbxFornecedor.SelectedItem = notaAtual.FornecedorNota;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearControls();
            cbxFornecedor.Focus();
        }

        private void btnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControls();
            cbxFornecedor.Focus();
        }

        private void btnRemoverNota_Click(object sender, EventArgs e)
        {
            if (txtIdNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma nota na tabela");
            }else
            {                
                this.dal.RemoveById(Convert.ToInt64(this.notaAtual.Id));
                ClearControls();
                MessageBox.Show("Nota removida com sucesso");
            }
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            if (txtIdNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione um fornecedor na tabela");
            }else
            {
                GetAllNotasProdutos();
                MudarEstado(true);
            }
            
        }

        private void MudarEstado(bool estado)
        {
            cbxProduto.Enabled = estado;
            txtCusto.Enabled = estado;
            txtQuantidade.Enabled = estado;
            btnGravarProduto.Enabled = estado;
            btnCancelarProduto.Enabled = estado;
            btnRemoverProduto.Enabled = estado;
            btnNovoProduto.Enabled = !estado;
        }

        private void btnGravarProduto_Click(object sender, EventArgs e)
        {

            dalProdComprados.Save(new ProdutoNotaEntrada()
            {
                Id = string.IsNullOrEmpty(txtIdProduto.Text) ? (long?)null : Convert.ToInt64(txtIdProduto.Text),
                IdNotaEntrada = new NotaEntrada(Convert.ToInt64(txtIdNotaEntrada.Text)),
                ProdutoNota = (Produto)cbxProduto.SelectedItem,
                PrecoCustoCompra = Convert.ToDouble(txtCusto.Text),
                QuantidadeComprada = Convert.ToDouble(txtQuantidade.Text)
            });
            
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControls();
            ClearControlsProdutosComprados();
            MudarEstado(false);
        }

        private void ClearControlsProdutosComprados()
        {
            txtIdProduto.Text = string.Empty;
            cbxProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            GetAllNotasProdutos();
            cbxProduto.Focus();
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProdutosComprados();
            dgvProdutos.DataSource = null;
            MudarEstado(false);
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (txtIdProduto.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma nota de produto na tabela");
            }
            else
            {
                
                this.dalProdComprados.RemoveById(Convert.ToInt64(this.notaAtual.Id));
                ClearControls();
                ClearControlsProdutosComprados();
                MessageBox.Show("Nota removida com sucesso");
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            
            txtIdProduto.Text = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            cbxProduto.Text = dgvProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCusto.Text = dgvProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtQuantidade.Text = dgvProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
    }
}
