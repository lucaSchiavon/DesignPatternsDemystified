using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.BookIterator
{
    //the Concrete Aggregate
    public class BookCatalog : IAggregate<Book>
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IIterator<Book> CreateIterator()
        {
            return new BookIterator(_books);
        }
    }
}
