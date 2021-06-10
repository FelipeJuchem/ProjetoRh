﻿using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface IVagaArmazenador
    {
        ActionResult<VagaComTecnologiaDto> IncluirVaga(VagaComTecnologiaDto VagaDto);
    }
}
