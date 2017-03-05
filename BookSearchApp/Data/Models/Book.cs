using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSearchApp.Data.Models
{
	public class Book
	{
		public string Author { get; set; }
		public string Title { get; set; }
		public string Genre { get; set; }
		public decimal Price { get; set; }
		public DateTime PublishDate { get; set; }
		public string Description { get; set; }

		public override string ToString()
		{
			return string.Format(
				"Author:{0}, Title:{1}, Genre:{2}, Published:{3}, Description:{4}",
				Author, Title, Genre, PublishDate, Description);
		}

		public override bool Equals(object obj)
		{
			return obj is Book &&
				((Book)obj).Author.Equals(Author) &&
				((Book)obj).Title.Equals(Title) &&
				((Book)obj).Genre.Equals(Genre) &&
				((Book)obj).Price.Equals(Price) &&
				((Book)obj).PublishDate.Equals(PublishDate) &&
				((Book)obj).Description.Equals(Description);
		}

		public override int GetHashCode()
		{
			var hash = 17;
			hash *= 31 + Author != null ? Author.GetHashCode() : 0;
			hash *= 31 + Title != null ? Title.GetHashCode() : 0;
			hash *= 31 + Genre != null ? Genre.GetHashCode() : 0;
			hash *= 31 + Price.GetHashCode();
			hash *= 31 + PublishDate.GetHashCode();
			hash *= 31 + Description != null ? Description.GetHashCode() : 0;
			return hash;
		}
	}
}