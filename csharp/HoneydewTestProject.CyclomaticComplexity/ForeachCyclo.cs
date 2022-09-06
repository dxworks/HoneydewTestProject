using System.Collections.Generic;

namespace HoneydewTestProject.CyclomaticComplexity
{
    public class ForeachCyclo
    {
        public void Function(IList<string> values)
        {
            var count = 0;

            foreach (var value in values)
            {
                count += value.Length;
            }
        }
    }
}
