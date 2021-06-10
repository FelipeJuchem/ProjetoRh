using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Entities.Tecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.TecnologiaValidation;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.TecnologiaServices
{
    public class TecnologiaArmazenador : ITecnologiaArmazenador
    {
        private readonly ITecnologiaRepository _tecnologiaRepository;
        private readonly ITecnologiaValidation _tecnologiaValidation;
        private readonly IUnitOfWork _uow;
        

        public TecnologiaArmazenador(ITecnologiaRepository tecnologiaRepository, ITecnologiaValidation tecnologiaValidation,
            IUnitOfWork uow) 
        {
            _tecnologiaRepository = tecnologiaRepository;
            _tecnologiaValidation = tecnologiaValidation;
            _uow = uow;
        }

        public ActionResult<TecnologiaDto> IncluirTecnologia(TecnologiaDto tecnologiaDto)
        {
            if (_tecnologiaValidation.ValidaSeTecnologiaEstaPreenchido(tecnologiaDto))
            {
                var tecnologia = new Tecnologia(tecnologiaDto.Descricao);
                _tecnologiaRepository.Armazenar(tecnologia);
                _uow.Commit();
                return tecnologiaDto;
            }
            return null;
        }
    }
}
