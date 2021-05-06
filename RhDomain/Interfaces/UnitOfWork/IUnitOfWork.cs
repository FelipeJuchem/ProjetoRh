using OnboardingSIGDB1.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        CommandResponse Commit();
        void ResetChanges();
    }
}
