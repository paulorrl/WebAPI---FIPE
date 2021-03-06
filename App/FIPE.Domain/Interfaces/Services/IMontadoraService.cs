﻿using System;
using System.Collections.Generic;
using FIPE.Domain.Entities;

namespace FIPE.Domain.Interfaces.Services
{
    public interface IMontadoraService : IDisposable
    {
        IEnumerable<Montadora> GetAll();
    }
}