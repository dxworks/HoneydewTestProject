﻿namespace HoneydewTestProject.CyclomaticComplexity
{
    public class SwitchCyclo
    {
        public void Function(int a)
        {
            switch (a)
            {
                case 1: break;
                case 2: {break;}
                case 3: {}break;
                case 4:
                {
                    
                }break;
                case 6:
                default: break;
            }
        }
    }
}
