using ControllerProject;
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
    public partial class formJanelaPrincipal : Form
    {
        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutoController produtoController = new ProdutoController();
        private NotaEntradaController notaEntradaController = new NotaEntradaController();

        public formJanelaPrincipal()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor(fornecedorController).ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto(produtoController).ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNotaEntrada
                (notaEntradaController, fornecedorController, produtoController).ShowDialog();
        }
    }
}
