using System.Collections.Generic;
using System.Linq;
using HoneydewTestProject.A;

namespace HoneydewTestProject
{
    internal class Generics
    {
        public void Method(List<C1> c1Params)
        {
            var x = c1Params.Single().X;
        }

        public void Method(List<D1> d1Params)
        {
            var x = d1Params;
        }
    }
}