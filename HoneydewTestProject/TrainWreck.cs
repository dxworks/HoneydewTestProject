namespace HoneydewTestProject
{
    internal class TrainWreck
    {
        public void Method()
        {
            var x = new Wagon4().Method4().Method3().Method2().X;
        }
    }

    public class Wagon2
    {
        public Wagon1 Method2()
        {
            return new Wagon1();
        }
    }

    public class Wagon3
    {
        public Wagon2 Method3()
        {
            return new Wagon2();
        }
    }

    public class Wagon4
    {
        public Wagon3 Method4()
        {
            return new Wagon3();
        }
    }

    public class Wagon1
    {
        public int X { get; set; }
    }
}