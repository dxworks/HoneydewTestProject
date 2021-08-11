namespace HoneydewTestProject.CyclomaticComplexity
{
    public class IfCyclo
    {
        public void Function(int a)
        {
            var b = 5;
            if (a > -2)
            {
                b = 1;
            }
            else if (a > 0)
            {
                b = 2;
            }

            // if (a < 6)
            // {
            //     b = 10;
            // }
            // else
            // {
            //     b = 100;
            // }

            // if (b < 100)
            // {
            //     b = 5;
            // }
        }
    }
}
