
// What is a multicast delegate in C#? 

// Delegate is one of the base types in .NET. 
// Delegate is a class that is used to create and invoke delegates at runtime.
// A delegate in C# allows developers to treat methods as objects and invoke them from their code.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
delegate void MDelegate();

class DM
{
    static public void Display()
    {
        Console.WriteLine("Denis");
    }
    static public void print()
    {
        Console.WriteLine("Rafi");
    }
}
class MTest
{
    public static void Main()
    {
        MDelegate m1 = new MDelegate(DM.Display);
        MDelegate m2 = new MDelegate(DM.print);
        MDelegate m3 = m1 + m2;
        MDelegate m4 = m2 + m1;
        MDelegate m5 = m3 - m2;
        m3();
        m4();
        m5();
    }
}