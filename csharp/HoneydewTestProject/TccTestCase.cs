using HoneydewTestProject.A;

namespace HoneydewTestProject
{
    public class TccTestCase
    {
        private readonly int anotherField = 3;
        private readonly int someField = 2;

        private C1 objectField = new C1();

        public void MethodUsesOne()
        {
            var x = someField;
        }

        public void MethodUsesAnother()
        {
            var x = anotherField;
        }

        public void MethodUsesBoth()
        {
            var x = anotherField;
            var y = someField;
        }

        public void MethodUsesObjectField()
        {
            var x = objectField.X;
        }
    }
}