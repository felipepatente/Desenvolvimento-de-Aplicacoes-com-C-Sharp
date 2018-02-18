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
        private NotaEntrada notaAtual;

        public FormNotaEntrada()
        {
            InitializeComponent();
            InicializarComboBoxs();
        }

        private void InicializarComboBoxs()
        {
            cbxFornecedor.Items.Clear();
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
            //Implementar os códigos
            //Resolução 4.33 da seção 4.10
        }

        private void GetAllNotas()
        {
            dgvNotasEntrada.DataSource = dal.GetAllAsIList();
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
    }
}
