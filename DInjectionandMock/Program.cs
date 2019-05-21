using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DInjectionandMock
{
    class Program
    {
        static void Main(string[] args)
        {
            IDependency idependency = new Dependency();
            var dependencyIsolation = new DependencyIsolation(idependency);
            dependencyIsolation.X();
            Console.ReadLine();

        }
    }
}
