using System;

namespace MyClassLibary
{

    /// <summary>
    /// This class represents a book.
    /// It has 4 properties. Title, Author, Page number, ISBN13-number.
    /// </summary>
    public class Book
    {
        private string _title;
        private string _author;
        private int _pageNumber;
        private string _isbn13;


        public Book(string title, string author, int pageNumber, string isbn13)
        {
            //if (title.Length>1) { _title = title; }
            //else { throw new ArgumentException("The length of title has to be at least 2 characters long.");  }
            
            //_author = author;

            //if (pageNumber > 10 && pageNumber <= 1000) { _pageNumber = pageNumber; }
            //else{throw new ArgumentException("The number of pages must be between 10 and 1001"); }

            //if (isbn13.Length == 13) { _isbn13 = isbn13; }
            //else {throw new ArgumentException("The length of the ISBN13-number is not 13 character long."); }

            Title = title;
            Author = author;
            PageNumber = pageNumber;
            Isbn13 = isbn13;
        }


        public string Title
        {
            get => _title;
            set
            {
                if (value.Length>1)
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentException("The length of title has to be at least 2 characters long.");
                }
            }
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int PageNumber
        {
            get => _pageNumber;
            set
            {
                if (value>10 && value<=1000)
                {
                    _pageNumber = value;
                }
                else
                {
                    throw new ArgumentException("The number of pages must be between 10 and 1001");
                }
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length==13)
                {
                    _isbn13 = value;
                }
                else
                {
                    throw new  ArgumentException("The length of the ISBN13-number is not 13 character long.");
                }
            }
        }
    }
}
