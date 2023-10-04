using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem.Entities;
using OrderSystem.Entities.Enums;
using System.Globalization;

namespace OrderSystem.Entities
{
    internal class Pedido
    {
        public DateTime Momento { get; set; }
        public PedidoStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

        public Pedido () { }

        public Pedido(DateTime momento, PedidoStatus status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(PedidoItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(PedidoItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (PedidoItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Horário do Pedido: {Momento.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Status do Pedido: {Status}");
            sb.AppendLine($"{Cliente.NomeCliente} {Cliente.DataAniversario.ToString("dd/MM/yyyy")} - {Cliente.Email}");
            sb.AppendLine("Itens Pedidos:");
            foreach(PedidoItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Preco Total: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
