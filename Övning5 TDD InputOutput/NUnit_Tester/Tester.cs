using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using FileHandler;
namespace NUnit_Tester
{
    [TestFixture]
    public class _FileTests
    {
        private string file = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\övning5.txt");

        [Test]
        public void _File_Should_Exists_After_Program_Starts()
        {
            File.Delete(file);
            Class1 class1 = new Class1();
            Assert.AreEqual(true, File.Exists(file));
        }
    }

    [TestFixture]
    class NameTests
    {
        private string file = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\övning5.txt");

        [Test]
        public void Names_Exist_In_File_After_They_Are_Inputed()
        {
            string firstName = "Michael";
            string lastName = "Wood";
            string fullname = string.Format("{0} {1}", firstName, lastName);
            Class1 class1 = new Class1();
            class1.Name(firstName, lastName);

            string content = File.ReadAllText(file);

            Assert.AreEqual(true, content.Contains(fullname));
        }
    }

    [TestFixture]
    class AdditionTests
    {
        private string file = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\övning5.txt");

        [Test]
        public void Addition_Gets_Added_To_The_Text_File()
        {
            Class1 class1 = new Class1();
            int firstNumber = 3;
            int secondNumber = 6;
            string expectedResult = string.Format("Addition: {0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);

            class1.Addition(firstNumber, secondNumber);

            string content = File.ReadAllText(file);

            Assert.AreEqual(true, content.Contains(expectedResult));
        }

        [Test]
        public void Addition_With_Negetive_Numbers_Should_Not_Be_Added_To_File()
        {
            Class1 class1 = new Class1();
            int firstNumber = 3;
            int secondNumber = -6;

            string contentBefore = File.ReadAllText(file);

            class1.Addition(firstNumber, secondNumber);

            string contentAfter = File.ReadAllText(file);

            Assert.AreEqual(contentBefore, contentAfter);
        }
    }

    [TestFixture]
    class SubtractionTests
    {
        private string file = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\övning5.txt");

        [Test]
        public void Subtraction_Gets_Added_To_The_Text_File()
        {
            Class1 class1 = new Class1();
            int firstNumber = 9;
            int secondNumber = 7;
            string expectedResult = string.Format("Subtraction: {0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);

            class1.Subtraction(firstNumber, secondNumber);

            string content = File.ReadAllText(file);

            Assert.AreEqual(true, content.Contains(expectedResult));
        }

        [Test]
        public void Subtraction_With_Negetive_Numbers_Should_Not_Be_Added_To_File()
        {
            Class1 class1 = new Class1();
            int firstNumber = 7;
            int secondNumber = -6;

            string contentBefore = File.ReadAllText(file);

            class1.Subtraction(firstNumber, secondNumber);

            string contentAfter = File.ReadAllText(file);

            Assert.AreEqual(contentBefore, contentAfter);
        }
    }

    [TestFixture]
    class MultiplicationTests
    {
        private string file = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\övning5.txt");

        [Test]
        public void Multiplication_Gets_Added_To_The_Text_File()
        {
            Class1 class1 = new Class1();
            int firstNumber = 8;
            int secondNumber = 3;
            string expectedResult = string.Format("Multiplication: {0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);

            class1.Multiplication(firstNumber, secondNumber);

            string content = File.ReadAllText(file);

            Assert.AreEqual(true, content.Contains(expectedResult));
        }

        [Test]
        public void Multiplication_With_Negetive_Numbers_Should_Not_Be_Added_To_File()
        {
            Class1 class1 = new Class1();
            int firstNumber = 8;
            int secondNumber = -3;

            string contentBefore = File.ReadAllText(file);

            class1.Multiplication(firstNumber, secondNumber);

            string contentAfter = File.ReadAllText(file);

            Assert.AreEqual(contentBefore, contentAfter);
        }
    }

    [TestFixture]
    class DivisionTests
    {
        private string file = string.Format("{0}{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\övning5.txt");

        [Test]
        public void Division_Gets_Added_To_The_Text_File()
        {
            Class1 class1 = new Class1();
            int firstNumber = 8;
            int secondNumber = 4;
            string expectedResult = string.Format("Division: {0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);

            class1.Division(firstNumber, secondNumber);

            string content = File.ReadAllText(file);

            Assert.AreEqual(true, content.Contains(expectedResult));
        }

        [Test]
        public void Division_With_Zero_Returns_Error()
        {
            Class1 class1 = new Class1();
            int firstNumber = 8;
            int secondNumber = 0;

            //Assert.Throws<ArgumentException>(() => class1.Division(firstNumber, secondNumber));

            try
            {
                class1.Division(firstNumber, secondNumber);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Cannot divide by zero", e.Message);
            }
        }
    }
}
