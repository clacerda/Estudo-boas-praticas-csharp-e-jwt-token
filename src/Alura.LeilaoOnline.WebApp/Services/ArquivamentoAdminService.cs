﻿using System.Collections.Generic;
using System.Linq;
using Projeto.LeilaoOnline.WebApp.Dados;
using Projeto.LeilaoOnline.WebApp.Models;

namespace Projeto.LeilaoOnline.WebApp.Services.Handlers
{
    public class ArquivamentoAdminService : IAdminService
    {
        IAdminService _defaultService;

        public ArquivamentoAdminService(ILeilaoDao dao)
        {
            _defaultService = new DefaultAdminService(dao);
        }

        public void CadastraLeilao(Leilao leilao)
        {
            _defaultService.CadastraLeilao(leilao);
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _defaultService.ModificaLeilao(leilao);
        }

        public void RemoveLeilao(Leilao leilao)
        {
            if (leilao != null && leilao.Situacao != SituacaoLeilao.Pregao)
            {
                leilao.Situacao = SituacaoLeilao.Arquivado;
                _defaultService.ModificaLeilao(leilao);
            }
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            _defaultService.FinalizaPregaoDoLeilaoComId(id);
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            _defaultService.IniciaPregaoDoLeilaoComId(id);
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            return _defaultService.ConsultaCategorias();
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            return _defaultService
                .ConsultaLeiloes()
                .Where(l => l.Situacao != SituacaoLeilao.Arquivado);
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _defaultService.ConsultaLeilaoPorId(id);
        }
    }
}
