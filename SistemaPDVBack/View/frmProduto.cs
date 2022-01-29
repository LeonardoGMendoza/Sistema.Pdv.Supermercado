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
using SistemaPDVBack.Validacoes;

namespace SistemaPDVBack.View
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        ControllerProduto controllerProduto;
        Moeda moeda = new Moeda();
        string _perecivel = "";
        string _ativo = "";


        private void frmProduto_Load(object sender, EventArgs e)
        {

            rbPerecivel.Checked = true;
            rbProdutoAtivo.Checked = true;
            controllerProduto = new ControllerProduto();
            cmbFornecedor.DataSource = controllerProduto.PreencherFornecedor();

            cmbFornecedor.DisplayMember = "nomeFantasia";
            cmbFornecedor.ValueMember = "idFornecedor";

        }
        private void Listar()
        {
            controllerProduto = new ControllerProduto();
            if (cmbFornecedor.Text.Equals(" "))
            {
                cmbFornecedor.SelectedIndex = 0;

            }

            dgvProduto.DataSource = controllerProduto.ListarProduto();



            DefinirCabecalhos(new List<string>() { "ID", "Cód barras", "Nome", "Fornecedor", "Descrição", "Qtd.", "P. Custo", "Margem", "P. Venda", "Dt. Fabri.", "Dt. Venci.", "Categoria", "Ativo" });

            LimpaCampos();
        }

        private void InseriValorRb()
        {
            if (rbPerecivel.Checked == true)
            {
                _perecivel = rbPerecivel.Text;
            }
            else
            {
                _perecivel = rbNaoPerecivel.Text;
            }
            if (rbProdutoAtivo.Checked == true)
            {
                _ativo = "1";

            }
            else
            {
                _ativo = "0";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            InseriValorRb();
            if (!cmbFornecedor.Text.Equals(""))
            {
                if (rbNaoPerecivel.Checked == true)
                {
                    msktDataFabricacao.Text = "00/00/0000";
                    msktDataVencimento.Text = "00/00/0000";


                    controllerProduto = new ControllerProduto(txbId.Text, txbCodigoBarras.Text, cmbFornecedor.SelectedValue.ToString(), txbNome.Text, rtbDescricao.Text, txbPrecoCusto.Text, txbPrecoDeVenda.Text,
                                                        txbMargemDeLucro.Text, msktDataFabricacao.Text, msktDataVencimento.Text, txbQuantidadeEstoque.Text, _perecivel, _ativo);
                    if (controllerProduto.VerificarCodBarras() == false)
                    {
                        controllerProduto.AdicionarProduto();

                        if (controllerProduto.Ds_Msg != "")
                        {
                            // Exibir erro!

                            txbCodigoBarras.Focus();
                            const string caption = "Ocorreu um erro?";
                            var result = MessageBox.Show(controllerProduto.Ds_Msg, caption,
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Warning);

                        }

                        Listar();
                    }
                    else
                    {
                        MessageBox.Show("Esse código de barras já existe !!");
                    }


                }


                else
                {
                    controllerProduto = new ControllerProduto(txbId.Text, txbCodigoBarras.Text, cmbFornecedor.SelectedValue.ToString(), txbNome.Text, rtbDescricao.Text, txbPrecoCusto.Text, txbPrecoDeVenda.Text,
                                            txbMargemDeLucro.Text, msktDataFabricacao.Text, msktDataVencimento.Text, txbQuantidadeEstoque.Text, _perecivel, _ativo);
                    // Tudo certinho!
                    if (controllerProduto.VerificarCodBarras() == false)
                    {
                        controllerProduto.AdicionarProduto();

                        if (controllerProduto.Ds_Msg != "")
                        {
                            // Exibir erro!

                            txbCodigoBarras.Focus();
                            const string caption = "Ocorreu um erro?";
                            var result = MessageBox.Show(controllerProduto.Ds_Msg, caption,
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Warning);

                        }

                        Listar();
                    }
                    else
                    {
                        MessageBox.Show("Esse código de barras já existe !!");
                    }

                }


            }

        }


        private void txbPrecoDeVenda_TextChanged(object sender, EventArgs e)
        {
            ValidaMoeda(txbPrecoDeVenda);


            decimal precoVenda = 0;
            decimal porcentagem = 0;


            decimal precoCusto = 0;
            decimal total = 0;

            if (txbPrecoDeVenda.Text != "" && txbPrecoCusto.Text != "" && txbPrecoCusto.Text != "0,00" && txbPrecoDeVenda.Text != "0,00")
            {
                precoVenda = decimal.Parse(txbPrecoDeVenda.Text);
                precoCusto = decimal.Parse(txbPrecoCusto.Text);
                total = (((precoVenda / precoCusto) - 1)) * 100;
                txbMargemDeLucro.Text = total.ToString("F2");
            }


        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string _tempAtivo;
            string _tempPerecivel;

            txbCodigoBarras.Text = this.dgvProduto.CurrentRow.Cells[1].Value.ToString();
            txbId.Text = this.dgvProduto.CurrentRow.Cells[0].Value.ToString();

            txbNome.Text = this.dgvProduto.CurrentRow.Cells[2].Value.ToString();
            cmbFornecedor.Text = this.dgvProduto.CurrentRow.Cells[3].Value.ToString();
            rtbDescricao.Text = this.dgvProduto.CurrentRow.Cells[4].Value.ToString();
            txbQuantidadeEstoque.Text = this.dgvProduto.CurrentRow.Cells[5].Value.ToString();
            txbPrecoCusto.Text = this.dgvProduto.CurrentRow.Cells[6].Value.ToString();
            txbMargemDeLucro.Text = this.dgvProduto.CurrentRow.Cells[7].Value.ToString();
            txbPrecoDeVenda.Text = this.dgvProduto.CurrentRow.Cells[8].Value.ToString();
            msktDataFabricacao.Text = this.dgvProduto.CurrentRow.Cells[9].Value.ToString();
            msktDataVencimento.Text = this.dgvProduto.CurrentRow.Cells[10].Value.ToString();
            _tempPerecivel = this.dgvProduto.CurrentRow.Cells[11].Value.ToString();
            _tempAtivo = this.dgvProduto.CurrentRow.Cells[12].Value.ToString();

            bool _tempAtivoV = bool.Parse(_tempAtivo);

            if (_tempAtivoV == true)
                rbProdutoAtivo.Checked = true;
            else
                rbProdutoInativo.Checked = true;

            if (_tempPerecivel == "Perecível")
                rbPerecivel.Checked = true;
            else
                rbNaoPerecivel.Checked = true;

            btnAdicionar.Enabled = false;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;

            InseriValorRb();
            controllerProduto = new ControllerProduto(txbId.Text, txbCodigoBarras.Text, cmbFornecedor.SelectedValue.ToString(), txbNome.Text, rtbDescricao.Text, txbPrecoCusto.Text, txbPrecoDeVenda.Text,
                                                        txbMargemDeLucro.Text, msktDataFabricacao.Text, msktDataVencimento.Text, txbQuantidadeEstoque.Text, _perecivel, _ativo);
            controllerProduto.AlterarProduto();

            if (controllerProduto.Ds_Msg != "")
            {
                // Exibir erro!

                txbCodigoBarras.Focus();
                const string caption = "Ocorreu um erro?";
                var result = MessageBox.Show(controllerProduto.Ds_Msg, caption,
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);

            }

            Listar();
            Listar();
        }

        private void DefinirCabecalhos(List<String> ListaCabecalhos)
        {
            int _index = 0;

            foreach (DataGridViewColumn coluna in dgvProduto.Columns)
            {
                if (coluna.Visible)
                {
                    coluna.HeaderText = ListaCabecalhos[_index];
                    _index++;
                }
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            controllerProduto = new ControllerProduto(txbCodigoBarras.Text);
            if (txbCodigoBarras.Text != "")
            {
                dgvProduto.DataSource = controllerProduto.PesquisaProduto();
                DefinirCabecalhos(new List<string>() { "ID", "Cód barras", "Nome", "Fornecedor", "Descrição", "Qtd", "P. Custo", "Margem", "P. Venda", "Dt. Fabri.", "Dt. Venci.", "Categoria", "Ativo" });


            }
            else
            {
                if (ckbInativo.Checked)
                {
                    dgvProduto.DataSource = controllerProduto.ListarTodosProdutos();
                    DefinirCabecalhos(new List<string>() { "ID", "Cód barras", "Nome", "Fornecedor", "Descrição", "Qtd", "P. Custo", "Margem", "P. Venda", "Dt. Fabri.", "Dt. Venci.", "Categoria", "Ativo" });

                }
                else
                {
                    Listar();

                }
            }
        }

        private void txbPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            ValidaMoeda(txbPrecoCusto);
            decimal precoVenda = 0;
            decimal porcentagem = 0;


            decimal precoCusto = 0;
            decimal total = 0;

            if (txbPrecoDeVenda.Text != "" && txbPrecoCusto.Text != "" && txbPrecoCusto.Text != "0,00" && txbPrecoDeVenda.Text != "0,00")
            {
                precoVenda = decimal.Parse(txbPrecoDeVenda.Text);
                precoCusto = decimal.Parse(txbPrecoCusto.Text);
                total = (((precoVenda / precoCusto) - 1)) * 100;
                txbMargemDeLucro.Text = total.ToString("F2");
            }
        }

        private void rbNaoPerecivel_CheckedChanged(object sender, EventArgs e)
        {
            msktDataFabricacao.Enabled = false;
            msktDataVencimento.Enabled = false;
        }

        private void LimpaCampos()
        {
            txbId.Clear();
            txbCodigoBarras.Clear();
            txbMargemDeLucro.Clear();
            txbNome.Clear();
            txbPrecoDeVenda.Clear();
            txbPrecoCusto.Clear();
            txbQuantidadeEstoque.Clear();
            if (cmbFornecedor.Text.Equals(" "))
            {
                cmbFornecedor.SelectedIndex = 0;
            }
            rbProdutoAtivo.Checked = true;
            rbPerecivel.Checked = true;
            rtbDescricao.Clear();
            msktDataFabricacao.Text = "";
            msktDataVencimento.Text = "";
        }

        private void rbPerecivel_CheckedChanged(object sender, EventArgs e)
        {
            msktDataFabricacao.Enabled = true;
            msktDataVencimento.Enabled = true;

        }

        private void ValidaMoeda(TextBox txt)
        {
            string m = string.Empty;
            double v = 0;
            try
            {
                m = txt.Text.Replace(",", "").Replace(".", "");
                if (m.Equals(""))
                    m = "";
                m = m.PadLeft(3, '0');
                if (m.Length > 3 & m.Substring(0, 1) == "0")
                    m = m.Substring(1, m.Length - 1);
                v = Convert.ToDouble(m) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {

            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    txbNome.Focus();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void txbCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txbPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)1)
            {
                e.Handled = true;
            }
        }

        private void txbPrecoDeVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)1)
            {
                e.Handled = true;
            }
        }
    }
}