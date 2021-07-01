using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.AbstractClasses
{
    public abstract class GeeksForGeeks : ICloneable
    {

        public abstract void gfg();

        public abstract object Clone();

        public virtual string VirtualMethod() // es sobreescribible
        {
            return "we are testing";
        }

    }
}
