
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPDVBack.Controller;
using SistemaPDVBack.Model;


namespace SistemaPDVBack.View
{
    public partial class frmCupom : Form
    {
        public frmCupom()
        {
            InitializeComponent();
            

        }
        ControllerPedido cupom = new ControllerPedido();

    
        public void CumpomImpresso(string codItem, string codBarras, string descricao, string quantidade, 
                                    string valorUnit, string Total, string Status, string cpf, 
                                    string totalVendido, string data, 
                                    string hora, string caixa, string formaPagamento, 
                                    string valorRecebido, string troco )
        {
            listBox1.Clear();
     
            cupom.ImprimirCupom(codItem, codBarras, descricao, quantidade,valorUnit, Total, Status , cpf, data , hora, caixa, formaPagamento, valorRecebido, troco, totalVendido);
            foreach (string obj in cupom.Layout)
            {
               listBox1.Items.Add(obj);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

