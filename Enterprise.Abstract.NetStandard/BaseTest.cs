using Enterprise.Interfaces.NetStandard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Abstract.NetStandard
{
    public abstract class BaseTest : ITest, IDisposable
    {
        public virtual void CleanUp()
        {
            CleanUpLogs();
            CleanUpDatabase();
            CleanUpVariables();
            CleanUpMockData();
        }

        public virtual void CleanUpDatabase()
        {

        }

        public virtual void CleanUpLogs()
        {

        }

        public virtual void CleanUpMockData()
        {

        }

        public virtual void CleanUpVariables()
        {

        }

        public void Dispose()
        {
            CleanUp();
        }

        public virtual void InitDatabase()
        {

        }

        public virtual void InitMockData()
        {

        }

        public virtual void InitVariables()
        {

        }
        public virtual void StartUp()
        {
            InitMockData();
            InitVariables();
            InitDatabase();
        }
    }
}
