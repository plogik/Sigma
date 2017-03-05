using BookSearchApp.Data.Models;
using BookSearchApp.Data.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace BookSearchApp.Controllers
{
    public class BooksController : ApiController
    {
		private IBookService bookService;

		public BooksController(IBookService bookService)
		{
			this.bookService = bookService;
		}

		[HttpGet]
        [Route("books/bytitle/{criteria?}")]
        public IEnumerable<Book> FindByTitle(string criteria = null)
        {
			return bookService.FindByTitle(criteria);
        }
    }
}
