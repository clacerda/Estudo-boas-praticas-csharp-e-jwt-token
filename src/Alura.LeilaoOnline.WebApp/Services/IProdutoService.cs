using System.Collections.Generic;
using Projeto.LeilaoOnline.WebApp.Models;

namespace Projeto.LeilaoOnline.WebApp.Services
{
    public interface IProdutoService
    {
        IEnumerable<Leilao> PesquisaLeiloesEmPregaoPorTermo(string termo);
        IEnumerable<CategoriaComInfoLeilao> ConsultaCategoriasComTotalDeLeiloesEmPregao();
        Categoria ConsultaCategoriaPorIdComLeiloesEmPregao(int id);
    }
}
