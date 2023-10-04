using OrderSystem.Entities.Enums;
using OrderSystem.Entities;
using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("Informe o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Informe o email do cliente: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Informe o aniversário do cliente (DD/MM/YYYY): ");
            DateTime aniversarioCliente = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre os dados do pedido:");
            Console.Write("Status: ");
            PedidoStatus status = Enum.Parse<PedidoStatus>(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCliente, emailCliente, aniversarioCliente);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.WriteLine();
            Console.Write("Quantos itens tem esse pedido? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre os dados do item {i}:");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preco do produto: ");
                double precoProduto = double.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeProduto, precoProduto);

                Console.Write("Quantidade: ");
                int quantProduto = int.Parse(Console.ReadLine());

                PedidoItem pedidoItem = new PedidoItem(quantProduto, precoProduto, produto);

                pedido.AddItem(pedidoItem);
            }

            Console.WriteLine();
            Console.WriteLine("DADOS DO PEDIDO");
            Console.WriteLine(pedido);
        }
    }
}
