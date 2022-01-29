using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SistemaPDVBack.Controller;

namespace SistemaPDVBack.View
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();


        }
        public List<string> listaCarrinho;

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ControllerRelatorio relatorio = new ControllerRelatorio(dtpDataInicial.Text, dtpDataFinal.Text);

            dgvRelatorio.DataSource = relatorio.BuscarPorData();
            DefinirCabecalhos(new List<string>() { "ID", "Data ", "Pagamento", "Total" });

            decimal valor = 0;

            for (int i = 0; i < dgvRelatorio.Rows.Count; i++)
            {
                valor += Convert.ToInt32(dgvRelatorio.Rows[i].Cells[3].Value);

            }
            lblTotal.Text = valor.ToString("F2");


        }
        private void DefinirCabecalhos(List<String> ListaCabecalhos)
        {
            int _index = 0;

            foreach (DataGridViewColumn coluna in dgvRelatorio.Columns)
            {
                if (coluna.Visible)
                {
                    coluna.HeaderText = ListaCabecalhos[_index];
                    _index++;
                }
            }
        }

        private void dgvRelatorio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;

            using (var carrinho = new frmCarrinho())
            {

                id = dgvRelatorio.CurrentRow.Cells[0].Value.ToString();
                carrinho.PreencheListaProdutos(id);


                carrinho.ShowDialog();

            }

        }
    }
}
