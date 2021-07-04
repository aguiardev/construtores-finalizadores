using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            var filmeRepo = new FilmeRepositorio('M');

            Console.WriteLine(string.Join(", ", filmeRepo.ListarFilmes()));
        }
    }
}
