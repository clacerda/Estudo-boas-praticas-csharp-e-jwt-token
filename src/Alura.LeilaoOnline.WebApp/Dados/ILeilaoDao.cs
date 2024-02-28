using Projeto.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        Leilao BuscarLeilaoPorId(int id);
        IEnumerable<Leilao> BuscarTodosLeiloes();
        IEnumerable<Categoria> BuscarTodasCategorias();
        void Incluir(Leilao leilao);
        void Alterar(Leilao leilao);
        void Excluir(Leilao leilao);
    }
}
