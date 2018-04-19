using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Advanced_Topics.LINQ;

namespace C_Sharp_Advanced_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            //---Extension-Methods---

            //string post = "This is supposed to be a very long blog post blah blah blah...";
            //var shortenedPost = post.Shorten(5);
            //Console.WriteLine(shortenedPost);

            //---LINQ---

            //var books = new BookRepository().GetBooks();

            ////Query Operators
            ////find books cheaper than $10 sorted by title, project to title
            //var cheaperBooks = from b in books
            //    where b.Price < 10
            //    orderby b.Title
            //    select b.Title;

            ////Extension Methods
            ////same as above
            //var cheapBooks = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderBy(b => b.Title)
            //                    .Select(b => b.Title);

            ////skip the first two objects, and return the next three
            //var pagedBooks = books.Skip(2).Take(3);

            ////min-max-average-sum returns
            //var maxPrice = books.Max(b => b.Price);
            //var minPrice = books.Min(b => b.Price);
            //var totalPrices = books.Sum(b => b.Price);
            //var averagePrice = books.Average(b => b.Price);






        }
    }
}