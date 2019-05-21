using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DInjectionandMock
{
   public interface IDependency
    {
        string JoinUpper(string a, string b);
        int Meaning { get; }
    }
}
