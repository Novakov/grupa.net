using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Commands
{
    public class AddTwoNumbers : ICommand<int>
    {
        public int A { get; private set; }
        public int B { get; private set; }

        public AddTwoNumbers(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
    }
}
