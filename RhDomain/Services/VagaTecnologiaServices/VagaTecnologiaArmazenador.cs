using RhDomain.Dto;
using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.VagaTecnologiaServices
{
    public class VagaTecnologiaArmazenador : IVagaTecnologiaArmazenador
    {
        private readonly IVagaTecnologiaRepository _vagaTecnologiaRepository;
        private readonly IUnitOfWork _uow;

        public VagaTecnologiaArmazenador(IVagaTecnologiaRepository vagaTecnologiaRepository, IUnitOfWork uow)
        {
            _vagaTecnologiaRepository = vagaTecnologiaRepository;
            _uow = uow;
        }
        public VagaTecnologiaDto IncluirVagaTecnologia(VagaTecnologiaDto vagaTecnologiaDto)
        {
            var vagaTecnologia = new VagaTecnologia(vagaTecnologiaDto.VagaId, vagaTecnologiaDto.TecnologiaId, vagaTecnologiaDto.Peso);
            _vagaTecnologiaRepository.Armazenar(vagaTecnologia);
            _uow.Commit();
            return vagaTecnologiaDto;
        }

    }
}
