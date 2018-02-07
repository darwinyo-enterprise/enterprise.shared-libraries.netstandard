using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Interfaces.NetStandard
{
    public interface IMockData<T> where T : class, new()
    {
        T GetNormalCaseMockData();
        T GetBadCaseMockData();
    }
}
