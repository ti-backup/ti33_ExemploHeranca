using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploHeranca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void teste()
        {
            Carro carro = new Carro();
            carro.Nome = "";
            carro.Descricao = "";
            carro.Venda = DateTime.Now;
            carro.Marca = "aserth";
            carro.Modelo = "srhsrth";

            MessageBox.Show(carro.Id.ToString());
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdicionaProduto addProd = new FrmAdicionaProduto();
            addProd.MdiParent = this;
            addProd.WindowState = FormWindowState.Maximized;
            addProd.Show();
        }
    }
}
