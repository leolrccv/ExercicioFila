using System;

namespace Fila {
    class OrdemServico {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public int Prazo { get; set; }
        public OrdemServico Proximo { get; set; }


        public override string ToString() {
            return $"\n=-=-DADOS DA ORDEM DE SERVIÇO-=-=\n\nNúmero: {Numero}\nTipo: {Tipo}\nDescrição: {Descricao}" +
                $"\nData: {Data.ToShortDateString()}\nPrazo em dias: {Prazo}";
        }
    }
}
