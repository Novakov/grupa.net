using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifyVisitor
{
    public abstract class VisitorBase
    {
        public void Dispatch(Node node)
        {
            // Call proper Visit method
        }
    }
}
