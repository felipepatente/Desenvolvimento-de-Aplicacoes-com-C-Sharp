using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdadeAlunosMatriculados
{
    public partial class frmIdadeAlunosMatriculados : Form
    {
        public frmIdadeAlunosMatriculados()
        {
            InitializeComponent();
            lblHoje.Text = "Hoje é " + DateTime.Now.ToShortDateString();
        }

        private void txtUltimoNascimento_Enter(object sender, EventArgs e)
        {
            if (txtNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE NASCIMENTO com 4 digitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNascimento.Focus();
            }
        }

        private void txtUltimoNascimento_Validating(object sender, CancelEventArgs e)
        {
            if (txtUltimoNascimento.Text != String.Empty && Convert.ToInt32(txtUltimoNascimento.Text) <= Convert.ToInt32(txtNascimento.Text))
            {
                MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO deve ser superior ao do ANO DE NASCIMENTO.", "Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty || txtNascimento.Text == String.Empty || txtUltimoNascimento.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {

                int idade = Convert.ToInt32(txtUltimoNascimento.Text) - Convert.ToInt32(txtNascimento.Text);

                if (idade > 17)
                {
                    lblCatetoria.Text = "Adulto";
                }else if (idade > 13)
                {
                    lblCatetoria.Text = "Juvenil B";
                }else if (idade > 10)
                {
                    lblCatetoria.Text = "Juvenil A";
                }else if (idade > 7)
                {
                    lblCatetoria.Text = "Infantil B";
                }
                else if(idade >= 5)
                {
                    lblCatetoria.Text = "Infantil A";
                }else
                {
                    lblCatetoria.Text = "Não existe categoria";
                }
            }
        }
    }
}
