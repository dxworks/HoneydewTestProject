﻿using HoneydewTestProject.A;

namespace HoneydewTestProject
{
    public class ReferencesOnlyAUsingOutsideOfNamespace
    {
        public void Method(C1 c1Params)
        {
            var x = c1Params.X;
        }

        public C1 Type { get; set; }
    }
}