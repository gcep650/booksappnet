using System;
namespace BooksAppNet.Models
{
	public class BookModel
	{
		public int BookId { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string Genre { get; set; }
		public int PageCount { get; set; }
		public DateTime PublishDate { get; set; }

		public BookModel()
		{
			this.BookId = 0;
			this.Title = "";
			this.Author = "";
			this.Genre = "";
			this.PageCount = 0;
			this.PublishDate = DateTime.Now;
		}

        public BookModel(int bookId, string title, string author, string genre, int pageCount, DateTime publishDate)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Genre = genre;
            PageCount = pageCount;
            PublishDate = publishDate;
        }

        public override string ToString()
        {
			return String.Format("Book ID {0}, Title: {1}", this.BookId, this.Title);
        }
    }
}

