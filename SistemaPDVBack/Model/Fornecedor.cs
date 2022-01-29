using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Fornecedor
    {

        int idFornecedor;
        string inscricaoEstadual;
        string nomeFantasia;
        string ufPessoa;
        string numeroPessoa;
        string complementoPessoa;
        string bairroPessoa;
        string cidadePessoa;
        int cepFornecedor;
        int statusAtivo;
        string cnpj;
        string rua;
        public int IdFornecedor { get {return idFornecedor; } set {idFornecedor = value; } }
        public string InscricaoEstadual { get{return inscricaoEstadual;} set{ inscricaoEstadual = value;} }
        public string NomeFantasia { get{return nomeFantasia;} set{nomeFantasia = value;} }
        public string UfPessoa { get{return ufPessoa;} set{ufPessoa =  value;} }
        public string NumeroPessoa { get{return numeroPessoa;} set{ numeroPessoa = value;} }
        public string ComplementoPessoa { get{return complementoPessoa;} set{ complementoPessoa = value;} }

        public string BairroPessoa { get{return bairroPessoa ;} set{ bairroPessoa = value;} }
        public string CidadePessoa { get{return cidadePessoa  ;} set{ cidadePessoa = value;} }
        public int CepFornecedor { get{return  cepFornecedor;} set{ cepFornecedor = value;} }

        public int StatusAtivo { get{return statusAtivo;} set{statusAtivo = value;} }
        public string  Cnpj { get{return cnpj ;} set{cnpj = value;} }
        public string Rua { get{return rua;} set{rua = value;} }





    }
}
