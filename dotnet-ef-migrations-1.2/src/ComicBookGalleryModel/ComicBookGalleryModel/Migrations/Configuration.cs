namespace ComicBookGalleryModel.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ComicBookGalleryModel.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ComicBookGalleryModel.Data.Context context)
        {
            context.Roles.AddOrUpdate(
                r => r.Name,
                new Role() { Name = "Script", },
                new Role() { Name = "Pencils"}
                );
        }
    }
}
