﻿using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface IVagaTecnologiaArmazenador
    {
        VagaTecnologiaDto IncluirVagaTecnologia(VagaTecnologiaDto vagaTecnologiaDto); 
    }
}
