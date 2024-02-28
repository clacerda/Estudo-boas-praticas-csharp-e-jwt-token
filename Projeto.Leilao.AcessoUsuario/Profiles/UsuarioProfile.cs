using AutoMapper;
using Projeto.Leilao.AcessoUsuario.Data.Dtos;
using Projeto.Leilao.AcessoUsuario.Models;

namespace UsuariosAPI.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }
}
