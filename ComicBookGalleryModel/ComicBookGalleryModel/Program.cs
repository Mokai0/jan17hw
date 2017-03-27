using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;

namespace ComicBookGalleryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.Database.Log = (message) => Debug.WriteLine(message);

                //var comicBooks = context.ComicBooks.ToList();

                var comicBooksQuery = from cb in context.ComicBooks select cb;
                var comicBooks = comicBooksQuery
                    .Include(cb => cb.Series)
                    .Where(cb => cb.Series.Title.Contains("man"))
                    //.Where(cb => cb.IssueNumber == 1 &&
                    //      cb.Series.Title == "The Amazing Spider-Man")
                    //.Where(cb => cb.IssueNumber == 1 ||
                    //      cb.Series.Title == "The Amazing Spider-Man")
                    .OrderByDescending(cb => cb.IssueNumber)
                    //.OrderBy(cb => cb.PublishedOn)
                    //You can't stack OrderBy calls, only the last one will run
                    .ThenBy(cb => cb.PublishedOn)
                    .ToList();

                foreach (var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.DisplayText);
                }

                Console.WriteLine();
                Console.WriteLine("# of comic books: {0}", comicBooks.Count);

                //var comicBooks = context.ComicBooks
                //    .Include(cb => cb.Series)
                //    .Include(cb => cb.Artists.Select(a => a.Artist))
                //    .Include(cb => cb.Artists.Select(a => a.Role))
                //    .ToList();
                //foreach (var comicBook in comicBooks)
                //{
                //    var artistRoleNames = comicBook.Artists
                //        .Select(a => $"{a.Artist.Name} - {a.Role.Name}").ToList();
                //    var artistRolesDisplayText = string.Join(", ", artistRoleNames);

                //    Console.WriteLine(comicBook.DisplayText);
                //    Console.WriteLine(artistRolesDisplayText);
                //}

                Console.ReadLine();
            }
        }
    }
}
