using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.EntityFrameworkCore;

namespace SenacAlimentacao
{// banco de dados representado no cSharp
    internal class ComandaDBContext:DbContext//banco de dados representado no cSharp
    {
        public DbSet<Usuario> Usuarios { get; set; } //tabela usuarios
        public DbSet<CardapioItem> CardapioItens { get; set; } //tabela cardápio
        public DbSet<Mesa> Mesas { get; set; } //tabela mesas
        public DbSet<Comanda> Comandas { get; set; } //tabela comandas
    }
}
//comandos sempre ficam no plural | palavras em branco o dev pode alterar  