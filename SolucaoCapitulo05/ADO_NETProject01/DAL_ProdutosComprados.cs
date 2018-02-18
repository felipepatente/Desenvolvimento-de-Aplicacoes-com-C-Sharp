using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETProject01
{
    public class DAL_ProdutosComprados
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void Save(ProdutoNotaEntrada produtoEntrada)
        {
            if (produtoEntrada.Id == null)
            {
                this.Insert(produtoEntrada);
            }
            else
            {
                this.Update(produtoEntrada);
            }
        }

        private void Insert(ProdutoNotaEntrada produtoEntrada)
        {
            var command = new SqlCommand("Insert INTO ProdutosNotasDeEntrada " +
                "(IdNotaDeEntrada, idProduto, PrecoDeCusto, QuantidadeCompra) " +
                "VALUES(@IdNotaDeEntrada, @idProduto, @PrecoDeCusto, @QuantidadeCompra) ", connection);

            command.Parameters.AddWithValue("@IdNotaDeEntrada", produtoEntrada.IdNotaEntrada.Id);
            command.Parameters.AddWithValue("@idProduto", produtoEntrada.ProdutoNota.Id);
            command.Parameters.AddWithValue("@PrecoDeCusto", produtoEntrada.PrecoCustoCompra);
            command.Parameters.AddWithValue("@QuantidadeCompra", produtoEntrada.QuantidadeComprada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(ProdutoNotaEntrada produtoEntrada)
        {
            //var command = new SqlCommand
            //    ("UPDATE notasDeEntrada SET IdFornecedor = @IdFornecedor, Numero = @Numero, " +
            //    "DataEmissao = @DataEmissao, DataEntrada = @DataEntrada WHERE Id = @Id", connection);
            //command.Parameters.AddWithValue("@IdFornecedor", notaEntrada.FornecedorNota.Id);
            //command.Parameters.AddWithValue("@Numero", notaEntrada.Numero);
            //command.Parameters.AddWithValue("@DataEmissao", notaEntrada.DataEmissao);
            //command.Parameters.AddWithValue("@DataEntrada", notaEntrada.DataEntrada);
            //command.Parameters.AddWithValue("@Id", notaEntrada.Id);

            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();            
        }

        public IList<ProdutoNotaEntrada> GetAllAsIListProdutosComprado()
        {
            IList<ProdutoNotaEntrada> produtoComprado = new List<ProdutoNotaEntrada>();

            var adapter = new SqlDataAdapter("SELECT pe.Id, p.Descricao, pe.PrecoDeCusto, pe.QuantidadeCompra, pe.IdNotaDeEntrada " + 
                "FROM ProdutosNotasDeEntrada AS pe " + 
                "INNER JOIN Produtos AS p " + 
                "ON pe.IdProduto = p.Id " + 
                "INNER JOIN NotasDeEntrada AS ne " + 
                "ON pe.IdNotaDeEntrada = ne.Id;", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                produtoComprado.Add(
                    new ProdutoNotaEntrada()
                    {
                        Id = Convert.ToInt64(row["id"]),
                        ProdutoNota = new Produto(row["Descricao"].ToString()),
                        PrecoCustoCompra = Convert.ToDouble(row["PrecoDeCusto"]),
                        QuantidadeComprada = Convert.ToDouble(row["QuantidadeCompra"]),
                        IdNotaEntrada = new NotaEntrada(Convert.ToInt64(row["IdNotadeEntrada"]))
                    });
            }
            return produtoComprado;
        }

        public void RemoveById(long? id)
        {
            var command = new SqlCommand("DELETE FROM ProdutosNotasDeEntrada WHERE id = @id ", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        
    }
}
