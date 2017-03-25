using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
        public Context()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //This database initializer will drop the preexisting database and create a new one IF the existing model changes
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            //This is the default initializer that EF uses, once created you are unable to change the model
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
            //This will effectively restart your database EVERYTIME you run your app and is useful if you'd like to start the app from a known baseline every time
        }

        public DbSet<ComicBook> ComicBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            //modelBuilder.Conventions.Add(new DecimalPropertyConvention(5, 2));

            modelBuilder.Entity<ComicBook>()
                .Property(cb => cb.AverageRating)
                .HasPrecision(5, 2);
        }
    }
}
