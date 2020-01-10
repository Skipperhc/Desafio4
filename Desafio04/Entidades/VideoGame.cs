using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio04.Entidades.Interfaces;

namespace Desafio04.Entidades {
    class VideoGame : Produto, Imposto {
        Loja loja = new Loja();
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Boolean IsUsado { get; set; }

        public void AdicionarVideoGame(Loja loja, string nome, double preco, int qtd, string marca, string modelo, bool isUsado) {
            loja.ListaVideoGame.Add(new VideoGame() {
                Nome = nome,
                Preco = preco,
                Quantidade = qtd,
                Marca = marca,
                Modelo = modelo,
                IsUsado = isUsado
            });
        }

        public double CalcularImposto() {
            double Total = 0;
            if (IsUsado == true) {
                Total = Preco + ((Preco / 100) * 25);
            } else if (IsUsado == false) {
                Total = Preco + ((Preco / 100) * 50);
            }
            return Total + Preco;
        }
    }
}
