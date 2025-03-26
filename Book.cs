using System;

namespace OOPs.LibraryManagement
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        public int AvailableCopies;

        public Book(string title, string author, string isbn, int copies)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
            AvailableCopies = copies;
        }

        public bool BorrowBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                return true;
            }
            return false;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {_title}, Author: {_author}, Available Copies: {AvailableCopies}");
        }

        public string GetTitle() => _title;
    }
}
