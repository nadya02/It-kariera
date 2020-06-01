using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_For_Library
{
    class Book
    {
        public Book(string title, int year, params string[] authors)
            //params - позволява да не се въвежда и нщ
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; } //IReadOnlyList - не позволява допълнително въвеждане на автори отвън
    }
}
