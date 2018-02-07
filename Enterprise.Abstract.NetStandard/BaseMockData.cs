using Enterprise.Interfaces.NetStandard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Abstract.NetStandard
{
    public abstract class BaseMockData<T> : IMockData<T> where T : class, new()
    {
        public virtual T GetBadCaseMockData()
        {
            throw new NotImplementedException();
        }

        public abstract T GetNormalCaseMockData();
    }
}
