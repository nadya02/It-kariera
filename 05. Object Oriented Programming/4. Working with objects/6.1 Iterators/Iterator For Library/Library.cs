using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_For_Library
{
    class Library : IEnumerable<Book>
    {
        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public void Dispose() { }
            public bool MoveNext()
                => ++this.currentIndex < this.books.Count;
            public void Reset() => this.currentIndex = -1;
            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;
        }


        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            /*foreach (var item in books)
            {
                yield return item;
            }*/
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
