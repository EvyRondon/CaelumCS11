using System.Collections.Generic;

namespace Banco.Busca
{
    class GeradorDeDevedores
    {
        public SortedSet<string> GeraLista()
        {
            SortedSet<string> nomes = new SortedSet<string>();
            for (int i = 0; i < 30000; i++)
            {
                nomes.Add($"devedores {i}");
            }
            return nomes;
        }
    }
}
