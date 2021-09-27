using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Expressions
    {
        delegate void TestDelegate(string s);

        public static void RunExamples()
        {
            // using anonimous method
            TestDelegate testDel1 = delegate (string s) { Console.WriteLine(s); };

            // using lambda expression
            TestDelegate testDel2 = (x) => { Console.WriteLine(x); };

            // built-in delegate 'action'
            Action<string> testDel3 = (x) => { Console.WriteLine(x); };

            // built-in delegate 'Func'
            Func<string, string> testDel4 = (x) => { return x; };

            // using c# exression (strongly typed lampda expression)
            Expression<Func<string, bool>> isSameStringExpr = s => s == "we use expression here";
            Func<string, bool> isSameString = isSameStringExpr.Compile();

            testDel1("using anonimous method");
            testDel2("using lambda expression");
            testDel3("built-in delegate 'action'");
            Console.WriteLine(testDel4("built-in delegate 'Func'"));
            Console.WriteLine($"result of 'isSameString' expression is: {isSameString("we use expression here")}");

        }
    }
}
