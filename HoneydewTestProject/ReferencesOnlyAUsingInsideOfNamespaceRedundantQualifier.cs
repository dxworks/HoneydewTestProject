namespace HoneydewTestProject
{
    using HoneydewTestProject.A;

    public class ReferencesOnlyAUsingInsideOfNamespaceRedundantQualifier
    {
        public void Method(C1 c1Params)
        {
            var x = c1Params.X;
        }
    }
}