using System;
using System.Text;
using BooksAppNet.Models;
using Newtonsoft.Json;

namespace BooksAppNet.Services
{
	public class BooksService : IBooksService
	{
        private List<BookModel> Books;
		private string apiUrl = "http://localhost:3000/books/";

		public BooksService()
		{
			// create initial blank list
			Books = new List<BookModel>();
			
		}

		public async Task<bool> GetBookList()
		{
			// create http client
            using (var http = new HttpClient())
            {
				// perform get request
                using (var response = await http.GetAsync(apiUrl))
				{
					string responseText = await response.Content.ReadAsStringAsync();

					this.Books = JsonConvert.DeserializeObject<List<BookModel>>(responseText);

					return Books != null;
				}

            }
        }

        public List<BookModel> GetBooks()
        {
            return Books;
        }

        public Task<BookModel> GetBookByID(int bookId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddBook(BookModel book)
        {
            using (var http = new HttpClient()) {

                StringContent content = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");

                using (var response = await http.PostAsync(apiUrl, content))
                {
                    return response.StatusCode == System.Net.HttpStatusCode.OK;
                }
            }
        }

        public Task<BookModel> UpdateBook(BookModel updated)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}

