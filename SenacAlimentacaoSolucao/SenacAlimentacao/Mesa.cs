using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao
{
    internal class Mesa
    {
        public int Id  { get; set; }
        public int NumeroMesa { get; set; } // Número da mesa
        //0 - Livre, 1 - Ocupada, 2 - Reservada
        public int SituacaoMesa { get; set; } // Número de pessoas na mesa
    }
}
