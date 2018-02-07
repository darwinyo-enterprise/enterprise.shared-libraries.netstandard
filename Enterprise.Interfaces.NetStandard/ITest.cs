using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Interfaces.NetStandard
{
    public interface ITest
    {
        void StartUp();
        void CleanUp();
        void InitDatabase();
        void CleanUpDatabase();
        void CleanUpLogs();
        void InitVariables();
        void CleanUpVariables();
        void InitMockData();
        void CleanUpMockData();
    }
}
