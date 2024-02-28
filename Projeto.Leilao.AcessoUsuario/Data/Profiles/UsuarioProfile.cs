using AutoMapper;
using Projeto.Leilao.AcessoUsuario.Data.Dtos;
using Projeto.Leilao.AcessoUsuario.Models;

namespace Projeto.Leilao.AcessoUsuario.Data.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
