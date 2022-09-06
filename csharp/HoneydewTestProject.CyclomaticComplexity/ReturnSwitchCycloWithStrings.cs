using System;

namespace HoneydewTestProject.CyclomaticComplexity
{
    public class ReturnSwitchCycloWithStrings
    {
        public string Function(string a)
        {
            return a switch
            {
                "object" => "obj",
                "value" => "val",
                _ => a
            };
        }
    }
}
