using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.BookIterator
{
    //the Concrete Iterator
    public class BookIterator : IIterator<Book>
    {
        private List<Book> _books;
        private int _position = 0;

        public BookIterator(List<Book> books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _position < _books.Count;
        }

        public Book Next()
        {
            if (HasNext())
            {
                Book nextBook = _books[_position];
                _position++;
                return nextBook;
            }
            else
            {
                return null;
            }
        }
    }
}
