using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Advanced_Topics.Exception_Handling;
using C_Sharp_Advanced_Topics.LINQ;

namespace C_Sharp_Advanced_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExtensionMethods();
            //Linq();
            //NullableTypes();
            ExceptionHandling();
        }

        private static void ExceptionHandling()
        {
            //using includes a built in finally block that releases the resource when scope is released
            //using (var streamReader = new StreamReader(@"c:\file.zip"))
            //{
            //    var content = streamReader.ReadToEnd();
            //}

            //using a custom exception
            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ExtensionMethods()
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);
        }

        static void Linq()
        {
            var books = new BookRepository().GetBooks();

            //Query Operators
            //find books cheaper than $10 sorted by title, project to title
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            //Extension Methods
            //same as above
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            //skip the first two objects, and return the next three
            var pagedBooks = books.Skip(2).Take(3);

            //min-max-average-sum returns
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrices = books.Sum(b => b.Price);
            var averagePrice = books.Average(b => b.Price);

            Console.WriteLine(averagePrice);
        }

        static void NullableTypes()
        {
            DateTime? date = null;

            //DateTime date2;
            //if (date != null)
            //{
            //    date2 = date.GetValueOrDefault();
            //}
            //else
            //{
            //    date2 = DateTime.Today;
            //}

            //above statement written as ternary expression
            DateTime date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            //Using Null coalescing operator - equal to above statement
            DateTime date3 = date ?? DateTime.Today;

        }
    }
}