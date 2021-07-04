using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Exemplo
{
    public class FilmeRepositorio
    {
        private char _filtroPorLetra;

        private bool _conexaoAberta;

        private IList<string> _filmes = new List<string>()
        {
            "Godzilla", "Vingadores", "Missão Impossível"
        };

        public FilmeRepositorio()
        {
            
        }

        public FilmeRepositorio(char filtroPorLetra)
        {
            _filtroPorLetra = filtroPorLetra;
        }

        public IList<string> ListarFilmes()
            => char.IsLetter(_filtroPorLetra)
                ? _filmes.Where(w => w.StartsWith(_filtroPorLetra)).ToList()
                : _filmes;
            
        ~FilmeRepositorio()
        {
            if(!_conexaoAberta)
            {
                _conexaoAberta = false;
            }
        }
    }
}