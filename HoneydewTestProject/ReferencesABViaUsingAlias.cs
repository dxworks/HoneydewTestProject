using HoneydewTestProject.A;
using C1B = HoneydewTestProject.B.C1;

namespace HoneydewTestProject
{
    public class ReferencesABViaUsingAlias
    {
        public void MethodC1A(C1 c1Params)
        {
            var x = c1Params.X;
        }

        public void MethodC1B(C1B c1Params)
        {
            var x = c1Params.X;
        }
    }
}