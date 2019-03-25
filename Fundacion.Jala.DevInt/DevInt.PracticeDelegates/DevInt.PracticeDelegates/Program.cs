using System;

namespace DevInt.PracticeDelegates
{
    class Program
    {
        delegate T Identity<T>(T argument);
        delegate T Nullable<T>(T argument);
        delegate decimal Operation(decimal a, decimal b);
        delegate Func<int> IdentityF(int arg);
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
        }

        /**
         * For each exercise print the result in the console.
         * */

        // Exercise 1
        //Write a delegate called Identity that takes a generic argument returns that same argument.
        public static void Exercise1()
        {
            Identity<int> identityFunc = IdentityFunction;
            var result = identityFunc(5);
            Console.WriteLine(result);
        }

        static T IdentityFunction<T>(T argument)
        {
            return argument;
        }
        // Exercise 2
        // Write a delegate called Nullable that takes a generic argument of reference type and set that argument to null 
        public static void Exercise2()
        {
            Identity<string> identityFunc = IdentityFunction;
            var nullable = "nullableType";
            var result = identityFunc(nullable);
            Console.WriteLine(nullable);
        }

        static T NullableFunction<T>(T argument) where T : class
        {
            argument = null;
            return argument;
        }
        // Exercise 3
        // Write a delegate called Operation and three binary functions Add, Substract and Multiply
        // that takes two decimal numbers and return their sum, difference and product.
        // call the three funcions with a single delegate instance.
        public static void Exercise3()
        {
            Operation operations = Add;
            operations += Substract;
            operations += Multiply;
            Console.WriteLine(operations(2,3));
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Substract(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        // Exercise 4
        // Write a delegate called IdentityF that takes an integer as parameter and returns a 
        // delegate that returns that number
        // indentityFunc(2)()
        public static void Exercise4()
        {
            IdentityF identityFunc = IdentityFunction2;
            var result = identityFunc(7)();
            Console.WriteLine(result);
        }

        static Func<int> IdentityFunction2(int arg)
        {
            return () => arg;
            return delegate ()
            {
                return arg;
            };
        }
        // Exercise 5
        // Write a delegate that adds two decimals numbers from two invocations
        // e.g AddF(3)(4)
        // result should be = 7
        public static void Exercise5()
        {

        }

        // Exercise 6
        // Write a delegate Caller that takes a binary function and make it callable
        // with two invocations
        // Caller(Multiply)(5)(8) 
        // result should be = 40
        public static void Exercise6()
        {

        }


        // Exercise 7
        // Write a delegate Courier that takes a binary function and an decimal number
        // and returns a function that can take a second argument
        // Courier(Multiply, 5)(8) 
        // result should be = 40
        public static void Exercise7()
        {

        }

        /**
        * Send the Program.cs compressed on a file with your DelegatesNameLastName.zip
        * */
    }
}
