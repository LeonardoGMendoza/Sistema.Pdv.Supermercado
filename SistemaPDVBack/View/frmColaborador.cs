using SistemaPDVBack.Controller;
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
    public partial class frmColaborador : Form
    {
        public frmColaborador()
        {
            InitializeComponent();
        }
        ControllerColaborador controllerColaborador;
        ControllerUsuario controllerUsuario;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string _ativo = "";
            if (rbColaboradorAtivo.Checked == true)
            {
                _ativo = "1";

            }
            else
            {
                _ativo = "0";
            }

            controllerColaborador = new ControllerColaborador(txbId.Text, txbNome.Text, msktCpf.Text, cmbDepartamento.SelectedValue.ToString(), _ativo, cmbCargo.Text, mskTxtCelular.Text, txbEmail.Text, txbEmailCorporativo.Text);

            if (controllerColaborador.Ds_Msg != "")
            {
                // Exibir erro!

                txbNome.Focus();
                const string caption = "Ocorreu um erro?";
                var result = MessageBox.Show(controllerColaborador.Ds_Msg, caption,
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);

            }
            else
            {
                if (controllerColaborador.Verificarcpf() == false)
                {

                    // Tudo certinho!
                    controllerColaborador.AdicionarColaborador();
                    if (controllerColaborador.Ds_Msg != "")
                    {
                        // Exibir erro!

                        txbNome.Focus();
                        const string caption = "Ocorreu um erro?";
                        var result = MessageBox.Show(controllerColaborador.Ds_Msg, caption,
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Warning);

                    }
                    controllerUsuario = new ControllerUsuario(txbUsuario.Text, txbSenha.Text, msktCpf.Text, _ativo, txbId.Text);
                    controllerUsuario.AdicionarUsuario();
                    Listar();
                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("CPF já existe!!");
                }

            }


        }

        private void Listar()
        {
            //verificar
            controllerColaborador = new ControllerColaborador();
            dgvColaborador.DataSource = controllerColaborador.ListarColaborador();
            DefinirCabecalhos(new List<string>() { "ID", "Nome", "Cpf", "Departamento", "Cargo", "telefone", "E-mail Coorp.", "E-mail Pessoal", "Usuario", "Senha", "Status" });


        }

        private void frmColaborador_Load(object sender, EventArgs e)

        {
            controllerColaborador = new ControllerColaborador();

            cmbDepartamento.DataSource = controllerColaborador.PreencherDepartamento();
            cmbDepartamento.DisplayMember = "nomeDepartamento";
            cmbDepartamento.ValueMember = "idDepartamento";
            rbColaboradorAtivo.Checked = true;
        }

        private void dgvColaborador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string _temp;
            cmbDepartamento.Text = this.dgvColaborador.CurrentRow.Cells[3].Value.ToString();
            txbNome.Text = this.dgvColaborador.CurrentRow.Cells[1].Value.ToString();
            txbId.Text = this.dgvColaborador.CurrentRow.Cells[0].Value.ToString();
            msktCpf.Text = this.dgvColaborador.CurrentRow.Cells[2].Value.ToString();
            cmbCargo.Text = this.dgvColaborador.CurrentRow.Cells[4].Value.ToString();
            mskTxtCelular.Text = this.dgvColaborador.CurrentRow.Cells[5].Value.ToString();
            txbEmailCorporativo.Text = this.dgvColaborador.CurrentRow.Cells[6].Value.ToString();
            txbEmail.Text = this.dgvColaborador.CurrentRow.Cells[7].Value.ToString();
            txbUsuario.Text = this.dgvColaborador.CurrentRow.Cells[8].Value.ToString();
            txbSenha.Text = this.dgvColaborador.CurrentRow.Cells[9].Value.ToString();
            _temp = this.dgvColaborador.CurrentRow.Cells[10].Value.ToString();

            bool _tempV = bool.Parse(_temp);
            if (_tempV == true)
                rbColaboradorAtivo.Checked = true;
            else
                rbColaboradorInativo.Checked = true;
            btnAdicionar.Enabled = false;
        }
        private void DefinirCabecalhos(List<String> ListaCabecalhos)
        {
            int _index = 0;

            foreach (DataGridViewColumn coluna in dgvColaborador.Columns)
            {
                if (coluna.Visible)
                {
                    coluna.HeaderText = ListaCabecalhos[_index];
                    _index++;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string _ativo = "";
            if (rbColaboradorAtivo.Checked == true)
            {
                _ativo = "1";

            }
            else
            {
                _ativo = "0";
            }

            controllerColaborador = new ControllerColaborador(txbId.Text, txbNome.Text, msktCpf.Text, cmbDepartamento.SelectedValue.ToString(), _ativo, cmbCargo.Text, mskTxtCelular.Text, txbEmail.Text, txbEmailCorporativo.Text);
            controllerUsuario = new ControllerUsuario(txbUsuario.Text, txbSenha.Text, msktCpf.Text, _ativo, txbId.Text);

            if (controllerColaborador.Ds_Msg != "")
            {
                // Exibir erro!

                txbNome.Focus();
                const string caption = "Ocorreu um erro?";
                var result = MessageBox.Show(controllerColaborador.Ds_Msg, caption,
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);

            }
            else
            {
                // Tudo certinho!
                controllerColaborador.AlterarColaborador();
                controllerUsuario.AlterarUsuario();


                if (controllerColaborador.Ds_Msg != "")
                {
                    // Exibir erro!

                    txbNome.Focus();
                    const string caption = "Ocorreu um erro?";
                    var result = MessageBox.Show(controllerColaborador.Ds_Msg, caption,
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Warning);

                }
                LimpaCampos();

                Listar();


            }

            btnAdicionar.Enabled = true;

        }

        private void LimpaCampos()
        {
            txbId.Clear();
            txbNome.Clear();
            msktCpf.Text = "";
            mskTxtCelular.Text = "";
            rbColaboradorAtivo.Checked = true;
            txbEmail.Clear();
            txbEmailCorporativo.Clear();
            txbUsuario.Clear();
            txbSenha.Clear();
            cmbDepartamento.SelectedIndex = 0;
            cmbCargo.SelectedIndex = 1;

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            controllerColaborador = new ControllerColaborador(txbNome.Text);
            if (txbNome.Text != "")
            {

                dgvColaborador.DataSource = controllerColaborador.PesquisaColaborador();
                DefinirCabecalhos(new List<string>() { "ID", "Nome", "Cpf", "Departamento", "Cargo", "telefone", "E-mail Coorp.", "E-mail Pessoal", "Usuario", "Senha", "Status" });



            }
            else
            {
                if (ckbIntativo.Checked)
                {
                    dgvColaborador.DataSource = controllerColaborador.ListarTodosColaboradores();
                    DefinirCabecalhos(new List<string>() { "ID", "Nome", "Cpf", "Departamento", "Cargo", "telefone", "E-mail Coorp.", "E-mail Pessoal", "Usuario", "Senha", "Status" });


                }
                else
                {
                    Listar();
                }
            }



        }

 
    }
}
