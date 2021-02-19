using System;

namespace Fila {
    class Fila {
        public OrdemServico Head { get; set; }
        public OrdemServico Tail { get; set; }

        private bool Vazia() {
            if (Head == null) return true;
            return false;
        }
        public void Push(OrdemServico aux) {
            Console.Clear();
            if (Vazia()) {
                Head = aux;
                Tail = aux;
            }
            else {
                Tail.Proximo = aux; 
                Tail = aux;
            }
            Console.WriteLine("\nElemento inserido com sucesso!!");
        }
        public void Print() {
            Console.Clear();
            if (Vazia()) {
                Console.WriteLine("Impossível Imprimir! Fila Vazia!");
            }
            else {
                OrdemServico aux = Head;
                Console.WriteLine("\n>>>AS Ordens de Serviço são<<<\n");
                do {
                    Console.WriteLine(aux);
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("\n>>> FIM DA IMPRESSÃO <<<");
            }
        }
        public void Pop() {
            Console.Clear();
            if (Vazia()) {
                Console.WriteLine("Impossível Remover! Fila Vazia!");
            }
            else {
                Head = Head.Proximo;
                Console.WriteLine("Elemento Removido com Sucesso!");

            }
        }
        public void QtdElementos() {
            int cont = 0;
            OrdemServico aux = Head;
            Console.Clear();
            if (Vazia()) Console.WriteLine("A Fila de Serviços encontra-se vazia!");
            else {
                do {
                    aux = aux.Proximo;
                    cont++;
                } while (aux != null);
                Console.WriteLine($"Quantidade de Serviços: {cont}");
            }

        }
        public void BuscarServico() {
            int cont = 0, num = 0;
            OrdemServico aux = Head;
            Console.Clear();
            if (Vazia()) Console.WriteLine("A Fila de Serviços encontra-se vazia!");
            else {
                Console.Write("Digite o Número de Serviço que deseja buscar: ");
                num = int.Parse(Console.ReadLine());
                while (aux != null) {
                    if (aux.Numero == num) {
                        cont++;
                        Console.WriteLine($"Serviço {num} encontrado em {cont}º na fila");
                    }
                    aux = aux.Proximo;
                }
                if (cont == 0) Console.WriteLine("Serviço não encontrado na Fila!");
            }
        }
    }
}
