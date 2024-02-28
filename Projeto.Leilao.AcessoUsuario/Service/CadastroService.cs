using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Projeto.Leilao.AcessoUsuario.Data.Dtos;
using Projeto.Leilao.AcessoUsuario.Models;

namespace UsuariosAPI.Service
{
    public class UsuarioService
    {
        private IMapper _mapper;
        private UsuarioService _cadastroService;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signManager;
        private TokenService _tokenService;

        public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signManager = signManager;
            _tokenService = tokenService;
        }

        public async Task Cadastra(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);

            IdentityResult result = await _userManager.CreateAsync(usuario, dto.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário!");
            }
            
        }

        public async Task<string> Login(LoginUsuarioDto dto)
        {
           var result =
                await _signManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);


            if (!result.Succeeded)
            {
                throw new ApplicationException("Usuário não autenticado!");
            }

            var usuario = _signManager
                                .UserManager
                                .Users
                                .FirstOrDefault(user => user.UserName == dto.UserName.ToUpper());

            var token = _tokenService.GenerateToken(usuario);

            return token;
        }
    }
}
