using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using AssemblyA;

[assembly: InternalsVisibleTo("AssemblyB")]

namespace AssemblyA
{
    public class MyClass
    {
        protected internal int protectedInternalField = 66;

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        Console.WriteLine("Accessing Protected Internal Field from Assembly B: " + myObject.protectedInternalField);
        myObject.ProtectedInternalMethod();
    }
}