using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace BooksAppNet.Models
{
	public class BookModel
	{
		[DisplayName("Book ID")]
        [JsonProperty("book_id")]
		public int BookId { get; set; }

		[DisplayName("Title")]
        [JsonProperty("title")]
		[StringLength(70, MinimumLength = 2)]
		public string Title { get; set; }

		[DisplayName("Author")]
		[JsonProperty("author")]
		[StringLength(70, MinimumLength = 2)]
		public string Author { get; set; }

		[DisplayName("Genre")]
		[JsonProperty("genre")]
		[StringLength(45, MinimumLength = 2)]
		public string Genre { get; set; }

		[DisplayName("Page Count")]
		[JsonProperty("page_count")]
		[Range(1, 25000)]
		public int PageCount { get; set; }

		[DisplayName("Publication Date")]
		[JsonProperty("publish_date")]
		[DataType(DataType.Date)]
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

