using System;

namespace Fila {
    class Program {
        static void Main(string[] args) {
            int op = 0;

            Fila fila = new Fila { Head = null, Tail = null };

            do {
                Console.WriteLine("\n1-Inserir Serviço\n2-Remover Serviço\n3-Imprimir Fila\n4-Quantidade de Elementos na Fila" +
                    "\n5-Busca de Serviço na Fila por Número da OS\n0-Sair");
                Console.Write("\nDigite uma opção: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op) {
                    case 1:
                        OrdemServico ordem;
                        ordem = InserirServico();
                        fila.Push(ordem);
                        break;

                    case 2:
                        fila.Pop();
                        break;

                    case 3:
                        fila.Print();
                        break;
                    
                    case 4:
                        fila.QtdElementos();
                        break;
                        
                    case 5:
                        fila.BuscarServico();
                        break;
                }
            } while (op != 0);

            Console.WriteLine("\nPressione qualquer tecla para fechar o programa");
            Console.ReadKey();
        }

        static OrdemServico InserirServico() {
            string tipo, descricao;
            int numero, prazo;
            DateTime data;

            Console.Write("Numero do Serviço: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Tipo de Serviço: ");
            tipo = Console.ReadLine();

            Console.Write("Descrição do Serviço: ");
            descricao = Console.ReadLine();

            Console.Write("Data do Serviço[data/mes/ano]: ");
            data = DateTime.Parse(Console.ReadLine());

            Console.Write("Prazo para entrega: ");
            prazo = int.Parse(Console.ReadLine());

            OrdemServico o = new OrdemServico { Numero = numero, Tipo = tipo, Descricao = descricao, Data = data, Prazo = prazo };
            return o;
        }
    }
}

