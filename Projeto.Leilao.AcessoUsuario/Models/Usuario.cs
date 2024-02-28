using Microsoft.AspNetCore.Identity;

namespace Projeto.Leilao.AcessoUsuario.Models;

public class Usuario : IdentityUser
{
    public DateTime DataNascimento { get; set; }

    public Usuario() : base() { }
}
