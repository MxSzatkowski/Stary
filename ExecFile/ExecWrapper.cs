using System;
using System.Collections.Generic;
using System.Text;
using Wrapper;

namespace ExecFile
{
    public class ExecWrapper
    {
        public int UseWrapperMethod()
        {
            var wrap = new CPlusPlusWraper();
            return wrap.UseAddNumbers(10,20);
        }

    }
}
