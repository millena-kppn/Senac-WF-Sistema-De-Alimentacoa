using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao
{
    public class Comanda
    {
        public int Id { get; set; } // Identificador único da comanda
        public int NumerosMesa { get; set; } // Número da mesa associada à comanda
        public int NomeCliente{ get; set; } // Nome do cliente associado à comanda
        public int SituacaoComanda { get; set; }// Situação da comanda (0 - Aberta, 1 - Fechada, 2 - Cancelada)

    }
}
