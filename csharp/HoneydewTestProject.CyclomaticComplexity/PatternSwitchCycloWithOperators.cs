﻿namespace HoneydewTestProject.CyclomaticComplexity
{
    public class PatternSwitchCycloWithOperators
    {
        public void Function(int a)
        {
            switch (a)
            {
                case >= 10:
                    break;
                case < 2:
                    break;
                default:
                {
                    switch (a)
                    {
                        case > 6:
                            break;
                        case <= 7:
                            break;
                    }

                    break;
                }
            }
        }
    }
}
