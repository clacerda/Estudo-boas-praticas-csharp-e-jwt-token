using System.Collections.Generic;
using Projeto.LeilaoOnline.WebApp.Models;

namespace Projeto.LeilaoOnline.WebApp.Dados
{
    public interface ICategoriaDao
    {
        IEnumerable<Categoria> ConsultaCategorias();
        Categoria ConsultaCategoriaPorId(int id);
    }
}
