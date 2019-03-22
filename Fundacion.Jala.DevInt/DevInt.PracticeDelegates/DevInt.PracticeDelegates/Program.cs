using System;

namespace DevInt.PracticeDelegates
{
    class Program
    {
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
        }

        // Exercise 2
        // Write a delegate called Nullable that takes a generic argument of reference type and set that argument to null 
        public static void Exercise2()
        {

        }

        // Exercise 3
        // Write a delegate called Operation and three binary functions Add, Substract and Multiply
        // that takes two decimal numbers and return their sum, difference and product.
        // call the three funcions with a single delegate instance.
        public static void Exercise3()
        {

        }


        // Exercise 4
        // Write a delegate called IdentityF that takes an integer as parameter and returns a 
        // delegate that returns that number
        public static void Exercise4()
        {
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
