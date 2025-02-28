using System;
using LibraryManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class LibraryTest
    {
        [TestMethod]
        public void TestAddBook()
        {
            Library library = new Library();
            var book = new Book("Atomic Habits", "James Clear", "123456");
            library.AddBook(book);

            Assert.AreEqual(1, library.Books.Count);
            Assert.AreEqual("Atomic Habits", library.Books[0].Title);
        }

        [TestMethod]
        public void TestRegisterBorrower()
        {
            Library library = new Library();
            var borrower = new Borrower("Max", "UID12");
            library.RegisterBorrower(borrower);

            Assert.AreEqual(1, library.Borrowers.Count);
            Assert.AreEqual("Max", library.Borrowers[0].Name);
        }

        [TestMethod]
        public void TestBorrowBook()
        {
            Library library = new Library();
            var book = new Book("Atomic Habits", "James Clear", "123456");
            var borrower = new Borrower("Max", "UID12");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123456", "UID12");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [TestMethod]
        public void TestReturnBook()
        {
            Library library = new Library();
            var book = new Book("Atomic Habits", "James Clear", "123456");
            var borrower = new Borrower("Max", "UID12");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123456", "UID12");
            library.ReturnBook("123456", "UID12");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        [TestMethod]
        public void TestViewBooksAndBorrowers()
        {
            Library library = new Library();
            var book = new Book("Atomic Habits", "James Clear", "123456");
            var borrower = new Borrower("Max", "UID12");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123456", "UID12");

            
            library.ViewBooks();
           
            library.ViewBorrowers();
        }
    }
}
