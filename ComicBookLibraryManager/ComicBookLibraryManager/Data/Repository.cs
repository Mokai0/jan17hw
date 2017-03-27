using ComicBookLibraryManager.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace ComicBookLibraryManager.Data
{
    /// <summary>
    /// Repository class that provides various database queries
    /// and CRUD operations.
    /// </summary>
    public static class Repository
    {
        /// <summary>
        /// Private method that returns a database context.
        /// </summary>
        /// <returns>An instance of the Context class.</returns>
        static Context GetContext()
        {
            var context = new Context();
            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }

        /// <summary>
        /// Returns a count of the comic books.
        /// </summary>
        /// <returns>An integer count of the comic books.</returns>
        public static int GetComicBookCount()
        {
            using (Context context = GetContext())
            {
                return context.ComicBooks.Count();
            }
        }

        /// <summary>
        /// Returns a list of comic books ordered by the series title 
        /// and issue number.
        /// </summary>
        /// <returns>An IList collection of ComicBook entity instances.</returns>
        public static IList<ComicBook> GetComicBooks()
        {
            using (Context context = GetContext())
            {
                return context.ComicBooks
                    .Include(cb => cb.Series)
                    .OrderBy(cb => cb.Series.Title)
                    .ThenBy(cb => cb.IssueNumber)
                    .ToList();
            }
        }

        /// <summary>
        /// Returns a single comic book.
        /// </summary>
        /// <param name="comicBookId">The comic book ID to retrieve.</param>
        /// <returns>A fully populated ComicBook entity instance.</returns>
        public static ComicBook GetComicBook(int comicBookId)
        {
            using (Context context = GetContext())
            {
                return context.ComicBooks
                    .Include(cb => cb.Series)
                    .Include(cb => cb.Artists.Select(a => a.Artist))
                    .Include(cb => cb.Artists.Select(a => a.Role))
                    .Where(cb => cb.Id == comicBookId)
                    .SingleOrDefault();
            }
        }

        /// <summary>
        /// Returns a list of series ordered by title.
        /// </summary>
        /// <returns>An IList collection of Series entity instances.</returns>
        public static IList<Series> GetSeries()
        {
            using (Context context = GetContext())
            {
                return context.Series
                    .OrderBy(s => s.Title)
                    .ToList();
            }
        }

        /// <summary>
        /// Returns a single series.
        /// </summary>
        /// <param name="seriesId">The series ID to retrieve.</param>
        /// <returns>A Series entity instance.</returns>
        public static Series GetSeries(int seriesId)
        {
            using (Context context = GetContext())
            {
                return context.Series
                    .Where(s => s.Id == seriesId)
                    .SingleOrDefault();
            }
        }

        /// <summary>
        /// Returns a list of artists ordered by name.
        /// </summary>
        /// <returns>An IList collection of Artist entity instances.</returns>
        public static IList<Artist> GetArtists()
        {
            using (Context context = GetContext())
            {
                return context.Artists
                    .OrderBy(a => a.Name)
                    .ToList();
            }
        }

        /// <summary>
        /// Returns a list of roles ordered by name.
        /// </summary>
        /// <returns>An IList collection of Role entity instances.</returns>
        public static IList<Role> GetRoles()
        {
            using (Context context = GetContext())
            {
                return context.Roles
                    .OrderBy(r => r.Name)
                    .ToList();
            }
        }

        /// <summary>
        /// Adds a comic book.
        /// </summary>
        /// <param name="comicBook">The ComicBook entity instance to add.</param>
        public static void AddComicBook(ComicBook comicBook)
        {
            using (Context context = GetContext())
            {
                if (comicBook.Series != null && comicBook.Series.Id > 0)
                {
                    context.Entry(comicBook.Series).State = EntityState.Unchanged;
                }

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates a comic book.
        /// </summary>
        /// <param name="comicBook">The ComicBook entity instance to update.</param>
        public static void UpdateComicBook(ComicBook comicBook)
        {
            using (Context context = GetContext())
            {
                //ComicBook comicBookToUpdate = context.ComicBooks.Find(comicBook.Id);
                //context.Entry(comicBookToUpdate).CurrentValues.SetValues(comicBook);
                //While this method is useful it requires 2 seperat queries to update the desired info

                context.ComicBooks.Attach(comicBook);
                var comicBookEntry = context.Entry(comicBook);
                comicBookEntry.State = EntityState.Modified;
                //comicBookEntry.Property("IssueNumber").IsModified = false;
                //This line of code is particularly useful because it allows you to specify bits of data that you'd like to prevent any changes to - preventing an unecessary query to be made

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes a comic book.
        /// </summary>
        /// <param name="comicBookId">The comic book ID to delete.</param>
        public static void DeleteComicBook(int comicBookId)
        {
            using (Context context = GetContext())
            {
                ComicBook comicBook = context.ComicBooks.Find(comicBook.Id);
                context.ComicBooks.Remove(comicBook);

                context.SaveChanges();
            }
        }
    }
}
