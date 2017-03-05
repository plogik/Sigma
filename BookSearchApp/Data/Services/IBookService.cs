using BookSearchApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSearchApp.Data.Services
{
	public interface IBookService
	{
		List<Book> FindByTitle(string criteria);
	}
}
