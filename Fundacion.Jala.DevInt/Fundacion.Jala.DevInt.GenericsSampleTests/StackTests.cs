using Fundacion.Jala.DevInt.GenericsSample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundacion.Jala.DevInt.GenericsSampleTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Test_Last_In_First_Out()
        {
            var stack = new IntStack();
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());

            var stringStack = new StringStack();
            stringStack.Push("ab");
            stringStack.Push("cd");
            Assert.AreEqual("cd", stringStack.Pop());
            Assert.AreEqual("ab", stringStack.Pop());
        }

        [TestMethod]
        public void Test_Covariance()
        {
            //var ebooks2 = new IntStack<EBook>();
            //IPopable<Book> books2 = ebooks2;
            
        }

        [TestMethod]
        public void Test_Contravariant()
        {
            //var books = new IntStack<Book>();
            //IPushable<EBook> ebooks = books;
        }
    }
}
