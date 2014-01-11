using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Commands;

namespace Sample.CommandHandlers
{
    public class AddTwoNumbersHandler
    {
        public int Handle(AddTwoNumbers cmd)
        {
            return cmd.A + cmd.B;
        }
    }
}
