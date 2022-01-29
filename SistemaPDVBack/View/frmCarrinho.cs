using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPDVBack.Controller;
using SistemaPDVBack.Model;

namespace SistemaPDVBack.View
{
    public partial class frmCarrinho : Form
    {
        public frmCarrinho()
        {
            InitializeComponent();
        }



        private void frmCarrinho_Load(object sender, EventArgs e)
        {
            dgvListaProdutos.ClearSelection();
            DefinirCabecalhos(new List<string>() { "Quantidade", "Nome", "Preço", "Total" });


        }
        ControllerRelatorio relatorio = new ControllerRelatorio();
        public void PreencheListaProdutos(string id)
        {


            dgvListaProdutos.DataSource = relatorio.BuscarPorProdutos(id);



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefinirCabecalhos(List<String> ListaCabecalhos)
        {
            int _index = 0;

            foreach (DataGridViewColumn coluna in dgvListaProdutos.Columns)
            {
                if (coluna.Visible)
                {
                    coluna.HeaderText = ListaCabecalhos[_index];
                    _index++;
                }
            }
        }
    }
}
