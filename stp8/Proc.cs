using System;
using System.Collections.Generic;
using System.Text;

namespace stp8
{
    public class Proc<T> : TProc<T> where T : new()
    {
        public Proc() : base()
        {

        }
        public Proc(T lop_res, T rop) : base(lop_res, rop)
        {

        }
    }
}
