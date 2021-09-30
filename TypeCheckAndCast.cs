using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class TypeCheckAndCast
    {

        public class Base { }

        public class Derived : Base { }

        /// <summary>
        /// "is" operator checks if the run-time type of an expression is compatible with a given type
        /// </summary>
        public static void IsOperator()
        {
            object b = new Base();
            Console.WriteLine(b is Base);  // output: True
            Console.WriteLine(b is Derived);  // output: False

            object d = new Derived();
            Console.WriteLine(d is Base);  // output: True
            Console.WriteLine(d is Derived); // output: True

            var i = 23;
            object iBoxed = i;
            int? jNullable = 7;

            if (iBoxed is int g && jNullable is int e)
            {
                Console.WriteLine(g + e);  // output 30
            }
        }

        /// <summary>
        /// "as" operator is used to perform conversion between compatible reference types or Nullable types. 
        /// This operator returns the object when they are compatible with the given type and return null if 
        /// the conversion is not possible instead of raising an exception. 
        /// Only for reference types
        /// </summary>
        public static void AsOperator()
        {
            IEnumerable<int> numbers = new[] { 10, 20, 30 };
            IList<int> indexable = numbers as IList<int>;

            if (indexable != null)
            {
                Console.WriteLine(indexable[0] + indexable[indexable.Count - 1]);  // output: 40
            }
        }

        /// <summary>
        /// expl. conversion
        /// If cant convert, shows compile-time errors or run-time exception
        /// </summary>
        public static void ExplicitCast()
        {
            double x = 1234.7;
            int a = (int)x;
            Console.WriteLine(a);   // output: 1234

            IEnumerable<int> numbers = new int[] { 10, 20, 30 };
            IList<int> list = (IList<int>)numbers;
            Console.WriteLine(list.Count);  // output: 3
            Console.WriteLine(list[1]);  // output: 20
        }

        /// <summary>
        /// "typeof" is an operator to obtain a type known at compile-time
        /// </summary>
        public static void TypeOf()
        {
            void PrintType<T>() => Console.WriteLine(typeof(T));

            Console.WriteLine(typeof(List<string>));
            PrintType<int>();
            PrintType<System.Int32>();
            PrintType<Dictionary<int, char>>();
            // Output:
            // System.Collections.Generic.List`1[System.String]
            // System.Int32
            // System.Int32
            // System.Collections.Generic.Dictionary`2[System.Int32,System.Char]
        }

        /// <summary>
        /// "GetType" to get "execution-time" type of the objec
        /// </summary>
        public static void GetType()
        {
            Base myBase = new Base();
            Derived myDerived = new Derived();
            object o = myDerived;
            Base b = myDerived;

            Console.WriteLine("mybase: Type is {0}", myBase.GetType());
            Console.WriteLine("myDerived: Type is {0}", myDerived.GetType());
            Console.WriteLine("object o = myDerived: Type is {0}", o.GetType());
            Console.WriteLine("MyBaseClass b = myDerived: Type is {0}", b.GetType());
        }
    }
}
