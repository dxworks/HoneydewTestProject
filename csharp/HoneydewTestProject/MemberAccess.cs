using HoneydewTestProject.A;

namespace HoneydewTestProject
{
    public class MemberAccess : BaseMemberAccess
    {
        public string PropertyAccessor
        {
            get => new C1().GetStuff();
            set { }
        }

        public void Function()
        {
            var c1 = new C1();
            var c1X = c1.X;
            var c1Y = c1.Y;
            var c1Z = c1.Z;
            var stuff = c1.GetStuff();
            var c1SomeEnum = c1.SomeEnum;

            var y = D1;
            var interfaceProperty = InterfaceProperty;
        }
    }

    public class BaseMemberAccess : BaseMemberAccess2
    {
        public D1 D1 { get; set; }
    }

    public class BaseMemberAccess2 : ISomeInterface
    {
        public D1 InterfaceProperty { get; set; }
    }

    public interface ISomeInterface
    {
        public D1 InterfaceProperty { get; set; }
    }
}