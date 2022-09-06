using HoneydewTestProject.A;

namespace HoneydewTestProject
{
    public class NotAmbiguous
    {
        private D1 d1Field;

        public D1 D1Prop { get; set; }

        public void UsingD1AsLocalVariable()
        {
            D1 localVariable = new D1();
        }

        public void UsingD1AsLocalVariable2()
        {
            D1 localVariable = new D1();
        }

        public void UsingD1AsParameter(D1 param)
        {
            var x = param.X;
        }
    }
}