using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ADO_NETProject01
{
    public partial class FornecedoresCRUD : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
        private Fornecedor fornecedorAtual;
        private DAL_Fornecedor dal = new DAL_Fornecedor();

        public FornecedoresCRUD()
        {
            InitializeComponent();
            GetAllFornecedores();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            /*
            //Versão 1
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Fornecedores(nome, cnpj) VALUES (@nome, @cnpj)";
            command.Parameters.AddWithValue("@nome", txtNome.Text);
            command.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Fornecedor registrado com sucesso");            
            */


            /*
            //Versão 2
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO fornecedores(nome, cnpj) VALUES (@nome, @cnpj) ";
                command.Parameters.AddWithValue("@nome", txtNome.Text);
                command.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                command.ExecuteNonQuery();                
            }

            MessageBox.Show("Fornecedor registrado com sucesso");
            ClearControls();            
            */

            //Versão 3
            dal.Save(new Fornecedor()
            {
                Id = string.IsNullOrEmpty(txtId.Text)?(long?) null : Convert.ToInt64(txtId.Text),
                Nome = txtNome.Text,
                Cnpj = txtCnpj.Text
            });
            MessageBox.Show("Manutenção realizada com sucesso");
            ClearControls();
        }

        private void GetAllFornecedores()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            var adapter = new SqlDataAdapter("SELECT id, cnpj, nome FROM fornecedores; ", connectionString);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);

            dgvFornecedores.DataSource = table;
            connection.Close();
        }

        private void ClearControls()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCnpj.Text = string.Empty;
            GetAllFornecedores();
            dgvFornecedores.ClearSelection();
            this.fornecedorAtual = null;
            txtNome.Focus();
        }

        private Fornecedor GetFornecedorById(long id)
        {
            Fornecedor fornecedor = new Fornecedor();
            var connection = DBConnection.DB_Connection;
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
            }            
            connection.Close();
            return fornecedor;
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvFornecedores.SelectedRows.Count != 0 && !(dgvFornecedores.SelectedRows[0].Cells[0].Value is DBNull))
            {
                this.fornecedorAtual = GetFornecedorById
                (Convert.ToInt64(dgvFornecedores.Rows[e.RowIndex].Cells[0].Value));
                txtId.Text = this.fornecedorAtual.Id.ToString();
                txtNome.Text = this.fornecedorAtual.Nome;
                txtCnpj.Text = this.fornecedorAtual.Cnpj;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o fornecedor a ser removido no GRID");
            }else
            {
                this.dal.RemoveById(Convert.ToInt64(this.fornecedorAtual.Id));
                ClearControls();
                MessageBox.Show("Fornecedor removido com sucesso");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
            txtNome.Focus();
        }
    }
}
