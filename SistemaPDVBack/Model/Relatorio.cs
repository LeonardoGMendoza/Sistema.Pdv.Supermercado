using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Relatorio
    {
        string dataInicial;
        string dataFinal;
        string id;
        string quantidade;
        string nome;
        string precoVenda;
        string total;

        public string DataInicial { get { return dataInicial;} set {dataInicial = value; } }
        public string DataFinal { get { return dataFinal; } set { dataFinal = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Quantidade { get { return quantidade; } set { quantidade = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string PrecoVenda { get { return precoVenda; } set { precoVenda = value; } }
        public string Total { get { return total; } set { total = value; } }




    }
}
