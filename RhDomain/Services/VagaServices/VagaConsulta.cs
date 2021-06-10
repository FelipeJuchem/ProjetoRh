using AutoMapper;
using RhDomain.Dto;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Entities.VagasTecnologias;
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
        public async Task<List<VagaComTecnologiaDto>> ObterListaDeVagas()
        {
            var listaVaga = await _vagaRepository.BuscarLista();
            var listaVagaDto = _mapper.Map<List<VagaComTecnologiaDto>>(listaVaga);
            return listaVagaDto;
        }

        public VagaComTecnologiaDto ObterVagaComTecnologiaPorId(int id)
        {
            var vaga = _vagaRepository.BuscaVagaComInclude(id);
            return _mapper.Map<VagaComTecnologiaDto>(vaga);
            
            //List<TecnologiaDto> tecnologiasDto = new List<TecnologiaDto>();
            //foreach(VagaTecnologia vagaTecnnologia in vaga.VagasTecnologias)
            //{
            //    tecnologiasDto.Add(TecnologiaDto.DeVagaTecnologia(vagaTecnnologia));
            //}

            //vagaDto.Tecnologias = tecnologiasDto;
            //return vagaDto;

            //var vaga = _vagaRepository.BuscarPorId(id);
            //return  _mapper.Map<VagaDto>(vaga);
        }

        public VagaDto ObterVagaPorId(int id)
        {
            var vaga = _vagaRepository.BuscarPorId(id);
            return _mapper.Map<VagaDto>(vaga);
        }

        


    }
}
