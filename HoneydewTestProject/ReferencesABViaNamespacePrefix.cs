using HoneydewTestProject.A;

namespace HoneydewTestProject
{
    public class ReferencesABViaNamespacePrefix
    {
        public C1 C1A { get; set; }

        public B.C1 C1B { get; set; }
    }
}