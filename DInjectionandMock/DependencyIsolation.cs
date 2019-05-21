using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DInjectionandMock
{
    public class DependencyIsolation
    {
        private readonly IDependency _idependency;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DependencyIsolation(IDependency idependency)
        {
            _idependency = idependency ?? throw new ArgumentNullException("DependencyIsolation");
        }

        public string X ()
        {
            var fullName = _idependency.JoinUpper(FirstName, LastName);
            return $"{fullName} = { _idependency.Meaning}";
        }
    }
}
