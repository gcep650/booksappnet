using System;
using BooksAppNet.Models;

namespace BooksAppNet.Services
{
	public interface IBooksService
	{
		/// <summary>
		/// Fetches the current list of books and updates the class property.
		/// </summary>
		/// <returns>Status of transaction. If true, book list was retrieved successfully.</returns>
		public Task<bool> GetBookList();

		/// <summary>
		/// Get the current list of books
		/// </summary>
		/// <returns>List of books</returns>
		public List<BookModel> GetBooks();

		/// <summary>
		/// Gets a single book by book ID
		/// </summary>
		/// <param name="bookId">Book ID</param>
		/// <returns>A single book</returns>
		public Task<BookModel> GetBookByID(int bookId);

		/// <summary>
		/// Adds a new book to the list
		/// </summary>
		/// <param name="book">New book</param>
		/// <returns>Status of transaction</returns>
		public Task<bool> AddBook(BookModel book);

		/// <summary>
		/// Updates an existing book
		/// </summary>
		/// <param name="updated">Updated book</param>
		/// <returns>If successful, returns the BookModel object</returns>
		public Task<BookModel> UpdateBook(BookModel updated);

		/// <summary>
		/// Deletes an existing book by book ID
		/// </summary>
		/// <param name="bookId">Book ID</param>
		/// <returns>Status of transaction</returns>
		public Task<bool> DeleteBook(int bookId);
	}
}

