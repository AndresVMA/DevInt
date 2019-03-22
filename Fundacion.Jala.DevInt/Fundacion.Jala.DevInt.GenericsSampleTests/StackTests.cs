using Fundacion.Jala.DevInt.GenericsSample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Fundacion.Jala.DevInt.GenericsSampleTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void ScenarioContext()
        {
            var scenarioContext = new ScenarioContext<string>();
            scenarioContext.SetList<Book>(
                new List<Book>
                {
                    new Book(),
                    new Book(50),
                    new Book(80)
                });
            scenarioContext.SetList<Magazine>(
                new List<Book>
                {
                    new Magazine(60),
                    new Magazine(50),
                });
            var magazines = scenarioContext.GetList<Magazine>();
            var books = scenarioContext.GetList<Book>();
            Assert.AreEqual(2, magazines.Count);
            Assert.AreEqual(3, books.Count);
        }
        [TestMethod]
        public void TestCreate()
        {
            var objStack = new ObjectsStack();
            var newObj = objStack.CreateNew(typeof(Book));
        }

        [TestMethod]
        public void Conditionals()
        {
            for (int i = 0; i < 250; i++)
            {
                var x = i + i * 2;
            }
        }
        [TestMethod]
        public void Test_Last_In_First_Out()
        {
            var stack = new CustomStack<Book>();
            //var stack = new Stack<int>();
            //stack.Push(2);
            //stack.Push(3);
            //Assert.AreEqual(3, stack.Pop());
            //Assert.AreEqual(2, stack.Pop());

            //var stringStack = new Stack<string>();
            //stringStack.Push("ab");
            //stringStack.Push("cd");
            //Assert.AreEqual("cd", stringStack.Pop());
            //Assert.AreEqual("ab", stringStack.Pop());
        }

        [TestMethod]
        public void Test_Covariance()
        {
            var ebooks2 = new CustomStack<EBook>();
            ebooks2.Push(new EBook(6));
            //Stack<Book> popable = ebooks2;
            //var ebook = popable.Pop();

            //Book[] booksArray = ebooksArray;
            //booksArray[1] = new Magazine(100);
        }

        [TestMethod]
        public void Test_Contravariant()
        {
            var books = new CustomStack<Book>();
            //Stack<EBook> ebooks = books;
            //ebooks.Push(new EBook());
            //ebooks.Push(new Magazine());
        }
    }
}
