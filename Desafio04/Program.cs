using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio04.Entidades;
using System.Threading;

namespace Desafio04 {
    class Program {
        static void Main(string[] args) {
            Loja loja = new Loja();
            Livro livro = new Livro();
            VideoGame videogame = new VideoGame();

            livro.AdicionarLivro(loja, "Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            livro.AdicionarLivro(loja, "Senhor Dos Anéis", 60, 30, "J. K. Rowling", "fantasia", 500);
            livro.AdicionarLivro(loja, "Java POO", 20, 50, "GFT", "educativo", 500);

            videogame.AdicionarVideoGame(loja, "PS4", 1800, 100, "Sony", "Slim", false);
            videogame.AdicionarVideoGame(loja, "PS4", 1000, 7, "Sony", "Slim", true);
            videogame.AdicionarVideoGame(loja, "XBOX", 1500, 500, "Microsoft", "One", false);

            loja.Nome = "Americanas";
            loja.CNPJ = "12345678";

            //2000 1800 1000 180000 7000 750000

            loja.ListarLivros(loja);
            loja.ListarVideoGames(loja);
            Console.WriteLine($"\n\npatrimônio: {loja.CalcularPatrimonio(loja)}");
        }
    }
}
