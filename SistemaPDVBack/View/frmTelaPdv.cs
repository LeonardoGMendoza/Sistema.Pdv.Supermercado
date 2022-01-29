//using MySqlX.XDevAPI.Relational;
using System.Data.SqlClient;
using SistemaPDVBack.Controller;
using SistemaPDVBack.Model;
using SistemaPDVBack.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack.View
{
    public partial class frmTelaPdv : Form
    {
        public frmTelaPdv()
        {
            InitializeComponent();
        }

        ControllerProdutoPedido controllerProdutoPedido;
        ControllerPedido controllerPedido;





        private void frmTelaPdv_Load(object sender, EventArgs e)
        {
            CarregarUsuario();
            timerData.Start();

            controllerPedido = new ControllerPedido();
            lblCaixa.Text = controllerPedido.VerificarCaixa();
            txbCodBarras.Focus();



        }


        bool verificadorTecla = false;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    decimal valorTotal;
                    decimal valorRecibido;
                    if (verificadorTecla == true)
                    {
                        valorTotal = decimal.Parse(lblTotal.Text);
                        valorRecibido = decimal.Parse(lblValorAReceber.Text);
                        if (valorRecibido >= valorTotal)
                        {
                            FinalizarVenda();
                            LimpaDgv();
                            lblNomeFormaPagamento.Visible = false;
                            lblFormaPagamento.Visible = false;
                            lblNomeTroco.Visible = false;
                            lblTroco.Visible = false;
                            lblNomeValorPago.Visible = false;
                            lblValorAReceber.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Valor rebido menor que o total");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Por favor selecione a forma de pagamento!");
                    }

                    break;
                case Keys.A:
                    Adicionar();
                    CalculaTotal();

                    LimpaCampos();


                    break;
                case Keys.D:

                    if (lblTotal.Text != "0")
                    {
                        using (var dinheiro = new frmDinheiro())
                        {

                            dinheiro.ReceberValor(lblTotal.Text);
                            dinheiro.ShowDialog();
                            lblValorAReceber.Text = dinheiro.ValorRecibido;
                            lblTroco.Text = dinheiro.Troco;

                        }

                        if (lblValorAReceber.Text != "0,00")
                        {
                            lblFormaPagamento.Text = "Dinheiro";
                            lblNomeFormaPagamento.Visible = true;
                            lblFormaPagamento.Visible = true;
                            lblNomeTroco.Visible = true;
                            lblTroco.Visible = true;
                            lblNomeValorPago.Visible = true;
                            lblValorAReceber.Visible = true;
                        }

                        // controllerPedido.AtualizaFormaPagamento(btnDinheiro.Text);
                        verificadorTecla = true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor insira um produto!!");
                    }


                    break;
                case Keys.C:
                    if (lblTotal.Text != "0")
                    {
                        lblFormaPagamento.Text = "Cartão";
                        lblTroco.Text = "0,00";
                        lblValorAReceber.Text = lblTotal.Text;
                        lblNomeFormaPagamento.Visible = true;
                        lblFormaPagamento.Visible = true;
                        lblNomeTroco.Visible = true;
                        lblTroco.Visible = true;
                        lblNomeValorPago.Visible = true;
                        lblValorAReceber.Visible = true;

                        verificadorTecla = true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor insira um produto!!");
                    }
                    break;

                case Keys.I:
                    if (lblTotal.Text != "0")
                    {
                        CancelarItem();
                    }
                    break;
                case Keys.Enter:
                    txbQuantidade.Focus();
                    break;
                case Keys.F8:
                    const string message = "Deseja cancelar a venda?";
                    const string caption = "Atenção";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        LimpaDgv();
                        txbCodBarras.Focus();

                    }

                    break;
                case Keys.F5:
                    LimpaCampos();
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txbCodBarras_TextChanged(object sender, EventArgs e)
        {
            if (txbCodBarras.Text != "")
            {
                controllerProdutoPedido = new ControllerProdutoPedido(txbCodBarras.Text, txbQuantidade.Text, txbTotalRecebido.Text);
                txbPrecoUnit.Text = controllerProdutoPedido.VerificaProdutoPreco();
                txbDescricao.Text = controllerProdutoPedido.VerificaProdutoNome();
            }

        }

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {
            decimal quantidade = 0;
            decimal preco = 0;
            decimal total = 0;


            if (txbPrecoUnit.Text != "" && txbQuantidade.Text != "")
            {
                quantidade = decimal.Parse(txbQuantidade.Text);
                preco = decimal.Parse(txbPrecoUnit.Text);

            }

            total = quantidade * preco;



            txbTotalRecebido.Text = total.ToString();
        }

        bool i = false;
        string cpfCnpjCliente;
        bool verificador = false;
        int codigo = 1;
        private void Adicionar()
        {

            if (VerificaVazio() == false)
            {

                if (i == false)
                {
                    const string message = "Deseja inserir CPF/CNPJ na nota?";
                    const string caption = "Atenção";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        using (var cliente = new frmCliente())
                        {

                            cliente.ShowDialog();
                            cpfCnpjCliente = cliente.Parametro;

                        }

                    }

                    i = true;

                    dgvCarrinho.Columns.Add("codVenda", "Cód.");
                    dgvCarrinho.Columns.Add("CodBarras", "Cod. barras");
                    dgvCarrinho.Columns.Add("Nome", "Produto");
                    dgvCarrinho.Columns.Add("ProdutoVenda", "P. Venda");
                    dgvCarrinho.Columns.Add("Quantidade", "Quant.");
                    dgvCarrinho.Columns.Add("Total", "Total");

                    verificador = true;

                }

                dgvCarrinho.Rows.Add(codigo, txbCodBarras.Text, txbDescricao.Text, txbPrecoUnit.Text, txbQuantidade.Text, txbTotalRecebido.Text);
                codigo++;
                dgvCarrinho.ClearSelection();
                lblNomeCaixa.Text = "PROCESSANDO";

            }

            else
            {
                MessageBox.Show("Por favor preencha todos os campos!!");
            }

        }

        private void CarregarUsuario()
        {

            lblNomeOperador.Text = CarregaUsuario.Nome;
        }

        private void txbCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        string codItem;


        private void CancelarItem()
        {
            int idex = 0;

            using (var verificaLogin = new frmVerificaLogin())
            {

                verificaLogin.ShowDialog();

                if (verificaLogin.Validador == true)
                {
                    using (var cancelarItem = new frmCancelarItem())
                    {

                        cancelarItem.ShowDialog();
                        codItem = cancelarItem.Parametro;

                    }

                }

            }
            
            if (codItem != "")
            {
                foreach (DataGridViewRow linha in dgvCarrinho.Rows)
                {

                    if (linha.Visible)
                    {
                        if (codItem == dgvCarrinho.Rows[idex].Cells[0].Value.ToString())
                        {
                            dgvCarrinho.Rows[idex].DefaultCellStyle.BackColor = Color.Red;

                        }

                    }
                    idex++;
                }
                CalculaTotal();
            }

        }



        private void CalculaTotal()
        {
            int cont = 0;
            int idex = 0;


            decimal calc = 0;
            decimal calcNegativo = 0;


            foreach (DataGridViewRow coluna in dgvCarrinho.Rows)
            {

                if (coluna.Visible)
                {
                    if (coluna.DefaultCellStyle.BackColor == Color.Red)
                    {

                    }
                    else
                    {
                        calc += Convert.ToDecimal(dgvCarrinho.Rows[idex].Cells[5].Value);


                    }
                    lblTotal.Text = calc.ToString();


                    idex++;

                }

            }

        }


        string codBarras;
        string quantidade;
        string totalProduto;
        string preco;
        string descricao;


        private void FinalizarVenda()
        {

            frmCupom cupom = new frmCupom();
            string temp = "1";
            controllerPedido = new ControllerPedido(temp, lblData.Text + " " + lblHora.Text, lblTotal.Text, lblFormaPagamento.Text);


            if (cpfCnpjCliente != null && cpfCnpjCliente != "")
            {
                ControllerCliente cliente = new ControllerCliente(cpfCnpjCliente);
                cliente.AdicionarCliente();
                controllerPedido.CarregaCpf();

            }


            int cont = 0;
            int idex = 0;
            int codItem = 1;


            controllerPedido.AdicionarPedido();


            foreach (DataGridViewRow coluna in dgvCarrinho.Rows)
            {

                if (coluna.Visible)
                {
                    if (coluna.DefaultCellStyle.BackColor == Color.Red)
                    {
                        string cancelado = "Cancelado";
                        codBarras = this.dgvCarrinho.Rows[idex].Cells[1].Value.ToString();
                        descricao = this.dgvCarrinho.Rows[idex].Cells[2].Value.ToString();
                        preco = this.dgvCarrinho.Rows[idex].Cells[3].Value.ToString();
                        quantidade = this.dgvCarrinho.Rows[idex].Cells[4].Value.ToString();
                        totalProduto = this.dgvCarrinho.Rows[idex].Cells[5].Value.ToString();
                        cupom.CumpomImpresso(codItem.ToString(), codBarras, descricao, quantidade, preco, totalProduto, cancelado, cpfCnpjCliente, lblTotal.Text, lblData.Text, lblHora.Text, lblCaixa.Text, lblFormaPagamento.Text, lblValorAReceber.Text, lblTroco.Text);


                        cont++;
                    }
                    else
                    {

                        string ativo = "Ativo";
                        if (dgvCarrinho.Rows[idex].Cells[cont].Value != null)
                        {
                            codBarras = this.dgvCarrinho.Rows[idex].Cells[1].Value.ToString();
                            descricao = this.dgvCarrinho.Rows[idex].Cells[2].Value.ToString();
                            preco = this.dgvCarrinho.Rows[idex].Cells[3].Value.ToString();
                            quantidade = this.dgvCarrinho.Rows[idex].Cells[4].Value.ToString();
                            totalProduto = this.dgvCarrinho.Rows[idex].Cells[5].Value.ToString();
                            controllerProdutoPedido = new ControllerProdutoPedido(codBarras, quantidade, totalProduto);
                            controllerProdutoPedido.AdicionarProdutoPedido();
                            controllerProdutoPedido.AtualizaEstoque();
                            cupom.CumpomImpresso(codItem.ToString(), codBarras, descricao, quantidade, preco, totalProduto, ativo, cpfCnpjCliente, lblTotal.Text, lblData.Text, lblHora.Text, lblCaixa.Text, lblFormaPagamento.Text, lblValorAReceber.Text, lblTroco.Text);


                        }
                    }
                    codItem++;

                    idex++;

                }

            }

            cupom.ShowDialog();
            lblNomeCaixa.Text = "CAIXA LIVRE";

            i = false;
        }


        private void CalulaValores(string valorpago, string total)

        {

            decimal valorRecebido = decimal.Parse(valorpago);
            decimal totalDaVenda = decimal.Parse(total);

            if (totalDaVenda > valorRecebido)
            {
                totalDaVenda = totalDaVenda - valorRecebido;
                lblValorAReceber.Text = totalDaVenda.ToString();


            }
            else
            {
                totalDaVenda = valorRecebido - totalDaVenda;

                lblTroco.Text = totalDaVenda.ToString();

                lblValorAReceber.Text = "0.00";
            }



        }

        private void LimpaCampos()
        {
            txbCodBarras.Clear();
            txbPrecoUnit.Clear();
            txbDescricao.Clear();
            txbQuantidade.Clear();
            txbTotalRecebido.Clear();
            txbCodBarras.Focus();

        }

        private void LimpaDgv()
        {
            i = false;
            verificador = false;
            codigo = 1;
            dgvCarrinho.Rows.Clear();
            dgvCarrinho.Columns.Clear();
            lblTotal.Text = "0";

        }


        private bool VerificaVazio()
        {
            if (txbCodBarras.Text == "" || txbDescricao.Text == "" || txbPrecoUnit.Text == "" || txbQuantidade.Text == "" || txbTotalRecebido.Text == "")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
