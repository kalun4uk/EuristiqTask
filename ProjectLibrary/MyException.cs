using System;

namespace ProjectLibrary
{
    public class MyException : Exception
    {
        public MyException() : base() { }

        public MyException(double a) : base(String.Format("Incorrect calculation operation {0}", a))
        {}
    }
}
