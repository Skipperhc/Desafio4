using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio04.Entidades.Interfaces;

namespace Desafio04.Entidades {
    class Livro : Produto, Imposto {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QuantidadePag { get; set; }

        public void AdicionarLivro(Loja loja, string nome, double preco, int quantidade, string autor, string tema, int qtdPag) {
            loja.ListaLivros.Add(new Livro() {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade,
                Autor = autor,  
                Tema = tema,
                QuantidadePag = qtdPag
            }); 
        }

        public double CalcularImposto() {
            double Imposto = 0;
            if (Tema == "educativo") {
                Imposto = 0;
            } else {
                Imposto = Preco + ((Preco / 100) * 10);
            }
            return Imposto + Preco;
        }
    }
}
