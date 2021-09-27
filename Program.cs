using Exercises;
using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        delegate void TestDelegate(string s);

        static void Main(string[] args)
        {
            // How to use: anonimous method, lambda expression, built-in delegate 'action',
            // built-in delegate 'Func', c# exression
            Expressions.RunExamples(); 
        }
    }
}
