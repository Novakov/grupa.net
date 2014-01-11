using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public abstract class HandlerAspectAttribute : Attribute
    {
        public virtual void BeforeHandle(object command)
        {}
    }
}
