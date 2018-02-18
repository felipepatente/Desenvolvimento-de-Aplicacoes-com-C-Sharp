using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETProject01
{
    public class DAL_Produtos
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id)
        {
            var command = new SqlCommand("DELETE FROM produtos WHERE id = @id ", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(Produto produto)
        {
            var command = new SqlCommand
                ("UPDATE produtos SET descricao = @descricao, precoDeCusto = @precoDeCusto, " + 
                "precoDeVenda = @precoDeVenda, estoque = @estoque WHERE id = @id ", this.connection);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@precoDeCusto", produto.PrecoDeCusto);
            command.Parameters.AddWithValue("@precoDeVenda", produto.PrecoDeVenda);
            command.Parameters.AddWithValue("@estoque", produto.Estoque);
            command.Parameters.AddWithValue("@id", produto.Id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Insert(Produto produto)
        {

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO produtos(descricao,precoDeCusto,precoDeVenda,estoque) " +
                "VALUES(@descricao,@precoDeCusto,@precoDeVenda,@estoque)";
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@precoDeCusto", produto.PrecoDeCusto);
            command.Parameters.AddWithValue("@precoDeVenda", produto.PrecoDeVenda);
            command.Parameters.AddWithValue("@estoque", produto.Estoque);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Produto produto)
        {
            if (produto.Id != null)
            {
                this.Update(produto);
            }
            else
            {
                this.Insert(produto);
            }
        }

        public IList<Produto> GetAllAsIList()
        {
            IList<Produto> produtos = new List<Produto>();

            var adapter = new SqlDataAdapter("select id, descricao, precoDeCusto, precoDeVenda, Estoque " + 
                "FROM produtos", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                produtos.Add(
                    new Produto()
                    {
                        Id = Convert.ToInt64(row["id"]),
                        Descricao = (string)row["descricao"],
                        PrecoDeCusto = Convert.ToDouble(row["precoDeCusto"]),
                        PrecoDeVenda = Convert.ToDouble(row["precoDeVenda"]),
                        Estoque = Convert.ToDouble(row["Estoque"])
                    });
            }
            return produtos;
        }
        
        private void InsertProduto(NotaEntrada notaEntrada, ProdutoNotaEntrada produto)
        {
            notaEntrada.Produtos.Add(produto);
            var command = new SqlCommand("INSERT INTO produtosNotasDeEntrada(idNotaDeEntrada,idProduto,precoCustoCompra, quantidadeCompra) VALUES (@idNotaDeEntrada, @idProduto, @precoCustoCompra, @quantidadeCompra)", this.connection);
            command.Parameters.AddWithValue("@idNotaEntrada", notaEntrada.Id);
            command.Parameters.AddWithValue("@idProduto", produto.Id);
            command.Parameters.AddWithValue("@precoCustoCompra", produto.PrecoCustoCompra);
            command.Parameters.AddWithValue("@quantidadeCompra", produto.QuantidadeComprada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void UpdateProduto(ProdutoNotaEntrada produto)
        {
            var command = new SqlCommand("UPDATE produtosNotasEntrada SET idProduto = @idProduto, precoCustoCompra = @precoCustoCompra, quantidadeCompra = @quantidadeCompra WHERE id = @id", this.connection);
            command.Parameters.AddWithValue("@idProduto", produto.Id);
            command.Parameters.AddWithValue("@precoCustoCompra", produto.PrecoCustoCompra);
            command.Parameters.AddWithValue("@quantidadeCompra", produto.QuantidadeComprada);
            command.Parameters.AddWithValue("@id", produto.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
