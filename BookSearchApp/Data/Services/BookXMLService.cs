using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookSearchApp.Data.Models;
using System.Data;
using System.IO;
using System.Xml.Linq;

namespace BookSearchApp.Data.Services
{
	public class BookXMLService : IBookService
	{
		private XElement data;

		public BookXMLService()
		{
			var xmlPath = Path.Combine(
				HttpContext.Current.Request.PhysicalApplicationPath,
				"App_Data", "books.xml");
			data = XElement.Load(xmlPath);
		}

		public List<Book> FindByTitle(string criteria)
		{
			return data.Descendants("book")
				.Where(e => criteria != null ? e.Element("title").Value.Contains(criteria) : true)
				.Select(b => new Book()
				{
					Author = b.Element("author").ToString(),
					Title = b.Element("title").ToString(),
					Genre = b.Element("genre").ToString(),
					Price = (decimal)b.Element("price"),
					PublishDate = (DateTime)b.Element("publish_date"),
					Description = b.Element("description").ToString()
				})
				.ToList();
		}
	}
}