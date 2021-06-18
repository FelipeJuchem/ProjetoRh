using AutoMapper;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Services.VagaTecnologiaServices
{
    public class VagaTecnologiaConsulta : IVagaTecnologiaConsulta
    {
        private readonly IMapper _mapper;
        private readonly IVagaTecnologiaRepository _vagaTecnologiaRepository;
       
        public VagaTecnologiaConsulta(IVagaTecnologiaRepository vagaTecnologiaRepository, IMapper mapper)
        {
            _vagaTecnologiaRepository = vagaTecnologiaRepository;
            _mapper = mapper;
        }
        public async Task<List<VagaTecnologiaDto>> BuscarListaVagaTecnologia()
        {
            var listaVagaTecnologia = await _vagaTecnologiaRepository.BuscarLista();
            return _mapper.Map<List<VagaTecnologiaDto>>(listaVagaTecnologia);
        }

        public VagaTecnologiaDto BuscaVagaTecnologiaPorId(int vagaId, int tecnologiaId)
        {
            var vagaTecnologia = _vagaTecnologiaRepository.BuscaVagaTecnologiaPorIdDuplo(vagaId, tecnologiaId);
            return _mapper.Map<VagaTecnologiaDto>(vagaTecnologia);
        }
    }
}
