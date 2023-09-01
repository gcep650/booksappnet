using System;
using BooksAppNet.Models;
using Newtonsoft.Json;

namespace BooksAppNet.Services
{
	public class BooksService
	{
		public List<BookModel> Books { get; private set; }
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
	}
}

