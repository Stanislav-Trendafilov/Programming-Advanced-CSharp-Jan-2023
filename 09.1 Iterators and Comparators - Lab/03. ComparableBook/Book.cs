using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book:IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            if (this.Year < other.Year)
            {
                return -1;
            }
            else if (this.Year == other.Year)
            {
                return Title.CompareTo(other.Title);
            }
            return 1;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";

        }
    }
}
