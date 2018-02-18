using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETProject01
{
    public class DAL_NotaEntrada
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        private void Insert(NotaEntrada notaEntrada)
        {
            var command = new SqlCommand("Insert INTO notasDeEntrada " + 
                "(IdFornecedor, Numero, DataEmissao, DataEnttrada) " +
                "VALUES(@IdFornecedor, @Numero, @DataEmissao, @DataEntrada) ", connection);
            command.Parameters.AddWithValue("@IdFornecedor", notaEntrada.FornecedorNota.Id);
            command.Parameters.AddWithValue("@Numero", notaEntrada.Numero);
            command.Parameters.AddWithValue("@DataEmissao", notaEntrada.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", notaEntrada.DataEntrada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(NotaEntrada notaEntrada)
        {
            var command = new SqlCommand
                ("UPDATE notasDeEntrada SET IdFornecedor = @IdFornecedor, Numero = @Numero, " + 
                "DataEmissao = @DataEmissao, DataEntrada = @DataEntrada WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@IdFornecedor", notaEntrada.FornecedorNota.Id);
            command.Parameters.AddWithValue("@Numero", notaEntrada.Numero);
            command.Parameters.AddWithValue("@DataEmissao", notaEntrada.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", notaEntrada.DataEntrada);
            command.Parameters.AddWithValue("@Id", notaEntrada.Id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            DeleteAllProdutosFromNotaEntrada(notaEntrada.Id);
            InsertProdutosNotaDeEntrada(notaEntrada.Id, notaEntrada.Produtos);
        }

        private void DeleteAllProdutosFromNotaEntrada(long? idNotaEntrada)
        {
            var command = new SqlCommand("DELETE FROM notasDeEntrada WHERE Id = @Id; ", connection);
            command.Parameters.AddWithValue("@Id", idNotaEntrada);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void InsertProdutosNotaDeEntrada(long? idNotaEntrada, IList<ProdutoNotaEntrada> produtos)
        {
            var command = new SqlCommand
                ("INSERT INTO produtosNotaDeEntrada(IdNotaDeEntrada, IdProduto, PrecoCustoCompra, " +
                "QuantidadeCompra) " + 
                "VALUES (@IdNotaDeEntrada, @IdProduto, @PrecoCustoCompra, @QuantidadeCompra)", connection);
            connection.Open();

            foreach (var produto in produtos)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@IdNotaDeEntrada", idNotaEntrada);
                command.Parameters.AddWithValue("@IdProduto",produto.Id);
                command.Parameters.AddWithValue("@PrecoCustoCompra", produto.PrecoCustoCompra);
                command.Parameters.AddWithValue("@QuantidadeDeCompra", produto.QuantidadeComprada);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void Save(NotaEntrada notaEntrada)
        {
            if (notaEntrada.Id == null)
            {
                this.Insert(notaEntrada);
            }else
            {
                this.Update(notaEntrada);
            }
        }

        public IList<NotaEntrada> GetAllAsIList()
        {
            IList<NotaEntrada> notaEntrada = new List<NotaEntrada>();

            var adapter = new SqlDataAdapter("SELECT n.id, f.Nome, n.numero, n.dataEmissao, n.dataEnttrada " +
                "FROM NotasDeEntrada AS n INNER JOIN fornecedores AS f ON n.idFornecedor = f.id", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                notaEntrada.Add(
                    new NotaEntrada()
                    {
                        Id = Convert.ToInt64(row["id"]),
                        FornecedorNota = new Fornecedor(row["Nome"].ToString()),
                        Numero = Convert.ToString(row["numero"]),
                        DataEmissao = Convert.ToDateTime(row["dataEmissao"]),
                        DataEntrada = Convert.ToDateTime(row["dataEnttrada"])
                    });
            }
            return notaEntrada;
        }

        public NotaEntrada GetById(long id)
        {
            NotaEntrada notaEntrada = new NotaEntrada();
            DAL_Fornecedor dalFornecedor = new DAL_Fornecedor();
            long idFornecedorNota = -1;
            var command = new SqlCommand("SELECT id, idFornecedor, numero, dataEmissao, dataEnttrada FROM notasDeEntrada WHERE id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    notaEntrada.Id = reader.GetInt64(0);
                    idFornecedorNota = reader.GetInt32(1);
                    notaEntrada.Numero = reader.GetString(2);
                    notaEntrada.DataEmissao = reader.GetDateTime(3);
                    notaEntrada.DataEntrada = reader.GetDateTime(4);
                }
            }
            connection.Close();
            if (idFornecedorNota > 0)
            {
                notaEntrada.FornecedorNota = dalFornecedor.GetById(idFornecedorNota);
            }

            return notaEntrada;
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
