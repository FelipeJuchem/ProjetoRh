using AutoMapper;
using RhDomain.Dto;
using RhDomain.Entities.Vagas;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Services.VagaServices
{
    public class VagaConsulta : IVagaConsulta
    {
        private readonly IMapper _mapper;
        private readonly IVagaRepository _vagaRepository;
        public VagaConsulta(IVagaRepository vagaRepository, IMapper mapper)
        {
            _mapper = mapper; 
            _vagaRepository = vagaRepository;
        }
        public List<VagaDto> ObterListaDeVagas()
        {
            var listaVaga = _vagaRepository.BuscarLista();
            var listaVagaDto = _mapper.Map<List<VagaDto>>(listaVaga);
            return listaVagaDto;
        }

        public VagaDto ObterVagaPorId(int id)
        {
            var vaga = _vagaRepository.BuscarPorId(id);
            var vagaDto = _mapper.Map<VagaDto>(vaga);
            return vagaDto;
        }
    }
}
