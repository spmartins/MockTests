using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DInjectionandMock
{
    public class Salutation
    {
        private readonly IMessageWriter writer;
        public Salutation(IMessageWriter writter)
        {
            this.writer = writter ?? throw new ArgumentNullException("writer");
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI");
        }
    }
}
