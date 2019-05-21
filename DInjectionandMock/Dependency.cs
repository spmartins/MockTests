using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DInjectionandMock
{
    public class Dependency: IDependency
    {
        public int Meaning => throw new NotImplementedException();

        public string JoinUpper(string a, string b)
        {
            throw new NotImplementedException();
        }
    }
}
