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

                var comicBookId = 1;

                //var comicBook1 = context.ComicBooks.Find(comicBookId);
                //var comicBook2 = context.ComicBooks.Find(comicBookId);


                var comicBook1 = context.ComicBooks
                    .SingleOrDefault(cb => cb.Id == comicBookId);
                //SingleOrDefault - will search for a single result and throw error if more than one is found
                //FirstOrDefault - will search for the first result, no error thrown if more than one found as it will end it's search at the first one
                //Single - more strict than the other one, this will search for 1 result and throw an error if more than one or none are found
                //First - also more strict but maintains that it will end it's search at the first result, error is thrown if nothing is found



                var comicBook2 = context.ComicBooks
                    .SingleOrDefault(cb => cb.Id == comicBookId);


                //var comicBooks = context.ComicBooks
                //    //.Include(cb => cb.Series)
                //    //.Include(cb => cb.Artists.Select(a => a.Artist))
                //    //.Include(cb => cb.Artists.Select(a => a.Role))
                ////These 3 lines of code 'Eagerly' load all the related tables
                //    .ToList();
                //foreach (var comicBook in comicBooks)
                //{
                //    if (comicBook.Series == null)
                //    {
                //        context.Entry(comicBook)
                //            .Reference(cb => cb.Series)
                //            .Load();
                //    }
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
