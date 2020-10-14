using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibary;

namespace TestProject
{
    [TestClass]
    public class BookTest
    {
        [DataTestMethod]
        [DataRow("The Lord of the Rings", "J. R. R. Tolkien", 9450, "1234ABCD12387")]
        [DataRow("Harry Potter", "J. K. Rowling", 1450, "1234ABCD12FE5")]
        [ExpectedException(typeof(ArgumentException), "The number of pages must be between 10 and 1001")]
        public void TestBookWithIncorrectPageInput(string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title,author,pageNumber,isbn13);
        }

        [DataTestMethod]
        [DataRow("IT", "Stephen Kings", 674, "1234ABCD12FE5D")]
        [ExpectedException(typeof(ArgumentException), "The length of the ISBN13-number is not 13 character long.")]
        public void TestBookWithIncorrectIsbn13Input(string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);
        }

        [DataTestMethod]
        [DataRow("A", "Stephen Kings", 674, "1234ABCD12FE5")]
        [ExpectedException(typeof(ArgumentException), "The length of title has to be at least 2 characters long.")]
        public void TestBookWithIncorrectTitleInput(string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);
        }

        [DataTestMethod]
        [DataRow("IT", "Stephen Kings", 674, "1234ABCD12FE5",9)]
        [DataRow("Harry Potter", "J. K. Rowling", 789, "1234ABCD12FE5",1004)]
        [ExpectedException(typeof(ArgumentException), "The number of pages must be between 10 and 1001")]
        public void TestChangeBookPages(string title, string author, int pageNumber, string isbn13, int newPageNumber)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);

            //Act
            TestBook.PageNumber = newPageNumber;

        }


        [DataTestMethod]
        [DataRow("IT", "Stephen Kings", 674, "1234ABCD12FE5", "N")]
        [ExpectedException(typeof(ArgumentException), "The length of title has to be at least 2 characters long.")]
        public void TestChangeBookTitle(string title, string author, int pageNumber, string isbn13, string newTitle)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);

            //Act
            TestBook.Title = newTitle;

        }

        [DataTestMethod]
        [DataRow("IT", "Stephen Kings", 674, "1234ABCD12FE5")]
        public void TestChangeBookAuthor(string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);

            //Act
            TestBook.Author = "Mama";

        }

        [DataTestMethod]
        [DataRow("IT", "Stephen Kings", 674, "1234ABCD12FE5")]
        public void TestChangeBookPageNumberWithCorrectData(string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);

            //Act
            TestBook.PageNumber = 15;

        }


        [DataTestMethod]
        [DataRow("IT","IT", "Stephen Kings", 674, "1234ABCD12FE5")]
        public void TestBookGetTitle(string expectedResult,string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);

            //Act
            string actualResult = TestBook.Title;

            //assert
            Assert.AreEqual(expectedResult,actualResult);
        }


        [DataTestMethod]
        [DataRow("Stephen Kings", "IT", "Stephen Kings", 234 , "1234ABCD12FE5")]
        public void TesteGetAuthor(string expectedResult, string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);

            //Act
            string actualResult = TestBook.Author;

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [DataTestMethod]
        [DataRow("1234ABCD12FE5", "IT", "Stephen Kings", 234, "1234ABCD12FE5")]
        public void TesteGetIsbn13(string expectedResult, string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);

            //Act
            string actualResult = TestBook.Isbn13;

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [DataTestMethod]
        [DataRow(234, "IT", "Stephen Kings", 234, "1234ABCD12FE5")]
        public void TesteGetPageNumber(int expectedResult, string title, string author, int pageNumber, string isbn13)
        {
            //Arrange
            Book TestBook = new Book(title, author, pageNumber, isbn13);

            //Act
            int actualResult = TestBook.PageNumber;

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }




    }
}
