﻿namespace HoneydewTestProject.CyclomaticComplexity
{
    public class ForCyclo
    {
        public void Function(int a)
        {
            var sum = 0;
            for (var i = 0; i < a; i++)
            {
                sum += i;
            }

            for (var i = 0; i < sum && a < sum; i++)
            {
                sum--;
            }

            for (int i = 0; ; i++)
            {
                break;
            }
        }
    }
}
