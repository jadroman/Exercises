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
            Expressions.RunExamples(); 
        }
    }
}
