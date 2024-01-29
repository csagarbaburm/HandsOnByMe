using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Book
    {
        public int bookId;
        public string bookName;
        public string language;
        public int price;
        public string author;
        public string publisher;
        public string[] stds;
    }
    class BookRepository
    {
        public Book[] books = new Book[15];
        public int idx = 0;
        public void AddBook(Book book) //Adding new book details
        {
            //add book details to array
            if (idx <= books.Length)
            {
                books[idx] = book;
                idx++;
            }
            else
            {
                Console.WriteLine("store is Full!!!");
            }
        } 
    }
    public Teacher GetBook(int id) //get book details with name
    {
        foreach (Book book in books)
        {
            if ((book != null))
            {
                if (book.Id == id)
                {
                    return book;
                }
                //else
                //    return null;
            }

        }
        return null; //when book not exist with given name
    }
}
