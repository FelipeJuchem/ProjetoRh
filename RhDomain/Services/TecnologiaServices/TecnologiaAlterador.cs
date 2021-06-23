using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.TecnologiaServices
{
    public class TecnologiaAlterador : ITecnologiaAlterador
    {
        private readonly ITecnologiaRepository _tecnologiaRepository;
        private readonly IUnitOfWork _uow;

        public TecnologiaAlterador(ITecnologiaRepository tecnologiaRepository, IUnitOfWork uow)
        {
            _tecnologiaRepository = tecnologiaRepository;
            _uow = uow;
        }
       
        public TecnologiaDto Alterar(TecnologiaDto tecnologiaDto)
        {
            if(tecnologiaDto.Descricao != string.Empty)
            {
                var tecnologia = _tecnologiaRepository.BuscarPorId(tecnologiaDto.Id);
                tecnologia.AtualizarDescricao(tecnologiaDto.Descricao);
                _tecnologiaRepository.Alterador(tecnologia);
                _uow.Commit();
                return tecnologiaDto;
            }
            throw new Exception("Descrição não pode estar vazia!");
            
        }
    }
}
