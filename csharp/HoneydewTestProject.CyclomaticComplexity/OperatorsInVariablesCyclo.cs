namespace HoneydewTestProject.CyclomaticComplexity
{
    public class OperatorsInVariablesCyclo
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C => A && B;
        public bool D => A & B;
        public bool E => A || B;
        public bool F => A | B;
        public bool G => A ^ B;
        public bool H => !A;

        public void Function(bool a, bool b)
        {
            var c = a && b;
            var d = a & b;
            var e = a || b;
            var f = a | b;
            var g = a ^ b;
            var h = !a;
        }
    }
}
