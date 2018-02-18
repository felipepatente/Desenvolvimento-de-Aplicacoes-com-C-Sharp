using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NETProject01
{
    public partial class ProdutosCRUD : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
        private Produto produtoAtual;
        private DAL_Produtos dal = new DAL_Produtos();
        private SqlConnection connection;

        public ProdutosCRUD()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            GetAllProdutos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            dal.Save(new Produto()
            {
                Id = string.IsNullOrEmpty(txtId.Text) ? (long?)null : Convert.ToInt64(txtId.Text),
                Descricao = txtDescricao.Text,
                PrecoDeCusto = Convert.ToDouble(txtCusto.Text),
                PrecoDeVenda = Convert.ToDouble(txtVenda.Text),
                Estoque = Convert.ToDouble(txtEstoque.Text),

            });
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControls();
        }

        private void GetAllProdutos()
        {            
            var adapter = new SqlDataAdapter("SELECT id, descricao, precoDeCusto, precoDeVenda, estoque FROM produtos; ", connectionString);
            var builder = new SqlCommandBuilder(adapter);
            var table = new DataTable();
            adapter.Fill(table);
            dgvProdutos.DataSource = table;
            connection.Close();
        }

        private void ClearControls()
        {
            txtId.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtVenda.Text = string.Empty;
            txtCusto.Text = string.Empty;
            
            GetAllProdutos();
            dgvProdutos.ClearSelection();
            this.produtoAtual = null;
            txtDescricao.Focus();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            
            if (dgvProdutos.SelectedRows.Count != 0 && !(dgvProdutos.SelectedRows[0].Cells[0].Value is DBNull))
            {
                this.produtoAtual = GetProdutoById
                (Convert.ToInt64(dgvProdutos.Rows[e.RowIndex].Cells[0].Value));
                txtId.Text = this.produtoAtual.Id.ToString();
                txtDescricao.Text = this.produtoAtual.Descricao;
                txtCusto.Text = this.produtoAtual.PrecoDeCusto.ToString();
                txtVenda.Text = this.produtoAtual.PrecoDeVenda.ToString();
                txtEstoque.Text = this.produtoAtual.Estoque.ToString();
            }
        }

        private Produto GetProdutoById(long id)
        {
            Produto produto = new Produto();           
            var command = new SqlCommand("SELECT id, descricao, precoDeCusto, precoDeVenda, estoque " + 
                "FROM produtos WHERE id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto.Id = Convert.ToInt64(reader["Id"]);
                    produto.Descricao = Convert.ToString(reader["Descricao"]);
                    produto.PrecoDeCusto = Convert.ToDouble(reader["PrecoDeCusto"]);
                    produto.PrecoDeVenda = Convert.ToDouble(reader["PrecoDeVenda"]);
                    produto.Estoque = Convert.ToDouble(reader["Estoque"]);
                }
            }
            connection.Close();
            return produto;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
            txtDescricao.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
            txtDescricao.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o produto a ser removido no GRID");
            }
            else
            {
                this.dal.RemoveById(Convert.ToInt64(this.produtoAtual.Id));
                ClearControls();
                MessageBox.Show("Produto removido com sucesso");
            }
        }
    }    
}
