namespace HoneydewTestProject
{
    using A;

    public class ReferencesOnlyAUsingInsideOfNamespaceNoRedundantQualifier
    {
        public void Method(C1 c1Params)
        {
            var x = c1Params.X;
        }
    }
}