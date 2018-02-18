using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETProject01
{
    public class DAL_Fornecedor
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id)
        {
            var command = new SqlCommand("DELETE FROM fornecedores WHERE id = @id ", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(Fornecedor fornecedor)
        {
            var command = new SqlCommand("UPDATE fornecedores SET cnpj = @cnpj, nome = @nome WHERE id = @id ", this.connection);
            command.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@id", fornecedor.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Insert(Fornecedor fornecedor)
        {
            
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO fornecedores(nome, cnpj) VALUES (@nome, @cnpj) ";
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();            
        }

        public void Save(Fornecedor fornecedor)
        {
            if (fornecedor.Id != null)
            {
                this.Update(fornecedor);
            }else
            {
                this.Insert(fornecedor);
            }
        }

        public IList<Fornecedor> GetAllAsIList()
        {
            IList<Fornecedor> fornecedores = new List<Fornecedor>();

            var adapter = new SqlDataAdapter("select id, cnpj, nome from FORNECEDORES", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                fornecedores.Add(
                    new Fornecedor()
                    {
                        Id = Convert.ToInt64(row["id"]),
                        Cnpj = (string)row["cnpj"],
                        Nome = (string)row["nome"]
                    });
            }
            return fornecedores;
        }

        public Fornecedor GetById(long id)
        {
            Fornecedor fornecedor = new Fornecedor();
            var command = new SqlCommand("SELECT id, cnpj, nome FROM fornecedores WHERE id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    fornecedor.Id = reader.GetInt32(0);
                    fornecedor.Cnpj = reader.GetString(1);
                    fornecedor.Nome = reader.GetString(2);
                }
                connection.Close();
                return fornecedor;
            }
        }

    }
}
