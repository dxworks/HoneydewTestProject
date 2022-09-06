using HoneydewTestProject.A;

namespace HoneydewTestProject
{
    public class ReferencesABViaNamespacePrefix
    {
        public void MethodC1A(C1 c1Params)
        {
            var x = c1Params.X;
        }

        public void MethodC1B(B.C1 c1Params)
        {
            var x = c1Params.X;
        }
    }
}