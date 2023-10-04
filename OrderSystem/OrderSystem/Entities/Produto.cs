using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Entities
{
    internal class Produto
    {
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        public Produto() { }

        public Produto(string nomeProduto, double preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }
    }
}
