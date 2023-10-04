using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Entities
{
    internal class Cliente
    {
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }

        public Cliente() { }

        public Cliente(string nomeCliente, string email, DateTime dataAniversario)
        {
            NomeCliente = nomeCliente;
            Email = email;
            DataAniversario = dataAniversario;
        }
    }
}

