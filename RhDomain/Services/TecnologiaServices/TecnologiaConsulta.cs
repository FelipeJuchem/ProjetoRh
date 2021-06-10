using AutoMapper;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Services.TecnologiaServices
{
    public class TecnologiaConsulta : ITecnologiaConsulta
    {
        private readonly ITecnologiaRepository _tecnologiaRepository;
        private readonly IMapper _mapper;

        public TecnologiaConsulta(ITecnologiaRepository tecnologiaRepository, IMapper mapper)
        {
            _tecnologiaRepository = tecnologiaRepository;
            _mapper = mapper;
        }

        public async Task<List<TecnologiaDto>> ObterListaDeTecnologias()
        {
            var listaTecnologias = await _tecnologiaRepository.BuscarLista();
            var listaTecnologiasDto = _mapper.Map<List<TecnologiaDto>>(listaTecnologias);
            return listaTecnologiasDto;
        }

        public TecnologiaDto ObterTecnologiaPorId(int id)
        {
            var tecnologia = _tecnologiaRepository.BuscarPorId(id);
            var tecnologiaDto = _mapper.Map<TecnologiaDto>(tecnologia);
            return tecnologiaDto;
        }


    }
}
