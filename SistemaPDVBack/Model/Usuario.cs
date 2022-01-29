using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Usuario
    {
        
        string login;
        string senha;
        bool statusAtivo;
        public string Login { get{return login;} set{login = value;} }
        public string Senha { get{return senha ;} set{ senha = value;} }
        public bool StatusAtivo { get{return statusAtivo;} set{ statusAtivo = value;} }

    }
}
