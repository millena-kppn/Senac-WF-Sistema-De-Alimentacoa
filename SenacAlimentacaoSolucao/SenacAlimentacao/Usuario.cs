using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao
{
    internal class Usuario
    {
        //criar as propriedades 
        public int Id { get; set; }//id,
        public string Nome { get; set; }//nome,
        public string Email { get; set; }//email,
        public string Senha { get; set; }//senha,
        public bool Ativo { get; set; }//tipo
    }
}
