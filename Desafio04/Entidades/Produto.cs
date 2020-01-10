using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio04.Entidades.Interfaces;

namespace Desafio04.Entidades {
    abstract class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
