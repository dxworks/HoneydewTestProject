namespace HoneydewTestProject.CyclomaticComplexity
{
    public class IfWithMultipleConditionsCyclo
    {
        public void Function(int a, int b, int c)
        {
            var x = 0;

            if (a > 0 && b < 5)
            {
                x = 2;
            }

            if (a < -2 && c > 6 && b > 2)
            {
                x = 6;
            }
            else if (a < -7 && c > 8)
            {
                x = 5;
            }
            else if (a > 7 && b < 3)
            {
                x = 8;
            }

            if (c > a && b > c)
            {
                x = 6;
            }
            else
            {
                x = 8;
            }
        }
    }
}
