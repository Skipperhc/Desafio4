using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04.Entidades {
    class Loja {

        public List<Livro> ListaLivros = new List<Livro>();
        public List<VideoGame> ListaVideoGame = new List<VideoGame>();
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public double Patrimonio { get; set; }
        
        public void ListarVideoGames(Loja loja) {
            Console.WriteLine("\nAs Lojas Americanas possui estes livros em estoque: \n");

            foreach (var VideoGames in ListaVideoGame) {
                Patrimonio = Patrimonio + VideoGames.Preco;
                Console.WriteLine($"Nome: {VideoGames.Nome} | Preço: {VideoGames.CalcularImposto()} | Quantidade: {VideoGames.Quantidade} em estoque");
            }
        }

        public void ListarLivros(Loja loja) {
            Console.WriteLine("\nAs Lojas Americanas possui estes livros em estoque: \n");

            for (int i = 0; i < ListaLivros.Count; i++) {
                Patrimonio = Patrimonio + ListaLivros[i].Preco;
                Console.WriteLine($"Nome: {loja.ListaLivros[i].Nome} | Preço: {loja.ListaLivros[i].CalcularImposto()} | Quantidade: {loja.ListaLivros[i].Quantidade} em estoque");
            }
        }

        public string CalcularPatrimonio(Loja loja) {
            double patrimonio = 0;

            for (int i = 0; i < loja.ListaLivros.Count; i++) {
                patrimonio = patrimonio + (loja.ListaLivros[i].Preco * loja.ListaLivros[i].Quantidade);
            }
            for (int i = 0; i < loja.ListaVideoGame.Count; i++) {
                patrimonio = patrimonio + (loja.ListaVideoGame[i].Preco * loja.ListaVideoGame[i].Quantidade);
            }

            return Convert.ToString(patrimonio);
        }

    }
}
