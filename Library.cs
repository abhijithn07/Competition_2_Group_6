using System;
using System.Collections.Generic;

namespace USF_Library_Management
{
    public class Library
    {
        public static void RunExample()
        {
            Console.WriteLine("Books in Library:");
            Book b1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book b2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book b3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);
            List<Book> books = new List<Book> { b1, b2, b3 };

            foreach (var b in books) b.DisplayInfo();

            Console.WriteLine("\nPatrons in Library:");
            Student s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student s2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            List<Person> patrons = new List<Person> { s1, s2, staff1 };

            foreach (var p in patrons) p.DisplayInfo();

            Console.WriteLine("\nBorrowing Books:");
            if (b2.BorrowBook()) Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");
            if (b3.BorrowBook()) Console.WriteLine("Akhil borrowed 'Analytics in Action'");

            Console.WriteLine("\nBooks in Library (After Borrowing):");
            foreach (var b in books) b.DisplayInfo();
        }
    }
}
