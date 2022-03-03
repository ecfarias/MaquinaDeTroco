using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTroco {
    internal class Moeda {
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        /// <summary>
        /// Construtor para Propriedades non-nullable
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="quantidade"></param>
        public Moeda(decimal valor, int quantidade) {
            Valor = valor;
            Quantidade = quantidade;
        }
    }
}
