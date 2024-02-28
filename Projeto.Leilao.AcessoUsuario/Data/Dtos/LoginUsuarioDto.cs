using System.ComponentModel.DataAnnotations;

namespace Projeto.Leilao.AcessoUsuario.Data.Dtos
{
    public class LoginUsuarioDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
