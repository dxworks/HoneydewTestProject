﻿namespace HoneydewTestProject.CyclomaticComplexity
{
    public class ConditionalOperatorsCyclo
    {
        public void Function(string s)
        {
            var a = s.Length == 2 ? 1 : -1;
            var b = s?.Length;
            var c = s ?? "value";
            s ??= "z";
        }
    }
}
