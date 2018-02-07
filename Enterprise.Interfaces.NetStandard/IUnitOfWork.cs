using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Interfaces.NetStandard
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
    }
}
